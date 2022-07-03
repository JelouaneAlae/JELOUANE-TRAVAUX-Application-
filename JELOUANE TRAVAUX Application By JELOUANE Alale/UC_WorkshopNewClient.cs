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
    public partial class UC_WorkshopNewClient : UserControl
    {
        //internal int id_client;
        public UC_WorkshopNewClient()
        {
            InitializeComponent();
        }

        private void rdEsictingClientYes_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            if (rdEsictingClientYes.Checked == true)
            {
                dgvExistingClient2.Visible = true;
                txtClientCin.Enabled = false;
                txtClientName.Enabled = false;
                txtClientPhone.Enabled = false;
                txtLastNameclient.Enabled = false;
                label1.Visible = true;
                label2.Visible= true;
                fillDgExistingClient();
            }
            if (rdEsictingClientYes.Checked == false)
            {
                dgvExistingClient2.Visible = false;
                txtClientCin.Enabled = true;
                txtClientName.Enabled = true;
                txtClientPhone.Enabled = true;
                txtLastNameclient.Enabled = true;
                label2.Visible = false;
                label1.Visible = false;
            }
        }

        private void rdExistingclientNo_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {

        }

        public void fillDgExistingClient()
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            dgvExistingClient2.Rows.Clear();
            for (int i = 0; i < db.Clients.ToList().Count; i++) 
            {
                dgvExistingClient2.Rows.Add(db.Clients.ToList()[i].ID_Client.ToString());
                db.Clients.ToList()[i].Nom_Client.ToString();
                db.Clients.ToList()[i].Prenom_Client.ToString();
                db.Clients.ToList()[i].CIN_Client.ToString();
                db.Clients.ToList()[i].Telephone_Client.ToString();

            }
        }


        private void UC_WorkshopNewClient_Load(object sender, EventArgs e)
        {
            CultureInfo la = new CultureInfo(ClsEmail.keyLang);
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(la);
            dgvExistingClient2.Columns.Add("ID", "ID");
            dgvExistingClient2.Columns.Add("F Name", "F Name");
            dgvExistingClient2.Columns.Add("L name", "L name");
            dgvExistingClient2.Columns.Add("Cin", "cin");
            dgvExistingClient2.Columns.Add("Phone", "Phone");

        }

        private void dgvExistingClient2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = dgvExistingClient2.CurrentRow.Cells[1].Value.ToString() + " " 
                + dgvExistingClient2.CurrentRow.Cells[2].Value.ToString();
            ClsEmail.ID_CLIENt = int.Parse(dgvExistingClient2.CurrentRow.Cells[0].Value.ToString());
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            try
            {
                if (rdEsictingClientYes.Checked == true)
                {
                    var exist = db.Clients.Find(int.Parse(dgvExistingClient2.CurrentRow.Cells[0].Value.ToString()));
                    if (exist != null)
                    {
                        var form1 = Form.ActiveForm as FormNewWorkShop;
                        if (form1 != null)
                        {
                            form1.btnProject.PerformClick();
                        }
                    }
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
                                    MessageBox.Show("Client Seccusfully Added","Add Client");
                                    var id = (from Client in db.Clients
                                             where Client.Nom_Client == txtClientName.Text && Client.Prenom_Client == txtLastNameclient.Text
                                             select Client.ID_Client).ToList();

                                    ClsEmail.ID_CLIENt = id[0];
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }

        private void pnlClientDetails_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
