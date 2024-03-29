﻿using System;
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
        JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
        string codemail;
        ClsEmail clsemail = new ClsEmail();
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
                    ClsEmail.Email= exist.Email;
                    client = new SmtpClient();
                    client.UseDefaultCredentials = false;
                    client.Port = 587;
                    login = new NetworkCredential("3al1original@gmail.com", "3al1@@37");

                    client.EnableSsl = true;
                    client.Credentials = login;
                    client.Host = "smtp.gmail.com";
                    mssg = new MailMessage { From = new MailAddress("3al1original@gmail.com", "Reset your pasword", Encoding.UTF8) };
                    mssg.To.Add(new MailAddress(txtEmailFP.Text));
                    mssg.Subject = "Forget Pass";
                    mssg.IsBodyHtml = true;
                    client.EnableSsl = true;
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
                MessageBox.Show(e.Error.ToString());
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
            var form = Form.ActiveForm as FrmLogin;
            if (form != null)
            {
                form.btnSignIn.Visible = false;
                form.lblOR.Visible = false;
            }
        }

        private void btnSubmitFP_Click(object sender, EventArgs e)
        {
            if (txtEmailcodeFP.Text == codemail)
            {
                F = 0;
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
                F++;
                if (F >= 3)
                {
                    DialogResult a =  MessageBox.Show("You entered the wrong code too many times, do you need to resend it", "ERROR", MessageBoxButtons.YesNo);
                    if(a == DialogResult.Yes)
                    {
                        txtEmailcodeFP.Text = null;
                        try
                        {
                            login = new NetworkCredential("3al1original@gmail.com", "A3J789#3al123");
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
                            MessageBox.Show(ex.Message, "ERROR");
                        }
                    }
                   
                }
                else
                {
                    MessageBox.Show("please enter the correct code exist in your email inbox", "ERROR", MessageBoxButtons.OK);
                }

            }
        }
    }
}
