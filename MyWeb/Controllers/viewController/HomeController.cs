using MyWeb.Dao;
using MyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWeb.Controllers
{
    public class HomeController : BaseController
    {
        private ImgDao imgDao = new ImgDao();
        public ActionResult Index()
        {
            ViewBag.Title = "首页"; 
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AskQuestion()
        {
            return View();
        }



    }
}