using MY_Db_Hospital_Managment.Master_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testproject.Master_Binder
{
    public  class M_Designation_Information_Binder
    {
        public M_Designation_Information_Model DataBinder()
        {
            M_Designation_Information_Model model = new M_Designation_Information_Model();
            model.DesignationId = 0;
            model.DesignationCode = "101";
            model.DesignationName = "CDS";
            model.DesignationQualification = "Coding";
            model.DesignationDescription = "Coder";
            model.CreatedDate=System.DateTime.Now;
            model.UpdatedDate=System.DateTime.Now;
            model.CreatedBy = 1;
            model.UpdatedBy = 2;
            model.AcFlag =true;


                return model;
        }
    }
}
