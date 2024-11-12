using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace MyWeb.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class Allcontext:System.Data.Entity.DbContext
    {
        public Allcontext() : base("name=MysqlConnection")
        {
            try
            {
                // 尝试打开数据库连接
                Database.Connection.Open();
                Console.WriteLine("Database connection opened successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to open database connection: " + ex.Message);
            }
            finally
            {
                if (Database.Connection.State == System.Data.ConnectionState.Open)
                {
                    Database.Connection.Close();
                }
            }
        }
        public System.Data.Entity.DbSet<Image> Images { get; set; }
        public System.Data.Entity.DbSet<User> Users { get; set; }
    }
}