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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShelterListForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.grcShelterList = new DevExpress.XtraGrid.GridControl();
            this.animalShelterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.보호소Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.이름 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.주소 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.전화번호 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.담당자 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.btnInsert = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnUpdate = new System.Windows.Forms.ToolStripButton();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.lkuShelterName = new DevExpress.XtraEditors.LookUpEdit();
            this.AnimalShelterName = new System.Windows.Forms.BindingSource(this.components);
            this.txeAddress = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.종료XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.추가IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.도움말HToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcShelterList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalShelterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkuShelterName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalShelterName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnLoad);
            this.layoutControl1.Controls.Add(this.grcShelterList);
            this.layoutControl1.Controls.Add(this.toolStrip1);
            this.layoutControl1.Controls.Add(this.lkuShelterName);
            this.layoutControl1.Controls.Add(this.txeAddress);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 161, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(771, 489);
            this.layoutControl1.TabIndex = 7;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnLoad
            // 
            this.btnLoad.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.btnLoad.Appearance.Options.UseFont = true;
            this.btnLoad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.ImageOptions.Image")));
            this.btnLoad.Location = new System.Drawing.Point(569, 68);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(190, 36);
            this.btnLoad.StyleController = this.layoutControl1;
            this.btnLoad.TabIndex = 17;
            this.btnLoad.Text = "검색";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // grcShelterList
            // 
            this.grcShelterList.DataSource = this.animalShelterBindingSource;
            this.grcShelterList.Location = new System.Drawing.Point(12, 156);
            this.grcShelterList.MainView = this.gridView1;
            this.grcShelterList.Name = "grcShelterList";
            this.grcShelterList.Size = new System.Drawing.Size(747, 321);
            this.grcShelterList.TabIndex = 4;
            this.grcShelterList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grcShelterList.DoubleClick += new System.EventHandler(this.grcShelterList_DoubleClick);
            // 
            // animalShelterBindingSource
            // 
            this.animalShelterBindingSource.DataSource = typeof(AnimalShelterManagementSystem.AnimalShelter);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.보호소Id,
            this.이름,
            this.주소,
            this.전화번호,
            this.담당자});
            this.gridView1.GridControl = this.grcShelterList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // 보호소Id
            // 
            this.보호소Id.Caption = "보호소Id";
            this.보호소Id.FieldName = "AnimalShelterId";
            this.보호소Id.MinWidth = 25;
            this.보호소Id.Name = "보호소Id";
            this.보호소Id.Visible = true;
            this.보호소Id.VisibleIndex = 0;
            this.보호소Id.Width = 94;
            // 
            // 이름
            // 
            this.이름.Caption = "이름";
            this.이름.FieldName = "Name";
            this.이름.MinWidth = 25;
            this.이름.Name = "이름";
            this.이름.Visible = true;
            this.이름.VisibleIndex = 1;
            this.이름.Width = 94;
            // 
            // 주소
            // 
            this.주소.Caption = "주소";
            this.주소.FieldName = "Address";
            this.주소.MinWidth = 25;
            this.주소.Name = "주소";
            this.주소.Visible = true;
            this.주소.VisibleIndex = 2;
            this.주소.Width = 94;
            // 
            // 전화번호
            // 
            this.전화번호.Caption = "전화번호";
            this.전화번호.FieldName = "PhoneNumber";
            this.전화번호.MinWidth = 25;
            this.전화번호.Name = "전화번호";
            this.전화번호.Visible = true;
            this.전화번호.VisibleIndex = 3;
            this.전화번호.Width = 94;
            // 
            // 담당자
            // 
            this.담당자.Caption = "담당자";
            this.담당자.FieldName = "ManagerName";
            this.담당자.MinWidth = 25;
            this.담당자.Name = "담당자";
            this.담당자.Visible = true;
            this.담당자.VisibleIndex = 4;
            this.담당자.Width = 94;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClose,
            this.btnInsert,
            this.btnEdit,
            this.btnDelete,
            this.btnUpdate,
            this.btnHelp});
            this.toolStrip1.Location = new System.Drawing.Point(12, 108);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(747, 44);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnClose
            // 
            this.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 41);
            this.btnClose.Text = "종료";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(29, 41);
            this.btnInsert.Text = "추가";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(29, 41);
            this.btnEdit.Text = "수정";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(29, 41);
            this.btnDelete.Text = "삭제";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(29, 41);
            this.btnUpdate.Text = "업데이트";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(29, 41);
            this.btnHelp.Text = "도움말";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lkuShelterName
            // 
            this.lkuShelterName.Location = new System.Drawing.Point(95, 40);
            this.lkuShelterName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lkuShelterName.Name = "lkuShelterName";
            this.lkuShelterName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuShelterName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "전체를 보고싶으시면 update버튼을 눌러주세요.")});
            this.lkuShelterName.Properties.DataSource = this.AnimalShelterName;
            this.lkuShelterName.Properties.DisplayMember = "Name";
            this.lkuShelterName.Properties.NullText = "보호소를 선택해주세요.";
            this.lkuShelterName.Properties.ValueMember = "AnimalShelterId";
            this.lkuShelterName.Size = new System.Drawing.Size(664, 24);
            this.lkuShelterName.StyleController = this.layoutControl1;
            this.lkuShelterName.TabIndex = 2;
            this.lkuShelterName.EditValueChanged += new System.EventHandler(this.lkuShelterName_EditValueChanged);
            // 
            // AnimalShelterName
            // 
            this.AnimalShelterName.DataSource = typeof(AnimalShelterManagementSystem.AnimalShelter);
            // 
            // txeAddress
            // 
            this.txeAddress.Location = new System.Drawing.Point(95, 12);
            this.txeAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txeAddress.Name = "txeAddress";
            this.txeAddress.Size = new System.Drawing.Size(664, 24);
            this.txeAddress.StyleController = this.layoutControl1;
            this.txeAddress.TabIndex = 0;
            this.txeAddress.EditValueChanged += new System.EventHandler(this.txeAddress_EditValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(771, 489);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.toolStrip1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(751, 48);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txeAddress;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(751, 28);
            this.layoutControlItem3.Text = "주소 : ";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(80, 18);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.lkuShelterName;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(751, 28);
            this.layoutControlItem4.Text = "보호소 이름 :";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(80, 18);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.grcShelterList;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(751, 325);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnLoad;
            this.layoutControlItem1.Location = new System.Drawing.Point(557, 56);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(194, 40);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 56);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(557, 40);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 489);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("ShelterListForm.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ShelterListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "보호소리스트";
            this.Load += new System.EventHandler(this.Shelter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcShelterList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalShelterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkuShelterName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalShelterName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.BindingSource animalShelterBindingSource;
        private DevExpress.XtraEditors.TextEdit txeAddress;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.LookUpEdit lkuShelterName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripButton btnInsert;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.ToolStripMenuItem 종료XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 추가IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정보AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem1;
        private System.Windows.Forms.BindingSource AnimalShelterName;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnUpdate;
        private DevExpress.XtraGrid.GridControl grcShelterList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn 보호소Id;
        private DevExpress.XtraGrid.Columns.GridColumn 이름;
        private DevExpress.XtraGrid.Columns.GridColumn 주소;
        private DevExpress.XtraGrid.Columns.GridColumn 전화번호;
        private DevExpress.XtraGrid.Columns.GridColumn 담당자;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}