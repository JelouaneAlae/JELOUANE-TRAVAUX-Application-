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
    public partial class frmNewPass : Form
    {
        public frmNewPass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new FrmLogin();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void frmNewPass_Load(object sender, EventArgs e)
        {

        }
        
        internal void closeform()
        {
            this.Close();
        }

        internal void hideform()
        {
            this.Hide();
        }
    }
}
