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
    public partial class FormNewWorkShop : Form
    {
        UC_Workshop_New_Project UCWNP = new UC_Workshop_New_Project();
        UC_Workshop_New_Wall UCWNW = new UC_Workshop_New_Wall();
        UC_WorkshopNewClient UCWNC = new UC_WorkshopNewClient();
        UC_Workshop_New_Room UCWNR = new UC_Workshop_New_Room();
        UC_Workshop_New_Material UCWNM = new UC_Workshop_New_Material();
        public FormNewWorkShop()
        {
            InitializeComponent();
        }

        private void FormNewWorkShop_Load(object sender, EventArgs e)
        {
            UC_controle_Workshop("Client");
        }

        public void UC_controle_Workshop(string name)
        {


            switch (name)
            {
                case "Client":
                    this.Controls.Remove(UCWNP);
                    this.Controls.Remove(UCWNW);
                    this.Controls.Remove(UCWNR);
                    this.Controls.Remove(UCWNM);
                    this.Controls.Add(UCWNC);
                    UCWNC.Location = new Point(0, 125);
                    break;

                case "Project":
                    this.Controls.Remove(UCWNW);
                    this.Controls.Remove(UCWNR);
                    this.Controls.Remove(UCWNM);
                    this.Controls.Remove(UCWNC);
                    this.Controls.Add(UCWNP);
                    UCWNP.Location = new Point(0, 125);
                    break;

                case "Room":
                    this.Controls.Remove(UCWNW);
                    this.Controls.Remove(UCWNP);
                    this.Controls.Remove(UCWNM);
                    this.Controls.Remove(UCWNC);
                    this.Controls.Add(UCWNR);
                    UCWNR.Location = new Point(0, 125);
                    break;

                case "Wall":
                    this.Controls.Remove(UCWNR);
                    this.Controls.Remove(UCWNP);
                    this.Controls.Remove(UCWNM);
                    this.Controls.Remove(UCWNC);
                    this.Controls.Add(UCWNW);
                    UCWNW.Location = new Point(0, 125);
                    break;

                case "Material":
                    this.Controls.Remove(UCWNR);
                    this.Controls.Remove(UCWNP);
                    this.Controls.Remove(UCWNW);
                    this.Controls.Remove(UCWNC);
                    this.Controls.Add(UCWNM);
                    UCWNM.Location = new Point(0, 125);
                    break;
            }
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            UC_controle_Workshop("Client");
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            UC_controle_Workshop("Project");
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            UC_controle_Workshop("Room");
        }

        private void btnWall_Click(object sender, EventArgs e)
        {
            UC_controle_Workshop("Wall");
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            UC_controle_Workshop("Material");
        }
    }
}
