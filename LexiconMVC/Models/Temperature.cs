using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMVC.Models
{
    public class Temperature
    {
        public Temperature()
        {

        }
        public Temperature(bool isCelsius, double currentTemp)
        {
            IsCelsius = isCelsius;
            CurrentTemp = currentTemp;
        }

        public bool IsCelsius { get; set; }
        public double CurrentTemp { get; set; }
    }
}
