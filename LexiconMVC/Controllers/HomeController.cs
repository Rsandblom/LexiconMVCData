using LexiconMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View(CvItem.GetCvItems());
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Projects()
        {

            return View(LexProject.GetLexProjects());
        }
    }

    
    
}
