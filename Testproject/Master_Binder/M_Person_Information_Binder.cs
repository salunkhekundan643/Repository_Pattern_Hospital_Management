using MY_Db_Hospital_Managment.Master_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testproject.Master_Binder
{
    public  class M_Person_Information_Binder
    {
        public M_Person_Information_Model DataBinder()
        {
            M_Person_Information_Model model= new M_Person_Information_Model();

            model.PersonId = 0;
            model.ClientId = 1;
            model.GlobalId = 2;
            model.ModuleId = 1;
            model.PersonCode = "";
            model.PersonType = 1;
            model.PersonName = "";
            model.PersonAddress = "";
            model.PersonEmailId = "";
            model.PersonContactNumber = "";
            model.PersonBussnessName = "";
            model.PersonOfficeNumber = "";
            model.PersonPancard = "";
            model.PersonCity = "";
            model.PersonBankName = 1;
            model.PersonAccountNumber = "";
            model.PersonGstNumber = "";
            model.PaymentTerms = 1;
            model.CreatedBy = 1;
            model.CreatedDate=System.DateTime.Now;
            model.UpdatedBy = 1;
            model.UpdatedDate=System.DateTime.Now;
            model.ActiveFlag = true;
            model.Attr1 = "";
            model.Attr2 = "";
            model.Attr3 = "";
            model.Attr4 = 1;
            model.Attr5=System.DateTime.Now;

            return model;
        }

    }
}
