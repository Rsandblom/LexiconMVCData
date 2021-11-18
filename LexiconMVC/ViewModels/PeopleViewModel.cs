using LexiconMVCData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMVCData.ViewModels
{
    public class PeopleViewModel
    {
        public CreatePersonViewModel CreatePerson { get; set; }
        public List<Person> PeopleList { get; set; }
        [Display(Name ="Search")]
        public string SearchString { get; set; }

        public string SortOrder { get; set; }
        [Display(Name ="Name")]
        public string SortByName { get; set; }
        [Display(Name = "City")]
        public string SortByCity { get; set; }

        public static List<Person> CreatePeopleList()
        {
            List<Person> peopleList = new List<Person>()
            {
                new Person( 1, "Adam Adamsson", "031-123456", "Göteborg"),
                new Person( 2, "Bertil Bertilsson", "040-123456", "Malmö"),
                new Person( 3, "Carl Carlsson", "08-123456", "Stockholm"),
                new Person( 4, "Dan Danielsson", "031-223456", "Göteborg"),
                new Person( 5, "Erik Eriksson", "040-223456", "Malmö"),
                new Person( 6, "Frans Fransson", "08-223456", "Stockholm"),
                new Person( 7, "Gustav Gustavsson", "031-323456", "Göteborg"),
                new Person( 8, "Henrik Henriksson", "040-323456", "Malmö"),
                new Person( 9, "Ivar Ivarsson", "08-323456", "Stockholm"),
                new Person( 10, "Jan Jansson", "031-423456", "Göteborg"),
                new Person( 11, "Karl Karlsson", "040-423456", "Malmö"),
                new Person( 12, "Lars Larsson", "08-423456", "Stockholm")

            };
            return peopleList;

        }
    }
}
