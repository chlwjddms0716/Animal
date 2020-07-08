namespace AnimalShelterManagementSystem.WinForm.AdminForms
{
    partial class AdoptionManagement
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
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdoptionManagement = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.list = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.speciesNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.physicalConditionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adoptionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureLinkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homelessAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txeUserName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homelessAnimalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txeUserName);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnAdoptionManagement);
            this.layoutControl1.Controls.Add(this.dataGridView1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(772, 314);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 275);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(372, 27);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "취소";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdoptionManagement
            // 
            this.btnAdoptionManagement.Location = new System.Drawing.Point(388, 275);
            this.btnAdoptionManagement.Name = "btnAdoptionManagement";
            this.btnAdoptionManagement.Size = new System.Drawing.Size(372, 27);
            this.btnAdoptionManagement.StyleController = this.layoutControl1;
            this.btnAdoptionManagement.TabIndex = 6;
            this.btnAdoptionManagement.Text = "확인";
            this.btnAdoptionManagement.Click += new System.EventHandler(this.btnAdoptionManagement_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.speciesNameDataGridViewTextBoxColumn,
            this.genderNameDataGridViewTextBoxColumn,
            this.physicalConditionNameDataGridViewTextBoxColumn,
            this.adoptionsDataGridViewTextBoxColumn,
            this.pictureLinkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.homelessAnimalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(75, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(685, 216);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.list,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(772, 314);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 248);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(752, 15);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // list
            // 
            this.list.Control = this.dataGridView1;
            this.list.Location = new System.Drawing.Point(0, 28);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(752, 220);
            this.list.Text = "리스트";
            this.list.TextSize = new System.Drawing.Size(60, 18);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnAdoptionManagement;
            this.layoutControlItem3.Location = new System.Drawing.Point(376, 263);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(376, 31);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnCancel;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 263);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(376, 31);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // speciesNameDataGridViewTextBoxColumn
            // 
            this.speciesNameDataGridViewTextBoxColumn.DataPropertyName = "SpeciesName";
            this.speciesNameDataGridViewTextBoxColumn.HeaderText = "종";
            this.speciesNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.speciesNameDataGridViewTextBoxColumn.Name = "speciesNameDataGridViewTextBoxColumn";
            this.speciesNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.speciesNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderNameDataGridViewTextBoxColumn
            // 
            this.genderNameDataGridViewTextBoxColumn.DataPropertyName = "GenderName";
            this.genderNameDataGridViewTextBoxColumn.HeaderText = "성별";
            this.genderNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderNameDataGridViewTextBoxColumn.Name = "genderNameDataGridViewTextBoxColumn";
            this.genderNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // physicalConditionNameDataGridViewTextBoxColumn
            // 
            this.physicalConditionNameDataGridViewTextBoxColumn.DataPropertyName = "PhysicalConditionName";
            this.physicalConditionNameDataGridViewTextBoxColumn.HeaderText = "건강상태";
            this.physicalConditionNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.physicalConditionNameDataGridViewTextBoxColumn.Name = "physicalConditionNameDataGridViewTextBoxColumn";
            this.physicalConditionNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.physicalConditionNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // adoptionsDataGridViewTextBoxColumn
            // 
            this.adoptionsDataGridViewTextBoxColumn.DataPropertyName = "Adoptions";
            this.adoptionsDataGridViewTextBoxColumn.HeaderText = "입양날짜";
            this.adoptionsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adoptionsDataGridViewTextBoxColumn.Name = "adoptionsDataGridViewTextBoxColumn";
            this.adoptionsDataGridViewTextBoxColumn.ReadOnly = true;
            this.adoptionsDataGridViewTextBoxColumn.Width = 125;
            // 
            // pictureLinkDataGridViewTextBoxColumn
            // 
            this.pictureLinkDataGridViewTextBoxColumn.DataPropertyName = "PictureLink";
            this.pictureLinkDataGridViewTextBoxColumn.HeaderText = "사진링크";
            this.pictureLinkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pictureLinkDataGridViewTextBoxColumn.Name = "pictureLinkDataGridViewTextBoxColumn";
            this.pictureLinkDataGridViewTextBoxColumn.ReadOnly = true;
            this.pictureLinkDataGridViewTextBoxColumn.Width = 125;
            // 
            // homelessAnimalBindingSource
            // 
            this.homelessAnimalBindingSource.DataSource = typeof(AnimalShelterManagementSystem.HomelessAnimal);
            // 
            // txeUserName
            // 
            this.txeUserName.Location = new System.Drawing.Point(75, 12);
            this.txeUserName.Name = "txeUserName";
            this.txeUserName.Size = new System.Drawing.Size(685, 24);
            this.txeUserName.StyleController = this.layoutControl1;
            this.txeUserName.TabIndex = 8;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txeUserName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(752, 28);
            this.layoutControlItem1.Text = " 유저이름:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(60, 18);
            // 
            // AdoptionManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 314);
            this.Controls.Add(this.layoutControl1);
            this.Name = "AdoptionManagement";
            this.Text = "AdoptionManagement";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homelessAnimalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnAdoptionManagement;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn physicalConditionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adoptionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureLinkDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource homelessAnimalBindingSource;
        private DevExpress.XtraLayout.LayoutControlItem list;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TextEdit txeUserName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}