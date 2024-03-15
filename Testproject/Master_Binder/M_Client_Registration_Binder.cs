using MY_Db_Hospital_Managment.Master_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MY_Db_Hospital_Managment_Abstraction.MyAbstraction;
using MY_Db_Hospital_Managment_Connection.My_Connection;
using MY_Db_Hospital_Managment_Interface.Master_Interface;


namespace Testproject.Master_Binder
{
    public  class M_Client_Registration_Binder
    {
        public M_Client_Registration_Model DataBinder() 
        {
            M_Client_Registration_Model model = new M_Client_Registration_Model();
            model.ClientId = 0;
            model.ClientCode = "A";
            model.ClientGlobalId = 1;
            model.ClientName = "b";
            model.ClientAddress = "c";
            model.ClientPhone = "ABC";
            model.ClientCity = "Chalisgaon";
            model.BusniessName = "AA";
            model.ClientPan = "Abc";
            model.ClientRegistrationNo = "abc";
            model.ClientGST="aa";
            model.ClientLogo = "bb";
            model.ClientEmail="cc";
            model.Password = "a";
            model.UserName = "a";
            model.CreatedBy = 1;
            model.CreatedDate= System.DateTime.Now;
            model.UpdatedDate= System.DateTime.Now;
            model.ActiveFlag = "A";
            model.Attr1 = "a";
            model.Attr2 = "s";
            model.Attr3 =1;


            return model;


        }
    }
}