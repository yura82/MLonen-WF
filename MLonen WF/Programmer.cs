using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLonen_WF
{
   public  class Programmer: Werknemers
    {
        public Programmer(string name, string rijksregisternummer,  DateTime dateOfbirthday, string sex, DateTime dateOfStart, bool companycar = false,int hours = 38, string function = "Programmer", double brutoLoon = 2050) : base(name,sex,rijksregisternummer,dateOfbirthday,dateOfStart,hours,function)
        {
            CompanyCar = companycar;
            BedrijfsVoorheffing = (companycar == true ? 17.30 : 13.68);

        }
    }
}
