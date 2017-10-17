using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace AccModelService
{
    public class KodePerkiraanModel : DataModel
    {
        private SqlCommand _sqlCommand;
        private String _commandString;

        public String KodeAcc = "";
        public String KodeAccKey = "";
        public String NamaAkun = "";
        public String StatusNR = "";
        public String StatusDK = "";
        public String Hpp = "";

        public KodePerkiraanModel()
        {
            _sqlCommand = ConnManager.Instance.SqlConnection.CreateCommand();
        }

        public String Add()
        {
            _commandString = "INSERT INTO kode_perkiraan VALUES ('" + KodeAcc + "','" + NamaAkun + "', '" +StatusNR
                + "', '" + StatusDK + "','" + Hpp + "')";
            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                int rows = _sqlCommand.ExecuteNonQuery();
                ConnManager.Instance.CloseConnection();
                DataManager.Instance.RefreshDataSet("kode_perkiraan");
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
            _commandString = "UPDATE kode_perkiraan SET kode_acc='" + KodeAcc + "',nama_account='" + NamaAkun + "', status_nr='" + StatusNR 
                + "', status_dk='" + StatusDK
                + "',hpp ='" + Hpp + "' WHERE kode_acc ='" + KodeAccKey + "'";
            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                int rows = _sqlCommand.ExecuteNonQuery();
                ConnManager.Instance.CloseConnection();
                DataManager.Instance.RefreshDataSet("kode_perkiraan");
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
            _commandString = "DELETE FROM kode_perkiraan WHERE kode_acc ='" + KodeAccKey + "'";

            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                int rows = _sqlCommand.ExecuteNonQuery();
                ConnManager.Instance.CloseConnection();
                DataManager.Instance.RefreshDataSet("kode_perkiraan");
                Clear();
                Notify();
                return KodeAccKey + " rows has been deleted";
            }
            catch (Exception e)
            {
                ConnManager.Instance.CloseConnection();
                return e.ToString();
            }
        }

        public String Select()
        {
            _commandString = "SELECT * FROM kode_perkiraan WHERE kode_acc ='" + KodeAccKey + "'";

            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                SqlDataReader _sqlReader = _sqlCommand.ExecuteReader();
                if (_sqlReader.Read())
                {
                    KodeAcc = _sqlReader["kode_acc"].ToString();
                    NamaAkun = _sqlReader["nama_account"].ToString();
                    StatusNR = _sqlReader["status_nr"].ToString();
                    StatusDK = _sqlReader["status_dk"].ToString();
                    Hpp = _sqlReader["hpp"].ToString();
                }                  
                ConnManager.Instance.CloseConnection();
                Notify();
                return KodeAcc + " has been selected";
            }
            catch (Exception e)
            {
                ConnManager.Instance.CloseConnection();
                return e.ToString();
            }
        }

        public void Clear()
        {
          KodeAcc = "";
          KodeAccKey = "";
          NamaAkun = "";
          StatusNR = "";
          StatusDK = "";
          Hpp = "";
      

        }

    }
}
