namespace AccSoftView.GeneralLedger
{
    partial class FrmKasBank
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
            this.cbNamaAkun = new System.Windows.Forms.ComboBox();
            this.cbKodeAkun = new System.Windows.Forms.ComboBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cbNoBukti = new System.Windows.Forms.ComboBox();
            this.dtTglTransaksi = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.btnCetak = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_delete = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_edit = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_save = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtTglTransaksi.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTglTransaksi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNamaAkun
            // 
            this.cbNamaAkun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNamaAkun.FormattingEnabled = true;
            this.cbNamaAkun.Location = new System.Drawing.Point(223, 225);
            this.cbNamaAkun.Name = "cbNamaAkun";
            this.cbNamaAkun.Size = new System.Drawing.Size(210, 24);
            this.cbNamaAkun.TabIndex = 69;
            // 
            // cbKodeAkun
            // 
            this.cbKodeAkun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKodeAkun.FormattingEnabled = true;
            this.cbKodeAkun.Location = new System.Drawing.Point(223, 197);
            this.cbKodeAkun.Name = "cbKodeAkun";
            this.cbKodeAkun.Size = new System.Drawing.Size(100, 24);
            this.cbKodeAkun.TabIndex = 68;
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
            this.labelControl6.Size = new System.Drawing.Size(462, 44);
            this.labelControl6.TabIndex = 62;
            this.labelControl6.Text = "..:: BUKTI KAS/BANK ::..";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(122, 321);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(69, 16);
            this.labelControl5.TabIndex = 61;
            this.labelControl5.Text = "Keterangan";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(95, 287);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(96, 16);
            this.labelControl3.TabIndex = 59;
            this.labelControl3.Text = "Jumlah Nominal";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(79, 229);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(112, 16);
            this.labelControl2.TabIndex = 58;
            this.labelControl2.Text = "Nama Akun Lawan";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(84, 200);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(107, 16);
            this.labelControl1.TabIndex = 57;
            this.labelControl1.Text = "Kode Akun Lawan";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bukti Kas Masuk (BKM)",
            "Bukti Kas Keluar (BKK)",
            "Bukti Bank Masuk (BBM)",
            "Bukti Bank Keluar (BBK)"});
            this.comboBox1.Location = new System.Drawing.Point(223, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 24);
            this.comboBox1.TabIndex = 74;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(99, 64);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(95, 16);
            this.labelControl7.TabIndex = 73;
            this.labelControl7.Text = "Jenis Transaksi";
            // 
            // cbNoBukti
            // 
            this.cbNoBukti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNoBukti.FormattingEnabled = true;
            this.cbNoBukti.Location = new System.Drawing.Point(223, 88);
            this.cbNoBukti.Name = "cbNoBukti";
            this.cbNoBukti.Size = new System.Drawing.Size(210, 24);
            this.cbNoBukti.TabIndex = 78;
            // 
            // dtTglTransaksi
            // 
            this.dtTglTransaksi.EditValue = new System.DateTime(2011, 11, 8, 11, 3, 58, 0);
            this.dtTglTransaksi.Location = new System.Drawing.Point(223, 115);
            this.dtTglTransaksi.Name = "dtTglTransaksi";
            this.dtTglTransaksi.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTglTransaksi.Properties.Appearance.Options.UseFont = true;
            this.dtTglTransaksi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTglTransaksi.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.dtTglTransaksi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtTglTransaksi.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtTglTransaksi.Size = new System.Drawing.Size(100, 22);
            this.dtTglTransaksi.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 76;
            this.label2.Text = "Tanggal";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 75;
            this.label1.Text = "No. Bukti/Cek";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(223, 142);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 80;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(70, 145);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(126, 16);
            this.labelControl8.TabIndex = 79;
            this.labelControl8.Text = "Kode Akun Kas/Bank";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(223, 284);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(210, 22);
            this.textEdit1.TabIndex = 81;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(224, 315);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Size = new System.Drawing.Size(209, 22);
            this.textEdit2.TabIndex = 82;
            // 
            // btnCetak
            // 
            this.btnCetak.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCetak.Appearance.Options.UseFont = true;
            this.btnCetak.Image = global::AccSoftView.Properties.Resources.print;
            this.btnCetak.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCetak.Location = new System.Drawing.Point(207, 382);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(104, 30);
            this.btnCetak.TabIndex = 66;
            this.btnCetak.Text = "CETAK";
            // 
            // cmd_cancel
            // 
            this.cmd_cancel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_cancel.Appearance.Options.UseFont = true;
            this.cmd_cancel.Image = global::AccSoftView.Properties.Resources.exit;
            this.cmd_cancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmd_cancel.Location = new System.Drawing.Point(329, 382);
            this.cmd_cancel.Name = "cmd_cancel";
            this.cmd_cancel.Size = new System.Drawing.Size(104, 30);
            this.cmd_cancel.TabIndex = 67;
            this.cmd_cancel.Text = "BATAL";
            // 
            // cmd_delete
            // 
            this.cmd_delete.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_delete.Appearance.Options.UseFont = true;
            this.cmd_delete.Image = global::AccSoftView.Properties.Resources.delete;
            this.cmd_delete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmd_delete.Location = new System.Drawing.Point(207, 419);
            this.cmd_delete.Name = "cmd_delete";
            this.cmd_delete.Size = new System.Drawing.Size(104, 29);
            this.cmd_delete.TabIndex = 65;
            this.cmd_delete.Text = "HAPUS";
            // 
            // cmd_edit
            // 
            this.cmd_edit.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_edit.Appearance.Options.UseFont = true;
            this.cmd_edit.Image = global::AccSoftView.Properties.Resources.edit;
            this.cmd_edit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmd_edit.Location = new System.Drawing.Point(84, 417);
            this.cmd_edit.Name = "cmd_edit";
            this.cmd_edit.Size = new System.Drawing.Size(104, 31);
            this.cmd_edit.TabIndex = 64;
            this.cmd_edit.Text = "UBAH";
            // 
            // cmd_save
            // 
            this.cmd_save.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_save.Appearance.Options.UseFont = true;
            this.cmd_save.Image = global::AccSoftView.Properties.Resources.simpan;
            this.cmd_save.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmd_save.Location = new System.Drawing.Point(84, 382);
            this.cmd_save.Name = "cmd_save";
            this.cmd_save.Size = new System.Drawing.Size(104, 29);
            this.cmd_save.TabIndex = 63;
            this.cmd_save.Text = "TAMBAH";
            // 
            // FrmKasBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 471);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.cbNoBukti);
            this.Controls.Add(this.dtTglTransaksi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.cbNamaAkun);
            this.Controls.Add(this.cbKodeAkun);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.cmd_cancel);
            this.Controls.Add(this.cmd_delete);
            this.Controls.Add(this.cmd_edit);
            this.Controls.Add(this.cmd_save);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmKasBank";
            this.Text = "frmKasBank";
            ((System.ComponentModel.ISupportInitialize)(this.dtTglTransaksi.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTglTransaksi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNamaAkun;
        private System.Windows.Forms.ComboBox cbKodeAkun;
        private DevExpress.XtraEditors.SimpleButton btnCetak;
        private DevExpress.XtraEditors.SimpleButton cmd_cancel;
        private DevExpress.XtraEditors.SimpleButton cmd_delete;
        private DevExpress.XtraEditors.SimpleButton cmd_edit;
        private DevExpress.XtraEditors.SimpleButton cmd_save;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.ComboBox cbNoBukti;
        private DevExpress.XtraEditors.DateEdit dtTglTransaksi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
    }
}