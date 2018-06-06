using ServiceStack.DataAnnotations;

namespace MorrisPhotos.Web.DataModels
{
    public class Category : BaseDataModel
    {
        [Index(true)]
        public string Name { get; set; }

        [Index(true)]
        public string UrlName { get; set; }

        public string ThumbnailImageUrl { get; set; }
    }
}