using MY_Db_Hospital_Managment.Master_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testproject.Master_Binder
{
    public  class M_Department_Information_Binder
    {
        public M_Department_Information_Model DataBinder()
        {
            M_Department_Information_Model model= new M_Department_Information_Model();
            model.DepartmentId = 0;
            model.DepartmentStartDate=System.DateTime.Now;
            model.DepartmentCode = "101";
            model.DepartmentName = "CDS";
            model.DepartmentAddress = "Dhule";
            model.DepartmentDescription = "A";
            model.HospitalId = 1;
            model.CreatedBy = 2;
            model.CreatedDate = System.DateTime.Now;
            model.UpdatedDate= System.DateTime.Now;
            model.UpdatedBy = 1;

            return model;

        }

    }
}
