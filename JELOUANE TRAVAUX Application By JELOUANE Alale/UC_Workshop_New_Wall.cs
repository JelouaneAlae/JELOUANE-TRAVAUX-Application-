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
    public partial class UC_Workshop_New_Wall : UserControl
    {
        public UC_Workshop_New_Wall()
        {
            InitializeComponent();
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            var form1 = Form.ActiveForm as FormNewWorkShop;
            if (form1 != null)
            {
                form1.btnMaterial.PerformClick();
            }
        }

        private void UC_Workshop_New_Wall_Load(object sender, EventArgs e)
        {
            dgvwalls.Columns.Add("ID", "ID");
            dgvwalls.Columns.Add("Legth", "Legth");
            dgvwalls.Columns.Add("Width", "Width");
            dgvwalls.Columns.Add("Cuurent C", "Current C");
            dgvwalls.Columns.Add("Futuristic", "Futuristic");

            FillcmbRooms();
        }
        public void FillcmbRooms()
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();

            cmbRooms.DataSource = db.Salles.Where(o => o.ID_Projet == ClsEmail.ID_PROJECt).ToList();
            cmbRooms.DisplayMember = "Nom_Salle";
            cmbRooms.ValueMember = "Id_Salle";
        }

        private void btnrefreshwall_Click(object sender, EventArgs e)
        {
            FillcmbRooms();
            ClearTxt();
            
        }
        
        public void FilldgvWall(string name)
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            
            var query = (from salle in db.Salles
                         where salle.Nom_Salle == name&& salle.ID_Projet == ClsEmail.ID_PROJECt
                         select salle.Id_Salle).ToList();

            int i = query[0];
            var Mu = (from Mur in db.Murs where Mur.Id_Salle == i select Mur).ToList();

            if (Mu != null)
            {
                dgvwalls.Rows.Clear();
                for (int j = 0; j < Mu.Count; j++)
                {
                    dgvwalls.Rows.Add(Mu[j].ID_Mur, Mu[j].Longeur_Mur, Mu[j].Largeur_Mur, Mu[j].couleur_Mur_AV, Mu[j].couleur_Mur_AP);
                }
            }
        }

        private void btnaddwall_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtWallCurrentColor.Text))
                {
                    MessageBox.Show("The Current Color can't be empty");
                }
                else
                {
                    if (string.IsNullOrEmpty(txtWallColorAfter.Text))
                    {
                        MessageBox.Show("The Futuristic Color can't be empty");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtlongeur.Text))
                        {
                            MessageBox.Show("The wall Length can't be empty");
                        }
                        else
                        {
                            {
                                if (string.IsNullOrEmpty(txtLargeur.Text))
                                {
                                    MessageBox.Show("The wall Width can't be empty");
                                }
                                else
                                {
                                    JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
                                    Mur M = new Mur();

                                    string Roomname = cmbRooms.Text;
                                    var roomid = db.Salles.Where(o => o.Nom_Salle == Roomname && o.ID_Projet == ClsEmail.ID_PROJECt).ToList();
                                    if (roomid != null)
                                    {
                                        M.Id_Salle = roomid[0].Id_Salle;
                                    }

                                    M.Longeur_Mur = int.Parse(txtlongeur.Text);
                                    M.Largeur_Mur = int.Parse(txtLargeur.Text);
                                    M.couleur_Mur_AV = txtWallCurrentColor.Text;
                                    M.couleur_Mur_AP = txtWallColorAfter.Text;
                                    db.Murs.Add(M);
                                    db.SaveChanges();
                                    FilldgvWall(cmbRooms.Text);
                                    ClearTxt();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message,"ERROR");
            }
            
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
        }

        private void cmbRooms_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void btndeletewall_Click(object sender, EventArgs e)
        {
            try
            {
                JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
                var items = db.Murs.Find(dgvwalls.CurrentRow.Cells[0].Value);
                DialogResult dr = MessageBox.Show("Are sure", "Delete", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    if (items != null)
                    {
                        db.Murs.Remove(items);
                        db.SaveChanges();
                        MessageBox.Show("Wall successfully deleted", "Delete");
                        ClearTxt();
                    }
                    else
                    {
                        MessageBox.Show("Wall not exist");
                    }
                }
                FilldgvWall(cmbRooms.Text);
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message, "ERROR");
            }
        }

        private void dgvwalls_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtlongeur.Text = dgvwalls.CurrentRow.Cells[1].Value.ToString();
            txtLargeur.Text = dgvwalls.CurrentRow.Cells[2].Value.ToString();
            txtWallCurrentColor.Text = dgvwalls.CurrentRow.Cells[3].Value.ToString();
            txtWallColorAfter.Text = dgvwalls.CurrentRow.Cells[4].Value.ToString();

            int WallID = int.Parse(dgvwalls.CurrentRow.Cells[0].Value.ToString());
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            var exist = db.Murs.Find(WallID);
            int RoomId = exist.Id_Salle.Value;
            var exist2 = db.Salles.Find(RoomId);
            
            cmbRooms.Text = exist2.Nom_Salle;
        }

        public void ClearTxt()
        {
            txtlongeur.Text = null;
            txtLargeur.Text = null;
            txtWallCurrentColor.Text = null;
            txtWallColorAfter.Text = null;
        }
        private void cmbRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbRooms_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbRooms_TabIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();

                int id = int.Parse(dgvwalls.CurrentRow.Cells[0].Value.ToString());

                var exist = db.Murs.Find(id);
                if (exist != null)
                {
                    exist.couleur_Mur_AV = txtWallCurrentColor.Text;
                    exist.couleur_Mur_AP = txtWallColorAfter.Text;
                    exist.Longeur_Mur = int.Parse(txtlongeur.Text);
                    exist.Largeur_Mur = int.Parse(txtLargeur.Text);

                    db.SaveChanges();
                    MessageBox.Show("Wall Succesefully updated", "Update");
                    ClearTxt();
                    FilldgvWall(cmbRooms.Text);
                }
                else
                {
                    MessageBox.Show("Wall Not exist", "Update");
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "ERROR");
            }
            
        }

        private void cmbRooms_Click(object sender, EventArgs e)
        {
        
        }

        private void cmbRooms_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void cmbRooms_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void cmbRooms_Leave(object sender, EventArgs e)
        {
        }

        private void cmbRooms_DropDown(object sender, EventArgs e)
        {
        }

        private void cmbRooms_DropDownClosed(object sender, EventArgs e)
        {
            //MessageBox.Show("  ");

            //JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            //string Roomname = cmbRooms.Text;
            //var roomid = db.Salles.Where(o => o.Nom_Salle == Roomname && o.ID_Projet == ClsEmail.ID_PROJECt).ToList();
            //int id = roomid[0].Id_Salle;

            //if (id >0)
            //{
            //    List<Mur> L = db.Murs.Where(o => o.Id_Salle == id).ToList();


            //    var x = (from Mur in db.Murs
            //             where Mur.Id_Salle == id
            //             select Mur).ToList();

            //    dgvwalls.DataSource = x;
            //}

            //dgvwalls.DataSource = db.Murs.ToList();

            FilldgvWall(cmbRooms.Text);
        }
    }
}
