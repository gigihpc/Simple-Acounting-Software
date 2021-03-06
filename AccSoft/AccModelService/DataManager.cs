using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace AccModelService
{
    public class DataManager
    {
        private DataSet _dsAccSoft;

        public DataSet DsAccSoft
        {
            get 
            { 
                return _dsAccSoft; 
            }
        }
        private static DataManager _instance;

        public static DataManager Instance
        {
            get 
            {
                if (_instance == null)
                    _instance = new DataManager();

                return DataManager._instance; 
            }            
        }
        
        private DataManager()
        {
           _dsAccSoft = new DataSet("dsAccSoft");
        }

        public void FillDataSet()
        {
             SqlDataAdapter _dataAdapter = new SqlDataAdapter("SELECT kode_suplier, nama_suplier, alamat, kota, no_telepon, limit_kredit, syarat_kredit FROM suplier", ConnManager.Instance.SqlConnection);
             _dataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
             _dataAdapter.Fill(_dsAccSoft, "suplier");
             _dataAdapter = new SqlDataAdapter("SELECT * FROM kurs_uang", ConnManager.Instance.SqlConnection);
             _dataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
             _dataAdapter.Fill(_dsAccSoft, "kurs_uang");
             _dataAdapter = new SqlDataAdapter("select kode_customer,nama_customer,alamat,kota,negara,no_fax,no_telepon,key_person,salesman,daerah from customer",ConnManager.Instance.SqlConnection);
             _dataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
             _dataAdapter.Fill(_dsAccSoft, "customer");
             _dataAdapter = new SqlDataAdapter("select * from item", ConnManager.Instance.SqlConnection);
             _dataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
             _dataAdapter.Fill(_dsAccSoft, "item");
             _dataAdapter = new SqlDataAdapter("select * from pembelian", ConnManager.Instance.SqlConnection);
             _dataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
             _dataAdapter.Fill(_dsAccSoft, "pembelian");
             _dataAdapter = new SqlDataAdapter("select * from user_acc", ConnManager.Instance.SqlConnection);
             _dataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
             _dataAdapter.Fill(_dsAccSoft, "user_acc");
             _dataAdapter = new SqlDataAdapter("select * from gudang", ConnManager.Instance.SqlConnection);
             _dataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
             _dataAdapter.Fill(_dsAccSoft, "gudang");
             _dataAdapter = new SqlDataAdapter("select * from penjualan", ConnManager.Instance.SqlConnection);
             _dataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
             _dataAdapter.Fill(_dsAccSoft, "penjualan");
             _dataAdapter = new SqlDataAdapter("select * from cndn_pembelian", ConnManager.Instance.SqlConnection);
             _dataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
             _dataAdapter.Fill(_dsAccSoft, "cndn_pembelian");
             _dataAdapter = new SqlDataAdapter("select * from cndn_penjualan", ConnManager.Instance.SqlConnection);
             _dataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
             _dataAdapter.Fill(_dsAccSoft, "cndn_penjualan");
             _dataAdapter = new SqlDataAdapter("select * from pembayaran_hutang", ConnManager.Instance.SqlConnection);
             _dataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
             _dataAdapter.Fill(_dsAccSoft, "pembayaran_hutang");
             _dataAdapter = new SqlDataAdapter("select * from kode_perkiraan", ConnManager.Instance.SqlConnection);
             _dataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
             _dataAdapter.Fill(_dsAccSoft, "kode_perkiraan");
             _dataAdapter = new SqlDataAdapter("select * from pembayaran_piutang", ConnManager.Instance.SqlConnection);
             _dataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
             _dataAdapter.Fill(_dsAccSoft, "pembayaran_piutang");
             _dataAdapter = new SqlDataAdapter("select * from barang_masuk_apg", ConnManager.Instance.SqlConnection);
             _dataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
             _dataAdapter.Fill(_dsAccSoft, "barang_masuk_apg");
             _dataAdapter = new SqlDataAdapter("select * from barang_keluar_apg", ConnManager.Instance.SqlConnection);
             _dataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
             _dataAdapter.Fill(_dsAccSoft, "barang_keluar_apg");
        }

        public void RefreshDataSet(String namaTabel)
        {
            _dsAccSoft.Tables[namaTabel].Clear();
            SqlDataAdapter _dataAdapter = new SqlDataAdapter("SELECT * FROM " + namaTabel, ConnManager.Instance.SqlConnection);
            _dataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            _dataAdapter.Fill(_dsAccSoft, namaTabel);

        }
        
    }
}
