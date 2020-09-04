using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLonen_WF
{
    public partial class Form1 : Form
    {
        public List<Werknemers> WorkersList = new List<Werknemers>();
        public Form1()
        {
            InitializeComponent();
        }
        
       
        private void Form1_Load(object sender, EventArgs e)
        {
            WorkersList.Add( new Werknemers("BBB AAA","Man","5555555555",new DateTime(1982,05,12),new DateTime(2018,05,29),hours: 38));
            WorkersList.Add(new IT_Support("KKKK NNN", "Woman", "2222222222", new DateTime(1988, 07, 07),new DateTime(2015,09,26),hours: 38));
            WorkersList.Add(new Programmer("LLL MMM","666666666",new DateTime(1982,05,12),"Man",new DateTime(2016,05,06)));
            lbWorkers.DataSource = null;
            lbWorkers.DataSource = WorkersList;
           
        }

        private void lbWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            lbWorkers.DataSource = WorkersList;
        }

        private void btLoonBrief_Click(object sender, EventArgs e)
        {
            LoonBrief();
        }
        private void LoonBrief()
        {
            foreach  (Werknemers werknemers in WorkersList)
            {
                

            }
            using (StreamWriter writer = new StreamWriter("loonkosten.txt"))
            {
                writer.WriteLine($"Loonkost voor de maand {DateTime.Now.ToString("MMMM yyyy").ToUpper()}: €");
            }

        }
    }
}
