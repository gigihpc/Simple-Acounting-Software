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

namespace AccSoftView.Gudang
{
    public partial class FrmBuktiBrgMasukAPG : DevExpress.XtraEditors.XtraForm,IView
    {
        private BrgMasukAPGModel _masukAPGModel;
        private BrgMasukAPGControl _masukAPGControl;
        private bool binding = false;

        public FrmBuktiBrgMasukAPG()
        {
            InitializeComponent();
            _masukAPGModel = new BrgMasukAPGModel();
            _masukAPGModel.Attach(this);
            _masukAPGControl= new BrgMasukAPGControl(_masukAPGModel);
        }

        public void SetKey(String key)
        {
            _masukAPGModel.kodeNoBuktiKey = key;
        }

        public void SetDataModel()
        {
            _masukAPGModel.kodeNoBukti = cb_noBukti.Text;
            _masukAPGModel.tglbrgmasukAPG = date_nobukti.DateTime;
            _masukAPGModel.kode_gudang = Convert.ToString(cb_gudang.SelectedValue);
            _masukAPGModel.jns_mutasi = txt_jenismutasi.Text;
            _masukAPGModel.drBagian = txt_bagian.Text;
        }

        public void BindingControl()
        {
            cb_noBukti.DataSource = DataManager.Instance.DsAccSoft.Tables["barang_masuk_apg"];
            cb_noBukti.DisplayMember = "no_bukti";
            cb_noBukti.ValueMember = "no_bukti";
            cb_gudang.DataSource = DataManager.Instance.DsAccSoft.Tables["gudang"];
            cb_gudang.DisplayMember = "deskripsi";
            cb_gudang.ValueMember = "kode_gudang";

            binding = true;
        }

        private void FrmBuktiBrgMasukAPG_Load(object sender, EventArgs e)
        {
            BindingControl();
            if (_masukAPGModel.kodeNoBuktiKey.CompareTo("") != 0)
                cb_noBukti.SelectedValue = (object)_masukAPGModel.kodeNoBuktiKey;
            else
                cb_noBukti.SelectedIndex = -1;
        }

        #region IView Members

        public void UpdateView()
        {
            cb_noBukti.Text = _masukAPGModel.kodeNoBukti;
            date_nobukti.DateTime = _masukAPGModel.tglbrgmasukAPG;
            cb_gudang.Text = _masukAPGModel.kode_gudang;
            txt_jenismutasi.Text = _masukAPGModel.jns_mutasi;
            txt_bagian.Text = _masukAPGModel.drBagian;
        }

        #endregion

        private void cb_noBukti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (binding)
            {
                _masukAPGModel.kodeNoBuktiKey = cb_noBukti.Text;
                _masukAPGModel.Select();
            }
        }

        private void cmd_save_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_masukAPGControl.Add());
        }

        private void cmd_edit_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_masukAPGControl.Update());
        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_masukAPGControl.Delete());
        }

        private void cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}