using MY_Db_Hospital_Managment.Master_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testproject.Master_Binder
{
    public  class T_Medicen_Sale_Hedar_Binder
    {
        public T_Medicen_Sale_Hedar_Model DataBinder()
        {
                T_Medicen_Sale_Hedar_Model model = new T_Medicen_Sale_Hedar_Model();
            model.Sale_Hedar_Id = 0;
            model.Sale_Date = System.DateTime.Now;
            model.Client_Id = 1;
            model.Global_Id = 2;
            model.Sale_Document_Number = "A";
            model.Customer_Name = "a";
            model.Discount_Percentage = 10;
            model.Discount_In_Rupees = 21;
            model.Discount_Amount_Percentage = 21;
            model.Discount_Amount_Rupees = 22;
            model.Total_Amount = 21;
            model.Contact_No = "aa";
            model.Dr_Name = "A";
            model.Address = "Dhule";
            model.Attr1 = 10;
            model.Attr2 = 11;
            model.Created_Date=System.DateTime.Now;
            model.Updated_Date=System.DateTime.Now;
            model.Created_By = 1;
            model.Updated_By = 2;

            return model;

        }

    }
}
