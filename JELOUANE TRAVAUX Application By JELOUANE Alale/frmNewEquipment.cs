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
    public partial class frmNewEquipment : Form
    {
        //JELOUANE_TRAVAUXEntities4 db = new JELOUANE_TRAVAUXEntities4();
        JELOUANE_TRAVAUX2Entities db = new JELOUANE_TRAVAUX2Entities();
        Byte[] t = null;
        OpenFileDialog fd = new OpenFileDialog();
        public frmNewEquipment()
        {
            InitializeComponent();
        }

        private void frmNewEquipment_Load(object sender, EventArgs e)
        {
            cmbQuantity.Items.Add("0.5");
            cmbQuantity.ValueMember="0.5";
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
        }

        private void button7_Click(object sender, EventArgs e)
        {
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtID.Text = null;
            txtnameM.Text = null;
            txtPrice.Text = null;
            txtProducer.Text = null;
            cmbColor.Text = null;
            cmbQuantity.Text = null;
            picImageEquipement.Image = null;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                //if (string.IsNullOrEmpty(txtID.Text))
                //{
                //    MessageBox.Show("The ID can't be empty");
                //}
                //else
                //{
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
                                    Materiel MT = new Materiel();
                                    MT.Nom_Materiel = txtnameM.Text;
                                    MT.Fondateur_Materiel = txtProducer.Text;
                                    //MT.Id_Materiel = int.Parse(txtID.Text);
                                    MT.Color_Materiel = cmbColor.Text;
                                    MT.Price_materiel = int.Parse(txtPrice.Text);
                                    MT.Quantity_Materiel = int.Parse(cmbQuantity.Text);

                                    if (rdbLiquid.Checked == true)
                                    {
                                        MT.Genre_Materiel = "Liquid";
                                    }

                                    if (rdbSolid.Checked == true)
                                    {
                                        MT.Genre_Materiel = "Solid";
                                    }
                                    MT.Photo_Materiel = t;
                                    db.Materiels.Add(MT);
                                    db.SaveChanges();
                                    MessageBox.Show("Successfully update");
                                    this.Close();
                                }
                            }
                        }
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"EROOR");
            }
        }
    }
}
