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
    public partial class FrmMainForm : Form
    {
        UCHome UCH = new UCHome();
        UC_Workshop UCWS = new UC_Workshop();
        UC_Equipements UCE = new UC_Equipements();
        JELOUANE_TRAVAUXEntities2 db = new JELOUANE_TRAVAUXEntities2();

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

        private void button6_Click(object sender, EventArgs e)
        {
            pnlsetting.Visible = false;
            PnlverticalMenu("pnlverticalhome");
            UC_controle("Home");
            this.Controls.Remove(UCGS);
            pnlHead.Size = new Size(734, 85);
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
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            PnlverticalMenu("pnlverticalworkshop");
            pnlsetting.Visible = false;
            UC_controle("Workshop");
            this.Controls.Remove(UCGS);
            pnlHead.Size = new Size(734, 88);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PnlverticalMenu("pnlverticalEquipment");
            UC_controle("Equipements");
            pnlsetting.Visible = false;
            this.Controls.Remove(UCGS);
            pnlHead.Size = new Size(734, 85);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PnlverticalMenu("pnlverticalSupport");
            pnlsetting.Visible = false;
            this.Controls.Remove(UCGS);
            pnlHead.Size = new Size(734, 85);
            UC_controle("Support");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PnlverticalMenu("pnlverticalSetting");
            UC_controle("Setting");
            UC_seeting_Control("Generale");
            pnlsetting.Visible = true;
            pnlHead.Size = new Size(734, 103);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if(PnlMenu.Size == new Size(193, 498))
            //{
            //    PnlMenu.Size = new Size(45, 540);
            //    btnoff.Location = new Point(833, 3);
            //    btnProfile.Location = new Point(781, 3);
            //    BtnInbox.Location = new Point(729 ,3);

            //}
            //else
            //{
            //    PnlMenu.Size = new Size(193, 498);
            //    btnoff.Location = new Point(685, 3);
            //    btnProfile.Location = new Point(633, 3);
            //    BtnInbox.Location = new Point(581, 3);
            //}
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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            //UC_Profile UCP = new UC_Profile();
            //this.Controls.Add(UCP);
            //UCP.Location = new Point(790, 77);
            //if (panelProfile.Visible == false)
            //{
            //    panelProfile.Visible = true;
            //}
            //else
            //{
            //    panelProfile.Visible = false;
            //}
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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

        private void pnlsetting_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
