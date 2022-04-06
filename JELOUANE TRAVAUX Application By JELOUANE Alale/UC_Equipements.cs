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
    public partial class UC_Equipements : UserControl
    {
        JELOUANE_TRAVAUXEntities2 db = new JELOUANE_TRAVAUXEntities2();
        int IDE;
        string NameE;
        //ClsEmail clsemail = new ClsEmail();
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
            dgvEqupmenet.DataSource = db.Materiels.ToList<Materiel>();

        }

        private void dgvEqupmenet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDE = int.Parse(dgvEqupmenet.CurrentRow.Cells[0].Value.ToString());
            ClsEmail.IdEquipment = IDE;
            NameE = dgvEqupmenet.CurrentRow.Cells[1].Value.ToString();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var exist = db.Materiels.Find(IDE);
            if(exist !=null)
            {
                DialogResult FD = MessageBox.Show("Do you want to remove "+NameE,"ERROR",MessageBoxButtons.YesNo);
                if(FD == DialogResult.Yes)
                {
                    db.Materiels.Remove(exist);
                    db.SaveChanges();
                    MessageBox.Show(IDE + "Nadddi");
                    dgvEqupmenet.DataSource = db.Materiels.ToList<Materiel>();
                }
                
            }
            else
            {
                MessageBox.Show("Material not exist");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dgvEqupmenet.DataSource = db.Materiels.ToList<Materiel>();
        }

        private void button4_Click(object sender, EventArgs e)
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
}
