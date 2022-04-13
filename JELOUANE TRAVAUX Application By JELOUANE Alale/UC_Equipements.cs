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

namespace JELOUANE_TRAVAUX_Application_By_JELOUANE_Alale
{
    public partial class UC_Equipements : UserControl
    {
        DataTable dt;
        JELOUANE_TRAVAUXEntities2 db = new JELOUANE_TRAVAUXEntities2();
        int IDE;
        string NameE;
        string indexdatagv;
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
            //JELOUANE_TRAVAUXEntities2 db1 = new JELOUANE_TRAVAUXEntities2();
            //dgvEqupmenet.DataSource = db1.Materiels.ToList<Materiel>();
        }

        private void dgvEqupmenet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexdatagv = e.ToString();
            IDE = int.Parse(dgvEqupmenet.CurrentRow.Cells[0].Value.ToString());
            ClsEmail.IdEquipment = IDE;
            NameE = dgvEqupmenet.CurrentRow.Cells[1].Value.ToString();
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
            JELOUANE_TRAVAUXEntities2 db2 = new JELOUANE_TRAVAUXEntities2();
            dgvEqupmenet.DataSource = null;
            dgvEqupmenet.DataSource = db2.Materiels.ToList<Materiel>();
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
            dgvEqupmenet.DataSource = null;
            //Materiel mt = new Materiel();
            //mt = db.Materiels.Where(x => x.Nom_Materiel == txtSrearchEq.Text).First();
            //if (mt == null)
            //{
            //    MessageBox.Show("matereil not found");
            //}
            //else
            //{
            //    DataSet ds = new DataSet();
            //    ds.Tables.Add("resultSearsh");
            //    ds.Tables[0].Columns.Add("ID");
            //    ds.Tables[0].Columns.Add("Name");
            //    ds.Tables[0].Columns.Add("fondateur");
            //    ds.Tables[0].Columns.Add("Price");
            //    ds.Tables[0].Columns.Add("picture");
            //    ds.Tables[0].Columns.Add("Color");
            //    ds.Tables[0].Columns.Add("genre");
            //    ds.Tables[0].Columns.Add("Quantity");
            //    ds.Tables[0].Rows.Add(mt.Id_Materiel, mt.Nom_Materiel, mt.Fondateur_Materiel, 
            //        mt.Price_materiel, mt.Photo_Materiel, mt.Color_Materiel, mt.Genre_Materiel, mt.Quantity_Materiel);

            //    dgvEqupmenet.DataSource = ds.Tables[0];
            //}



        }
    }
}
