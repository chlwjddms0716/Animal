namespace AnimalShelterManagementSystem.WinForm.UserForms
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
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.btnAdoption = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnUserEdit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnFind = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnLoss = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.Font = new System.Drawing.Font("Tahoma", 13F);
            this.accordionControl1.Appearance.AccordionControl.Options.UseFont = true;
            this.accordionControl1.Appearance.Group.Normal.Font = new System.Drawing.Font("Tempus Sans ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Group.Normal.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Hovered.Font = new System.Drawing.Font("HCR Dotum", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.accordionControl1.Appearance.Item.Hovered.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Normal.Font = new System.Drawing.Font("HCR Dotum", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.accordionControl1.Appearance.Item.Normal.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Pressed.Font = new System.Drawing.Font("HCR Dotum", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.accordionControl1.Appearance.Item.Pressed.Options.UseFont = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnAdoption,
            this.btnUserEdit,
            this.btnFind,
            this.btnLoss});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(207, 573);
            this.accordionControl1.TabIndex = 3;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // btnAdoption
            // 
            this.btnAdoption.Name = "btnAdoption";
            this.btnAdoption.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnAdoption.Text = "입양 신청";
            this.btnAdoption.Click += new System.EventHandler(this.btnAdoption_Click);
            // 
            // btnUserEdit
            // 
            this.btnUserEdit.Name = "btnUserEdit";
            this.btnUserEdit.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnUserEdit.Text = "유저 정보 수정";
            this.btnUserEdit.Click += new System.EventHandler(this.btnUserEdit_Click);
            // 
            // btnFind
            // 
            this.btnFind.Name = "btnFind";
            this.btnFind.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnFind.Text = "발견 신고";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnLoss
            // 
            this.btnLoss.Name = "btnLoss";
            this.btnLoss.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnLoss.Text = "실종 신고";
            this.btnLoss.Click += new System.EventHandler(this.btnLoss_Click);
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 573);
            this.Controls.Add(this.accordionControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserMenu";
            this.Text = "사용자메뉴";
            this.Load += new System.EventHandler(this.UserMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnAdoption;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnUserEdit;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnFind;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnLoss;
    }
}