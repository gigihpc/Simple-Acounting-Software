using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace AccModelService
{
   public class MatauangModel : DataModel
    {
       private SqlCommand _sqlCommand;
        private String _commandString;

       public MatauangModel()
       {
           _sqlCommand = ConnManager.Instance.SqlConnection.CreateCommand();
       }

       public String MatauangKey = "";
       public String Matauang = "";
       public double KursIDR = .0;
       
       public String Add()
       {
           _commandString = "INSERT INTO kurs_uang VALUES ('" + Matauang + "','" + KursIDR + "')";

           try
           {
               ConnManager.Instance.OpenConnection();
               _sqlCommand.CommandText = _commandString;
               int rows = _sqlCommand.ExecuteNonQuery();
               ConnManager.Instance.CloseConnection();
               DataManager.Instance.RefreshDataSet("kurs_uang");
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
           _commandString = "UPDATE kurs_uang SET kurs_thd_IDR='" + KursIDR + "'"
               + "WHERE mata_uang ='" + MatauangKey + "'";

           try
           {
               ConnManager.Instance.OpenConnection();
               _sqlCommand.CommandText = _commandString;
               int rows = _sqlCommand.ExecuteNonQuery();
               ConnManager.Instance.CloseConnection();
               DataManager.Instance.RefreshDataSet("kurs_uang");
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
           _commandString = "DELETE FROM kurs_uang WHERE mata_uang ='" + MatauangKey + "'";

           try
           {
               ConnManager.Instance.OpenConnection();
               _sqlCommand.CommandText = _commandString;
               int rows = _sqlCommand.ExecuteNonQuery();
               ConnManager.Instance.CloseConnection();
               DataManager.Instance.RefreshDataSet("kurs_uang");
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
           _commandString = "SELECT * FROM kurs_uang WHERE mata_uang ='" + MatauangKey + "'";

           try
           {
               ConnManager.Instance.OpenConnection();
               _sqlCommand.CommandText = _commandString;
               SqlDataReader _sqlReader = _sqlCommand.ExecuteReader();
               if (_sqlReader.Read())
               {
                   Matauang = _sqlReader["mata_uang"].ToString();
                   KursIDR = Convert.ToDouble(_sqlReader["kurs_thd_IDR"].ToString());
               }
               ConnManager.Instance.CloseConnection();
               //DataManager.Instance.RefreshDataSet("Customer");
               Notify();
               return Matauang + " has been selected";
           }
           catch (Exception e)
           {
               ConnManager.Instance.CloseConnection();
               return e.ToString();
           }
       }

       public void Clear()
       {
           MatauangKey = "";
           Matauang = "";
           KursIDR = 0;
       }
        
    }
}
