using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestingAngularDeployment.Models;

namespace TestingAngularDeployment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUsersController : ControllerBase
    {
        private readonly DataContext _context;

        public AppUsersController(DataContext context)
        {
            _context = context;
        }
        // GET: api/AppUsers
        [HttpGet]
        public JsonResult Get()
        {
            if (_context.AppUserAuths.ToList().Count == 0)
            {
                _context.AppUserAuths.Add(new AppUserAuth
                {
                    CanAccessProducts = true,
                    UserName = "NPeachey"
                });

                _context.SaveChanges();
            }

            var result = _context.AppUserAuths.ToList();

            return new JsonResult(result);
        }
    }
}
