using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWeb.Controllers.viewController
{
    public class ForgetController : BaseController
    {
        // GET: Forget
        public ActionResult ForgetIndex()
        {
            return View();
        }
        public ActionResult ForgetSuccess()
        {   
            return View();
        }
    }
}