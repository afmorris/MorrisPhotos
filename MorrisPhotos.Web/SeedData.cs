using System.Collections.Generic;
using MorrisPhotos.Web.DataModels;

namespace MorrisPhotos.Web
{
    public static class SeedData
    {
        public static class SchoolYearIds
        {
            public static int Id20152016 = 1;
            public static int Id20162017 = 2;
            public static int Id20172018 = 3;
        }

        public static class CategoryIds
        {
            public static int CrossCountryId = 1;
            public static int TrackAndFieldId = 2;
            public static int SchoolId = 3;
            public static int PersonalId = 4;
        }

        public static List<SchoolYear> SchoolYears => new List<SchoolYear>
        {
            new SchoolYear { Name = "2015-16" },
            new SchoolYear { Name = "2016-17" },
            new SchoolYear { Name = "2017-18" }
        };

        public static List<Category> Categories => new List<Category>
        {
            new Category { Name = "Cross Country", UrlName = "cross-country", ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new Category { Name = "Track & Field", UrlName = "track-and-field", ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new Category { Name = "School", UrlName = "school", ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new Category { Name = "Personal", UrlName = "personal", ThumbnailImageUrl = "http://via.placeholder.com/510x510"}
        };

        public static List<PhotoEvent> PhotoEvents => new List<PhotoEvent>
        {
            new PhotoEvent { Name = "State", UrlName = "state", SchoolYearId = SchoolYearIds.Id20152016, CategoryId = CategoryIds.TrackAndFieldId, ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new PhotoEvent { Name = "Team Pictures", UrlName = "team-pictures", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new PhotoEvent { Name = "Keystone Icebreaker", UrlName = "keystone-icebreaker", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new PhotoEvent { Name = "Seneca East Tiger Classic", UrlName = "seneca-east-tiger-classic", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new PhotoEvent { Name = "Kenston Frank Gibas Invitational", UrlName = "kenston-frank-gibas-invitational", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new PhotoEvent { Name = "Smithville Invitational", UrlName = "smithville-invitational", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new PhotoEvent { Name = "Wooster Invitational", UrlName = "wooster-invitational", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new PhotoEvent { Name = "PTC Super Duals", UrlName = "ptc-super-duals", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new PhotoEvent { Name = "Spartan Invitational", UrlName = "spartan-invitational", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new PhotoEvent { Name = "Todd Clark Invitational", UrlName = "todd-clark-invitational", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new PhotoEvent { Name = "Medina Invitational", UrlName = "medina-invitational", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new PhotoEvent { Name = "PTC Championships", UrlName = "ptc-championships", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new PhotoEvent { Name = "Districts", UrlName = "districts", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new PhotoEvent { Name = "Regionals", UrlName = "regionals", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new PhotoEvent { Name = "State", UrlName = "state", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new PhotoEvent { Name = "Homecoming", UrlName = "homecoming", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.SchoolId, ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new PhotoEvent { Name = "April Fools Quad", UrlName = "april-fools-quad", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.TrackAndFieldId, ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new PhotoEvent { Name = "McCay Relays", UrlName = "mccay-relays", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.TrackAndFieldId, ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new PhotoEvent { Name = "Mehock Invitational", UrlName = "mehock-invitational", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.TrackAndFieldId, ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new PhotoEvent { Name = "Woodridge Dual", UrlName = "woodridge-dual", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.TrackAndFieldId, ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new PhotoEvent { Name = "PTC Championships", UrlName = "ptc-championships", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.TrackAndFieldId, ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new PhotoEvent { Name = "Districts", UrlName = "districts", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.TrackAndFieldId, ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new PhotoEvent { Name = "Regionals", UrlName = "regionals", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.TrackAndFieldId, ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new PhotoEvent { Name = "Senior Night", UrlName = "senior-night", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.TrackAndFieldId, ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new PhotoEvent { Name = "Seneca East Tiger Classic", UrlName = "seneca-east-tiger-classic", SchoolYearId = SchoolYearIds.Id20172018, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new PhotoEvent { Name = "Avon Lake Invitational", UrlName = "avon-lake-invitational", SchoolYearId = SchoolYearIds.Id20172018, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new PhotoEvent { Name = "Wooster Invitational", UrlName = "wooster-invitational", SchoolYearId = SchoolYearIds.Id20172018, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new PhotoEvent { Name = "PTC Super Duals", UrlName = "ptc-super-duals", SchoolYearId = SchoolYearIds.Id20172018, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new PhotoEvent { Name = "Spartan Invitational", UrlName = "spartan-invitational", SchoolYearId = SchoolYearIds.Id20172018, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
            new PhotoEvent { Name = "Todd Clark Invitational", UrlName = "todd-clark-invitational", SchoolYearId = SchoolYearIds.Id20172018, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "http://via.placeholder.com/510x510"},
        };
    }
}