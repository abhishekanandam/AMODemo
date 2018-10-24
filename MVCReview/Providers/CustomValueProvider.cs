using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCReview.Providers
{
    public class CustomValueProvider : IValueProvider
    {
        public bool ContainsPrefix(string prefix)
        {
            return HttpContext.Current.Request.Cookies[prefix] != null;
        }

        public ValueProviderResult GetValue(string key)
        {
            return new ValueProviderResult(HttpContext.Current.Request.Cookies[key].Value,
                HttpContext.Current.Request.Cookies[key].Value.ToString(), CultureInfo.CurrentCulture);
        }
    }
}