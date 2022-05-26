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
    public partial class UC_NotificationItems : UserControl
    {
        public UC_NotificationItems()
        {
            InitializeComponent();
        }

        #region propreties
        public string ProjectName;
        public string Notification_description;

        public string _ProjectName
        {
            get { return ProjectName; }
            set { _ProjectName = value;lblProjectName.Text = value; }
        }

        public string _Notification_description
        {
            get { return Notification_description; }
            set { _Notification_description = value; lbldescription.Text = value; }
        }

        #endregion

        private void UC_NotificationItems_Load(object sender, EventArgs e)
        {

        }
    }
}
