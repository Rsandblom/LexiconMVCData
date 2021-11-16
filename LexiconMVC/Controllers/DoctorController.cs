using LexiconMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMVC.Controllers
{
    public class DoctorController : Controller
    {
        public ActionResult Index()
        {

            string resultMsg = TemperatureEvaluator.TempResult();
            if(resultMsg == null || resultMsg == "")
                ViewBag.Msg = null;
            else
                ViewBag.Msg = resultMsg;

            return View();
        }

        
        [HttpPost]
        public ActionResult Index(Temperature temperature)
        {
            TemperatureEvaluator.GetBodyTemperatureStatus(temperature);
            
            return RedirectToAction(nameof(Index));
        }

        
    }
}
