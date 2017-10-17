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

namespace AccSoftView.GeneralLedger
{
    public partial class FrmKodePerkiraan : DevExpress.XtraEditors.XtraForm, IView
    {
        private KodePerkiraanModel _kodePerkiraanM;
        private KodePerkiraanControl _kodePerkiraanC;
        private bool binded = false;

        public FrmKodePerkiraan()
        {
            InitializeComponent();
            _kodePerkiraanM = new KodePerkiraanModel();
            _kodePerkiraanM.Attach(this);
            _kodePerkiraanC = new KodePerkiraanControl(_kodePerkiraanM);
        }


        #region IView Members

        public void UpdateView()
        {
            cbKodeAkun.SelectedValue = (object)_kodePerkiraanM.KodeAcc;
            cbNamaAkun.SelectedValue = (object)_kodePerkiraanM.NamaAkun;
            cbStatusNR.Text = _kodePerkiraanM.StatusNR;
            cbStatusDK.Text = _kodePerkiraanM.StatusDK;
            cbHPP.Text = _kodePerkiraanM.Hpp;
        }

        #endregion

        private void FrmKodePerkiraan_Load(object sender, EventArgs e)
        {
            //Binding control with dataset here
            BindingControl();

            if (_kodePerkiraanM.KodeAccKey.CompareTo("") != 0)
                cbKodeAkun.SelectedValue = (object)_kodePerkiraanM.KodeAccKey;
            else
            {
                cbKodeAkun.SelectedIndex = -1;
            }
        }

        public void BindingControl()
        {         
            cbKodeAkun.DataSource = DataManager.Instance.DsAccSoft.Tables["kode_perkiraan"];
            cbKodeAkun.DisplayMember = "kode_acc";
            cbKodeAkun.ValueMember = "kode_acc";
            cbNamaAkun.DataSource = DataManager.Instance.DsAccSoft.Tables["kode_perkiraan"];
            cbNamaAkun.DisplayMember = "nama_account";
            cbNamaAkun.ValueMember = "nama_account";

            binded = true;
        }

        public void SetKey(String no_acc)
        {
            _kodePerkiraanM.KodeAccKey = no_acc;
        }

        public void SetDataModel()
        {
            _kodePerkiraanM.KodeAcc = cbKodeAkun.Text;
            _kodePerkiraanM.NamaAkun = cbNamaAkun.Text;
            _kodePerkiraanM.StatusNR = cbStatusNR.Text;
            _kodePerkiraanM.StatusDK = cbStatusDK.Text;
            _kodePerkiraanM.Hpp = cbHPP.Text;
        }

        private void cbKodeAkun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (binded)
            {
                _kodePerkiraanM.KodeAccKey = cbKodeAkun.Text;
                _kodePerkiraanM.Select();
            }
        }

        private void cmd_save_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_kodePerkiraanC.Add());
        }

        private void cmd_edit_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_kodePerkiraanC.Update());
        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_kodePerkiraanC.Delete());
        }

        private void cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}