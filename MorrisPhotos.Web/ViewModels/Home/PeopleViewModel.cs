using System.Collections.Generic;
using MorrisPhotos.Web.DataModels;

namespace MorrisPhotos.Web.ViewModels.Home
{
    public class PeopleViewModel
    {
        public List<Person> People { get; set; } = new List<Person>();
    }
}