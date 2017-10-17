using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using AccModelService;

namespace AccSoftView.DataMaster
{
    public partial class FrmDaftarSuplier : DevExpress.XtraEditors.XtraForm
    {
        private DataView _dvSuplier;

        public FrmDaftarSuplier()
        {
            InitializeComponent();
            _dvSuplier = DataManager.Instance.DsAccSoft.Tables["suplier"].DefaultView;
            gridControl1.DataSource = _dvSuplier;
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 0)
                _dvSuplier.RowFilter = "kode_suplier like '%" + textEdit1.Text + "%'";
            else if (cbFilter.SelectedIndex == 1)
                _dvSuplier.RowFilter = "nama_suplier like '%" + textEdit1.Text + "%'";
            else if (cbFilter.SelectedIndex == 2)
                _dvSuplier.RowFilter = "kota like '%" + textEdit1.Text + "%'";
            else if (cbFilter.SelectedIndex == 3)
                _dvSuplier.RowFilter = "key_person like '%" + textEdit1.Text + "%'";

        }

        private void cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_save_Click(object sender, EventArgs e)
        {
            RegistrasiSuplier frmRegSuplier = new RegistrasiSuplier();
            frmRegSuplier.ShowDialog();
        }

        private void cmd_edit_Click(object sender, EventArgs e)
        {
            RegistrasiSuplier frmRegSuplier = new RegistrasiSuplier();
            frmRegSuplier.SetKey(gridView1.GetFocusedRowCellValue("kode_suplier").ToString());
            frmRegSuplier.ShowDialog();
        }
    }
}