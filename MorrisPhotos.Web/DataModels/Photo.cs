using System;
using System.Collections.Generic;
using ServiceStack.DataAnnotations;

namespace MorrisPhotos.Web.DataModels
{
    public class Photo : BaseDataModel
    {
        public string DownloadImageUrl { get; set; }
        public string ThumbnailImageUrl { get; set; }
        public string WebImageUrl { get; set; }
        public int PhotoEventId { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        [Ignore]
        public string HeightWidthString => $"{this.Width}x{this.Height}";
        public string AltText { get; set; }

        [Ignore]
        public string Number
        {
            get
            {
                var startStripped = this.DownloadImageUrl.Remove(0, this.DownloadImageUrl.IndexOf("-", StringComparison.Ordinal) + 1);
                var number = startStripped.Remove(startStripped.IndexOf(".jpg", StringComparison.Ordinal));

                return number;
            }
        }
        
        [Ignore]
        public List<Person> People { get; set; } = new List<Person>();

        [Reference]
        public PhotoEvent PhotoEvent { get; set; }
    }
}