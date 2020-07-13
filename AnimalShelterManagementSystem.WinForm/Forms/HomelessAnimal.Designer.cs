namespace AnimalShelterManagementSystem.WinForm.Forms
{
    partial class HomelessAnimal
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
            this.lueSpecies = new DevExpress.XtraEditors.LookUpEdit();
            this.txeAge = new DevExpress.XtraEditors.TextEdit();
            this.txeHomelessAnimalId = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lueSpecies1 = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueSpecies.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeHomelessAnimalId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSpecies1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lueSpecies);
            this.layoutControl1.Controls.Add(this.txeAge);
            this.layoutControl1.Controls.Add(this.txeHomelessAnimalId);
            this.layoutControl1.Controls.Add(this.lueSpecies1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 450);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lueSpecies
            // 
            this.lueSpecies.Location = new System.Drawing.Point(76, 68);
            this.lueSpecies.Name = "lueSpecies";
            this.lueSpecies.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSpecies.Size = new System.Drawing.Size(712, 24);
            this.lueSpecies.StyleController = this.layoutControl1;
            this.lueSpecies.TabIndex = 8;
            // 
            // txeAge
            // 
            this.txeAge.Location = new System.Drawing.Point(76, 40);
            this.txeAge.Name = "txeAge";
            this.txeAge.Size = new System.Drawing.Size(712, 24);
            this.txeAge.StyleController = this.layoutControl1;
            this.txeAge.TabIndex = 6;
            // 
            // txeHomelessAnimalId
            // 
            this.txeHomelessAnimalId.Location = new System.Drawing.Point(43, 12);
            this.txeHomelessAnimalId.Name = "txeHomelessAnimalId";
            this.txeHomelessAnimalId.Size = new System.Drawing.Size(745, 24);
            this.txeHomelessAnimalId.StyleController = this.layoutControl1;
            this.txeHomelessAnimalId.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.OptionsItemText.TextToControlDistance = 2;
            this.Root.Size = new System.Drawing.Size(800, 450);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txeHomelessAnimalId;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 28);
            this.layoutControlItem1.Text = "ID :";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(26, 18);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 112);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(780, 318);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txeAge;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(780, 28);
            this.layoutControlItem3.Text = "나이 :";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(62, 18);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.lueSpecies;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(780, 28);
            this.layoutControlItem5.Text = "종 :";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(62, 18);
            // 
            // lueSpecies1
            // 
            this.lueSpecies1.Location = new System.Drawing.Point(76, 96);
            this.lueSpecies1.Name = "lueSpecies1";
            this.lueSpecies1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSpecies1.Size = new System.Drawing.Size(712, 24);
            this.lueSpecies1.StyleController = this.layoutControl1;
            this.lueSpecies1.TabIndex = 8;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lueSpecies1;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "실종장소 :";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(780, 28);
            this.layoutControlItem2.Text = "실종장소 :";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(62, 18);
            // 
            // HomelessAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layoutControl1);
            this.Name = "HomelessAnimal";
            this.Text = "HomelessAnimal";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueSpecies.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeHomelessAnimalId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSpecies1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txeHomelessAnimalId;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.TextEdit txeAge;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.LookUpEdit lueSpecies;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.LookUpEdit lueSpecies1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}