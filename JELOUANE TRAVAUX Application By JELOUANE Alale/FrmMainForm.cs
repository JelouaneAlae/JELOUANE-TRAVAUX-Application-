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
    public partial class FrmMainForm : Form
    {
        UCHome UCH = new UCHome();
        UC_Workshop UCWS = new UC_Workshop();
        UC_Equipements UCE = new UC_Equipements();
        JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
        UC_Setting_Generale UCGS = new UC_Setting_Generale();
        UC_AccountSetting UCAS = new UC_AccountSetting();
        UC_NotificationSetting UCNS = new UC_NotificationSetting();
        UC_Privacy_Setting UCPS = new UC_Privacy_Setting();
        UC_About_setting UCASs = new UC_About_setting();
        UC_Support UCS = new UC_Support();
        ClsEmail clsmail = new ClsEmail();

        public FrmMainForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void removeSettingUC()
        {
            this.Controls.Remove(UCGS);
            this.Controls.Remove(UCAS);
            this.Controls.Remove(UCNS);
            this.Controls.Remove(UCPS);
            this.Controls.Remove(UCASs);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            pnlsetting.Visible = false;
            PnlverticalMenu("pnlverticalhome");
            UC_controle("Home");
            this.Controls.Remove(UCGS);
            pnlHead.Size = new Size(734, 85);
            removeSettingUC();
            
        }
        public void PnlverticalMenu(string name)
        {
            switch (name)
            {
                case "pnlverticalhome":
                    pnlverticalhome.Visible = true;
                    pnlverticalworkshop.Visible = false;
                    pnlverticalEquipment.Visible = false;
                    pnlverticalSupport.Visible = false;
                    pnlverticalSetting.Visible = false;
                    break;

                case "pnlverticalworkshop":
                    pnlverticalhome.Visible = false;
                    pnlverticalworkshop.Visible = true;
                    pnlverticalEquipment.Visible = false;
                    pnlverticalSupport.Visible = false;
                    pnlverticalSetting.Visible = false;
                    break;

                case "pnlverticalEquipment":
                    pnlverticalhome.Visible = false;
                    pnlverticalworkshop.Visible = false;
                    pnlverticalEquipment.Visible = true;
                    pnlverticalSupport.Visible = false;
                    pnlverticalSetting.Visible = false;
                    break;

                case "pnlverticalSetting":
                    pnlverticalhome.Visible = false;
                    pnlverticalworkshop.Visible = false;
                    pnlverticalEquipment.Visible = false;
                    pnlverticalSupport.Visible = false;
                    pnlverticalSetting.Visible = true;
                    break;

                case "pnlverticalSupport":
                    pnlverticalhome.Visible = false;
                    pnlverticalworkshop.Visible = false;
                    pnlverticalEquipment.Visible = false;
                    pnlverticalSupport.Visible = true;
                    pnlverticalSetting.Visible = false;
                    break;

                default:
                    pnlverticalhome.Visible = false;
                    pnlverticalworkshop.Visible = false;
                    pnlverticalEquipment.Visible = false;
                    pnlverticalSupport.Visible = false;
                    pnlverticalSetting.Visible = false;
                    break;



            }
        }

        private void FrmMainForm_Load(object sender, EventArgs e)
        {
            FrmLogin frml = new FrmLogin(); 
            frml.Visible = false;
            PnlverticalMenu("pnlverticalhome");
            UC_controle("Home");
            var N = db.Notifications.Where(o => o.visibility == false).ToList();
            lblNotificatonCount.Text = N.Count.ToString();              

        }

         public void NotificationItems()
         {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            var N = db.Notifications.Where(o => o.visibility == false).ToList();
            if (N.Count > 0)
            {
                UC_NotificationItems[] ls = new UC_NotificationItems[N.Count()];

                flowLayoutPanel1.Controls.Clear();
                for (int i = 0; i < ls.ToList().Count; i++)
                {
                    ls[i] = new UC_NotificationItems();

                    var OBproject = (from projet in db.projets.ToList() where projet.ID_Projet == db.Notifications.ToList()[i].id_Project select projet.Nom_projet).ToList();
                    var notification = db.Notifications.ToList()[i];
                    ls[i]._ProjectName = OBproject[0]; ;
                    ls[i]._Notification_description = notification.message_notification;
                    flowLayoutPanel1.Controls.Add(ls[i]);
                    var No = db.Notifications.Where(o => o.visibility == false).ToList();
                    lblNotificatonCount.Text = No.Count.ToString();
                }
            }
            if(N.Count==0)
            {
                //Label l = new Label();
                //l.Text = "No notification found";
                //l.Font = new Font("Microsoft Sans Serif", 10);
                //flowLayoutPanel1.Controls.Add(l);
                MessageBox.Show("No notification found");
                n.Text = "No notification found";
                n.Visible = true;
                flowLayoutPanel1.Visible = false;

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            PnlverticalMenu("pnlverticalworkshop");
            pnlsetting.Visible = false;
            UC_controle("Workshop");
            this.Controls.Remove(UCGS);
            pnlHead.Size = new Size(734, 88);
            removeSettingUC();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PnlverticalMenu("pnlverticalEquipment");
            UC_controle("Equipements");
            pnlsetting.Visible = false;
            this.Controls.Remove(UCGS);
            pnlHead.Size = new Size(734, 85);
            removeSettingUC();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PnlverticalMenu("pnlverticalSupport");
            pnlsetting.Visible = false;
            this.Controls.Remove(UCGS);
            pnlHead.Size = new Size(734, 85);
            UC_controle("Support");

            removeSettingUC();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PnlverticalMenu("pnlverticalSetting");
            UC_controle("Setting");
            UC_seeting_Control("Generale");
            pnlsetting.Visible = true;
            pnlHead.Size = new Size(734, 103);
            removeSettingUC();
            UC_seeting_Control("Generale");
        }

        public void UC_controle(string name)
        {


            switch (name)
            {
                case "Home":
                    this.Controls.Remove(UCE);
                    this.Controls.Remove(UCS);
                    this.Controls.Remove(UCWS);
                    this.Controls.Add(UCH);
                    UCH.Location = new Point(199, 97);
                    break;

                case "Workshop":
                    this.Controls.Remove(UCE);
                    this.Controls.Remove(UCS);
                    this.Controls.Remove(UCH);
                    this.Controls.Add(UCWS);
                    UCWS.Location = new Point(199, 105);
                    break;

                case "Equipements":
                    this.Controls.Remove(UCWS);
                    this.Controls.Remove(UCS);
                    this.Controls.Remove(UCH);
                    this.Controls.Add(UCE);
                    UCE.Location = new Point(199, 102);
                    break;

                case "Setting":
                    this.Controls.Remove(UCWS);
                    this.Controls.Remove(UCH);
                    this.Controls.Remove(UCE);
                    this.Controls.Remove(UCS);
                    break;

                case "Support":
                    this.Controls.Remove(UCWS);
                    this.Controls.Remove(UCH);
                    this.Controls.Remove(UCE);
                    this.Controls.Add(UCS);
                    UCS.Location = new Point(199, 102);
                    break;
            }

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void BtnInbox_Click(object sender, EventArgs e)
        {
            if(flowLayoutPanel1.Visible == false)
            {
                flowLayoutPanel1.Visible = true;
                NotificationItems();
            }
            else
            {
                flowLayoutPanel1.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            btnSetting.PerformClick();
            btnAccountSetting.PerformClick();
        }


        private void button12_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(UCAS);
            this.Controls.Remove(UCASs);
            this.Controls.Remove(UCNS);
            this.Controls.Remove(UCPS);
            UC_seeting_Control("Generale");

        }


        private void button11_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(UCASs);
            this.Controls.Remove(UCNS);
            this.Controls.Remove(UCPS);
            this.Controls.Remove(UCGS);
            UC_seeting_Control("Account");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(UCAS);
            this.Controls.Remove(UCASs);
            this.Controls.Remove(UCPS);
            this.Controls.Remove(UCGS);
            UC_seeting_Control("Notification");
        }

        public void UC_seeting_Control(string name)
        {


            switch (name)
            {
                case "Generale":
                    this.Controls.Add(UCGS);
                    UCGS.Location = new Point(359, 120);
                    break;

                case "Account":
                    this.Controls.Add(UCAS);
                    UCAS.Location = new Point(359, 120);
                    break;

                case "Notification":
                    this.Controls.Add(UCNS);
                    UCNS.Location = new Point(359, 120);
                    break;

                case "Security":
                    this.Controls.Add(UCPS);
                    UCPS.Location = new Point(359, 120);
                    break;

                case "About":
                    this.Controls.Add(UCASs);
                    UCASs.Location = new Point(359, 120);
                    break;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(UCAS);
            this.Controls.Remove(UCASs);
            this.Controls.Remove(UCNS);
            this.Controls.Remove(UCGS);
            UC_seeting_Control("Security");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Controls.Remove(UCAS);
            this.Controls.Remove(UCNS);
            this.Controls.Remove(UCPS);
            this.Controls.Remove(UCGS);
            UC_seeting_Control("About");
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
