namespace AnimalShelterManagementSystem.WinForm.AdminForms
{
    partial class UserListForm
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
            this.grvUserList = new System.Windows.Forms.DataGridView();
            this.rdgAdmin = new DevExpress.XtraEditors.RadioGroup();
            this.rdgBlacklist = new DevExpress.XtraEditors.RadioGroup();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbId = new System.Windows.Forms.TextBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txbUserName = new DevExpress.XtraLayout.LayoutControlItem();
            this.txbUserId = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isBlacklistDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.blacklistReasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAdministratorDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgAdmin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgBlacklist.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbUserId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.toolStrip1);
            this.layoutControl1.Controls.Add(this.grvUserList);
            this.layoutControl1.Controls.Add(this.rdgAdmin);
            this.layoutControl1.Controls.Add(this.rdgBlacklist);
            this.layoutControl1.Controls.Add(this.txbName);
            this.layoutControl1.Controls.Add(this.txbId);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 540);
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
            this.toolStrip1.Location = new System.Drawing.Point(12, 198);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(776, 26);
            this.toolStrip1.TabIndex = 10;
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
            // grvUserList
            // 
            this.grvUserList.AllowUserToAddRows = false;
            this.grvUserList.AllowUserToDeleteRows = false;
            this.grvUserList.AllowUserToOrderColumns = true;
            this.grvUserList.AutoGenerateColumns = false;
            this.grvUserList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIdDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.isBlacklistDataGridViewCheckBoxColumn,
            this.blacklistReasonDataGridViewTextBoxColumn,
            this.isAdministratorDataGridViewCheckBoxColumn});
            this.grvUserList.DataSource = this.userBindingSource;
            this.grvUserList.Location = new System.Drawing.Point(82, 228);
            this.grvUserList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grvUserList.Name = "grvUserList";
            this.grvUserList.ReadOnly = true;
            this.grvUserList.RowHeadersVisible = false;
            this.grvUserList.RowHeadersWidth = 51;
            this.grvUserList.RowTemplate.Height = 27;
            this.grvUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvUserList.Size = new System.Drawing.Size(706, 300);
            this.grvUserList.TabIndex = 10;
            this.grvUserList.DoubleClick += new System.EventHandler(this.grvUserList_DoubleClick);
            // 
            // rdgAdmin
            // 
            this.rdgAdmin.EditValue = 0;
            this.rdgAdmin.Location = new System.Drawing.Point(82, 70);
            this.rdgAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdgAdmin.Name = "rdgAdmin";
            this.rdgAdmin.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "전체"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "관리자"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "일반 유저")});
            this.rdgAdmin.Size = new System.Drawing.Size(706, 61);
            this.rdgAdmin.StyleController = this.layoutControl1;
            this.rdgAdmin.TabIndex = 11;
            this.rdgAdmin.SelectedIndexChanged += new System.EventHandler(this.rdgAdmin_SelectedIndexChanged);
            // 
            // rdgBlacklist
            // 
            this.rdgBlacklist.EditValue = 0;
            this.rdgBlacklist.Location = new System.Drawing.Point(82, 135);
            this.rdgBlacklist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdgBlacklist.Name = "rdgBlacklist";
            this.rdgBlacklist.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "전체"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "블랙 유저"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "일반 유저")});
            this.rdgBlacklist.Size = new System.Drawing.Size(706, 59);
            this.rdgBlacklist.StyleController = this.layoutControl1;
            this.rdgBlacklist.TabIndex = 11;
            this.rdgBlacklist.SelectedIndexChanged += new System.EventHandler(this.rdgBlacklist_SelectedIndexChanged);
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(82, 12);
            this.txbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(706, 25);
            this.txbName.TabIndex = 6;
            this.txbName.TextChanged += new System.EventHandler(this.txbName_TextChanged);
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(82, 41);
            this.txbId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(706, 25);
            this.txbId.TabIndex = 6;
            this.txbId.TextChanged += new System.EventHandler(this.txbId_TextChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.txbUserName,
            this.txbUserId,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 540);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.grvUserList;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "l";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 216);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(780, 304);
            this.layoutControlItem2.Text = "리스트";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(67, 18);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.rdgAdmin;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "관리자";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 58);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(780, 65);
            this.layoutControlItem3.Text = "관리자";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(67, 18);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.rdgBlacklist;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem1.CustomizationFormText = "블랙리스트";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 123);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 63);
            this.layoutControlItem1.Text = "블랙리스트";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(67, 18);
            // 
            // txbUserName
            // 
            this.txbUserName.Control = this.txbName;
            this.txbUserName.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.txbUserName.CustomizationFormText = "유저 이름 : ";
            this.txbUserName.Location = new System.Drawing.Point(0, 0);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(780, 29);
            this.txbUserName.Text = "유저 이름 :";
            this.txbUserName.TextSize = new System.Drawing.Size(67, 18);
            // 
            // txbUserId
            // 
            this.txbUserId.Control = this.txbId;
            this.txbUserId.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.txbUserId.CustomizationFormText = "유저 Id : ";
            this.txbUserId.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
            this.txbUserId.Location = new System.Drawing.Point(0, 29);
            this.txbUserId.Name = "txbUserId";
            this.txbUserId.Size = new System.Drawing.Size(780, 29);
            this.txbUserId.Text = "유저 Id :";
            this.txbUserId.TextSize = new System.Drawing.Size(67, 18);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.toolStrip1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 186);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(780, 30);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "유저Id";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIdDataGridViewTextBoxColumn.Width = 80;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "비밀번호";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Width = 125;
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
            // isBlacklistDataGridViewCheckBoxColumn
            // 
            this.isBlacklistDataGridViewCheckBoxColumn.DataPropertyName = "IsBlacklist";
            this.isBlacklistDataGridViewCheckBoxColumn.HeaderText = "블랙리스트여부";
            this.isBlacklistDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isBlacklistDataGridViewCheckBoxColumn.Name = "isBlacklistDataGridViewCheckBoxColumn";
            this.isBlacklistDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isBlacklistDataGridViewCheckBoxColumn.Width = 125;
            // 
            // blacklistReasonDataGridViewTextBoxColumn
            // 
            this.blacklistReasonDataGridViewTextBoxColumn.DataPropertyName = "BlacklistReason";
            this.blacklistReasonDataGridViewTextBoxColumn.HeaderText = "블랙리스트이유";
            this.blacklistReasonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.blacklistReasonDataGridViewTextBoxColumn.Name = "blacklistReasonDataGridViewTextBoxColumn";
            this.blacklistReasonDataGridViewTextBoxColumn.ReadOnly = true;
            this.blacklistReasonDataGridViewTextBoxColumn.Width = 125;
            // 
            // isAdministratorDataGridViewCheckBoxColumn
            // 
            this.isAdministratorDataGridViewCheckBoxColumn.DataPropertyName = "IsAdministrator";
            this.isAdministratorDataGridViewCheckBoxColumn.HeaderText = "관리자여부";
            this.isAdministratorDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isAdministratorDataGridViewCheckBoxColumn.Name = "isAdministratorDataGridViewCheckBoxColumn";
            this.isAdministratorDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isAdministratorDataGridViewCheckBoxColumn.Width = 125;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(AnimalShelterManagementSystem.User);
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.BlackPuppy;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "유저리스트";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgAdmin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgBlacklist.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbUserId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.DataGridView grvUserList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.RadioGroup rdgAdmin;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbId;
        private DevExpress.XtraLayout.LayoutControlItem txbUserName;
        private DevExpress.XtraLayout.LayoutControlItem txbUserId;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private DevExpress.XtraEditors.RadioGroup rdgBlacklist;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isBlacklistDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blacklistReasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isAdministratorDataGridViewCheckBoxColumn;
    }
}