﻿using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema_1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
