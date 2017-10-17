using System;
using System.Collections.Generic;
using System.Text;
using AccModelService;

namespace AccController
{
    public class GudangControl
    {
        private GudangModel _gudangModel;

        public GudangControl(GudangModel G)
        {
            _gudangModel = G;
        }

        private bool Valid()
        {
            bool valid = (_gudangModel.kodeGudang != "" &&
                _gudangModel.diskripsi != "" && _gudangModel.lokasi != "");

            return valid;
        }

        public String Add()
        {
            String message = "";
            if (Valid())
                message = _gudangModel.Add();
            else
                message = "Pengisian data kurang lengkap";

            return message;
        }

        public String Update()
        {
            String message = "";
            if (Valid())
                message = _gudangModel.Update();
            else
                message = "Pengisian data kurang lengkap";

            return message;
        }

        public String Delete()
        {
            String message = "";
            if (Valid())
                message = _gudangModel.Delete();
            else
                message = "Pengisian data kurang lengkap";

            return message;
        }

        public String Select()
        {
            String message = "";
            message = _gudangModel.Select();

            return message;
        }
    }
}
