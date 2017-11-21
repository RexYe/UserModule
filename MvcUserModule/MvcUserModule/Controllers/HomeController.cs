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
                    Id = 1,
                    Name = "has"
                });
               // db.SaveChanges();
            }
            return View();
        }
   
        public ActionResult LogIn ()
        {
            ViewBag.Message = "LogIn";
            return View();
        }

        public ActionResult SignUp ()
        {
            ViewBag.Message = "SignUp";
            return View();
        }
    }
}