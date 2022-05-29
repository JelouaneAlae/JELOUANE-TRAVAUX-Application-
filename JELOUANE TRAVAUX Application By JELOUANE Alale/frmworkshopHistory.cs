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
    public partial class frmworkshopHistory : Form
    {
        public frmworkshopHistory()
        {
            InitializeComponent();
        }

        private void frmworkshopHistory_Load(object sender, EventArgs e)
        {
            FillcolumnsDgv();
            filldgvProject();
        }

        public void filldgvProject()
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            var ProjectList = (from projet in db.projets select projet).ToList();
            if(ProjectList != null)
            {
                dgvProject.Rows.Clear();
                for(int i = 0; i < ProjectList.Count; i++)
                {
                    dgvProject.Rows.Add(ProjectList[i].ID_Projet, ProjectList[i].Nom_projet, ProjectList[i].Datedebut_Projet,
                        ProjectList[i].DateFin_Projet, ProjectList[i].Etat_Projet);
                }
            }
        }
        public void FillcolumnsDgv()
        {
            dgvProject.Columns.Add("ID","ID");
            dgvProject.Columns.Add("Name", "Name");
            dgvProject.Columns.Add("Starting D", "Starting D");
            dgvProject.Columns.Add("Expiry D", "Expiry D");
            dgvProject.Columns.Add("Stat", "Stat");
        }

        private void txtSreachMa_KeyUp(object sender, KeyEventArgs e)
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            dgvProject.Rows.Clear();

            var list = db.projets.Where(o => o.Nom_projet.StartsWith(txtSreachWorkshop.Text)).ToList();
            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    dgvProject.Rows.Add(list[i].ID_Projet, list[i].Nom_projet, list[i].Datedebut_Projet,
                                            list[i].DateFin_Projet, list[i].Etat_Projet);
                }
            }
        }

        private void btnDeleteEquipment_Click(object sender, EventArgs e)
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();

            DialogResult dr = MessageBox.Show("Are you sur you want to delete this project ","delete",MessageBoxButtons.YesNo);

            if(dr == DialogResult.Yes)
            {
                int id = int.Parse(dgvProject.CurrentRow.Cells[0].Value.ToString());
                var itemsDeleted = db.projets.Where(o => o.ID_Projet == id).ToList();
                if (itemsDeleted != null)
                {
                    db.projets.Remove(itemsDeleted[0]);
                    db.SaveChanges();
                    MessageBox.Show("The product successfully deleted ");
                }
                else
                {
                    MessageBox.Show("Please select the product you want to delete");
                }
                filldgvProject();
            }

        }

        private void dgvProject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddEqupment_Click(object sender, EventArgs e)
        {
            var form = Form.ActiveForm as frmworkshopHistory;
            if (form != null)
            {
                
                form.Hide();
                var form1 = new FormNewWorkShop();
                form1.Closed += (s, args) => form.Close();
                form1.Show();
            }
        }

        private void bunifuDatePicker2_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("yes");

            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            var ProjectList = (from projet in db.projets
                               where (projet.Datedebut_Projet >= (DateTime)dtpStartingDate.Value && projet.Datedebut_Projet <= (DateTime)dtpEndingDate.Value)
                               select projet).ToList();
            if (ProjectList != null)
            {
                dgvProject.Rows.Clear();
                for (int i = 0; i < ProjectList.Count; i++)
                {
                    dgvProject.Rows.Add(ProjectList[i].ID_Projet, ProjectList[i].Nom_projet, ProjectList[i].Datedebut_Projet,
                        ProjectList[i].DateFin_Projet, ProjectList[i].Etat_Projet);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = Form.ActiveForm as frmworkshopHistory;
            if (form != null)
            {

                form.Hide();
                var form1 = new FrmMainForm();
                form1.Closed += (s, args) => form.Close();
                form1.Show();
            }
        }

        private void btnEditEquipment_Click(object sender, EventArgs e)
        {
            ClsEmail.ID_PROJECt = int.Parse(dgvProject.CurrentRow.Cells[0].Value.ToString());
            var form = Form.ActiveForm as frmworkshopHistory;
            if (form != null)
            {

                form.Hide();
                var form1 = new FormNewWorkShop();
                form1.Closed += (s, args) => form.Close();
                form1.Show();
            }
            var form2 = Form.ActiveForm as FormNewWorkShop;
            form2.btnRoom.PerformClick();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            filldgvProject();
        }
    }
}
