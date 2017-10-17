using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace AccModelService
{
   public class GudangModel : DataModel
    {
       private SqlCommand _sqlCommand;
       private String _commandString;

       public GudangModel()
       {
           _sqlCommand = ConnManager.Instance.SqlConnection.CreateCommand();
       }

       public String kodeGudangKey = "";
       public String kodeGudang = "";
       public String diskripsi = "";
       public String lokasi = "";
       
       public String Add()
       {
           _commandString = "INSERT INTO gudang VALUES ('" + kodeGudang + "','" + diskripsi + "', '" + lokasi + "')";

           try
           {
               ConnManager.Instance.OpenConnection();
               _sqlCommand.CommandText = _commandString;
               int rows = _sqlCommand.ExecuteNonQuery();
               ConnManager.Instance.CloseConnection();
               DataManager.Instance.RefreshDataSet("gudang");
               Notify();
               Clear();
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
           _commandString = "UPDATE gudang SET deskripsi='" + diskripsi + "', lokasi='" + lokasi + "'"
               + "WHERE kode_gudang ='" + kodeGudangKey + "'";

           try
           {
               ConnManager.Instance.OpenConnection();
               _sqlCommand.CommandText = _commandString;
               int rows = _sqlCommand.ExecuteNonQuery();
               ConnManager.Instance.CloseConnection();
               DataManager.Instance.RefreshDataSet("gudang");
               Notify();
               Clear();
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
           _commandString = "DELETE FROM gudang WHERE kode_gudang ='" + kodeGudangKey + "'";

           try
           {
               ConnManager.Instance.OpenConnection();
               _sqlCommand.CommandText = _commandString;
               int rows = _sqlCommand.ExecuteNonQuery();
               ConnManager.Instance.CloseConnection();
               DataManager.Instance.RefreshDataSet("gudang");
               Notify();
               Clear();
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
           _commandString = "SELECT * FROM gudang WHERE kode_gudang ='" + kodeGudangKey + "'";

           try
           {
               ConnManager.Instance.OpenConnection();
               _sqlCommand.CommandText = _commandString;
               SqlDataReader _sqlReader = _sqlCommand.ExecuteReader();
               if (_sqlReader.Read())
               {
                   kodeGudang= _sqlReader["kode_gudang"].ToString();
                   diskripsi = _sqlReader["deskripsi"].ToString();
                   lokasi = _sqlReader["lokasi"].ToString();
               }
               ConnManager.Instance.CloseConnection();
               //DataManager.Instance.RefreshDataSet("Customer");
               Notify();
               return kodeGudang + " has been selected";
           }
           catch (Exception e)
           {
               ConnManager.Instance.CloseConnection();
               return e.ToString();
           }
       }

       public void Clear()
       {
           kodeGudangKey = "";
           kodeGudang = "";
           diskripsi = "";
           lokasi = "";
       }
    }
}
