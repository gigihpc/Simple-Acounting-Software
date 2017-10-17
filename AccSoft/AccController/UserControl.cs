using System;
using System.Collections.Generic;
using System.Text;
using AccModelService;

namespace AccController
{
   public class User_Control
    {
        private UserModel _userModel;

       public User_Control(UserModel U)
       {
           _userModel = U;
       }

       private bool Valid()
       {
           bool valid = (_userModel.kodeUser != "" &&
               _userModel.namaUser != "" && _userModel.password != "" && _userModel.jabatan != "" &&
               _userModel.status != "");

           return valid;
       }

       public String Add()
       {
           String message = "";
           if (Valid())
               message = _userModel.Add();
           else
               message = "Pengisian data kurang lengkap";

           return message;
       }

       public String Update()
       {
           String message = "";
           if (Valid())
               message = _userModel.Update();
           else
               message = "Pengisian data kurang lengkap";

           return message;
       }

       public String Delete()
       {
           String message = "";
           if (Valid())
               message = _userModel.Delete();
           else
               message = "Pengisian data kurang lengkap";

           return message;
       }

       public String Select()
       {
           String message = "";
           message = _userModel.Select();

           return message;
       }
    }
}
