using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace AccModelService
{
    public class CNPembelianModel : DataModel
    {
        private SqlCommand _sqlCommand;
        private String _commandString;

        public String NoBukti = "";
        public String NoBuktiKey = "";
        public DateTime TglTransaksi;
        public String ExFaktur = "";
        public Double JumCnDn = .0;
        public String Ket = "";

        public CNPembelianModel()
        {
            _sqlCommand = ConnManager.Instance.SqlConnection.CreateCommand();
        }

        public String Add()
        {
            _commandString = "INSERT INTO cndn_pembelian VALUES ('" + NoBukti + "','" + TglTransaksi.ToShortDateString() + "', '" + ExFaktur + "', " +JumCnDn.ToString() 
                + ",'" + Ket + "')";
            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                int rows = _sqlCommand.ExecuteNonQuery();
                ConnManager.Instance.CloseConnection();
                DataManager.Instance.RefreshDataSet("cndn_pembelian");
                Notify();
                return rows.ToString() + " rows has been added";
            }
            catch (Exception e)
            {
                ConnManager.Instance.CloseConnection();
                return e.ToString();
            }

        }

        public String Update()
        {
            _commandString = "UPDATE cndn_pembelian SET no_bukti='" + NoBukti + "',tgl_transaksi='" + TglTransaksi.ToShortDateString() + "', ex_faktur='" + ExFaktur + "', jumlah_cndn=" + JumCnDn.ToString()
                + ",keterangan='" + Ket + "' WHERE no_bukti ='"+ NoBuktiKey +"'";
            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                int rows = _sqlCommand.ExecuteNonQuery();
                ConnManager.Instance.CloseConnection();
                DataManager.Instance.RefreshDataSet("cndn_pembelian");
                Notify();
                return rows.ToString() + " rows has been updated";
            }
            catch (Exception e)
            {
                ConnManager.Instance.CloseConnection();
                return e.ToString();
            }
        }

        public String Delete()
        {
            _commandString = "DELETE FROM cndn_pembelian WHERE no_bukti ='" + NoBuktiKey + "'";
            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                int rows = _sqlCommand.ExecuteNonQuery();
                ConnManager.Instance.CloseConnection();
                DataManager.Instance.RefreshDataSet("cndn_pembelian");
                Clear();
                Notify();
                return NoBuktiKey + " rows has been deleted";
            }
            catch (Exception e)
            {
                ConnManager.Instance.CloseConnection();
                return e.ToString();
            }
        }

        public String Select()
        {
            _commandString = "SELECT * FROM cndn_pembelian WHERE no_bukti ='" + NoBuktiKey + "'";

            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                SqlDataReader _sqlReader = _sqlCommand.ExecuteReader();
                if (_sqlReader.Read())
                {
                    NoBukti = _sqlReader["no_bukti"].ToString();
                    TglTransaksi = (DateTime)_sqlReader["tgl_transaksi"];
                    ExFaktur = _sqlReader["ex_faktur"].ToString();
                    JumCnDn = Convert.ToDouble(_sqlReader["jumlah_cndn"].ToString());
                    Ket = _sqlReader["keterangan"].ToString();
                }
                  
                ConnManager.Instance.CloseConnection();
                Notify();
                return NoBukti + " has been selected";
            }
            catch (Exception e)
            {
                ConnManager.Instance.CloseConnection();
                return e.ToString();
            }
        }

        public void Clear()
        {
            NoBukti = "";
            NoBuktiKey = "";
            TglTransaksi = DateTime.Now;
            ExFaktur = "";
            JumCnDn = .0;
            Ket = "";
        }

    }
}
