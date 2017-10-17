namespace AccSoftView.GeneralLedger
{
    partial class FrmKodePerkiraan
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cbKodeAkun = new System.Windows.Forms.ComboBox();
            this.cbNamaAkun = new System.Windows.Forms.ComboBox();
            this.cbStatusNR = new System.Windows.Forms.ComboBox();
            this.cbStatusDK = new System.Windows.Forms.ComboBox();
            this.cbHPP = new System.Windows.Forms.ComboBox();
            this.btnCetak = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_delete = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_edit = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_save = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(50, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kode Akun";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(47, 92);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nama Akun";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(41, 121);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Status (N/R)";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(42, 150);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Status (D/K)";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(55, 179);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(46, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "HPP (Y/T)";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl6.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl6.Location = new System.Drawing.Point(0, 0);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(300, 44);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "..:: KODE PERKIRAAN ::..";
            // 
            // cbKodeAkun
            // 
            this.cbKodeAkun.FormattingEnabled = true;
            this.cbKodeAkun.Location = new System.Drawing.Point(114, 60);
            this.cbKodeAkun.Name = "cbKodeAkun";
            this.cbKodeAkun.Size = new System.Drawing.Size(79, 21);
            this.cbKodeAkun.TabIndex = 52;
            this.cbKodeAkun.SelectedIndexChanged += new System.EventHandler(this.cbKodeAkun_SelectedIndexChanged);
            // 
            // cbNamaAkun
            // 
            this.cbNamaAkun.FormattingEnabled = true;
            this.cbNamaAkun.Location = new System.Drawing.Point(114, 89);
            this.cbNamaAkun.Name = "cbNamaAkun";
            this.cbNamaAkun.Size = new System.Drawing.Size(161, 21);
            this.cbNamaAkun.TabIndex = 53;
            // 
            // cbStatusNR
            // 
            this.cbStatusNR.FormattingEnabled = true;
            this.cbStatusNR.Items.AddRange(new object[] {
            "N",
            "R"});
            this.cbStatusNR.Location = new System.Drawing.Point(114, 118);
            this.cbStatusNR.Name = "cbStatusNR";
            this.cbStatusNR.Size = new System.Drawing.Size(121, 21);
            this.cbStatusNR.TabIndex = 54;
            // 
            // cbStatusDK
            // 
            this.cbStatusDK.FormattingEnabled = true;
            this.cbStatusDK.Items.AddRange(new object[] {
            "Debet",
            "Kredit"});
            this.cbStatusDK.Location = new System.Drawing.Point(114, 147);
            this.cbStatusDK.Name = "cbStatusDK";
            this.cbStatusDK.Size = new System.Drawing.Size(121, 21);
            this.cbStatusDK.TabIndex = 55;
            // 
            // cbHPP
            // 
            this.cbHPP.FormattingEnabled = true;
            this.cbHPP.Items.AddRange(new object[] {
            "Ya",
            "Tidak"});
            this.cbHPP.Location = new System.Drawing.Point(114, 176);
            this.cbHPP.Name = "cbHPP";
            this.cbHPP.Size = new System.Drawing.Size(121, 21);
            this.cbHPP.TabIndex = 56;
            // 
            // btnCetak
            // 
            this.btnCetak.Image = global::AccSoftView.Properties.Resources.print;
            this.btnCetak.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCetak.Location = new System.Drawing.Point(142, 231);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(104, 30);
            this.btnCetak.TabIndex = 50;
            this.btnCetak.Text = "CETAK";
            // 
            // cmd_cancel
            // 
            this.cmd_cancel.Image = global::AccSoftView.Properties.Resources.exit;
            this.cmd_cancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmd_cancel.Location = new System.Drawing.Point(142, 300);
            this.cmd_cancel.Name = "cmd_cancel";
            this.cmd_cancel.Size = new System.Drawing.Size(104, 30);
            this.cmd_cancel.TabIndex = 51;
            this.cmd_cancel.Text = "BATAL";
            this.cmd_cancel.Click += new System.EventHandler(this.cmd_cancel_Click);
            // 
            // cmd_delete
            // 
            this.cmd_delete.Image = global::AccSoftView.Properties.Resources.delete;
            this.cmd_delete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmd_delete.Location = new System.Drawing.Point(142, 265);
            this.cmd_delete.Name = "cmd_delete";
            this.cmd_delete.Size = new System.Drawing.Size(104, 29);
            this.cmd_delete.TabIndex = 49;
            this.cmd_delete.Text = "HAPUS";
            this.cmd_delete.Click += new System.EventHandler(this.cmd_delete_Click);
            // 
            // cmd_edit
            // 
            this.cmd_edit.Image = global::AccSoftView.Properties.Resources.edit;
            this.cmd_edit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmd_edit.Location = new System.Drawing.Point(23, 264);
            this.cmd_edit.Name = "cmd_edit";
            this.cmd_edit.Size = new System.Drawing.Size(104, 31);
            this.cmd_edit.TabIndex = 48;
            this.cmd_edit.Text = "UBAH";
            this.cmd_edit.Click += new System.EventHandler(this.cmd_edit_Click);
            // 
            // cmd_save
            // 
            this.cmd_save.Image = global::AccSoftView.Properties.Resources.simpan;
            this.cmd_save.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmd_save.Location = new System.Drawing.Point(23, 231);
            this.cmd_save.Name = "cmd_save";
            this.cmd_save.Size = new System.Drawing.Size(104, 29);
            this.cmd_save.TabIndex = 47;
            this.cmd_save.Text = "SIMPAN";
            this.cmd_save.Click += new System.EventHandler(this.cmd_save_Click);
            // 
            // FrmKodePerkiraan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 346);
            this.Controls.Add(this.cbHPP);
            this.Controls.Add(this.cbStatusDK);
            this.Controls.Add(this.cbStatusNR);
            this.Controls.Add(this.cbNamaAkun);
            this.Controls.Add(this.cbKodeAkun);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.cmd_cancel);
            this.Controls.Add(this.cmd_delete);
            this.Controls.Add(this.cmd_edit);
            this.Controls.Add(this.cmd_save);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmKodePerkiraan";
            this.Text = "FrmKodePerkiraan";
            this.Load += new System.EventHandler(this.FrmKodePerkiraan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnCetak;
        private DevExpress.XtraEditors.SimpleButton cmd_cancel;
        private DevExpress.XtraEditors.SimpleButton cmd_delete;
        private DevExpress.XtraEditors.SimpleButton cmd_edit;
        private DevExpress.XtraEditors.SimpleButton cmd_save;
        private System.Windows.Forms.ComboBox cbKodeAkun;
        private System.Windows.Forms.ComboBox cbNamaAkun;
        private System.Windows.Forms.ComboBox cbStatusNR;
        private System.Windows.Forms.ComboBox cbStatusDK;
        private System.Windows.Forms.ComboBox cbHPP;
    }
}