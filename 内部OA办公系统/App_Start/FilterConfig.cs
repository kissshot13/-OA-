﻿using System.Web;
using System.Web.Mvc;

namespace 内部OA办公系统
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
