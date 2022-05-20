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
    public partial class frmNewWorkshop : Form
    {
        int index;
        int Projectid;
        int id_salle_for_delete;
        int id_mur_for_delete;
        public frmNewWorkshop()
        {
            InitializeComponent();
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
        }

        private void frmNewWorkshop_Load(object sender, EventArgs e)
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            dgvRooms.Columns.Add("Id", "Id");
            dgvRooms.Columns.Add("Name", "Name");

            cmbExistingCliebnt.DataSource = db.Clients.ToList<Client>();
            cmbExistingCliebnt.ValueMember = "ID_Client";
            cmbExistingCliebnt.DisplayMember = "Nom_Client" ;

        }


        private void rdExistingclientNo_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (rdExistingclientNo.Checked == false)
            {
                cmbExistingCliebnt.Visible = true;
                txtClientCin.Enabled = false;
                txtClientName.Enabled = false;
                txtClientPhone.Enabled = false;
                txtLastNameclient.Enabled = false;
            }
            if (rdExistingclientNo.Checked == true)
            {
                cmbExistingCliebnt.Visible = false;
                txtClientCin.Enabled = true;
                txtClientName.Enabled = true;
                txtClientPhone.Enabled = true;
                txtLastNameclient.Enabled = true;
            }
        }

        private void bunifuRadioButton1_CheckedChanged2_1(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            if (rdEsictingClientYes.Checked == true)
            {
                cmbExistingCliebnt.Visible = true;
                txtClientCin.Enabled = false;
                txtClientName.Enabled = false;
                txtClientPhone.Enabled = false;
                txtLastNameclient.Enabled = false;
                cmbExistingCliebnt.DataSource = db.Clients.ToList<Client>();
            }
            if (rdEsictingClientYes.Checked == false)
            {
                cmbExistingCliebnt.Visible = false;
                txtClientCin.Enabled = true;
                txtClientName.Enabled = true;
                txtClientPhone.Enabled = true;
                txtLastNameclient.Enabled = true;
            }
        }


        private void cmbExistingCliebnt_Click(object sender, EventArgs e)
        {
            cmbExistingCliebnt.Text = " ";
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {

            frmWalls frmw = new frmWalls();
            frmw.Show();
        }


        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            try
            {
                if (rdEsictingClientYes.Checked == true)
                {
                    pnlProjectDetails.Enabled = true;
                }
                if (rdExistingclientNo.Checked == true)
                {
                    if (string.IsNullOrEmpty(txtClientName.Text))
                    {
                        MessageBox.Show("Please enter client first name");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtLastNameclient.Text))
                        {
                            MessageBox.Show("Please enter client last name");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtClientCin.Text))
                            {
                                MessageBox.Show("Please enter client cin");
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(txtClientPhone.Text))
                                {
                                    MessageBox.Show("Please enter client phone");
                                }
                                else
                                {

                                   
                                        Client CL = new Client();
                                        CL.Nom_Client = txtClientName.Text;
                                        CL.Prenom_Client = txtLastNameclient.Text;
                                        CL.CIN_Client = txtClientCin.Text;
                                        CL.Telephone_Client = txtClientPhone.Text;
                                        db.Clients.Add(CL);
                                        db.SaveChanges();
                                        pnlProjectDetails.Enabled = true;
                                        MessageBox.Show("Done");
                                    

                                }
                            }
                        }
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
            
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            if (dtpExpiryDate.Value <= DateTime.Now)
            {
                MessageBox.Show("expiry date cannot be now");
            }
            else
            {
                projet pr = new projet();
                if (rdEsictingClientYes.Checked == true)
                {
                    pr.Datedebut_Projet = dtpStartingDate.Value;
                    pr.DateFin_Projet = dtpExpiryDate.Value;
                    pr.Nom_projet = txtProjectName.Text;
                    var exist = db.Clients.Find(cmbExistingCliebnt.SelectedValue);
                    if (exist != null)
                    {
                        pr.ID_Client = exist.ID_Client;
                        db.projets.Add(pr);
                        db.SaveChanges();

                    }
                    pnlRoomsDetails.Enabled = true;

                }
                if (rdExistingclientNo.Checked == true)
                {
                    pr.Datedebut_Projet = dtpStartingDate.Value;
                    pr.DateFin_Projet = dtpExpiryDate.Value;
                    pr.Nom_projet = txtProjectName.Text;
                    var exist = db.Clients.Find(txtClientName.Text);
                    if (exist != null)
                    {
                        pr.ID_Client = exist.ID_Client;
                        db.projets.Add(pr);
                        db.SaveChanges();

                    }
                    pnlRoomsDetails.Enabled = true;
                }

            }
        }

        private void btnAddEqupment_Click(object sender, EventArgs e)
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            if (string.IsNullOrEmpty(txtRoomName.Text))
            {
                MessageBox.Show("please enter room name");
            }
            else
            {
                Salle s = new Salle();
                s.Nom_Salle = txtRoomName.Text;

                var exist = (from projet in db.projets
                             where projet.Nom_projet == txtProjectName.Text
                             select projet.ID_Projet).ToList();


                s.ID_Projet = exist[0];
                db.Salles.Add(s);
                db.SaveChanges();
                fillDg();
                txtRoomName.Text = null;
            }



        }

        private void dgvRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            if (e == null)
            {
                MessageBox.Show("please select a room", "ERROR");
            }
            if (e != null)
            {
                 id_salle_for_delete = int.Parse(dgvRooms.CurrentRow.Cells[0].Value.ToString());
            }
            fillDgWall();
        }

        private void btnDeleteEquipment_Click(object sender, EventArgs e)
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            DialogResult dr=  MessageBox.Show("Do you really want to remove this room","Delete",MessageBoxButtons.YesNo);
            if(dr== DialogResult.Yes)
            {
                var exist = db.Salles.Find(id_salle_for_delete);
                if (exist == null)
                {
                    MessageBox.Show("Cant delete Room not exist Please select another one", "Delete");
                }
                if (exist != null)
                {
                    db.Salles.Remove(exist);
                    MessageBox.Show("deleted successfullye", "Delete");
                    db.SaveChanges();
                    fillDg();
                }
            }
        }



        public void fillDg()
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();

            var exist = (from projet in db.projets
                         where projet.Nom_projet == txtProjectName.Text
                         select projet.ID_Projet).ToList();

            int i = int.Parse(exist[0].ToString());

            var exist2 = db.Salles.Where(s => s.ID_Projet == i).ToList();

            for (int j = 0; j < exist2.Count; j++)
            {
                dgvRooms.Rows.Add(exist2[j].Id_Salle, exist2[j].Nom_Salle);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();

            //var exist = (from projet in db.projets
            //             where projet.Nom_projet == txtProjectName.Text
            //             select projet.ID_Projet).ToList();

            //var exist2 = db.Salles.Where(s => s.ID_Projet == exist[0]).ToList();
            //dgvRooms.DataSource = db.Salles;
            //dgvRooms.Rows.Add(exist2.ID_Projet, exist2.Nom_Salle);

            var exist = (from projet in db.projets
                         where projet.Nom_projet == "fatinneProjet"
                         select projet.ID_Projet).ToList();

            int i = int.Parse(exist[0].ToString());

            var exist2 = db.Salles.Where(s => s.ID_Projet ==i).ToList();
            dgvRooms.DataSource = exist2;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtRoomName.Text = null;
            dgvRooms.Rows.Clear();
            fillDg();
        }

        public void fillDgWall()
        {
            while (id_salle_for_delete != null)
            {

                JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
                var query = db.Murs.Where(s => s.Id_Salle == id_salle_for_delete).ToList();

                if (query!= null)
                {
                    dgvwalls.DataSource = null;
                    dgvwalls.DataSource = query;
                }
            }

        }

        private void btnrefreshwall_Click(object sender, EventArgs e)
        {
            //txtWallCurrentColor.Text = null;
            //txtWallColorAfter.Text = null;
            //txtLargeur.Text = null;
            //txtlongeur.Text = null;
            //fillDgWall();
            //fillcmbRoom();
        }

        private void dgvwalls_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_mur_for_delete = int.Parse(dgvwalls.CurrentRow.Cells[0].Value.ToString());
        }

        private void btndeletewall_Click(object sender, EventArgs e)
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();

            DialogResult dr = MessageBox.Show("Do you really want to remove this wall", "Delete", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                var exist = db.Murs.Find(id_mur_for_delete);
                if (exist != null)
                {
                    db.Murs.Remove(exist);
                    db.SaveChanges();
                    MessageBox.Show("Wall deleted seccusfully", "Delete");
                    fillDgWall();

                }
                else
                {
                    MessageBox.Show("Cant delete wall not exist Please select another one", "Delete");
                }
            }


        }

        private void btnaddwall_Click(object sender, EventArgs e)
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            if (string.IsNullOrEmpty(txtlongeur.Text))
            {
                MessageBox.Show("Please enter wall length ");
            }
            else
            {
                if (string.IsNullOrEmpty(txtLargeur.Text))
                {
                    MessageBox.Show("Please enter wall width");
                }
                else
                {
                    if (string.IsNullOrEmpty(txtWallCurrentColor.Text))
                    {
                        MessageBox.Show("Please enter the wall current color ");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtWallColorAfter.Text))
                        {
                            MessageBox.Show("please enter futuristic wall color");
                        }
                        else
                        {
                            Mur M = new Mur();
                            M.Largeur_Mur = int.Parse(txtLargeur.Text);
                            M.Longeur_Mur = int.Parse(txtlongeur.Text);
                            M.couleur_Mur_AV = txtWallCurrentColor.Text;
                            M.couleur_Mur_AP = txtWallColorAfter.Text;
                            M.Id_Salle = id_salle_for_delete;
                            db.Murs.Add(M);
                            db.SaveChanges();
                            fillDgWall();
                        }
                    }
                }

            }
        }



        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            fillcmbRoom();
        }

        public void fillcmbRoom()
        {

            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            var query = db.Salles.Where(o => o.ID_Projet == id_salle_for_delete).ToList();

            if (query != null)
            {
                cmbRooms.DataSource = null;
                cmbRooms.DataSource = query;
                cmbRooms.DisplayMember = "Nom_Salle";
                cmbRooms.ValueMember = "Id_Salle";
            }
        }

        private void pnlProjectDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlRoomsDetails_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
