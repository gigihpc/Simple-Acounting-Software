using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using AccController;
using AccModelService;

namespace AccSoftView.DataMaster
{
    public partial class RegistrasiSuplier : DevExpress.XtraEditors.XtraForm, IView
    {
        private SuplierModel _suplierModel;
        private SuplierControl _suplierControl;
        private bool binded = false;

        public RegistrasiSuplier()
        {
            InitializeComponent();
            _suplierModel = new SuplierModel();
            _suplierModel.Attach(this);
            _suplierControl = new SuplierControl(_suplierModel);
        }

        public void SetKey(String key)
        {
            _suplierModel.KodeSuplierKey = key;
        }

        private void RegistrasiSuplier_Load(object sender, EventArgs e)
        {
            //Binding control with dataset here
            BindingControl();

            if (_suplierModel.KodeSuplierKey.CompareTo("") != 0)
                cbKodeSuplier.SelectedValue = (object)_suplierModel.KodeSuplierKey;
            else
            {
                cbKodeSuplier.SelectedIndex = -1;
                cbNamaSuplier.SelectedIndex = -1;
            }
        }

        public void SetDataModel()
        {
            _suplierModel.KodeSuplier = cbKodeSuplier.Text;
            _suplierModel.NamaSuplier = cbNamaSuplier.Text;
            _suplierModel.Alamat = txtAlamat.Text;
            _suplierModel.Kota = txtKota.Text;
            _suplierModel.Negara = txtNegara.Text;
            _suplierModel.No_telepon = txtNoTelepon.Text;
            _suplierModel.No_fax = txtNoFax.Text;
            _suplierModel.Key_person = txtKeyPerson.Text;
            _suplierModel.Syarat_kredit = Convert.ToInt32(txtSyaratKredit.Text);
            _suplierModel.Limit_kredit = Convert.ToDouble(txtLimitKredit.Text);
            _suplierModel.Mata_uang = cbMataUang.Text;
            _suplierModel.Npwp = txtNpwp.Text;
            _suplierModel.Acc_hutang = txtAccHtgDagang.Text;
        }

        public void BindingControl()
        {            
            cbKodeSuplier.DataSource = DataManager.Instance.DsAccSoft.Tables["suplier"];
            cbKodeSuplier.DisplayMember = "kode_suplier";
            cbKodeSuplier.ValueMember = "kode_suplier";
            cbNamaSuplier.DataSource = DataManager.Instance.DsAccSoft.Tables["suplier"];
            cbNamaSuplier.DisplayMember = "nama_suplier";
            cbNamaSuplier.ValueMember = "nama_suplier";
            cbMataUang.DataSource = DataManager.Instance.DsAccSoft.Tables["kurs_uang"];
            cbMataUang.DisplayMember = "mata_uang";
            cbMataUang.ValueMember = "mata_uang";

            binded = true;
        }       

        private void cmd_save_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_suplierControl.Add());
        }

        private void cmd_edit_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_suplierControl.Update());
        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_suplierControl.Delete());
        }

        private void cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbNamaSuplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            _suplierModel.KodeSuplierKey = cbKodeSuplier.Text;
            _suplierControl.Select();            
        }


        #region IView Members

        public void UpdateView()
        {            
            txtAlamat.Text = _suplierModel.Alamat;
            txtKota.Text = _suplierModel.Kota;
            txtNegara.Text = _suplierModel.Negara;
            txtNoTelepon.Text = _suplierModel.No_telepon;
            txtNoFax.Text = _suplierModel.No_fax;
            txtKeyPerson.Text = _suplierModel.Key_person;
            txtSyaratKredit.Text = _suplierModel.Syarat_kredit.ToString();
            txtLimitKredit.Text = _suplierModel.Limit_kredit.ToString();
            cbMataUang.SelectedValue = (object)_suplierModel.Mata_uang;            
            txtNpwp.Text = _suplierModel.Npwp;
            txtAccHtgDagang.Text = _suplierModel.Acc_hutang;
        }

        #endregion

        private void cbKodeSuplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (binded)
            {
                _suplierModel.KodeSuplierKey = cbKodeSuplier.Text;
                _suplierControl.Select();
            }
        }

    }
}