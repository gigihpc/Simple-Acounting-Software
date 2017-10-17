using System;
using System.Collections.Generic;
using System.Text;
using AccModelService;

namespace AccController
{
    public class KodePerkiraanControl
    {
        private KodePerkiraanModel _kodePerkiraan;

        public KodePerkiraanControl(KodePerkiraanModel p)
        {
            _kodePerkiraan = p;
        }

        private bool Valid()
        {
            return (_kodePerkiraan.KodeAcc != "" && _kodePerkiraan.NamaAkun!= ""
                && _kodePerkiraan.StatusDK != "" && _kodePerkiraan.StatusNR != ""
                && _kodePerkiraan.Hpp != "");
        }

        public String Add()
        {
            String message = "";
            if (Valid())
            {
                message = _kodePerkiraan.Add();
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
                message = _kodePerkiraan.Update();
            }
            else
                message = "Pengisian data kurang lengkap";

            return message;
        }

        public String Delete()
        {
            String message = "";
            if (Valid())
                message = _kodePerkiraan.Delete();
            else
                message = "Pengisian data kurang lengkap";

            return message;
        }

        public String Select()
        {
            String message = "";
            message = _kodePerkiraan.Select();

            return message;
        }

    }
}
