using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dn_mvc_loc;
using Microsoft.AspNetCore.Mvc;
using System.Web;

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
        [HttpGet("itemList")]
        public string GetItems()

        {
            DatabaseTasks dbTasks = new DatabaseTasks();
            var obj = dbTasks.getItems();

           
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(obj);

            return json;
        }

        [HttpGet("items")]
        public ActionResult Items()
        {
            DatabaseTasks dbTasks = new DatabaseTasks();
            var obj = dbTasks.getItems();

            return View(obj);
        }

        // GET api/values/5
        [HttpGet("doinit")]
        public string GetInit()
        {
            DatabaseTasks dbTasts = new DatabaseTasks();
            dbTasts.init();

            return "done";
        }

        // GET api/values/5
        [HttpGet("create")]
        public string GetCreate()
        {
            DatabaseTasks.createDbFromContext();
           
            return "done";
        }

        // GET api/values/5
        [HttpGet("delete")]
        public string GetClear()
        {
            DatabaseTasks dbTasts = new DatabaseTasks();
            dbTasts.deleteDb();

            return "done";
        }

        // GET api/values/5
        [HttpGet("fake")]
        public string GetFake()
        {
            DatabaseTasks dbTasts = new DatabaseTasks();
            dbTasts.pushFakeData();

            return "done";
        }
    }

}
