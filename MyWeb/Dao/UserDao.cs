using MyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWeb.Dao
{
    public class UserDao
    {
        private Allcontext db = new Allcontext();

        public User LoginCheck(string email)
        {
            User user = db.Users.FirstOrDefault(u => u.user_email == email );
            if (user != null)
            {
                return user;
            }
            else
            {
                return null;
            }
            
        }
    }
}