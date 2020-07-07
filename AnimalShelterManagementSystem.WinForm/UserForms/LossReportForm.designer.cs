namespace AnimalShelterManagementSystem.WinForm
{
    partial class LossReportForm
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
            this.btnCancle = new DevExpress.XtraEditors.SimpleButton();
            this.btnLossRequest = new DevExpress.XtraEditors.SimpleButton();
            this.txbPictureLink = new System.Windows.Forms.TextBox();
            this.dteDate = new DevExpress.XtraEditors.DateEdit();
            this.txbPlace = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.lbPictureLink = new DevExpress.XtraEditors.LabelControl();
            this.lblPlace = new DevExpress.XtraEditors.LabelControl();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.lkuSpecies = new DevExpress.XtraEditors.LookUpEdit();
            this.speciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.locSpecies = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuSpecies.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locSpecies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnCancle);
            this.layoutControl1.Controls.Add(this.btnLossRequest);
            this.layoutControl1.Controls.Add(this.txbPictureLink);
            this.layoutControl1.Controls.Add(this.dteDate);
            this.layoutControl1.Controls.Add(this.txbPlace);
            this.layoutControl1.Controls.Add(this.tbxName);
            this.layoutControl1.Controls.Add(this.lblName);
            this.layoutControl1.Controls.Add(this.lbPictureLink);
            this.layoutControl1.Controls.Add(this.lblPlace);
            this.layoutControl1.Controls.Add(this.lblDate);
            this.layoutControl1.Controls.Add(this.lkuSpecies);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(545, 245);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(10, 208);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(260, 27);
            this.btnCancle.StyleController = this.layoutControl1;
            this.btnCancle.TabIndex = 17;
            this.btnCancle.Text = "취소";
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnLossRequest
            // 
            this.btnLossRequest.Location = new System.Drawing.Point(274, 208);
            this.btnLossRequest.Name = "btnLossRequest";
            this.btnLossRequest.Size = new System.Drawing.Size(261, 27);
            this.btnLossRequest.StyleController = this.layoutControl1;
            this.btnLossRequest.TabIndex = 16;
            this.btnLossRequest.Text = "확인";
            this.btnLossRequest.Click += new System.EventHandler(this.btnLossRequest_Click);
            // 
            // txbPictureLink
            // 
            this.txbPictureLink.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txbPictureLink.Location = new System.Drawing.Point(106, 132);
            this.txbPictureLink.Name = "txbPictureLink";
            this.txbPictureLink.Size = new System.Drawing.Size(429, 25);
            this.txbPictureLink.TabIndex = 15;
            this.txbPictureLink.Text = "사진링크를 입력해주세요.";
            // 
            // dteDate
            // 
            this.dteDate.EditValue = null;
            this.dteDate.Location = new System.Drawing.Point(107, 75);
            this.dteDate.Name = "dteDate";
            this.dteDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDate.Size = new System.Drawing.Size(428, 24);
            this.dteDate.StyleController = this.layoutControl1;
            this.dteDate.TabIndex = 14;
            // 
            // txbPlace
            // 
            this.txbPlace.Location = new System.Drawing.Point(107, 103);
            this.txbPlace.Name = "txbPlace";
            this.txbPlace.Size = new System.Drawing.Size(428, 25);
            this.txbPlace.TabIndex = 13;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(106, 10);
            this.tbxName.Name = "tbxName";
            this.tbxName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxName.Size = new System.Drawing.Size(429, 25);
            this.tbxName.TabIndex = 11;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(10, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 18);
            this.lblName.StyleController = this.layoutControl1;
            this.lblName.TabIndex = 10;
            this.lblName.Text = "동물 이름 :     ";
            // 
            // lbPictureLink
            // 
            this.lbPictureLink.Location = new System.Drawing.Point(10, 132);
            this.lbPictureLink.Name = "lbPictureLink";
            this.lbPictureLink.Size = new System.Drawing.Size(92, 18);
            this.lbPictureLink.StyleController = this.layoutControl1;
            this.lbPictureLink.TabIndex = 10;
            this.lbPictureLink.Text = "사진 링크 :     ";
            // 
            // lblPlace
            // 
            this.lblPlace.Location = new System.Drawing.Point(10, 103);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(93, 18);
            this.lblPlace.StyleController = this.layoutControl1;
            this.lblPlace.TabIndex = 10;
            this.lblPlace.Text = "잃어버린 장소 :";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(10, 75);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(93, 18);
            this.lblDate.StyleController = this.layoutControl1;
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "잃어버린 날짜 :";
            // 
            // lkuSpecies
            // 
            this.lkuSpecies.Location = new System.Drawing.Point(105, 39);
            this.lkuSpecies.Name = "lkuSpecies";
            this.lkuSpecies.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkuSpecies.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", " ")});
            this.lkuSpecies.Properties.DataSource = this.speciesBindingSource;
            this.lkuSpecies.Properties.DisplayMember = "Name";
            this.lkuSpecies.Properties.NullText = "잃어버린 동물의 종을 선택해주세요.";
            this.lkuSpecies.Properties.ValueMember = "Name";
            this.lkuSpecies.Size = new System.Drawing.Size(430, 24);
            this.lkuSpecies.StyleController = this.layoutControl1;
            this.lkuSpecies.TabIndex = 4;
            // 
            // speciesBindingSource
            // 

            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.locSpecies,
            this.layoutControlItem9,
            this.layoutControlItem8,
            this.layoutControlItem7,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem11});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(545, 245);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lblName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(96, 29);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 151);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(529, 47);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.tbxName;
            this.layoutControlItem4.Location = new System.Drawing.Point(96, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(433, 29);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // locSpecies
            // 
            this.locSpecies.Control = this.lkuSpecies;
            this.locSpecies.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.locSpecies.CustomizationFormText = " 종      ";
            this.locSpecies.Location = new System.Drawing.Point(0, 29);
            this.locSpecies.MinSize = new System.Drawing.Size(100, 35);
            this.locSpecies.Name = "locSpecies";
            this.locSpecies.Size = new System.Drawing.Size(529, 36);
            this.locSpecies.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.locSpecies.Text = " 종 :             ";
            this.locSpecies.TextSize = new System.Drawing.Size(93, 18);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.lblDate;
            this.layoutControlItem9.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem9.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 65);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(97, 28);
            this.layoutControlItem9.Text = "layoutControlItem1";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.lblPlace;
            this.layoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 93);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(97, 29);
            this.layoutControlItem8.Text = "layoutControlItem1";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.lbPictureLink;
            this.layoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 122);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(96, 29);
            this.layoutControlItem7.Text = "layoutControlItem1";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txbPlace;
            this.layoutControlItem5.Location = new System.Drawing.Point(97, 93);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(432, 29);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.dteDate;
            this.layoutControlItem6.Location = new System.Drawing.Point(97, 65);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(432, 28);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txbPictureLink;
            this.layoutControlItem2.Location = new System.Drawing.Point(96, 122);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(433, 29);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnLossRequest;
            this.layoutControlItem3.Location = new System.Drawing.Point(264, 198);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(265, 31);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.btnCancle;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 198);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(264, 31);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // LossReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 245);
            this.Controls.Add(this.layoutControl1);
            this.Name = "LossReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "실종신고";
            this.Load += new System.EventHandler(this.LossRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dteDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkuSpecies.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locSpecies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.TextBox tbxName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.LabelControl lbPictureLink;
        private DevExpress.XtraEditors.LabelControl lblPlace;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private System.Windows.Forms.TextBox txbPlace;
        private DevExpress.XtraEditors.LookUpEdit lkuSpecies;
        private DevExpress.XtraLayout.LayoutControlItem locSpecies;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton btnLossRequest;
        private System.Windows.Forms.TextBox txbPictureLink;
        private DevExpress.XtraEditors.DateEdit dteDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnCancle;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private System.Windows.Forms.BindingSource speciesBindingSource;
    }
}