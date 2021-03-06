using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace AccModelService
{
    public class LoginModel
    {
        private SqlCommand _sqlCommand;
        private String _commandString;

        public LoginModel()
        {
            _sqlCommand = ConnManager.Instance.SqlConnection.CreateCommand();
        }

        public Boolean statusLogin(string user, string password)
        {
            user = user.ToString();
            password = password.ToString();

            if (ConnManager.Instance.OpenConnection() == 1)
            {
                _commandString = "select nama_pengguna,katakunci from user_acc where nama_pengguna='"+ user +"'";
                _sqlCommand.CommandText = _commandString;
                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    if ((reader.GetString(0).ToString() == user) && (reader.GetString(1).ToString() == password))
                    {
                        ConnManager.Instance.CloseConnection();
                        return true;
                    }
                }               
            }
            
            return false;
        }

        public Boolean LoginServer(string server, string namadb, string user, string password)
        {
            server = server.ToString();
            namadb = namadb.ToString();
            user = user.ToString();
            password = password.ToString();

            ConnManager.Instance.SetConnString(server, namadb, user, password);
            if (ConnManager.Instance.CheckConnection() == 1)
                return true;
            else
                return false;
        }
    }
}
