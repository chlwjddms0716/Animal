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
            this.btnAdoption = new DevExpress.XtraEditors.SimpleButton();
            this.btnShelter = new DevExpress.XtraEditors.SimpleButton();
            this.btnUser = new DevExpress.XtraEditors.SimpleButton();
            this.btnAnimal = new DevExpress.XtraEditors.SimpleButton();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // btnAdoption
            // 
            this.btnAdoption.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdoption.Appearance.Options.UseFont = true;
            this.btnAdoption.Location = new System.Drawing.Point(464, 303);
            this.btnAdoption.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdoption.Name = "btnAdoption";
            this.btnAdoption.Size = new System.Drawing.Size(308, 169);
            this.btnAdoption.TabIndex = 7;
            this.btnAdoption.Text = "입양 관리";
            this.btnAdoption.Click += new System.EventHandler(this.btnAdoption_Click);
            // 
            // btnShelter
            // 
            this.btnShelter.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShelter.Appearance.Options.UseFont = true;
            this.btnShelter.Location = new System.Drawing.Point(85, 303);
            this.btnShelter.Margin = new System.Windows.Forms.Padding(4);
            this.btnShelter.Name = "btnShelter";
            this.btnShelter.Size = new System.Drawing.Size(308, 169);
            this.btnShelter.TabIndex = 6;
            this.btnShelter.Text = "보호소 관리";
            this.btnShelter.Click += new System.EventHandler(this.btnShelter_Click);
            // 
            // btnUser
            // 
            this.btnUser.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Appearance.Options.UseFont = true;
            this.btnUser.Location = new System.Drawing.Point(464, 71);
            this.btnUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(308, 169);
            this.btnUser.TabIndex = 5;
            this.btnUser.Text = "유저 관리";
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnAnimal
            // 
            this.btnAnimal.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimal.Appearance.Options.UseFont = true;
            this.btnAnimal.Location = new System.Drawing.Point(85, 71);
            this.btnAnimal.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnimal.Name = "btnAnimal";
            this.btnAnimal.Size = new System.Drawing.Size(308, 169);
            this.btnAnimal.TabIndex = 4;
            this.btnAnimal.Text = "유기 동물 관리";
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 529);
            this.Controls.Add(this.btnAdoption);
            this.Controls.Add(this.btnShelter);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnAnimal);
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenu";
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