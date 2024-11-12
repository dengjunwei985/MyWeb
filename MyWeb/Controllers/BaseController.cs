using MyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MyWeb.Controllers
{
    public class BaseController : Controller
    {

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            setTopBar();
        }

        private void setTopBar()
        {
            var navList = new List<Item>()
            {
                new Item{ Name = "首页" , RouterSrc = "Index" , Controller = "Home"},
                new Item{ Name = "资源" , RouterSrc = "Paper" , Controller = "Home"},
                new Item{ Name = "资讯", RouterSrc = "Computer" , Controller = "Home"},
                new Item{ Name = "询问", RouterSrc = "AskQuestion" , Controller = "Home"},
                new Item{ Name = "关于我们", RouterSrc = "About" , Controller = "Home"}

            };

            ViewBag.navList = navList;

            UserViewModel userViewModel = new UserViewModel();
            ViewBag.UserViewModel = userViewModel;

        }

    }

    public class TopBarViewModel
    {
        public List<Item> NavLinks { get; set; }
    }

    public class UserViewModel
    {
        public UserViewModel()
        {
            user = new User();
            IsLogin = false;
        }
        public User user { get; set; }
        public bool IsLogin { get; set; }


    }

    public class Item
    {
        public string Name { get; set; }
        public string RouterSrc { get; set; }

        public string Controller {  get; set; }


    }
}