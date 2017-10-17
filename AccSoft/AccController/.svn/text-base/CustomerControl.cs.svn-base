using System;
using System.Collections.Generic;
using System.Text;
using AccModelService;

namespace AccController
{
    public class CustomerControl
    {
        private CustomerModel _custmodel;

        public CustomerControl(CustomerModel C)
        {
            _custmodel = C;
        }

        private bool Valid()
        {
            bool valid = (_custmodel.KodeCust != "" &&
                _custmodel.Nm_Cust != "" && _custmodel.Almatcust != "" && _custmodel.Kota != "" &&
                _custmodel.Negara != "" && _custmodel.Notelp != "" && _custmodel.NoFax != "" &&
                _custmodel.NPWP1 != "" && _custmodel.Sales != "" && _custmodel.Matauang != "" &&
                _custmodel.Accptgdagang != "");

            return valid;
        }

        public String Add()
        {
            String message = "";
            if (Valid())
                message = _custmodel.Add();
            else
                message = "Pengisian data kurang lengkap";

            return message;
        }

        public String Update()
        {
            String message = "";
            if (Valid())
                message = _custmodel.Update();
            else
                message = "Pengisian data kurang lengkap";

            return message;
        }

        public String Delete()
        {
            String message = "";
            if (Valid())
                message = _custmodel.Delete();
            else
                message = "Pengisian data kurang lengkap";

            return message;
        }

        public String Select()
        {
            String message = "";
            message = _custmodel.Select();

            return message;
        }
 
    }
}
