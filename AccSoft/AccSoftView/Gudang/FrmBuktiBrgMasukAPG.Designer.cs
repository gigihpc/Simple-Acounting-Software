namespace AccSoftView.Gudang
{
    partial class FrmBuktiBrgMasukAPG
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
            this.date_nobukti = new DevExpress.XtraEditors.DateEdit();
            this.txt_jenismutasi = new DevExpress.XtraEditors.TextEdit();
            this.txt_bagian = new DevExpress.XtraEditors.TextEdit();
            this.cb_noBukti = new System.Windows.Forms.ComboBox();
            this.cb_gudang = new System.Windows.Forms.ComboBox();
            this.btnCetak = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_delete = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_edit = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_save = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.date_nobukti.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_nobukti.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_jenismutasi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_bagian.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "No Bukti";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(32, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Tanggal";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(32, 97);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Jenis Mutasi";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(32, 129);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Gudang";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(32, 162);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Dari Bagian";
            // 
            // date_nobukti
            // 
            this.date_nobukti.EditValue = new System.DateTime(2011, 12, 15, 0, 0, 0, 0);
            this.date_nobukti.Location = new System.Drawing.Point(127, 62);
            this.date_nobukti.Name = "date_nobukti";
            this.date_nobukti.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_nobukti.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.date_nobukti.Size = new System.Drawing.Size(145, 20);
            this.date_nobukti.TabIndex = 1;
            // 
            // txt_jenismutasi
            // 
            this.txt_jenismutasi.Location = new System.Drawing.Point(127, 94);
            this.txt_jenismutasi.Name = "txt_jenismutasi";
            this.txt_jenismutasi.Size = new System.Drawing.Size(145, 20);
            this.txt_jenismutasi.TabIndex = 2;
            // 
            // txt_bagian
            // 
            this.txt_bagian.Location = new System.Drawing.Point(127, 159);
            this.txt_bagian.Name = "txt_bagian";
            this.txt_bagian.Size = new System.Drawing.Size(145, 20);
            this.txt_bagian.TabIndex = 2;
            // 
            // cb_noBukti
            // 
            this.cb_noBukti.FormattingEnabled = true;
            this.cb_noBukti.Location = new System.Drawing.Point(127, 32);
            this.cb_noBukti.Name = "cb_noBukti";
            this.cb_noBukti.Size = new System.Drawing.Size(145, 21);
            this.cb_noBukti.TabIndex = 3;
            this.cb_noBukti.SelectedIndexChanged += new System.EventHandler(this.cb_noBukti_SelectedIndexChanged);
            // 
            // cb_gudang
            // 
            this.cb_gudang.FormattingEnabled = true;
            this.cb_gudang.Location = new System.Drawing.Point(127, 126);
            this.cb_gudang.Name = "cb_gudang";
            this.cb_gudang.Size = new System.Drawing.Size(145, 21);
            this.cb_gudang.TabIndex = 3;
            // 
            // btnCetak
            // 
            this.btnCetak.Image = global::AccSoftView.Properties.Resources.print;
            this.btnCetak.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCetak.Location = new System.Drawing.Point(252, 207);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(104, 30);
            this.btnCetak.TabIndex = 50;
            this.btnCetak.Text = "CETAK";
            // 
            // cmd_cancel
            // 
            this.cmd_cancel.Image = global::AccSoftView.Properties.Resources.exit;
            this.cmd_cancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmd_cancel.Location = new System.Drawing.Point(209, 242);
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
            this.cmd_delete.Location = new System.Drawing.Point(88, 243);
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
            this.cmd_edit.Location = new System.Drawing.Point(142, 206);
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
            this.cmd_save.Location = new System.Drawing.Point(32, 208);
            this.cmd_save.Name = "cmd_save";
            this.cmd_save.Size = new System.Drawing.Size(104, 29);
            this.cmd_save.TabIndex = 47;
            this.cmd_save.Text = "SIMPAN";
            this.cmd_save.Click += new System.EventHandler(this.cmd_save_Click);
            // 
            // FrmBuktiBrgMasukAPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 329);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.cmd_cancel);
            this.Controls.Add(this.cmd_delete);
            this.Controls.Add(this.cmd_edit);
            this.Controls.Add(this.cmd_save);
            this.Controls.Add(this.cb_gudang);
            this.Controls.Add(this.cb_noBukti);
            this.Controls.Add(this.txt_bagian);
            this.Controls.Add(this.txt_jenismutasi);
            this.Controls.Add(this.date_nobukti);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmBuktiBrgMasukAPG";
            this.Text = "FrmBuktiBrgMasukAPG";
            this.Load += new System.EventHandler(this.FrmBuktiBrgMasukAPG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.date_nobukti.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_nobukti.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_jenismutasi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_bagian.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit date_nobukti;
        private DevExpress.XtraEditors.TextEdit txt_jenismutasi;
        private DevExpress.XtraEditors.TextEdit txt_bagian;
        private System.Windows.Forms.ComboBox cb_noBukti;
        private System.Windows.Forms.ComboBox cb_gudang;
        private DevExpress.XtraEditors.SimpleButton btnCetak;
        private DevExpress.XtraEditors.SimpleButton cmd_cancel;
        private DevExpress.XtraEditors.SimpleButton cmd_delete;
        private DevExpress.XtraEditors.SimpleButton cmd_edit;
        private DevExpress.XtraEditors.SimpleButton cmd_save;
    }
}