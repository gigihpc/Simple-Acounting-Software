using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

//Singleton Pattern
namespace AccModelService
{
    public class ConnManager
    {
        //Data Source=190.190.200.100,1433;Network Library=DBMSSOCN;Initial Catalog=myDataBase;User ID=myUsername;Password=myPassword;
        private String _connString = "Data Source=(local);Initial Catalog=dbAccSoft;User ID=sa; Password=gigih";
        private SqlConnection _sqlConnection;
        private static ConnManager _instance;

        private ConnManager()
        {
            _sqlConnection = new SqlConnection(_connString);            
        }

        public SqlConnection SqlConnection
        {
            get { return _sqlConnection; }
        }

        public static ConnManager Instance
        {          
           get 
           {
               if (_instance == null)
                   _instance = new ConnManager();

               return ConnManager._instance;
           }
        }

        public int OpenConnection()
        {
            bool checkState = (_sqlConnection.State == System.Data.ConnectionState.Closed ||
                _sqlConnection.State == System.Data.ConnectionState.Broken);

            if (checkState)
            {
                try
                {
                    _sqlConnection.Open();
                    return 1;
                }
                catch 
                {
                    return 0;
                }   
            }
            else
                return 0;            
        }

        public int CloseConnection()
        {
            bool checkState = (_sqlConnection.State == System.Data.ConnectionState.Open);

            if (checkState)
            {
                try
                {
                    _sqlConnection.Close();
                    return 1;
                }
                catch
                {
                    return 0;
                }                
            }
            else
                return 0;       

        }

        public int CheckConnection()
        {
            try
            {
                _sqlConnection.Open();
                _sqlConnection.Close();
                return 1;

            }
            catch
            {
                return 0;
            }
        }

        public void SetConnString(String server, String databaseName, String userName, String userPassword)
        {
            if(server.CompareTo("(local)") == 0)
                _connString = "Data Source=(local);Initial Catalog=dbAccSoft;User ID=sa;Password=sa";
            else
                _connString = "Data Source="+ server +";Network Library=DBMSSOCN;Initial Catalog="+ databaseName +";User ID="+ userName +";Password=" + userPassword + ";";

            _sqlConnection.ConnectionString = _connString;
        }       
    }
}
