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
    public partial class FrmBuktiBrgKeluarAPG : DevExpress.XtraEditors.XtraForm,IView
    {
        private BrgKeluarAPGModel _keluarAPGModel;
        private BrgKeluarAPGControl _keluarAPGControl;
        private bool binding = false;

        public FrmBuktiBrgKeluarAPG()
        {
            InitializeComponent();
            _keluarAPGModel = new BrgKeluarAPGModel();
            _keluarAPGModel.Attach(this);
            _keluarAPGControl = new BrgKeluarAPGControl(_keluarAPGModel);
        }
        public void SetDataModel()
        {
            _keluarAPGModel.kodeNoBukti = cb_noBukti.Text;
            _keluarAPGModel.tglbrgkeluarAPG = date_nobukti.DateTime;
            _keluarAPGModel.kode_gudang = Convert.ToString(cb_gudang.SelectedValue);
            _keluarAPGModel.jns_mutasi = txt_jenismutasi.Text;
            //_keluarAPGModel.drBagian = txt_bagian.Text;
            _keluarAPGModel.ekspedisi = txt_expedisi.Text;
            _keluarAPGModel.exDo = txt_DO.Text;
            _keluarAPGModel.exOrder = txt_order.Text;
            _keluarAPGModel.KodeCust = Convert.ToString(cb_cust.SelectedValue);
            _keluarAPGModel.noFaktr = cb_fktr.Text;
            _keluarAPGModel.noPol = txt_nopol.Text;
        }

        public void BindingControl()
        {
            cb_noBukti.DataSource = DataManager.Instance.DsAccSoft.Tables["barang_keluar_apg"];
            cb_noBukti.DisplayMember = "no_bukti";
            cb_noBukti.ValueMember = "no_bukti";
            cb_gudang.DataSource = DataManager.Instance.DsAccSoft.Tables["gudang"];
            cb_gudang.DisplayMember = "deskripsi";
            cb_gudang.ValueMember = "kode_gudang";
            cb_cust.DataSource = DataManager.Instance.DsAccSoft.Tables["customer"];
            cb_cust.DisplayMember = "nama_customer";
            cb_cust.ValueMember = "kode_customer";
            cb_fktr.DataSource = DataManager.Instance.DsAccSoft.Tables["penjualan"];
            cb_fktr.DisplayMember = "no_bpb";
            cb_fktr.ValueMember = "no_bpb";

            binding = true;
        }
        private void FrmBuktiBrgKeluarAPG_Load(object sender, EventArgs e)
        {
            BindingControl();
            if (_keluarAPGModel.kodeNoBuktiKey.CompareTo("") != 0)
                cb_noBukti.SelectedValue = (object)_keluarAPGModel.kodeNoBuktiKey;
            else
                cb_noBukti.SelectedIndex = -1;
        }
    
#region IView Members

public void  UpdateView()
{
    cb_noBukti.Text = _keluarAPGModel.kodeNoBukti;
    date_nobukti.DateTime = _keluarAPGModel.tglbrgkeluarAPG;
    cb_gudang.Text = _keluarAPGModel.kode_gudang;
    txt_jenismutasi.Text = _keluarAPGModel.jns_mutasi;
   // txt_bagian.Text = _keluarAPGModel.drBagian;
    txt_expedisi.Text = _keluarAPGModel.ekspedisi;
    txt_DO.Text = _keluarAPGModel.exDo;
    txt_order.Text = _keluarAPGModel.exOrder;
    cb_cust.Text = _keluarAPGModel.KodeCust;
    cb_fktr.Text = _keluarAPGModel.noFaktr;
    txt_nopol.Text = _keluarAPGModel.noPol;
}

#endregion

        private void cb_noBukti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (binding)
            {
                _keluarAPGModel.kodeNoBuktiKey = cb_noBukti.Text;
                _keluarAPGModel.Select();
            }
        }

        private void cmd_save_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_keluarAPGControl.Add());
        }

        private void cmd_edit_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_keluarAPGControl.Update());
        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_keluarAPGControl.Delete());
        }

        private void cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
}
}