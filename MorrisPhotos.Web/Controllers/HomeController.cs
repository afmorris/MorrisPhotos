using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MorrisPhotos.Web.DataModels;
using MorrisPhotos.Web.DataModels.Comparers;
using MorrisPhotos.Web.Extensions;
using MorrisPhotos.Web.ViewModels;
using MorrisPhotos.Web.ViewModels.Home;
using ServiceStack;
using ServiceStack.Mvc;
using ServiceStack.OrmLite;

namespace MorrisPhotos.Web.Controllers
{
    public class HomeController : ServiceStackController
    {
        public IActionResult Index()
        {
            return View();
        }

        [Microsoft.AspNetCore.Mvc.Route("school-year/{schoolYearName}")]
        public IActionResult SchoolYearDetails(string schoolYearName)
        {
            var schoolYear = Db.Single<SchoolYear>(x => x.Name == schoolYearName);
            var photoEvents = Db.LoadSelect<PhotoEvent>(x => x.SchoolYearId == schoolYear.Id);
            var categories = photoEvents.Select(x => x.Category).Distinct().ToList();

            var vm = new SchoolYearDetailsViewModel
            {
                SchoolYear = schoolYear,
                Categories = categories
            };

            return View(vm);
        }

        [Microsoft.AspNetCore.Mvc.Route("school-year/{schoolYearName}/category/{categoryName}")]
        public IActionResult SchoolYearAndCategoryDetails(string schoolYearName, string categoryName)
        {
            var schoolYear = Db.Single<SchoolYear>(x => x.Name == schoolYearName);
            var category = Db.Single<Category>(x => x.UrlName == categoryName);
            var photoEvents = Db.Select<PhotoEvent>(x => x.SchoolYearId == schoolYear.Id && x.CategoryId == category.Id);

            var vm = new SchoolYearAndCategoryDetailsViewModel
            {
                SchoolYear = schoolYear,
                Category = category,
                PhotoEvents = photoEvents
            };

            return View(vm);
        }

        [Microsoft.AspNetCore.Mvc.Route("school-year/{schoolYearName}/category/{categoryName}/event/{eventName}")]
        public IActionResult SchoolYearAndCategoryAndEventDetails(string schoolYearName, string categoryName, string eventName)
        {
            if (schoolYearName.IsNullOrEmpty() || categoryName.IsNullOrEmpty() || eventName.IsNullOrEmpty())
            {
                return BadRequest();
            }

            var schoolYear = Db.Single<SchoolYear>(x => x.Name == schoolYearName);

            if (schoolYear == null)
            {
                return NotFound(schoolYearName);
            }

            var category = Db.Single<Category>(x => x.UrlName == categoryName);

            if (category == null)
            {
                return NotFound(categoryName);
            }

            var photoEvent = Db.Single<PhotoEvent>(x => x.UrlName == eventName && x.SchoolYearId == schoolYear.Id && x.CategoryId == category.Id);

            if (photoEvent == null)
            {
                return NotFound(eventName);
            }

            var photos = Db.Select<Photo>(x => x.PhotoEventId == photoEvent.Id);

            foreach (var photo in photos)
            {
                var peoplePhotos = Db.Select<PersonPhoto>(x => x.PhotoId == photo.Id);
                foreach (var personPhoto in peoplePhotos)
                {
                    var person = Db.Single<Person>(x => x.Id == personPhoto.PersonId);
                    photo.People.Add(person);
                }
            }

            var vm = new SchoolYearAndCategoryAndEventDetailsViewModel
            {
                SchoolYear = schoolYear,
                Category = category,
                PhotoEvent = photoEvent,
                Photos = photos
            };

            return View(vm);
        }

        [Microsoft.AspNetCore.Mvc.Route("category/{categoryName}")]
        public IActionResult CategoryDetails(string categoryName)
        {
            var category = Db.Single<Category>(x => x.UrlName == categoryName);
            var photoEvent = Db.LoadSelect<PhotoEvent>(x => x.CategoryId == category.Id);
            var schoolYears = photoEvent.Select(x => x.SchoolYear).Distinct().ToList();

            var vm = new CategoryDetailsViewModel
            {
                Category = category,
                SchoolYears = schoolYears
            };

            return View(vm);
        }

        [Microsoft.AspNetCore.Mvc.Route("events")]
        public IActionResult Events()
        {
            var vm = new EventsViewModel();

            return View(vm);
        }

        [Microsoft.AspNetCore.Mvc.Route("people")]
        public IActionResult People()
        {
            var query = Db.From<PersonPhoto>().Select(x => x.PersonId);
            var peopleIds = Db.ColumnDistinct<int>(query);
            var people = new List<Person>();

            foreach (var personId in peopleIds)
            {
                people.Add(Db.Single<Person>(x => x.Id == personId));
            }

            people.Sort(new PersonComparer());

            var vm = new PeopleViewModel
            {
                People = people
            };

            return View(vm);
        }

        [Microsoft.AspNetCore.Mvc.Route("people/{personId}/{personName}")]
        public IActionResult PersonDetails(int personId, string personName)
        {
            var person = Db.Single<Person>(x => x.Id == personId);
            var personPhotos = Db.Select<PersonPhoto>(x => x.PersonId == personId);
            var photos = new List<Photo>();

            foreach (var personPhoto in personPhotos)
            {
                photos.Add(Db.Single<Photo>(x => x.Id == personPhoto.PhotoId));
            }

            foreach (var photo in photos)
            {
                var peoplePhotos = Db.Select<PersonPhoto>(x => x.PhotoId == photo.Id);
                foreach (var personPhoto in peoplePhotos)
                {
                    var p = Db.Single<Person>(x => x.Id == personPhoto.PersonId);
                    photo.People.Add(p);
                }
            }

            var vm = new PersonDetailsViewModel
            {
                Person = person,
                Photos = photos
            };

            return View(vm);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
