using ServiceStack.DataAnnotations;

namespace MorrisPhotos.Web.DataModels
{
    public class SchoolYear : BaseDataModel
    {
        [Index(true)]
        public string Name { get; set; }
        public string ThumbnailImageUrl { get; set; }

        public override string ToString() => this.Name;
    }
}