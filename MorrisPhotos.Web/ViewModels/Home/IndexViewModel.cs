using System.Collections.Generic;
using MorrisPhotos.Web.DataModels;

namespace MorrisPhotos.Web.ViewModels.Home
{
    public class IndexViewModel
    {
        public List<SchoolYear> SchoolYears { get; set; } = new List<SchoolYear>();
    }
}