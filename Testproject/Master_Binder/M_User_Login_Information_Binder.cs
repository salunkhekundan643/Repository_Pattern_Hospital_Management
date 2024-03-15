using MY_Db_Hospital_Managment.Master_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testproject.Master_Binder
{
    public  class M_User_Login_Information_Binder
    {
        public M_User_Login_Information_Model DataBinder()
        {
            M_User_Login_Information_Model model= new M_User_Login_Information_Model();

            model.UserId = 0;
            model.UserName = "A";
            model.UserPassword = "AA";
            model.UserConfirmPassword = "a";
            model.EmployeeId = 1;
            model.CreatedBy = 2;
            model.CreatedDate=System.DateTime.Now;
            model.UpdatedBy= 3;
            model.UpdatedDate=System.DateTime.Now;
            model.Attr1 = "A";
            model.Attr2 = "B";
            model.Attr3 = "C";
            model.Attr4 = "D";

             return model;
        }



    }
}
