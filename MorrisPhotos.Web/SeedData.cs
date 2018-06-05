using System.Collections.Generic;
using MorrisPhotos.Web.DataModels;

namespace MorrisPhotos.Web
{
    public static class SeedData
    {
        public static List<SchoolYear> SchoolYears => new List<SchoolYear>
        {
            new SchoolYear { Name = "2015-16" },
            new SchoolYear { Name = "2016-17" },
            new SchoolYear { Name = "2017-18" }
        };

        public static List<Category> Categories => new List<Category>
        {
            new Category { Name = "CrossCountry", DisplayName = "Cross Country", UrlName = "cross-country", ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new Category { Name = "TrackAndField", DisplayName = "Track & Field", UrlName = "track-and-field", ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new Category { Name = "School", DisplayName = "School", UrlName = "school", ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new Category { Name = "Personal", DisplayName = "Personal", UrlName = "personal", ThumbnailImageUrl = "http://via.placeholder.com/510x510"}
        };
    }
}