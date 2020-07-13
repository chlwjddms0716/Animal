namespace AnimalShelterManagementSystem.WinForm.AdminForms
{
    partial class AdminAnimalImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAnimalImage));
            this.imgAnimal = new DevExpress.XtraEditors.Controls.ImageSlider();
            ((System.ComponentModel.ISupportInitialize)(this.imgAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // imgAnimal
            // 
            this.imgAnimal.CurrentImageIndex = 0;
            this.imgAnimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgAnimal.Images.Add(((System.Drawing.Image)(resources.GetObject("imgAnimal.Images"))));
            this.imgAnimal.Images.Add(((System.Drawing.Image)(resources.GetObject("imgAnimal.Images1"))));
            this.imgAnimal.Location = new System.Drawing.Point(0, 0);
            this.imgAnimal.Name = "imgAnimal";
            this.imgAnimal.Size = new System.Drawing.Size(779, 492);
            this.imgAnimal.TabIndex = 0;
            this.imgAnimal.Text = "imageSlider1";
            // 
            // AnimalImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 492);
            this.Controls.Add(this.imgAnimal);
            this.Name = "AnimalImage";
            this.Text = "Animal";
            this.Load += new System.EventHandler(this.XtraForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgAnimal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Controls.ImageSlider imgAnimal;
    }
}