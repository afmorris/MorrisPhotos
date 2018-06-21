using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using MorrisPhotos.Web.DataModels;

namespace MorrisPhotos.Web.Extensions
{
    public static class HtmlExtensions
    {
        public static HtmlString ToJavascriptArray(this IHtmlHelper helper, List<Person> people)
        {
            var builder = new StringBuilder();

            foreach (var person in people)
            {
                builder.Append($"[\"{person.FirstName} {person.LastName}\", \"{person.Id}\"],");
            }

            return new HtmlString(builder.ToString());
        }
    }
}