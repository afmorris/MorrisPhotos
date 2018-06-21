using System;
using System.Collections.Generic;
using ServiceStack.DataAnnotations;

namespace MorrisPhotos.Web.DataModels
{
    public class Person : BaseDataModel, IEquatable<Person>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ThumbnailImageUrl { get; set; }

        [Ignore]
        public List<Photo> Photos { get; set; } = new List<Photo>();

        public bool Equals(Person other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(FirstName, other.FirstName) && string.Equals(LastName, other.LastName) && string.Equals(ThumbnailImageUrl, other.ThumbnailImageUrl);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Person) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (FirstName != null ? FirstName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (LastName != null ? LastName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (ThumbnailImageUrl != null ? ThumbnailImageUrl.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}