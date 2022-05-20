using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

namespace JELOUANE_TRAVAUX_Application_By_JELOUANE_Alale
{
    public partial class UC_Equipements : UserControl
    {
        //JELOUANE_TRAVAUXEntities4 db = new JELOUANE_TRAVAUXEntities4();
        JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
        int IDE;
        string NameE;
        string indexdatagv;
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-3PA9N2V;Initial Catalog=JELOUANE_TRAVAUX;Integrated Security=True");
        DataSet ds;
        public UC_Equipements()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmNewEquipment frmne = new frmNewEquipment();
            frmne.Show();
        }

        private void UC_Equipements_Load(object sender, EventArgs e)
        {
            //JELOUANE_TRAVAUXEntities4 db = new JELOUANE_TRAVAUXEntities4();
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            dgvEqupmenet.DataSource = db.Materiels.ToList<Materiel>();
        }

        private void dgvEqupmenet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var exist = db.Materiels.Find(IDE);

                if (exist != null)
                {
                    DialogResult FD = MessageBox.Show("Do you want to remove " + NameE, "ERROR", MessageBoxButtons.YesNo);
                    if (FD == DialogResult.Yes)
                    {
                        db.Materiels.Remove(exist);
                        db.SaveChanges();
                        MessageBox.Show("Successfully update");
                        dgvEqupmenet.DataSource = db.Materiels.ToList<Materiel>();
                    }

                }
                else
                {
                    MessageBox.Show("Material not exist");
                }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //JELOUANE_TRAVAUXEntities4 db = new JELOUANE_TRAVAUXEntities4();
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            dgvEqupmenet.DataSource = null;
            dgvEqupmenet.DataSource = db.Materiels.ToList<Materiel>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(indexdatagv == null)
            {
                MessageBox.Show("Please select one");
            }
            else
            {
                var exist = db.Materiels.Find(ClsEmail.IdEquipment);
                if (exist != null)
                {
                    FrmEditEqupement frmEE = new FrmEditEqupement();
                    frmEE.Show();
                }
                else
                {
                    MessageBox.Show("materiel Not exist");
                }
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(btnLiquid.BackColor == Color.White )
            {
                btnLiquid.BackColor = Color.Pink;
            }
            else
            {
                btnLiquid.BackColor = Color.White;
            }
            if (btnLiquid.BackColor == Color.Pink)
            {
                btnSolid.BackColor = Color.White;
            }


            if(btnLiquid.BackColor == Color.Pink)
            {
                dgvEqupmenet.DataSource = db.Materiels.ToList<Materiel>();

                for (int i = 0; i < dgvEqupmenet.Rows.Count; i++)
                {
                    if (dgvEqupmenet.Rows[i].Cells[4].Value.ToString() == "Solid")
                    {
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvEqupmenet.DataSource];
                        currencyManager1.SuspendBinding();
                        dgvEqupmenet.Rows[i].Visible = false;
                        currencyManager1.ResumeBinding();
                    }
                }
            }
            else
            {
                dgvEqupmenet.DataSource = db.Materiels.ToList<Materiel>();
            }
        }

        private void btnSolid_Click(object sender, EventArgs e)
        {
            
            if (btnSolid.BackColor == Color.White)
            {
                btnSolid.BackColor = Color.Pink;
            }
            else
            {
                btnSolid.BackColor = Color.White;
            }

            if (btnSolid.BackColor == Color.Pink)
            {
                btnLiquid.BackColor = Color.White;
            }

            if (btnSolid.BackColor == Color.Pink)
            {
                dgvEqupmenet.DataSource = db.Materiels.ToList<Materiel>();
                for (int i = 0; i < dgvEqupmenet.Rows.Count; i++)
                {
                    if (dgvEqupmenet.Rows[i].Cells[4].Value.ToString() == "Liquid")
                    {
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvEqupmenet.DataSource];
                        currencyManager1.SuspendBinding();
                        dgvEqupmenet.Rows[i].Visible = false;
                        currencyManager1.ResumeBinding();
                    }
                }
            }
            else
            {
                dgvEqupmenet.DataSource = db.Materiels.ToList<Materiel>();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //dgvEqupmenet.DataSource = null;

        }

        private void dgvEqupmenet_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            indexdatagv = e.ToString();
            IDE = int.Parse(dgvEqupmenet.CurrentRow.Cells[0].Value.ToString());
            ClsEmail.IdEquipment = IDE;
            NameE = dgvEqupmenet.CurrentRow.Cells[1].Value.ToString();
        }

        private void txtSrearchEq_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //JELOUANE_TRAVAUXEntities4 db = new JELOUANE_TRAVAUXEntities4();
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            dgvEqupmenet.DataSource = db.Materiels.ToList<Materiel>();
            DataTable dt = new DataTable("M");

            for (int i = 0; i < dgvEqupmenet.Rows.Count; i++)
            {
                if (dgvEqupmenet.Rows[i].Cells[1].Value.ToString() == txtSrearchEq.Text)
                {
                    dt.Columns.Add("ID");
                    dt.Columns.Add("Name");
                    dt.Columns.Add("Picture");
                    dt.Columns.Add("Color");
                    dt.Columns.Add("Genre");
                    dt.Columns.Add("Fondation");
                    dt.Columns.Add("Quantity");
                    dt.Columns.Add("Price");

                    byte[] tabimg = (byte[])dgvEqupmenet.Rows[i].Cells[2].Value;

                    MemoryStream ms = new MemoryStream(tabimg);
                    dt.Rows.Add(dgvEqupmenet.Rows[i].Cells[0].Value, dgvEqupmenet.Rows[i].Cells[1].Value, Image.FromStream(ms),
                        dgvEqupmenet.Rows[i].Cells[3].Value, dgvEqupmenet.Rows[i].Cells[4].Value, dgvEqupmenet.Rows[i].Cells[5].Value,
                        dgvEqupmenet.Rows[i].Cells[6].Value, dgvEqupmenet.Rows[i].Cells[7].Value);
                    
                }
            }
            dgvEqupmenet.DataSource = dt;

        }
    }
}
