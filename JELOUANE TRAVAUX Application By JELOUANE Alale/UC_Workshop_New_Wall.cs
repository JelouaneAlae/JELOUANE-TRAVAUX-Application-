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
            FilldgvWall(cmbRooms.Text);

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
        
        public void FilldgvWall(string RoomName)
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            
            var query = (from salle in db.Salles
                         where salle.Nom_Salle == RoomName && salle.ID_Projet == ClsEmail.ID_PROJECt
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
                                var roomid = db.Salles.Where(o => o.Nom_Salle == Roomname && o.ID_Projet == ClsEmail.ID_PROJECt).ToList() ;
                                if(roomid != null)
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

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbRooms.Text);
        }

        private void cmbRooms_SelectedValueChanged(object sender, EventArgs e)
        {

            //JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            //string Roomname = cmbRooms.Text;
            //var roomid = db.Salles.Where(o => o.Nom_Salle == Roomname && o.ID_Projet == ClsEmail.ID_PROJECt).ToList();

            //var query = from Salle in db.Salles
            //            where Salle.Nom_Salle == Roomname && Salle.ID_Projet == ClsEmail.ID_PROJECt
            //            select Salle.Id_Salle;

            //if (roomid != null)
            //{
            //    //List<Mur> L = db.Murs.Where(o => o.Id_Salle == roomid[0].Id_Salle).ToList();


            //    //var x = (from Mur in db.Murs
            //    //         where Mur.Id_Salle == roomid[0].Id_Salle
            //    //         select Mur).ToList();


            //    //var x = (from Mur in db.Murs
            //    //         where Mur.Id_Salle == query[0]
            //    //         select Mur).ToList();


            //    //dgvwalls.DataSource = x;
            //    //dgvwalls.DataSource = db.Murs.Find(2);
            //}

            ////dgvwalls.DataSource = db.Murs.ToList();
            ///
        }

        private void btndeletewall_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Wall successfully deleted","Delete");
                    ClearTxt();
                }
                else
                {
                    MessageBox.Show("Wall not exist");
                }
            }
            FilldgvWall(cmbRooms.Text);
        }

        private void dgvwalls_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtlongeur.Text = dgvwalls.CurrentRow.Cells[1].Value.ToString();
            txtLargeur.Text = dgvwalls.CurrentRow.Cells[2].Value.ToString();
            txtWallCurrentColor.Text = dgvwalls.CurrentRow.Cells[3].Value.ToString();
            txtWallColorAfter.Text = dgvwalls.CurrentRow.Cells[4].Value.ToString();
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
    }
}
