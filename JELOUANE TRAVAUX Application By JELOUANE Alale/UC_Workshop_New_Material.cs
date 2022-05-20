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
        public UC_Workshop_New_Material()
        {
            InitializeComponent();
        }

        private void UC_Workshop_New_Material_Load(object sender, EventArgs e)
        {
            dgvMatreial.Columns.Add("Name","Name");
            dgvMatreial.Columns.Add("Producer", "Producer");
            dgvMatreial.Columns.Add("Price", "Price");
            dgvMatreial.Columns.Add("Picture", "Picture");
            dgvMatreial.Columns.Add("Color", "Color");
            dgvMatreial.Columns.Add("genre", "genre");
            FilldgvMaterial();
        }
        public void FilldgvMaterial()
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            var MList = (from Materiel in db.Materiels
                               select Materiel).ToList();

            for (int i = 0; i < MList.Count; i++)
            {
                dgvMatreial.Rows.Add(MList[i].Nom_Materiel, MList[i].Fondateur_Materiel, MList[i].Price_materiel, MList[i].Photo_Materiel, MList[i].Color_Materiel, MList[i].Genre_Materiel);
            }
        }
    }
}
