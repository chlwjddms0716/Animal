namespace AnimalShelterManagementSystem.WinForm.Forms
{
    partial class HomelessAnimalListForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.추가IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.수정UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.도움말HToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.homelessAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchControl1 = new AnimalShelterManagementSystem.WinForm.UserControls.SearchControl();
            this.grcAnimalList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.동물Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.종 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.이름 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.나이 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.성별 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.특징 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.건강상태 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.보호소Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.최신발견날짜 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.사진 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homelessAnimalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcAnimalList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.편집EToolStripMenuItem,
            this.도움말HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1029, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료XToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // 종료XToolStripMenuItem
            // 
            this.종료XToolStripMenuItem.Name = "종료XToolStripMenuItem";
            this.종료XToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.종료XToolStripMenuItem.Text = "종료(&X)";
            this.종료XToolStripMenuItem.Click += new System.EventHandler(this.종료XToolStripMenuItem_Click);
            // 
            // 편집EToolStripMenuItem
            // 
            this.편집EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.추가IToolStripMenuItem,
            this.삭제DToolStripMenuItem,
            this.수정UToolStripMenuItem});
            this.편집EToolStripMenuItem.Name = "편집EToolStripMenuItem";
            this.편집EToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.편집EToolStripMenuItem.Text = "편집(&E)";
            // 
            // 추가IToolStripMenuItem
            // 
            this.추가IToolStripMenuItem.Name = "추가IToolStripMenuItem";
            this.추가IToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.추가IToolStripMenuItem.Text = "추가(&I)";
            this.추가IToolStripMenuItem.Click += new System.EventHandler(this.추가IToolStripMenuItem_Click);
            // 
            // 삭제DToolStripMenuItem
            // 
            this.삭제DToolStripMenuItem.Name = "삭제DToolStripMenuItem";
            this.삭제DToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.삭제DToolStripMenuItem.Text = "삭제(&D)";
            this.삭제DToolStripMenuItem.Click += new System.EventHandler(this.삭제DToolStripMenuItem_Click);
            // 
            // 수정UToolStripMenuItem
            // 
            this.수정UToolStripMenuItem.Name = "수정UToolStripMenuItem";
            this.수정UToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.수정UToolStripMenuItem.Text = "수정(&U)";
            this.수정UToolStripMenuItem.Click += new System.EventHandler(this.수정UToolStripMenuItem_Click);
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.정보AToolStripMenuItem,
            this.toolStripSeparator1,
            this.도움말HToolStripMenuItem1});
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.도움말HToolStripMenuItem.Text = "도움말(&H)";
            // 
            // 정보AToolStripMenuItem
            // 
            this.정보AToolStripMenuItem.Name = "정보AToolStripMenuItem";
            this.정보AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.정보AToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.정보AToolStripMenuItem.Text = "정보(&A)";
            this.정보AToolStripMenuItem.Click += new System.EventHandler(this.정보AToolStripMenuItem_Click);
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
            this.도움말HToolStripMenuItem1.Click += new System.EventHandler(this.도움말HToolStripMenuItem1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1029, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.Close;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "닫기";
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
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.Edit;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "수정";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
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
            // homelessAnimalBindingSource
            // 
            this.homelessAnimalBindingSource.DataSource = typeof(AnimalShelterManagementSystem.HomelessAnimal);
            // 
            // searchControl1
            // 
            this.searchControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchControl1.Location = new System.Drawing.Point(0, 55);
            this.searchControl1.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Size = new System.Drawing.Size(1029, 196);
            this.searchControl1.TabIndex = 4;
            this.searchControl1.LoadButtonClicked += new System.EventHandler<AnimalShelterManagementSystem.WinForm.UserControls.SearchControl.LoadButtonClickedEventArgs>(this.searchControl1_LoadButtonClicked_1);
            // 
            // grcAnimalList
            // 
            this.grcAnimalList.DataSource = this.homelessAnimalBindingSource;
            this.grcAnimalList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcAnimalList.Location = new System.Drawing.Point(0, 251);
            this.grcAnimalList.MainView = this.gridView1;
            this.grcAnimalList.Name = "grcAnimalList";
            this.grcAnimalList.Size = new System.Drawing.Size(1029, 425);
            this.grcAnimalList.TabIndex = 6;
            this.grcAnimalList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grcAnimalList.DoubleClick += new System.EventHandler(this.grcAnimalList_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.동물Id,
            this.종,
            this.이름,
            this.나이,
            this.성별,
            this.특징,
            this.건강상태,
            this.보호소Id,
            this.최신발견날짜,
            this.사진});
            this.gridView1.GridControl = this.grcAnimalList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // 동물Id
            // 
            this.동물Id.Caption = "동물Id";
            this.동물Id.FieldName = "HomelessAnimalId";
            this.동물Id.MinWidth = 25;
            this.동물Id.Name = "동물Id";
            this.동물Id.Visible = true;
            this.동물Id.VisibleIndex = 4;
            this.동물Id.Width = 100;
            // 
            // 종
            // 
            this.종.Caption = "종";
            this.종.FieldName = "SpeciesName";
            this.종.MinWidth = 25;
            this.종.Name = "종";
            this.종.Visible = true;
            this.종.VisibleIndex = 0;
            this.종.Width = 100;
            // 
            // 이름
            // 
            this.이름.Caption = "이름";
            this.이름.FieldName = "Name";
            this.이름.MinWidth = 25;
            this.이름.Name = "이름";
            this.이름.Visible = true;
            this.이름.VisibleIndex = 5;
            this.이름.Width = 100;
            // 
            // 나이
            // 
            this.나이.Caption = "나이";
            this.나이.FieldName = "Age";
            this.나이.MinWidth = 25;
            this.나이.Name = "나이";
            this.나이.Visible = true;
            this.나이.VisibleIndex = 6;
            this.나이.Width = 100;
            // 
            // 성별
            // 
            this.성별.Caption = "성별";
            this.성별.FieldName = "GenderName";
            this.성별.MinWidth = 25;
            this.성별.Name = "성별";
            this.성별.Visible = true;
            this.성별.VisibleIndex = 2;
            this.성별.Width = 100;
            // 
            // 특징
            // 
            this.특징.Caption = "특징";
            this.특징.FieldName = "Feature";
            this.특징.MinWidth = 25;
            this.특징.Name = "특징";
            this.특징.Visible = true;
            this.특징.VisibleIndex = 7;
            this.특징.Width = 100;
            // 
            // 건강상태
            // 
            this.건강상태.Caption = "건강상태";
            this.건강상태.FieldName = "PhysicalConditionName";
            this.건강상태.MinWidth = 25;
            this.건강상태.Name = "건강상태";
            this.건강상태.Visible = true;
            this.건강상태.VisibleIndex = 1;
            this.건강상태.Width = 100;
            // 
            // 보호소Id
            // 
            this.보호소Id.Caption = "보호소Id";
            this.보호소Id.FieldName = "AnimalShelterId";
            this.보호소Id.MinWidth = 25;
            this.보호소Id.Name = "보호소Id";
            this.보호소Id.Visible = true;
            this.보호소Id.VisibleIndex = 9;
            this.보호소Id.Width = 110;
            // 
            // 최신발견날짜
            // 
            this.최신발견날짜.Caption = "최신발견날짜";
            this.최신발견날짜.FieldName = "LatestFindingReportDate";
            this.최신발견날짜.MinWidth = 25;
            this.최신발견날짜.Name = "최신발견날짜";
            this.최신발견날짜.Visible = true;
            this.최신발견날짜.VisibleIndex = 3;
            this.최신발견날짜.Width = 100;
            // 
            // 사진
            // 
            this.사진.Caption = "사진";
            this.사진.FieldName = "Picture";
            this.사진.MinWidth = 25;
            this.사진.Name = "사진";
            this.사진.Visible = true;
            this.사진.VisibleIndex = 8;
            this.사진.Width = 95;
            // 
            // HomelessAnimalListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 676);
            this.Controls.Add(this.grcAnimalList);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IconOptions.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.BlackPuppy;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HomelessAnimalListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "유기유실동물리스트";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homelessAnimalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcAnimalList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 추가IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정보AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.BindingSource homelessAnimalBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isMaleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn physicalConditionCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem 수정UToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private UserControls.SearchControl searchControl1;
        private DevExpress.XtraGrid.GridControl grcAnimalList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn 동물Id;
        private DevExpress.XtraGrid.Columns.GridColumn 종;
        private DevExpress.XtraGrid.Columns.GridColumn 이름;
        private DevExpress.XtraGrid.Columns.GridColumn 나이;
        private DevExpress.XtraGrid.Columns.GridColumn 성별;
        private DevExpress.XtraGrid.Columns.GridColumn 특징;
        private DevExpress.XtraGrid.Columns.GridColumn 건강상태;
        private DevExpress.XtraGrid.Columns.GridColumn 보호소Id;
        private DevExpress.XtraGrid.Columns.GridColumn 최신발견날짜;
        private DevExpress.XtraGrid.Columns.GridColumn 사진;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}