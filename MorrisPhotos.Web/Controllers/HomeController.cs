using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MorrisPhotos.Web.DataModels;
using MorrisPhotos.Web.ViewModels;
using MorrisPhotos.Web.ViewModels.Home;
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

        [Route("school-year/{schoolYear}")]
        public IActionResult SchoolYearDetails(string schoolYear)
        {
            var vm = new SchoolYearDetailsViewModel
            {
                SchoolYear = Db.Single<SchoolYear>(x => x.Name == schoolYear),
                Categories = Db.Select<Category>().OrderBy(x => x.Id).ToList()
            };

            return View(vm);
        }

        [Route("school-year/{schoolYear}/category/{categoryName}")]
        public IActionResult SchoolYearAndCategoryDetails(string schoolYear, string categoryName)
        {
            var vm = new SchoolYearAndCategoryDetailsViewModel
            {
                SchoolYear = Db.Single<SchoolYear>(x => x.Name == schoolYear),
                Category = Db.Single<Category>(x => x.UrlName == categoryName)
            };

            vm.Events = Db.Select<PhotoEvent>(x => x.SchoolYearId == vm.SchoolYear.Id && x.CategoryId == vm.Category.Id);

            return View(vm);
        }

        [Route("school-year/{schoolYear}/category/{categoryName}/event/{eventName}")]
        public IActionResult SchoolYearAndCategoryAndEventDetails(string schoolYear, string categoryName, string eventName)
        {
            var vm = new SchoolYearAndCategoryAndEventDetailsViewModel
            {
                SchoolYear = Db.Single<SchoolYear>(x => x.Name == schoolYear),
                Category = Db.Single<Category>(x => x.UrlName == categoryName),
                PhotoEvent = Db.Single<PhotoEvent>(x => x.UrlName == eventName)
            };

            return View(vm);
        }

        [Route("category/{categoryName}")]
        public IActionResult CategoryDetails(string categoryName)
        {
            var vm = new CategoryDetailsViewModel
            {
                Category = Db.Single<Category>(x => x.UrlName == categoryName)
            };

            return View(vm);
        }

        [Route("events")]
        public IActionResult Events()
        {
            var vm = new EventsViewModel();

            return View(vm);
        }

        [Route("people")]
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
