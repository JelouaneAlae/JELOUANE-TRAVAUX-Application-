using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JELOUANE_TRAVAUX_Application_By_JELOUANE_Alale
{
    public partial class UCHome : UserControl
    {
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
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            lblOrder.Text = db.projets.ToList<projet>().Count.ToString();
            int cptNotNull = 0;
            int cptNull = 0;
            for (int i =0;i < db.projets.ToList<projet>().Count; i++)
            {
                if (db.projets.ToList<projet>()[i].DateFin_Projet != null)
                {
                    cptNotNull++;
                }
            }
            lblWorkshopFinished.Text = cptNotNull.ToString();

            for (int i = 0; i < db.projets.ToList<projet>().Count; i++)
            {
                if (db.projets.ToList<projet>()[i].DateFin_Projet == null)
                {
                    cptNull++;
                }
            }
            lblWorshopNotfinished.Text = cptNull.ToString();

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
                flowLayoutPanel1.Controls.Add(Notification[i]);
            }

        }
    }
}
