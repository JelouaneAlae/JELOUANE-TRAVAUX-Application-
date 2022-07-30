using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

namespace JELOUANE_TRAVAUX_Application_By_JELOUANE_Alale
{
    public partial class FrmLogin : Form
    {
        JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();

        UCLogIn UCL = new UCLogIn();
        UCForgetPassword UCFP = new UCForgetPassword();
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void FrmLogin_Load(object sender, EventArgs e)
        {
            ClsEmail.Email = null;
            btnLogin.Visible = false;
            this.Controls.Add(UCL);
            UCL.Location = new Point(0, 215);

            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            var keyL = db.AppSettings.Find(1);

            ClsEmail.keyLang = keyL.Keylang;
            ClsEmail.Theme = keyL.Theme;
            ClsEmail.Applan = keyL.appLang;
            ClsEmail.savelogininfo = false;
        }

        private void btnForgetPass_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(UCL);

        }

        private void btnForgetPass_Click_1(object sender, EventArgs e)
        {
            
            lblOR.Visible = false;
            btnSignIn.Visible = false;
            btnLogin.Visible = true;
            btnLogin.Location = new Point(41, 389);
            btnForgetPass.Visible = false;
            this.Controls.Remove(UCL);
            
            this.Controls.Add(UCFP);
            UCFP.Location = new Point(0, 167);
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            lblOR.Visible = true;
            btnSignIn.Visible = true;
            this.Controls.Remove(UCFP);
            this.Controls.Add(UCL);
            UCL.Location = new Point(0, 215);
            btnLogin.Visible = false;
            btnForgetPass.Visible = true;
            
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmSignIn();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
        internal void closeform()
        {
            this.Close();

        }
        internal void hideform()
        {
            this.Hide();
        }

    }
}
