﻿using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using System.Web.UI.HtmlControls;
using TestWcfSite.Models.PikhotaSerhiiModels;

namespace TestWcfSite.Controllers
{
    public class SergeyPekhotaController : Controller
    {
        // GET: SergeyPekhota
        public ActionResult Index()
        {
            ViewBag.Info = Info();
            return View();
        }

        [HttpPost]
        public ActionResult MathTables(Calculator calc)
        {
            return View("MathTables",calc);
        }
        
        public ActionResult MathTables()
        {

            var calc = new Calculator();
            return View(calc);
        }

        public ActionResult AddUser()
        {
            var user = new User();
            return View(user);
        }

        [HttpPost]
        public ActionResult DataUser(User user)
        {
            return PartialView("_UserData",user);
        }

        public ActionResult MultiplyTable()
        {

            ViewBag.Begintd = "<td class = \"tb-pikhota \">";
            ViewBag.Endtd = "</td>";
            ViewBag.Counter = 0;
            ViewBag.TagBr = "<br />";
            ViewData.Model = MultyTables();
            return View();
        }
        

        public ActionResult DivisionTable()
        {
            ViewBag.Begintd = "<td class = \"tb-pikhota \">";
            ViewBag.Endtd = "</td>";
            ViewBag.Counter = 0;
            ViewBag.TagBr = "<br />";
            ViewData.Model = DivTables();
            return View();
        }

        public ActionResult SumTable()
        {
            ViewBag.Begintd = "<td class = \"tb-pikhota \">";
            ViewBag.Endtd = "</td>";
            ViewBag.Counter = 0;
            ViewBag.TagBr = "<br />";
            ViewData.Model = SumTables();
            return View();
        }

        public ActionResult SubstractionTable()
        {
            ViewBag.Begintd = "<td class = \"tb-pikhota \">";
            ViewBag.Endtd = "</td>";
            ViewBag.Counter = 0;
            ViewBag.TagBr = "<br />";
            ViewData.Model = SubTables();
            return View();
        }

        #region ActionMathMethods
        public List<string> MultyTables()
        {
            var list = new List<string>();
            var str = new StringBuilder();
            for (var i = 2; i < 10; i++)
            {
                for (var j = 2; j < 10; j++)
                {
                    str.Append($"{i}x{j}={i * j}");
                    list.Add(str.ToString());
                    str.Clear();
                }
            }
            return list;
        }

        public List<string> DivTables()
        {
            var list = new List<string>();
            var str = new StringBuilder();
            for (var i = 2; i < 10; i++)
            {
                for (var j = 2; j < 10; j++)
                {

                    var result = i % j == 0
                        ? str.Append($"{i}/{j}={i / j}")
                        : str.Append($"{i}/{j}={((double)i / (double)j):N2}");
                    list.Add(result.ToString());
                    str.Clear();
                }

            }
            return list;
        }

        public List<string> SumTables()
        {
            var list = new List<string>();
            var str = new StringBuilder();
            for (var i = 2; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {

                    str.Append($"{i}+{j}={i + j}");
                    list.Add(str.ToString());
                    str.Clear();
                }
            }
            return list;
        }

        public List<string> SubTables()
        {
            var list = new List<string>();
            var str = new StringBuilder();
            for (var i = 2; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {

                    str.Append($"{i}-{j}={i - j}");
                    list.Add(str.ToString());
                    str.Clear();
                }

            }
            return list;
        }
        #endregion

        #region OtherMethods
        public string Info()
        {
            var b = new StringBuilder();
            var browser = HttpContext.Request.Browser.Browser;
            var agent = HttpContext.Request.UserAgent;
            var url = HttpContext.Request.RawUrl;
            var ip = HttpContext.Request.UserHostAddress;
            var reffer = HttpContext.Request.UrlReferrer == null ? "" : HttpContext.Request.UrlReferrer.AbsoluteUri;
            return b.Append($"<table class=\"table table-bordered table-condensed\"><th>Info</th><tr><td><b>Browser:</b>{browser}</td><tr><td><b>User_agent:</b>{agent}</td></tr>" +
                            $"<tr><td><b>url:</b>{url}</td></tr>" +
                            $"<tr><td><b>IPAdress:</b>{ip}</td></tr><tr><td><b>Reffer:{reffer}</td></tr></table>").ToString();
        }
        #endregion


    }
}