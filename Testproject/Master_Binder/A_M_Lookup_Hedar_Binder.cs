using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MY_Db_Hospital_Managment.Master_Model;
using MY_Db_Hospital_Managment_Interface.Master_Interface;

namespace Testproject.Master_Binder
{
    public  class A_M_Lookup_Hedar_Binder
    {

        public A_M_Lookup_Hedar_Model DataBinder()
        {
            A_M_Lookup_Hedar_Model model= new A_M_Lookup_Hedar_Model();
            model.LookupId = 0;
            model.ClientId = 4;
            model.GlobalId = 2;
            model.LookupName = "A";
            model.LookupDescription = "B";
            model.CreatedBy = 2;
            model.CreatedDate = System.DateTime.Now;
            model.UpdatedBy = 3;
            model.UpdatedDate = System.DateTime.Now;
            model.ActiveFlag ="";



            return model;

        }

    }
}
