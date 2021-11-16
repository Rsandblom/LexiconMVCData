using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMVC.Models
{
    public class CvItem
    {
        public CvItem(string itemType, string header, string description)
        {
            ItemType = itemType;
            Header = header;
            Description = description;
        }

        public string ItemType { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }

        public static List<CvItem> GetCvItems()
        {
            List<CvItem> cvItemsList = new List<CvItem>()
            {
                new CvItem("work", "Production worker", "Production of medical equipment"),
                new CvItem("edu", "Web development", "Four courser covering webdevelopment in ASP.NET"),
                new CvItem("work", "Carpenter", "Carpentry indoors and outdoors at a medium sized company"),
                new CvItem("edu", "Economics", "Five courses covering national and corporate economics"),

            };
            return cvItemsList;

        }


        
    }
}
