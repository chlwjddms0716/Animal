﻿namespace AnimalShelterManagementSystem.WinForm.AdminForms
{
    partial class AdoptionForm
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
            this.txeAnimalName = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.txeUserId = new DevExpress.XtraEditors.TextEdit();
            this.lkuAnimalId = new DevExpress.XtraEditors.LookUpEdit();
            this.rdgAdoptionStatus = new DevExpress.XtraEditors.RadioGroup();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.homelessAnimalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txeAnimalName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeUserId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuAnimalId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgAdoptionStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homelessAnimalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txeAnimalName);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.btnClose);
            this.layoutControl1.Controls.Add(this.txeUserId);
            this.layoutControl1.Controls.Add(this.lkuAnimalId);
            this.layoutControl1.Controls.Add(this.rdgAdoptionStatus);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(732, 0, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(351, 202);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txeAnimalName
            // 
            this.txeAnimalName.Location = new System.Drawing.Point(76, 40);
            this.txeAnimalName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txeAnimalName.Name = "txeAnimalName";
            this.txeAnimalName.Size = new System.Drawing.Size(263, 24);
            this.txeAnimalName.StyleController = this.layoutControl1;
            this.txeAnimalName.TabIndex = 15;
            this.txeAnimalName.EditValueChanged += new System.EventHandler(this.txeAnimalName_EditValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(255, 158);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 32);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "확인(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Location = new System.Drawing.Point(166, 158);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 32);
            this.btnClose.StyleController = this.layoutControl1;
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "취소(&C)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txeUserId
            // 
            this.txeUserId.Location = new System.Drawing.Point(76, 12);
            this.txeUserId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txeUserId.Name = "txeUserId";
            this.txeUserId.Size = new System.Drawing.Size(263, 24);
            this.txeUserId.StyleController = this.layoutControl1;
            this.txeUserId.TabIndex = 6;
            // 
            // lkuAnimalId
            // 
            this.lkuAnimalId.Location = new System.Drawing.Point(76, 68);
            this.lkuAnimalId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lkuAnimalId.Name = "lkuAnimalId";
            this.lkuAnimalId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuAnimalId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HomelessAnimalId", "")});
            this.lkuAnimalId.Properties.DataSource = this.homelessAnimalBindingSource;
            this.lkuAnimalId.Properties.DisplayMember = "HomelessAnimalId";
            this.lkuAnimalId.Properties.NullText = "";
            this.lkuAnimalId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lkuAnimalId.Properties.ValueMember = "HomelessAnimalId";
            this.lkuAnimalId.Size = new System.Drawing.Size(263, 24);
            this.lkuAnimalId.StyleController = this.layoutControl1;
            this.lkuAnimalId.TabIndex = 2;
            // 
            // rdgAdoptionStatus
            // 
            this.rdgAdoptionStatus.EditValue = 0;
            this.rdgAdoptionStatus.Location = new System.Drawing.Point(76, 96);
            this.rdgAdoptionStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdgAdoptionStatus.Name = "rdgAdoptionStatus";
            this.rdgAdoptionStatus.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "처리중"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "입양됨")});
            this.rdgAdoptionStatus.Size = new System.Drawing.Size(263, 30);
            this.rdgAdoptionStatus.StyleController = this.layoutControl1;
            this.rdgAdoptionStatus.TabIndex = 11;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem7,
            this.layoutControlItem11,
            this.layoutControlItem12,
            this.layoutControlItem4,
            this.layoutControlItem10,
            this.emptySpaceItem2,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.OptionsItemText.TextToControlDistance = 2;
            this.Root.Size = new System.Drawing.Size(351, 202);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txeUserId;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(331, 28);
            this.layoutControlItem3.Text = "유저Id :";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(62, 18);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnClose;
            this.layoutControlItem7.Location = new System.Drawing.Point(154, 146);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(89, 36);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.btnSave;
            this.layoutControlItem11.Location = new System.Drawing.Point(243, 146);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(88, 36);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.txeAnimalName;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(331, 28);
            this.layoutControlItem12.Text = "동물이름 :";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(62, 18);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.lkuAnimalId;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem4.CustomizationFormText = " 보호소 이름 :";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(331, 28);
            this.layoutControlItem4.Text = "동물Id :";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(62, 18);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.rdgAdoptionStatus;
            this.layoutControlItem10.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem10.CustomizationFormText = "블랙리스트";
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(331, 34);
            this.layoutControlItem10.Text = "입양상태: ";
            this.layoutControlItem10.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem10.TextSize = new System.Drawing.Size(62, 18);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 146);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(154, 36);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 118);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(331, 28);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // homelessAnimalBindingSource
            // 
            this.homelessAnimalBindingSource.DataSource = typeof(AnimalShelterManagementSystem.HomelessAnimal);
            // 
            // AdoptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 202);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.BlackPuppy;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdoptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "입양관리";
            this.Load += new System.EventHandler(this.AdoptionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txeAnimalName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeUserId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuAnimalId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgAdoptionStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homelessAnimalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txeAnimalName;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.TextEdit txeUserId;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraEditors.LookUpEdit lkuAnimalId;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.RadioGroup rdgAdoptionStatus;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private System.Windows.Forms.BindingSource homelessAnimalBindingSource;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}