using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dn_mvc_loc;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dnmvcloc.Controllers
{
    [Route("db/[controller]")]
    public class DbActionController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        // GET api/values/5
        [HttpGet("init")]
        public string Get()
        {
            //return "value";

            DatabaseTasks dbTasts = new DatabaseTasks();
            dbTasts.setup();

            return "ok";
        }
    }

}
