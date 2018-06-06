using System.Collections.Generic;
using MorrisPhotos.Web.DataModels;

namespace MorrisPhotos.Web.ViewModels.Home
{
    public class SchoolYearAndCategoryAndEventDetailsViewModel
    {
        public SchoolYear SchoolYear { get; set; }
        public Category Category { get; set; }
        public PhotoEvent PhotoEvent { get; set; }
        public List<Photo> Photos { get; set; } = new List<Photo>();
    }
}