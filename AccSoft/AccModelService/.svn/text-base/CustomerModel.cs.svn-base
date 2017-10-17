using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace AccModelService
{
    public class CustomerModel : DataModel
    {
        private SqlCommand _sqlCommand;
        private String _commandString;

        public CustomerModel()
        {
            _sqlCommand = ConnManager.Instance.SqlConnection.CreateCommand();
        }

        private String kodeCustKey = "";

        public String KodeCustKey
        {
            get { return kodeCustKey; }
            set { kodeCustKey = value; }
        }
        private String kodeCust = "";

        public String KodeCust
        {
            get { return kodeCust; }
            set { kodeCust = value; }
        }
        private String nm_Cust = "";

        public String Nm_Cust
        {
            get { return nm_Cust; }
            set { nm_Cust = value; }
        }
        private String almatcust = "";

        public String Almatcust
        {
            get { return almatcust; }
            set { almatcust = value; }
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
        private String notelp = "";

        public String Notelp
        {
            get { return notelp; }
            set { notelp = value; }
        }
        private String noFax = "";

        public String NoFax
        {
            get { return noFax; }
            set { noFax = value; }
        }
        private String keyperson = "";

        public String Keyperson
        {
            get { return keyperson; }
            set { keyperson = value; }
        }
        private int syrtKredit =0;

        public int SyrtKredit
        {
            get { return syrtKredit; }
            set { syrtKredit = value; }
        }
        private double lmtKredit = 0;

        public double LmtKredit
        {
            get { return lmtKredit; }
            set { lmtKredit = value; }
        }
        private String NPWP = "";

        public String NPWP1
        {
            get { return NPWP; }
            set { NPWP = value; }
        }
        private String sales = "";

        public String Sales
        {
            get { return sales; }
            set { sales = value; }
        }
        private String daerah = "";

        public String Daerah
        {
            get { return daerah; }
            set { daerah = value; }
        }
        private String matauang = "";

        public String Matauang
        {
            get { return matauang; }
            set { matauang = value; }
        }
        private String accptgdagang = "";

        public String Accptgdagang
        {
            get { return accptgdagang; }
            set { accptgdagang = value; }
        }

        public String Add()
        {
            _commandString = "INSERT INTO customer VALUES ('" + kodeCust + "','" + nm_Cust + "', '" + almatcust + "', '" + kota + "', '"
                + negara + "','" + notelp + "','" + noFax + "','" + keyperson + "'," + syrtKredit.ToString() + "," + lmtKredit.ToString() + ",'"
                + NPWP + "','" + sales + "','" + daerah + "','" + matauang + " ','" + accptgdagang + "')";

            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                int rows = _sqlCommand.ExecuteNonQuery();
                ConnManager.Instance.CloseConnection();
                DataManager.Instance.RefreshDataSet("customer");
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
            _commandString = "UPDATE customer SET nama_customer='" + nm_Cust + "', alamat='" + almatcust + "', kota='" + kota
                + "', negara='" + negara + "', no_telepon='" + notelp + "', no_fax='" + noFax + "', key_person='" + keyperson + "', syarat_kredit=" + syrtKredit.ToString()
                + ",limit_kredit=" + lmtKredit.ToString() + ",npwp='" + NPWP + "',salesman='" + sales +"',daerah='" + daerah + "',mata_uang='" + matauang + " ',acc_piutang_dagang='" + accptgdagang + "'"
                + "WHERE kode_customer ='" + kodeCustKey + "'";

            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                int rows = _sqlCommand.ExecuteNonQuery();
                ConnManager.Instance.CloseConnection();
                DataManager.Instance.RefreshDataSet("Customer");
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
            _commandString = "DELETE FROM customer WHERE kode_customer ='" + kodeCustKey + "'";

            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                int rows = _sqlCommand.ExecuteNonQuery();
                ConnManager.Instance.CloseConnection();
                DataManager.Instance.RefreshDataSet("Customer");
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
            _commandString = "SELECT * FROM customer WHERE kode_customer ='" + kodeCustKey + "'";

            try
            {
                ConnManager.Instance.OpenConnection();
                _sqlCommand.CommandText = _commandString;
                SqlDataReader _sqlReader = _sqlCommand.ExecuteReader();
                if (_sqlReader.Read())
                {
                    KodeCust = _sqlReader["kode_customer"].ToString();
                    Nm_Cust = _sqlReader["nama_customer"].ToString();
                    Almatcust = _sqlReader["alamat"].ToString();
                    Kota = _sqlReader["kota"].ToString();
                    Negara = _sqlReader["negara"].ToString();
                    Notelp = _sqlReader["no_telepon"].ToString();
                    NoFax = _sqlReader["no_fax"].ToString();
                    Keyperson = _sqlReader["key_person"].ToString();
                    SyrtKredit = Convert.ToInt32(_sqlReader["syarat_kredit"]);
                    LmtKredit = Convert.ToDouble(_sqlReader["limit_kredit"]);
                    NPWP1 = _sqlReader["npwp"].ToString();
                    Daerah = _sqlReader["daerah"].ToString();
                    Sales = _sqlReader["salesman"].ToString();
                    Matauang = _sqlReader["mata_uang"].ToString();
                    Accptgdagang = _sqlReader["acc_piutang_dagang"].ToString();
                }
                ConnManager.Instance.CloseConnection();
                //DataManager.Instance.RefreshDataSet("Customer");
                Notify();
                return kodeCust + " has been selected";
            }
            catch (Exception e)
            {
                ConnManager.Instance.CloseConnection();
                return e.ToString();
            }
        }

        public void Clear()
        {
            KodeCustKey = "";
            KodeCust = "";
            nm_Cust = "";
            Almatcust = "";
            Kota = "";
            Negara = "";
            Notelp = "";
            NoFax = "";
            Keyperson = "";
            SyrtKredit = 0;
            LmtKredit = .0;
            NPWP1 = "";
            Daerah = "";
            Sales = "";
            Matauang = "";
            Accptgdagang = "";
            //Notify();
        }

    }
}
