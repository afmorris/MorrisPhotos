using System;
using System.Collections.Generic;

namespace MorrisPhotos.Web.DataModels.Comparers
{
    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x == null)
            {
                throw new ArgumentNullException(nameof(x));
            }

            if (y == null)
            {
                throw new ArgumentNullException(nameof(y));
            }

            return string.Compare(x.FirstName, y.FirstName, StringComparison.OrdinalIgnoreCase);
        }
    }
}