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
    public partial class FrmUser : DevExpress.XtraEditors.XtraForm,IView
    {
        private UserModel _userModel;
        private User_Control _userControl;
        private bool binding = false;

        public FrmUser()
        {
            InitializeComponent();
            _userModel = new UserModel();
            _userModel.Attach(this);
            _userControl = new User_Control(_userModel);
        }

        public void SetKey(String key)
        {
            _userModel.kodeUserKey = key;
        }

        public void ClearCb()
        {
            cb_kodepengguna.SelectedIndex = -1;
            cb_status.SelectedIndex = -1;
        }

        public void SetDataModel()
        {
            _userModel.kodeUser = cb_kodepengguna.Text;
            _userModel.namaUser = txt_nmpengguna.Text;
            _userModel.password = txt_katakunci.Text;
            _userModel.jabatan = txt_jabatan.Text;
            _userModel.status =Convert.ToString(cb_status.SelectedIndex);
            
        }

        public void BindingControl()
        {
            cb_kodepengguna.DataSource = DataManager.Instance.DsAccSoft.Tables["user_acc"];
            cb_kodepengguna.DisplayMember = "id_pengguna";
            cb_kodepengguna.ValueMember = "id_pengguna";

            binding = true;
        }       
        #region IView Members

        public void UpdateView()
        {
            txt_nmpengguna.Text = _userModel.namaUser;
            txt_katakunci.Text = _userModel.password;
            txt_jabatan.Text = _userModel.jabatan;
            cb_status.SelectedIndex =Convert.ToInt16(_userModel.status);
        }

        #endregion

        private void cmd_save_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_userControl.Add());
            ClearCb();
        }

        private void cmd_edit_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_userControl.Update());
            ClearCb();
        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_userControl.Delete());
            ClearCb();
        }

        private void cb_kodepengguna_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (binding)
            {
                _userModel.kodeUserKey = cb_kodepengguna.Text;
                _userControl.Select();
            }
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* if (cb_kodepengguna.Text == "Manajer")
                cb_kodepengguna.SelectedIndex.Equals(0);
            else if (cb_kodepengguna.Text == "Admin")
                cb_kodepengguna.SelectedIndex.Equals(1);*/
        }

        private void cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            BindingControl();
            if (_userModel.kodeUserKey.CompareTo("") != 0)
                cb_kodepengguna.SelectedValue = (object)_userModel.kodeUserKey;
            else
                ClearCb();
        }
    }
}