﻿using MVCReview.Filters;
using System.Web;
using System.Web.Mvc;

namespace MVCReview
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new CustomFilter());
            filters.Add(new HandleErrorAttribute());
        }
    }
}