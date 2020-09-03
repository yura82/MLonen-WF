using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MLonen_WF
{
 public   class Werknemers
    {
        

        public bool Sex { get; set; }
        public string Name { get; set; }
        public string Rijksregisternummer { get; set; }
        public DateTime DateOfbirthday { get; set; }
        public DateTime DateOfStart { get; set; }
        public string Function { get; set; }
       
        public int Hours { get; set; }
        public double BrutoLoon { get; set; }

        public Werknemers(string name,bool sex, string rijksregisternummer, DateTime dateOfbirthday, DateTime dateOfStart,int hours, string function,  double brutoLoon= 1900)
        {
            Name = name;
            Sex = sex;
            Rijksregisternummer = rijksregisternummer;
            DateOfbirthday = dateOfbirthday;
            DateOfStart = dateOfStart;
            Function = function;
           
            BrutoLoon = brutoLoon;
            Hours = hours;
        }


        public virtual double BruttoLoonWithHours()
        {
            double bruttoLoonWithHours = Hours / 38 * BrutoLoon;
            return Math.Round(bruttoLoonWithHours,2);

        }
        public int SeniorityYears()
        {
            int seniorityYear = DateOfStart.Year - DateTime.Now.Year;
            return seniorityYear;
        }
        public virtual double SeniorityCounting()
        {
            
            double salarie = BruttoLoonWithHours();
            double seniority = salarie;
            int seniorityYear = SeniorityYears();
            for (int i = 0; i < seniorityYear; i++)
            {
                seniority *= 1.01;
            }
            seniority -= salarie;
            return Math.Round(seniority,2);


        }
        public override string ToString()
        {
            return Name;
        }

    }
}
