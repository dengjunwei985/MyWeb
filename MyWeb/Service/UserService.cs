using MyWeb.Dao;
using MyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWeb.Service
{
    public class UserService
    {
        private UserDao userDao;
        public UserService()
        {
            userDao = new UserDao();
            // TODO: Add constructor logic here
        }

        public int Login(string username, string password)
        {
            User user = userDao.LoginCheck(username);
            if(user!= null)
            {
                if (user.user_Password == password)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return -1;
            }
        }

    }
}