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
            set { ProjectName = value;lblProjectName.Text = value; }
        }

        public string _Notification_description
        {
            get { return Notification_description; }
            set { Notification_description = value; lbldescription.Text = value; }
        }

        #endregion

        private void UC_NotificationItems_Load(object sender, EventArgs e)
        {

        }

        private void BtnInbox_Click(object sender, EventArgs e)
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();

            var idproject = db.projets.Where(o => o.Nom_projet == this._ProjectName).ToList(); ;
            var obj = (from Notification in db.Notifications.ToList() where Notification.id_Project == idproject[0].ID_Projet && Notification.message_notification == this.Notification_description select Notification.id_notification).ToList();

            var noti = db.Notifications.Find(obj[0]);
            noti.visibility = true;
            db.SaveChanges();

            var form = Form.ActiveForm as FrmMainForm;
            if (form != null)
            {
                form.flowLayoutPanel1.Controls.Remove(this);
            }
        }
    }
}
