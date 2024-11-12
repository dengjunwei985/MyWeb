using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyWeb.Models
{

    [Table("index-img")]
    public class Image
    {
        [Key]
        [Column("img_id")]
        public int img_id { get; set; }

        [Column("img_name")]
        public string img_name { get; set; }

        [Column("img_path")]
        public string img_path { get; set; }

        [Column("img_type")]
        public string img_type { get; set; }

        [Column("img_active")]
        public int img_active { get; set; }


        public Image()
        {
        }



    }
}