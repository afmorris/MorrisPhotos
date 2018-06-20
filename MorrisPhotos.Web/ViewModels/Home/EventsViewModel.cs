using System.Collections.Generic;
using MorrisPhotos.Web.DataModels;

namespace MorrisPhotos.Web.ViewModels.Home
{
    public class EventsViewModel
    {
        public Dictionary<SchoolYear, Dictionary<Category, List<PhotoEvent>>> Events { get; set; } = new Dictionary<SchoolYear, Dictionary<Category, List<PhotoEvent>>>();
    }
}