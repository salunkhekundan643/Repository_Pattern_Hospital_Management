using MY_Db_Hospital_Managment.Master_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testproject.Master_Binder
{
    public  class T_Purchase_Hedar_Binder
    {
        public T_Purchase_Hedar_Model DataBinder()
        {
            T_Purchase_Hedar_Model model = new T_Purchase_Hedar_Model();
            model.PurchaseHedarId = 0;
            model.ClientId = 1;
            model.GlobalId = 2;
            model.PurchaseDocumentNo = "";
            model.PurchaseStatus = 1;
            model.PurchaseApprovBy = 1;
            model.ApproveDate= System.DateTime.Now;
            model.PurchaseDate = System. DateTime.Now;
            model.PurchaseTotalAmount = 11;
            model.PurchaseType = 20;
            model.SupplierId = 22;
            model.PayTerms = 11;
            model.AgentId = 2;
            model.Commision = 10;
            model.CommisionAmount = 21;
            model.TotalPurchaseAmountHedar = 20;
            model.Remark = "";
            model.CreatedBy = 1;
            model.CreatedDate= System.DateTime.Now;
            model.UpdatedDate= System.DateTime.Now; 
            model.UpdatedBy = 1;
            model.Attr1 = "";
            model.Attr2 = "";
            model.Attr3 = "";
            model.Attr4 = "";
            model.Attr5 = "";
            model.Attr6 = 21;
            model.Attr7= 1;
            model.Attr8 = 2;

            return model;

        }


    }
}
