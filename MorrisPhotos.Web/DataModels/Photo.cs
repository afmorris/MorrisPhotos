using System;
using System.Collections.Generic;
using ServiceStack.DataAnnotations;

namespace MorrisPhotos.Web.DataModels
{
    [Alias("MP_Photo")]
    public class Photo : BaseDataModel, IEquatable<Photo>
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

        public bool Equals(Photo other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(DownloadImageUrl, other.DownloadImageUrl) && string.Equals(ThumbnailImageUrl, other.ThumbnailImageUrl) && string.Equals(WebImageUrl, other.WebImageUrl) && PhotoEventId == other.PhotoEventId && Height == other.Height && Width == other.Width && string.Equals(AltText, other.AltText);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Photo) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (DownloadImageUrl != null ? DownloadImageUrl.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (ThumbnailImageUrl != null ? ThumbnailImageUrl.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (WebImageUrl != null ? WebImageUrl.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ PhotoEventId;
                hashCode = (hashCode * 397) ^ Height;
                hashCode = (hashCode * 397) ^ Width;
                hashCode = (hashCode * 397) ^ (AltText != null ? AltText.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}