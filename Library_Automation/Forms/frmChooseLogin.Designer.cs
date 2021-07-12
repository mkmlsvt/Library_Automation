
namespace Library_Automation.Forms
{
    partial class frmChooseLogin
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
            this.btnPersonalGiris = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdminGiris = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPersonalGiris
            // 
            this.btnPersonalGiris.Appearance.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPersonalGiris.Appearance.Font = new System.Drawing.Font("MV Boli", 14.14F);
            this.btnPersonalGiris.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnPersonalGiris.Appearance.Options.UseBackColor = true;
            this.btnPersonalGiris.Appearance.Options.UseFont = true;
            this.btnPersonalGiris.Appearance.Options.UseForeColor = true;
            this.btnPersonalGiris.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPersonalGiris.Location = new System.Drawing.Point(386, 144);
            this.btnPersonalGiris.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnPersonalGiris.Name = "btnPersonalGiris";
            this.btnPersonalGiris.Size = new System.Drawing.Size(339, 297);
            this.btnPersonalGiris.TabIndex = 2;
            this.btnPersonalGiris.Text = "PERSONAL GIRIS";
            this.btnPersonalGiris.Click += new System.EventHandler(this.btnPersonalGiris_Click);
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.Appearance.BackColor = System.Drawing.Color.Khaki;
            this.btnAdminGiris.Appearance.Font = new System.Drawing.Font("MV Boli", 14.14F);
            this.btnAdminGiris.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnAdminGiris.Appearance.Options.UseBackColor = true;
            this.btnAdminGiris.Appearance.Options.UseFont = true;
            this.btnAdminGiris.Appearance.Options.UseForeColor = true;
            this.btnAdminGiris.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdminGiris.Location = new System.Drawing.Point(21, 144);
            this.btnAdminGiris.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(339, 297);
            this.btnAdminGiris.TabIndex = 3;
            this.btnAdminGiris.Text = "ADMIN GIRIS";
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click);
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = global::Library_Automation.Properties.Resources.contacts_50px;
            this.pictureEdit2.Location = new System.Drawing.Point(500, 38);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(119, 102);
            this.pictureEdit2.TabIndex = 5;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::Library_Automation.Properties.Resources.manager_50px;
            this.pictureEdit1.Location = new System.Drawing.Point(102, 38);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(161, 100);
            this.pictureEdit1.TabIndex = 4;
            // 
            // frmChooseLogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 469);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.btnAdminGiris);
            this.Controls.Add(this.btnPersonalGiris);
            this.IconOptions.LargeImage = global::Library_Automation.Properties.Resources.web_32x321;
            this.MaximumSize = new System.Drawing.Size(754, 508);
            this.MinimumSize = new System.Drawing.Size(754, 508);
            this.Name = "frmChooseLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GIRIS YONTEMI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnPersonalGiris;
        private DevExpress.XtraEditors.SimpleButton btnAdminGiris;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
    }
}