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
            FillcmbRooms();
            //dgvwalls.Columns.Add("ID","ID");
            //dgvwalls.Columns.Add("Length", "Length");
            //dgvwalls.Columns.Add("Width", "Width");
            //dgvwalls.Columns.Add("Current C", "Current C");
            //dgvwalls.Columns.Add("Futuristic C", "Futursitic C");

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
        }
        
        public void FilldgvWall()
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            
            var query = (from salle in db.Salles
                         where salle.Nom_Salle == cmbRooms.SelectedText && salle.ID_Projet == ClsEmail.ID_PROJECt
                         select salle.ID_Projet).ToList();

            var Mu = db.Murs.Where(o => o.Id_Salle == query[0]);

            if (Mu != null)
            {
                //dgvwalls.Rows.Clear();
                //for (int i = 0; i < query.Count; i++)
                //{
                //    dgvwalls.Rows.Add(Mu[i].ID_Mur, Mu[i].Longeur_Mur, Mu[i].Largeur_Mur, Mu[i].couleur_Mur_AV, Mu[i].couleur_Mur_AP);
                //}

                dgvwalls.DataSource = null;
                dgvwalls.DataSource = Mu.ToList();
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
                                FilldgvWall();
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
            MessageBox.Show("yes");
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            string Roomname = cmbRooms.Text;
            var roomid = db.Salles.Where(o => o.Nom_Salle == Roomname && o.ID_Projet == ClsEmail.ID_PROJECt).ToList();

            var query = from Salle in db.Salles
                        where Salle.Nom_Salle == Roomname && Salle.ID_Projet == ClsEmail.ID_PROJECt
                        select Salle.Id_Salle;

            if (roomid != null)
            {
                //List<Mur> L = db.Murs.Where(o => o.Id_Salle == roomid[0].Id_Salle).ToList();


                //var x = (from Mur in db.Murs
                //         where Mur.Id_Salle == roomid[0].Id_Salle
                //         select Mur).ToList();


                //var x = (from Mur in db.Murs
                //         where Mur.Id_Salle == query[0]
                //         select Mur).ToList();


                //dgvwalls.DataSource = x;
                //dgvwalls.DataSource = db.Murs.Find(2);
            }

            //dgvwalls.DataSource = db.Murs.ToList();
        }
    }
}
