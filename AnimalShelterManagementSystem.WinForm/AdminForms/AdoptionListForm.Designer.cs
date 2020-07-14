﻿namespace AnimalShelterManagementSystem.WinForm.AdminForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdoptionListForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.grcAdoptionList = new DevExpress.XtraGrid.GridControl();
            this.adoptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.유저Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.동물이름 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.입양상태 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.입양날짜 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txeId = new DevExpress.XtraEditors.TextEdit();
            this.rdgAdoptionStatus = new DevExpress.XtraEditors.RadioGroup();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcAdoptionList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adoptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgAdoptionStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnLoad);
            this.layoutControl1.Controls.Add(this.toolStrip1);
            this.layoutControl1.Controls.Add(this.grcAdoptionList);
            this.layoutControl1.Controls.Add(this.txeId);
            this.layoutControl1.Controls.Add(this.rdgAdoptionStatus);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1020, 126, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(639, 454);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnLoad
            // 
            this.btnLoad.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.btnLoad.Appearance.Options.UseFont = true;
            this.btnLoad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.ImageOptions.Image")));
            this.btnLoad.Location = new System.Drawing.Point(448, 74);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(179, 36);
            this.btnLoad.StyleController = this.layoutControl1;
            this.btnLoad.TabIndex = 16;
            this.btnLoad.Text = "검색";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
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
            this.toolStrip1.Location = new System.Drawing.Point(12, 114);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(615, 38);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.Insert;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(29, 35);
            this.tsbAdd.Text = "추가";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.Delete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(29, 35);
            this.tsbDelete.Text = "삭제";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEdit.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.Edit;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(29, 35);
            this.tsbEdit.Text = "수정";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHelp.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.Help;
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(29, 35);
            this.btnHelp.Text = "도움말";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.Update;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(29, 35);
            this.tsbRefresh.Text = "새로고침";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // grcAdoptionList
            // 
            this.grcAdoptionList.DataSource = this.adoptionBindingSource;
            this.grcAdoptionList.Location = new System.Drawing.Point(12, 156);
            this.grcAdoptionList.MainView = this.gridView1;
            this.grcAdoptionList.Name = "grcAdoptionList";
            this.grcAdoptionList.Size = new System.Drawing.Size(615, 286);
            this.grcAdoptionList.TabIndex = 14;
            this.grcAdoptionList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grcAdoptionList.DoubleClick += new System.EventHandler(this.grcAdoptionList_DoubleClick);
            // 
            // adoptionBindingSource
            // 
            this.adoptionBindingSource.DataSource = typeof(AnimalShelterManagementSystem.Adoption);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.유저Id,
            this.동물이름,
            this.입양상태,
            this.입양날짜});
            this.gridView1.GridControl = this.grcAdoptionList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // 유저Id
            // 
            this.유저Id.Caption = "유저Id";
            this.유저Id.FieldName = "userLoginId";
            this.유저Id.MinWidth = 25;
            this.유저Id.Name = "유저Id";
            this.유저Id.Visible = true;
            this.유저Id.VisibleIndex = 0;
            this.유저Id.Width = 94;
            // 
            // 동물이름
            // 
            this.동물이름.Caption = "동물이름";
            this.동물이름.FieldName = "AnimalName";
            this.동물이름.MinWidth = 25;
            this.동물이름.Name = "동물이름";
            this.동물이름.Visible = true;
            this.동물이름.VisibleIndex = 1;
            this.동물이름.Width = 94;
            // 
            // 입양상태
            // 
            this.입양상태.Caption = "입양상태";
            this.입양상태.FieldName = "userLoginId";
            this.입양상태.MinWidth = 25;
            this.입양상태.Name = "입양상태";
            this.입양상태.Visible = true;
            this.입양상태.VisibleIndex = 2;
            this.입양상태.Width = 94;
            // 
            // 입양날짜
            // 
            this.입양날짜.Caption = "입양날짜";
            this.입양날짜.FieldName = "AdoptionDate";
            this.입양날짜.MinWidth = 25;
            this.입양날짜.Name = "입양날짜";
            this.입양날짜.Visible = true;
            this.입양날짜.VisibleIndex = 3;
            this.입양날짜.Width = 94;
            // 
            // txeId
            // 
            this.txeId.Location = new System.Drawing.Point(82, 46);
            this.txeId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txeId.Name = "txeId";
            this.txeId.Size = new System.Drawing.Size(545, 24);
            this.txeId.StyleController = this.layoutControl1;
            this.txeId.TabIndex = 8;
            // 
            // rdgAdoptionStatus
            // 
            this.rdgAdoptionStatus.EditValue = 0;
            this.rdgAdoptionStatus.Location = new System.Drawing.Point(82, 12);
            this.rdgAdoptionStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdgAdoptionStatus.Name = "rdgAdoptionStatus";
            this.rdgAdoptionStatus.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "전체", true, null, ""),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "처리중"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "입양됨")});
            this.rdgAdoptionStatus.Size = new System.Drawing.Size(545, 30);
            this.rdgAdoptionStatus.StyleController = this.layoutControl1;
            this.rdgAdoptionStatus.TabIndex = 11;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.layoutControlItem10,
            this.emptySpaceItem1,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(639, 454);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 102);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(619, 42);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.grcAdoptionList;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(619, 290);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txeId;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 34);
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
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(619, 34);
            this.layoutControlItem10.Text = " 입양상태: ";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(67, 18);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 62);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(436, 40);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnLoad;
            this.layoutControlItem5.Location = new System.Drawing.Point(436, 62);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(183, 40);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.grcAdoptionList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adoptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgAdoptionStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txeId;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.RadioGroup rdgAdoptionStatus;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource adoptionBindingSource;
        private DevExpress.XtraGrid.GridControl grcAdoptionList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn 입양날짜;
        private DevExpress.XtraGrid.Columns.GridColumn 유저Id;
        private DevExpress.XtraGrid.Columns.GridColumn 동물이름;
        private DevExpress.XtraGrid.Columns.GridColumn 입양상태;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.ToolStripButton btnHelp;
    }
}