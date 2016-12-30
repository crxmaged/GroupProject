﻿using System.Web.Mvc;
using TestWcfSite.Models.Yuriymodels;

namespace TestWcfSite.Controllers
{
    public class YuriyController : Controller
    {
        // GET: Yuriy
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TableMultiply()
        {
            var expression = new Expression { A = 2, B = 2 };
            ViewBag.Expression = expression;
            
            var table = Expression.AllTableExpressions();
            
            return View(table);
        }
        
        

    }
}