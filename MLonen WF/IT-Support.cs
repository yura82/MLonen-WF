using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLonen_WF
{
   public class IT_Support: Support
    {
        public IT_Support(string name, bool sex, string rijksregisternummer, DateTime dateOfbirthday, DateTime dateOfStart, int hours, string function, double brutoLoon = 2050) : base(name, sex, rijksregisternummer, dateOfbirthday, dateOfStart, hours, function, brutoLoon)
        {
            Hours = 48;
        }
        public override double SeniorityCounting()
        {
            double salarie = BruttoLoonWithHours() * 0.06 ;
            double seniority = salarie;
            int seniorityYear = SeniorityYears();
            for (int i = 0; i < seniorityYear; i++)
            {
                seniority *= 1.01;
            }
            seniority -= salarie;
            return Math.Round(seniority, 2);
        }
    }
}
