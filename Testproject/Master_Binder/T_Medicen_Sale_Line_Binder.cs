using MY_Db_Hospital_Managment.Master_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testproject.Master_Binder
{
    public  class T_Medicen_Sale_Line_Binder
    {
        public T_Medicen_Sale_Line_Model DataBinder()
        {
            T_Medicen_Sale_Line_Model model= new T_Medicen_Sale_Line_Model();
            model.SaleLineId = 0;
            model.SaleHedarId = 1;
            model.PurchaseLineId = 2;
            model.ItemId = 2;
            model.ItemName = "A";
            model.ItemBatch = "A";
            model.ItemPckg = "A";
            model.ItemExpDate=System.DateTime.Now;
            model.ItemMfg = "A";
            model.ItemMfg = "A";
            model.ItemMrp = 1;
            model.ItemTotalAmount = 1;
            model.Discount = 1;
            model.PaidUnpaid = 21;
            model.Attr1 = 11;
            model.Attr2 = 1;
            model.Attr3 = "A";
            model.CreatedBy = 1;
            model.UpdatedBy = 1;
            model.CreatedDate=System.DateTime.Now;
            model.UpdatedDate=System.DateTime.Now;

            return model;

        }

    }
}
