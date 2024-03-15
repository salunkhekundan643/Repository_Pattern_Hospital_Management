using MY_Db_Hospital_Managment.Master_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testproject.Master_Binder
{
    public  class M_Employee_Information_Binder
    {
        public M_Employee_Information_Model DataBinder()
        {
            M_Employee_Information_Model model= new M_Employee_Information_Model();
            model.EmployeeId = 0;
            model.EmployeeCode = "AA";
            model.EmployeeTitle = 1;
            model.EmployeeGender = 2;
            model.EmployeeName = "aa";
            model.EmployeeDesignation = 1;
            model.EmployeeDepartment = 2;
            model.EmployeeDob=System.DateTime.Now;
            model.EmployeeJoingDate=System.DateTime.Now;
            model.EmployeeAddress = "a";
            model.EmployeeAddress1 = "b";
            model.EmployeeCity = "A";
            model.EmployeePan = "B";
            model.EmployeeAdharchard = "A";
            model.EmployeeAlternetNo = "A";
            model.EmployeeMobile = "747773737";
            model.EmployeeEmailId = "alunkhe";
            model.EmployeeBankName = 1;
            model.EmployeeAccountNo = "HDFC";
            model.EmployeeIfscCode = ")01";
            model.EmployeeBranch = 2;
            model.EmployeePhoto = "q";
            model.CreatedBy = 1;
            model.UpdatedBy = 1;
            model.CreatedDate=System .DateTime.Now; 
            model.UpdatedDate=System .DateTime.Now;
            model.ActiveFlag = true;
            model.Attr1 = "A";
            model.Attr2 = "b";
            model.Attr3 = "a";
            model.Attr4 = 1;

            return model;   

        }

    }
}
