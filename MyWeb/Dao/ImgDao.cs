using MyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWeb.Dao
{
    public class ImgDao
    {
        private Allcontext db = new Allcontext();

        public List<Image> GetImgs()
        {
            var sql="select * from index_img";
            var result=db.Database.SqlQuery<Image>(sql).ToList();
            return result;
        }
            
        
        public List<Image> GetIndexImgs()
        {
            var sql = "select * from index_img where img_active=1 order by sort_id";
            var result = db.Database.SqlQuery<Image>(sql).ToList();
            return result;
        }
    }
}