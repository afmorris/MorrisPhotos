using System;
using System.Collections.Generic;
using ServiceStack.DataAnnotations;

namespace MorrisPhotos.Web.DataModels
{
    [Alias("MP_PhotoEvent")]
    public class PhotoEvent : BaseDataModel, IEquatable<PhotoEvent>
    {
        public string Name { get; set; }
        public string UrlName { get; set; }
        public string ThumbnailImageUrl { get; set; }
        public int SchoolYearId { get; set; }
        public int CategoryId { get; set; }

        [Reference]
        public List<Photo> Photos { get; set; } = new List<Photo>();

        [Reference]
        public Category Category { get; set; }

        [Reference]
        public SchoolYear SchoolYear { get; set; }

        public bool Equals(PhotoEvent other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(Name, other.Name) && string.Equals(UrlName, other.UrlName) && string.Equals(ThumbnailImageUrl, other.ThumbnailImageUrl) && SchoolYearId == other.SchoolYearId && CategoryId == other.CategoryId;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((PhotoEvent) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (UrlName != null ? UrlName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (ThumbnailImageUrl != null ? ThumbnailImageUrl.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ SchoolYearId;
                hashCode = (hashCode * 397) ^ CategoryId;
                return hashCode;
            }
        }
    }
}