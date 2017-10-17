using System;
using System.Collections.Generic;
using System.Text;
using AccModelService;

namespace AccController
{
   public class ItemControl
    {
       private ItemModel _itemModel;

       public ItemControl(ItemModel I)
       {
           _itemModel = I;
       }

       private bool Valid()
       {
           bool valid = (_itemModel.kodeItem != "" &&
               _itemModel.namaItem != "" && _itemModel.grupItem != "" && _itemModel.status != "" &&
               _itemModel.Unit != "" && _itemModel.minStok != 0 && _itemModel.jumStok != 0 &&
               _itemModel.hrgJual != 0 && _itemModel.hrgBeli != 0 && _itemModel.ppn != "" &&
               _itemModel.persediaan != "" && _itemModel.hpp != "");

           return valid;
       }

       public String Add()
       {
           String message = "";
           if (Valid())
               message = _itemModel.Add();
           else
               message = "Pengisian data kurang lengkap";

           return message;
       }

       public String Update()
       {
           String message = "";
           if (Valid())
               message = _itemModel.Update();
           else
               message = "Pengisian data kurang lengkap";

           return message;
       }

       public String Delete()
       {
           String message = "";
           if (Valid())
               message = _itemModel.Delete();
           else
               message = "Pengisian data kurang lengkap";

           return message;
       }

       public String Select()
       {
           String message = "";
           message = _itemModel.Select();

           return message;
       }
 
    }
}
