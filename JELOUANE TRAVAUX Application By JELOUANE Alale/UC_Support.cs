using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Globalization;

namespace JELOUANE_TRAVAUX_Application_By_JELOUANE_Alale
{
    public partial class UC_Support : UserControl
    {
        byte[] t;
        public UC_Support()
        {
            InitializeComponent();
        }

        private void UC_Support_Load(object sender, EventArgs e)
        {
            CultureInfo la = new CultureInfo(ClsEmail.keyLang);
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(la);
        }


        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                c.Visible = false;
            }
            pnlPassword.Visible = true;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Choose image or video";
            fd.Filter = "Image  Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                FileStream fl = new FileStream(fd.FileName, FileMode.Open);
                BinaryReader br = new BinaryReader(fl);
                t = br.ReadBytes((int)fl.Length);
                string Path = fd.FileName;
                fl.Close();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (pnlWarnin.Visible == false)
            {
                pnlWarnin.Visible = true;
            }
            else
            {
                pnlWarnin.Visible = false;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                c.Visible = true;
            }
            pnlPassword.Visible = false;

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPasswordGmail.Text))
            {
                MessageBox.Show("Please enter your gmail password ");
            }
            else
            {
                try
                {
                    NetworkCredential login;
                    SmtpClient client;
                    MailMessage mssg;
                    client = new SmtpClient();
                    client.UseDefaultCredentials = false;
                    client.Port = 587;
                    login = new NetworkCredential(ClsEmail.Email, txtPasswordGmail.Text);
                    client.EnableSsl = true;
                    client.Credentials = login;
                    client.Host = "smtp.gmail.com";
                    mssg = new MailMessage { From = new MailAddress(ClsEmail.Email, "Reset your pasword", Encoding.UTF8) };
                    mssg.To.Add(new MailAddress("3al1.original@gmail.com"));
                    mssg.Subject = "Report a problem";
                    mssg.IsBodyHtml = true;
                    client.EnableSsl = true;
                    string htmlbody = "<p>"+txtDescriptionReport.Text+"</p>";
                    //mail.Attachments.Add(new Attachment());
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
        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Message cannot send");
            }
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.ToString());
            }
            else
            {
                MessageBox.Show("Your Report message has been successfully sent.", "Message");
            }
        }

    }
}
