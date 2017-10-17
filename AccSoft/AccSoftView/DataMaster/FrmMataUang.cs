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
    public partial class FrmMataUang : DevExpress.XtraEditors.XtraForm,IView
    {
        private MatauangModel _uangModel;
        private MataUangControl _uangControl;
        private bool binding = false;

        public FrmMataUang()
        {
            InitializeComponent();
            _uangModel = new MatauangModel();
            _uangModel.Attach(this);
            _uangControl = new MataUangControl(_uangModel);

        }

        private void SetKey(String key)
        {
            _uangModel.MatauangKey = key;
        }

        private void ClearCb()
        {
            cb_matauang.SelectedIndex = -1;
        }

        public void SetDataModel()
        {
            _uangModel.Matauang = cb_matauang.Text;
            _uangModel.KursIDR = Convert.ToUInt16(txt_kurs.Text);
        }

        public void BindingControl()
        {
            cb_matauang.DataSource = DataManager.Instance.DsAccSoft.Tables["kurs_uang"];
            cb_matauang.DisplayMember = "mata_uang";
            cb_matauang.ValueMember = "mata_uang";

            binding = true;
        }

        private void FrmMataUang_Load(object sender, EventArgs e)
        {
            BindingControl();
            if (_uangModel.MatauangKey.CompareTo("") != 0)
                cb_matauang.SelectedValue = (object)_uangModel.MatauangKey;
            else
                ClearCb();
        }

        #region IView Members

        public void UpdateView()
        {
            txt_kurs.Text = Convert.ToString(_uangModel.KursIDR);
        }

        #endregion

        private void cb_matauang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (binding)
            {
                _uangModel.MatauangKey = cb_matauang.Text;
                _uangControl.Select();
            }
        }

        private void cmd_save_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_uangControl.Add());
            ClearCb();
        }

        private void cmd_edit_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_uangControl.Update());
            ClearCb();
        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_uangControl.Delete());
            ClearCb();
        }

        private void cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}