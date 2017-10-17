using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace AccModelService
{
   public class FakturPenjualanModel : DataModel
    {
        private SqlCommand _sqlCommand;
        private String _commandString;
        private String _commandString2;

        public String No_bpbKey = "";
        public String No_bpb = "";
        public DateTime tgl_transaksi;
        public String surat_jalan = "";
        public DateTime jth_tempo;
        public String no_fakturPjk = "";
        public DateTime tgl_fktr;
        public String statusTK = "";
        public String statusFktr = "";
        public String exOrder = "";
        public String kodeCust = "";
        public String mata_uang = "";
        public double totalhrga = .0;
        public string ket_fktr = "";

        public List<string> KodeItem;
        public List<double> HrgSatuan;
        public List<int> jmlItem;
        public List<double> Total;

        public FakturPenjualanModel()
        {
            _sqlCommand = ConnManager.Instance.SqlConnection.CreateCommand();
            KodeItem = new List<string>();
            HrgSatuan = new List<double>();
            jmlItem = new List<int>();
            Total = new List<double>();
        }

        public void AddItem(string kodeItem, double hrgSatuan, int _jmlItem, double total)
        {
            KodeItem.Add(kodeItem);
            HrgSatuan.Add(hrgSatuan);
            jmlItem.Add(_jmlItem);
            Total.Add(total);
        }

        public String Add()
        {
            _commandString = "INSERT INTO penjualan VALUES ('" + No_bpb + "','" + tgl_transaksi.ToShortDateString() + "', '" + surat_jalan + "', '" + jth_tempo.ToShortDateString() + "', '"
                + no_fakturPjk + "','" + tgl_fktr.ToShortDateString() + "','" + statusTK + "','" + exOrder + "','"  + kodeCust + "','"
                + mata_uang + "'," + totalhrga + ",'" + ket_fktr + "')";
            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                int rows = _sqlCommand.ExecuteNonQuery();
                ConnManager.Instance.CloseConnection();
                DataManager.Instance.RefreshDataSet("penjualan");
                Notify();
                Clear();
                return rows.ToString() + " rows has been added";
            }
            catch (Exception e)
            {
                ConnManager.Instance.CloseConnection();
                return e.ToString();
            }
        }

        public String AddItemToDb()
        {
            for (int i = 0; i < KodeItem.Count; i++)
            {
                _commandString2 = "INSERT INTO detail_penjualan VALUES ('"+ No_bpb + "-" + i.ToString() + "','" + KodeItem[i] + "', '" + No_bpb + "', "
                    + jmlItem[i].ToString() + "," + HrgSatuan[i].ToString() + "," + Total[i].ToString() + ")";
                try
                {
                    ConnManager.Instance.OpenConnection();
                    _sqlCommand.CommandText = _commandString2;
                    int rows = _sqlCommand.ExecuteNonQuery();
                    ConnManager.Instance.CloseConnection();
                    DataManager.Instance.RefreshDataSet("detail_penjualan");
                    Notify();
                    ClearItem();
                }
                catch (Exception e)
                {
                    ConnManager.Instance.CloseConnection();
                    return e.ToString();
                }
            }
            DataManager.Instance.RefreshDataSet("penjualan");
            Notify();
            return "Succes";
        }

        public String Update()
        {
            _commandString = "UPDATE penjualan SET tgl_transaksi='" + tgl_transaksi.ToShortDateString() + "', surat_jalan='" + surat_jalan + "', jatuh_tempo='" + jth_tempo.ToShortDateString()
                + "', no_faktur_pajak='" + no_fakturPjk + "',tgl_faktur_pajak='" + tgl_fktr.ToShortDateString() + "',status_tk='" + statusTK
                + "',ex_order='" + exOrder + "',kode_customer='" + kodeCust + "',mata_uang='" + mata_uang + "',total_harga="
                + totalhrga + ",keterangan='" + ket_fktr + "' WHERE no_bpb='" + No_bpbKey + "'";

            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                int rows = _sqlCommand.ExecuteNonQuery();
                ConnManager.Instance.CloseConnection();
                DataManager.Instance.RefreshDataSet("penjualan");
                Notify();
                Clear();
                return rows.ToString() + " rows has been updated";
            }
            catch (Exception e)
            {
                ConnManager.Instance.CloseConnection();
                return e.ToString();
            }
        }

        public String UpdateItemToDb()
        {
            for (int i = 0; i < KodeItem.Count; i++)
            {
                _commandString2 = "UPDATE detail_penjualan SET kode_item='" + KodeItem[i] + "',jumlah_item="
                    + jmlItem[i].ToString() + ",harga_satuan=" + HrgSatuan[i].ToString() + ",total=" + Total[i].ToString() +
                    " WHERE id_detail='" + No_bpbKey + "-" + i.ToString() + "'";
                try
                {
                    ConnManager.Instance.OpenConnection();
                    _sqlCommand.CommandText = _commandString2;
                    int rows = _sqlCommand.ExecuteNonQuery();
                    ConnManager.Instance.CloseConnection();
                    DataManager.Instance.RefreshDataSet("detail_penjualan");
                    Notify();
                    ClearItem();
                }
                catch (Exception e)
                {
                    ConnManager.Instance.CloseConnection();
                    return e.ToString();
                }
            }
            DataManager.Instance.RefreshDataSet("penjualan");
            Notify();
            return "Succes";
        }


        public String Delete()
        {
            _commandString = "DELETE FROM penjualan WHERE no_bpb ='" + No_bpbKey + "'";

            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                int rows = _sqlCommand.ExecuteNonQuery();
                ConnManager.Instance.CloseConnection();
                DataManager.Instance.RefreshDataSet("penjualan");
                Clear();
                Notify();
                return No_bpb + " rows has been deleted";
            }
            catch (Exception e)
            {
                ConnManager.Instance.CloseConnection();
                return e.ToString();
            }
        }

        public String Select()
        {
            _commandString = "SELECT * FROM penjualan WHERE no_bpb ='" + No_bpbKey + "'";

            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                SqlDataReader _sqlReader = _sqlCommand.ExecuteReader();
                if (_sqlReader.Read())
                {
                    No_bpb = _sqlReader["no_bpb"].ToString();
                    tgl_transaksi = (DateTime)_sqlReader["tgl_transaksi"];
                    surat_jalan = _sqlReader["surat_jalan"].ToString();
                    statusTK = _sqlReader["status_tk"].ToString();
                    //statusFktr = _sqlReader["status_faktur"].ToString();
                    exOrder = _sqlReader["ex_order"].ToString();
                    kodeCust = _sqlReader["kode_customer"].ToString();
                    jth_tempo = (DateTime)_sqlReader["jatuh_tempo"];
                    no_fakturPjk = _sqlReader["no_faktur_pajak"].ToString();
                    tgl_fktr = (DateTime)_sqlReader["tgl_faktur_pajak"];
                    ket_fktr = _sqlReader["keterangan"].ToString();
                    totalhrga = Convert.ToDouble(_sqlReader["total_harga"]);
                    mata_uang = _sqlReader["mata_uang"].ToString();

                    _sqlReader.Close();
                    _commandString = "SELECT * FROM detail_penjualan WHERE no_bpb ='" + No_bpbKey + "'";
                    _sqlCommand.CommandText = _commandString;
                    SqlDataReader _sqlReader2 = _sqlCommand.ExecuteReader();

                    ClearItem();
                    while (_sqlReader2.Read())
                    {
                        AddItem(_sqlReader2["kode_item"].ToString(), Convert.ToDouble(_sqlReader2["harga_satuan"]),
                            Convert.ToInt32(_sqlReader2["jumlah_item"]),
                            Convert.ToDouble(_sqlReader2["total"]));
                    }
                }
                ConnManager.Instance.CloseConnection();
                Notify();
                return No_bpbKey + " rows has been selected";
            }
            catch (Exception e)
            {
                ConnManager.Instance.CloseConnection();
                return e.ToString();
            }
        }

        public void ClearItem()
        {
            KodeItem.Clear();
            HrgSatuan.Clear();
            jmlItem.Clear();
            Total.Clear();

        }

        public void Clear()
        {
            No_bpbKey = "";
            No_bpb = "";
            tgl_transaksi = DateTime.Now;
            surat_jalan = "";
            statusTK = "";
            statusFktr = "";
            exOrder = "";
            kodeCust = "";
            jth_tempo = DateTime.Now;
            no_fakturPjk = "";
            tgl_fktr = DateTime.Now;
            ket_fktr = "";
            totalhrga = .0;
            mata_uang = "";

            ClearItem();
        }
    }
}
