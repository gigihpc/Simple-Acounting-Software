namespace AccSoftView.DataMaster
{
    partial class FrmDaftarCustomer
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_data = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cb_filter = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.cmd_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnCetak = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_edit = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_save = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_data.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_filter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(751, 53);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "..::DAFTAR CUSTOMER::..";
            // 
            // panelControl1
            // 
            this.panelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 53);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(751, 75);
            this.panelControl1.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.groupControl1.Controls.Add(this.txt_data);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.cb_filter);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(354, 71);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Filter";
            // 
            // txt_data
            // 
            this.txt_data.Location = new System.Drawing.Point(178, 34);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(170, 20);
            this.txt_data.TabIndex = 2;
            this.txt_data.EditValueChanged += new System.EventHandler(this.txt_data_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(142, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Data :";
            // 
            // cb_filter
            // 
            this.cb_filter.EditValue = "--Pilih Filter--";
            this.cb_filter.Location = new System.Drawing.Point(10, 34);
            this.cb_filter.Name = "cb_filter";
            this.cb_filter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_filter.Properties.Items.AddRange(new object[] {
            "Kode Kustomer",
            "Nama Kustomer",
            "Key Person"});
            this.cb_filter.Size = new System.Drawing.Size(126, 20);
            this.cb_filter.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.panelControl2.Controls.Add(this.cmd_cancel);
            this.panelControl2.Controls.Add(this.btnCetak);
            this.panelControl2.Controls.Add(this.cmd_edit);
            this.panelControl2.Controls.Add(this.cmd_save);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(356, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(393, 71);
            this.panelControl2.TabIndex = 2;
            // 
            // cmd_cancel
            // 
            this.cmd_cancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmd_cancel.Image = global::AccSoftView.Properties.Resources.exit;
            this.cmd_cancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmd_cancel.Location = new System.Drawing.Point(295, 2);
            this.cmd_cancel.Name = "cmd_cancel";
            this.cmd_cancel.Size = new System.Drawing.Size(104, 67);
            this.cmd_cancel.TabIndex = 61;
            this.cmd_cancel.Text = "BATAL";
            this.cmd_cancel.Click += new System.EventHandler(this.cmd_cancel_Click);
            // 
            // btnCetak
            // 
            this.btnCetak.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCetak.Image = global::AccSoftView.Properties.Resources.print;
            this.btnCetak.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCetak.Location = new System.Drawing.Point(191, 2);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(104, 67);
            this.btnCetak.TabIndex = 60;
            this.btnCetak.Text = "CETAK";
            // 
            // cmd_edit
            // 
            this.cmd_edit.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmd_edit.Image = global::AccSoftView.Properties.Resources.edit;
            this.cmd_edit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmd_edit.Location = new System.Drawing.Point(87, 2);
            this.cmd_edit.Name = "cmd_edit";
            this.cmd_edit.Size = new System.Drawing.Size(104, 67);
            this.cmd_edit.TabIndex = 58;
            this.cmd_edit.Text = "UBAH";
            this.cmd_edit.Click += new System.EventHandler(this.cmd_edit_Click);
            // 
            // cmd_save
            // 
            this.cmd_save.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmd_save.Image = global::AccSoftView.Properties.Resources.simpan;
            this.cmd_save.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cmd_save.Location = new System.Drawing.Point(2, 2);
            this.cmd_save.Name = "cmd_save";
            this.cmd_save.Size = new System.Drawing.Size(85, 67);
            this.cmd_save.TabIndex = 57;
            this.cmd_save.Text = "TAMBAH";
            this.cmd_save.Click += new System.EventHandler(this.cmd_save_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(0, 128);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(751, 387);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // FrmDaftarCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 515);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmDaftarCustomer";
            this.Text = "FrmDaftarCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_data.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_filter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton btnCetak;
        private DevExpress.XtraEditors.SimpleButton cmd_cancel;
        private DevExpress.XtraEditors.SimpleButton cmd_edit;
        private DevExpress.XtraEditors.SimpleButton cmd_save;
        private DevExpress.XtraEditors.TextEdit txt_data;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cb_filter;
    }
}