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

        public static class PersonIds
        {
            public static int ClayGuckerId = 1;
            public static int TaraFreelandId = 2;
            public static int JulieOliverId = 3;
            public static int DaveFreelandId = 4;
            public static int AnnaWinnickiId = 5;
            public static int JennaOliverId = 6;
            public static int RileyFreelandId = 7;
            public static int VanessaRiveraId = 8;
            public static int AndyFroelichId = 9;
            public static int KatelynYoungId = 10;
            public static int GarthGuckerId = 11;
            public static int ErianHamiltonId = 12;
            public static int TommieKurtzId = 13;
            public static int LaurenFrankId = 14;
            public static int CarolProhaskaId = 15;
            public static int BaileyFreelandId = 16;
            public static int KatelynMalenaId = 17;
            public static int FredDevoreId = 18;
            public static int KevinDevoreId = 19;
            public static int MattieMorrisId = 20;
            public static int CindyMorrisId = 21;
        }

        public static class PhotoIds
        {
            public static int State_1_2015_2016_Id = 1;
            public static int State_2_2015_2016_Id = 2;
            public static int State_3_2015_2016_Id = 3;
            public static int State_4_2015_2016_Id = 4;
            public static int State_5_2015_2016_Id = 5;
            public static int State_6_2015_2016_Id = 6;
            public static int State_7_2015_2016_Id = 7;
            public static int State_8_2015_2016_Id = 8;
            public static int State_9_2015_2016_Id = 9;
            public static int State_10_2015_2016_Id = 10;
            public static int State_11_2015_2016_Id = 11;
            public static int State_12_2015_2016_Id = 12;
            public static int State_13_2015_2016_Id = 13;
            public static int State_14_2015_2016_Id = 14;
            public static int State_15_2015_2016_Id = 15;
            public static int State_16_2015_2016_Id = 16;
        }

        public static List<Person> People => new List<Person>
        {
            new Person { FirstName = "Clay", LastName = "Gucker", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=CG&size=510" },
            new Person { FirstName = "Tara", LastName = "Freeland", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=TF&size=510" },
            new Person { FirstName = "Julie", LastName = "Oliver", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=JO&size=510" },
            new Person { FirstName = "Dave", LastName = "Freeland", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=DF&size=510" },
            new Person { FirstName = "Anna", LastName = "Winnicki", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=AW&size=510" },
            new Person { FirstName = "Jenna", LastName = "Oliver", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=JO&size=510" },
            new Person { FirstName = "Riley", LastName = "Freeland", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=RF&size=510" },
            new Person { FirstName = "Vanessa", LastName = "Rivera", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=VR&size=510" },
            new Person { FirstName = "Andy", LastName = "Froelich", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=AF&size=510" },
            new Person { FirstName = "Katelyn", LastName = "Young", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=KY&size=510" },
            new Person { FirstName = "Garth", LastName = "Gucker", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=GG&size=510" },
            new Person { FirstName = "Erian", LastName = "Hamilton", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=EH&size=510" },
            new Person { FirstName = "Tommie", LastName = "Kurtz", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=TK&size=510" },
            new Person { FirstName = "Lauren", LastName = "Frank", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=LF&size=510" },
            new Person { FirstName = "Carol", LastName = "Prohaska", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=CP&size=510" },
            new Person { FirstName = "Bailey", LastName = "Freeland", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=BF&size=510" },
            new Person { FirstName = "Katelyn", LastName = "Malena", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=KM&size=510" },
            new Person { FirstName = "Fred", LastName = "Devore", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=FD&size=510" },
            new Person { FirstName = "Kevin", LastName = "Devore", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=KD&size=510" },
            new Person { FirstName = "Mattie", LastName = "Morris", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=MM&size=510" },
            new Person { FirstName = "Cindy", LastName = "Morris", ThumbnailImageUrl = "https://ui-avatars.com/api/?name=CM&size=510" },
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
            new Photo { ThumbnailImageUrl = "https://cdn.morrisphotos.com/2016/06/State-1.t.jpg", DownloadImageUrl = "https://cdn.morrisphotos.com/2016/06/State-1.jpg", WebImageUrl = "https://cdn.morrisphotos.com/2016/06/State-1.web.jpg", PhotoEventId = 1, Height = 1600, Width = 2400 },
            new Photo { ThumbnailImageUrl = "https://cdn.morrisphotos.com/2016/06/State-2.t.jpg", DownloadImageUrl = "https://cdn.morrisphotos.com/2016/06/State-2.jpg", WebImageUrl = "https://cdn.morrisphotos.com/2016/06/State-2.web.jpg", PhotoEventId = 1, Height = 1600, Width = 2400 },
            new Photo { ThumbnailImageUrl = "https://cdn.morrisphotos.com/2016/06/State-3.t.jpg", DownloadImageUrl = "https://cdn.morrisphotos.com/2016/06/State-3.jpg", WebImageUrl = "https://cdn.morrisphotos.com/2016/06/State-3.web.jpg", PhotoEventId = 1, Height = 1600, Width = 2400 },
            new Photo { ThumbnailImageUrl = "https://cdn.morrisphotos.com/2016/06/State-4.t.jpg", DownloadImageUrl = "https://cdn.morrisphotos.com/2016/06/State-4.jpg", WebImageUrl = "https://cdn.morrisphotos.com/2016/06/State-4.web.jpg", PhotoEventId = 1, Height = 1600, Width = 2400 },
            new Photo { ThumbnailImageUrl = "https://cdn.morrisphotos.com/2016/06/State-5.t.jpg", DownloadImageUrl = "https://cdn.morrisphotos.com/2016/06/State-5.jpg", WebImageUrl = "https://cdn.morrisphotos.com/2016/06/State-5.web.jpg", PhotoEventId = 1, Height = 1600, Width = 2400 },
            new Photo { ThumbnailImageUrl = "https://cdn.morrisphotos.com/2016/06/State-6.t.jpg", DownloadImageUrl = "https://cdn.morrisphotos.com/2016/06/State-6.jpg", WebImageUrl = "https://cdn.morrisphotos.com/2016/06/State-6.web.jpg", PhotoEventId = 1, Height = 2400, Width = 1600 },
            new Photo { ThumbnailImageUrl = "https://cdn.morrisphotos.com/2016/06/State-7.t.jpg", DownloadImageUrl = "https://cdn.morrisphotos.com/2016/06/State-7.jpg", WebImageUrl = "https://cdn.morrisphotos.com/2016/06/State-7.web.jpg", PhotoEventId = 1, Height = 1600, Width = 2400 },
            new Photo { ThumbnailImageUrl = "https://cdn.morrisphotos.com/2016/06/State-8.t.jpg", DownloadImageUrl = "https://cdn.morrisphotos.com/2016/06/State-8.jpg", WebImageUrl = "https://cdn.morrisphotos.com/2016/06/State-8.web.jpg", PhotoEventId = 1, Height = 1600, Width = 2400 },
            new Photo { ThumbnailImageUrl = "https://cdn.morrisphotos.com/2016/06/State-9.t.jpg", DownloadImageUrl = "https://cdn.morrisphotos.com/2016/06/State-9.jpg", WebImageUrl = "https://cdn.morrisphotos.com/2016/06/State-9.web.jpg", PhotoEventId = 1, Height = 1600, Width = 2400 },
            new Photo { ThumbnailImageUrl = "https://cdn.morrisphotos.com/2016/06/State-10.t.jpg", DownloadImageUrl = "https://cdn.morrisphotos.com/2016/06/State-10.jpg", WebImageUrl = "https://cdn.morrisphotos.com/2016/06/State-10.web.jpg", PhotoEventId = 1, Height = 1600, Width = 2400 },
            new Photo { ThumbnailImageUrl = "https://cdn.morrisphotos.com/2016/06/State-11.t.jpg", DownloadImageUrl = "https://cdn.morrisphotos.com/2016/06/State-11.jpg", WebImageUrl = "https://cdn.morrisphotos.com/2016/06/State-11.web.jpg", PhotoEventId = 1, Height = 1600, Width = 2400 },
            new Photo { ThumbnailImageUrl = "https://cdn.morrisphotos.com/2016/06/State-12.t.jpg", DownloadImageUrl = "https://cdn.morrisphotos.com/2016/06/State-12.jpg", WebImageUrl = "https://cdn.morrisphotos.com/2016/06/State-12.web.jpg", PhotoEventId = 1, Height = 1600, Width = 2400 },
            new Photo { ThumbnailImageUrl = "https://cdn.morrisphotos.com/2016/06/State-13.t.jpg", DownloadImageUrl = "https://cdn.morrisphotos.com/2016/06/State-13.jpg", WebImageUrl = "https://cdn.morrisphotos.com/2016/06/State-13.web.jpg", PhotoEventId = 1, Height = 1600, Width = 2400 },
            new Photo { ThumbnailImageUrl = "https://cdn.morrisphotos.com/2016/06/State-14.t.jpg", DownloadImageUrl = "https://cdn.morrisphotos.com/2016/06/State-14.jpg", WebImageUrl = "https://cdn.morrisphotos.com/2016/06/State-14.web.jpg", PhotoEventId = 1, Height = 1600, Width = 2400 },
            new Photo { ThumbnailImageUrl = "https://cdn.morrisphotos.com/2016/06/State-15.t.jpg", DownloadImageUrl = "https://cdn.morrisphotos.com/2016/06/State-15.jpg", WebImageUrl = "https://cdn.morrisphotos.com/2016/06/State-15.web.jpg", PhotoEventId = 1, Height = 1600, Width = 2400 },
            new Photo { ThumbnailImageUrl = "https://cdn.morrisphotos.com/2016/06/State-16.t.jpg", DownloadImageUrl = "https://cdn.morrisphotos.com/2016/06/State-16.jpg", WebImageUrl = "https://cdn.morrisphotos.com/2016/06/State-16.web.jpg", PhotoEventId = 1, Height = 1600, Width = 2400 },
        };

        public static List<PersonPhoto> PeoplePhotos => new List<PersonPhoto>
        {
            new PersonPhoto { PhotoId = PhotoIds.State_1_2015_2016_Id, PersonId = PersonIds.ClayGuckerId },
            new PersonPhoto { PhotoId = PhotoIds.State_2_2015_2016_Id, PersonId = PersonIds.TaraFreelandId },
            new PersonPhoto { PhotoId = PhotoIds.State_2_2015_2016_Id, PersonId = PersonIds.JulieOliverId },
            new PersonPhoto { PhotoId = PhotoIds.State_2_2015_2016_Id, PersonId = PersonIds.DaveFreelandId },
            new PersonPhoto { PhotoId = PhotoIds.State_2_2015_2016_Id, PersonId = PersonIds.AnnaWinnickiId },
            new PersonPhoto { PhotoId = PhotoIds.State_2_2015_2016_Id, PersonId = PersonIds.JennaOliverId },
            new PersonPhoto { PhotoId = PhotoIds.State_2_2015_2016_Id, PersonId = PersonIds.RileyFreelandId },
            new PersonPhoto { PhotoId = PhotoIds.State_2_2015_2016_Id, PersonId = PersonIds.VanessaRiveraId },
        };
    }
}