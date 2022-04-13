
namespace JELOUANE_TRAVAUX_Application_By_JELOUANE_Alale
{
    partial class UC_Equipements
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Equipements));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEqupmenet = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.btnLiquid = new System.Windows.Forms.Button();
            this.btnSolid = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteEquipment = new System.Windows.Forms.Button();
            this.btnEditEquipment = new System.Windows.Forms.Button();
            this.btnAddEqupment = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSrearchEq = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.materielBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEqupmenet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materielBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 38);
            this.label1.TabIndex = 18;
            this.label1.Text = "EQUIPEMENT";
            // 
            // dgvEqupmenet
            // 
            this.dgvEqupmenet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEqupmenet.Location = new System.Drawing.Point(12, 70);
            this.dgvEqupmenet.Name = "dgvEqupmenet";
            this.dgvEqupmenet.Size = new System.Drawing.Size(698, 260);
            this.dgvEqupmenet.TabIndex = 19;
            this.dgvEqupmenet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEqupmenet_CellContentClick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.button6.FlatAppearance.BorderSize = 3;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(525, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(188, 33);
            this.button6.TabIndex = 20;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btnLiquid
            // 
            this.btnLiquid.BackColor = System.Drawing.Color.White;
            this.btnLiquid.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnLiquid.FlatAppearance.BorderSize = 0;
            this.btnLiquid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLiquid.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiquid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnLiquid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLiquid.Location = new System.Drawing.Point(528, 14);
            this.btnLiquid.Name = "btnLiquid";
            this.btnLiquid.Size = new System.Drawing.Size(90, 28);
            this.btnLiquid.TabIndex = 21;
            this.btnLiquid.Text = "liquid";
            this.btnLiquid.UseVisualStyleBackColor = false;
            this.btnLiquid.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSolid
            // 
            this.btnSolid.BackColor = System.Drawing.Color.White;
            this.btnSolid.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnSolid.FlatAppearance.BorderSize = 0;
            this.btnSolid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolid.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnSolid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSolid.Location = new System.Drawing.Point(620, 14);
            this.btnSolid.Name = "btnSolid";
            this.btnSolid.Size = new System.Drawing.Size(90, 28);
            this.btnSolid.TabIndex = 22;
            this.btnSolid.Text = "Solid";
            this.btnSolid.UseVisualStyleBackColor = false;
            this.btnSolid.Click += new System.EventHandler(this.btnSolid_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.panel1.Location = new System.Drawing.Point(617, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 30);
            this.panel1.TabIndex = 23;
            // 
            // btnDeleteEquipment
            // 
            this.btnDeleteEquipment.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteEquipment.FlatAppearance.BorderSize = 0;
            this.btnDeleteEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEquipment.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEquipment.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEquipment.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteEquipment.Image")));
            this.btnDeleteEquipment.Location = new System.Drawing.Point(673, 336);
            this.btnDeleteEquipment.Name = "btnDeleteEquipment";
            this.btnDeleteEquipment.Size = new System.Drawing.Size(40, 37);
            this.btnDeleteEquipment.TabIndex = 24;
            this.btnDeleteEquipment.UseVisualStyleBackColor = false;
            this.btnDeleteEquipment.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEditEquipment
            // 
            this.btnEditEquipment.BackColor = System.Drawing.Color.Transparent;
            this.btnEditEquipment.FlatAppearance.BorderSize = 0;
            this.btnEditEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEquipment.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEquipment.ForeColor = System.Drawing.Color.White;
            this.btnEditEquipment.Image = ((System.Drawing.Image)(resources.GetObject("btnEditEquipment.Image")));
            this.btnEditEquipment.Location = new System.Drawing.Point(627, 336);
            this.btnEditEquipment.Name = "btnEditEquipment";
            this.btnEditEquipment.Size = new System.Drawing.Size(40, 37);
            this.btnEditEquipment.TabIndex = 25;
            this.btnEditEquipment.UseVisualStyleBackColor = false;
            this.btnEditEquipment.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAddEqupment
            // 
            this.btnAddEqupment.BackColor = System.Drawing.Color.Transparent;
            this.btnAddEqupment.FlatAppearance.BorderSize = 0;
            this.btnAddEqupment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEqupment.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEqupment.ForeColor = System.Drawing.Color.White;
            this.btnAddEqupment.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEqupment.Image")));
            this.btnAddEqupment.Location = new System.Drawing.Point(581, 336);
            this.btnAddEqupment.Name = "btnAddEqupment";
            this.btnAddEqupment.Size = new System.Drawing.Size(40, 37);
            this.btnAddEqupment.TabIndex = 26;
            this.btnAddEqupment.UseVisualStyleBackColor = false;
            this.btnAddEqupment.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txtSrearchEq);
            this.panel2.Location = new System.Drawing.Point(310, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 30);
            this.panel2.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // txtSrearchEq
            // 
            this.txtSrearchEq.BackColor = System.Drawing.Color.White;
            this.txtSrearchEq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSrearchEq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSrearchEq.Location = new System.Drawing.Point(39, 6);
            this.txtSrearchEq.Name = "txtSrearchEq";
            this.txtSrearchEq.Size = new System.Drawing.Size(163, 16);
            this.txtSrearchEq.TabIndex = 30;
            this.txtSrearchEq.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(535, 333);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(40, 43);
            this.btnRefresh.TabIndex = 44;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.button7_Click);
            // 
            // materielBindingSource
            // 
            this.materielBindingSource.DataSource = typeof(JELOUANE_TRAVAUX_Application_By_JELOUANE_Alale.Materiel);
            // 
            // UC_Equipements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAddEqupment);
            this.Controls.Add(this.btnEditEquipment);
            this.Controls.Add(this.btnDeleteEquipment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSolid);
            this.Controls.Add(this.btnLiquid);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dgvEqupmenet);
            this.Controls.Add(this.label1);
            this.Name = "UC_Equipements";
            this.Size = new System.Drawing.Size(723, 382);
            this.Load += new System.EventHandler(this.UC_Equipements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEqupmenet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materielBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvEqupmenet;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnLiquid;
        private System.Windows.Forms.Button btnSolid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteEquipment;
        private System.Windows.Forms.Button btnEditEquipment;
        private System.Windows.Forms.Button btnAddEqupment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSrearchEq;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource materielBindingSource;
        private System.Windows.Forms.Button btnRefresh;
    }
}
