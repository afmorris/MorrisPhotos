using System.Collections.Generic;
using ServiceStack.DataAnnotations;

namespace MorrisPhotos.Web.DataModels
{
    public class PhotoEvent : BaseDataModel
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string UrlName { get; set; }
        public int SchoolYearId { get; set; }
        public int CategoryId { get; set; }

        [Reference]
        public List<Photo> Photos { get; set; } = new List<Photo>();

        [Reference]
        public Category Category { get; set; }

        [Reference]
        public SchoolYear SchoolYear { get; set; }
    }
}