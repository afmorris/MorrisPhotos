using System.Collections.Generic;
using MorrisPhotos.Web.DataModels;

namespace MorrisPhotos.Web.ViewModels.Home
{
    public class SchoolYearAndCategoryDetailsViewModel
    {
        public SchoolYear SchoolYear { get; set; }
        public Category Category { get; set; }
        public List<PhotoEvent> PhotoEvents { get; set; } = new List<PhotoEvent>();
    }
}