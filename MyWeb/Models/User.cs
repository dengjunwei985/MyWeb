using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyWeb.Models
{

    [Table("user")]
    public class User
    {
        [Key]
        public int user_id { get; set; }
        public string user_name { get; set; }
        public string user_Password { get; set; }
        public string user_email { get; set; }
        public string user_imgPath { get; set; }

        public User()
        {
            user_id = 0;
            user_name = "";
            user_Password = "";
            user_email = "";
            user_imgPath = "";
        }
    }
}