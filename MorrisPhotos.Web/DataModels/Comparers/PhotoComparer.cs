using System;
using System.Collections.Generic;
using MorrisPhotos.Web.Helpers;

namespace MorrisPhotos.Web.DataModels.Comparers
{
    public class PhotoComparer : IComparer<Photo>
    {
        public int Compare(Photo x, Photo y)
        {
            if (x == null)
            {
                throw new ArgumentNullException(nameof(x));
            }

            if (y == null)
            {
                throw new ArgumentNullException(nameof(y));
            }

            var xRegexResult = RegularExpressions.NaturalSortRegex.Match(x.ImageUrl);
            var yRegexResult = RegularExpressions.NaturalSortRegex.Match(y.ImageUrl);

            if (xRegexResult.Success && yRegexResult.Success)
            {
                var xResult = xRegexResult.Groups[0].Value.Replace(".jpg", string.Empty);
                var yResult = yRegexResult.Groups[0].Value.Replace(".jpg", string.Empty);
                return int.Parse(xResult).CompareTo(int.Parse(yResult));
            }

            return string.Compare(x.ImageUrl, y.ImageUrl, StringComparison.Ordinal);
        }
    }
}