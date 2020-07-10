namespace AnimalShelterManagementSystem.WinForm.AdminForms
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.btnAdoption = new DevExpress.XtraEditors.SimpleButton();
            this.btnShelter = new DevExpress.XtraEditors.SimpleButton();
            this.btnUser = new DevExpress.XtraEditors.SimpleButton();
            this.btnAnimal = new DevExpress.XtraEditors.SimpleButton();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // imageSlider1
            // 
            this.imageSlider1.AnimationTime = 1000;
            this.imageSlider1.CurrentImageIndex = 0;
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images"))));
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images1"))));
            this.imageSlider1.Location = new System.Drawing.Point(793, 5);
            this.imageSlider1.Name = "imageSlider1";
            this.imageSlider1.Size = new System.Drawing.Size(467, 561);
            this.imageSlider1.TabIndex = 8;
            this.imageSlider1.Text = "imageSlider1";
            // 
            // btnAdoption
            // 
            this.btnAdoption.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdoption.Appearance.Options.UseFont = true;
            this.btnAdoption.ImageOptions.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.handshake;
            this.btnAdoption.Location = new System.Drawing.Point(420, 300);
            this.btnAdoption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdoption.Name = "btnAdoption";
            this.btnAdoption.Size = new System.Drawing.Size(356, 230);
            this.btnAdoption.TabIndex = 7;
            this.btnAdoption.Text = "입양 관리";
            this.btnAdoption.Click += new System.EventHandler(this.btnAdoption_Click);
            // 
            // btnShelter
            // 
            this.btnShelter.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShelter.Appearance.Options.UseFont = true;
            this.btnShelter.ImageOptions.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.shelter;
            this.btnShelter.Location = new System.Drawing.Point(41, 300);
            this.btnShelter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShelter.Name = "btnShelter";
            this.btnShelter.Size = new System.Drawing.Size(356, 230);
            this.btnShelter.TabIndex = 6;
            this.btnShelter.Text = "보호소 관리";
            this.btnShelter.Click += new System.EventHandler(this.btnShelter_Click);
            // 
            // btnUser
            // 
            this.btnUser.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Appearance.Options.UseFont = true;
            this.btnUser.ImageOptions.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.User;
            this.btnUser.Location = new System.Drawing.Point(420, 48);
            this.btnUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(356, 230);
            this.btnUser.TabIndex = 5;
            this.btnUser.Text = "유저 관리";
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnAnimal
            // 
            this.btnAnimal.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimal.Appearance.Options.UseFont = true;
            this.btnAnimal.ImageOptions.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.dddoogg;
            this.btnAnimal.Location = new System.Drawing.Point(41, 48);
            this.btnAnimal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnimal.Name = "btnAnimal";
            this.btnAnimal.Size = new System.Drawing.Size(356, 230);
            this.btnAnimal.TabIndex = 4;
            this.btnAnimal.Text = "유기 동물 관리";
            this.btnAnimal.Click += new System.EventHandler(this.btnAnimal_Click);
            // 
            // btnFindReportManagement
            // 
            this.btnFindReportManagement.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindReportManagement.Appearance.Options.UseFont = true;
            this.btnFindReportManagement.ImageOptions.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.discovery;
            this.btnFindReportManagement.Location = new System.Drawing.Point(801, 48);
            this.btnFindReportManagement.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindReportManagement.Name = "btnFindReportManagement";
            this.btnFindReportManagement.Size = new System.Drawing.Size(356, 230);
            this.btnFindReportManagement.TabIndex = 9;
            this.btnFindReportManagement.Text = "발견 신고 관리";
            this.btnFindReportManagement.Click += new System.EventHandler(this.btnFindReportManagement_Click);
            // 
            // btnLossReportManagement
            // 
            this.btnLossReportManagement.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLossReportManagement.Appearance.Options.UseFont = true;
            this.btnLossReportManagement.ImageOptions.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.time;
            this.btnLossReportManagement.Location = new System.Drawing.Point(801, 300);
            this.btnLossReportManagement.Margin = new System.Windows.Forms.Padding(4);
            this.btnLossReportManagement.Name = "btnLossReportManagement";
            this.btnLossReportManagement.Size = new System.Drawing.Size(356, 230);
            this.btnLossReportManagement.TabIndex = 8;
            this.btnLossReportManagement.Text = "실종 신고 관리";
            this.btnLossReportManagement.Click += new System.EventHandler(this.btnLossReportManagement_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 571);
            this.Controls.Add(this.btnAdoption);
            this.Controls.Add(this.btnShelter);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnAnimal);
            this.IconOptions.Image = global::AnimalShelterManagementSystem.WinForm.Properties.Resources.BlackPuppy;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "관리자메뉴";
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAdoption;
        private DevExpress.XtraEditors.SimpleButton btnShelter;
        private DevExpress.XtraEditors.SimpleButton btnUser;
        private DevExpress.XtraEditors.SimpleButton btnAnimal;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}