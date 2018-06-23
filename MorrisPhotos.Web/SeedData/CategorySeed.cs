using System.Collections.Generic;
using MorrisPhotos.Web.DataModels;

namespace MorrisPhotos.Web.SeedData
{
    public static class CategorySeed
    {
        public static List<Category> Categories => new List<Category>
        {
            new Category { Name = "Cross Country", UrlName = "cross-country", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=XC&size=510" },
            new Category { Name = "Track & Field", UrlName = "track-and-field", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=TF&size=510" },
            new Category { Name = "School", UrlName = "school", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=S&size=510&length=1" }
        };
    }
}