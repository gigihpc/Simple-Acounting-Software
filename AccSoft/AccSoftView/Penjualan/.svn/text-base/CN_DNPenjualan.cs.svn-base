using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using AccModelService;
using AccController;

namespace AccSoftView.Penjualan
{
    public partial class CN_DNPenjualan : DevExpress.XtraEditors.XtraForm,IView
    {
        private CnDnPenjualanModel _CDModel;
        private CnDnPenjualanControl _CDControl;
        private bool binding = false;

        public CN_DNPenjualan()
        {
            InitializeComponent();
            _CDModel = new CnDnPenjualanModel();
            _CDModel.Attach(this);
            _CDControl = new CnDnPenjualanControl(_CDModel);
        }

        public void BindingControl()
        {
            cb_nobukti.DataSource = DataManager.Instance.DsAccSoft.Tables["cndn_penjualan"];
            cb_nobukti.DisplayMember = "no_bukti";
            cb_nobukti.ValueMember = "no_bukti";
            cb_exfktr.DataSource = DataManager.Instance.DsAccSoft.Tables["penjualan"];
            cb_exfktr.DisplayMember = "no_bpb";
            cb_exfktr.ValueMember = "no_bpb";
            txt_jmlfktr.DataBindings.Add("text", DataManager.Instance.DsAccSoft, "penjualan.total_harga");
            date_fktr.DataBindings.Add("DateTime", DataManager.Instance.DsAccSoft, "penjualan.tgl_transaksi");
            cb_cust.DataSource = DataManager.Instance.DsAccSoft.Tables["customer"];
            cb_cust.DisplayMember = "nama_customer";
            cb_cust.ValueMember = "nama_customer";

            binding = true;
        }

        public void SetKey(String no_bukti)
        {
            _CDModel.NoBuktiKey = no_bukti;
        }

        public void SetDataModel()
        {
            _CDModel.NoBukti = cb_nobukti.Text;
            _CDModel.TglTransaksi = date_bukti.DateTime;
            _CDModel.ExFaktur = cb_exfktr.Text;
            _CDModel.JumCnDn = Convert.ToDouble(txt_jmlcn.Text);
            _CDModel.Ket = txt_ket.Text;
        }
 
        private void CN_DNPenjualan_Load(object sender, EventArgs e)
        {
            BindingControl();

            if (_CDModel.NoBuktiKey.CompareTo("") != 0)
                cb_nobukti.SelectedValue = (object)_CDModel.NoBuktiKey;
            else
                cb_nobukti.SelectedIndex = -1;
        }

        #region IView Members

        public void UpdateView()
        {
            date_bukti.DateTime = _CDModel.TglTransaksi;
            cb_exfktr.SelectedValue = (object)_CDModel.ExFaktur;
            txt_jmlcn.Text = _CDModel.JumCnDn.ToString();
            txt_ket.Text = _CDModel.Ket;
        }

        #endregion

        private void cmd_save_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_CDControl.Add());
        }

        private void cmd_edit_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_CDControl.Update());
        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_CDControl.Delete());
        }

        private void cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_nobukti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (binding)
            {
                _CDModel.NoBuktiKey = cb_nobukti.Text;
                _CDModel.Select();
            }
        }
    }
}