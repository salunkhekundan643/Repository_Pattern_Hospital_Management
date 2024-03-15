using MY_Db_Hospital_Managment.Master_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testproject.Master_Binder
{
    public  class M_Item_Information_Binder
    {
        public M_Item_Information_Model DataBinder()
        {
            M_Item_Information_Model model= new M_Item_Information_Model();
            model.ItemId = 0;
            model.ItemCode = "";
            model.ItemType = 1;
            model.ItemName = "";
            model.ItemManufactionName = "";
            model.ItemPacinking = 1;
            model.ItemUseName = "";
            model.ItemDescription = "";
            model.ItemStartDate=System.DateTime.Now;    
            model.ItemEndDate=System.DateTime.Now;
            model.ItemFirstUnit = 1;
            model.ItemSecondUnit = 2;
            model.ItemConversionFirstFactor = 22;
            model.ItemConversionSecondFactor = 22;
            model.ItemIsStockebal = true;
            model.ItemQualityCheck = false;
            model.ItemReturnPolicy = true;
            model.ItemMinQTY = 22;
            model.ItemMaxQTY= 22;
            model.ItemHsnCode = "";
            model.ItemPoType = 1;
            model.ItemTaxApply = true;
            model.ItemPoTaxGroup = 23;
            model.ItemSaleTaxGroup = 21;
            model.CreatedBy = 1;
            model.CreatedDate=System.DateTime.Now;
            model.UpdatedBy= 1;
            model.UpdatedDate=System.DateTime.Now;
            model.ActiveFlag= true;
            model.Attr1 = "";
            model.Attr2 = "";
            model.Attr3 = "";
            model.Attr4 = 1;
            model.Attr5= 1;
            model.Attr6 = 1;


            return model;

        }
    }
}
