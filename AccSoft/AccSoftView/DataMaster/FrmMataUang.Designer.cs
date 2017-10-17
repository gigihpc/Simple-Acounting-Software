namespace AccSoftView.DataMaster
{
    partial class FrmMataUang
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
            this.txt_kurs = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCetak = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_delete = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_edit = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_save = new DevExpress.XtraEditors.SimpleButton();
            this.cb_matauang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kurs.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_kurs
            // 
            this.txt_kurs.EditValue = "0";
            this.txt_kurs.Location = new System.Drawing.Point(116, 52);
            this.txt_kurs.Name = "txt_kurs";
            this.txt_kurs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_kurs.Size = new System.Drawing.Size(134, 20);
            this.txt_kurs.TabIndex = 66;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 13);
            this.labelControl2.TabIndex = 63;
            this.labelControl2.Text = "Kurs Terhadap IDR\r\n";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 62;
            this.labelControl1.Text = "Mata Uang";
            // 
            // btnCetak
            // 
            this.btnCetak.Image = global::AccSoftView.Properties.Resources.print;
            this.btnCetak.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCetak.Location = new System.Drawing.Point(5, 140);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(104, 30);
            this.btnCetak.TabIndex = 71;
            this.btnCetak.Text = "CETAK";
            // 
            // cmd_cancel
            // 
            this.cmd_cancel.Image = global::AccSoftView.Properties.Resources.exit;
            this.cmd_cancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmd_cancel.Location = new System.Drawing.Point(225, 140);
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
            this.cmd_delete.Location = new System.Drawing.Point(115, 140);
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
            this.cmd_edit.Location = new System.Drawing.Point(164, 105);
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
            this.cmd_save.Location = new System.Drawing.Point(54, 105);
            this.cmd_save.Name = "cmd_save";
            this.cmd_save.Size = new System.Drawing.Size(104, 29);
            this.cmd_save.TabIndex = 68;
            this.cmd_save.Text = "TAMBAH";
            this.cmd_save.Click += new System.EventHandler(this.cmd_save_Click);
            // 
            // cb_matauang
            // 
            this.cb_matauang.FormattingEnabled = true;
            this.cb_matauang.Location = new System.Drawing.Point(115, 24);
            this.cb_matauang.Name = "cb_matauang";
            this.cb_matauang.Size = new System.Drawing.Size(135, 21);
            this.cb_matauang.TabIndex = 73;
            this.cb_matauang.SelectedIndexChanged += new System.EventHandler(this.cb_matauang_SelectedIndexChanged);
            // 
            // FrmMataUang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 262);
            this.Controls.Add(this.cb_matauang);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.cmd_cancel);
            this.Controls.Add(this.cmd_delete);
            this.Controls.Add(this.cmd_edit);
            this.Controls.Add(this.cmd_save);
            this.Controls.Add(this.txt_kurs);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmMataUang";
            this.Text = "FrmMataUang";
            this.Load += new System.EventHandler(this.FrmMataUang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_kurs.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCetak;
        private DevExpress.XtraEditors.SimpleButton cmd_cancel;
        private DevExpress.XtraEditors.SimpleButton cmd_delete;
        private DevExpress.XtraEditors.SimpleButton cmd_edit;
        private DevExpress.XtraEditors.SimpleButton cmd_save;
        private DevExpress.XtraEditors.TextEdit txt_kurs;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cb_matauang;
    }
}