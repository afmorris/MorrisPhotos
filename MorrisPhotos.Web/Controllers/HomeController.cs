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
            var output = new Dictionary<SchoolYear, Dictionary<Category, List<PhotoEvent>>>();
            var photoEvents = Db.LoadSelect<PhotoEvent>();
            var events = photoEvents.GroupBy(x => x.SchoolYear).ToDictionary(x => x.Key, x => x.ToList());
            foreach (var group in events)
            {
                var categoryGrouping = group.Value.GroupBy(x => x.Category).ToDictionary(x => x.Key, x => x.ToList());
                output[group.Key] = categoryGrouping;
            }

            var vm = new EventsViewModel
            {
                Events = output
            };

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

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("phototag")]
        public IActionResult PhotoTag()
        {
            var people = Db.Select<Person>();
            var photos = Db.LoadSelect<Photo>();
            foreach (var photo in photos)
            {
                Db.LoadReferences(photo.PhotoEvent);
            }

            var vm = new PhotoTagViewModel
            {
                People = people,
                Photos = photos
            };

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Microsoft.AspNetCore.Mvc.Route("phototag")]
        public IActionResult PhotoTag(PhotoTagViewModel viewModel)
        {
            var personPhoto = new PersonPhoto
            {
                PersonId = viewModel.PersonId,
                PhotoId = viewModel.PhotoId
            };

            Db.Insert(personPhoto);

            return View();
        }

        [Microsoft.AspNetCore.Mvc.Route("photolist")]
        public IActionResult PhotoList()
        {
            var photos = Db.LoadSelect<Photo>();
            foreach (var photo in photos)
            {
                Db.LoadReferences(photo.PhotoEvent);
            }

            var data = new Dictionary<SchoolYear, Dictionary<Category, Dictionary<PhotoEvent, List<Photo>>>>();

            var schoolYearGroups = photos.GroupBy(x => x.PhotoEvent.SchoolYear).ToDictionary(x => x.Key, x => x.ToList());
            foreach (var schoolYearGroup in schoolYearGroups)
            {
                var schoolYearData = new Dictionary<Category, Dictionary<PhotoEvent, List<Photo>>>();
                var categoryGroups = schoolYearGroup.Value.GroupBy(x => x.PhotoEvent.Category).ToDictionary(x => x.Key, x => x.ToList());

                foreach (var categoryGroup in categoryGroups)
                {
                    var categoryData = new Dictionary<PhotoEvent, List<Photo>>();
                    var photoEventGroups = categoryGroup.Value.GroupBy(x => x.PhotoEvent).ToDictionary(x => x.Key, x => x.ToList());

                    foreach (var photoEventGroup in photoEventGroups)
                    {
                        categoryData[photoEventGroup.Key] = photoEventGroup.Value;
                    }

                    schoolYearData[categoryGroup.Key] = categoryData;
                }

                data[schoolYearGroup.Key] = schoolYearData;
            }

            var vm = new PhotoListViewModel
            {
                Photos = data
            };

            return View(vm);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
