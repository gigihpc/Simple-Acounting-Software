using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace AccModelService
{
    public class PembayaranPiutangModel : DataModel
    {
        private SqlCommand _sqlCommand;
        private String _commandString;

        public PembayaranPiutangModel()
        {
            _sqlCommand = ConnManager.Instance.SqlConnection.CreateCommand();
        }

        public String NoBuktiKey = "";
        public String NoBukti = "";
        public DateTime TglPembayaran;
        public String NoFaktur = "";
        public Double JumPembayaran = .0;
        public String Uraian = "";
        public String KodeCustomer = "";

        private void SetKodeSuplier()
        {
            _commandString = "SELECT kode_customer FROM penjualan WHERE no_bpb ='" + NoFaktur + "'";

            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                SqlDataReader _sqlReader = _sqlCommand.ExecuteReader();
                if (_sqlReader.Read())
                {
                    KodeCustomer = _sqlReader[0].ToString();
                }

                ConnManager.Instance.CloseConnection();
                Notify();
            }
            catch
            {
                ConnManager.Instance.CloseConnection();
            }
        }

        public String Add()
        {
            _commandString = "INSERT INTO pembayaran_piutang VALUES ('" + NoBukti + "'," + TglPembayaran.ToShortDateString() + ", " + JumPembayaran.ToString()
                + ", '" + Uraian + "','" + NoFaktur + "')";
            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                int rows = _sqlCommand.ExecuteNonQuery();
                ConnManager.Instance.CloseConnection();
                DataManager.Instance.RefreshDataSet("pembayaran_piutang");
                Clear();
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
            _commandString = "UPDATE pembayaran_piutang SET no_bukti='" + NoBukti + "',tgl_pembayaran=" + TglPembayaran.ToShortDateString() + ", no_faktur_penjualan='" + NoFaktur
                + "', jumlah_pembayaran=" + JumPembayaran.ToString()
                + ",uraian='" + Uraian + "' WHERE no_bukti ='" + NoBuktiKey + "'";
            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                int rows = _sqlCommand.ExecuteNonQuery();
                ConnManager.Instance.CloseConnection();
                DataManager.Instance.RefreshDataSet("pembayaran_piutang");
                Clear();
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
            _commandString = "DELETE FROM pembayaran_piutang WHERE no_bukti ='" + NoBuktiKey + "'";
            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                int rows = _sqlCommand.ExecuteNonQuery();
                ConnManager.Instance.CloseConnection();
                DataManager.Instance.RefreshDataSet("pembayaran_piutang");
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
            _commandString = "SELECT * FROM pembayaran_piutang WHERE no_bukti ='" + NoBuktiKey + "'";

            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                SqlDataReader _sqlReader = _sqlCommand.ExecuteReader();
                if (_sqlReader.Read())
                {
                    NoBukti = _sqlReader["no_bukti"].ToString();
                    TglPembayaran = (DateTime)_sqlReader["tgl_pembayaran"];
                    NoFaktur = _sqlReader["no_faktur_penjualan"].ToString();
                    JumPembayaran = Convert.ToDouble(_sqlReader["jumlah_pembayaran"].ToString());
                    Uraian = _sqlReader["uraian"].ToString();
                }
                ConnManager.Instance.CloseConnection();
                SetKodeSuplier();
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
            NoFaktur = "";
            TglPembayaran = DateTime.Now;
            JumPembayaran = .0;
            Uraian = "";
            KodeCustomer = "";
        }

    }
}
