
namespace JELOUANE_TRAVAUX_Application_By_JELOUANE_Alale
{
    partial class frmSignIn
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignIn));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFisrNameSI = new System.Windows.Forms.TextBox();
            this.DtpDateOfBirthSI = new System.Windows.Forms.DateTimePicker();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.txtLastNameSI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmailSI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPasswordSI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "First name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFisrNameSI
            // 
            this.txtFisrNameSI.Location = new System.Drawing.Point(131, 127);
            this.txtFisrNameSI.MaxLength = 40;
            this.txtFisrNameSI.Name = "txtFisrNameSI";
            this.txtFisrNameSI.Size = new System.Drawing.Size(98, 20);
            this.txtFisrNameSI.TabIndex = 20;
            this.txtFisrNameSI.TextChanged += new System.EventHandler(this.txtFisrNameSI_TextChanged);
            // 
            // DtpDateOfBirthSI
            // 
            this.DtpDateOfBirthSI.Location = new System.Drawing.Point(131, 199);
            this.DtpDateOfBirthSI.Name = "DtpDateOfBirthSI";
            this.DtpDateOfBirthSI.Size = new System.Drawing.Size(200, 20);
            this.DtpDateOfBirthSI.TabIndex = 21;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // txtLastNameSI
            // 
            this.txtLastNameSI.Location = new System.Drawing.Point(131, 164);
            this.txtLastNameSI.MaxLength = 60;
            this.txtLastNameSI.Name = "txtLastNameSI";
            this.txtLastNameSI.Size = new System.Drawing.Size(98, 20);
            this.txtLastNameSI.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label2.Location = new System.Drawing.Point(12, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Last name";
            // 
            // txtEmailSI
            // 
            this.txtEmailSI.Location = new System.Drawing.Point(131, 238);
            this.txtEmailSI.Name = "txtEmailSI";
            this.txtEmailSI.Size = new System.Drawing.Size(200, 20);
            this.txtEmailSI.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label3.Location = new System.Drawing.Point(12, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label4.Location = new System.Drawing.Point(12, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Date of Birth";
            // 
            // txtPasswordSI
            // 
            this.txtPasswordSI.Location = new System.Drawing.Point(131, 275);
            this.txtPasswordSI.MaxLength = 10;
            this.txtPasswordSI.Name = "txtPasswordSI";
            this.txtPasswordSI.Size = new System.Drawing.Size(98, 20);
            this.txtPasswordSI.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label5.Location = new System.Drawing.Point(12, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "Password";
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(16, 314);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(315, 34);
            this.btnSignUp.TabIndex = 29;
            this.btnSignUp.Text = "SIGN UP";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.button1.Location = new System.Drawing.Point(252, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 32);
            this.button1.TabIndex = 40;
            this.button1.Text = "LogIn";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.label6.Location = new System.Drawing.Point(85, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 21);
            this.label6.TabIndex = 41;
            this.label6.Text = "Already registered User?";
            // 
            // frmSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 404);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtPasswordSI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmailSI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLastNameSI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtpDateOfBirthSI);
            this.Controls.Add(this.txtFisrNameSI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign in";
            this.Load += new System.EventHandler(this.frmSignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFisrNameSI;
        private System.Windows.Forms.DateTimePicker DtpDateOfBirthSI;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.TextBox txtLastNameSI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmailSI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPasswordSI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}