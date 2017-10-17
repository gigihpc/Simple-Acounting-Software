namespace AccSoftView.GeneralLedger
{
    partial class FrmSaldoAwal
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSaldoAwal = new DevExpress.XtraEditors.TextEdit();
            this.dtPeriode = new DevExpress.XtraEditors.DateEdit();
            this.cmd_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_save = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoAwal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPeriode.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPeriode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNamaAkun
            // 
            this.cbNamaAkun.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNamaAkun.FormattingEnabled = true;
            this.cbNamaAkun.Location = new System.Drawing.Point(98, 93);
            this.cbNamaAkun.Name = "cbNamaAkun";
            this.cbNamaAkun.Size = new System.Drawing.Size(121, 24);
            this.cbNamaAkun.TabIndex = 69;
            // 
            // cbKodeAkun
            // 
            this.cbKodeAkun.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKodeAkun.FormattingEnabled = true;
            this.cbKodeAkun.Location = new System.Drawing.Point(98, 64);
            this.cbKodeAkun.Name = "cbKodeAkun";
            this.cbKodeAkun.Size = new System.Drawing.Size(121, 24);
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
            this.labelControl6.Size = new System.Drawing.Size(265, 44);
            this.labelControl6.TabIndex = 62;
            this.labelControl6.Text = "..:: ATUR SALDO AWAL ::..";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(28, 154);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 16);
            this.labelControl4.TabIndex = 60;
            this.labelControl4.Text = "Saldo Awal";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(49, 125);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 16);
            this.labelControl3.TabIndex = 59;
            this.labelControl3.Text = "Periode";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(27, 96);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 16);
            this.labelControl2.TabIndex = 58;
            this.labelControl2.Text = "Nama Akun";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(32, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 16);
            this.labelControl1.TabIndex = 57;
            this.labelControl1.Text = "Kode Akun";
            // 
            // txtSaldoAwal
            // 
            this.txtSaldoAwal.Location = new System.Drawing.Point(98, 151);
            this.txtSaldoAwal.Name = "txtSaldoAwal";
            this.txtSaldoAwal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoAwal.Properties.Appearance.Options.UseFont = true;
            this.txtSaldoAwal.Size = new System.Drawing.Size(154, 22);
            this.txtSaldoAwal.TabIndex = 71;
            // 
            // dtPeriode
            // 
            this.dtPeriode.EditValue = new System.DateTime(2011, 12, 9, 0, 0, 0, 0);
            this.dtPeriode.Location = new System.Drawing.Point(98, 122);
            this.dtPeriode.Name = "dtPeriode";
            this.dtPeriode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPeriode.Properties.Appearance.Options.UseFont = true;
            this.dtPeriode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtPeriode.Properties.DisplayFormat.FormatString = "MMMM yyyy";
            this.dtPeriode.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtPeriode.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtPeriode.Size = new System.Drawing.Size(118, 22);
            this.dtPeriode.TabIndex = 72;
            // 
            // cmd_cancel
            // 
            this.cmd_cancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_cancel.Appearance.Options.UseFont = true;
            this.cmd_cancel.Image = global::AccSoftView.Properties.Resources.exit;
            this.cmd_cancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmd_cancel.Location = new System.Drawing.Point(148, 221);
            this.cmd_cancel.Name = "cmd_cancel";
            this.cmd_cancel.Size = new System.Drawing.Size(104, 30);
            this.cmd_cancel.TabIndex = 67;
            this.cmd_cancel.Text = "BATAL";
            // 
            // cmd_save
            // 
            this.cmd_save.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_save.Appearance.Options.UseFont = true;
            this.cmd_save.Image = global::AccSoftView.Properties.Resources.simpan;
            this.cmd_save.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmd_save.Location = new System.Drawing.Point(38, 221);
            this.cmd_save.Name = "cmd_save";
            this.cmd_save.Size = new System.Drawing.Size(104, 29);
            this.cmd_save.TabIndex = 63;
            this.cmd_save.Text = "SIMPAN";
            // 
            // FrmSaldoAwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 269);
            this.Controls.Add(this.dtPeriode);
            this.Controls.Add(this.txtSaldoAwal);
            this.Controls.Add(this.cbNamaAkun);
            this.Controls.Add(this.cbKodeAkun);
            this.Controls.Add(this.cmd_cancel);
            this.Controls.Add(this.cmd_save);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmSaldoAwal";
            this.Text = "FrmSaldoAwal";
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoAwal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPeriode.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPeriode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNamaAkun;
        private System.Windows.Forms.ComboBox cbKodeAkun;
        private DevExpress.XtraEditors.SimpleButton cmd_cancel;
        private DevExpress.XtraEditors.SimpleButton cmd_save;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSaldoAwal;
        private DevExpress.XtraEditors.DateEdit dtPeriode;

    }
}