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
    public partial class UC_NotificationSetting : UserControl
    {
        public UC_NotificationSetting()
        {
            InitializeComponent();
        }

        private void cmbDatebefore_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsEmail.Email = cmbDatebefore.Text;
        }

        private void UC_NotificationSetting_Load(object sender, EventArgs e)
        {

        }
    }
}
