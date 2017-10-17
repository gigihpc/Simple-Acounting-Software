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
    public partial class Reg_Customer : DevExpress.XtraEditors.XtraForm,IView
    {
        private CustomerModel _custModel;
        private CustomerControl _custControl;
        private bool binding = false;

        public Reg_Customer()
        {
            InitializeComponent();
            _custModel = new CustomerModel();
            _custModel.Attach(this);
            _custControl = new CustomerControl(_custModel);
        }

        public void SetKey(String key)
        {
            _custModel.KodeCustKey = key;
        }

        private void ClearCb()
        {
            cbKodeCustomer.SelectedIndex = -1;
            cbNamaCustomer.SelectedIndex = -1;
        }

        public void SetDataModel()
        {
            _custModel.KodeCust = cbKodeCustomer.Text;
            _custModel.Nm_Cust = cbNamaCustomer.Text;
            _custModel.Almatcust = txt_almt.Text;
            _custModel.Kota = txt_kota.Text;
            _custModel.Negara = txt_negara.Text;
            _custModel.Notelp = txt_notlp.Text;
            _custModel.NoFax = txt_nofax.Text;
            _custModel.Keyperson = txt_keyperson.Text;
            _custModel.SyrtKredit = Convert.ToInt32(txt_syaratkredit.Text);
            _custModel.LmtKredit = Convert.ToDouble(txt_limitkredit.Text);
            _custModel.Matauang = cbMataUang.Text;
            _custModel.NPWP1 = txt_npwp.Text;
            _custModel.Daerah = txt_daerah.Text;
            _custModel.Sales = txt_selesman.Text;
            _custModel.Accptgdagang = txt_dagang.Text;
        }

        public void BindingControl()
        {
            cbKodeCustomer.DataSource = DataManager.Instance.DsAccSoft.Tables["customer"];
            cbKodeCustomer.DisplayMember = "kode_customer";
            cbKodeCustomer.ValueMember = "kode_customer";
            cbNamaCustomer.DataSource = DataManager.Instance.DsAccSoft.Tables["customer"];
            cbNamaCustomer.DisplayMember = "nama_customer";
            cbNamaCustomer.ValueMember = "nama_customer";
            cbMataUang.DataSource = DataManager.Instance.DsAccSoft.Tables["kurs_uang"];
            cbMataUang.DisplayMember = "mata_uang";
            cbMataUang.ValueMember = "mata_uang";

            binding = true;
        }       

        private void cmd_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmd_save_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_custControl.Add());
            ClearCb();
        }

        private void cmd_edit_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_custControl.Update());
            ClearCb();
        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_custControl.Delete());
            ClearCb();
        }

        private void Reg_Customer_Load(object sender, EventArgs e)
        {
            BindingControl();
            if (_custModel.KodeCustKey.CompareTo("") != 0)
                cbKodeCustomer.SelectedValue = (object)_custModel.KodeCustKey;
            else
                ClearCb();
        }

       /* private void cbNamaCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (binding)
            {
                _custModel.KodeCustKey = cbKodeCustomer.Text;
                _custControl.Select();
            }
        }*/

        #region IView Members

        public void UpdateView()
        {
            txt_almt.Text = _custModel.Almatcust;
            txt_kota.Text = _custModel.Kota;
            txt_negara.Text = _custModel.Negara;
            txt_notlp.Text = _custModel.Notelp;
            txt_nofax.Text = _custModel.NoFax;
            txt_keyperson.Text = _custModel.Keyperson;
            txt_syaratkredit.Text = _custModel.SyrtKredit.ToString();
            txt_limitkredit.Text = _custModel.LmtKredit.ToString();
            cbMataUang.SelectedValue = (object)_custModel.Matauang;
            txt_npwp.Text = _custModel.NPWP1;
            txt_daerah.Text = _custModel.Daerah;
            txt_selesman.Text = _custModel.Sales;
            txt_dagang.Text = _custModel.Accptgdagang;
        }

        #endregion

        private void cbKodeCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (binding)
            {
                _custModel.KodeCustKey = cbKodeCustomer.Text;
                _custControl.Select();
            }
        }
    }
}