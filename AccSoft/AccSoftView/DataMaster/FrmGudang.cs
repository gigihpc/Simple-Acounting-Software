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

namespace AccSoftView.DataMaster
{
    public partial class FrmGudang : DevExpress.XtraEditors.XtraForm,IView
    {
        private GudangModel _gudangModel;
        private GudangControl _gudangControl;
        private bool binding = false;

        public FrmGudang()
        {
            InitializeComponent();
            _gudangModel = new GudangModel();
            _gudangModel.Attach(this);
            _gudangControl = new GudangControl(_gudangModel);
        }

        public void SetKey(String key)
        {
            _gudangModel.kodeGudangKey = key;
        }

        public void ClearCb()
        {
            cb_kodegudang.SelectedIndex = -1;
        }

        public void SetDataModel()
        {
            _gudangModel.kodeGudang = cb_kodegudang.Text;
            _gudangModel.diskripsi = txt_deskripsi.Text;
            _gudangModel.lokasi = txt_lokasi.Text;
        }

        public void BindingControl()
        {
            cb_kodegudang.DataSource = DataManager.Instance.DsAccSoft.Tables["gudang"];
            cb_kodegudang.DisplayMember = "kode_gudang";
            cb_kodegudang.ValueMember = "kode_gudang";

            binding = true;
        }
        #region IView Members

        public void UpdateView()
        {
            txt_deskripsi.Text = _gudangModel.diskripsi;
            txt_lokasi.Text = _gudangModel.lokasi;
        }

        #endregion

        private void cmd_save_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_gudangControl.Add());
            ClearCb();
        }

        private void cmd_edit_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_gudangControl.Update());
            ClearCb();
        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_gudangControl.Delete());
            ClearCb();
        }

        private void cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmGudang_Load(object sender, EventArgs e)
        {
            BindingControl();
            if (_gudangModel.kodeGudangKey.CompareTo("") != 0)
                cb_kodegudang.SelectedValue = (object)_gudangModel.kodeGudangKey;
            else
                ClearCb();
        }

        private void cb_kodegudang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (binding)
            {
                _gudangModel.kodeGudangKey = cb_kodegudang.Text;
                _gudangControl.Select();
            }
        }

    }
}