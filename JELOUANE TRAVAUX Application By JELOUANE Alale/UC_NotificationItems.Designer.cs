
namespace JELOUANE_TRAVAUX_Application_By_JELOUANE_Alale
{
    partial class UC_NotificationItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_NotificationItems));
            this.lbl = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbldescription = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblProjectName = new Bunifu.UI.WinForms.BunifuLabel();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AllowParentOverrides = false;
            this.lbl.AutoEllipsis = false;
            this.lbl.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl.Location = new System.Drawing.Point(4, 4);
            this.lbl.Name = "lbl";
            this.lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl.Size = new System.Drawing.Size(51, 17);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Project :";
            this.lbl.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbldescription
            // 
            this.lbldescription.AllowParentOverrides = false;
            this.lbldescription.AutoEllipsis = false;
            this.lbldescription.CursorType = null;
            this.lbldescription.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbldescription.Location = new System.Drawing.Point(17, 29);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbldescription.Size = new System.Drawing.Size(74, 17);
            this.lbldescription.TabIndex = 1;
            this.lbldescription.Text = "bunifuLabel1";
            this.lbldescription.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbldescription.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblProjectName
            // 
            this.lblProjectName.AllowParentOverrides = false;
            this.lblProjectName.AutoEllipsis = false;
            this.lblProjectName.CursorType = null;
            this.lblProjectName.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblProjectName.Location = new System.Drawing.Point(61, 5);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProjectName.Size = new System.Drawing.Size(82, 17);
            this.lblProjectName.TabIndex = 2;
            this.lblProjectName.Text = "bunifuLabel1";
            this.lblProjectName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblProjectName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // UC_NotificationItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.lbl);
            this.Name = "UC_NotificationItems";
            this.Size = new System.Drawing.Size(250, 56);
            this.Load += new System.EventHandler(this.UC_NotificationItems_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel lbl;
        private Bunifu.UI.WinForms.BunifuLabel lbldescription;
        private Bunifu.UI.WinForms.BunifuLabel lblProjectName;
    }
}
