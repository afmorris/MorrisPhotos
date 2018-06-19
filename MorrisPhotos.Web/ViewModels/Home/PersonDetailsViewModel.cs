using System.Collections.Generic;
using MorrisPhotos.Web.DataModels;

namespace MorrisPhotos.Web.ViewModels.Home
{
    public class PersonDetailsViewModel
    {
        public Person Person { get; set; }
        public List<Photo> Photos { get; set; } = new List<Photo>();
    }
}