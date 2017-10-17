using System;
using System.Collections.Generic;
using System.Text;
using AccModelService;

namespace AccController
{
    public class SuplierControl
    {
        private SuplierModel _suplierModel;

        public SuplierControl(SuplierModel s)
        {
            _suplierModel = s;
        }

        private bool Valid()
        {
            bool valid = (_suplierModel.KodeSuplier != "" && 
                _suplierModel.NamaSuplier != "" && _suplierModel.Alamat != "" && _suplierModel.Kota != "" &&
                _suplierModel.Negara != "" && _suplierModel.No_telepon != "" && _suplierModel.No_fax != "" &&
                _suplierModel.Npwp != "" && _suplierModel.Mata_uang != "" &&
                _suplierModel.Acc_hutang != "");

            return valid;
        }

        public String Add()
        {
            String message = "";
            if (Valid())
               message = _suplierModel.Add();
            else
                message = "Pengisian data kurang lengkap";

            return message;
        }

        public String Update()
        {
            String message = "";
            if (Valid())
                message = _suplierModel.Update();
            else
                message = "Pengisian data kurang lengkap";

            return message;
        }

        public String Delete()
        {
            String message = "";
            if (Valid())
                message = _suplierModel.Delete();
            else
                message = "Pengisian data kurang lengkap";

            return message;
        }

        public String Select()
        {
            String message = "";
            message = _suplierModel.Select();

            return message;
        }
      
    }
}
