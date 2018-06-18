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
        }

        public static List<Person> People => new List<Person>
        {
            new Person { FirstName = "Clay", LastName = "Gucker" },
            new Person { FirstName = "Tara", LastName = "Freeland" },
            new Person { FirstName = "Julie", LastName = "Oliver" },
            new Person { FirstName = "Dave", LastName = "Freeland" },
            new Person { FirstName = "Anna", LastName = "Winnicki" },
            new Person { FirstName = "Jenna", LastName = "Oliver" },
            new Person { FirstName = "Riley", LastName = "Freeland" },
            new Person { FirstName = "Vanessa", LastName = "Rivera" },
            new Person { FirstName = "Andy", LastName = "Froelich" },
            new Person { FirstName = "Katelyn", LastName = "Young" },
            new Person { FirstName = "Garth", LastName = "Gucker" },
            new Person { FirstName = "Erian", LastName = "Hamilton" },
            new Person { FirstName = "Tommie", LastName = "Kurtz" },
            new Person { FirstName = "Lauren", LastName = "Frank" },
            new Person { FirstName = "Carol", LastName = "Prohaska" },
            new Person { FirstName = "Bailey", LastName = "Freeland" },
            new Person { FirstName = "Katelyn", LastName = "Malena" },
            new Person { FirstName = "Fred", LastName = "Devore" },
            new Person { FirstName = "Kevin", LastName = "Devore" },
            new Person { FirstName = "Mattie", LastName = "Morris" },
            new Person { FirstName = "Cindy", LastName = "Morris" },
        };

        public static List<SchoolYear> SchoolYears => new List<SchoolYear>
        {
            new SchoolYear { Name = "2015-16", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=15&size=510" },
            new SchoolYear { Name = "2016-17", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=16&size=510" },
            new SchoolYear { Name = "2017-18", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=17&size=510" }
        };

        public static List<Category> Categories => new List<Category>
        {
            new Category { Name = "Cross Country", UrlName = "cross-country", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=XC&size=510" },
            new Category { Name = "Track & Field", UrlName = "track-and-field", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=TF&size=510" },
            new Category { Name = "School", UrlName = "school", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=S&size=510&length=1" }
        };

        public static List<PhotoEvent> PhotoEvents => new List<PhotoEvent>
        {
            new PhotoEvent { Name = "State", UrlName = "state", SchoolYearId = SchoolYearIds.Id20152016, CategoryId = CategoryIds.TrackAndFieldId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=S&size=510&length=1"},
            new PhotoEvent { Name = "Team Pictures", UrlName = "team-pictures", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=TP&size=510"},
            new PhotoEvent { Name = "Keystone Icebreaker", UrlName = "keystone-icebreaker", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=KI&size=510"},
            new PhotoEvent { Name = "Seneca East Tiger Classic", UrlName = "seneca-east-tiger-classic", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=SETC&size=510"},
            new PhotoEvent { Name = "Kenston Frank Gibas Invitational", UrlName = "kenston-frank-gibas-invitational", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=KFGI&size=510"},
            new PhotoEvent { Name = "Smithville Invitational", UrlName = "smithville-invitational", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=SI&size=510"},
            new PhotoEvent { Name = "Wooster Invitational", UrlName = "wooster-invitational", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=WI&size=510"},
            new PhotoEvent { Name = "PTC Super Duals", UrlName = "ptc-super-duals", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=PTCSD&size=510"},
            new PhotoEvent { Name = "Spartan Invitational", UrlName = "spartan-invitational", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=SI&size=510"},
            new PhotoEvent { Name = "Todd Clark Invitational", UrlName = "todd-clark-invitational", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=TCI&size=510"},
            new PhotoEvent { Name = "Medina Invitational", UrlName = "medina-invitational", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=MI&size=510"},
            new PhotoEvent { Name = "PTC Championships", UrlName = "ptc-championships", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=PTCC&size=510"},
            new PhotoEvent { Name = "Districts", UrlName = "districts", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=D&size=510&length=1"},
            new PhotoEvent { Name = "Regionals", UrlName = "regionals", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=R&size=510&length=1"},
            new PhotoEvent { Name = "State", UrlName = "state", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=S&size=510&length=1"},
            new PhotoEvent { Name = "Homecoming", UrlName = "homecoming", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.SchoolId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=HC&size=510"},
            new PhotoEvent { Name = "April Fools Quad", UrlName = "april-fools-quad", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.TrackAndFieldId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=AFQ&size=510"},
            new PhotoEvent { Name = "McCay Relays", UrlName = "mccay-relays", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.TrackAndFieldId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=MR&size=510"},
            new PhotoEvent { Name = "Mehock Invitational", UrlName = "mehock-invitational", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.TrackAndFieldId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=MI&size=510"},
            new PhotoEvent { Name = "Dual vs. Woodridge", UrlName = "dual-vs-woodridge", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.TrackAndFieldId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=DW&size=510"},
            new PhotoEvent { Name = "PTC Championships", UrlName = "ptc-championships", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.TrackAndFieldId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=PTCC&size=510"},
            new PhotoEvent { Name = "Districts", UrlName = "districts", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.TrackAndFieldId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=D&size=510&length=1"},
            new PhotoEvent { Name = "Regionals", UrlName = "regionals", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.TrackAndFieldId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=R&size=510&length=1"},
            new PhotoEvent { Name = "Senior Night", UrlName = "senior-night", SchoolYearId = SchoolYearIds.Id20162017, CategoryId = CategoryIds.TrackAndFieldId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=SN&size=510"},
            new PhotoEvent { Name = "Seneca East Tiger Classic", UrlName = "seneca-east-tiger-classic", SchoolYearId = SchoolYearIds.Id20172018, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=SETC&size=510"},
            new PhotoEvent { Name = "Avon Lake Invitational", UrlName = "avon-lake-invitational", SchoolYearId = SchoolYearIds.Id20172018, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=ALI&size=510"},
            new PhotoEvent { Name = "Wooster Invitational", UrlName = "wooster-invitational", SchoolYearId = SchoolYearIds.Id20172018, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=WI&size=510"},
            new PhotoEvent { Name = "PTC Super Duals", UrlName = "ptc-super-duals", SchoolYearId = SchoolYearIds.Id20172018, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=PTCSD&size=510"},
            new PhotoEvent { Name = "Spartan Invitational", UrlName = "spartan-invitational", SchoolYearId = SchoolYearIds.Id20172018, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=SI&size=510"},
            new PhotoEvent { Name = "Todd Clark Invitational", UrlName = "todd-clark-invitational", SchoolYearId = SchoolYearIds.Id20172018, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=TCI&size=510"},
            new PhotoEvent { Name = "Spartan Invitational", UrlName = "spartan-invitational", SchoolYearId = SchoolYearIds.Id20172018, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=SI&size=510"},
            new PhotoEvent { Name = "Medina Invitational", UrlName = "medina-invitational", SchoolYearId = SchoolYearIds.Id20172018, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=MI&size=510"},
            new PhotoEvent { Name = "PTC Championships", UrlName = "ptc-championships", SchoolYearId = SchoolYearIds.Id20172018, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=PTCC&size=510"},
            new PhotoEvent { Name = "Districts", UrlName = "districts", SchoolYearId = SchoolYearIds.Id20172018, CategoryId = CategoryIds.CrossCountryId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=D&size=510&length=1"},
            new PhotoEvent { Name = "April Fools Quad", UrlName = "april-fools-quad", SchoolYearId = SchoolYearIds.Id20172018, CategoryId = CategoryIds.TrackAndFieldId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=AFQ&size=510"},
            new PhotoEvent { Name = "New London Relays", UrlName = "new-london-relays", SchoolYearId = SchoolYearIds.Id20172018, CategoryId = CategoryIds.TrackAndFieldId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=NLR&size=510"},
            new PhotoEvent { Name = "Dual vs. Norton & Springfield", UrlName = "dual-vs-norton-and-springfield", SchoolYearId = SchoolYearIds.Id20172018, CategoryId = CategoryIds.TrackAndFieldId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=NS&size=510"},
            new PhotoEvent { Name = "Loudonville Invitational", UrlName = "loudonville-invitational", SchoolYearId = SchoolYearIds.Id20172018, CategoryId = CategoryIds.TrackAndFieldId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=LI&size=510"},
            new PhotoEvent { Name = "Triway Invitational", UrlName = "triway-invitational", SchoolYearId = SchoolYearIds.Id20172018, CategoryId = CategoryIds.TrackAndFieldId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=TI&size=510"},
            new PhotoEvent { Name = "Dual vs. Field & Coventry", UrlName = "dual-vs-field-and-coventry", SchoolYearId = SchoolYearIds.Id20172018, CategoryId = CategoryIds.TrackAndFieldId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=FC&size=510"},
            new PhotoEvent { Name = "Districts", UrlName = "districts", SchoolYearId = SchoolYearIds.Id20172018, CategoryId = CategoryIds.TrackAndFieldId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=D&size=510&length=1"},
            new PhotoEvent { Name = "Regionals", UrlName = "regionals", SchoolYearId = SchoolYearIds.Id20172018, CategoryId = CategoryIds.TrackAndFieldId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=R&size=510&length=1"},
            new PhotoEvent { Name = "State", UrlName = "state", SchoolYearId = SchoolYearIds.Id20172018, CategoryId = CategoryIds.TrackAndFieldId, ThumbnailImageUrl = "https://ui-avatars.com/api/?name=S&size=510&length=1"},
        };

        public static List<Photo> Photos => new List<Photo>
        {
            new Photo { ThumbnailImageUrl = "https://cdn.morrisphotos.com/2015/06/State-1.t.jpg", ImageUrl = "https://cdn.morrisphotos.com/2015/06/State-1.jpg", PhotoEventId = 1, Height = 4000, Width = 6000 },
            new Photo { ThumbnailImageUrl = "https://cdn.morrisphotos.com/2015/06/State-2.t.jpg", ImageUrl = "https://cdn.morrisphotos.com/2015/06/State-2.jpg", PhotoEventId = 1, Height = 4000, Width = 6000 },
            new Photo { ThumbnailImageUrl = "https://cdn.morrisphotos.com/2015/06/State-3.t.jpg", ImageUrl = "https://cdn.morrisphotos.com/2015/06/State-3.jpg", PhotoEventId = 1, Height = 4000, Width = 6000 },
            new Photo { ThumbnailImageUrl = "https://cdn.morrisphotos.com/2015/06/State-4.t.jpg", ImageUrl = "https://cdn.morrisphotos.com/2015/06/State-4.jpg", PhotoEventId = 1, Height = 4000, Width = 6000 },
            new Photo { ThumbnailImageUrl = "https://cdn.morrisphotos.com/2015/06/State-5.t.jpg", ImageUrl = "https://cdn.morrisphotos.com/2015/06/State-5.jpg", PhotoEventId = 1, Height = 4000, Width = 6000 },
            new Photo { ThumbnailImageUrl = "https://cdn.morrisphotos.com/2015/06/State-6.t.jpg", ImageUrl = "https://cdn.morrisphotos.com/2015/06/State-6.jpg", PhotoEventId = 1, Height = 6000, Width = 4000 },
            new Photo { ThumbnailImageUrl = "https://cdn.morrisphotos.com/2015/06/State-7.t.jpg", ImageUrl = "https://cdn.morrisphotos.com/2015/06/State-7.jpg", PhotoEventId = 1, Height = 4000, Width = 6000 },
            new Photo { ThumbnailImageUrl = "https://cdn.morrisphotos.com/2015/06/State-8.t.jpg", ImageUrl = "https://cdn.morrisphotos.com/2015/06/State-8.jpg", PhotoEventId = 1, Height = 4000, Width = 6000 },
        };
    }
}