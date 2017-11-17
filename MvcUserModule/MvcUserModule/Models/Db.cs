using MvcUserModule.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcUserModule
{
    public class Db : DbContext
    {
        public Db() : base("name=database")
        {}

        public DbSet<UserRepo> UserRepos { get; set; }
    }
}