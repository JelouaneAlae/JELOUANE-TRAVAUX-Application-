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
    public partial class frmNewPass : Form
    {
        JELOUANE_TRAVAUXEntities2 db = new JELOUANE_TRAVAUXEntities2();
        ClsEmail clsemail = new ClsEmail();
        public frmNewPass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new FrmLogin();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void frmNewPass_Load(object sender, EventArgs e)
        {
            label5.Text = clsemail.Email;
            PicShowPss1.Visible = true;
            PicShowPss2.Visible = true;
            txtNewPass1.PasswordChar = '*';
            txtNewPass2.PasswordChar = '*';
        }
        
        internal void closeform()
        {
            this.Close();
        }

        internal void hideform()
        {
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPass1.Text))
            {
                errorProvider1.SetError(txtNewPass1, "Password must have Minimum 6 characters At least one numeral At least one alphabet");
            }
            else
            {
                if (txtNewPass1.Text.Length < 6)
                {
                    errorProvider1.SetError(txtNewPass1, "Password must have Minimum 6 characters ");
                }
                else
                {
                    if (txtNewPass1.Text == txtNewPass2.Text)
                    {

                        var exist = db.utilisateurs.Find(label5.Text);
                        if(exist != null)
                        {
                            DialogResult dr = MessageBox.Show("Your password changed successfully \nPlease login with your new password to continue", "Done", MessageBoxButtons.OK);
                            exist.MotdePasse = txtNewPass2.Text;
                            db.SaveChanges();
                            this.Hide();
                            FrmLogin frml = new FrmLogin();
                            frml.Closed += (s, args) => this.Close();
                            frml.Show();
                        }


                    }
                    else
                    {
                        errorProvider1.SetError(txtNewPass2, "Password must be the same ");
                    }
                }

            }

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNewPass2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PicMaskPass1_Click(object sender, EventArgs e)
        {
            txtNewPass1.PasswordChar = '*';
            PicMaskPass1.Visible = false;
            PicShowPss1.Visible = true;
        }

        private void PicShowPss1_Click(object sender, EventArgs e)
        {
            txtNewPass1.PasswordChar = '\0';
            PicShowPss1.Visible = false;
            PicMaskPass1.Visible = true;
        }

        private void PicShowPss2_Click(object sender, EventArgs e)
        {
            txtNewPass2.PasswordChar = '\0';
            PicShowPss2.Visible = false;
            PicMaskPass2.Visible = true;
        }

        private void PicMaskPass2_Click(object sender, EventArgs e)
        {
            txtNewPass2.PasswordChar = '*';
            PicMaskPass2.Visible = false;
            PicShowPss2.Visible = true;
        }
    }
}
