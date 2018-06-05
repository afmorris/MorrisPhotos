using System.Collections.Generic;
using ServiceStack.DataAnnotations;

namespace MorrisPhotos.Web.DataModels
{
    public class Person : BaseDataModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Reference]
        public List<Photo> Photos { get; set; } = new List<Photo>();
    }
}