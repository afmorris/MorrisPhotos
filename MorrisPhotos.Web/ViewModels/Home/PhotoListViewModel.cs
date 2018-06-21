using System.Collections.Generic;
using MorrisPhotos.Web.DataModels;

namespace MorrisPhotos.Web.ViewModels.Home
{
    public class PhotoListViewModel
    {
        public Dictionary<SchoolYear, Dictionary<Category, Dictionary<PhotoEvent, List<Photo>>>> Photos { get; set; } = new Dictionary<SchoolYear, Dictionary<Category, Dictionary<PhotoEvent, List<Photo>>>>();
    }
}