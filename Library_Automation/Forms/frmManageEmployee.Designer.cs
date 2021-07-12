
namespace Library_Automation.Forms
{
    partial class frmManageEmployee
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnInfo = new DevExpress.XtraEditors.SimpleButton();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.txtYas = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbCinsiyet = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtParola = new DevExpress.XtraEditors.TextEdit();
            this.txtDuzenlencekId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYas.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCinsiyet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuzenlencekId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(10);
            this.gridControl1.Location = new System.Drawing.Point(503, 14);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(10);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(882, 398);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 852;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // btnEkle
            // 
            this.btnEkle.Appearance.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnEkle.Appearance.Font = new System.Drawing.Font("MV Boli", 10.1F);
            this.btnEkle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnEkle.Appearance.Options.UseBackColor = true;
            this.btnEkle.Appearance.Options.UseFont = true;
            this.btnEkle.Appearance.Options.UseForeColor = true;
            this.btnEkle.Location = new System.Drawing.Point(31, 436);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(10);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(138, 43);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Appearance.BackColor = System.Drawing.Color.Khaki;
            this.btnDuzenle.Appearance.Font = new System.Drawing.Font("MV Boli", 10.1F);
            this.btnDuzenle.Appearance.Options.UseBackColor = true;
            this.btnDuzenle.Appearance.Options.UseFont = true;
            this.btnDuzenle.Location = new System.Drawing.Point(503, 437);
            this.btnDuzenle.Margin = new System.Windows.Forms.Padding(12);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(169, 41);
            this.btnDuzenle.TabIndex = 2;
            this.btnDuzenle.Text = "DUZENLE";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.BackColor = System.Drawing.Color.Crimson;
            this.btnSil.Appearance.Font = new System.Drawing.Font("MV Boli", 10.1F);
            this.btnSil.Appearance.Options.UseBackColor = true;
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.Location = new System.Drawing.Point(1261, 430);
            this.btnSil.Margin = new System.Windows.Forms.Padding(12);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(124, 48);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "SIL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Appearance.BackColor = System.Drawing.Color.Chartreuse;
            this.btnInfo.Appearance.Font = new System.Drawing.Font("MV Boli", 10.1F);
            this.btnInfo.Appearance.Options.UseBackColor = true;
            this.btnInfo.Appearance.Options.UseFont = true;
            this.btnInfo.ImageOptions.Image = global::Library_Automation.Properties.Resources.info_32x32;
            this.btnInfo.Location = new System.Drawing.Point(841, 433);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(10);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(266, 48);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.Text = "YARDIM ICIN TIKLAYIN";
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(220, 21);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Properties.Appearance.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtAd.Properties.Appearance.Options.UseBackColor = true;
            this.txtAd.Size = new System.Drawing.Size(156, 23);
            this.txtAd.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(220, 175);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.Appearance.BackColor = System.Drawing.Color.Khaki;
            this.txtUsername.Properties.Appearance.Options.UseBackColor = true;
            this.txtUsername.Size = new System.Drawing.Size(156, 23);
            this.txtUsername.TabIndex = 6;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(220, 73);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Properties.Appearance.BackColor = System.Drawing.Color.Khaki;
            this.txtSoyad.Properties.Appearance.Options.UseBackColor = true;
            this.txtSoyad.Size = new System.Drawing.Size(156, 23);
            this.txtSoyad.TabIndex = 8;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(220, 125);
            this.txtYas.Margin = new System.Windows.Forms.Padding(5);
            this.txtYas.Name = "txtYas";
            this.txtYas.Properties.Appearance.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtYas.Properties.Appearance.Options.UseBackColor = true;
            this.txtYas.Properties.BeepOnError = false;
            this.txtYas.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtYas.Properties.MaskSettings.Set("mask", "999");
            this.txtYas.Size = new System.Drawing.Size(156, 23);
            this.txtYas.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelControl9);
            this.panel1.Controls.Add(this.labelControl8);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.cmbCinsiyet);
            this.panel1.Controls.Add(this.txtParola);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.txtYas);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 398);
            this.panel1.TabIndex = 10;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("MV Boli", 10.1F);
            this.labelControl9.Appearance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(44, 300);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(80, 22);
            this.labelControl9.TabIndex = 20;
            this.labelControl9.Text = "CINSIYET";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("MV Boli", 10.1F);
            this.labelControl8.Appearance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(44, 71);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(59, 22);
            this.labelControl8.TabIndex = 19;
            this.labelControl8.Text = "SOYAD";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("MV Boli", 10.1F);
            this.labelControl5.Appearance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(44, 240);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(69, 22);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "PAROLA";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("MV Boli", 10.1F);
            this.labelControl4.Appearance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(44, 178);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(98, 22);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "USERNAME";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("MV Boli", 10.1F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(44, 123);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 22);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "YAS";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("MV Boli", 10.1F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(44, 19);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 22);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "AD";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.EditValue = "";
            this.cmbCinsiyet.Location = new System.Drawing.Point(220, 300);
            this.cmbCinsiyet.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Properties.Appearance.BackColor = System.Drawing.Color.Khaki;
            this.cmbCinsiyet.Properties.Appearance.Options.UseBackColor = true;
            this.cmbCinsiyet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCinsiyet.Properties.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbCinsiyet.Size = new System.Drawing.Size(156, 23);
            this.cmbCinsiyet.TabIndex = 11;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(220, 237);
            this.txtParola.Margin = new System.Windows.Forms.Padding(6);
            this.txtParola.Name = "txtParola";
            this.txtParola.Properties.Appearance.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtParola.Properties.Appearance.Options.UseBackColor = true;
            this.txtParola.Size = new System.Drawing.Size(156, 23);
            this.txtParola.TabIndex = 10;
            // 
            // txtDuzenlencekId
            // 
            this.txtDuzenlencekId.Enabled = false;
            this.txtDuzenlencekId.Location = new System.Drawing.Point(428, 452);
            this.txtDuzenlencekId.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuzenlencekId.Name = "txtDuzenlencekId";
            this.txtDuzenlencekId.Properties.Appearance.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtDuzenlencekId.Properties.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDuzenlencekId.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtDuzenlencekId.Properties.Appearance.Options.UseBackColor = true;
            this.txtDuzenlencekId.Properties.Appearance.Options.UseFont = true;
            this.txtDuzenlencekId.Properties.Appearance.Options.UseForeColor = true;
            this.txtDuzenlencekId.Size = new System.Drawing.Size(40, 36);
            this.txtDuzenlencekId.TabIndex = 21;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("MV Boli", 8.1F);
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(271, 453);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(134, 18);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "DUZENLENECEK ID";
            // 
            // frmManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1404, 502);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtDuzenlencekId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.gridControl1);
            this.MaximumSize = new System.Drawing.Size(1422, 549);
            this.MinimumSize = new System.Drawing.Size(1422, 549);
            this.Name = "frmManageEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMIN YONETIM SAYFASI";
            this.Load += new System.EventHandler(this.frmManageEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYas.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCinsiyet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuzenlencekId.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnInfo;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.TextEdit txtSoyad;
        private DevExpress.XtraEditors.TextEdit txtYas;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCinsiyet;
        private DevExpress.XtraEditors.TextEdit txtParola;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtDuzenlencekId;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}