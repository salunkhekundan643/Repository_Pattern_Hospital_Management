using MY_Db_Hospital_Managment.Master_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testproject.Master_Binder
{
    public  class M_Tax_Type_Information_Binder
    {
        public M_Tax_Type_Information_Model DataBinder()
        {
            M_Tax_Type_Information_Model model= new M_Tax_Type_Information_Model();
            model.TaxId = 0;
            model.TaxName = "A";
            model.TaxPercent = 1;
            model.TaxGroupId = 1;

            return model;
        }

    }
}
