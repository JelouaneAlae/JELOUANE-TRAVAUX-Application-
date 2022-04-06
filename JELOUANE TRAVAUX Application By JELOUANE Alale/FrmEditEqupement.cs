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
    public partial class FrmEditEqupement : Form
    {
        JELOUANE_TRAVAUXEntities2 db = new JELOUANE_TRAVAUXEntities2();
        public FrmEditEqupement()
        {
            InitializeComponent();
        }

        private void FrmEditEqupement_Load(object sender, EventArgs e)
        {
            var exist = db.Materiels.Find(ClsEmail.IdEquipment);
            if (exist != null)
            {

            }
        }
    }
}
