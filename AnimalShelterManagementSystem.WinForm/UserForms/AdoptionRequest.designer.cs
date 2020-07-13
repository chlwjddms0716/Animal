namespace AnimalShelterManagementSystem.WinForm
{
    partial class AdoptionRequest
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.homelessAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSpeciesName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.건강상태 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.성별 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.이름 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.나이 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.특징 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.사진 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.cbxSpecies = new System.Windows.Forms.ComboBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.rdgSex = new DevExpress.XtraEditors.RadioGroup();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.종 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homelessAnimalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgSex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.종)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.lblSpecies);
            this.layoutControl1.Controls.Add(this.cbxSpecies);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.rdgSex);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(947, 130, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(730, 515);
            this.layoutControl1.TabIndex = 6;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.homelessAnimalBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 85);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(706, 382);
            this.gridControl1.TabIndex = 16;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // homelessAnimalBindingSource
            // 
            this.homelessAnimalBindingSource.DataSource = typeof(AnimalShelterManagementSystem.HomelessAnimal);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSpeciesName,
            this.건강상태,
            this.성별,
            this.이름,
            this.나이,
            this.특징,
            this.사진});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colSpeciesName
            // 
            this.colSpeciesName.Caption = "종";
            this.colSpeciesName.FieldName = "SpeciesName";
            this.colSpeciesName.MinWidth = 25;
            this.colSpeciesName.Name = "colSpeciesName";
            this.colSpeciesName.Visible = true;
            this.colSpeciesName.VisibleIndex = 0;
            this.colSpeciesName.Width = 94;
            // 
            // 건강상태
            // 
            this.건강상태.Caption = "건강상태";
            this.건강상태.FieldName = "PhysicalConditionName";
            this.건강상태.MinWidth = 25;
            this.건강상태.Name = "건강상태";
            this.건강상태.Visible = true;
            this.건강상태.VisibleIndex = 1;
            this.건강상태.Width = 94;
            // 
            // 성별
            // 
            this.성별.Caption = "성별";
            this.성별.FieldName = "GenderName";
            this.성별.MinWidth = 25;
            this.성별.Name = "성별";
            this.성별.Visible = true;
            this.성별.VisibleIndex = 2;
            this.성별.Width = 94;
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
            // 나이
            // 
            this.나이.Caption = "나이";
            this.나이.FieldName = "Age";
            this.나이.MinWidth = 25;
            this.나이.Name = "나이";
            this.나이.Visible = true;
            this.나이.VisibleIndex = 4;
            this.나이.Width = 94;
            // 
            // 특징
            // 
            this.특징.Caption = "특징";
            this.특징.FieldName = "Feature";
            this.특징.MinWidth = 25;
            this.특징.Name = "특징";
            this.특징.Visible = true;
            this.특징.VisibleIndex = 5;
            this.특징.Width = 94;
            // 
            // 사진
            // 
            this.사진.Caption = "사진";
            this.사진.FieldName = "PictureLink";
            this.사진.MinWidth = 25;
            this.사진.Name = "사진";
            this.사진.Visible = true;
            this.사진.VisibleIndex = 6;
            this.사진.Width = 94;
            // 
            // lblSpecies
            // 
            this.lblSpecies.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblSpecies.Location = new System.Drawing.Point(12, 12);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(45, 26);
            this.lblSpecies.TabIndex = 15;
            this.lblSpecies.Text = " 종 :      ";
            // 
            // cbxSpecies
            // 
            this.cbxSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSpecies.FormattingEnabled = true;
            this.cbxSpecies.Location = new System.Drawing.Point(61, 12);
            this.cbxSpecies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxSpecies.Name = "cbxSpecies";
            this.cbxSpecies.Size = new System.Drawing.Size(657, 26);
            this.cbxSpecies.TabIndex = 14;
            this.cbxSpecies.SelectedIndexChanged += new System.EventHandler(this.cbxSpecies_SelectedIndexChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(576, 471);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(142, 32);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = "입양 신청";
            this.simpleButton1.Click += new System.EventHandler(this.btnAdoptionRequest_Click);
            // 
            // rdgSex
            // 
            this.rdgSex.EditValue = 0;
            this.rdgSex.Location = new System.Drawing.Point(56, 42);
            this.rdgSex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdgSex.Name = "rdgSex";
            this.rdgSex.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "전체"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "수컷"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "암컷")});
            this.rdgSex.Size = new System.Drawing.Size(662, 39);
            this.rdgSex.StyleController = this.layoutControl1;
            this.rdgSex.TabIndex = 11;
            this.rdgSex.SelectedIndexChanged += new System.EventHandler(this.rdgSex_SelectedIndexChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.종,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(730, 515);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.simpleButton1;
            this.layoutControlItem6.Location = new System.Drawing.Point(564, 459);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(146, 36);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // 종
            // 
            this.종.Control = this.cbxSpecies;
            this.종.Location = new System.Drawing.Point(49, 0);
            this.종.Name = "종";
            this.종.Size = new System.Drawing.Size(661, 30);
            this.종.TextSize = new System.Drawing.Size(0, 0);
            this.종.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lblSpecies;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(49, 30);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.rdgSex;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "성별";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(710, 43);
            this.layoutControlItem3.Text = " 성별: ";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(41, 18);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 459);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(564, 36);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gridControl1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 73);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(710, 386);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PhysicalCondition";
            this.dataGridViewTextBoxColumn1.HeaderText = "PhysicalCondition";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Species";
            this.dataGridViewTextBoxColumn2.HeaderText = "Species";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PhysicalCondition";
            this.dataGridViewTextBoxColumn3.HeaderText = "PhysicalCondition";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // AdoptionRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(730, 515);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.BlackPuppy;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdoptionRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "입양신청";
            this.Load += new System.EventHandler(this.AdoptionRequest_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homelessAnimalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgSex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.종)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn featureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureLinkDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource homelessAnimalBindingSource;
        private System.Windows.Forms.ComboBox cbxSpecies;
        private DevExpress.XtraLayout.LayoutControlItem 종;
        private System.Windows.Forms.Label lblSpecies;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.RadioGroup rdgSex;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSpeciesName;
        private DevExpress.XtraGrid.Columns.GridColumn 건강상태;
        private DevExpress.XtraGrid.Columns.GridColumn 성별;
        private DevExpress.XtraGrid.Columns.GridColumn 이름;
        private DevExpress.XtraGrid.Columns.GridColumn 나이;
        private DevExpress.XtraGrid.Columns.GridColumn 특징;
        private DevExpress.XtraGrid.Columns.GridColumn 사진;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}