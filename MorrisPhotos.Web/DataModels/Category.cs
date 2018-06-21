using System;
using ServiceStack.DataAnnotations;

namespace MorrisPhotos.Web.DataModels
{
    public class Category : BaseDataModel, IEquatable<Category>
    {
        [Index(true)]
        public string Name { get; set; }

        [Index(true)]
        public string UrlName { get; set; }

        public string ThumbnailImageUrl { get; set; }

        public bool Equals(Category other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(Name, other.Name) && string.Equals(UrlName, other.UrlName) && string.Equals(ThumbnailImageUrl, other.ThumbnailImageUrl);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Category) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (UrlName != null ? UrlName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (ThumbnailImageUrl != null ? ThumbnailImageUrl.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}