using System;
using ServiceStack.DataAnnotations;

namespace MorrisPhotos.Web.DataModels
{
    public class PersonPhoto : BaseDataModel, IEquatable<PersonPhoto>
    {
        [References(typeof(Person))]
        public int PersonId { get; set; }

        [References(typeof(Photo))]
        public int PhotoId { get; set; }

        public bool Equals(PersonPhoto other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return PersonId == other.PersonId && PhotoId == other.PhotoId;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((PersonPhoto) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (PersonId * 397) ^ PhotoId;
            }
        }
    }
}