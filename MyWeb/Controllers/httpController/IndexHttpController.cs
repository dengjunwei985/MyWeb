using MyWeb.Service;
using System;
using System.Collections.Generic;
using MyWeb.Models;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWeb.Controllers.httpController
{

    
    public class IndexHttpController:BaseController
    {

        private readonly ImgService _imgService;

        public IndexHttpController()
        {
            _imgService = new ImgService();
        }

        [HttpGet]
        public ActionResult IndexImg()
        {
            List<Image> imgs = _imgService.GetIndexImgs();
            return Json(imgs, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Hello()
        {
            Response.Write("Hello World!");
            return Content("Hello World!");
        }
    }
}