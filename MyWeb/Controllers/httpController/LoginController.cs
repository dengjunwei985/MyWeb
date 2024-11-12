using Mysqlx;
using MyWeb.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWeb.Controllers.viewController
{
    public class LoginController:BaseController
    {
        private readonly UserService _userServices;
        public LoginController()
        {
            _userServices = new UserService();
        }

        public ActionResult LoginIndex()
        {

            return View();
        }


        [HttpPost]
        public ActionResult LoginGet(string user_email, string user_password)
        {
            _userServices.Login(user_email, user_password);
            return Json("ok");
        }
    }

    public class LoginSet
    {

    }
}