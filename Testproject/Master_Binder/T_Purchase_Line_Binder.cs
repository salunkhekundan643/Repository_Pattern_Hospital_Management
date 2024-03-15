using MY_Db_Hospital_Managment.Master_Model;
using MY_Db_Hospital_Managment_Interface.Master_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testproject.Master_Binder
{
    public  class T_Purchase_Line_Binder
    {

        public T_Purchase_Line_Model DataBinder()
        {
            T_Purchase_Line_Model model= new T_Purchase_Line_Model();
            model.PurchaseLineId = 0;
            model.PurchaseHedar = 1;
            model.ClientId = 1;
            model.GlobalId = 1;
            model.ItemId = 1;
            model.ItemQty = 1;
            model.ItemTotalStripQty= 1;
            model.ItemStripQty= 1;
            model.ItemPerUnitRate = 1;
            model.ItemUnit = 1;
            model.ItemRate = 1;
            model.ItemPacking = 22;
            model.TaxId = 1;
            model.GodownId = 2;
            model.BranchId = 2;
            model.DevileryDate = System.DateTime.Now;
            model.TotalAmount = 1;
            model.TaxType = 2;
            model.BasicAmount = 1;
            model.TaxAmount = 2;
            model.QualityCheck = "";
            model.BatchNO = "";
            model.BatchDate=System.DateTime.Now;
            model.ExpireDate=System.DateTime.Now;
            model.ItemMrp = 11;
            model.ItemDiscount = 21;
            model.ItemMediRate = 22;
            model.MediQty = 2;
            model.GstVat = 2;
            model.Sgst = 2;
            model.Igst = 2;
            model.MediTotalAmount = 1;
            model.CreatedBy = 2;
            model.UpdatedBy = System.DateTime.Now;
            model.CreatedDate=System.DateTime.Now;
            model.UpdatedDate=System.DateTime.Now;
            model.Attr1 = "";
            model.Attr2 = "";
            model.Attr3 = 1;
            model.Attr4 = 2;
            model.Attr5= 3;
            model.Attr6 = 2;
            model.Attr7 = 1;
            model.HsnCode = "";
            model.SachDiscount = 1;
            model.CompanyName = "";
            model.FreeQty = 2;
            model.PackingId = 1;
            model.DiscountAmount = 22;

            return model;

        }


    }
}
