
namespace JELOUANE_TRAVAUX_Application_By_JELOUANE_Alale
{
    partial class UCForgetPassword
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCForgetPassword));
            this.txtEmailFP = new System.Windows.Forms.TextBox();
            this.panelusername = new System.Windows.Forms.Panel();
            this.picEmailFP = new System.Windows.Forms.PictureBox();
            this.lblFP = new System.Windows.Forms.Label();
            this.lblOR = new System.Windows.Forms.Label();
            this.picCodeFp = new System.Windows.Forms.PictureBox();
            this.btnSendEmailFP = new System.Windows.Forms.Button();
            this.btnSubmitFP = new System.Windows.Forms.Button();
            this.txtEmailcodeFP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picEmailFP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCodeFp)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmailFP
            // 
            this.txtEmailFP.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmailFP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailFP.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailFP.ForeColor = System.Drawing.Color.Black;
            this.txtEmailFP.Location = new System.Drawing.Point(51, 112);
            this.txtEmailFP.Name = "txtEmailFP";
            this.txtEmailFP.Size = new System.Drawing.Size(196, 19);
            this.txtEmailFP.TabIndex = 25;
            this.txtEmailFP.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // panelusername
            // 
            this.panelusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.panelusername.Location = new System.Drawing.Point(11, 140);
            this.panelusername.Name = "panelusername";
            this.panelusername.Size = new System.Drawing.Size(238, 5);
            this.panelusername.TabIndex = 24;
            // 
            // picEmailFP
            // 
            this.picEmailFP.Image = ((System.Drawing.Image)(resources.GetObject("picEmailFP.Image")));
            this.picEmailFP.Location = new System.Drawing.Point(11, 100);
            this.picEmailFP.Name = "picEmailFP";
            this.picEmailFP.Size = new System.Drawing.Size(33, 39);
            this.picEmailFP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEmailFP.TabIndex = 23;
            this.picEmailFP.TabStop = false;
            // 
            // lblFP
            // 
            this.lblFP.AutoSize = true;
            this.lblFP.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F);
            this.lblFP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.lblFP.Location = new System.Drawing.Point(3, 9);
            this.lblFP.Name = "lblFP";
            this.lblFP.Size = new System.Drawing.Size(261, 75);
            this.lblFP.TabIndex = 26;
            this.lblFP.Text = "Please enter your current \r\nEmail address to generate\r\nnew password";
            this.lblFP.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblOR
            // 
            this.lblOR.AutoSize = true;
            this.lblOR.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.lblOR.ForeColor = System.Drawing.Color.Black;
            this.lblOR.Location = new System.Drawing.Point(117, 205);
            this.lblOR.Name = "lblOR";
            this.lblOR.Size = new System.Drawing.Size(26, 18);
            this.lblOR.TabIndex = 29;
            this.lblOR.Text = "OR";
            // 
            // picCodeFp
            // 
            this.picCodeFp.Image = ((System.Drawing.Image)(resources.GetObject("picCodeFp.Image")));
            this.picCodeFp.Location = new System.Drawing.Point(11, 100);
            this.picCodeFp.Name = "picCodeFp";
            this.picCodeFp.Size = new System.Drawing.Size(33, 39);
            this.picCodeFp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCodeFp.TabIndex = 30;
            this.picCodeFp.TabStop = false;
            this.picCodeFp.Visible = false;
            // 
            // btnSendEmailFP
            // 
            this.btnSendEmailFP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnSendEmailFP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendEmailFP.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.btnSendEmailFP.ForeColor = System.Drawing.Color.White;
            this.btnSendEmailFP.Location = new System.Drawing.Point(11, 163);
            this.btnSendEmailFP.Name = "btnSendEmailFP";
            this.btnSendEmailFP.Size = new System.Drawing.Size(241, 34);
            this.btnSendEmailFP.TabIndex = 27;
            this.btnSendEmailFP.Text = "Send Email";
            this.btnSendEmailFP.UseVisualStyleBackColor = false;
            this.btnSendEmailFP.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSubmitFP
            // 
            this.btnSubmitFP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnSubmitFP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitFP.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.btnSubmitFP.ForeColor = System.Drawing.Color.White;
            this.btnSubmitFP.Location = new System.Drawing.Point(10, 184);
            this.btnSubmitFP.Name = "btnSubmitFP";
            this.btnSubmitFP.Size = new System.Drawing.Size(241, 34);
            this.btnSubmitFP.TabIndex = 32;
            this.btnSubmitFP.Text = "Submit";
            this.btnSubmitFP.UseVisualStyleBackColor = false;
            this.btnSubmitFP.Visible = false;
            this.btnSubmitFP.Click += new System.EventHandler(this.btnSubmitFP_Click);
            // 
            // txtEmailcodeFP
            // 
            this.txtEmailcodeFP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmailcodeFP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailcodeFP.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailcodeFP.ForeColor = System.Drawing.Color.Black;
            this.txtEmailcodeFP.Location = new System.Drawing.Point(51, 111);
            this.txtEmailcodeFP.Name = "txtEmailcodeFP";
            this.txtEmailcodeFP.Size = new System.Drawing.Size(196, 19);
            this.txtEmailcodeFP.TabIndex = 33;
            this.txtEmailcodeFP.Visible = false;
            // 
            // UCForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtEmailcodeFP);
            this.Controls.Add(this.btnSubmitFP);
            this.Controls.Add(this.picCodeFp);
            this.Controls.Add(this.lblOR);
            this.Controls.Add(this.btnSendEmailFP);
            this.Controls.Add(this.lblFP);
            this.Controls.Add(this.picEmailFP);
            this.Controls.Add(this.txtEmailFP);
            this.Controls.Add(this.panelusername);
            this.Name = "UCForgetPassword";
            this.Size = new System.Drawing.Size(261, 228);
            this.Load += new System.EventHandler(this.UCForgetPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picEmailFP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCodeFp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmailFP;
        private System.Windows.Forms.Panel panelusername;
        private System.Windows.Forms.PictureBox picEmailFP;
        private System.Windows.Forms.Label lblFP;
        internal System.Windows.Forms.Label lblOR;
        private System.Windows.Forms.PictureBox picCodeFp;
        private System.Windows.Forms.Button btnSendEmailFP;
        private System.Windows.Forms.Button btnSubmitFP;
        private System.Windows.Forms.TextBox txtEmailcodeFP;
    }
}
