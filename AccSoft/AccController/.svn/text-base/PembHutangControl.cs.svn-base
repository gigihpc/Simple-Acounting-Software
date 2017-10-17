using System;
using System.Collections.Generic;
using System.Text;
using AccModelService;

namespace AccController
{
    public class PembHutangControl
    {
        private PembHutangModel _pembModel;

        public PembHutangControl(PembHutangModel p)
        {
            _pembModel = p;
        }

        private bool Valid()
        {
            return (_pembModel.NoBukti != "" && _pembModel.JumPembayaran != .0 && _pembModel.Uraian != "");
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
