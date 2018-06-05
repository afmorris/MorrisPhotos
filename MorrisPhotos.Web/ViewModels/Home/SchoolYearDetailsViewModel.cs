using System.Collections.Generic;
using MorrisPhotos.Web.DataModels;

namespace MorrisPhotos.Web.ViewModels.Home
{
    public class SchoolYearDetailsViewModel
    {
        public SchoolYear SchoolYear { get; set; }
        public List<Category> Categories { get; set; }
    }
}