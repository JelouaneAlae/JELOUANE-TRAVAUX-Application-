using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Globalization;

namespace JELOUANE_TRAVAUX_Application_By_JELOUANE_Alale
{
    public partial class UCHome : UserControl
    {
        JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
        public UCHome()
        {
            InitializeComponent();
            
        }

        private void UCHome_Load(object sender, EventArgs e)
        {
            MainFormInfo();
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            lblTotalProfit.Text = CalculeTotalProfit().ToString()+"  DH" ;
            bunifuPieChart1.Data.Add(1);
            bunifuPieChart1.Data.Add(2);
            bunifuPieChart1.Data.Add(8);



            foreach (Control text in Controls)
            {
                ClsEmail.keyLang = "ar-MA";
                CultureInfo la = new CultureInfo(ClsEmail.keyLang);
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(la);
            }
        }

        public void chart(string Month)
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();

            var projectFin = db.projets.ToList().Where(o => o.Datedebut_Projet.Value.ToString("MMMM").ToLower() == Month.ToLower() && o.DateFin_Projet >= DateTime.Now);

            var projectNotFin = db.projets.ToList().Where(o => o.Datedebut_Projet.Value.ToString("MMMM").ToLower() == Month.ToLower() && o.DateFin_Projet <= DateTime.Now);

            if(projectNotFin.ToList().Count() >=0)
            {
                bunifuPieChart1.Data[0] = projectNotFin.ToList().Count();
            }

            if (projectFin.ToList().Count() >= 0)
            {
                bunifuPieChart1.Data[0] = projectFin.ToList().Count();
            }
        }


        public void MainFormInfo()
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            lblOrder.Text = db.projets.ToList<projet>().Count.ToString();

            int ProjectEnded = 0;
            int ProjectNotEnded = 0;
            for (int i = 0; i < db.projets.ToList<projet>().Count; i++)
            {
                if (db.projets.ToList<projet>()[i].DateFin_Projet != null)
                {
                    ProjectEnded++;
                }
            }

            for (int i = 0; i < db.projets.ToList<projet>().Count; i++)
            {
                if (db.projets.ToList<projet>()[i].DateFin_Projet == null)
                {
                    ProjectNotEnded++;
                }
            }
            lblWorkshopFinished.Text = ProjectNotEnded.ToString();
            lblWorshopNotfinished.Text = ProjectEnded.ToString();
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart(cmbMonth.Text);
        }

        public double CalculeTotalProfit()
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            int Profit = 0;

            for (int i = 0; i < db.Utilisers.ToList().Count; i++)
            {
                Profit += db.Utilisers.ToList()[i].PrixQuantite.Value;
            }
            return Profit;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bunifuPieChart1.Data[0] = 12;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
