using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace AccModelService
{
    public class SuplierModel : DataModel
    {
        private SqlCommand _sqlCommand;
        private String _commandString;

        public SuplierModel()
        {
            _sqlCommand = ConnManager.Instance.SqlConnection.CreateCommand();
        }

        private String kodeSuplierKey = "";
        public String KodeSuplierKey
        {
            get { return kodeSuplierKey; }
            set { kodeSuplierKey = value; }
        }

        private String kodeSuplier = "";
        public String KodeSuplier
        {
            get { return kodeSuplier; }
            set { kodeSuplier = value; }
        }
        
        private String namaSuplier = "";
        public String NamaSuplier
        {
            get { return namaSuplier; }
            set { namaSuplier = value; }
        }

        private String alamat = "";
        public String Alamat
        {
            get { return alamat; }
            set { alamat = value; }
        }

        private String kota = "";
        public String Kota
        {
            get { return kota; }
            set { kota = value; }
        }

        private String negara = "";
        public String Negara
        {
            get { return negara; }
            set { negara = value; }
        }

        private String no_telepon = "";
        public String No_telepon
        {
            get { return no_telepon; }
            set { no_telepon = value; }
        }

        private String no_fax = "";
        public String No_fax
        {
            get { return no_fax; }
            set { no_fax = value; }
        }

        private String key_person = "";
        public String Key_person
        {
            get { return key_person; }
            set { key_person = value; }
        }

        private int syarat_kredit = 0;
        public int Syarat_kredit
        {
            get { return syarat_kredit; }
            set { syarat_kredit = value; }
        }

        private double limit_kredit = .0;
        public double Limit_kredit
        {
            get { return limit_kredit; }
            set { limit_kredit = value; }
        }

        private String npwp = "";
        public String Npwp
        {
            get { return npwp; }
            set { npwp = value; }
        }

        private String daerah = "";
        public String Daerah
        {
            get { return daerah; }
            set { daerah = value; }
        }

        private String mata_uang = "";
        public String Mata_uang
        {
            get { return mata_uang; }
            set { mata_uang = value; }
        }

        private String acc_hutang = "";
        public String Acc_hutang
        {
            get { return acc_hutang; }
            set { acc_hutang = value; }
        }

        public String Add()
        {
            _commandString = "INSERT INTO suplier VALUES ('"+ kodeSuplier +"','"+ namaSuplier +"', '" + alamat +"', '"+ kota +"', '"
                + negara +"','"+ no_telepon +"','"+ no_fax +"','"+ key_person +"',"+ syarat_kredit.ToString() +","+ limit_kredit.ToString() +",'"
                + npwp +"','"+ mata_uang +" ','"+ acc_hutang +"')";

            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                int rows = _sqlCommand.ExecuteNonQuery();
                ConnManager.Instance.CloseConnection();
                DataManager.Instance.RefreshDataSet("suplier");
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
            _commandString = "UPDATE suplier SET kode_suplier='" + kodeSuplier + "',nama_suplier='" + namaSuplier + "', alamat='" + alamat + "', kota='" + kota 
                + "', negara='" + negara + "', no_telepon='" + no_telepon + "', no_fax='" + no_fax + "', key_person='" + key_person + "', syarat_kredit=" + syarat_kredit.ToString()
                + ",limit_kredit=" + limit_kredit.ToString() + ",npwp='" + npwp + "',mata_uang='" + mata_uang + " ',acc_hutang_dagang='" + acc_hutang + "'"
                + "WHERE kode_suplier ='"+ kodeSuplierKey +"'";

            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                int rows = _sqlCommand.ExecuteNonQuery();
                ConnManager.Instance.CloseConnection();
                DataManager.Instance.RefreshDataSet("suplier");
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
            _commandString = "DELETE FROM suplier WHERE kode_suplier ='" + kodeSuplierKey + "'";

            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                int rows = _sqlCommand.ExecuteNonQuery();
                ConnManager.Instance.CloseConnection();
                DataManager.Instance.RefreshDataSet("suplier");
                Clear();
                Notify();
                return rows.ToString() + " rows has been deleted";               
            }
            catch (Exception e)
            {
                ConnManager.Instance.CloseConnection();
                return e.ToString();
            }           
        }

        public String Select()
        {
            _commandString = "SELECT * FROM suplier WHERE kode_suplier ='" + kodeSuplierKey + "'";

            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                SqlDataReader _sqlReader = _sqlCommand.ExecuteReader();
                if (_sqlReader.Read())
                {
                    KodeSuplier = _sqlReader["kode_suplier"].ToString();
                    NamaSuplier = _sqlReader["nama_suplier"].ToString();
                    Alamat = _sqlReader["alamat"].ToString();
                    Kota = _sqlReader["kota"].ToString();
                    Negara = _sqlReader["negara"].ToString();
                    No_telepon = _sqlReader["no_telepon"].ToString();
                    No_fax = _sqlReader["no_fax"].ToString();
                    Key_person = _sqlReader["key_person"].ToString();
                    Syarat_kredit = Convert.ToInt32(_sqlReader["syarat_kredit"]);
                    Limit_kredit = Convert.ToDouble(_sqlReader["limit_kredit"]);
                    Npwp = _sqlReader["npwp"].ToString();
                    Mata_uang = _sqlReader["mata_uang"].ToString();
                    Acc_hutang = _sqlReader["acc_hutang_dagang"].ToString();
                }
                ConnManager.Instance.CloseConnection();
                Notify();
                return kodeSuplier + "rows has been selected";
            }
            catch (Exception e)
            {
                ConnManager.Instance.CloseConnection();
                return e.ToString();
            }
        }

        public void Clear()
        {
            kodeSuplierKey = "";
            kodeSuplier = "";
            namaSuplier = "";
            alamat = "";
            kota = "";
            negara = "";
            no_telepon = "";
            no_fax = "";
            key_person = "";
            syarat_kredit = 0;
            limit_kredit = .0;
            npwp = "";
            daerah = "";
            mata_uang = "";
            acc_hutang = "";
        }
    }
}
