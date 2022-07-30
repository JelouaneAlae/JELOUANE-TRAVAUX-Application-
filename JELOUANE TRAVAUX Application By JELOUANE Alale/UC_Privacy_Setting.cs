using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JELOUANE_TRAVAUX_Application_By_JELOUANE_Alale
{
    public partial class UC_Privacy_Setting : UserControl
    {
        public UC_Privacy_Setting()
        {
            InitializeComponent();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sur you want to remove "+ ClsEmail.Email + " Account definitively","Delete User" ,MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();

                var user = db.utilisateurs.Find(ClsEmail.Email);
                db.utilisateurs.Remove(user);
                db.SaveChanges();
                if(db.utilisateurs.Find(ClsEmail.Email)==null)
                {
                    MessageBox.Show("The user was successfully deleted");
                    var form = Form.ActiveForm as FrmMainForm;
                    if (form != null)
                    {

                        form.Hide();
                        var form1 = new FrmLogin();
                        form1.Closed += (s, args) => form.Close();
                        form1.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Can't delete this user please try again");
                }

            }
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            FrmEditAcc f = new FrmEditAcc();
            f.Show();
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            FrmEditAcc f = new FrmEditAcc();
            f.Show();
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            var form1 = Form.ActiveForm as FrmMainForm;
            form1.btnAbout.PerformClick();
        }

        private void bunifuButton24_Click_1(object sender, EventArgs e)
        {
            if(rdOn.Checked == true)
            {
                using (StreamReader file = File.OpenText(@"C:\Users\jelal\OneDrive\Desktop\JELOUANE-TRAVAUX-Application-\Setting.json"))
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JToken o2 = JToken.ReadFrom(reader);
                    o2["saveLoginInfo"] = "true";
                    o2["Email"] = ClsEmail.Email;
                    file.Close();
                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(o2, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(@"C:\Users\jelal\OneDrive\Desktop\JELOUANE-TRAVAUX-Application-\Setting.json", output);
                }
            }
            if(Rdoff.Checked == true)
            {
                using (StreamReader file = File.OpenText(@"C:\Users\jelal\OneDrive\Desktop\JELOUANE-TRAVAUX-Application-\Setting.json"))
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JToken o2 = JToken.ReadFrom(reader);
                    o2["saveLoginInfo"] = "false";
                    file.Close();
                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(o2, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(@"C:\Users\jelal\OneDrive\Desktop\JELOUANE-TRAVAUX-Application-\Setting.json", output);
                }
            }
        }

        private void UC_Privacy_Setting_Load(object sender, EventArgs e)
        {
            setLogininfo();
        }

        public void setLogininfo()
        {
            using (StreamReader file = File.OpenText(@"C:\Users\jelal\OneDrive\Desktop\JELOUANE-TRAVAUX-Application-\Setting.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JToken o2 = JToken.ReadFrom(reader);
                if (o2["saveLoginInfo"].ToString() == "true")
                {
                    rdOn.Checked = true;
                    Rdoff.Checked = false;
                }

                if (o2["saveLoginInfo"].ToString() == "false")
                {
                    Rdoff.Checked = true;
                    rdOn.Checked = false;
                }
            }
        }
    }
}
