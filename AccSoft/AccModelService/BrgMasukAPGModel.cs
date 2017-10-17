using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace AccModelService
{
    public class BrgMasukAPGModel : DataModel
    {
        private SqlCommand _sqlCommand;
        private String _commandString;

        public BrgMasukAPGModel()
        {
            _sqlCommand = ConnManager.Instance.SqlConnection.CreateCommand();
        }

        public String kodeNoBuktiKey = "";
        public String kodeNoBukti = "";
        public DateTime tglbrgmasukAPG;
        public String kode_gudang = "";
        public String drBagian = "";
        public String jns_mutasi = "";

        public String Add()
        {
            _commandString = "INSERT INTO barang_masuk_apg VALUES ('" + kodeNoBukti + "','" + tglbrgmasukAPG + "', '" + kode_gudang + "','" + drBagian + "','" + jns_mutasi + "')";

            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                int rows = _sqlCommand.ExecuteNonQuery();
                ConnManager.Instance.CloseConnection();
                DataManager.Instance.RefreshDataSet("barang_masuk_apg");
                Clear();
                Notify();
                return rows.ToString() + " has been added";
            }
            catch (Exception e)
            {
                ConnManager.Instance.CloseConnection();
                return e.ToString();
            }
        }

        public String Update()
        {
            _commandString = "UPDATE barang_masuk_apg SET tanggal='" + tglbrgmasukAPG + "', kode_gudang='" + kode_gudang + "', dari_bagian='" + drBagian + "', jenis_mutasi='" + jns_mutasi + "'"
                + "WHERE no_bukti ='" + kodeNoBuktiKey + "'";

            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                int rows = _sqlCommand.ExecuteNonQuery();
                ConnManager.Instance.CloseConnection();
                DataManager.Instance.RefreshDataSet("barang_masuk_apg");
                Clear();
                Notify();
                return rows.ToString() + " has been updated";
            }
            catch (Exception e)
            {
                ConnManager.Instance.CloseConnection();
                return e.ToString();
            }
        }

        public String Delete()
        {
            _commandString = "DELETE FROM barang_masuk_apg WHERE no_bukti ='" + kodeNoBuktiKey + "'";

            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                int rows = _sqlCommand.ExecuteNonQuery();
                ConnManager.Instance.CloseConnection();
                DataManager.Instance.RefreshDataSet("barang_masuk_apg");
                Clear();
                Notify();
                return rows.ToString() + " has been deleted";
            }
            catch (Exception e)
            {
                ConnManager.Instance.CloseConnection();
                return e.ToString();
            }
        }

        public String Select()
        {
            _commandString = "SELECT * FROM barang_masuk_apg WHERE no_bukti ='" + kodeNoBuktiKey + "'";

            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                SqlDataReader _sqlReader = _sqlCommand.ExecuteReader();
                if (_sqlReader.Read())
                {
                    kodeNoBukti = _sqlReader["no_bukti"].ToString();
                    tglbrgmasukAPG = (DateTime) _sqlReader["tanggal"];
                    kode_gudang = _sqlReader["kode_gudang"].ToString();
                    drBagian = _sqlReader["dari_bagian"].ToString();
                    jns_mutasi = _sqlReader["jenis_mutasi"].ToString();
                }
                ConnManager.Instance.CloseConnection();
                //DataManager.Instance.RefreshDataSet("Customer");
                Notify();
                return kodeNoBukti + " has been selected";
            }
            catch (Exception e)
            {
                ConnManager.Instance.CloseConnection();
                return e.ToString();
            }
        }

        public void Clear()
        {
            kodeNoBuktiKey = "";
            tglbrgmasukAPG = DateTime.Now;
            kode_gudang = "";
            drBagian = "";
            jns_mutasi = "";
        }
    }
}
