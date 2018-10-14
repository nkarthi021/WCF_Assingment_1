using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCF_Assignment_1.ProgramService;

namespace WCF_Assignment_1.Controllers
{
    public class ProgramController : Controller
    {
        // GET: Program
        public ActionResult Index(string Name, string submit)
        {
            ServiceClient client;

            switch (submit)
            {
                case "SayHello":
                    client = new ServiceClient("BasicHttpBinding_IService");
                    ViewBag.Message = client.SayHello(Name);
                    break;
                case "Program":
                    client = new ServiceClient("BasicHttpBinding_IService");
                    ViewBag.Message = client.TodayProgram(Name);
                    break;
            }

            
            
            return View();
        }
        //[HttpGet]
        //public ActionResult SayHello(string Name)
        //{
        //    Service1Client client = new Service1Client("BasicHttpBinding_IService1");
        //    TempData["Message"] = client.SayHello(Name);
        //    return RedirectToAction("Index");
        //}

        //[HttpPost]
        //public ActionResult TodayProgram(string Name)
        //{
        //    Service1Client client = new Service1Client("NetTcpBinding_IService1");
        //    TempData["Message"] = client.TodayProgram(Name);
        //    return RedirectToAction("Index");
        //}


    }
}