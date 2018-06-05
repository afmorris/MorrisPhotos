using System.Text.RegularExpressions;

namespace MorrisPhotos.Web.Helpers
{
    public class RegularExpressions
    {
        public static Regex NaturalSortRegex = new Regex(@"\d+.jpg", RegexOptions.Compiled);
    }
}