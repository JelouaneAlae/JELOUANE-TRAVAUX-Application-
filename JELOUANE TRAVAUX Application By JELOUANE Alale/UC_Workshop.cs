﻿using System;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            frmworkshopHistory frmwh = new frmworkshopHistory();
            frmwh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnnewwork_MouseLeave(object sender, EventArgs e)
        {

        }

        private void bunifuButton24_MouseHover(object sender, EventArgs e)
        {

        }

        private void bunifuButton24_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnNewWorkFull_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnNewWorkFull_Click(object sender, EventArgs e)
        {
            //frmNewWorkshop frmnw = new frmNewWorkshop();
            //frmnw.Show();


            FormNewWorkShop fnw = new FormNewWorkShop();
            fnw.Show();
        }
    }
}
