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
    public partial class UCLogIn : UserControl
    {
        int F = 0;
        JELOUANE_TRAVAUXEntities2 db = new JELOUANE_TRAVAUXEntities2();
        
        public UCLogIn()
        {
            InitializeComponent();
        }

        private void btnForgetPass_Click(object sender, EventArgs e)
        {
            //UCLogIn UCL = new UCLogIn();
            //this.Controls.Remove(UCL);
            //UCForgetPassword UCFP = new UCForgetPassword();
            //this.Controls.Add(UCFP);
            ////UCFP.Dock = DockStyle.Fill;
            //UCFP.Location = new Point(0, 167);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            var exist = db.utilisateurs.Find(txtEmail.Text);
            if (exist != null)
            {
                if(exist.MotdePasse == txtPassword.Text)
                {

                    var form = Form.ActiveForm as FrmLogin;
                    if (form != null)
                    {
                        form.hideform();
                        var form1 = new FrmMainForm();
                        form1.Closed += (s, args) => form.closeform();
                        form1.Show();
                       
                    }
                    F = 0;
                }
                else
                {

                    F++;
                    if (F >= 3)
                    {
                        DialogResult Dialogresult= MessageBox.Show("Incorrect Email or Password . Forgot password?", "Error", MessageBoxButtons.YesNo);
                        if(Dialogresult == DialogResult.Yes)
                        {
                            var form = Form.ActiveForm as FrmLogin;
                            if (form != null)
                            {
                                form.btnForgetPass.PerformClick();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Email or Password", "Error", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {

                MessageBox.Show("Incorrect Email or Password", "Error", MessageBoxButtons.OK);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            btnShowPassword.Visible = false;
            btnMaskPassword.Visible = true;
        }

        private void UCLogIn_Load(object sender, EventArgs e)
        {
            btnMaskPassword.Visible = false;
        }

        private void btnMaskPassword_Click(object sender, EventArgs e)
        {
            btnShowPassword.Visible = true;
            btnMaskPassword.Visible = false;
            txtPassword.PasswordChar = '*';
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
