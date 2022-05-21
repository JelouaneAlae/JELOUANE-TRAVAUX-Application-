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
    public partial class UC_Workshop_New_Material : UserControl
    {
        int index;
        public UC_Workshop_New_Material()
        {
            InitializeComponent();
        }

        private void UC_Workshop_New_Material_Load(object sender, EventArgs e)
        {
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
            index = e.RowIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filldgutiliser();
            FilldgvMaterial();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtQte.Text))
            //{
            //    MessageBox.Show("Qte can't be empty", "ERROR");
            //}
            //else
            //{
            //    JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();

            //    Utiliser U = new Utiliser();
            //    U.ID_Projet = ClsEmail.ID_PROJECt;
            //    U.Quantite_Utiliser = int.Parse(txtQte.Text);

            //    int materialprice = int.Parse(dgvMatreial.CurrentRow.Cells[3].Value.ToString());
            //    U.PrixQuantite = int.Parse(txtQte.Text) * materialprice;
            //    db.Utilisers.Add(U);
            //    db.SaveChanges();

            //    MessageBox.Show("yes");
            //    Filldgutilisateur();
            //}
        }

        private void btnDeleteEquipment_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEqupment_Click(object sender, EventArgs e)
        {
            foreach (Control C in Controls)
            {
                
                C.Visible = false;
            }

            pnlMaterial.Visible = true;
            pnlMaterial.Location = new Point(12, 8);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            foreach (Control C in Controls)
            {
                C.Visible = true;
            }
            pnlMaterial.Visible = false;

        }

        private void lblmaterialname_Click(object sender, EventArgs e)
        {

        }

        private void txtQte_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtColorSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }
    }
}
