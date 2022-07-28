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
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JELOUANE_TRAVAUX_Application_By_JELOUANE_Alale
{
    public partial class UCLogIn : UserControl
    {
        MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        int F = 0;
        JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
        ClsEmail clsemail = new ClsEmail();
        public UCLogIn()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            var exist = db.utilisateurs.Find(txtEmail.Text);
            if (exist != null)
            {
                if(exist.MotdePasse == txtPassword.Text)
                {

                    var form = Form.ActiveForm as FrmLogin;
                    if (form != null)
                    {
                        ClsEmail.Email = txtEmail.Text;
                        form.hideform();
                        var form1 = new FrmMainForm();
                        form1.Closed += (s, args) => form.closeform();
                        form1.Show();
                       
                    }
                    F = 0;
                }
                else
                {

                    F++;
                    if (F >= 3)
                    {
                        DialogResult Dialogresult= MessageBox.Show("Incorrect Email or Password . Forgot password?", "Error", MessageBoxButtons.YesNo);
                        if(Dialogresult == DialogResult.Yes)
                        {
                            var form = Form.ActiveForm as FrmLogin;
                            if (form != null)
                            {
                                form.btnForgetPass.PerformClick();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Email or Password", "Error", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {

                MessageBox.Show("Incorrect Email or Password", "Error", MessageBoxButtons.OK);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            btnShowPassword.Visible = false;
            btnMaskPassword.Visible = true;
        }

        private void UCLogIn_Load(object sender, EventArgs e)
        {
            ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            btnMaskPassword.Visible = false;
            CheckLogibninfo();
        }
        public void CheckLogibninfo()
        {
            using (StreamReader file = File.OpenText(@"C:\Users\jelal\OneDrive\Desktop\JELOUANE-TRAVAUX-Application-\Setting.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JToken o2 = JToken.ReadFrom(reader);

                if (o2["saveLoginInfo"].ToString() == "true")
                {
                    txtEmail.Text = o2["Email"].ToString();
                    JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
                    var pass = db.utilisateurs.Find(o2["Email"].ToString());
                    if(pass != null)
                    {
                        txtPassword.Text = pass.MotdePasse;
                    }
                }
            }

        }

        private void btnMaskPassword_Click(object sender, EventArgs e)
        {
            btnShowPassword.Visible = true;
            btnMaskPassword.Visible = false;
            txtPassword.PasswordChar = '*';
        }

    }
}
