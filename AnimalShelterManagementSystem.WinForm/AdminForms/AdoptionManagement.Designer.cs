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
            this.txeUserName = new DevExpress.XtraEditors.TextEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdoptionManagement = new DevExpress.XtraEditors.SimpleButton();
            this.r = new System.Windows.Forms.DataGridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.list = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.rdgBlacklist = new DevExpress.XtraEditors.RadioGroup();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.adoptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homelessAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userLoginId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdoptionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txeUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgBlacklist.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adoptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homelessAnimalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txeUserName);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnAdoptionManagement);
            this.layoutControl1.Controls.Add(this.r);
            this.layoutControl1.Controls.Add(this.rdgBlacklist);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(772, 314);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txeUserName
            // 
            this.txeUserName.Location = new System.Drawing.Point(82, 12);
            this.txeUserName.Name = "txeUserName";
            this.txeUserName.Size = new System.Drawing.Size(678, 24);
            this.txeUserName.StyleController = this.layoutControl1;
            this.txeUserName.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 275);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(274, 27);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "취소";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdoptionManagement
            // 
            this.btnAdoptionManagement.Location = new System.Drawing.Point(290, 275);
            this.btnAdoptionManagement.Name = "btnAdoptionManagement";
            this.btnAdoptionManagement.Size = new System.Drawing.Size(470, 27);
            this.btnAdoptionManagement.StyleController = this.layoutControl1;
            this.btnAdoptionManagement.TabIndex = 6;
            this.btnAdoptionManagement.Text = "확인";
            this.btnAdoptionManagement.Click += new System.EventHandler(this.btnAdoptionManagement_Click);
            // 
            // r
            // 
            this.r.AllowUserToAddRows = false;
            this.r.AllowUserToDeleteRows = false;
            this.r.AllowUserToOrderColumns = true;
            this.r.AutoGenerateColumns = false;
            this.r.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.r.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userLoginId,
            this.AnimalName,
            this.AdoptionDate});
            this.r.DataSource = this.adoptionBindingSource;
            this.r.Location = new System.Drawing.Point(82, 74);
            this.r.Name = "r";
            this.r.ReadOnly = true;
            this.r.RowHeadersWidth = 51;
            this.r.RowTemplate.Height = 27;
            this.r.Size = new System.Drawing.Size(678, 162);
            this.r.TabIndex = 5;
            this.r.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.layoutControlItem1,
            this.layoutControlItem10});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(772, 314);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 228);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(752, 35);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // list
            // 
            this.list.Control = this.r;
            this.list.Location = new System.Drawing.Point(0, 62);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(752, 166);
            this.list.Text = "리스트";
            this.list.TextSize = new System.Drawing.Size(67, 18);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnAdoptionManagement;
            this.layoutControlItem3.Location = new System.Drawing.Point(278, 263);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(474, 31);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnCancel;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 263);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(278, 31);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txeUserName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(752, 28);
            this.layoutControlItem1.Text = " 유저이름:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(67, 18);
            // 
            // rdgBlacklist
            // 
            this.rdgBlacklist.EditValue = 0;
            this.rdgBlacklist.Location = new System.Drawing.Point(82, 40);
            this.rdgBlacklist.Name = "rdgBlacklist";
            this.rdgBlacklist.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "처리중"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "입양됨")});
            this.rdgBlacklist.Size = new System.Drawing.Size(678, 30);
            this.rdgBlacklist.StyleController = this.layoutControl1;
            this.rdgBlacklist.TabIndex = 11;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.rdgBlacklist;
            this.layoutControlItem10.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem10.CustomizationFormText = "블랙리스트";
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(752, 34);
            this.layoutControlItem10.Text = " 입양상태: ";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(67, 18);
            // 
            // adoptionBindingSource
            // 
            this.adoptionBindingSource.DataSource = typeof(AnimalShelterManagementSystem.Adoption);
            // 
            // homelessAnimalBindingSource
            // 
            this.homelessAnimalBindingSource.DataSource = typeof(AnimalShelterManagementSystem.HomelessAnimal);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(AnimalShelterManagementSystem.AnimalShelter);
            // 
            // userLoginId
            // 
            this.userLoginId.DataPropertyName = "userLoginId";
            this.userLoginId.HeaderText = "userLoginId";
            this.userLoginId.MinimumWidth = 6;
            this.userLoginId.Name = "userLoginId";
            this.userLoginId.ReadOnly = true;
            this.userLoginId.Width = 125;
            // 
            // AnimalName
            // 
            this.AnimalName.DataPropertyName = "AnimalName";
            this.AnimalName.HeaderText = "AnimalName";
            this.AnimalName.MinimumWidth = 6;
            this.AnimalName.Name = "AnimalName";
            this.AnimalName.ReadOnly = true;
            this.AnimalName.Width = 125;
            // 
            // AdoptionDate
            // 
            this.AdoptionDate.DataPropertyName = "AdoptionDate";
            this.AdoptionDate.HeaderText = "AdoptionDate";
            this.AdoptionDate.MinimumWidth = 6;
            this.AdoptionDate.Name = "AdoptionDate";
            this.AdoptionDate.ReadOnly = true;
            this.AdoptionDate.Width = 125;
            // 
            // AdoptionManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 314);
            this.Controls.Add(this.layoutControl1);
            this.Name = "AdoptionManagement";
            this.Text = "AdoptionManagement";
            this.Load += new System.EventHandler(this.AdoptionManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txeUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgBlacklist.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adoptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homelessAnimalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnAdoptionManagement;
        private System.Windows.Forms.DataGridView r;
        private System.Windows.Forms.BindingSource homelessAnimalBindingSource;
        private DevExpress.XtraLayout.LayoutControlItem list;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TextEdit txeUserName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource adoptionBindingSource;
        private DevExpress.XtraEditors.RadioGroup rdgBlacklist;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLoginId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdoptionDate;
    }
}