using MyWeb.Dao;
using MyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWeb.Service
{
    public class ImgService
    {
        private readonly ImgDao imgDao;

        public ImgService()
        {
            imgDao = new ImgDao();
        }

        public List<Image> GetIndexImgs()
        {
            return imgDao.GetIndexImgs();
        }

    }
}