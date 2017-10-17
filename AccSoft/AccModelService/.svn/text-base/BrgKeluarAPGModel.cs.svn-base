using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace AccModelService
{
    public class BrgKeluarAPGModel : DataModel
    {
        private SqlCommand _sqlCommand;
        private String _commandString;

        public BrgKeluarAPGModel()
        {
            _sqlCommand = ConnManager.Instance.SqlConnection.CreateCommand();
        }

        public String kodeNoBuktiKey = "";
        public String kodeNoBukti = "";
        public DateTime tglbrgkeluarAPG;
        public String kode_gudang = "";
        public String drBagian = "";
        public String jns_mutasi = "";
        public String ekspedisi = "";
        public String exOrder = "";
        public String exDo = "";
        public String KodeCust = "";
        public String noFaktr = "";
        public String noPol = "";

        public String Add()
        {
            _commandString = "INSERT INTO barang_keluar_apg VALUES ('" + kodeNoBukti + "','" + tglbrgkeluarAPG + "', '" + kode_gudang + "','" + drBagian + "','" + jns_mutasi + "','"
             + ekspedisi + "','" + exDo + "','" + exOrder +"','" + KodeCust + "','" + noFaktr + "','" + noPol + "')";

            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                int rows = _sqlCommand.ExecuteNonQuery();
                ConnManager.Instance.CloseConnection();
                DataManager.Instance.RefreshDataSet("barang_keluar_apg");
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
            _commandString = "UPDATE barang_keluar_apg SET tanggal='" + tglbrgkeluarAPG + "', kode_gudang='" + kode_gudang + "', dari_bagian='" + drBagian + "', jenis_mutasi='" + jns_mutasi + "', ekspedisi='" + ekspedisi +"',ex_do='" + exDo +"',ex_order='" + exOrder +"',kode_customer='" + KodeCust +"',no_faktur='" + noFaktr +"',no_pol='" + noPol + "'"
                + "WHERE no_bukti ='" + kodeNoBuktiKey + "'";

            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                int rows = _sqlCommand.ExecuteNonQuery();
                ConnManager.Instance.CloseConnection();
                DataManager.Instance.RefreshDataSet("barang_keluar_apg");
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
            _commandString = "DELETE FROM barang_keluar_apg WHERE no_bukti ='" + kodeNoBuktiKey + "'";

            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                int rows = _sqlCommand.ExecuteNonQuery();
                ConnManager.Instance.CloseConnection();
                DataManager.Instance.RefreshDataSet("barang_keluar_apg");
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
            _commandString = "SELECT * FROM barang_keluar_apg WHERE no_bukti ='" + kodeNoBuktiKey + "'";

            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                SqlDataReader _sqlReader = _sqlCommand.ExecuteReader();
                if (_sqlReader.Read())
                {
                    kodeNoBukti = _sqlReader["no_bukti"].ToString();
                    tglbrgkeluarAPG = (DateTime)_sqlReader["tanggal"];
                    kode_gudang = _sqlReader["kode_gudang"].ToString();
                    drBagian = _sqlReader["dari_bagian"].ToString();
                    jns_mutasi = _sqlReader["jenis_mutasi"].ToString();
                    ekspedisi = _sqlReader["ekspedisi"].ToString();
                    exDo = _sqlReader["ex_do"].ToString();
                    exOrder = _sqlReader["ex_order"].ToString();
                    KodeCust = _sqlReader["kode_customer"].ToString();
                    noFaktr = _sqlReader["no_faktur"].ToString();
                    noPol = _sqlReader["no_pol"].ToString();
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
            tglbrgkeluarAPG = DateTime.Now;
            kode_gudang = "";
            drBagian = "";
            jns_mutasi = "";
            ekspedisi = "";
            exDo = "";
            exOrder = "";
            //KodeCust = "";
            noPol = "";
        }
    }
}
