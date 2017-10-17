using System;
using System.Collections.Generic;
using System.Text;
using AccModelService;

namespace AccController
{
   public class MataUangControl
    {
       private MatauangModel _uangModel;

       public MataUangControl(MatauangModel M)
       {
           _uangModel = M;
       }

       private bool Valid()
       {
           bool valid = (_uangModel.Matauang != "" &&
               _uangModel.KursIDR != 0 );

           return valid;
       }

       public String Add()
       {
           String message = "";
           if (Valid())
               message = _uangModel.Add();
           else
               message = "Pengisian data kurang lengkap";

           return message;
       }

       public String Update()
       {
           String message = "";
           if (Valid())
               message = _uangModel.Update();
           else
               message = "Pengisian data kurang lengkap";

           return message;
       }

       public String Delete()
       {
           String message = "";
           if (Valid())
               message = _uangModel.Delete();
           else
               message = "Pengisian data kurang lengkap";

           return message;
       }

       public String Select()
       {
           String message = "";
           message = _uangModel.Select();

           return message;
       }
    }
}
