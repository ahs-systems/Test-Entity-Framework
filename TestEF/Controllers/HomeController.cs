using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestEF.Controllers
{
    public class HomeController : Controller
    {
        private esp_systemsEntities DbContext = new esp_systemsEntities();

        public ActionResult Test()
        {
            // ADD
            //TestTable _testData = new TestTable
            //{
            //    name = "test1",
            //    bdate = Convert.ToDateTime("2017-01-03"),
            //    place = "cali"
            //};
            //DbContext.TestTables.Add(_testData);
            //DbContext.SaveChanges();


            // Edit
            TestTable _testData = new TestTable();
            _testData = DbContext.TestTables.Single(t => t.id == 0);
            _testData.name = DateTime.Now.ToString("HH:mm:ss");
            DbContext.SaveChanges();


            List<TestTable> testTable = new List<TestTable>();

            testTable = DbContext.TestTables.ToList();

            return View(testTable);
        }

        public ActionResult Index()
        {
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