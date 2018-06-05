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
            var vm = new IndexViewModel
            {
                SchoolYears = Db.Select<SchoolYear>().OrderBy(x => x.Name).ToList()
            };

            return View(vm);
        }

        [Route("{schoolYear}")]
        public IActionResult SchoolYearDetails(string schoolYear)
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
