using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MY_Db_Hospital_Managment.Master_Model;
using MY_Db_Hospital_Managment_Abstraction.MyAbstraction;
using MY_Db_Hospital_Managment_Connection.My_Connection;
using MY_Db_Hospital_Managment_Interface.Master_Interface;

namespace Testproject.Master_Binder
{
    public  class A_M_Lookup_Line_Binder
    {
        public A_M_Lookup_Line_Model DataBinder()
        {
            A_M_Lookup_Line_Model model = new A_M_Lookup_Line_Model();
            model.LineId = 0;
            model.ClientId = 2;
            model.GlobalId = 2;
            model.LookupId = 3;
            model.LineName = "CDS";
            model.LineDescription = "ABC";
            model.CreatedBy = 1;
            model.CreatedDate = DateTime.Now;
            model.UpdatedBy = 1;
            model.UpdatedDate = DateTime.Now;



            return model;

        }
    }
}
