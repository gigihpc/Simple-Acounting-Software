using System;
using System.Collections.Generic;
using System.Text;
using AccModelService;

namespace AccController
{
    public class CNPembelianCOntrol
    {
        private CNPembelianModel _pembModel;

        public CNPembelianCOntrol(CNPembelianModel p)
        {
            _pembModel = p;
        }

        private bool Valid()
        {
            return (_pembModel.NoBukti != "" && _pembModel.JumCnDn != .0 && _pembModel.Ket != "");
        }

        public String Add()
        {
            String message = "";
            if (Valid())
            {
                message = _pembModel.Add();               
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
                message = _pembModel.Update();
            }
            else
                message = "Pengisian data kurang lengkap";

            return message;
        }

        public String Delete()
        {
            String message = "";
            if (Valid())
                message = _pembModel.Delete();
            else
                message = "Pengisian data kurang lengkap";

            return message;
        }

        public String Select()
        {
            String message = "";
            message = _pembModel.Select();

            return message;
        }




    }
}
