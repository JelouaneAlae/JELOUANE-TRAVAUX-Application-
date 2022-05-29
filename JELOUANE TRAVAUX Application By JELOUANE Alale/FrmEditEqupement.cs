using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace JELOUANE_TRAVAUX_Application_By_JELOUANE_Alale
{
    public partial class FrmEditEqupement : Form
    {
        //JELOUANE_TRAVAUXEntities4 db = new JELOUANE_TRAVAUXEntities4();
        JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
        byte[] t = null;
        public FrmEditEqupement()
        {
            InitializeComponent();
        }

        private void FrmEditEqupement_Load(object sender, EventArgs e)
        {
            cmbQuantity.Items.Add("0.5");
            cmbQuantity.ValueMember = "0.5";
            cmbQuantity.Items.Add("1");
            cmbQuantity.Items.Add("3");
            cmbQuantity.Items.Add("5");
            cmbQuantity.Items.Add("13");
            cmbQuantity.Items.Add("30");

            cmbColor.Items.Add("Yellow");
            cmbColor.ValueMember = "Yellow";
            cmbColor.Items.Add("Orange");
            cmbColor.Items.Add("Red");
            cmbColor.Items.Add("Violet");
            cmbColor.Items.Add("Blue");
            cmbColor.Items.Add("Green");
            cmbColor.Items.Add("White");
            cmbColor.Items.Add("Black");

            var exist = db.Materiels.Find(ClsEmail.IdEquipment);
            if (exist != null)
            {
                txtnameM.Text = exist.Nom_Materiel;
                txtPrice.Text = exist.Price_materiel.ToString();
                txtProducer.Text = exist.Fondateur_Materiel;
                cmbColor.Text = exist.Color_Materiel;
                cmbQuantity.Text = exist.Quantity_Materiel.ToString();
                if (exist.Genre_Materiel == "Liquid")
                {
                    rdbLiquid.Checked = true;
                }
                if (exist.Genre_Materiel == "Solid")
                {
                    rdbLiquid.Checked = true;
                }
                
                byte[] tabimg = (byte[])exist.Photo_Materiel;
                if(tabimg == null)
                {
                    picImageEquipement.Image = null;
                }
                else
                {
                    MemoryStream ms = new MemoryStream(tabimg);
                    picImageEquipement.Image = Image.FromStream(ms);
                }

            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                    if (string.IsNullOrEmpty(txtnameM.Text))
                    {
                        MessageBox.Show("The Name can't be empty");

                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtProducer.Text))
                        {
                            MessageBox.Show("The Producer can't be empty");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtPrice.Text))
                            {
                                MessageBox.Show("The Price can't be empty");
                            }
                            else
                            {
                                if (rdbLiquid.Checked == false && rdbSolid.Checked == false)
                                {
                                    MessageBox.Show("The State can't be empty");
                                }
                                else
                                {
                                    var exist = db.Materiels.Find(ClsEmail.IdEquipment);
                                    if (exist != null)
                                    {
                                        exist.Nom_Materiel = txtnameM.Text;
                                        exist.Fondateur_Materiel = txtProducer.Text;
                                        exist.Price_materiel = int.Parse(txtPrice.Text);
                                        exist.Color_Materiel = cmbColor.Text;

                                        if (rdbLiquid.Checked == true)
                                        {
                                            exist.Genre_Materiel = "Liquid";
                                        }

                                        if (rdbSolid.Checked == true)
                                        {
                                            exist.Genre_Materiel = "Solid";
                                        }

                                        exist.Photo_Materiel = t;

                                        db.SaveChanges();
                                        MessageBox.Show("Successful update");
                                        this.Close();
                                    }

                                }
                            }
                        }
                    }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "EROOR");
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Choose image";
            fd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                FileStream fl = new FileStream(fd.FileName, FileMode.Open);
                BinaryReader br = new BinaryReader(fl);
                t = br.ReadBytes((int)fl.Length);
                string Path = fd.FileName;
                picImageEquipement.Image = new Bitmap(fl);
                fl.Close();
            }
        }
    }
}
