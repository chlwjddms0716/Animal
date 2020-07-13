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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserListForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.grcUserList = new DevExpress.XtraGrid.GridControl();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.유저Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.비밀번호 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.이름 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.주소 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.전화번호 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.블랙리스트여부 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.블랙리스트사유 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.관리자여부 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.rdgAdmin = new DevExpress.XtraEditors.RadioGroup();
            this.rdgBlacklist = new DevExpress.XtraEditors.RadioGroup();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbId = new System.Windows.Forms.TextBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txbUserName = new DevExpress.XtraLayout.LayoutControlItem();
            this.txbUserId = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgAdmin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgBlacklist.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbUserId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnLoad);
            this.layoutControl1.Controls.Add(this.grcUserList);
            this.layoutControl1.Controls.Add(this.toolStrip1);
            this.layoutControl1.Controls.Add(this.rdgAdmin);
            this.layoutControl1.Controls.Add(this.rdgBlacklist);
            this.layoutControl1.Controls.Add(this.txbName);
            this.layoutControl1.Controls.Add(this.txbId);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 212, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 540);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnLoad
            // 
            this.btnLoad.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.btnLoad.Appearance.Options.UseFont = true;
            this.btnLoad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.ImageOptions.Image")));
            this.btnLoad.Location = new System.Drawing.Point(581, 138);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(207, 36);
            this.btnLoad.StyleController = this.layoutControl1;
            this.btnLoad.TabIndex = 17;
            this.btnLoad.Text = "검색";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // grcUserList
            // 
            this.grcUserList.DataSource = this.userBindingSource;
            this.grcUserList.Location = new System.Drawing.Point(12, 234);
            this.grcUserList.MainView = this.gridView1;
            this.grcUserList.Name = "grcUserList";
            this.grcUserList.Size = new System.Drawing.Size(776, 294);
            this.grcUserList.TabIndex = 12;
            this.grcUserList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grcUserList.DoubleClick += new System.EventHandler(this.grcUserList_DoubleClick);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(AnimalShelterManagementSystem.User);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.유저Id,
            this.Id,
            this.비밀번호,
            this.이름,
            this.주소,
            this.전화번호,
            this.블랙리스트여부,
            this.블랙리스트사유,
            this.관리자여부});
            this.gridView1.GridControl = this.grcUserList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // 유저Id
            // 
            this.유저Id.Caption = "유저Id";
            this.유저Id.FieldName = "UserId";
            this.유저Id.MinWidth = 25;
            this.유저Id.Name = "유저Id";
            this.유저Id.Visible = true;
            this.유저Id.VisibleIndex = 0;
            this.유저Id.Width = 94;
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.MinWidth = 25;
            this.Id.Name = "Id";
            this.Id.Visible = true;
            this.Id.VisibleIndex = 1;
            this.Id.Width = 94;
            // 
            // 비밀번호
            // 
            this.비밀번호.Caption = "비밀번호";
            this.비밀번호.FieldName = "Password";
            this.비밀번호.MinWidth = 25;
            this.비밀번호.Name = "비밀번호";
            this.비밀번호.Visible = true;
            this.비밀번호.VisibleIndex = 2;
            this.비밀번호.Width = 94;
            // 
            // 이름
            // 
            this.이름.Caption = "이름";
            this.이름.FieldName = "Name";
            this.이름.MinWidth = 25;
            this.이름.Name = "이름";
            this.이름.Visible = true;
            this.이름.VisibleIndex = 3;
            this.이름.Width = 94;
            // 
            // 주소
            // 
            this.주소.Caption = "주소";
            this.주소.FieldName = "Address";
            this.주소.MinWidth = 25;
            this.주소.Name = "주소";
            this.주소.Visible = true;
            this.주소.VisibleIndex = 4;
            this.주소.Width = 94;
            // 
            // 전화번호
            // 
            this.전화번호.Caption = "전화번호";
            this.전화번호.FieldName = "PhoneNumber";
            this.전화번호.MinWidth = 25;
            this.전화번호.Name = "전화번호";
            this.전화번호.Visible = true;
            this.전화번호.VisibleIndex = 5;
            this.전화번호.Width = 94;
            // 
            // 블랙리스트여부
            // 
            this.블랙리스트여부.Caption = "블랙리스트 여부";
            this.블랙리스트여부.FieldName = "IsBlacklist";
            this.블랙리스트여부.MinWidth = 25;
            this.블랙리스트여부.Name = "블랙리스트여부";
            this.블랙리스트여부.Visible = true;
            this.블랙리스트여부.VisibleIndex = 6;
            this.블랙리스트여부.Width = 94;
            // 
            // 블랙리스트사유
            // 
            this.블랙리스트사유.Caption = "블랙리스트 사유";
            this.블랙리스트사유.FieldName = "BlacklistReason";
            this.블랙리스트사유.MinWidth = 25;
            this.블랙리스트사유.Name = "블랙리스트사유";
            this.블랙리스트사유.Visible = true;
            this.블랙리스트사유.VisibleIndex = 7;
            this.블랙리스트사유.Width = 94;
            // 
            // 관리자여부
            // 
            this.관리자여부.Caption = "관리자 여부";
            this.관리자여부.FieldName = "IsAdministrator";
            this.관리자여부.MinWidth = 25;
            this.관리자여부.Name = "관리자여부";
            this.관리자여부.Visible = true;
            this.관리자여부.VisibleIndex = 8;
            this.관리자여부.Width = 94;
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
            this.btnHelp,
            this.tsbRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(12, 178);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(776, 52);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(29, 49);
            this.tsbAdd.Text = "추가";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(29, 49);
            this.tsbDelete.Text = "삭제";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(29, 49);
            this.tsbEdit.Text = "수정";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(29, 49);
            this.btnHelp.Text = "도움말";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(29, 49);
            this.tsbRefresh.Text = "새로고침";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
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
            this.rdgAdmin.Size = new System.Drawing.Size(706, 30);
            this.rdgAdmin.StyleController = this.layoutControl1;
            this.rdgAdmin.TabIndex = 11;
            // 
            // rdgBlacklist
            // 
            this.rdgBlacklist.EditValue = 0;
            this.rdgBlacklist.Location = new System.Drawing.Point(82, 104);
            this.rdgBlacklist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdgBlacklist.Name = "rdgBlacklist";
            this.rdgBlacklist.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "전체"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "블랙 유저"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "일반 유저")});
            this.rdgBlacklist.Size = new System.Drawing.Size(706, 30);
            this.rdgBlacklist.StyleController = this.layoutControl1;
            this.rdgBlacklist.TabIndex = 11;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(82, 12);
            this.txbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(706, 25);
            this.txbName.TabIndex = 6;
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(82, 41);
            this.txbId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(706, 25);
            this.txbId.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.txbUserName,
            this.txbUserId,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem2,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 540);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.rdgAdmin;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "관리자";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 58);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(780, 34);
            this.layoutControlItem3.Text = "관리자";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(67, 18);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.rdgBlacklist;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem1.CustomizationFormText = "블랙리스트";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 92);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 34);
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
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 166);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(780, 56);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.grcUserList;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 222);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(780, 298);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnLoad;
            this.layoutControlItem2.Location = new System.Drawing.Point(569, 126);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(211, 40);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 126);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(569, 40);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // UserListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("UserListForm.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "유저리스트";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgAdmin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgBlacklist.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbUserId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
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
        private DevExpress.XtraGrid.GridControl grcUserList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn 유저Id;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn 비밀번호;
        private DevExpress.XtraGrid.Columns.GridColumn 이름;
        private DevExpress.XtraGrid.Columns.GridColumn 주소;
        private DevExpress.XtraGrid.Columns.GridColumn 전화번호;
        private DevExpress.XtraGrid.Columns.GridColumn 블랙리스트여부;
        private DevExpress.XtraGrid.Columns.GridColumn 블랙리스트사유;
        private DevExpress.XtraGrid.Columns.GridColumn 관리자여부;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.ToolStripButton btnHelp;
    }
}