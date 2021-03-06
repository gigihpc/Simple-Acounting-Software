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
    public partial class CnDnPembelian : DevExpress.XtraEditors.XtraForm, IView
    {
        private CNPembelianModel _pembModel;
        private CNPembelianCOntrol _pembControl;
        private bool binded = false;

        public CnDnPembelian()
        {
            InitializeComponent();
            _pembModel = new CNPembelianModel();
            _pembModel.Attach(this);
            _pembControl = new CNPembelianCOntrol(_pembModel);
        }

        private void CnDnPembelian_Load(object sender, EventArgs e)
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
            cbNoBukti.DataSource = DataManager.Instance.DsAccSoft.Tables["cndn_pembelian"];
            cbNoBukti.DisplayMember = "no_bukti";
            cbNoBukti.ValueMember = "no_bukti";
            cbNoFaktur.DataSource = DataManager.Instance.DsAccSoft.Tables["pembelian"];
            cbNoFaktur.DisplayMember = "no_bpb";
            cbNoFaktur.ValueMember = "no_bpb";
            txt_jmlfktr.DataBindings.Add("text", DataManager.Instance.DsAccSoft, "pembelian.total_harga");
            dtFaktur.DataBindings.Add("DateTime", DataManager.Instance.DsAccSoft, "pembelian.tgl_transaksi");
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
            _pembModel.TglTransaksi = dtTglTransaksi.DateTime;
            _pembModel.ExFaktur = cbNoFaktur.Text;
            _pembModel.JumCnDn = Convert.ToDouble(txt_jmlcn.Text);
            _pembModel.Ket = txt_ket.Text;
        }

        #region IView Members

        public void UpdateView()
        {
            dtTglTransaksi.DateTime = _pembModel.TglTransaksi;
            cbNoFaktur.SelectedValue = (object)_pembModel.ExFaktur;
            txt_jmlcn.Text = _pembModel.JumCnDn.ToString();
            txt_ket.Text = _pembModel.Ket;
        }

        #endregion

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

        private void cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbNoBukti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (binded)
            {
                _pembModel.NoBuktiKey = cbNoBukti.Text;
                _pembModel.Select();
            }
        }

     
    }
}