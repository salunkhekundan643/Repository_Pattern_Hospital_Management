using MY_Db_Hospital_Managment.Master_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testproject.Master_Binder
{
    public  class M_Material_Type_Infromation_Binder
    {
        public M_Material_Type_Infromation_Model DataBinder()
        {
            M_Material_Type_Infromation_Model model= new M_Material_Type_Infromation_Model();
            model.MaterialTypeId = 0;
            model.MaterialType = "";
            model.GlobalId = 1;
            model.CreatedBy = 2;
            model.CreatedDate=System.DateTime.Now;
            model.UpdatedBy= 3;
            model.UpdatedDate=System.DateTime.Now;

            return model;

        }

    }
}
