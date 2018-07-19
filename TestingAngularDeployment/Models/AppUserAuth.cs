using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestingAngularDeployment.Models
{
    public class AppUserAuth
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public Boolean CanAccessProducts { get; set; }
    }
}
