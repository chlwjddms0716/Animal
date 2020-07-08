namespace AnimalShelterManagementSystem.WinForm.AdminForms
{
    partial class ShelterListForm
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
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료XtoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.편집EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.추가XtoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제XtoolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보XtoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말XtoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lkuShelterName = new DevExpress.XtraEditors.LookUpEdit();
            this.animalShelterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txeAddress = new DevExpress.XtraEditors.TextEdit();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AnimalShelterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.종료XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.추가IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.도움말HToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkuShelterName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalShelterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.toolStrip1);
            this.layoutControl1.Controls.Add(this.menuStrip1);
            this.layoutControl1.Controls.Add(this.lkuShelterName);
            this.layoutControl1.Controls.Add(this.txeAddress);
            this.layoutControl1.Controls.Add(this.dataGridView1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(914, 446);
            this.layoutControl1.TabIndex = 7;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton4,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(12, 43);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(890, 27);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.Close;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "종료";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.Insert;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "추가";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.Delete;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "삭제";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.Help;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton5.Text = "도움말";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.편집EToolStripMenuItem,
            this.도움말HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(12, 12);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(890, 27);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료XtoolStripMenuItem1});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(70, 23);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // 종료XtoolStripMenuItem1
            // 
            this.종료XtoolStripMenuItem1.Name = "종료XtoolStripMenuItem1";
            this.종료XtoolStripMenuItem1.Size = new System.Drawing.Size(141, 26);
            this.종료XtoolStripMenuItem1.Text = "종료(&X)";
            this.종료XtoolStripMenuItem1.Click += new System.EventHandler(this.종료XToolStripMenuItem_Click);
            // 
            // 편집EToolStripMenuItem
            // 
            this.편집EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.추가XtoolStripMenuItem2,
            this.삭제XtoolStripMenuItem3});
            this.편집EToolStripMenuItem.Name = "편집EToolStripMenuItem";
            this.편집EToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.편집EToolStripMenuItem.Text = "편집(&E)";
            // 
            // 추가XtoolStripMenuItem2
            // 
            this.추가XtoolStripMenuItem2.Name = "추가XtoolStripMenuItem2";
            this.추가XtoolStripMenuItem2.Size = new System.Drawing.Size(143, 26);
            this.추가XtoolStripMenuItem2.Text = "추가(&I)";
            this.추가XtoolStripMenuItem2.Click += new System.EventHandler(this.추가IToolStripMenuItem_Click);
            // 
            // 삭제XtoolStripMenuItem3
            // 
            this.삭제XtoolStripMenuItem3.Name = "삭제XtoolStripMenuItem3";
            this.삭제XtoolStripMenuItem3.Size = new System.Drawing.Size(143, 26);
            this.삭제XtoolStripMenuItem3.Text = "삭제(&D)";
            this.삭제XtoolStripMenuItem3.Click += new System.EventHandler(this.삭제DToolStripMenuItem_Click);
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.정보XtoolStripMenuItem1,
            this.도움말XtoolStripMenuItem2});
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(89, 23);
            this.도움말HToolStripMenuItem.Text = "도움말(&H)";
            // 
            // 정보XtoolStripMenuItem1
            // 
            this.정보XtoolStripMenuItem1.Name = "정보XtoolStripMenuItem1";
            this.정보XtoolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.정보XtoolStripMenuItem1.Size = new System.Drawing.Size(201, 26);
            this.정보XtoolStripMenuItem1.Text = "정보(&A)";
            this.정보XtoolStripMenuItem1.Click += new System.EventHandler(this.정보AToolStripMenuItem_Click);
            // 
            // 도움말XtoolStripMenuItem2
            // 
            this.도움말XtoolStripMenuItem2.Name = "도움말XtoolStripMenuItem2";
            this.도움말XtoolStripMenuItem2.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.도움말XtoolStripMenuItem2.Size = new System.Drawing.Size(201, 26);
            this.도움말XtoolStripMenuItem2.Text = "도움말(&H)";
            this.도움말XtoolStripMenuItem2.Click += new System.EventHandler(this.도움말HToolStripMenuItem1_Click);
            // 
            // lkuShelterName
            // 
            this.lkuShelterName.Location = new System.Drawing.Point(100, 102);
            this.lkuShelterName.Name = "lkuShelterName";
            this.lkuShelterName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuShelterName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", " ")});
            this.lkuShelterName.Properties.DataSource = this.animalShelterBindingSource;
            this.lkuShelterName.Properties.DisplayMember = "Name";
            this.lkuShelterName.Properties.NullText = "보호소를 선택해주세요.";
            this.lkuShelterName.Properties.ValueMember = "AnimalShelterId";
            this.lkuShelterName.Size = new System.Drawing.Size(802, 24);
            this.lkuShelterName.StyleController = this.layoutControl1;
            this.lkuShelterName.TabIndex = 7;
            this.lkuShelterName.EditValueChanged += new System.EventHandler(this.lkuShelterName_EditValueChanged);
            // 
            // animalShelterBindingSource
            // 
            this.animalShelterBindingSource.DataSource = typeof(AnimalShelterManagementSystem.AnimalShelter);
            // 
            // txeAddress
            // 
            this.txeAddress.Location = new System.Drawing.Point(100, 74);
            this.txeAddress.Name = "txeAddress";
            this.txeAddress.Properties.NullText = "주소를 입력해주세요.";
            this.txeAddress.Size = new System.Drawing.Size(802, 24);
            this.txeAddress.StyleController = this.layoutControl1;
            this.txeAddress.TabIndex = 6;
            this.txeAddress.EditValueChanged += new System.EventHandler(this.txeAddress_EditValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AnimalShelterId,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.managerNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.animalShelterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(100, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(802, 304);
            this.dataGridView1.TabIndex = 4;
            // 
            // AnimalShelterId
            // 
            this.AnimalShelterId.DataPropertyName = "AnimalShelterId";
            this.AnimalShelterId.HeaderText = "보호소Id";
            this.AnimalShelterId.MinimumWidth = 6;
            this.AnimalShelterId.Name = "AnimalShelterId";
            this.AnimalShelterId.ReadOnly = true;
            this.AnimalShelterId.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "이름";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "주소";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "전화번호";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // managerNameDataGridViewTextBoxColumn
            // 
            this.managerNameDataGridViewTextBoxColumn.DataPropertyName = "ManagerName";
            this.managerNameDataGridViewTextBoxColumn.HeaderText = "담당자";
            this.managerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.managerNameDataGridViewTextBoxColumn.Name = "managerNameDataGridViewTextBoxColumn";
            this.managerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.managerNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(914, 446);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dataGridView1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 118);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(894, 308);
            this.layoutControlItem1.Text = "   리스트";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(85, 18);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txeAddress;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 62);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(894, 28);
            this.layoutControlItem3.Text = " 주소 : ";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(85, 18);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.lkuShelterName;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 90);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(894, 28);
            this.layoutControlItem4.Text = " 보호소 이름 :";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(85, 18);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.menuStrip1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(894, 31);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.toolStrip1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 31);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(894, 31);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // 종료XToolStripMenuItem
            // 
            this.종료XToolStripMenuItem.Name = "종료XToolStripMenuItem";
            this.종료XToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.종료XToolStripMenuItem.Text = "종료(&X)";
            // 
            // 추가IToolStripMenuItem
            // 
            this.추가IToolStripMenuItem.Name = "추가IToolStripMenuItem";
            this.추가IToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.추가IToolStripMenuItem.Text = "추가(&I)";
            // 
            // 삭제DToolStripMenuItem
            // 
            this.삭제DToolStripMenuItem.Name = "삭제DToolStripMenuItem";
            this.삭제DToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.삭제DToolStripMenuItem.Text = "삭제(&D)";
            // 
            // 정보AToolStripMenuItem
            // 
            this.정보AToolStripMenuItem.Name = "정보AToolStripMenuItem";
            this.정보AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.정보AToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.정보AToolStripMenuItem.Text = "정보(&A)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(198, 6);
            // 
            // 도움말HToolStripMenuItem1
            // 
            this.도움말HToolStripMenuItem1.Name = "도움말HToolStripMenuItem1";
            this.도움말HToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.도움말HToolStripMenuItem1.Size = new System.Drawing.Size(201, 26);
            this.도움말HToolStripMenuItem1.Text = "도움말(&H)";
            // 
            // ShelterListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 446);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ShelterListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "보호소목록";
            this.Load += new System.EventHandler(this.Shelter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkuShelterName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalShelterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource animalShelterBindingSource;
        private DevExpress.XtraEditors.TextEdit txeAddress;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.LookUpEdit lkuShelterName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalShelterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.ToolStripMenuItem 종료XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 추가IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정보AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 종료XtoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 추가XtoolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 삭제XtoolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 정보XtoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 도움말XtoolStripMenuItem2;
    }
}