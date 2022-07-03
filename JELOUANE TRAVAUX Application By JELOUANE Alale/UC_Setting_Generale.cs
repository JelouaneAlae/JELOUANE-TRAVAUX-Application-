using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace JELOUANE_TRAVAUX_Application_By_JELOUANE_Alale
{
    public partial class UC_Setting_Generale : UserControl
    {
        public UC_Setting_Generale()
        {
            InitializeComponent();
        }

        private void UC_Setting_Generale_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pnlDefault.Visible == true)
            {
                pnlDefault.Visible = false;

            }
            else
            {
                pnlDefault.Visible = true;
                pnldark.Visible = false;
                pnlHighContrast.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pnldark.Visible == true)
            {
                pnldark.Visible = false;
                
            }
            else
            {
                pnldark.Visible = true;
                pnlDefault.Visible = false;
                pnlHighContrast.Visible = false;
            }
        }

        private void pnldark_Click(object sender, EventArgs e)
        {

        }

        private void pnlDefault_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pnlHighContrast.Visible == true)
            {
                pnlHighContrast.Visible = false;

            }
            else
            {
                pnlDefault.Visible = false;
                pnldark.Visible = false;
                pnlHighContrast.Visible = true;
            }
        }

        private void CmbKeyLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CmbKeyLanguage.Text == "English")
            {
                JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
                var it = db.AppSettings.Find(1);
                it.appLang  = "en-us";
                DialogResult dr = MessageBox.Show("Please restart the application to activate the modifications","Setting",MessageBoxButtons.YesNo);
                if(dr == DialogResult.Yes)
                {
                    Application.Exit();
                }
                db.SaveChanges();   
            }
            if (CmbKeyLanguage.Text == "Frensh")
            {
                JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
                var it = db.AppSettings.Find(1);
                it.appLang  = "fr-fr";
                DialogResult dr = MessageBox.Show("Please restart the application to activate the modifications", "Setting", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Application.Exit();
                }
                db.SaveChanges();
            }

            if (CmbKeyLanguage.Text == "Arab")
            {
                JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
                var it = db.AppSettings.Find(1);
                it.appLang  = "ar-ma";
                DialogResult dr = MessageBox.Show("Please restart the application to activate the modifications", "Setting", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Application.Exit();
                }
                db.SaveChanges();
            }

        }

        private void CmbAppLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CmbAppLanguage.Text == "French")
            {
                JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
                var it = db.AppSettings.Find(1);
                it.appLang = "fr";
                db.SaveChanges();
            }

            if (CmbAppLanguage.Text == "English")
            {
                JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
                var it = db.AppSettings.Find(1);
                it.appLang = "en";
                db.SaveChanges();
            }
        }
    }
}
