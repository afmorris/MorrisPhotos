using System.Collections.Generic;
using MorrisPhotos.Web.DataModels;

namespace MorrisPhotos.Web.ViewModels.Home
{
    public class EventsViewModel
    {
        public List<PhotoEvent> PhotoEvents { get; set; } = new List<PhotoEvent>();
    }
}