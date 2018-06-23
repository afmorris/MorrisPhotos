using System.Collections.Generic;
using MorrisPhotos.Web.DataModels;

namespace MorrisPhotos.Web.ViewModels.Home
{
    public class PhotoTagViewModel
    {
        public int PersonId { get; set; }
        public int PhotoId { get; set; }
        public List<Person> People { get; set; } = new List<Person>();
        public List<Photo> Photos { get; set; } = new List<Photo>();
    }
}