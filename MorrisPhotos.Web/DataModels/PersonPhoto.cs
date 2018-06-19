using ServiceStack.DataAnnotations;

namespace MorrisPhotos.Web.DataModels
{
    public class PersonPhoto : BaseDataModel
    {
        [References(typeof(Person))]
        public int PersonId { get; set; }

        [References(typeof(Photo))]
        public int PhotoId { get; set; }
    }
}