using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace AccModelService
{
    public class FakturPembelianModel : DataModel
    {
        private SqlCommand _sqlCommand;
        private String _commandString;
        private String _commandString2;

        public String No_bpbKey = "";
        public String No_bpb = "";
        public DateTime Tgl_transaksi;
        public String Surat_jalan = "";
        public String Status_transaksi = "";
        public String ExNoSPB = "";
        public DateTime Tgl_SPB;
        public String KodeSuplier = "";
        public DateTime Tgl_jatuh_tempo;
        public String NoFakturPajak = "";
        public DateTime TglFakturPajak;
        public String Ket = "";
        public double TotalBiaya = .0;
        public String MataUang = "";

        public List<string> KodeItem;
        public List<double> HargaSatuan;
        public List<int> JumItem;
        public List<double> Total;

        public FakturPembelianModel()
        {
            _sqlCommand = ConnManager.Instance.SqlConnection.CreateCommand();
            KodeItem = new List<string>();
            HargaSatuan = new List<double>();
            JumItem = new List<int>();
            Total = new List<double>();
        }

        public void AddItem(string kodeItem, double hargaSatuan, int jumItem, double total)
        {
            KodeItem.Add(kodeItem);
            HargaSatuan.Add(hargaSatuan);
            JumItem.Add(jumItem);
            Total.Add(total);
        }
        
        public String Add()
        {
            _commandString = "INSERT INTO pembelian VALUES ('" + No_bpb + "','" + Tgl_transaksi.ToShortDateString() + "', '" + Surat_jalan + "', '" + Tgl_jatuh_tempo.ToShortDateString() + "', '"
                + NoFakturPajak + "','" + TglFakturPajak.ToShortDateString() + "','" + Status_transaksi + "','" + ExNoSPB + "','" + Tgl_SPB + "','" + KodeSuplier + "','"
                + MataUang + "'," + TotalBiaya + ",'" + Ket + "')";
            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                int rows = _sqlCommand.ExecuteNonQuery();
                ConnManager.Instance.CloseConnection();                
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
                _commandString2 = "INSERT INTO detail_pembelian VALUES ('" + No_bpb + "-" + i.ToString() + "','" + KodeItem[i] + "', '" + No_bpb + "', " 
                    + JumItem[i].ToString() + "," + HargaSatuan[i].ToString() + "," + Total[i].ToString() + ")";
                try
                {
                    ConnManager.Instance.OpenConnection();
                    _sqlCommand.CommandText = _commandString2;
                    int rows = _sqlCommand.ExecuteNonQuery();
                    ConnManager.Instance.CloseConnection();
                }
                catch (Exception e)
                {
                    ConnManager.Instance.CloseConnection();
                    return e.ToString();
                }
            }
            DataManager.Instance.RefreshDataSet("pembelian");
            Notify();
            return "Succes";
        }

        public String Update()
        {
            _commandString = "UPDATE pembelian SET no_bpb='" + No_bpb + "',tgl_transaksi='" + Tgl_transaksi.ToShortDateString() + "', surat_jalan='" + Surat_jalan + "', jatuh_tempo='" + Tgl_jatuh_tempo.ToShortDateString() 
                + "', no_faktur_pajak='" + NoFakturPajak + "',tgl_faktur_pajak='" + TglFakturPajak.ToShortDateString() + "',status_tk='" + Status_transaksi 
                + "',ex_nomer_spb='" + ExNoSPB + "',tgl_spb='" + Tgl_SPB + "',kode_suplier='" + KodeSuplier + "',mata_uang='" + MataUang + "',total_harga="
                + TotalBiaya + ",keterangan='" + Ket + "' WHERE no_bpb='" + No_bpbKey + "'";

            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                int rows = _sqlCommand.ExecuteNonQuery();
                ConnManager.Instance.CloseConnection();                
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
                _commandString2 = "UPDATE detail_pembelian SET kode_item='" + KodeItem[i] + "',jumlah_item="
                    + JumItem[i].ToString() + ",harga_satuan=" + HargaSatuan[i].ToString() + ",total=" + Total[i].ToString() +
                    " WHERE id_detail='" + No_bpbKey + "-" + i.ToString() + "'";
                try
                {
                    ConnManager.Instance.OpenConnection();
                    _sqlCommand.CommandText = _commandString2;
                    int rows = _sqlCommand.ExecuteNonQuery();
                    ConnManager.Instance.CloseConnection();
                }
                catch (Exception e)
                {
                    ConnManager.Instance.CloseConnection();
                    return e.ToString();
                }
            }
            DataManager.Instance.RefreshDataSet("pembelian");
            Notify();
            return "Succes";
        }
        

        public String Delete()
        {
            _commandString = "DELETE FROM pembelian WHERE no_bpb ='" + No_bpbKey + "'";

            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                int rows = _sqlCommand.ExecuteNonQuery();
                ConnManager.Instance.CloseConnection();
                DataManager.Instance.RefreshDataSet("pembelian");
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
            _commandString = "SELECT * FROM pembelian WHERE no_bpb ='" + No_bpbKey + "'";

            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                SqlDataReader _sqlReader = _sqlCommand.ExecuteReader();
                if (_sqlReader.Read())
                {
                    No_bpb = _sqlReader["no_bpb"].ToString();
                    Tgl_transaksi = (DateTime)_sqlReader["tgl_transaksi"];
                    Surat_jalan = _sqlReader["surat_jalan"].ToString();
                    Status_transaksi = _sqlReader["status_tk"].ToString();
                    ExNoSPB = _sqlReader["ex_nomer_spb"].ToString();
                    Tgl_SPB = (DateTime)_sqlReader["tgl_spb"];
                    KodeSuplier = _sqlReader["kode_suplier"].ToString();
                    Tgl_jatuh_tempo = (DateTime)_sqlReader["jatuh_tempo"];
                    NoFakturPajak = _sqlReader["no_faktur_pajak"].ToString();
                    TglFakturPajak = (DateTime)_sqlReader["tgl_faktur_pajak"];
                    Ket = _sqlReader["keterangan"].ToString();
                    TotalBiaya = Convert.ToDouble(_sqlReader["total_harga"]);
                    MataUang = _sqlReader["mata_uang"].ToString();

                    _sqlReader.Close();
                    _commandString = "SELECT * FROM detail_pembelian WHERE no_bpb ='" + No_bpbKey + "'";
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
            HargaSatuan.Clear();
            JumItem.Clear();
            Total.Clear();

        }

        public void Clear()
        {
            No_bpbKey = "";
            No_bpb = "";
            Tgl_transaksi = DateTime.Now;
            Surat_jalan = "";
            Status_transaksi = "";
            ExNoSPB = "";
            Tgl_SPB = DateTime.Now;
            KodeSuplier = "";
            Tgl_jatuh_tempo = DateTime.Now;
            NoFakturPajak = "";
            TglFakturPajak = DateTime.Now;
            Ket = "";
            TotalBiaya = .0;
            MataUang = "";

            ClearItem();
        }
    }
}
