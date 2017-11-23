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
            using (var db = new Db())
            {  
                db.UserLogIn.Add(new UserLogIn
                {
                    Id = 100,
                    Name = "has"
                });
                db.SaveChanges();
               // db.UserLogIn.SqlQuery<UserLogIn>("select * from test");
            }
            return View();
        }
    }
}