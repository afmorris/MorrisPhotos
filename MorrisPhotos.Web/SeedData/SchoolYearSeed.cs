using System.Collections.Generic;
using MorrisPhotos.Web.DataModels;

namespace MorrisPhotos.Web.SeedData
{
    public static class SchoolYearSeed
    {
        public static List<SchoolYear> SchoolYears => new List<SchoolYear>
        {
            new SchoolYear { Name = "2015-16", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=15&size=510" },
            new SchoolYear { Name = "2016-17", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=16&size=510" },
            new SchoolYear { Name = "2017-18", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=17&size=510" },
            new SchoolYear { Name = "2018-19", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=18&size=510" },
            new SchoolYear { Name = "2019-20", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=19&size=510" },
        };
    }
}