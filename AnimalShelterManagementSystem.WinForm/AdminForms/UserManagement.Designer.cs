namespace AnimalShelterManagementSystem.WinForm.AdminForms
{
    partial class UserManagement
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
            this.grvUserList = new System.Windows.Forms.DataGridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.rdgAdmin = new DevExpress.XtraEditors.RadioGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.rdgSex1 = new DevExpress.XtraEditors.RadioGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbUserName = new DevExpress.XtraLayout.LayoutControlItem();
            this.txbId = new System.Windows.Forms.TextBox();
            this.txbUserId = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgAdmin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgSex1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbUserId)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.grvUserList);
            this.layoutControl1.Controls.Add(this.rdgAdmin);
            this.layoutControl1.Controls.Add(this.rdgSex1);
            this.layoutControl1.Controls.Add(this.txbName);
            this.layoutControl1.Controls.Add(this.txbId);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 450);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // grvUserList
            // 
            this.grvUserList.AllowUserToAddRows = false;
            this.grvUserList.AllowUserToDeleteRows = false;
            this.grvUserList.AllowUserToOrderColumns = true;
            this.grvUserList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvUserList.Location = new System.Drawing.Point(82, 174);
            this.grvUserList.Name = "grvUserList";
            this.grvUserList.ReadOnly = true;
            this.grvUserList.RowHeadersWidth = 51;
            this.grvUserList.RowTemplate.Height = 27;
            this.grvUserList.Size = new System.Drawing.Size(706, 264);
            this.grvUserList.TabIndex = 10;
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
            this.txbUserId});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 450);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.grvUserList;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "l";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 162);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(780, 268);
            this.layoutControlItem2.Text = "리스트";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(67, 18);
            // 
            // rdgAdmin
            // 
            this.rdgAdmin.EditValue = 0;
            this.rdgAdmin.Location = new System.Drawing.Point(82, 70);
            this.rdgAdmin.Name = "rdgAdmin";
            this.rdgAdmin.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "전체"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "관리자"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "일반 유저")});
            this.rdgAdmin.Size = new System.Drawing.Size(706, 48);
            this.rdgAdmin.StyleController = this.layoutControl1;
            this.rdgAdmin.TabIndex = 11;
            this.rdgAdmin.SelectedIndexChanged += new System.EventHandler(this.rdgAdmin_SelectedIndexChanged);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.rdgAdmin;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "성별";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 58);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(780, 52);
            this.layoutControlItem3.Text = "성별";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(67, 18);
            // 
            // rdgSex1
            // 
            this.rdgSex1.EditValue = 0;
            this.rdgSex1.Location = new System.Drawing.Point(82, 122);
            this.rdgSex1.Name = "rdgSex1";
            this.rdgSex1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "전체"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "블랙 유저"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "일반 유저")});
            this.rdgSex1.Size = new System.Drawing.Size(706, 48);
            this.rdgSex1.StyleController = this.layoutControl1;
            this.rdgSex1.TabIndex = 11;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.rdgSex1;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem1.CustomizationFormText = "성별";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 110);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 52);
            this.layoutControlItem1.Text = "성별";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(67, 18);
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(82, 12);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(706, 25);
            this.txbName.TabIndex = 6;
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
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(82, 41);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(706, 25);
            this.txbId.TabIndex = 6;
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
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layoutControl1);
            this.Name = "UserManagement";
            this.Text = "UserManagement";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgAdmin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgSex1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbUserId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.DataGridView grvUserList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.RadioGroup rdgAdmin;
        private DevExpress.XtraEditors.RadioGroup rdgSex1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbId;
        private DevExpress.XtraLayout.LayoutControlItem txbUserName;
        private DevExpress.XtraLayout.LayoutControlItem txbUserId;
    }
}