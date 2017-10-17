using System;
using System.Collections.Generic;
using System.Text;
using AccModelService;

namespace AccController
{
    public class BrgMasukAPGControl
    {
        private BrgMasukAPGModel _masukAPG;

        public BrgMasukAPGControl(BrgMasukAPGModel B)
        {
            _masukAPG = B;
        }

        private bool Valid()
        {
            bool valid = (_masukAPG.kodeNoBukti != "" &&
                _masukAPG.kode_gudang != "" && _masukAPG.jns_mutasi!="");

            return valid;
        }

        public String Add()
        {
            String message = "";
            if (Valid())
                message = _masukAPG.Add();
            else
                message = "Pengisian data kurang lengkap";

            return message;
        }

        public String Update()
        {
            String message = "";
            if (Valid())
                message = _masukAPG.Update();
            else
                message = "Pengisian data kurang lengkap";

            return message;
        }

        public String Delete()
        {
            String message = "";
            if (Valid())
                message = _masukAPG.Delete();
            else
                message = "Pengisian data kurang lengkap";

            return message;
        }

        public String Select()
        {
            String message = "";
            message = _masukAPG.Select();

            return message;
        }
    }
}
