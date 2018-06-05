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
    }
}