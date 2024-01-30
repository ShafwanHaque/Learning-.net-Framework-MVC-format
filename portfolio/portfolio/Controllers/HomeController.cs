using portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace portfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult PersonalInfo()
        {
       
            var personalInfo = new PersonalInfo
            {
                FullName = "",
                Address = "",
                PhoneNumber = "",
                Email = "",
                LinkedInProfile = "",
                GitHubProfile = "",

            };

            return View(personalInfo);
        }
        public ActionResult Projects()
        {
            
            var projects = new List<Project>
        {
            new Project
            {
                ProjectName = "Profesional Sage",
                Description = "A project showcasing web development",
                Technologies = new List<string> { "HTML", "CSS", "JavaScript", "PHP" }
            },
            new Project
            {
                ProjectName = "Traveler Mangement system",
                Description = "A desktop application built with C#",
                Technologies = new List<string> { "C#", ".NET", "MSSQL" }
            },
            new Project
            {
                ProjectName = "PAyroll Management System",
                Description = "A consol application built with JAVA",
                Technologies = new List<string> { "Java" }
            }

        };

            return View(projects);
        }
        public ActionResult Index()
        {
            
            var profile = new Profile
            {
                Name = "Shafwanul Haque Chowdhury",
                ID = "21-44482-1",
                Email = "safwan198207@email.com",
                GitProfile = "https://github.com/ShafwanHaque"
            };

            return View(profile);
        }

        public ActionResult Education()
        {
           
            var educations = new List<Education>
        {
            new Education { Degree = "SSC", Year = 2018, Institute = "Alhaz Kobbad Ahammed Adarsha High School" },
            new Education { Degree = "HSC", Year = 2020, Institute = "Feni Government College" },
            new Education { Degree = "BSc", Year = 2023, Institute = "American International University-Bangladesh" }
        };

            return View(educations);
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