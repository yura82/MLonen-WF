using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MLonen_WF
{
    public class Werknemers
    {

        public double BedrijfsVoorheffing = 13.68;
        public double ExtraLegaleVoordelen = 0;
        public string Sex { get; set; }
        public string Name { get; set; }
        public string Rijksregisternummer { get; set; }
        public DateTime DateOfbirthday { get; set; }
        public DateTime DateOfStart { get; set; }
        public string Function { get; set; }
        public bool CompanyCar { get; set; }
        public int Hours { get; set; }
        public double BrutoLoon { get; set; }

        public Werknemers(string name, string sex, string rijksregisternummer, DateTime dateOfbirthday, DateTime dateOfStart, int hours, string function = "Werknemer", double brutoLoon = 1900)
        {
            Name = name;
            Sex = sex;
            Rijksregisternummer = rijksregisternummer;
            DateOfbirthday = dateOfbirthday;
            DateOfStart = dateOfStart;
            Function = function;
            CompanyCar = false;
            BrutoLoon = brutoLoon;
            Hours = hours;
        }


        public virtual double BruttoLoonWithHours()
        {

            double bruttoLoonWithHours = Hours / 38 * BrutoLoon;
            return Math.Round(bruttoLoonWithHours, 2);

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
            return Math.Round(seniority, 2);


        }
        public override string ToString()
        {
            return Name;
        }
        public double PrintInformation(string Location)
        {

            double bruttoloon = BruttoLoonWithHours() + SeniorityCounting();
            double amountBedrijfsvoorheffing = Math.Round(bruttoloon / 100 * BedrijfsVoorheffing, 2);
            double nettoloon = Math.Round(bruttoloon - (amountBedrijfsvoorheffing) + ExtraLegaleVoordelen, 2);
            string NameFromList = Location + $" Lonbrief{Name},{Rijksregisternummer},{DateTime.Now.ToString("MM yyyy")}.txt";
            using (StreamWriter writer = new StreamWriter(NameFromList))
            {
                writer.WriteLine("------------------------------------------------");
                writer.WriteLine($"LoonBrief {DateTime.Now.AddMonths(DateTime.Now.Month).ToString("MMMM yyyy")}");
                writer.WriteLine("------------------------------------------------");
                writer.WriteLine(("NAAM") + $"{Name.ToUpper()}.");
                writer.WriteLine(("GESLACHT") + $"{Sex.ToUpper()}.");
                writer.WriteLine(("RIJKSREGISTERNUMMER") + $"{Rijksregisternummer}.");
                writer.WriteLine(("DATUM INDIENSTTREDING") + $"{DateOfStart.ToString("yyyy dd MM")}.");
                writer.WriteLine("--------------------------------------------------------");
                writer.WriteLine($"STARTLOON                :   €{PrintValue(BruttoLoonWithHours())}");
                writer.WriteLine($"ANCIËNNITEIT             : + €{PrintValue(SeniorityYears())}");
                

            }
            double totalincome = BruttoLoonWithHours() + SeniorityCounting() + ExtraLegaleVoordelen;
            return totalincome;
            string PrintValue(double getal)
            {
                string tePrinten = getal.ToString("0.00");
                tePrinten = string.Format("{0,8}", tePrinten);

                return tePrinten;

            }
        }
    }
}
