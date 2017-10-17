using System;
using System.Collections.Generic;
using System.Text;
using AccModelService;

namespace AccController
{
    public class CnDnPenjualanControl
    {
        private CnDnPenjualanModel _Cnpenjualnmodel;

        public CnDnPenjualanControl(CnDnPenjualanModel C)
        {
            _Cnpenjualnmodel = C;
        }

        private bool Valid()
        {
            return (_Cnpenjualnmodel.NoBukti != "" && _Cnpenjualnmodel.JumCnDn != .0 && _Cnpenjualnmodel.Ket != "");
        }

        public String Add()
        {
            String message = "";
            if (Valid())
            {
                message = _Cnpenjualnmodel.Add();
            }
            else
                message = "Pengisian data kurang lengkap";

            return message;
        }

        public String Update()
        {
            String message = "";
            if (Valid())
            {
                message = _Cnpenjualnmodel.Update();
            }
            else
                message = "Pengisian data kurang lengkap";

            return message;
        }

        public String Delete()
        {
            String message = "";
            if (Valid())
                message = _Cnpenjualnmodel.Delete();
            else
                message = "Pengisian data kurang lengkap";

            return message;
        }

        public String Select()
        {
            String message = "";
            message = _Cnpenjualnmodel.Select();

            return message;
        }

    }
}
