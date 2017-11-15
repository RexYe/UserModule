using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using MvcUserModule.Models;

namespace MvcUserModule.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //SqlConnection connecton = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ad"].ConnectionString.ToString());
            //try
            //{
            //    connecton.Open();
            //    Console.WriteLine("连接数据库测试成功！") ;

            //}
            //catch (Exception err)
            //{
            //    Console.WriteLine("连接数据库失败！");
            //}
            //finally
            //{
            //    connecton.Close();
            //}
            using (var db = new Db())
            {
                db.AuthGroupRepos.Add(new AuthGroupRepo
                {
                    Id = 1,
                    Name = "has"
                });
                db.SaveChanges();
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}