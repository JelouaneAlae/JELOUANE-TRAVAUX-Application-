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
    public partial class UC_Setting_Generale : UserControl
    {
        public UC_Setting_Generale()
        {
            InitializeComponent();
        }

        private void UC_Setting_Generale_Load(object sender, EventArgs e)
        {
            CmbAppLanguage.Items.Add("frensh");
            CmbAppLanguage.Items.Add("English");

            CmbKeyLanguage.Items.Add("frensh");
            CmbKeyLanguage.Items.Add("English");
            CmbKeyLanguage.Items.Add("Arabic");
            CmbKeyLanguage.Items.Add("Español");
            CmbKeyLanguage.Items.Add("Deutsch");
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
