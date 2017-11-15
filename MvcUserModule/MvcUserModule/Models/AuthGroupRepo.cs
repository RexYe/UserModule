using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcUserModule.Models
{
    [Table("auth_group")]
    public class AuthGroupRepo
    {
        public long Id { get; set; }

        public string Name { get; set; }
    }
}