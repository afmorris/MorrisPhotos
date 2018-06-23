using System;
using ServiceStack.DataAnnotations;

namespace MorrisPhotos.Web.DataModels
{
    [Alias("MP_SchoolYear")]
    public class SchoolYear : BaseDataModel, IEquatable<SchoolYear>
    {
        [Index(true)]
        public string Name { get; set; }
        public string ThumbnailImageUrl { get; set; }

        public override string ToString() => this.Name;

        public bool Equals(SchoolYear other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(Name, other.Name) && string.Equals(ThumbnailImageUrl, other.ThumbnailImageUrl);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((SchoolYear) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Name != null ? Name.GetHashCode() : 0) * 397) ^ (ThumbnailImageUrl != null ? ThumbnailImageUrl.GetHashCode() : 0);
            }
        }
    }
}