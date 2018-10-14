using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCF_Assignment_1.ProgramService;

namespace WCF_Assignment_1.Controllers
{
    public class CalculateController : Controller
    {
        // GET: Calculate
        public ActionResult Index(string Value1, string Value2, string submit)
        {
            int a = Convert.ToInt32(Value1);
            int b = Convert.ToInt32(Value2);
            ServiceClient client;
            switch (submit)
            {
                case "Add":
                    client = new ServiceClient("BasicHttpBinding_IService");
                   ViewBag.Output = "Result: " +  client.Add(a, b).ToString();
                    break;
                case "Subract":
                    client = new ServiceClient("BasicHttpBinding_IService");
                    ViewBag.Output = "Result: " + client.Subract(a, b).ToString(); ;
                    break;
                case "Multiply":
                    client = new ServiceClient("BasicHttpBinding_IService");
                    ViewBag.Output = "Result: " + client.Multiply(a, b).ToString(); ;
                    break;
                case "Divide":
                    client = new ServiceClient("BasicHttpBinding_IService");
                    ViewBag.Output = "Result: " + client.Divide(a, b).ToString(); ;
                    break;
            }
            return View();
        }
    }
}