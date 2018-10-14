using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCF_Assignment_1.ProgramService;
using WCF_Assignment_1.Models;

namespace WCF_Assignment_1.Controllers
{
    public class JobOpeningsController : Controller
    {
        // GET: JobOpenings
        public ActionResult Index(string Role, string submit)
        {
            ServiceClient client;

            List<JobOpenings> JobOpeningList = new List<JobOpenings>();

            //ViewBag.Result = JobOpeningsList;

            switch (submit)
            {
                case "Job Openings":
                    client =  new ServiceClient();
                    ViewBag.Result = client.JobOpenings();
                    break;
                case "Job Openings By Role":
                    if (Role != "Select")
                    {
                        client = new ServiceClient();
                        ViewBag.Result = client.JobOpeningsByRole(Role);
                    }
                    break;
            }
            return View();
        }

        public List<JobList> GetJobOpenings()
        {
            List<JobList> JobOpeningsList = new List<JobList>();
            JobOpeningsList.Add(new JobList { JobName = "DotNet Developer", Role = "Developer" });
            JobOpeningsList.Add(new JobList { JobName = "Java Developer", Role = "Senior Developer" });
            JobOpeningsList.Add(new JobList { JobName = "Angular Developer", Role = "Developer" });
            JobOpeningsList.Add(new JobList { JobName = "Php Developer", Role = "Manager" });
            JobOpeningsList.Add(new JobList { JobName = "Mainframe Developer", Role = "Senior Developer" });
            JobOpeningsList.Add(new JobList { JobName = "UI Developer", Role = "Senior Developer" });
            JobOpeningsList.Add(new JobList { JobName = "SQL Developer", Role = "Manager" });
            JobOpeningsList.Add(new JobList { JobName = "Android Developer", Role = "Developer" });
            JobOpeningsList.Add(new JobList { JobName = "IOS Developer", Role = "Developer" });

            return JobOpeningsList;
        }
    }
}