using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLonen_WF
{
   public  class Support: Werknemers
    {
        public double ExtraMoney = 0;
        public Support(string name, string sex, string rijksregisternummer, DateTime dateOfbirthday, DateTime dateOfStart, int hours , string function, double brutoLoon = 2050) : base(name, sex, rijksregisternummer, dateOfbirthday, dateOfStart, hours, function, brutoLoon)
        {
            Hours = 38;
            ExtraMoney = 50;
        }
        public override double BruttoLoonWithHours() 
        {
            return base.BruttoLoonWithHours() + 50;
        }


    }
}
