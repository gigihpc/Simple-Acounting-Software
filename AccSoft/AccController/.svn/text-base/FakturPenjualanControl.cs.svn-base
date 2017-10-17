using System;
using System.Collections.Generic;
using System.Text;
using AccModelService;

namespace AccController
{
    public class FakturPenjualanControl
    {
        private FakturPenjualanModel _fPenjualanModel;

        public FakturPenjualanControl(FakturPenjualanModel Pnj)
        {
            _fPenjualanModel = Pnj;
        }

        private bool Valid()
        {
            bool valid = _fPenjualanModel.No_bpb != "";

            return valid;
        }

        public String Add()
        {
            String message = "";
            if (Valid())
            {
                message = _fPenjualanModel.Add();
                message += "-";
                message += _fPenjualanModel.AddItemToDb();
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
                message = _fPenjualanModel.Update();
                message += "-";
                message += _fPenjualanModel.UpdateItemToDb();
            }
            else
                message = "Pengisian data kurang lengkap";

            return message;
        }

        public String Delete()
        {
            String message = "";
            if (Valid())
                message = _fPenjualanModel.Delete();
            else
                message = "Pengisian data kurang lengkap";

            return message;
        }

        public String Select()
        {
            String message = "";
            message = _fPenjualanModel.Select();

            return message;
        }
    }
}
