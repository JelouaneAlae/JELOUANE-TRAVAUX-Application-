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
        DataSet ds;
        public UCHome()
        {
            InitializeComponent();
            
        }



        private void UCHome_Load(object sender, EventArgs e)
        {
            MainFormInfo();
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            lblTotalProfit.Text = CalculeTotalProfit().ToString()+"  DH" ;
            bunifuPieChart1.Data.Add(8);
            bunifuPieChart1.Data.Add(2);
            bunifuPieChart1.Data.Add(6);


            foreach (Control text in Controls)
            {
                ClsEmail.keyLang = "ar-MA";
                CultureInfo la = new CultureInfo(ClsEmail.keyLang);
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(la);
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

        public int chart(string Month)
        {
            int cpt = 0;
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            for (int i = 0; i < db.projets.ToList().Count; i++)
            {
                if (Month.ToLower() == db.projets.ToList()[i].Datedebut_Projet.Value.ToString("MMMM").ToLower())
                {
                    cpt++;
                }
            }
            return cpt;
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
    }
}
