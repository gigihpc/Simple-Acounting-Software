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
    public partial class FrmItem : DevExpress.XtraEditors.XtraForm,IView
    {
        private ItemModel _itemModel;
        private ItemControl _itemControl;
        private bool binding = false;

        public FrmItem()
        {
            InitializeComponent();
            _itemModel = new ItemModel();
            _itemModel.Attach(this);
            _itemControl = new ItemControl(_itemModel);
        }

        private void cmd_save_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_itemControl.Add());
        }

        #region IView Members

        public void UpdateView()
        {
            cb_Item.Text = _itemModel.kodeItem;
            txt_namaItem.Text = _itemModel.namaItem;
            txt_grupItem.Text = _itemModel.grupItem;
            cb_Status.Text = _itemModel.status;
            txt_unit.Text = _itemModel.Unit;
            txt_minimumStok.Text = _itemModel.minStok.ToString();
            txt_jmlStok.Text = _itemModel.jumStok.ToString();
            txt_hrgJual.Text = _itemModel.hrgJual.ToString();
            txt_hrgBeli.Text = _itemModel.hrgBeli.ToString();
            txt_PPn.Text = _itemModel.ppn;
            txt_persediaan.Text = _itemModel.persediaan;
            txt_hpp.Text = _itemModel.hpp;
            cb_KodeGudang.SelectedValue = _itemModel.kodeGudang;
        }

        #endregion

        private void BindingControl()
        {
            cb_Item.DataSource = DataManager.Instance.DsAccSoft.Tables["Item"];
            cb_Item.DisplayMember = "kode_item";
            cb_Item.ValueMember = "kode_item";
            cb_KodeGudang.DataSource = DataManager.Instance.DsAccSoft.Tables["Gudang"];
            cb_KodeGudang.DisplayMember = "deskripsi";
            cb_KodeGudang.ValueMember = "kode_gudang";

            binding = true;
        }

        private void SetDataModel()
        {
            _itemModel.kodeItem = cb_Item.Text;
            _itemModel.namaItem = txt_namaItem.Text;
            _itemModel.grupItem = txt_grupItem.Text;
            _itemModel.status = cb_Status.Text;
            _itemModel.Unit = txt_unit.Text;
            _itemModel.minStok = Convert.ToDouble(txt_minimumStok.Text);
            _itemModel.jumStok = Convert.ToDouble(txt_jmlStok.Text);
            _itemModel.hrgJual = Convert.ToInt16(txt_hrgJual.Text);
            _itemModel.hrgBeli = Convert.ToInt16(txt_hrgBeli.Text);
            _itemModel.ppn = txt_PPn.Text;
            _itemModel.persediaan = txt_persediaan.Text;
            _itemModel.hpp = txt_hpp.Text;
            _itemModel.kodeGudang = Convert.ToString(cb_KodeGudang.SelectedValue);
        }

        public void SetKey(String key)
        {
            _itemModel.kodeItemKey = key;
        }

        private void FrmItem_Load(object sender, EventArgs e)
        {
            BindingControl();

            if (_itemModel.kodeItemKey.CompareTo("") != 0)
                cb_Item.SelectedValue = (object)_itemModel.kodeItemKey;
            else
                cb_Item.SelectedIndex = -1;
        }

        private void cmd_edit_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_itemControl.Update());
        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            SetDataModel();
            MessageBox.Show(_itemControl.Delete());
        }

        private void cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_Item_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (binding)
            {
                _itemModel.kodeItemKey = cb_Item.Text;
                _itemModel.Select();
            }
        }
    }
}