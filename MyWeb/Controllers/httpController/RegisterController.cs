using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWeb.Controllers.viewController
{
    public class RegisterController : BaseController
    {
        // GET: Register
        public ActionResult RegisterIndex()
        {
            return View();
        }
    }
}