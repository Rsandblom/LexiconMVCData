using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMVC.Models
{
    public static class TemperatureEvaluator
    {
        private static string tempResult;

        public static string TempResult()
        {
            string temp = tempResult;
            tempResult = "";
            return temp;
        }

        public static void  GetBodyTemperatureStatus(Temperature temp)
        {
            if (temp.CurrentTemp == 0)
                tempResult = "";

            double fever, hypothermia;
            if (temp.IsCelsius)
            {
                fever = 38;
                hypothermia = 35;
            }
            else
            {
                fever = 100.4;
                hypothermia = 95;
            }

            if (temp.CurrentTemp < hypothermia && temp.CurrentTemp > 0)
                tempResult = "You have hypothermia";

            if(temp.CurrentTemp >= hypothermia && temp.CurrentTemp <= fever)
                tempResult = "Your body temperature is ok";

            if (temp.CurrentTemp > fever)
                tempResult = "You have a fever";

            return;
        }
    }
}
