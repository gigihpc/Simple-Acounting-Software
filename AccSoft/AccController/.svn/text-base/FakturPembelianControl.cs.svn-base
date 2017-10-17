using System;
using System.Collections.Generic;
using System.Text;
using AccModelService;

namespace AccController
{
    public class FakturPembelianControl
    {
        private FakturPembelianModel fakturPembelianModel;

        public FakturPembelianControl(FakturPembelianModel f)
        {
            fakturPembelianModel = f;
        }

        private bool Valid()
        {
            bool valid = fakturPembelianModel.No_bpb != "";

            return valid;
        }

        public String Add()
        {
            String message = "";
            if (Valid())
            {
                message = fakturPembelianModel.Add();
                message += "-";
                message += fakturPembelianModel.AddItemToDb();
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
                message = fakturPembelianModel.Update();
                message += "-";
                message += fakturPembelianModel.UpdateItemToDb();
            }
            else
                message = "Pengisian data kurang lengkap";

            return message;
        }
      
        public String Delete()
        {
            String message = "";
            if (Valid())
                message = fakturPembelianModel.Delete();
            else
                message = "Pengisian data kurang lengkap";

            return message;
        }

        public String Select()
        {
            String message = "";
            message = fakturPembelianModel.Select();

            return message;
        }
    }
}
