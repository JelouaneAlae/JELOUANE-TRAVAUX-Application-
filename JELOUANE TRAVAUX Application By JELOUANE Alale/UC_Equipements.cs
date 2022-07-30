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
using System.Globalization;

namespace JELOUANE_TRAVAUX_Application_By_JELOUANE_Alale
{
    public partial class UC_Equipements : UserControl
    {
        JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
        int IDE;
        string NameE;
        string indexdatagv;

        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-3PA9N2V;Initial Catalog=JELOUANE_TRAVAUX;Integrated Security=True");
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
            dgvEqupmenet.Columns.Add("ID", "ID");
            dgvEqupmenet.Columns.Add("Name", "Name");
            dgvEqupmenet.Columns.Add("Producer", "Producer");
            dgvEqupmenet.Columns.Add("Price", "Price");
            dgvEqupmenet.Columns.Add("Picture", "Picture");
            dgvEqupmenet.Columns.Add("Color", "Color");
            dgvEqupmenet.Columns.Add("Genre", "Genre");
            filldMaterial();


            CultureInfo la = new CultureInfo(ClsEmail.keyLang);
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(la);
        }
        public void filldMaterial()
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            dgvEqupmenet.Rows.Clear();
            var query = (from Materiel in db.Materiels select Materiel).ToList();
            if (query != null)
            {
                for (int i = 0; i < query.Count; i++)
                {
                    //MemoryStream ms = new MemoryStream(query[i].Photo_Materiel);
                    //Image imageform = Image.FromStream(ms);

                    //Image img = imageform;

                    dgvEqupmenet.Rows.Add(query[i].Id_Materiel, query[i].Nom_Materiel, query[i].Fondateur_Materiel,
                        query[i].Price_materiel, null, query[i].Color_Materiel, query[i].Genre_Materiel);
                }

            }
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
                    filldMaterial();
                    }

                }
                else
                {
                    MessageBox.Show("Material not exist");
                }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            filldMaterial();
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
                var list = (from Materiel in db.Materiels where Materiel.Genre_Materiel == "Liquid" select Materiel).ToList();
                if (list != null)
                {
                    dgvEqupmenet.Rows.Clear();
                    for(int i = 0; i < list.Count;i++)
                    {
                        dgvEqupmenet.Rows.Add(list[i].Id_Materiel, list[i].Nom_Materiel, list[i].Fondateur_Materiel,
                            list[i].Price_materiel, list[i].Photo_Materiel, list[i].Color_Materiel,
                            list[i].Genre_Materiel);
                    }

                }
            }
            else
            {
                filldMaterial();
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
                var list = (from Materiel in db.Materiels where Materiel.Genre_Materiel == "Solid" select Materiel).ToList();
                if (list != null)
                {
                    dgvEqupmenet.Rows.Clear();
                    for (int i = 0; i < list.Count; i++)
                    {
                        dgvEqupmenet.Rows.Add(list[i].Id_Materiel, list[i].Nom_Materiel, list[i].Fondateur_Materiel,
                            list[i].Price_materiel, list[i].Photo_Materiel, list[i].Color_Materiel,
                            list[i].Genre_Materiel);
                    }

                }
            }
            else
            {
                filldMaterial();
            }
        }

        private void dgvEqupmenet_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            indexdatagv = e.ToString();
            IDE = int.Parse(dgvEqupmenet.CurrentRow.Cells[0].Value.ToString());
            ClsEmail.IdEquipment = IDE;
            NameE = dgvEqupmenet.CurrentRow.Cells[1].Value.ToString();
        }


        private void bunifuTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            dgvEqupmenet.Rows.Clear();

            var list = db.Materiels.Where(o => o.Nom_Materiel.StartsWith(txtSreachMa.Text)).ToList();
            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    dgvEqupmenet.Rows.Add(list[i].Id_Materiel, list[i].Nom_Materiel, list[i].Fondateur_Materiel, list[i].Price_materiel, list[i].Photo_Materiel, list[i].Color_Materiel, list[i].Genre_Materiel);
                }
            }
        }
    }
}
