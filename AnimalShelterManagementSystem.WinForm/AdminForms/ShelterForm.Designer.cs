﻿namespace AnimalShelterManagementSystem.WinForm.AdminForms
{
    partial class ShelterForm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txeShelterId = new DevExpress.XtraEditors.TextEdit();
            this.txeAddress = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.txeName = new DevExpress.XtraEditors.TextEdit();
            this.txePhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txeManager = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txeShelterId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txePhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeManager.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txeShelterId);
            this.layoutControl1.Controls.Add(this.txeAddress);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.btnClose);
            this.layoutControl1.Controls.Add(this.txeName);
            this.layoutControl1.Controls.Add(this.txePhoneNumber);
            this.layoutControl1.Controls.Add(this.txeManager);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(494, 253);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txeShelterId
            // 
            this.txeShelterId.Cursor = System.Windows.Forms.Cursors.Default;
            this.txeShelterId.Location = new System.Drawing.Point(81, 12);
            this.txeShelterId.Name = "txeShelterId";
            this.txeShelterId.Size = new System.Drawing.Size(401, 24);
            this.txeShelterId.StyleController = this.layoutControl1;
            this.txeShelterId.TabIndex = 18;
            // 
            // txeAddress
            // 
            this.txeAddress.Location = new System.Drawing.Point(81, 68);
            this.txeAddress.Name = "txeAddress";
            this.txeAddress.Size = new System.Drawing.Size(401, 24);
            this.txeAddress.StyleController = this.layoutControl1;
            this.txeAddress.TabIndex = 15;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(249, 152);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(233, 34);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "추가";
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Location = new System.Drawing.Point(12, 152);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(233, 34);
            this.btnClose.StyleController = this.layoutControl1;
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "취소";
            // 
            // txeName
            // 
            this.txeName.Location = new System.Drawing.Point(81, 40);
            this.txeName.Name = "txeName";
            this.txeName.Size = new System.Drawing.Size(401, 24);
            this.txeName.StyleController = this.layoutControl1;
            this.txeName.TabIndex = 6;
            // 
            // txePhoneNumber
            // 
            this.txePhoneNumber.Location = new System.Drawing.Point(81, 96);
            this.txePhoneNumber.Name = "txePhoneNumber";
            this.txePhoneNumber.Size = new System.Drawing.Size(401, 24);
            this.txePhoneNumber.StyleController = this.layoutControl1;
            this.txePhoneNumber.TabIndex = 15;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem7,
            this.layoutControlItem11,
            this.layoutControlItem12,
            this.layoutControlItem8,
            this.layoutControlItem2,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.OptionsItemText.TextToControlDistance = 2;
            this.Root.Size = new System.Drawing.Size(494, 253);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 178);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(474, 55);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txeName;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(474, 28);
            this.layoutControlItem3.Text = "이름 :";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(67, 18);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnClose;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 140);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(237, 38);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.btnSave;
            this.layoutControlItem11.Location = new System.Drawing.Point(237, 140);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(237, 38);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.txeAddress;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(474, 28);
            this.layoutControlItem12.Text = "주소 :";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(67, 18);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txeShelterId;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(474, 28);
            this.layoutControlItem8.Text = "보호소Id :";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(67, 18);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txePhoneNumber;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "주소 :";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(474, 28);
            this.layoutControlItem2.Text = "전화번호 : ";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(67, 18);
            // 
            // txeManager
            // 
            this.txeManager.Location = new System.Drawing.Point(81, 124);
            this.txeManager.Name = "txeManager";
            this.txeManager.Size = new System.Drawing.Size(401, 24);
            this.txeManager.StyleController = this.layoutControl1;
            this.txeManager.TabIndex = 15;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txeManager;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem1.CustomizationFormText = "주소 :";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 112);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(474, 28);
            this.layoutControlItem1.Text = "담당자 :";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(67, 18);
            // 
            // ShelterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 253);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ShelterForm";
            this.Text = "보호소관리";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txeShelterId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txePhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeManager.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txeShelterId;
        private DevExpress.XtraEditors.TextEdit txeAddress;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.TextEdit txeName;
        private DevExpress.XtraEditors.TextEdit txePhoneNumber;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit txeManager;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}