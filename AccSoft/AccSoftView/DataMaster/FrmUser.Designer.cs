namespace AccSoftView.DataMaster
{
    partial class FrmUser
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
            this.txt_katakunci = new DevExpress.XtraEditors.TextEdit();
            this.txt_nmpengguna = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCetak = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_delete = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_edit = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_save = new DevExpress.XtraEditors.SimpleButton();
            this.txt_jabatan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cb_status = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cb_kodepengguna = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txt_katakunci.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nmpengguna.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_jabatan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_status.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_katakunci
            // 
            this.txt_katakunci.Location = new System.Drawing.Point(133, 83);
            this.txt_katakunci.Name = "txt_katakunci";
            this.txt_katakunci.Properties.PasswordChar = '*';
            this.txt_katakunci.Size = new System.Drawing.Size(134, 20);
            this.txt_katakunci.TabIndex = 67;
            // 
            // txt_nmpengguna
            // 
            this.txt_nmpengguna.Location = new System.Drawing.Point(133, 56);
            this.txt_nmpengguna.Name = "txt_nmpengguna";
            this.txt_nmpengguna.Size = new System.Drawing.Size(134, 20);
            this.txt_nmpengguna.TabIndex = 66;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(50, 90);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 64;
            this.labelControl3.Text = "Kata Kunci";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(50, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 13);
            this.labelControl2.TabIndex = 63;
            this.labelControl2.Text = "Nama Pengguna";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(50, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 13);
            this.labelControl1.TabIndex = 62;
            this.labelControl1.Text = "Kode Pengguna";
            // 
            // btnCetak
            // 
            this.btnCetak.Image = global::AccSoftView.Properties.Resources.print;
            this.btnCetak.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCetak.Location = new System.Drawing.Point(33, 222);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(104, 30);
            this.btnCetak.TabIndex = 71;
            this.btnCetak.Text = "CETAK";
            // 
            // cmd_cancel
            // 
            this.cmd_cancel.Image = global::AccSoftView.Properties.Resources.exit;
            this.cmd_cancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmd_cancel.Location = new System.Drawing.Point(253, 222);
            this.cmd_cancel.Name = "cmd_cancel";
            this.cmd_cancel.Size = new System.Drawing.Size(104, 30);
            this.cmd_cancel.TabIndex = 72;
            this.cmd_cancel.Text = "BATAL";
            this.cmd_cancel.Click += new System.EventHandler(this.cmd_cancel_Click);
            // 
            // cmd_delete
            // 
            this.cmd_delete.Image = global::AccSoftView.Properties.Resources.delete;
            this.cmd_delete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmd_delete.Location = new System.Drawing.Point(143, 222);
            this.cmd_delete.Name = "cmd_delete";
            this.cmd_delete.Size = new System.Drawing.Size(104, 29);
            this.cmd_delete.TabIndex = 70;
            this.cmd_delete.Text = "HAPUS";
            this.cmd_delete.Click += new System.EventHandler(this.cmd_delete_Click);
            // 
            // cmd_edit
            // 
            this.cmd_edit.Image = global::AccSoftView.Properties.Resources.edit;
            this.cmd_edit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmd_edit.Location = new System.Drawing.Point(192, 187);
            this.cmd_edit.Name = "cmd_edit";
            this.cmd_edit.Size = new System.Drawing.Size(104, 31);
            this.cmd_edit.TabIndex = 69;
            this.cmd_edit.Text = "UBAH";
            this.cmd_edit.Click += new System.EventHandler(this.cmd_edit_Click);
            // 
            // cmd_save
            // 
            this.cmd_save.Image = global::AccSoftView.Properties.Resources.simpan;
            this.cmd_save.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmd_save.Location = new System.Drawing.Point(82, 187);
            this.cmd_save.Name = "cmd_save";
            this.cmd_save.Size = new System.Drawing.Size(104, 29);
            this.cmd_save.TabIndex = 68;
            this.cmd_save.Text = "TAMBAH";
            this.cmd_save.Click += new System.EventHandler(this.cmd_save_Click);
            // 
            // txt_jabatan
            // 
            this.txt_jabatan.Location = new System.Drawing.Point(133, 116);
            this.txt_jabatan.Name = "txt_jabatan";
            this.txt_jabatan.Size = new System.Drawing.Size(134, 20);
            this.txt_jabatan.TabIndex = 75;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(50, 150);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 13);
            this.labelControl4.TabIndex = 74;
            this.labelControl4.Text = "Status";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(50, 119);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 13);
            this.labelControl5.TabIndex = 73;
            this.labelControl5.Text = "Jabatan";
            // 
            // cb_status
            // 
            this.cb_status.Location = new System.Drawing.Point(133, 143);
            this.cb_status.Name = "cb_status";
            this.cb_status.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_status.Properties.Items.AddRange(new object[] {
            "Manajer",
            "Admin",
            "Gudang"});
            this.cb_status.Size = new System.Drawing.Size(134, 20);
            this.cb_status.TabIndex = 76;
            this.cb_status.SelectedIndexChanged += new System.EventHandler(this.cb_status_SelectedIndexChanged);
            // 
            // cb_kodepengguna
            // 
            this.cb_kodepengguna.FormattingEnabled = true;
            this.cb_kodepengguna.Location = new System.Drawing.Point(133, 27);
            this.cb_kodepengguna.Name = "cb_kodepengguna";
            this.cb_kodepengguna.Size = new System.Drawing.Size(134, 21);
            this.cb_kodepengguna.TabIndex = 77;
            this.cb_kodepengguna.SelectedIndexChanged += new System.EventHandler(this.cb_kodepengguna_SelectedIndexChanged);
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 279);
            this.Controls.Add(this.cb_kodepengguna);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.txt_jabatan);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.cmd_cancel);
            this.Controls.Add(this.cmd_delete);
            this.Controls.Add(this.cmd_edit);
            this.Controls.Add(this.cmd_save);
            this.Controls.Add(this.txt_katakunci);
            this.Controls.Add(this.txt_nmpengguna);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmUser";
            this.Text = "FrmUser";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_katakunci.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nmpengguna.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_jabatan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_status.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCetak;
        private DevExpress.XtraEditors.SimpleButton cmd_cancel;
        private DevExpress.XtraEditors.SimpleButton cmd_delete;
        private DevExpress.XtraEditors.SimpleButton cmd_edit;
        private DevExpress.XtraEditors.SimpleButton cmd_save;
        private DevExpress.XtraEditors.TextEdit txt_katakunci;
        private DevExpress.XtraEditors.TextEdit txt_nmpengguna;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_jabatan;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cb_status;
        private System.Windows.Forms.ComboBox cb_kodepengguna;
    }
}