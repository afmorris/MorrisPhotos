using System.Collections.Generic;
using ServiceStack.DataAnnotations;

namespace MorrisPhotos.Web.DataModels
{
    public class Photo : BaseDataModel
    {
        public string ImageUrl { get; set; }
        public string ThumbnailImageUrl { get; set; }
        public int PhotoEventId { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string HeightWidthString => $"{this.Width}x{this.Height}";
        public string AltText { get; set; }

        [Reference]
        public List<Person> People { get; set; } = new List<Person>();
    }
}