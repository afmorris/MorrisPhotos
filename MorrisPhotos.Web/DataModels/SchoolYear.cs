using ServiceStack.DataAnnotations;

namespace MorrisPhotos.Web.DataModels
{
    public class SchoolYear : BaseDataModel
    {
        [Index(true)]
        public string Name { get; set; }

        public override string ToString() => this.Name;
    }
}