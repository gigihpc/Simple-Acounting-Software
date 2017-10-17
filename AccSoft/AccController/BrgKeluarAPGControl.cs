using System;
using System.Collections.Generic;
using System.Text;
using AccModelService;

namespace AccController
{
    public class BrgKeluarAPGControl
    {
        private BrgKeluarAPGModel _keluarAPGModel;

        public BrgKeluarAPGControl(BrgKeluarAPGModel _K)
        {
            _keluarAPGModel = _K;
        }

        private bool Valid()
        {
            bool valid = (_keluarAPGModel.kodeNoBukti != "" &&
                _keluarAPGModel.kode_gudang != "" && _keluarAPGModel.jns_mutasi != "" 
                && _keluarAPGModel.KodeCust!="");

            return valid;
        }

        public String Add()
        {
            String message = "";
            if (Valid())
                message = _keluarAPGModel.Add();
            else
                message = "Pengisian data kurang lengkap";

            return message;
        }

        public String Update()
        {
            String message = "";
            if (Valid())
                message = _keluarAPGModel.Update();
            else
                message = "Pengisian data kurang lengkap";

            return message;
        }

        public String Delete()
        {
            String message = "";
            if (Valid())
                message = _keluarAPGModel.Delete();
            else
                message = "Pengisian data kurang lengkap";

            return message;
        }

        public String Select()
        {
            String message = "";
            message = _keluarAPGModel.Select();

            return message;
        }
    }
}
