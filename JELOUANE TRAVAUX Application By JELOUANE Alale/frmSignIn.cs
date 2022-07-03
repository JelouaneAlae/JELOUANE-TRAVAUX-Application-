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
    public partial class frmSignIn : Form
    {
        JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
        public frmSignIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var exist = db.utilisateurs.Find(txtEmailSI.Text);
            try
            {
                if (txtFisrNameSI.Text != "")
                {
                    if (txtLastNameSI.Text != "")
                    {
                        if (DtpDateOfBirthSI.Value < DateTime.Now.AddYears(-18))
                        {
                            if (txtEmailSI.Text != "")
                            {

                                if (txtPasswordSI.Text != "")
                                {
                                    if (exist == null)
                                    {
                                        utilisateur u = new utilisateur();
                                        u.Nom_utilisateur = txtFisrNameSI.Text;
                                        u.Prenom_utilisateur = txtLastNameSI.Text;
                                        u.DateNaissance_utilisateur = DtpDateOfBirthSI.Value;
                                        u.Email = txtEmailSI.Text;
                                        u.MotdePasse = txtPasswordSI.Text;
                                        db.utilisateurs.Add(u);
                                        db.SaveChanges();
                                        DialogResult = MessageBox.Show("Account created successfully, please go back to login", "Done", MessageBoxButtons.YesNo);
                                        if (DialogResult == DialogResult.Yes)
                                        {
                                            this.Hide();
                                            var form1 = new FrmLogin();
                                            form1.Closed += (s, args) => this.Close();
                                            form1.Show();
                                        }
                                        else
                                        {
                                            txtEmailSI.Text = null;
                                            txtFisrNameSI.Text = null;
                                            txtLastNameSI.Text = null;
                                            txtPasswordSI.Text = null;
                                            DtpDateOfBirthSI.Text = default;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("This email is already exist please enter a new email or login", "ERROR");
                                    }


                                }
                                else
                                {
                                    MessageBox.Show("Please Enter a valid Password", "ERROR");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please Enter a valid Email", "ERROR");
                            }
                        }
                        else
                        {
                            MessageBox.Show("You must be +18 years old", "ERROR");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter a valid Last Name", "ERROR");
                    }

                }
                else
                {
                    MessageBox.Show("Please Enter a valid First Name", "ERROR");
                }
            }
            catch (Exception ex)
            {
                if (ex.GetType().FullName == "System.Data.Entity.Infrastructure.DbUpdateException")
                {
                    MessageBox.Show("Email format should be like ___@___.com", "ERROR");
                }
                else
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new FrmLogin();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
    }
}
