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
    public partial class UC_Workshop : UserControl
    {
        public UC_Workshop()
        {
            InitializeComponent();
        }


        private void btnNewWorkFull_Click(object sender, EventArgs e)
        {
            FormNewWorkShop fnw = new FormNewWorkShop();
            fnw.Show();
        }

        private void bunifuButton21_Click_1(object sender, EventArgs e)
        {
            var form = Form.ActiveForm as FrmMainForm;
            if (form != null)
            {

                form.Hide();
                var form1 = new frmworkshopHistory();
                form1.Closed += (s, args) => form.Close();
                form1.Show();
            }
        }
    }
}
