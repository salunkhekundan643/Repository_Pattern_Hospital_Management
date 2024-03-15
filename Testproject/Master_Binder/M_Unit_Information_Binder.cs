using MY_Db_Hospital_Managment.Master_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testproject.Master_Binder
{
    public  class M_Unit_Information_Binder
    {
        public M_Unit_Information_Model DataBinder()
        {
            M_Unit_Information_Model model= new M_Unit_Information_Model();
            model.UnitId = 0;
            model.UnitName = "";
            model.CreatedDate=System.DateTime.Now;
            model.CreatedBy = 1;
            model.UpdatedBy = 1;
            model.UpdatedDate=System.DateTime.Now;

            return model;
        }

    }
}
