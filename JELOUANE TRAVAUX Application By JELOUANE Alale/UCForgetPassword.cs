using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace JELOUANE_TRAVAUX_Application_By_JELOUANE_Alale
{
    public partial class UCForgetPassword : UserControl
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage mssg;
        int F;
        int partCode1;
        int PartCode2;
        JELOUANE_TRAVAUXEntities2 db = new JELOUANE_TRAVAUXEntities2();
        string Email;
        string codemail;
        public UCForgetPassword()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var exist = db.utilisateurs.Find(txtEmailFP.Text);
            if (exist != null)
            {
                try
                {
                    login = new NetworkCredential("3al1original@gmail.com", "ALAEORG31");
                    client = new SmtpClient();
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.Credentials = login;
                    client.Host = "smtp.gmail.com";
                    mssg = new MailMessage { From = new MailAddress("3al1original@gmail.com", "Reset your pasword", Encoding.UTF8) };
                    mssg.To.Add(new MailAddress(txtEmailFP.Text));
                    mssg.Subject = "Forget Pass";
                    mssg.IsBodyHtml = true;
                    codemail = GenerateCodeFP();
                    string htmlbody = "<p><strong>Hello,</strong></p>" +
                        "<p>We have sent you this email in response to your request to reset your password on <strong>JELOUANE TRAVAUX</strong> .</p>" +
                        "<p>Please use the code below code to <strong>reset the password</strong> :</p>" + codemail;
                    GenerateCodeFP();
                    mssg.Body = htmlbody;
                    mssg.BodyEncoding = Encoding.UTF8;
                    mssg.Priority = MailPriority.Normal;
                    mssg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                    client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
                    string userstate = "sending..";

                    client.SendAsync(mssg, userstate);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"ERROR");
                }


                btnSubmitFP.Visible = true;
                btnSendEmailFP.Visible = false;
                btnSubmitFP.Location = new Point(11, 163);
                lblFP.Text = "Enter the code sent to \nyour email inbox";
                txtEmailcodeFP.Visible = true;
                picCodeFp.Visible = true;
            }
            else
            {
                MessageBox.Show("Email not found . Please enter an existing email", "Error", MessageBoxButtons.OK);
            }

        }
        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("NO");
            }              
            if (e.Error != null)
            {
                MessageBox.Show("ERROR");
            }
            else
            {
                MessageBox.Show("Your message has been successfully sent.", "Message");
            }
        }


        public string GenerateCodeFP()
        {
            Random rnd = new Random();

            for (int j = 0; j < 1; j++)
            {
                partCode1 = rnd.Next(0, 999);
            }
            for (int i = 0; i < 1; i++)
            {
                PartCode2 = rnd.Next(0, 999);
            }

            string GenerateCode = (partCode1).ToString() + (PartCode2).ToString();
            return GenerateCode;
        }

        private void UCForgetPassword_Load(object sender, EventArgs e)
        {
            txtEmailFP.Visible = true;
            picCodeFp.Visible = false;
            //txtEmailF_P.Visible = false;
            var form = Form.ActiveForm as FrmLogin;
            if (form != null)
            {
                form.btnSignIn.Visible = false;
                form.lblOR.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmitFP_Click(object sender, EventArgs e)
        {

            if (txtEmailcodeFP.Text == codemail)
            {
                frmNewPass frmnp = new frmNewPass();
                frmnp.Show();
                //F = 0;
                MessageBox.Show("code s7i7");

                var form = Form.ActiveForm as FrmLogin;
                if (form != null)
                {
                    form.hideform();
                    var form1 = new frmNewPass();
                    form1.Closed += (s, args) => form.closeform();
                    form1.Show();

                }
            }
            else
            {
                //F++;
                //if (F >= 3)
                //{
                //    MessageBox.Show("please enter the correct code exist in your email inbox", "ERROR", MessageBoxButtons.OK);
                //}
                MessageBox.Show("ERROR", "ERROR", MessageBoxButtons.OK);

            }
        }

        private void txtCodeEmailFP_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
