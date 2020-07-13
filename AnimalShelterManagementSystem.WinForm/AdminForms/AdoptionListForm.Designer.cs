namespace AnimalShelterManagementSystem.WinForm.AdminForms
{
    partial class AdoptionListForm
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
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.txeId = new DevExpress.XtraEditors.TextEdit();
            this.grvAdoptionList = new System.Windows.Forms.DataGridView();
            this.userLoginId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdoptionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdoptionStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homelessAnimalIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adoptionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homelessAnimalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLoginIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adoptionStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adoptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rdgAdoptionStatus = new DevExpress.XtraEditors.RadioGroup();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.list = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.homelessAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txeId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvAdoptionList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adoptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgAdoptionStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homelessAnimalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.toolStrip1);
            this.layoutControl1.Controls.Add(this.txeId);
            this.layoutControl1.Controls.Add(this.grvAdoptionList);
            this.layoutControl1.Controls.Add(this.rdgAdoptionStatus);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(639, 454);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbDelete,
            this.tsbEdit,
            this.tsbRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(12, 75);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(615, 26);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.Insert;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(29, 23);
            this.tsbAdd.Text = "추가";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.Delete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(29, 23);
            this.tsbDelete.Text = "삭제";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEdit.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.Edit;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(29, 23);
            this.tsbEdit.Text = "수정";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.Update;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(29, 23);
            this.tsbRefresh.Text = "새로고침";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // txeId
            // 
            this.txeId.Location = new System.Drawing.Point(82, 12);
            this.txeId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txeId.Name = "txeId";
            this.txeId.Size = new System.Drawing.Size(545, 24);
            this.txeId.StyleController = this.layoutControl1;
            this.txeId.TabIndex = 8;
            this.txeId.TextChanged += new System.EventHandler(this.txeId_TextChanged);
            // 
            // grvAdoptionList
            // 
            this.grvAdoptionList.AllowUserToAddRows = false;
            this.grvAdoptionList.AllowUserToDeleteRows = false;
            this.grvAdoptionList.AllowUserToOrderColumns = true;
            this.grvAdoptionList.AutoGenerateColumns = false;
            this.grvAdoptionList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvAdoptionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvAdoptionList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userLoginId,
            this.AnimalName,
            this.AdoptionDate,
            this.AdoptionStatus,
            this.userIdDataGridViewTextBoxColumn,
            this.homelessAnimalIdDataGridViewTextBoxColumn,
            this.adoptionDateDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.homelessAnimalDataGridViewTextBoxColumn,
            this.userLoginIdDataGridViewTextBoxColumn,
            this.animalNameDataGridViewTextBoxColumn,
            this.adoptionStatusDataGridViewTextBoxColumn});
            this.grvAdoptionList.DataSource = this.adoptionBindingSource;
            this.grvAdoptionList.Location = new System.Drawing.Point(82, 105);
            this.grvAdoptionList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grvAdoptionList.Name = "grvAdoptionList";
            this.grvAdoptionList.ReadOnly = true;
            this.grvAdoptionList.RowHeadersVisible = false;
            this.grvAdoptionList.RowHeadersWidth = 51;
            this.grvAdoptionList.RowTemplate.Height = 27;
            this.grvAdoptionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvAdoptionList.Size = new System.Drawing.Size(545, 337);
            this.grvAdoptionList.TabIndex = 5;
            // 
            // userLoginId
            // 
            this.userLoginId.DataPropertyName = "userLoginId";
            this.userLoginId.HeaderText = "유저Id";
            this.userLoginId.MinimumWidth = 6;
            this.userLoginId.Name = "userLoginId";
            this.userLoginId.ReadOnly = true;
            // 
            // AnimalName
            // 
            this.AnimalName.DataPropertyName = "AnimalName";
            this.AnimalName.HeaderText = "동물이름";
            this.AnimalName.MinimumWidth = 6;
            this.AnimalName.Name = "AnimalName";
            this.AnimalName.ReadOnly = true;
            // 
            // AdoptionDate
            // 
            this.AdoptionDate.DataPropertyName = "AdoptionDate";
            this.AdoptionDate.HeaderText = "입양날짜";
            this.AdoptionDate.MinimumWidth = 6;
            this.AdoptionDate.Name = "AdoptionDate";
            this.AdoptionDate.ReadOnly = true;
            // 
            // AdoptionStatus
            // 
            this.AdoptionStatus.DataPropertyName = "AdoptionStatus";
            this.AdoptionStatus.HeaderText = "입양상태";
            this.AdoptionStatus.MinimumWidth = 6;
            this.AdoptionStatus.Name = "AdoptionStatus";
            this.AdoptionStatus.ReadOnly = true;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // homelessAnimalIdDataGridViewTextBoxColumn
            // 
            this.homelessAnimalIdDataGridViewTextBoxColumn.DataPropertyName = "HomelessAnimalId";
            this.homelessAnimalIdDataGridViewTextBoxColumn.HeaderText = "HomelessAnimalId";
            this.homelessAnimalIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.homelessAnimalIdDataGridViewTextBoxColumn.Name = "homelessAnimalIdDataGridViewTextBoxColumn";
            this.homelessAnimalIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adoptionDateDataGridViewTextBoxColumn
            // 
            this.adoptionDateDataGridViewTextBoxColumn.DataPropertyName = "AdoptionDate";
            this.adoptionDateDataGridViewTextBoxColumn.HeaderText = "AdoptionDate";
            this.adoptionDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adoptionDateDataGridViewTextBoxColumn.Name = "adoptionDateDataGridViewTextBoxColumn";
            this.adoptionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // homelessAnimalDataGridViewTextBoxColumn
            // 
            this.homelessAnimalDataGridViewTextBoxColumn.DataPropertyName = "HomelessAnimal";
            this.homelessAnimalDataGridViewTextBoxColumn.HeaderText = "HomelessAnimal";
            this.homelessAnimalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.homelessAnimalDataGridViewTextBoxColumn.Name = "homelessAnimalDataGridViewTextBoxColumn";
            this.homelessAnimalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userLoginIdDataGridViewTextBoxColumn
            // 
            this.userLoginIdDataGridViewTextBoxColumn.DataPropertyName = "userLoginId";
            this.userLoginIdDataGridViewTextBoxColumn.HeaderText = "userLoginId";
            this.userLoginIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userLoginIdDataGridViewTextBoxColumn.Name = "userLoginIdDataGridViewTextBoxColumn";
            this.userLoginIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // animalNameDataGridViewTextBoxColumn
            // 
            this.animalNameDataGridViewTextBoxColumn.DataPropertyName = "AnimalName";
            this.animalNameDataGridViewTextBoxColumn.HeaderText = "AnimalName";
            this.animalNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.animalNameDataGridViewTextBoxColumn.Name = "animalNameDataGridViewTextBoxColumn";
            this.animalNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adoptionStatusDataGridViewTextBoxColumn
            // 
            this.adoptionStatusDataGridViewTextBoxColumn.DataPropertyName = "AdoptionStatus";
            this.adoptionStatusDataGridViewTextBoxColumn.HeaderText = "AdoptionStatus";
            this.adoptionStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adoptionStatusDataGridViewTextBoxColumn.Name = "adoptionStatusDataGridViewTextBoxColumn";
            this.adoptionStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adoptionBindingSource
            // 
            this.adoptionBindingSource.DataSource = typeof(AnimalShelterManagementSystem.Adoption);
            // 
            // rdgAdoptionStatus
            // 
            this.rdgAdoptionStatus.EditValue = 0;
            this.rdgAdoptionStatus.Location = new System.Drawing.Point(82, 40);
            this.rdgAdoptionStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdgAdoptionStatus.Name = "rdgAdoptionStatus";
            this.rdgAdoptionStatus.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "전체", true, null, ""),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "처리중"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "입양됨")});
            this.rdgAdoptionStatus.Size = new System.Drawing.Size(545, 31);
            this.rdgAdoptionStatus.StyleController = this.layoutControl1;
            this.rdgAdoptionStatus.TabIndex = 11;
            this.rdgAdoptionStatus.SelectedIndexChanged += new System.EventHandler(this.rdgAdoptionStatus_SelectedIndexChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.list,
            this.layoutControlItem1,
            this.layoutControlItem10,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(639, 454);
            this.Root.TextVisible = false;
            // 
            // list
            // 
            this.list.Control = this.grvAdoptionList;
            this.list.Location = new System.Drawing.Point(0, 93);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(619, 341);
            this.list.Text = "리스트";
            this.list.TextSize = new System.Drawing.Size(67, 18);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txeId;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(619, 28);
            this.layoutControlItem1.Text = " 유저이름:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(67, 18);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.rdgAdoptionStatus;
            this.layoutControlItem10.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem10.CustomizationFormText = "블랙리스트";
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(619, 35);
            this.layoutControlItem10.Text = " 입양상태: ";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(67, 18);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 63);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(619, 30);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // homelessAnimalBindingSource
            // 
            this.homelessAnimalBindingSource.DataSource = typeof(AnimalShelterManagementSystem.HomelessAnimal);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(AnimalShelterManagementSystem.AnimalShelter);
            // 
            // AdoptionListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 454);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.BlackPuppy;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdoptionListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "입양리스트";
            this.Load += new System.EventHandler(this.AdoptionManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txeId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvAdoptionList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adoptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgAdoptionStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homelessAnimalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.DataGridView grvAdoptionList;
        private System.Windows.Forms.BindingSource homelessAnimalBindingSource;
        private DevExpress.XtraLayout.LayoutControlItem list;
        private DevExpress.XtraEditors.TextEdit txeId;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource adoptionBindingSource;
        private DevExpress.XtraEditors.RadioGroup rdgAdoptionStatus;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLoginId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdoptionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdoptionStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homelessAnimalIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adoptionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homelessAnimalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLoginIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adoptionStatusDataGridViewTextBoxColumn;
    }
}