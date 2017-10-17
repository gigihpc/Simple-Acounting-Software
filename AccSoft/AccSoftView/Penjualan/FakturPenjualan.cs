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
using AccSoftView.DataMaster;

namespace AccSoftView.Penjualan
{
    public partial class FakturPenjualan : DevExpress.XtraEditors.XtraForm,IView
    {
        private FakturPenjualanModel _fPenjualanModel;
        private FakturPenjualanControl _fPenjualanControl;
        private bool binding = false;

        public FakturPenjualan()
        {
            InitializeComponent();
            _fPenjualanModel = new FakturPenjualanModel();
            _fPenjualanModel.Attach(this);
            _fPenjualanControl = new FakturPenjualanControl(_fPenjualanModel);
        }


        private void FakturPenjualan_Load(object sender, EventArgs e)
        {
            BindingControl();
            if (_fPenjualanModel.No_bpbKey.CompareTo("") != 0)
                cbNoBpb.SelectedValue = (object)_fPenjualanModel.No_bpbKey;
            else
                cb_cust.SelectedIndex = -1;
        }

        #region IView Members

        public void UpdateView()
        {
            date_bpb.DateTime = _fPenjualanModel.tgl_transaksi;
            dateJthTempo.DateTime = _fPenjualanModel.jth_tempo;
            txt_fkt.Text = _fPenjualanModel.no_fakturPjk;
            date_fkt.DateTime = _fPenjualanModel.tgl_fktr;
            cbStatusTransaksi.Text = _fPenjualanModel.statusTK;
            //cbKodeSuplier.SelectedValue = (object)fakturPembModel.KodeSuplier;
            cmb_status.Text = _fPenjualanModel.surat_jalan;
            txt_exOr.Text = _fPenjualanModel.exOrder;
            cb_cust.SelectedValue = _fPenjualanModel.kodeCust;
            cb_matauang.Text = _fPenjualanModel.mata_uang;
            txt_ket.Text = _fPenjualanModel.ket_fktr;

            dataGridView1.Rows.Clear();
            for (int i = 0; i < _fPenjualanModel.KodeItem.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.CreateCells(dataGridView1);
                row.Cells[0].Value = _fPenjualanModel.KodeItem[i];
                row.Cells[1].Value = _fPenjualanModel.HrgSatuan[i];
                row.Cells[2].Value = _fPenjualanModel.jmlItem[i];
                row.Cells[3].Value = _fPenjualanModel.Total[i];

                dataGridView1.Rows.Add(row);
            }
        }

        #endregion

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            Reg_Customer regCust = new Reg_Customer();
            regCust.ShowDialog();
        }

        public void SetDataModel()
        {
            _fPenjualanModel.No_bpb = cbNoBpb.Text;
            _fPenjualanModel.tgl_transaksi = date_bpb.DateTime;
            _fPenjualanModel.jth_tempo = dateJthTempo.DateTime;
            _fPenjualanModel.no_fakturPjk = txt_fkt.Text;
            _fPenjualanModel.tgl_fktr = date_fkt.DateTime;
            _fPenjualanModel.statusTK = cbStatusTransaksi.Text;
            _fPenjualanModel.surat_jalan = cmb_status.Text;
            _fPenjualanModel.exOrder = txt_exOr.Text;
            _fPenjualanModel.kodeCust =Convert.ToString(cb_cust.SelectedValue);
            _fPenjualanModel.mata_uang = cb_matauang.Text;
            _fPenjualanModel.ket_fktr = txt_ket.Text;

            _fPenjualanModel.ClearItem();
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                _fPenjualanModel.AddItem(dataGridView1.Rows[i].Cells[0].Value.ToString(),
                    Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value.ToString()),
                    Convert.ToInt16(dataGridView1.Rows[i].Cells[2].Value.ToString()),
                    Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value.ToString()));
            }
        }

        public void BindingControl()
        {
            cbNoBpb.DataSource = DataManager.Instance.DsAccSoft.Tables["penjualan"];
            cbNoBpb.DisplayMember = "no_bpb";
            cbNoBpb.ValueMember = "no_bpb";
            cb_cust.DataSource = DataManager.Instance.DsAccSoft.Tables["customer"];
            cb_cust.DisplayMember = "nama_customer";
            cb_cust.ValueMember = "kode_customer";
            cb_matauang.DataSource = DataManager.Instance.DsAccSoft.Tables["kurs_uang"];
            cb_matauang.DisplayMember = "mata_uang";
            cb_matauang.ValueMember = "mata_uang";
            NamaItem.DataSource = DataManager.Instance.DsAccSoft.Tables["Item"];
            NamaItem.DisplayMember = "nama_item";
            NamaItem.ValueMember = "kode_item";

            binding = true;
        }

        private void cmd_save_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_fPenjualanControl.Add());
        }

        private void cmd_edit_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_fPenjualanControl.Update());
        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_fPenjualanControl.Delete());
        }

        private void cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetKey(String key)
        {
            _fPenjualanModel.No_bpbKey = key;
        }

        private void cbNoBpb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (binding)
            {
                _fPenjualanModel.No_bpbKey = cbNoBpb.Text;
                _fPenjualanModel.Select();
            }
        }

    }
}