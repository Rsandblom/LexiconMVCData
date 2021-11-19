using LexiconMVCData.Models;
using LexiconMVCData.Services;
using LexiconMVCData.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMVCData.Controllers
{
    public class AjaxController : Controller
    {

        private static List<Person> _personList;

        public AjaxController()
        {
            _personList = PeopleRepo.peopleList;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAllPersons()
        {
            PeopleViewModel peopleVM = new PeopleViewModel();
            peopleVM.PeopleList = _personList;
            return PartialView("_PersonListPartial", peopleVM.PeopleList);
        }


        [HttpPost]
        public IActionResult FindPersonById(int personID)
        {
            Person person = _personList.Where(p => p.Id == personID).FirstOrDefault();
            List<Person> tempList = new List<Person>();
            if (person != null)
            {
                tempList.Add(person);
            }
            
            return PartialView("_PersonListPartial", tempList);
        }

        [HttpPost]
        public IActionResult DeletePersonById(int personID)
        {
            bool success = PeopleRepo.DeletePersonFromList(personID);

            if (success)
            {
                return StatusCode(200);
            }
            return StatusCode(404);

        }
    }
}
