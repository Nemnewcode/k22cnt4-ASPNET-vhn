﻿using System.Web;
using System.Web.Mvc;

namespace Vhnlesson07CF
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}