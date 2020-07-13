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
            this.components = new System.ComponentModel.Container();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.btnUser = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnAdoption = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnShelter = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnAnimal = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnFindReport = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnLossReport = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(207, 37);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(819, 620);
            this.fluentDesignFormContainer1.TabIndex = 0;
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
            this.btnUser,
            this.btnAdoption,
            this.btnShelter,
            this.btnAnimal,
            this.btnFindReport,
            this.btnLossReport});
            this.accordionControl1.Location = new System.Drawing.Point(0, 37);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(207, 620);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // btnUser
            // 
            this.btnUser.Name = "btnUser";
            this.btnUser.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnUser.Text = "유저 관리";
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnAdoption
            // 
            this.btnAdoption.Name = "btnAdoption";
            this.btnAdoption.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnAdoption.Text = "입양 관리";
            this.btnAdoption.Click += new System.EventHandler(this.btnAdoption_Click);
            // 
            // btnShelter
            // 
            this.btnShelter.Name = "btnShelter";
            this.btnShelter.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnShelter.Text = "보호소 관리";
            this.btnShelter.Click += new System.EventHandler(this.btnShelter_Click);
            // 
            // btnAnimal
            // 
            this.btnAnimal.Name = "btnAnimal";
            this.btnAnimal.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnAnimal.Text = "동물 관리";
            this.btnAnimal.Click += new System.EventHandler(this.btnAnimal_Click);
            // 
            // btnFindReport
            // 
            this.btnFindReport.Name = "btnFindReport";
            this.btnFindReport.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnFindReport.Text = "발견 신고 관리";
            this.btnFindReport.Click += new System.EventHandler(this.btnFindReport_Click);
            // 
            // btnLossReport
            // 
            this.btnLossReport.Name = "btnLossReport";
            this.btnLossReport.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnLossReport.Text = "분실 신고 관리";
            this.btnLossReport.Click += new System.EventHandler(this.btnLossReport_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1026, 37);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.DockingEnabled = false;
            this.fluentFormDefaultManager1.Form = this;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 657);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "AdminMenu";
            this.NavigationControl = this.accordionControl1;
            this.Text = "관리자메뉴";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnAdoption;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnShelter;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnAnimal;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnFindReport;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnUser;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnLossReport;
    }
}