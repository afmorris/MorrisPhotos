using System.Diagnostics;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using MorrisPhotos.Web.DataModels;
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
            var vm = new PeopleViewModel();

            return View(vm);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
