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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.grvHomelessAnimalList = new System.Windows.Forms.DataGridView();
            this.chbFemale = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lkuSpecies = new DevExpress.XtraEditors.LookUpEdit();
            this.speciesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.chbMale = new DevExpress.XtraEditors.CheckEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homelessAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PictureLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvHomelessAnimalList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbFemale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuSpecies.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbMale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homelessAnimalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.labelControl2);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.grvHomelessAnimalList);
            this.layoutControl1.Controls.Add(this.chbFemale);
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.lkuSpecies);
            this.layoutControl1.Controls.Add(this.chbMale);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(947, 130, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(757, 424);
            this.layoutControl1.TabIndex = 6;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 387);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(550, 18);
            this.labelControl2.StyleController = this.layoutControl1;
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "                                                                                 " +
    "                             ";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(564, 387);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(183, 27);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = "입양 신청";
            this.simpleButton1.Click += new System.EventHandler(this.btnAdoptionRequest_Click);
            // 
            // grvHomelessAnimalList
            // 
            this.grvHomelessAnimalList.AllowUserToAddRows = false;
            this.grvHomelessAnimalList.AllowUserToDeleteRows = false;
            this.grvHomelessAnimalList.AllowUserToOrderColumns = true;
            this.grvHomelessAnimalList.AutoGenerateColumns = false;
            this.grvHomelessAnimalList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvHomelessAnimalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvHomelessAnimalList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.speciesDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn6,
            this.PictureLink});
            this.grvHomelessAnimalList.DataSource = this.homelessAnimalBindingSource;
            this.grvHomelessAnimalList.Location = new System.Drawing.Point(60, 71);
            this.grvHomelessAnimalList.Name = "grvHomelessAnimalList";
            this.grvHomelessAnimalList.ReadOnly = true;
            this.grvHomelessAnimalList.RowHeadersWidth = 51;
            this.grvHomelessAnimalList.RowTemplate.Height = 27;
            this.grvHomelessAnimalList.Size = new System.Drawing.Size(687, 312);
            this.grvHomelessAnimalList.TabIndex = 10;
            this.grvHomelessAnimalList.DoubleClick += new System.EventHandler(this.grvHomelessAnimalList_DoubleClick);
            // 
            // chbFemale
            // 
            this.chbFemale.Location = new System.Drawing.Point(388, 45);
            this.chbFemale.Name = "chbFemale";
            this.chbFemale.Properties.Caption = "암컷";
            this.chbFemale.Size = new System.Drawing.Size(359, 22);
            this.chbFemale.StyleController = this.layoutControl1;
            this.chbFemale.TabIndex = 9;
            this.chbFemale.CheckedChanged += new System.EventHandler(this.chbFemale_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 18);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = " 성별    ";
            // 
            // lkuSpecies
            // 
            this.lkuSpecies.Location = new System.Drawing.Point(60, 10);
            this.lkuSpecies.Name = "lkuSpecies";
            this.lkuSpecies.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuSpecies.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", " ")});
            this.lkuSpecies.Properties.DataSource = this.speciesBindingSource3;
            this.lkuSpecies.Properties.DisplayMember = "Name";
            this.lkuSpecies.Properties.NullText = "입양하고 싶은 종을 선택해주세요";
            this.lkuSpecies.Properties.ValueMember = "Name";
            this.lkuSpecies.Size = new System.Drawing.Size(687, 24);
            this.lkuSpecies.StyleController = this.layoutControl1;
            this.lkuSpecies.TabIndex = 4;
            this.lkuSpecies.EditValueChanged += new System.EventHandler(this.lkuSpecies_EditValueChanged);
            // 
            // chbMale
            // 
            this.chbMale.Location = new System.Drawing.Point(65, 45);
            this.chbMale.Name = "chbMale";
            this.chbMale.Properties.Appearance.Options.UseImage = true;
            this.chbMale.Properties.Caption = "수컷";
            this.chbMale.Size = new System.Drawing.Size(319, 22);
            this.chbMale.StyleController = this.layoutControl1;
            this.chbMale.TabIndex = 9;
            this.chbMale.CheckedChanged += new System.EventHandler(this.chbMale_CheckedChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem2,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(757, 424);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lkuSpecies;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(100, 35);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(741, 35);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = " 종      ";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 18);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.labelControl1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 35);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(55, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.chbFemale;
            this.layoutControlItem3.Location = new System.Drawing.Point(378, 35);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(363, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.chbMale;
            this.layoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem5.Location = new System.Drawing.Point(55, 35);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(323, 26);
            this.layoutControlItem5.Text = "layoutControlItem3";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.grvHomelessAnimalList;
            this.layoutControlItem2.CustomizationFormText = "l";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 61);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(741, 316);
            this.layoutControlItem2.Text = "리스트";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 18);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.simpleButton1;
            this.layoutControlItem6.Location = new System.Drawing.Point(554, 377);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(187, 31);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.labelControl2;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 377);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(554, 31);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
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
            // homelessAnimalBindingSource
            // 
            this.homelessAnimalBindingSource.DataSource = typeof(AnimalShelterManagementSystem.HomelessAnimal);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn5.HeaderText = "Age";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // speciesDataGridViewTextBoxColumn
            // 
            this.speciesDataGridViewTextBoxColumn.DataPropertyName = "Species";
            this.speciesDataGridViewTextBoxColumn.HeaderText = "Species";
            this.speciesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.speciesDataGridViewTextBoxColumn.Name = "speciesDataGridViewTextBoxColumn";
            this.speciesDataGridViewTextBoxColumn.ReadOnly = true;
            this.speciesDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Feature";
            this.dataGridViewTextBoxColumn6.HeaderText = "Feature";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // PictureLink
            // 
            this.PictureLink.DataPropertyName = "PictureLink";
            this.PictureLink.HeaderText = "PictureLink";
            this.PictureLink.MinimumWidth = 6;
            this.PictureLink.Name = "PictureLink";
            this.PictureLink.ReadOnly = true;
            this.PictureLink.Width = 125;
            // 
            // AdoptionRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(757, 424);
            this.Controls.Add(this.layoutControl1);
            this.Name = "AdoptionRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "입양신청";
            this.Load += new System.EventHandler(this.AdoptionRequest_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvHomelessAnimalList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbFemale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuSpecies.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbMale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homelessAnimalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.CheckEdit chbFemale;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lkuSpecies;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.CheckEdit chbMale;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.DataGridView grvHomelessAnimalList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource speciesBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn featureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureLinkDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource homelessAnimalBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn PictureLink;
    }
}