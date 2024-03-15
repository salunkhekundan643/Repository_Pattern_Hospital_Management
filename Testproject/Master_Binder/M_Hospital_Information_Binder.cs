using MY_Db_Hospital_Managment.Master_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Testproject.Master_Binder
{
    public class M_Hospital_Information_Binder
    {
        public M_Hospital_Information_Model DataBinder()
        {
            M_Hospital_Information_Model model= new M_Hospital_Information_Model();
            model.HospitalId = 0;
            model.HospitalName = "";
            model.HospitalAddress = "";
            model.HospitalEmailAddress = "";
            model.Logo = "";
            model.HospitalCity = "";
            model.HospitalPan = "";
            model.HospitalContactNumber = "";
            model.HospitalContactNumber1 = "";
            model.Hospitalwedsite = "";
            model.CreatedBy = 1;
            model.CreatedDate=System .DateTime.Now;
            model.UpdatedBy= 1;
            model.UpdatedDate=System .DateTime.Now;

            return model;

        }
    }
}
