
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.btnLiquid = new System.Windows.Forms.Button();
            this.btnSolid = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteEquipment = new System.Windows.Forms.Button();
            this.btnEditEquipment = new System.Windows.Forms.Button();
            this.btnAddEqupment = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.materielBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvEqupmenet = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.txtSreachMa = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.materielBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEqupmenet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.label1.Location = new System.Drawing.Point(20, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 45);
            this.label1.TabIndex = 18;
            this.label1.Text = "EQUIPEMENT";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.button6.FlatAppearance.BorderSize = 3;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnLiquid.Font = new System.Drawing.Font("Bahnschrift Light", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnSolid.Font = new System.Drawing.Font("Bahnschrift Light", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnDeleteEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEquipment.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEquipment.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteEquipment.Image")));
            this.btnDeleteEquipment.Location = new System.Drawing.Point(673, 331);
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
            this.btnEditEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEquipment.ForeColor = System.Drawing.Color.White;
            this.btnEditEquipment.Image = ((System.Drawing.Image)(resources.GetObject("btnEditEquipment.Image")));
            this.btnEditEquipment.Location = new System.Drawing.Point(627, 331);
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
            this.btnAddEqupment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEqupment.ForeColor = System.Drawing.Color.White;
            this.btnAddEqupment.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEqupment.Image")));
            this.btnAddEqupment.Location = new System.Drawing.Point(581, 331);
            this.btnAddEqupment.Name = "btnAddEqupment";
            this.btnAddEqupment.Size = new System.Drawing.Size(40, 37);
            this.btnAddEqupment.TabIndex = 26;
            this.btnAddEqupment.UseVisualStyleBackColor = false;
            this.btnAddEqupment.Click += new System.EventHandler(this.button5_Click);
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
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(535, 329);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(40, 43);
            this.btnRefresh.TabIndex = 44;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.button7_Click);
            // 
            // dgvEqupmenet
            // 
            this.dgvEqupmenet.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvEqupmenet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEqupmenet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEqupmenet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEqupmenet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEqupmenet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEqupmenet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEqupmenet.ColumnHeadersHeight = 40;
            this.dgvEqupmenet.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvEqupmenet.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvEqupmenet.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEqupmenet.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvEqupmenet.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEqupmenet.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvEqupmenet.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvEqupmenet.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvEqupmenet.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvEqupmenet.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEqupmenet.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvEqupmenet.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEqupmenet.CurrentTheme.Name = null;
            this.dgvEqupmenet.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEqupmenet.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvEqupmenet.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEqupmenet.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvEqupmenet.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEqupmenet.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEqupmenet.EnableHeadersVisualStyles = false;
            this.dgvEqupmenet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvEqupmenet.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvEqupmenet.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvEqupmenet.HeaderForeColor = System.Drawing.Color.White;
            this.dgvEqupmenet.Location = new System.Drawing.Point(28, 67);
            this.dgvEqupmenet.Name = "dgvEqupmenet";
            this.dgvEqupmenet.RowHeadersVisible = false;
            this.dgvEqupmenet.RowTemplate.Height = 40;
            this.dgvEqupmenet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEqupmenet.Size = new System.Drawing.Size(682, 256);
            this.dgvEqupmenet.TabIndex = 45;
            this.dgvEqupmenet.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvEqupmenet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEqupmenet_CellContentClick_1);
            // 
            // txtSreachMa
            // 
            this.txtSreachMa.AcceptsReturn = false;
            this.txtSreachMa.AcceptsTab = false;
            this.txtSreachMa.AnimationSpeed = 200;
            this.txtSreachMa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSreachMa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSreachMa.AutoSizeHeight = true;
            this.txtSreachMa.BackColor = System.Drawing.Color.Transparent;
            this.txtSreachMa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSreachMa.BackgroundImage")));
            this.txtSreachMa.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtSreachMa.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSreachMa.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSreachMa.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSreachMa.BorderRadius = 15;
            this.txtSreachMa.BorderThickness = 1;
            this.txtSreachMa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSreachMa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSreachMa.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtSreachMa.DefaultText = "";
            this.txtSreachMa.FillColor = System.Drawing.Color.White;
            this.txtSreachMa.HideSelection = true;
            this.txtSreachMa.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSreachMa.IconLeft")));
            this.txtSreachMa.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSreachMa.IconPadding = 10;
            this.txtSreachMa.IconRight = null;
            this.txtSreachMa.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSreachMa.Lines = new string[0];
            this.txtSreachMa.Location = new System.Drawing.Point(308, 15);
            this.txtSreachMa.MaxLength = 32767;
            this.txtSreachMa.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSreachMa.Modified = false;
            this.txtSreachMa.Multiline = false;
            this.txtSreachMa.Name = "txtSreachMa";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSreachMa.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSreachMa.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSreachMa.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSreachMa.OnIdleState = stateProperties4;
            this.txtSreachMa.Padding = new System.Windows.Forms.Padding(3);
            this.txtSreachMa.PasswordChar = '\0';
            this.txtSreachMa.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSreachMa.PlaceholderText = "     Search";
            this.txtSreachMa.ReadOnly = false;
            this.txtSreachMa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSreachMa.SelectedText = "";
            this.txtSreachMa.SelectionLength = 0;
            this.txtSreachMa.SelectionStart = 0;
            this.txtSreachMa.ShortcutsEnabled = true;
            this.txtSreachMa.Size = new System.Drawing.Size(198, 30);
            this.txtSreachMa.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSreachMa.TabIndex = 48;
            this.txtSreachMa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSreachMa.TextMarginBottom = 0;
            this.txtSreachMa.TextMarginLeft = 3;
            this.txtSreachMa.TextMarginTop = 1;
            this.txtSreachMa.TextPlaceholder = "     Search";
            this.txtSreachMa.UseSystemPasswordChar = false;
            this.txtSreachMa.WordWrap = true;
            this.txtSreachMa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bunifuTextBox1_KeyUp);
            // 
            // UC_Equipements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtSreachMa);
            this.Controls.Add(this.dgvEqupmenet);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddEqupment);
            this.Controls.Add(this.btnEditEquipment);
            this.Controls.Add(this.btnDeleteEquipment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSolid);
            this.Controls.Add(this.btnLiquid);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Name = "UC_Equipements";
            this.Size = new System.Drawing.Size(723, 376);
            this.Load += new System.EventHandler(this.UC_Equipements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materielBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEqupmenet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnLiquid;
        private System.Windows.Forms.Button btnSolid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteEquipment;
        private System.Windows.Forms.Button btnEditEquipment;
        private System.Windows.Forms.Button btnAddEqupment;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource materielBindingSource;
        private System.Windows.Forms.Button btnRefresh;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvEqupmenet;
        private Bunifu.UI.WinForms.BunifuTextBox txtSreachMa;
    }
}
