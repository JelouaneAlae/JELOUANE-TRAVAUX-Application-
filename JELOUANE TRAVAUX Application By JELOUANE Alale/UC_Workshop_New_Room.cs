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
    public partial class UC_Workshop_New_Room : UserControl
    {
        int Room_ID;
        public UC_Workshop_New_Room()
        {
            InitializeComponent();
        }

        private void UC_Workshop_New_Room_Load(object sender, EventArgs e)
        {
            CultureInfo la = new CultureInfo(ClsEmail.keyLang);
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(la);
            dgvRooms.Columns.Add("ID", "ID");
            dgvRooms.Columns.Add("Name", "Name");
            fillDgRoom();
        }
        public void fillDgRoom()
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            dgvRooms.Rows.Clear();
            var exist2 = db.Salles.Where(s => s.ID_Projet == ClsEmail.ID_PROJECt).ToList();

            for (int i = 0; i < exist2.Count; i++)
            {
                dgvRooms.Rows.Add(exist2[i].Id_Salle, exist2[i].Nom_Salle);
            }
        }

        private void btnAddEqupment_Click(object sender, EventArgs e)
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            if (string.IsNullOrEmpty(txtRoomName.Text))
            {
                MessageBox.Show("Please enter the Room name", "ERROR");
            }
            else
            {
                Salle S = new Salle();
                S.Nom_Salle = txtRoomName.Text;
                S.ID_Projet = ClsEmail.ID_PROJECt;
                db.Salles.Add(S);
                db.SaveChanges();
                fillDgRoom();
                txtRoomName.Text = null;
            }
        }

        private void dgvRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Room_ID = int.Parse(dgvRooms.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnDeleteEquipment_Click(object sender, EventArgs e)
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            DialogResult dr = MessageBox.Show("Do you really want to remove this room", "Delete", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                var exist = db.Salles.Find(Room_ID);

                if (exist == null)
                {
                    MessageBox.Show("Cant delete Room not exist Please select another one", "Delete");
                }
                if (exist != null)
                {
                    db.Salles.Remove(exist);
                    MessageBox.Show("Deleted successfully", "Delete");
                    db.SaveChanges();
                    fillDgRoom();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            fillDgRoom();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var form1 = Form.ActiveForm as FormNewWorkShop;
            if (form1 != null)
            {
                form1.btnWall.PerformClick();
            }
        }
    }
}
