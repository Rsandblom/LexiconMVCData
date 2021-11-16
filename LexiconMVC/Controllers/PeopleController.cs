using LexiconMVCData.Models;
using LexiconMVCData.Services;
using LexiconMVCData.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMVCData.Controllers
{
    public class PeopleController : Controller
    {
        private static List<Person> _personList;

        public PeopleController()
        {
            _personList = PeopleRepo.peopleList;
        }
        
        public ActionResult Index(PeopleViewModel pVM)
        {
            PeopleViewModel peopleVM = new PeopleViewModel();
            peopleVM.PeopleList = _personList;
            peopleVM.SortByName = String.IsNullOrEmpty(pVM.SortOrder) ? "name_desc" : "";
            peopleVM.SortByCity = pVM.SortOrder == "city" ? "city_desc" : "city";

            if (!String.IsNullOrEmpty(pVM.SearchString))
                peopleVM.PeopleList = peopleVM.PeopleList.Where(c => c.City!.Contains(pVM.SearchString)).ToList();

            switch (pVM.SortOrder)
            {
                case "name_desc":
                    peopleVM.PeopleList = peopleVM.PeopleList.OrderByDescending(p => p.Name).ToList();
                    break;
                case "city":
                    peopleVM.PeopleList = peopleVM.PeopleList.OrderBy(p => p.City).ToList();
                    break;
                case "city_desc":
                    peopleVM.PeopleList = peopleVM.PeopleList.OrderByDescending(p => p.City).ToList(); ;
                    break;
                default:
                    peopleVM.PeopleList = peopleVM.PeopleList.OrderBy(p => p.Id).ToList(); ;
                    break;
            }

            return View(peopleVM);
        }

     
        [HttpPost]
        public ActionResult Create(PeopleViewModel peopleVM)
        {
            if (ModelState.IsValid)
            {
                PeopleRepo.AddNewPersonToList(peopleVM.CreatePerson.Name, peopleVM.CreatePerson.PhoneNumber, peopleVM.CreatePerson.City);
            }
            
            return RedirectToAction(nameof(Index));
        }
        
        [HttpPost]
        public ActionResult Delete(int id)
        {
            PeopleRepo.DeletePersonFromList(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
