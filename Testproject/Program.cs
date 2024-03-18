using Microsoft.SqlServer.Server;
using MY_Db_Hospital_Managment.Master_Model;
using MY_Db_Hospital_Managment_Abstraction.MyAbstraction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testproject.Master_Binder;
using MY_Db_Hospital_Managment_Interface.Master_Interface;
using My_Db_Hospital_Management_EntityFramework.MyDbContext;


namespace Testproject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //GetDataTable function //

            //A_M_Lookup_Line_Abstraction obj = new A_M_Lookup_Line_Abstraction();
            //DataTable dt = obj.GetDataTable();

            //A_M_Lookup_Hedar_Abstraction obj = new A_M_Lookup_Hedar_Abstraction();
            //DataTable dt = obj.GetDataTable();

            //M_Client_Registration_Abstraction obj = new M_Client_Registration_Abstraction();
            //DataTable dt = obj.GetDataTable();

            //M_Department_Information_Abstraction obj = new M_Department_Information_Abstraction();
            //DataTable dt = obj.GetDataTable();

            //M_Designation_Information_Abstraction obj = new M_Designation_Information_Abstraction();
            //DataTable dt = obj.GetDataTable();

            //M_Employee_Information_Abstraction obj = new M_Employee_Information_Abstraction();
            //DataTable dt = obj. GetDataTable();

            //M_Hospital_Information_Abstraction obj = new M_Hospital_Information_Abstraction();
            //DataTable dt = obj.GetDataTable();

            //M_Item_Information_Abstraction obj = new M_Item_Information_Abstraction();
            //DataTable dt = obj. GetDataTable();

            //M_Material_Type_Infromation_Abstraction obj= new M_Material_Type_Infromation_Abstraction();
            //DataTable dt =obj.GetDataTable();

            //M_Packing_Abstraction obj = new M_Packing_Abstraction();
            //DataTable dt = obj.GetDataTable();

            //M_Person_Information_Abstraction obj = new M_Person_Information_Abstraction();
            //DataTable dt = obj.GetDataTable();

            //M_Tax_Type_Information_Abstraction obj= new M_Tax_Type_Information_Abstraction();
            //DataTable dt = obj.GetDataTable();

            //M_Unit_Information_Abstraction obj= new M_Unit_Information_Abstraction();
            //DataTable dt = obj.GetDataTable();

            //M_User_Login_Information_Abstraction obj= new M_User_Login_Information_Abstraction();
            //DataTable dt = obj.GetDataTable();

            //T_Medicen_Sale_Hedar_Abstraction obj = new T_Medicen_Sale_Hedar_Abstraction(); ;
            //DataTable dt = obj.GetDataTable();

            //T_Medicen_Sale_Line_Abstraction obj = new T_Medicen_Sale_Line_Abstraction();
            //DataTable dt =obj.GetDataTable();

            //T_Purchase_Hedar_Abstraction obj = new T_Purchase_Hedar_Abstraction();
            //DataTable dt = obj.GetDataTable();

            //T_Purchase_Line_Abstraction obj = new T_Purchase_Line_Abstraction();
            //DataTable dt = obj.GetDataTable();

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //SaveWithQuery function //SaveWithQueryString function//

            //A_M_Lookup_Hedar_Binder binder = new A_M_Lookup_Hedar_Binder();
            //A_M_Lookup_Hedar_Model model = binder.DataBinder();
            //A_M_Lookup_Hedar_Abstraction ma = new A_M_Lookup_Hedar_Abstraction();
            //ma.SaveWithQuery(model);

            //A_M_Lookup_Hedar_Binder binder = new A_M_Lookup_Hedar_Binder();
            //A_M_Lookup_Hedar_Model model = binder.DataBinder();
            //A_M_Lookup_Hedar_Abstraction ma = new A_M_Lookup_Hedar_Abstraction();
            //ma.SaveWithQueryString(model);


            //A_M_Lookup_Line_Binder binder = new A_M_Lookup_Line_Binder();
            //A_M_Lookup_Line_Model model = binder.DataBinder();
            //A_M_Lookup_Line_Abstraction ma = new A_M_Lookup_Line_Abstraction();
            //ma.SaveWithQuery(model);

            //A_M_Lookup_Line_Binder binder = new A_M_Lookup_Line_Binder();
            //A_M_Lookup_Line_Model model = binder.DataBinder();
            //A_M_Lookup_Line_Abstraction ma = new A_M_Lookup_Line_Abstraction();
            //ma.SaveWithQueryString(model);


            //M_Client_Registration_Binder binder = new M_Client_Registration_Binder();
            //M_Client_Registration_Model model = binder.DataBinder();
            //M_Client_Registration_Abstraction ma = new M_Client_Registration_Abstraction();
            //ma.SaveWithQuery(model);

            //M_Client_Registration_Binder binder = new M_Client_Registration_Binder();
            //M_Client_Registration_Model model = binder.DataBinder();
            //M_Client_Registration_Abstraction ma = new M_Client_Registration_Abstraction();
            //ma.SaveWithQueryString(model);


            //M_Department_Information_Binder binder = new M_Department_Information_Binder();
            //M_Department_Information_Model model = binder.DataBinder();
            //M_Department_Information_Abstraction ma = new M_Department_Information_Abstraction();
            //ma.SaveWithQuery(model);

            //M_Department_Information_Binder binder = new M_Department_Information_Binder();
            //M_Department_Information_Model model = binder.DataBinder();
            //M_Department_Information_Abstraction ma = new M_Department_Information_Abstraction();
            //ma.SaveWithQueryString(model);


            //M_Designation_Information_Binder binder = new M_Designation_Information_Binder  ();
            //M_Designation_Information_Model model = binder.DataBinder();
            //M_Designation_Information_Abstraction ma= new M_Designation_Information_Abstraction ();
            //ma.SaveWithQuery (model);

            //M_Designation_Information_Binder binder = new M_Designation_Information_Binder();
            //M_Designation_Information_Model model = binder.DataBinder();
            //M_Designation_Information_Abstraction ma = new M_Designation_Information_Abstraction();
            //ma.SaveWithQueryString(model);


            //M_Employee_Information_Binder binder= new M_Employee_Information_Binder();
            //M_Employee_Information_Model model = binder.DataBinder();
            //M_Employee_Information_Abstraction ma = new M_Employee_Information_Abstraction();
            //ma.SaveWithQuery(model);

            //M_Employee_Information_Binder binder = new M_Employee_Information_Binder();
            //M_Employee_Information_Model model = binder.DataBinder();
            //M_Employee_Information_Abstraction ma = new M_Employee_Information_Abstraction();
            //ma.SaveWithQueryString(model);


            //M_Hospital_Information_BInder binder = new M_Hospital_Information_BInder();
            //M_Hospital_Information_Model model = binder.DataBinder();
            //M_Hospital_Information_Abstraction ma = new M_Hospital_Information_Abstraction();
            //ma.SaveWithQuery(model);

            //M_Hospital_Information_Binder binder = new M_Hospital_Information_Binder();
            //M_Hospital_Information_Model model = binder.DataBinder();
            //M_Hospital_Information_Abstraction ma = new M_Hospital_Information_Abstraction();
            //ma.SaveWithQueryString(model);


            //M_Item_Information_Binder binder = new M_Item_Information_Binder();
            //M_Item_Information_Model model = binder.DataBinder();
            //M_Item_Information_Abstraction ma = new M_Item_Information_Abstraction();
            //ma.SaveWithQuery(model);

            //M_Item_Information_Binder binder = new M_Item_Information_Binder();
            //M_Item_Information_Model model = binder.DataBinder();
            //M_Item_Information_Abstraction ma = new M_Item_Information_Abstraction();
            //ma.SaveWithQueryString(model);

            //M_Material_Type_Infromation_Binder binder = new M_Material_Type_Infromation_Binder();
            //M_Material_Type_Infromation_Model model = binder.DataBinder();
            //M_Material_Type_Infromation_Abstraction ma = new M_Material_Type_Infromation_Abstraction();
            //ma.SaveWithQuery(model);


            //M_Material_Type_Infromation_Binder binder = new M_Material_Type_Infromation_Binder();
            //M_Material_Type_Infromation_Model model = binder.DataBinder();
            //M_Material_Type_Infromation_Abstraction ma = new M_Material_Type_Infromation_Abstraction();
            //ma.SaveWithQueryString(model);


            //M_Packing_Binder binder = new M_Packing_Binder();
            //M_Packing_Model model = binder.DataBinder();
            //M_Packing_Abstraction ma = new M_Packing_Abstraction();
            //ma.SaveWithQuery(model);

            //M_Packing_Binder binder = new M_Packing_Binder();
            //M_Packing_Model model = binder.DataBinder();
            //M_Packing_Abstraction ma = new M_Packing_Abstraction();
            //ma.SaveWithQueryString(model);


            //M_Person_Information_Binder binder = new M_Person_Information_Binder();
            //M_Person_Information_Model model = binder.DataBinder();
            //M_Person_Information_Abstraction ma = new M_Person_Information_Abstraction();
            //ma.SaveWithQuery(model);

            //M_Person_Information_Binder binder = new M_Person_Information_Binder();
            //M_Person_Information_Model model = binder.DataBinder();
            //M_Person_Information_Abstraction ma = new M_Person_Information_Abstraction();
            //ma.SaveWithQueryString(model);


            //M_Tax_Type_Information_Binder binder = new M_Tax_Type_Information_Binder();
            //M_Tax_Type_Information_Model model = binder.DataBinder();
            //M_Tax_Type_Information_Abstraction ma= new M_Tax_Type_Information_Abstraction();
            //ma.SaveWithQuery(model);

            //M_Tax_Type_Information_Binder binder = new M_Tax_Type_Information_Binder();
            //M_Tax_Type_Information_Model model = binder.DataBinder();
            //M_Tax_Type_Information_Abstraction ma = new M_Tax_Type_Information_Abstraction();
            //ma.SaveWithQueryString(model);

            //M_Unit_Information_Binder binder = new M_Unit_Information_Binder();
            //M_Unit_Information_Model model = binder.DataBinder();
            //M_Unit_Information_Abstraction ma = new M_Unit_Information_Abstraction();
            //ma.SaveWithQuery(model);

            //M_Unit_Information_Binder binder = new M_Unit_Information_Binder();
            //M_Unit_Information_Model model = binder.DataBinder();
            //M_Unit_Information_Abstraction ma = new M_Unit_Information_Abstraction();
            //ma.SaveWithQueryString(model);


            //M_User_Login_Information_Binder binder = new M_User_Login_Information_Binder();
            //M_User_Login_Information_Model model = binder.DataBinder();
            //M_User_Login_Information_Abstraction ma= new M_User_Login_Information_Abstraction();
            //ma.SaveWithQuery(model);

            //M_User_Login_Information_Binder binder = new M_User_Login_Information_Binder();
            //M_User_Login_Information_Model model = binder.DataBinder();
            //M_User_Login_Information_Abstraction ma = new M_User_Login_Information_Abstraction();
            //ma.SaveWithQueryString(model);


            //T_Medicen_Sale_Hedar_Binder binder= new T_Medicen_Sale_Hedar_Binder();
            //T_Medicen_Sale_Hedar_Model model = binder.DataBinder();
            //T_Medicen_Sale_Hedar_Abstraction ma= new T_Medicen_Sale_Hedar_Abstraction();
            //ma.SaveWithQuery(model);

            //T_Medicen_Sale_Hedar_Binder binder = new T_Medicen_Sale_Hedar_Binder();
            //T_Medicen_Sale_Hedar_Model model = binder.DataBinder();
            //T_Medicen_Sale_Hedar_Abstraction ma = new T_Medicen_Sale_Hedar_Abstraction();
            //ma.SaveWithQueryString(model);


            //T_Medicen_Sale_Line_Binder binder= new T_Medicen_Sale_Line_Binder();
            //T_Medicen_Sale_Line_Model model = binder.DataBinder();
            //T_Medicen_Sale_Line_Abstraction ma= new T_Medicen_Sale_Line_Abstraction();
            //ma.SaveWithQuery(model);

            //T_Medicen_Sale_Line_Binder binder = new T_Medicen_Sale_Line_Binder();
            //T_Medicen_Sale_Line_Model model = binder.DataBinder();
            //T_Medicen_Sale_Line_Abstraction ma = new T_Medicen_Sale_Line_Abstraction();
            //ma.SaveWithQueryString(model);


            //   T_Purchase_Hedar_Binder binder= new T_Purchase_Hedar_Binder();
            //T_Purchase_Hedar_Model model = binder.DataBinder();
            //T_Purchase_Hedar_Abstraction ma = new T_Purchase_Hedar_Abstraction();
            //ma.SaveWithQuery(model);


            //T_Purchase_Hedar_Binder binder = new T_Purchase_Hedar_Binder();
            //T_Purchase_Hedar_Model model = binder.DataBinder();
            //T_Purchase_Hedar_Abstraction ma = new T_Purchase_Hedar_Abstraction();
            //ma.SaveWithQueryString(model);


            //T_Purchase_Line_Binder binder= new T_Purchase_Line_Binder();
            //T_Purchase_Line_Model model = binder.DataBinder();
            //T_Purchase_Line_Abstraction ma= new T_Purchase_Line_Abstraction ();
            //ma.SaveWithQuery (model);


            //T_Purchase_Line_Binder binder = new T_Purchase_Line_Binder();
            //T_Purchase_Line_Model model = binder.DataBinder();
            //T_Purchase_Line_Abstraction ma = new T_Purchase_Line_Abstraction();
            //ma.SaveWithQueryString(model);
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //SaveOrUpdateWithADO

            //A_M_Lookup_Hedar_Binder binder = new A_M_Lookup_Hedar_Binder();
            //A_M_Lookup_Hedar_Model model = binder.DataBinder();
            //A_M_Lookup_Hedar_Abstraction ma = new A_M_Lookup_Hedar_Abstraction();
            //ma.SaveOrUpdateWithADO(model);

            //A_M_Lookup_Line_Binder binder= new A_M_Lookup_Line_Binder();
            //A_M_Lookup_Line_Model model = binder.DataBinder();
            //A_M_Lookup_Line_Abstraction ma= new A_M_Lookup_Line_Abstraction();
            //ma.SaveOrUpdateWithADO(model);

            // M_Client_Registration_Binder binder = new M_Client_Registration_Binder();
            // M_Client_Registration_Model model = binder.DataBinder();
            // M_Client_Registration_Abstraction ma = new M_Client_Registration_Abstraction();
            // ma.SaveOrUpdatewithADO(model);

            //M_Department_Information_Binder binder = new M_Department_Information_Binder();
            //M_Department_Information_Model model = binder.DataBinder();
            //M_Department_Information_Abstraction ma = new M_Department_Information_Abstraction();
            //ma.SaveOrUpdateWithADO(model);

            //M_Designation_Information_Binder binder = new M_Designation_Information_Binder();
            //M_Designation_Information_Model model = binder.DataBinder();
            //M_Designation_Information_Abstraction ma = new M_Designation_Information_Abstraction();
            //ma.SaveOrUpdateWithADO(model);

            //M_Employee_Information_Binder binder= new M_Employee_Information_Binder();
            //M_Employee_Information_Model model = binder.DataBinder();
            //M_Employee_Information_Abstraction ma= new M_Employee_Information_Abstraction();
            //ma.SaveOeUpdateWithADO(model);

            //M_Hospital_Information_Binder binder = new M_Hospital_Information_Binder();
            //M_Hospital_Information_Model model = binder.DataBinder();
            //M_Hospital_Information_Abstraction ma=new M_Hospital_Information_Abstraction();
            //ma.SaveOrUpdateWithADO(model);

            //M_Item_Information_Binder binder= new M_Item_Information_Binder();
            //M_Item_Information_Model model = binder.DataBinder();
            //M_Item_Information_Abstraction ma= new M_Item_Information_Abstraction();
            //ma.SaveOrUpdateWithADO(model);

            //M_Material_Type_Infromation_Binder binder= new M_Material_Type_Infromation_Binder();
            //M_Material_Type_Infromation_Model model = binder.DataBinder();
            //M_Material_Type_Infromation_Abstraction ma= new M_Material_Type_Infromation_Abstraction();
            //ma.SaveOrUpdateWithADO (model);

            //M_Packing_Binder binder= new M_Packing_Binder();
            //M_Packing_Model model= binder.DataBinder();
            //M_Packing_Abstraction ma= new M_Packing_Abstraction();
            //ma.SaveOrupdateWithADO(model);

            //M_Person_Information_Binder binder = new M_Person_Information_Binder();
            //M_Person_Information_Model model = binder.DataBinder();
            //M_Person_Information_Abstraction ma = new M_Person_Information_Abstraction();
            //ma.SaveOrUpdateWithADO(model);

            //M_Tax_Type_Information_Binder binder = new M_Tax_Type_Information_Binder();
            //M_Tax_Type_Information_Model model = binder.DataBinder();
            //M_Tax_Type_Information_Abstraction ma = new M_Tax_Type_Information_Abstraction();
            //ma.SaveOrUpdateWithADO(model);

            //M_Unit_Information_Binder binder= new M_Unit_Information_Binder();
            //M_Unit_Information_Model model = binder.DataBinder();
            //M_Unit_Information_Abstraction ma= new M_Unit_Information_Abstraction();
            //ma.SaveOrUpdateWithADO(model);

            //M_User_Login_Information_Binder binder = new M_User_Login_Information_Binder();
            //M_User_Login_Information_Model model = binder.DataBinder();
            //M_User_Login_Information_Abstraction ma = new M_User_Login_Information_Abstraction();
            //ma.SaveOrUpdateWithADO(model);

            //T_Medicen_Sale_Hedar_Binder binder = new T_Medicen_Sale_Hedar_Binder();
            //T_Medicen_Sale_Hedar_Model model = binder.DataBinder();
            //T_Medicen_Sale_Hedar_Abstraction ma = new T_Medicen_Sale_Hedar_Abstraction();
            //ma.SaveOrUpdateWithADO(model);

            //T_Medicen_Sale_Line_Binder binder = new T_Medicen_Sale_Line_Binder();
            //T_Medicen_Sale_Line_Model model = binder.DataBinder();
            //T_Medicen_Sale_Line_Abstraction ma = new T_Medicen_Sale_Line_Abstraction();
            //ma.SaveOrUpdateWithADO (model);

            //T_Purchase_Hedar_Binder binder = new T_Purchase_Hedar_Binder();
            //T_Purchase_Hedar_Model model = binder.DataBinder();
            //T_Purchase_Hedar_Abstraction ma = new T_Purchase_Hedar_Abstraction();
            //ma.SaveOrUpdateWithADO(model);

            //T_Purchase_Line_Binder binder = new T_Purchase_Line_Binder();
            //T_Purchase_Line_Model model = binder.DataBinder();
            //T_Purchase_Line_Abstraction ma = new T_Purchase_Line_Abstraction();
            //ma.SaveOrUpdateWithADO(model);

            //////////////////////////////////////////////////////////////////////////////////////////////////


            //GetDataListWithADO function       //Test GetDataList List Method 


            //A_M_Lookup_Hedar_Abstraction ma = new A_M_Lookup_Hedar_Abstraction();
            //List<A_M_Lookup_Hedar_Model> _List=ma.GetDataListWithADO();

            //A_M_Lookup_Line_Abstraction ma = new A_M_Lookup_Line_Abstraction();
            //List<A_M_Lookup_Line_Model> _List=ma.GetDataListWithADO();

            //M_Client_Registration_Abstraction ma = new M_Client_Registration_Abstraction();
            //List<M_Client_Registration_Model> _List=ma.GetDataListWithADO();

            //  M_Department_Information_Abstraction ma = new M_Department_Information_Abstraction();
            //List<M_Department_Information_Model> _List=ma.GetDataListWithADO();

            //M_Designation_Information_Abstraction ma = new M_Designation_Information_Abstraction();
            //List<M_Designation_Information_Model> _List = ma.GetDataListWithADO();

            //M_Employee_Information_Abstraction ma = new M_Employee_Information_Abstraction();
            //List<M_Employee_Information_Model> _List = ma.GetDataListWithADO();

            //M_Hospital_Information_Abstraction ma = new M_Hospital_Information_Abstraction();
            //List<M_Hospital_Information_Model> _List = ma.GetDataListWithADO();


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // SaveOrUpdateWithEntityFramework()  //Test saveEntityFrameWork Method

            //A_M_Lookup_Hedar_Binder binder = new A_M_Lookup_Hedar_Binder();
            //A_M_Lookup_Hedar_Model model = binder.DataBinder();
            //A_M_Lookup_Hedar_Abstraction ma =new A_M_Lookup_Hedar_Abstraction();
            //ma.SaveOrUpdateWithEntityFramework(model);

            //A_M_Lookup_Line_Binder binder = new A_M_Lookup_Line_Binder();
            //A_M_Lookup_Line_Model model = binder.DataBinder();
            //A_M_Lookup_Line_Abstraction ma= new A_M_Lookup_Line_Abstraction();
            //ma.SaveOrUpdateWithEntityFrameWork(model);

            //M_Client_Registration_Binder binder= new M_Client_Registration_Binder();
            //M_Client_Registration_Model model = binder.DataBinder();
            //M_Client_Registration_Abstraction ma = new M_Client_Registration_Abstraction();
            //ma.SaveOrUpdateWithEntityFrameWork(model);

            //M_Department_Information_Binder binder= new M_Department_Information_Binder();
            //M_Department_Information_Model model = binder.DataBinder();
            //M_Department_Information_Abstraction ma= new M_Department_Information_Abstraction();
            //ma.SaveOrUpdateWithEntityFrameWork(model);

            //M_Designation_Information_Binder binder = new M_Designation_Information_Binder();
            //M_Designation_Information_Model model = binder.DataBinder();
            //M_Designation_Information_Abstraction ma = new M_Designation_Information_Abstraction();
            //ma.SaveOrUpdateWithEntityFramework(model);

            //M_Employee_Information_Binder binder = new M_Employee_Information_Binder();
            //M_Employee_Information_Model model = binder.DataBinder();
            //M_Employee_Information_Abstraction ma = new M_Employee_Information_Abstraction();
            //ma.SaveOrUpdateWithEntityFramework(model);

            //M_Hospital_Information_Binder binder =new M_Hospital_Information_Binder();
            //M_Hospital_Information_Model model = binder.DataBinder();
            //M_Hospital_Information_Abstraction ma = new M_Hospital_Information_Abstraction();
            //ma.SaveOrUpdateWithEntityFramework(model);


            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            //GetDataListWithEntityFramework()  //Test GetdataEntityFrameWork List Method

            //A_M_Lookup_Hedar_Abstraction ma = new A_M_Lookup_Hedar_Abstraction();
            //List<A_M_Lookup_Hedar> _list = ma.GetDataListWithEntityFramework();

            //A_M_Lookup_Line_Abstraction ma = new A_M_Lookup_Line_Abstraction();
            //List<A_M_Lookup_Line> _list = ma.GetDataListWithEntityFramework();

            //M_Client_Registration_Abstraction ma = new M_Client_Registration_Abstraction();
            //List<M_Client_Registration> _list = ma.GetDataListWithEntityFramework();

            //M_Department_Information_Abstraction ma = new M_Department_Information_Abstraction();
            //List<M_Department_Information> _List = ma.GetDataListWithEntityFramework();

            //M_Designation_Information_Abstraction ma = new M_Designation_Information_Abstraction  ();
            //List<M_Designation_Information> _List = ma.GetDataListWithEntityFramework();

            //M_Employee_Information_Abstraction ma = new M_Employee_Information_Abstraction();
            //List<M_Employee_Information> _List= ma.GetDataListWithEntityFramework();

            //M_Hospital_Information_Abstraction ma = new M_Hospital_Information_Abstraction();
            //List<M_Hospital_Information> _List = ma.GetDataListWithEntityFramework();




        }
    }
}   

