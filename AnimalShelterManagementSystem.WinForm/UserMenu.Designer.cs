namespace AnimalShelterManagementSystem.WinForm
{
    partial class UserMenu
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
            this.btnAdoption = new DevExpress.XtraEditors.SimpleButton();
            this.btnUserInfo = new DevExpress.XtraEditors.SimpleButton();
            this.btnLossReport = new DevExpress.XtraEditors.SimpleButton();
            this.btnFindReport = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnAdoption
            // 
            this.btnAdoption.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdoption.Appearance.Options.UseFont = true;
            this.btnAdoption.Location = new System.Drawing.Point(119, 83);
            this.btnAdoption.Name = "btnAdoption";
            this.btnAdoption.Size = new System.Drawing.Size(246, 135);
            this.btnAdoption.TabIndex = 0;
            this.btnAdoption.Text = "입양 신청";
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserInfo.Appearance.Options.UseFont = true;
            this.btnUserInfo.Location = new System.Drawing.Point(422, 83);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Size = new System.Drawing.Size(246, 135);
            this.btnUserInfo.TabIndex = 1;
            this.btnUserInfo.Text = "유저 정보 수정";
            // 
            // btnLossReport
            // 
            this.btnLossReport.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLossReport.Appearance.Options.UseFont = true;
            this.btnLossReport.Location = new System.Drawing.Point(119, 269);
            this.btnLossReport.Name = "btnLossReport";
            this.btnLossReport.Size = new System.Drawing.Size(246, 135);
            this.btnLossReport.TabIndex = 2;
            this.btnLossReport.Text = "실종 신고";
            // 
            // btnFindReport
            // 
            this.btnFindReport.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindReport.Appearance.Options.UseFont = true;
            this.btnFindReport.Location = new System.Drawing.Point(422, 269);
            this.btnFindReport.Name = "btnFindReport";
            this.btnFindReport.Size = new System.Drawing.Size(246, 135);
            this.btnFindReport.TabIndex = 3;
            this.btnFindReport.Text = "발견 신고";
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 486);
            this.Controls.Add(this.btnFindReport);
            this.Controls.Add(this.btnLossReport);
            this.Controls.Add(this.btnUserInfo);
            this.Controls.Add(this.btnAdoption);
            this.Name = "UserMenu";
            this.Text = "메뉴";
            this.Load += new System.EventHandler(this.UserMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAdoption;
        private DevExpress.XtraEditors.SimpleButton btnUserInfo;
        private DevExpress.XtraEditors.SimpleButton btnLossReport;
        private DevExpress.XtraEditors.SimpleButton btnFindReport;
    }
}