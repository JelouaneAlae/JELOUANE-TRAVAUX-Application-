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
    public partial class UC_Workshop_New_Material : UserControl
    {
        int index;
        public UC_Workshop_New_Material()
        {
            InitializeComponent();
        }

        private void UC_Workshop_New_Material_Load(object sender, EventArgs e)
        {
            CultureInfo la = new CultureInfo(ClsEmail.keyLang);
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(la);
            dgvMatreial.Columns.Add("ID", "ID");
            dgvMatreial.Columns.Add("Name","Name");
            dgvMatreial.Columns.Add("Producer", "Producer");
            dgvMatreial.Columns.Add("Price", "Price");
            dgvMatreial.Columns.Add("Picture", "Picture");
            dgvMatreial.Columns.Add("Color", "Color");
            dgvMatreial.Columns.Add("genre", "genre");

            dgvUtliser.Columns.Add("ID", "ID");
            dgvUtliser.Columns.Add("Name","Name");
            dgvUtliser.Columns.Add("Color", "Color");
            dgvUtliser.Columns.Add("Genre", "Genre");
            dgvUtliser.Columns.Add("Quantity", "Quantity");
            dgvUtliser.Columns.Add("Price", "Price");
            FilldgvMaterial();
            Filldgutiliser();
        }
        public void FilldgvMaterial()
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            dgvMatreial.Rows.Clear();
            var MList = (from Materiel in db.Materiels
                               select Materiel).ToList();
            for (int i = 0; i < MList.Count; i++)
            {
                dgvMatreial.Rows.Add(MList[i].Id_Materiel,MList[i].Nom_Materiel, MList[i].Fondateur_Materiel, MList[i].Price_materiel, MList[i].Photo_Materiel, MList[i].Color_Materiel, MList[i].Genre_Materiel);
            }
        }

        public void Filldgutiliser()
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            dgvUtliser.Rows.Clear();
            var list = (from u in db.Utilisers
                        join m in db.Materiels on u.Id_Materiel equals m.Id_Materiel
                        where u.ID_Projet == ClsEmail.ID_PROJECt
                        select new { m.Id_Materiel, m.Nom_Materiel, m.Color_Materiel, m.Genre_Materiel, m.Quantity_Materiel, m.Price_materiel }).ToList();
            var quey = db.projets.Find(ClsEmail.ID_PROJECt);

            var name = quey.Nom_projet;
            for (int i = 0; i < list.Count; i++)
            {
                dgvUtliser.Rows.Add(list[i].Id_Materiel, name, list[i].Nom_Materiel, list[i].Color_Materiel, list[i].Genre_Materiel, list[i].Quantity_Materiel, list[i].Price_materiel);
            }
        }


        private void dgvMatreial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblmaterialname.Text = dgvMatreial.CurrentRow.Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filldgutiliser();
            FilldgvMaterial();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteEquipment_Click(object sender, EventArgs e)
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();

            int id = int.Parse(dgvMatreial.CurrentRow.Cells[0].Value.ToString());
            var itemsDeleted = db.Utilisers.Where(o=> o.ID_Projet== ClsEmail.ID_PROJECt && o.Id_Materiel == id).ToList();
            if (itemsDeleted != null)
            {
                db.Utilisers.Remove(itemsDeleted[0]);
                db.SaveChanges();
                MessageBox.Show("The product successfully deleted ");
            }
            else
            {
                MessageBox.Show("Please select the product you want to delete");
            }
            Filldgutiliser();
        }

        private void btnAddEqupment_Click(object sender, EventArgs e)
        {
            foreach (Control C in Controls)
            {
                
                C.Visible = false;
            }

            pnlMaterial.Visible = true;
            pnlMaterial.Location = new Point(12, 20);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            foreach (Control C in Controls)
            {
                C.Visible = true;
            }
            pnlMaterial.Visible = false;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtQte.Text))
                {
                    MessageBox.Show("Qte can't be empty", "ERROR");
                }
                else
                {
                    JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();


                    var exsist = db.Utilisers.Find(int.Parse(dgvMatreial.CurrentRow.Cells[0].Value.ToString()), ClsEmail.ID_PROJECt);
                    if (exsist != null)
                    {
                        MessageBox.Show("This material is already exist please select another one");
                    }
                    else
                    {
                        Utiliser U = new Utiliser();
                        U.Id_Materiel = int.Parse(dgvMatreial.CurrentRow.Cells[0].Value.ToString());
                        U.ID_Projet = ClsEmail.ID_PROJECt;
                        U.Quantite_Utiliser = int.Parse(txtQte.Text);

                        int materialprice = int.Parse(dgvMatreial.CurrentRow.Cells[3].Value.ToString());
                        U.PrixQuantite = int.Parse(txtQte.Text) * materialprice;
                        db.Utilisers.Add(U);
                        db.SaveChanges();

                        MessageBox.Show("The Product successfully Added");
                        Filldgutiliser();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void txtSreachMa_KeyUp(object sender, KeyEventArgs e)
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            dgvMatreial.Rows.Clear();

            var list = db.Materiels.Where(o => o.Nom_Materiel.StartsWith(txtSreachMa.Text)).ToList();
            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    dgvMatreial.Rows.Add(list[i].Id_Materiel, list[i].Nom_Materiel, list[i].Fondateur_Materiel, list[i].Price_materiel, list[i].Photo_Materiel, list[i].Color_Materiel, list[i].Genre_Materiel);
                }
            }
        }

        private void btnLiquid_Click_1(object sender, EventArgs e)
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            if (btnLiquid.BackColor == Color.White)
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


            if (btnLiquid.BackColor == Color.Pink)
            {
                var list = (from Materiel in db.Materiels where Materiel.Genre_Materiel == "Liquid" select Materiel).ToList();
                if (list != null)
                {
                    dgvMatreial.Rows.Clear();
                    for (int i = 0; i < list.Count; i++)
                    {
                        dgvMatreial.Rows.Add(list[i].Id_Materiel, list[i].Nom_Materiel, list[i].Fondateur_Materiel,
                            list[i].Price_materiel, list[i].Photo_Materiel, list[i].Color_Materiel,
                            list[i].Genre_Materiel);
                    }

                }
            }
            else
            {
                FilldgvMaterial();
            }
        }

        private void btnSolid_Click_1(object sender, EventArgs e)
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
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
                    dgvMatreial.Rows.Clear();
                    for (int i = 0; i < list.Count; i++)
                    {
                        dgvMatreial.Rows.Add(list[i].Id_Materiel, list[i].Nom_Materiel, list[i].Fondateur_Materiel,
                            list[i].Price_materiel, list[i].Photo_Materiel, list[i].Color_Materiel,
                            list[i].Genre_Materiel);
                    }

                }
            }
            else
            {
                FilldgvMaterial();
            }
        }

    }
}
