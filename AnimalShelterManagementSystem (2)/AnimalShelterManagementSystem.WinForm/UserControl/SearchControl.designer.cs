namespace AnimalShelterManagementSystem.WinForm.UserControls
{
    partial class SearchControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchControl));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dtaLastestFindingReportDate = new DevExpress.XtraEditors.DateEdit();
            this.dtaFindingReportDate = new DevExpress.XtraEditors.DateEdit();
            this.luIsmale = new DevExpress.XtraEditors.LookUpEdit();
            this.luAnimalshelter = new DevExpress.XtraEditors.LookUpEdit();
            this.luSpecies = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.성별 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dateTimeChartRangeControlClient1 = new DevExpress.XtraEditors.DateTimeChartRangeControlClient();
            this.sexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.animalShelterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.speciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.homelessAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalShelterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaLastestFindingReportDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaLastestFindingReportDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaFindingReportDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaFindingReportDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luIsmale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luAnimalshelter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luSpecies.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.성별)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalShelterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homelessAnimalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalShelterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(733, 414);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "검색";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dtaLastestFindingReportDate);
            this.layoutControl1.Controls.Add(this.dtaFindingReportDate);
            this.layoutControl1.Controls.Add(this.luIsmale);
            this.layoutControl1.Controls.Add(this.btnLoad);
            this.layoutControl1.Controls.Add(this.luAnimalshelter);
            this.layoutControl1.Controls.Add(this.luSpecies);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 27);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(729, 385);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dtaLastestFindingReportDate
            // 
            this.dtaLastestFindingReportDate.EditValue = null;
            this.dtaLastestFindingReportDate.Location = new System.Drawing.Point(411, 96);
            this.dtaLastestFindingReportDate.Name = "dtaLastestFindingReportDate";
            this.dtaLastestFindingReportDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtaLastestFindingReportDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtaLastestFindingReportDate.Size = new System.Drawing.Size(205, 24);
            this.dtaLastestFindingReportDate.StyleController = this.layoutControl1;
            this.dtaLastestFindingReportDate.TabIndex = 10;
            // 
            // dtaFindingReportDate
            // 
            this.dtaFindingReportDate.EditValue = null;
            this.dtaFindingReportDate.Location = new System.Drawing.Point(107, 96);
            this.dtaFindingReportDate.Name = "dtaFindingReportDate";
            this.dtaFindingReportDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtaFindingReportDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtaFindingReportDate.Size = new System.Drawing.Size(205, 24);
            this.dtaFindingReportDate.StyleController = this.layoutControl1;
            this.dtaFindingReportDate.TabIndex = 9;
            // 
            // luIsmale
            // 
            this.luIsmale.Location = new System.Drawing.Point(107, 68);
            this.luIsmale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.luIsmale.Name = "luIsmale";
            this.luIsmale.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luIsmale.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Sex1", "Name10")});
            this.luIsmale.Properties.DataSource = this.sexBindingSource;
            this.luIsmale.Properties.DisplayMember = "Sex1";
            this.luIsmale.Properties.ValueMember = "SexId";
            this.luIsmale.Size = new System.Drawing.Size(509, 24);
            this.luIsmale.StyleController = this.layoutControl1;
            this.luIsmale.TabIndex = 8;
            // 
            // luAnimalshelter
            // 
            this.luAnimalshelter.AllowDrop = true;
            this.luAnimalshelter.Location = new System.Drawing.Point(107, 12);
            this.luAnimalshelter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.luAnimalshelter.Name = "luAnimalshelter";
            this.luAnimalshelter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luAnimalshelter.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name1")});
            this.luAnimalshelter.Properties.DataSource = this.animalShelterBindingSource1;
            this.luAnimalshelter.Properties.DisplayMember = "Name";
            this.luAnimalshelter.Properties.ValueMember = "AnimalShelterId";
            this.luAnimalshelter.Size = new System.Drawing.Size(509, 24);
            this.luAnimalshelter.StyleController = this.layoutControl1;
            this.luAnimalshelter.TabIndex = 4;
            this.luAnimalshelter.UseWaitCursor = true;
            // 
            // luSpecies
            // 
            this.luSpecies.AllowDrop = true;
            this.luSpecies.Location = new System.Drawing.Point(107, 40);
            this.luSpecies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.luSpecies.Name = "luSpecies";
            this.luSpecies.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luSpecies.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Species1", "Name9")});
            this.luSpecies.Properties.DataSource = this.speciesBindingSource;
            this.luSpecies.Properties.DisplayMember = "Species1";
            this.luSpecies.Properties.ValueMember = "SpeciesCode";
            this.luSpecies.Size = new System.Drawing.Size(509, 24);
            this.luSpecies.StyleController = this.layoutControl1;
            this.luSpecies.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.성별,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(729, 385);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.luAnimalshelter;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(608, 28);
            this.layoutControlItem1.Text = "       보호센터";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(92, 18);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 112);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(608, 253);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.luSpecies;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "보호센터";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(608, 28);
            this.layoutControlItem2.Text = "          축종";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(92, 18);
            // 
            // 성별
            // 
            this.성별.Control = this.luIsmale;
            this.성별.Location = new System.Drawing.Point(0, 56);
            this.성별.Name = "성별";
            this.성별.Size = new System.Drawing.Size(608, 28);
            this.성별.Text = "          성별";
            this.성별.TextSize = new System.Drawing.Size(92, 18);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dtaFindingReportDate;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(304, 28);
            this.layoutControlItem4.Text = "      찾은 날짜 ";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(92, 18);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.dtaLastestFindingReportDate;
            this.layoutControlItem5.Location = new System.Drawing.Point(304, 84);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(304, 28);
            this.layoutControlItem5.Text = "    마지막 날짜";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(92, 18);
            // 
            // sexBindingSource
            // 
            this.sexBindingSource.DataSource = typeof(AnimalShelterManagementSystem.Sex);
            // 
            // btnLoad
            // 
            this.btnLoad.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.btnLoad.Appearance.Options.UseFont = true;
            this.btnLoad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.ImageOptions.Image")));
            this.btnLoad.Location = new System.Drawing.Point(620, 12);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(97, 38);
            this.btnLoad.StyleController = this.layoutControl1;
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "검색";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // animalShelterBindingSource1
            // 
            this.animalShelterBindingSource1.DataSource = typeof(AnimalShelterManagementSystem.AnimalShelter);
            // 
            // speciesBindingSource
            // 
            this.speciesBindingSource.DataSource = typeof(AnimalShelterManagementSystem.Species);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnLoad;
            this.layoutControlItem3.Location = new System.Drawing.Point(608, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(101, 365);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // homelessAnimalBindingSource
            // 
            this.homelessAnimalBindingSource.DataSource = typeof(AnimalShelterManagementSystem.HomelessAnimal);
            // 
            // animalShelterBindingSource
            // 
            this.animalShelterBindingSource.DataSource = typeof(AnimalShelterManagementSystem.AnimalShelter);
            // 
            // SearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SearchControl";
            this.Size = new System.Drawing.Size(733, 414);
            this.Load += new System.EventHandler(this.SearchControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtaLastestFindingReportDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaLastestFindingReportDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaFindingReportDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaFindingReportDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luIsmale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luAnimalshelter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luSpecies.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.성별)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalShelterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homelessAnimalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalShelterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LookUpEdit luAnimalshelter;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.LookUpEdit luSpecies;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.LookUpEdit luIsmale;
        private DevExpress.XtraLayout.LayoutControlItem 성별;
        private System.Windows.Forms.BindingSource animalShelterBindingSource;
        private System.Windows.Forms.BindingSource speciesBindingSource;
        private System.Windows.Forms.BindingSource homelessAnimalBindingSource;
        private DevExpress.XtraEditors.DateEdit dtaLastestFindingReportDate;
        private DevExpress.XtraEditors.DateEdit dtaFindingReportDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.DateTimeChartRangeControlClient dateTimeChartRangeControlClient1;
        private System.Windows.Forms.BindingSource sexBindingSource;
        private System.Windows.Forms.BindingSource animalShelterBindingSource1;
    }
}
