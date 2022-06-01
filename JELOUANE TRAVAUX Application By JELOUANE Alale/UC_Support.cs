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

namespace JELOUANE_TRAVAUX_Application_By_JELOUANE_Alale
{
    public partial class UC_Support : UserControl
    {
        byte[] t;
        public UC_Support()
        {
            InitializeComponent();
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_Support_Load(object sender, EventArgs e)
        {
            
        }

        private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblChooseanarea_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {

            try
            {
                NetworkCredential login;
                SmtpClient client = new SmtpClient();
                MailMessage mssg = new MailMessage(ClsEmail.Email,"3al1.original@gmail.com");
                client = new SmtpClient();
                client.UseDefaultCredentials = false;
                client.Port = 25;
                login = new NetworkCredential(ClsEmail.Email,);

                client.EnableSsl = true;
                client.Credentials = new System.Net.NetworkCredential();
                client.Host = "smtp.gmail.com";
                mssg = new MailMessage { From = new MailAddress("3al1original@gmail.com", "Reset your pasword", Encoding.UTF8) };
                mssg.To.Add(new MailAddress("3al1.original@gmail.com"));
                mssg.Subject = "Report a problem";
                mssg.IsBodyHtml = true;
                client.EnableSsl = true;
                string htmlbody = "<p><strong>Hello,</strong></p>" +
                    "<p>We have sent you this email in response to your request to reset your password on <strong>JELOUANE TRAVAUX</strong> .</p>" +
                    "<p>Please use the code below code to <strong>reset the password</strong> :</p>" ;
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

        private void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            throw new NotImplementedException();
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
                //picImageEquipement.Image = new Bitmap(fl);
                fl.Close();
            }
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {

        }

        private void picusername_Click(object sender, EventArgs e)
        {

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
    }
}
