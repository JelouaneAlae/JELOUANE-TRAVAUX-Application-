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

namespace JELOUANE_TRAVAUX_Application_By_JELOUANE_Alale
{
    public partial class UCHome : UserControl
    {
        DataSet ds;
        public UCHome()
        {
            InitializeComponent();
            NotificationItems();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UCHome_Load(object sender, EventArgs e)
        {
            MainFormInfo();

            //fillcmb();

            lblTotalProfit.Text = CalculeTotalProfit().ToString()+"  DH" ;
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
        public void PieChart()
        {
            //var month = cmbMonth.Text; 
            //JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            ////bunifuPieChart1.Data.Add(db.projets.Where(o=> DbFunctions.TruncateTime(
            ////    o.Datedebut_Projet)==++ ).ToList().Count);
            //////var no
            //////bunifuPieChart1.Data.Add
            /////
            //int projectFinshed=0;
            //int projectNotFinished = 0;

            //for (int i = 0; i < db.projets.ToList().Count; i++)
            //{
            //    string mont = cmbMonth.Text;
            //    switch (mont)
            //    {
            //        case "salam":
            //            DateTime date = db.projets.ToList()[i].Datedebut_Projet.Value;
            //            if (date.Month == 1)
            //            {
            //                if (db.projets.ToList()[i].DateFin_Projet.Value != null)
            //                {
            //                    projectFinshed += 1;
            //                }
            //                else
            //                {
            //                    projectNotFinished += 1;
            //                }
            //            }
            //            break;
            //        case "dd":

            //    }

            //}
        }

        private void bunifuChartCanvas1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void NotificationItems()
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            UC_NotificationItems[] Notification = new UC_NotificationItems[5];

            for (int i = 0; i < Notification.Length; i++)
            {
                //Notification[i] = new UC_NotificationItems();
                //Notification[i].ProjectName =
                //flowLayoutPanel1.Controls.Add(Notification[i]);
            }

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }



        private void CmbKeyLanguage_SelectedValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("ff");

        }

        //public void fillcmb()
        //{
        //    //IDictionary<string, int> mount = new Dictionary<string, int>();
        //    List<string> mount = new List<string>();
        //    ds.Tables.Add("mois");
        //    ds.Tables[0].Columns.Add("nom");
        //    ds.Tables[0].Columns.Add("number");
        //    ds.Tables[0].Rows.Add("January", 1);
        //    ds.Tables[0].Rows.Add("February",2);
        //    ds.Tables[0].Rows.Add("March", 3);
        //    ds.Tables[0].Rows.Add("April", 4);
        //    ds.Tables[0].Rows.Add("May", 5);
        //    ds.Tables[0].Rows.Add("June", 6);
        //    ds.Tables[0].Rows.Add("July",7);
        //    ds.Tables[0].Rows.Add("August", 8);
        //    ds.Tables[0].Rows.Add("September", 9);
        //    ds.Tables[0].Rows.Add("October", 10);
        //    ds.Tables[0].Rows.Add("November",11);
        //    ds.Tables[0].Rows.Add("December",12);

        //    cmbMonth.DataSource = ds.Tables[0];
        //    cmbMonth.ValueMember = "number";
        //    cmbMonth.DisplayMember = "nom";

        //}

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

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
