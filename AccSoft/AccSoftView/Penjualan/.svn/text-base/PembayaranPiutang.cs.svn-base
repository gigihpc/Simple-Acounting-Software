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
    public partial class PembayaranPiutang : DevExpress.XtraEditors.XtraForm, IView
    {
        private PembayaranPiutangModel _piutangModel;
        private PembayaranPiutangControl _piutangControl;
        private DataView dvNoFaktur;
        private bool binding = false;

        public PembayaranPiutang()
        {
            InitializeComponent();
            _piutangModel = new PembayaranPiutangModel();
            _piutangModel.Attach(this);
            _piutangControl = new PembayaranPiutangControl(_piutangModel);
        }

        public void BindingControl()
        {
            cb_noBukti.DataSource = DataManager.Instance.DsAccSoft.Tables["pembayaran_piutang"];
            cb_noBukti.DisplayMember = "no_bukti";
            cb_noBukti.ValueMember = "no_bukti";
            dvNoFaktur = DataManager.Instance.DsAccSoft.Tables["penjualan"].DefaultView;
            dvNoFaktur.RowFilter = "status_tk='Tunai'";
            cbNoFaktur.DataSource = dvNoFaktur;
            cbNoFaktur.DisplayMember = "no_bpb";
            cbNoFaktur.ValueMember = "no_bpb";
            txt_uangmuka.DataBindings.Add("text", DataManager.Instance.DsAccSoft, "pembayaran_piutang.jumlah_pembayaran");
            txt_uraian.DataBindings.Add("text", DataManager.Instance.DsAccSoft, "pembayaran_piutang.uraian");
            date_nobukti.DataBindings.Add("DateTime", DataManager.Instance.DsAccSoft, "pembayaran_piutang.tgl_pembayaran");
            cb_cust.DataSource = DataManager.Instance.DsAccSoft.Tables["customer"];
            cb_cust.DisplayMember = "nama_customer";
            cb_cust.ValueMember = "kode_customer";

            binding = true;
        }

        public void SetKey(String no_bukti)
        {
            _piutangModel.NoBuktiKey = no_bukti;
        }

        public void SetDataModel()
        {
            _piutangModel.NoBukti = cb_noBukti.Text;
            _piutangModel.TglPembayaran = date_nobukti.DateTime;
            _piutangModel.NoFaktur = cbNoFaktur.Text;
            _piutangModel.JumPembayaran = Convert.ToDouble(txt_uangmuka.Text);
            _piutangModel.Uraian = txt_uraian.Text;
        }

        private void PembayaranPiutang_Load(object sender, EventArgs e)
        {
            BindingControl();

            if (_piutangModel.NoBuktiKey.CompareTo("") != 0)
                cb_noBukti.SelectedValue = (object)_piutangModel.NoBuktiKey;
            else
            {
                cb_noBukti.SelectedIndex = -1;
            }
        }



        #region IView Members

        public void UpdateView()
        {
            date_nobukti.DateTime = _piutangModel.TglPembayaran;
            cbNoFaktur.Text = _piutangModel.NoFaktur;
            txt_uangmuka.Text = _piutangModel.JumPembayaran.ToString();
            txt_uraian.Text = _piutangModel.Uraian;
            cb_cust.SelectedValue = (object)_piutangModel.KodeCustomer;
        }

        #endregion

        private void cb_noBukti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (binding)
            {
                _piutangModel.NoBuktiKey = cb_noBukti.Text;
                _piutangModel.Select();
            }
        }

        private void cmd_save_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_piutangControl.Add());
        }

        private void cmd_edit_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_piutangControl.Update());
        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_piutangControl.Delete());
        }

        private void cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_cust_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (binding)
                dvNoFaktur.RowFilter = "status_tk='Kredit' AND kode_customer='" + cb_cust.SelectedValue + "'";
        }
    }
}