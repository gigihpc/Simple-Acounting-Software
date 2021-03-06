using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace AccModelService
{
   public class ItemModel : DataModel
    {
       private SqlCommand _sqlCommand;
       private String _commandString;

        public ItemModel()
        {
            _sqlCommand = ConnManager.Instance.SqlConnection.CreateCommand();
        }

       public String kodeItemKey = "";
       public String kodeItem = "";
       public String kodeGudang = "";
       public String namaItem = "";
       public String grupItem = "";
       public String status = "";
       public String Unit = "";
       public double minStok = .0;
       public double jumStok = .0;
       public int hrgJual = 0;
       public int hrgBeli = 0;
       public String ppn = "";
       public String persediaan = "";
       public String hpp = "";

       public String Add()
       {
           _commandString = "INSERT INTO item VALUES ('" + kodeItem + "','" + namaItem + "', '" + grupItem + "', '" + status + "', '"
               + Unit + "'," + minStok + "," + jumStok + "," + hrgJual + "," + hrgBeli + ",'" + ppn + "','"
               + persediaan + "','" + hpp + "','" + kodeGudang + "')";

           try
           {
               ConnManager.Instance.OpenConnection();
               _sqlCommand.CommandText = _commandString;
               int rows = _sqlCommand.ExecuteNonQuery();
               ConnManager.Instance.CloseConnection();
               DataManager.Instance.RefreshDataSet("Item");
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
           _commandString = "UPDATE item SET nama_Item='" + namaItem + "', grup_item='" + grupItem + "', status='" + status
               + "', unit='" + Unit + "', minimum_stok=" + minStok + ", jum_stok='" + jumStok + "', harga_jual_std=" + hrgJual + ", harga_beli_std=" + hrgBeli
               + ",ppn_bm='" + ppn + "',acc_persedian='" + persediaan + "',acc_hpp='" + hpp + "',kode_gudang='" + kodeGudang + "'"
               + "WHERE kode_item ='" + kodeItemKey + "'";

           try
           {
               ConnManager.Instance.OpenConnection();
               _sqlCommand.CommandText = _commandString;
               int rows = _sqlCommand.ExecuteNonQuery();
               ConnManager.Instance.CloseConnection();
               DataManager.Instance.RefreshDataSet("Customer");
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
           _commandString = "DELETE FROM item WHERE kode_item ='" + kodeItemKey + "'";

           try
           {
               ConnManager.Instance.OpenConnection();
               _sqlCommand.CommandText = _commandString;
               int rows = _sqlCommand.ExecuteNonQuery();
               ConnManager.Instance.CloseConnection();
               DataManager.Instance.RefreshDataSet("Customer");
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
           _commandString = "SELECT * FROM item WHERE kode_item ='" + kodeItemKey + "'";

           try
           {
               ConnManager.Instance.OpenConnection();
               _sqlCommand.CommandText = _commandString;
               SqlDataReader _sqlReader = _sqlCommand.ExecuteReader();
               if (_sqlReader.Read())
               {
                   kodeItem = _sqlReader["kode_item"].ToString();
                   namaItem = _sqlReader["nama_item"].ToString();
                   grupItem = _sqlReader["grup_item"].ToString();
                   status = _sqlReader["status"].ToString();
                   Unit = _sqlReader["unit"].ToString();
                   minStok = Convert.ToDouble(_sqlReader["minimum_stok"]);
                   jumStok = Convert.ToDouble(_sqlReader["jum_stok"]);
                   hrgJual = Convert.ToInt32( _sqlReader["harga_jual_std"]);
                   hrgBeli = Convert.ToInt32(_sqlReader["harga_beli_std"]);
                   persediaan = _sqlReader["acc_persedian"].ToString();
                   ppn = _sqlReader["ppn_bm"].ToString();
                   hpp = _sqlReader["acc_hpp"].ToString();
                   kodeGudang = _sqlReader["kode_gudang"].ToString();
               }
               ConnManager.Instance.CloseConnection();
               //DataManager.Instance.RefreshDataSet("Customer");
               Notify();
               return kodeItem + " has been selected";
           }
           catch (Exception e)
           {
               ConnManager.Instance.CloseConnection();
               return e.ToString();
           }
       }

       public void Clear()
       {
           kodeItemKey = "";
           kodeItem = "";
           namaItem = "";
           grupItem = "";
           status = "";
           Unit = "";
           minStok = .0;
           jumStok = .0;
           hrgJual = 0;
           hrgBeli = 0;
           ppn = "";
           persediaan = "";
           hpp = "";
           kodeGudang = "";
           //Notify();
       }
    }
}
