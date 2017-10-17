using System;
using System.Collections.Generic;
using System.Text;
using AccModelService;

namespace AccController
{
    public class PembayaranPiutangControl
    {
        private PembayaranPiutangModel _piutangModel;

        public PembayaranPiutangControl(PembayaranPiutangModel P)
        {
            _piutangModel = P;
        }

        private bool Valid()
        {
            return (_piutangModel.NoBukti != "" && _piutangModel.JumPembayaran != .0 && _piutangModel.Uraian != "");
        }

        public String Add()
        {
            String message = "";
            if (Valid())
            {
                message = _piutangModel.Add();
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
                message = _piutangModel.Update();
            }
            else
                message = "Pengisian data kurang lengkap";

            return message;
        }

        public String Delete()
        {
            String message = "";
            if (Valid())
                message = _piutangModel.Delete();
            else
                message = "Pengisian data kurang lengkap";

            return message;
        }

        public String Select()
        {
            String message = "";
            message = _piutangModel.Select();

            return message;
        }
    }
}
