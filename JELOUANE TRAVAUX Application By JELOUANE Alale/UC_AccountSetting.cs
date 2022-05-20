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
    public partial class UC_AccountSetting : UserControl
    {
        public UC_AccountSetting()
        {
            InitializeComponent();
        }

        private void UC_AccountSetting_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            var form = Form.ActiveForm as FrmMainForm;
            if (form != null)
            {
                var form1 = new FrmLogin();
                form.Hide();
                form1.Closed += (s, args) => form.Close();
                form1.Show();

            }
        }
    }
}
