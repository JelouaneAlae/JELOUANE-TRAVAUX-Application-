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
    public partial class FrmEditAcc : Form
    {
        public FrmEditAcc()
        {
            InitializeComponent();
        }

        private void FrmEditAcc_Load(object sender, EventArgs e)
        {
            JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
            var obj = db.utilisateurs.Find(ClsEmail.Email);
            if (obj!= null)
            {
                txtFisrNameSI.Text = obj.Nom_utilisateur;
                txtLastNameSI.Text = obj.Prenom_utilisateur;
                txtEmailSI.Text = obj.Email;
                DtpDateOfBirthSI.Text = obj.DateNaissance_utilisateur.ToString();

            }
        }
    }
}
