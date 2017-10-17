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
    public partial class FrmDaftarCustomer : DevExpress.XtraEditors.XtraForm
    {
        private DataView _dfCustomer;
        private Reg_Customer _regCust;

        public FrmDaftarCustomer()
        {
            InitializeComponent();
            _dfCustomer = DataManager.Instance.DsAccSoft.Tables["customer"].DefaultView;
            gridControl1.DataSource = _dfCustomer;
        }

        private void txt_data_EditValueChanged(object sender, EventArgs e)
        {
            if (cb_filter.SelectedIndex == 0)
                _dfCustomer.RowFilter = "kode_customer like '%" + txt_data.Text + "%'";
            else if (cb_filter.SelectedIndex == 1)
                _dfCustomer.RowFilter = "nama_customer like '%" + txt_data.Text + "%'";
            else if (cb_filter.SelectedIndex == 2)
                _dfCustomer.RowFilter = "key_person like '%" + txt_data.Text + "%'";
        }

        private void cmd_save_Click(object sender, EventArgs e)
        {
            _regCust = new Reg_Customer();
            _regCust.ShowDialog();
        }

        private void cmd_edit_Click(object sender, EventArgs e)
        {
            _regCust = new Reg_Customer();
            _regCust.SetKey(gridView1.GetFocusedRowCellValue("kode_customer").ToString());
            _regCust.ShowDialog();
        }

        private void cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}