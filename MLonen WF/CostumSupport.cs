using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLonen_WF
{
   public class CostumSupport: Support
    {
        public CostumSupport(string name, bool sex, string rijksregisternummer, DateTime dateOfbirthday, DateTime dateOfStart, int hours, string function, double brutoLoon = 2050) : base(name, sex, rijksregisternummer, dateOfbirthday, dateOfStart, hours, function, brutoLoon)
        { 
        }
        public override double BruttoLoonWithHours()
        {
            return base.BruttoLoonWithHours() + 19.5 ;
        }


    }
}
