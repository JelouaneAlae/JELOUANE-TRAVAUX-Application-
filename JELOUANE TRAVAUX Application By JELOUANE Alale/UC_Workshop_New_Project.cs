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
    public partial class UC_Workshop_New_Project : UserControl
    {
        public UC_Workshop_New_Project()
        {
            InitializeComponent();
        }

        private void bunifuRadioButton1_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();

            if (rdExistingProject.Checked == true)
            {
                dgvExistingProject.Visible = true;
                txtProjectName.Enabled = false;
                dtpExpiryDate.Enabled = false;
                dtpStartingDate.Enabled = false;
                
                label1.Visible = true;
                lblProjectName.Visible = true;
                FillDgvProduit();
            }
            if (rdExistingProject.Checked == false)
            {
                dgvExistingProject.Visible = false;
                txtProjectName.Enabled = true;
                dtpExpiryDate.Enabled = true;
                dtpStartingDate.Enabled = true;
                
                lblProjectName.Visible = false;
                label1.Visible = false;
            }
        }

        public void FillDgvProduit()
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            dgvExistingProject.Rows.Clear();
            var query = db.projets.Where(s => s.ID_Client == ClsEmail.ID_CLIENt).ToList();
            for (int i = 0; i < query.Count; i++)
            {
                dgvExistingProject.Rows.Add(query[i].ID_Projet, query[i].Nom_projet, query[i].Datedebut_Projet,
                    query[i].DateFin_Projet, query[i].Etat_Projet);
            }
        }

        private void UC_Workshop_New_Project_Load(object sender, EventArgs e)
        {
            CultureInfo la = new CultureInfo(ClsEmail.keyLang);
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(la);
            dgvExistingProject.Columns.Add("ID", "ID");
            dgvExistingProject.Columns.Add("Name", "Name");
            dgvExistingProject.Columns.Add("Starting D", "Starting D");
            dgvExistingProject.Columns.Add("Expery D", "Expery D");
            dgvExistingProject.Columns.Add("Etat", "Etat");
        }

        private void dgvExistingProject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblProjectName.Text = dgvExistingProject.CurrentRow.Cells[1].Value.ToString();

            ClsEmail.ID_PROJECt = int.Parse(dgvExistingProject.CurrentRow.Cells[0].Value.ToString());
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if(rdExistingProject.Checked == true)
            {
                ClsEmail.ID_PROJECt = int.Parse(dgvExistingProject.CurrentRow.Cells[0].Value.ToString());
                var form1 = Form.ActiveForm as FormNewWorkShop;
                if (form1 != null)
                {
                    form1.btnRoom.PerformClick();
                }
            }

            if (rdExistingProject.Checked == false)
            {
                JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
                if (dtpExpiryDate.Value <= DateTime.Now)
                {
                    MessageBox.Show("expiry date cannot be now");
                }
                else
                {
                    projet pr = new projet();
                    pr.Datedebut_Projet = dtpStartingDate.Value;
                    pr.DateFin_Projet = dtpExpiryDate.Value;
                    pr.Nom_projet = txtProjectName.Text;
                    pr.ID_Client = ClsEmail.ID_CLIENt;
                    db.projets.Add(pr);
                    db.SaveChanges();

                    var a = db.projets.Where(o => o.ID_Client == ClsEmail.ID_CLIENt && o.Nom_projet == txtProjectName.Text).ToList();

                            
                    ClsEmail.ID_PROJECt = a[0].ID_Projet;
                    var form = Form.ActiveForm as FormNewWorkShop;
                    if (form != null)
                    {
                        form.btnRoom.PerformClick();
                    }
                        
                    
                }
            }
        }
    }
}
