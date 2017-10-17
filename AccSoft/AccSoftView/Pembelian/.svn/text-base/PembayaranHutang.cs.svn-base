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

namespace AccSoftView.Pembelian
{
    public partial class PembayaranHutang : DevExpress.XtraEditors.XtraForm, IView
    {
        private PembHutangModel _pembModel;
        private PembHutangControl _pembControl;
        private DataView dvNoFaktur;
        private bool binded = false;

        public PembayaranHutang()
        {
            InitializeComponent();
            _pembModel = new PembHutangModel();
            _pembModel.Attach(this);
            _pembControl = new PembHutangControl(_pembModel);
        }

        private void PembayaranHutang_Load(object sender, EventArgs e)
        {
            //Binding control with dataset here
            BindingControl();

            if (_pembModel.NoBuktiKey.CompareTo("") != 0)
                cbNoBukti.SelectedValue = (object)_pembModel.NoBuktiKey;
            else
            {
                cbNoBukti.SelectedIndex = -1;
            }
        }

        public void BindingControl()
        {
            cbNoBukti.DataSource = DataManager.Instance.DsAccSoft.Tables["pembayaran_hutang"];
            cbNoBukti.DisplayMember = "no_bukti";
            cbNoBukti.ValueMember = "no_bukti";
            dvNoFaktur = DataManager.Instance.DsAccSoft.Tables["pembelian"].DefaultView;
            dvNoFaktur.RowFilter = "status_tk='Kredit'";
            cbNoFaktur.DataSource = dvNoFaktur;
            cbNoFaktur.DisplayMember = "no_bpb";
            cbNoFaktur.ValueMember = "no_bpb";
            txtUangMuka.DataBindings.Add("text", DataManager.Instance.DsAccSoft, "pembayaran_hutang.jumlah_pembayaran");
            txtUraian.DataBindings.Add("text", DataManager.Instance.DsAccSoft, "pembayaran_hutang.uraian");
            dtTglTransaks.DataBindings.Add("DateTime", DataManager.Instance.DsAccSoft, "pembayaran_hutang.tgl_pembayaran");
            cbKodeSuplier.DataSource = DataManager.Instance.DsAccSoft.Tables["suplier"];
            cbKodeSuplier.DisplayMember = "kode_suplier";
            cbKodeSuplier.ValueMember = "kode_suplier";
            cbNamaSuplier.DataSource = DataManager.Instance.DsAccSoft.Tables["suplier"];
            cbNamaSuplier.DisplayMember = "nama_suplier";
            cbNamaSuplier.ValueMember = "nama_suplier";

            binded = true;
        }

        public void SetKey(String no_bukti)
        {
            _pembModel.NoBuktiKey = no_bukti;
        }

        public void SetDataModel()
        {
            _pembModel.NoBukti = cbNoBukti.Text;
            _pembModel.TglPembayaran = dtTglTransaks.DateTime;
            _pembModel.NoFaktur = cbNoFaktur.Text;
            _pembModel.JumPembayaran = Convert.ToDouble(txtUangMuka.Text);
            _pembModel.Uraian = txtUraian.Text;
        }

        #region IView Members

        public void UpdateView()
        {
            dtTglTransaks.DateTime = _pembModel.TglPembayaran;
            cbNoFaktur.Text = _pembModel.NoFaktur;
            txtUangMuka.Text = _pembModel.JumPembayaran.ToString();
            txtUraian.Text = _pembModel.Uraian;
            cbKodeSuplier.SelectedValue = (object)_pembModel.KodeSuplier;
        }

        #endregion

        private void cbNoBukti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (binded)
            {
                _pembModel.NoBuktiKey = cbNoBukti.Text;
                _pembModel.Select();
            }
        }

        private void cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_save_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_pembControl.Add());
        }

        private void cmd_edit_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_pembControl.Update());
        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_pembControl.Delete());
        }

        private void cbKodeSuplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (binded)
                dvNoFaktur.RowFilter = "status_tk='Kredit' AND kode_suplier='"+ cbKodeSuplier.Text +"'";
        }
    }
}