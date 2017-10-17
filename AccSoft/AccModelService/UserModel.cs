using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace AccModelService
{
   public class UserModel : DataModel
    {
        private SqlCommand _sqlCommand;
        private String _commandString;

       public UserModel()
       {
           _sqlCommand = ConnManager.Instance.SqlConnection.CreateCommand();
       }

       public String kodeUserKey = "";
       public String kodeUser = "";
       public String namaUser = "";
       public String password = "";
       public String jabatan = "";
       public String status = "";

       public String Add()
       {
           _commandString = "INSERT INTO user_acc VALUES ('" + kodeUser + "','" + namaUser + "', '" + password + "', '" + jabatan + "', '"
               + status +"')";

           try
           {
               ConnManager.Instance.OpenConnection();
               _sqlCommand.CommandText = _commandString;
               int rows = _sqlCommand.ExecuteNonQuery();
               ConnManager.Instance.CloseConnection();
               DataManager.Instance.RefreshDataSet("user_acc");
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
           _commandString = "UPDATE user_acc SET nama_pengguna='" + namaUser + "', katakunci='" + password + "', jabatan='" + jabatan
               + "', status='" + status + "'"
               + "WHERE id_pengguna ='" + kodeUserKey + "'";

           try
           {
               ConnManager.Instance.OpenConnection();
               _sqlCommand.CommandText = _commandString;
               int rows = _sqlCommand.ExecuteNonQuery();
               ConnManager.Instance.CloseConnection();
               DataManager.Instance.RefreshDataSet("user_acc");
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
           _commandString = "DELETE FROM user_acc WHERE id_pengguna ='" + kodeUserKey + "'";

           try
           {
               ConnManager.Instance.OpenConnection();
               _sqlCommand.CommandText = _commandString;
               int rows = _sqlCommand.ExecuteNonQuery();
               ConnManager.Instance.CloseConnection();
               DataManager.Instance.RefreshDataSet("user_acc");
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
           _commandString = "SELECT * FROM user_acc WHERE id_pengguna ='" + kodeUserKey + "'";

           try
           {
               ConnManager.Instance.OpenConnection();
               _sqlCommand.CommandText = _commandString;
               SqlDataReader _sqlReader = _sqlCommand.ExecuteReader();
               if (_sqlReader.Read())
               {
                   kodeUser= _sqlReader["id_pengguna"].ToString();
                   namaUser = _sqlReader["nama_pengguna"].ToString();
                   password = _sqlReader["katakunci"].ToString();
                   jabatan = _sqlReader["jabatan"].ToString();
                   status = _sqlReader["status"].ToString();
               }
               ConnManager.Instance.CloseConnection();
               //DataManager.Instance.RefreshDataSet("Customer");
               Notify();
               return kodeUser + " has been selected";
           }
           catch (Exception e)
           {
               ConnManager.Instance.CloseConnection();
               return e.ToString();
           }
       }

       public void Clear()
       {
           kodeUserKey = "";
           kodeUser = "";
           namaUser = "";
           password = "";
           jabatan = "";
           //status = "";

       }
    }
}
