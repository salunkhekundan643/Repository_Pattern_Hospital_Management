using MY_Db_Hospital_Managment.Master_Model;
using MY_Db_Hospital_Managment_Interface.Master_Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MY_Db_Hospital_Managment_Connection.My_Connection;
using My_Db_Hospital_Management_EntityFramework.MyDbContext;

namespace MY_Db_Hospital_Managment_Abstraction.MyAbstraction
{
    public  class M_Person_Information_Abstraction : I_M_Person_Information
    {
        public List<M_Person_Information_Model> GetDataListWithADO()
        {
            throw new NotImplementedException();
        }

        public List<M_Person_Information> GetDataListWithEntityFramework()
        {
            throw new NotImplementedException();
        }


        //this function for get datatable from sql using qry string
        //
        public DataTable GetDataTable()
        {
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand("select * from M_Person_Information", sqlcon);//provider of ADO.Net//used to execute commands at on database
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);// use for retrive data from sql
            DataTable _datatable = new DataTable();//object  declaration of DataTable
            adapter.Fill(_datatable);//called fill() from SqlDataAdapter class for to fill my datatable


            return _datatable;//Connecting string


        }

        public void SaveOrUpdateWithADO(M_Person_Information_Model model)
        {
            string Flag = null;
            if (model.PersonId==0)
            {
                Flag = "I";

            }
            else
            {
                Flag = "U";
            }

            ClsFunction cls = new ClsFunction();
            SqlConnection sqlcon= cls.Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Sp_M_Person_Information";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlcon;

            cmd.Parameters.AddWithValue("@PersonId", model.PersonId);
            cmd.Parameters.AddWithValue("@ClientId", model.ClientId);//Add a parameters by specifying its name
            cmd.Parameters.AddWithValue("@GlobalId", model.GlobalId);
            cmd.Parameters.AddWithValue("@ModuleId", model.ModuleId);
            cmd.Parameters.AddWithValue("@PersonCode", model.PersonCode);
            cmd.Parameters.AddWithValue("@PersonType", model.PersonType);
            cmd.Parameters.AddWithValue("@PersonName", model.PersonName);
            cmd.Parameters.AddWithValue("@PersonAddress", model.PersonAddress);
            cmd.Parameters.AddWithValue("@PersonEmailId", model.PersonEmailId);
            cmd.Parameters.AddWithValue("@PersonContactNumber", model.PersonContactNumber);
            cmd.Parameters.AddWithValue("@PersonBussnessName", model.PersonBussnessName);
            cmd.Parameters.AddWithValue("@PersonOfficeNumber", model.PersonOfficeNumber);
            cmd.Parameters.AddWithValue("@PersonPancard", model.PersonPancard);
            cmd.Parameters.AddWithValue("@PersonCity", model.PersonCity);
            cmd.Parameters.AddWithValue("@PersonBankName", model.PersonBankName);
            cmd.Parameters.AddWithValue("@PersonAccountNumber", model.PersonAccountNumber);
            cmd.Parameters.AddWithValue("@PersonGstNumber", model.PersonGstNumber);
            cmd.Parameters.AddWithValue("@PaymentTerms", model.PaymentTerms);
            cmd.Parameters.AddWithValue("@CreatedBy", model.CreatedBy);
            cmd.Parameters.AddWithValue("@CreatedDate", model.CreatedDate);
            cmd.Parameters.AddWithValue("@UpdatedBy", model.UpdatedBy);
            cmd.Parameters.AddWithValue("@UpdatedDate", model.UpdatedDate);
            cmd.Parameters.AddWithValue("@ActiveFlag", model.ActiveFlag);
            cmd.Parameters.AddWithValue("@Attr1", model.Attr1);
            cmd.Parameters.AddWithValue("@Attr2", model.Attr2);
            cmd.Parameters.AddWithValue("@Attr3", model.Attr3);
            cmd.Parameters.AddWithValue("@Attr4", model.Attr4);
            cmd.Parameters.AddWithValue("@Attr5", model.Attr5);
            cmd.Parameters.AddWithValue("@Flag", Flag);


            cmd.ExecuteNonQuery();
        }

        public void SaveOrUpdatewithenityFrameWork(M_Person_Information_Model model)
        {
            throw new NotImplementedException();
        }

        public void SaveWithQuery(M_Person_Information_Model model)
        {
            string qry = "Insert into M_Person_Information (ClientId,GlobalId,ModuleId,PersonCode,PersonType,PersonName,PersonAddress,PersonEmailId,PersonContactNumber,PersonBussnessName,PersonOfficeNumber,PersonPancard,PersonCity,PersonBankName,PersonAccountNumber,PersonGstNumber,PaymentTerms,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,ActiveFlag,Attr1,Attr2,Attr3,Attr4,Attr5) values ('"+model.ClientId + "','"+model.GlobalId + "','"+model.ModuleId + "','"+model.PersonCode + "','"+model.PersonType + "','"+model.PersonName + "','"+model.PersonAddress + "','"+model.PersonEmailId + "','"+model.PersonContactNumber + "','"+model.PersonBussnessName + "','"+model.PersonOfficeNumber + "','"+model.PersonPancard + "','"+model.PersonCity + "','"+model.PersonBankName + "','"+model.PersonAccountNumber + "','"+model.PersonGstNumber + "','"+model.PaymentTerms + "','"+model.CreatedBy + "',getdate(),'"+model.UpdatedBy + "',getdate(),'"+model.ActiveFlag + "','"+model.Attr1 + "','"+model.Attr2 + "','"+model.Attr3 + "','"+model.Attr4 + "',getdate())";// sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand();//provider of ADO.Net//used to execute commands at on database
            cmd.CommandText = qry;//It is set or return a string that contain a provider
            cmd.CommandType = CommandType.Text;//should  contain text of a query that must be run on the server
            cmd.Connection= sqlcon;//Connecting string


            cmd.ExecuteNonQuery();// It's used for Execute sql command
        }

        public void SaveWithQueryString(M_Person_Information_Model model)
        {
            string qry = "Insert into M_Person_Information (ClientId,GlobalId,ModuleId,PersonCode,PersonType,PersonName,PersonAddress,PersonEmailId,PersonContactNumber,PersonBussnessName,PersonOfficeNumber,PersonPancard,PersonCity,PersonBankName,PersonAccountNumber,PersonGstNumber,PaymentTerms,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,ActiveFlag,Attr1,Attr2,Attr3,Attr4,Attr5) values (@ClientId,@GlobalId,@ModuleId,@PersonCode,@PersonType,@PersonName,@PersonAddress,@PersonEmailId,@PersonContactNumber,@PersonBussnessName,@PersonOfficeNumber,@PersonPancard,@PersonCity,@PersonBankName,@PersonAccountNumber,@PersonGstNumber,@PaymentTerms,@CreatedBy,@CreatedDate,@UpdatedBy,@UpdatedDate,@ActiveFlag,@Attr1,@Attr2,@Attr3,@Attr4,@Attr5)";// sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class
            SqlConnection sqlcon= cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand();//provider of ADO.Net//used to execute commands at on database
            try
            {


                cmd.CommandText = qry;//It is set or return a string that contain a provider
                cmd.CommandType = CommandType.Text;  //should  contain text of a query that must be run on the server
                cmd.Connection = sqlcon;//Connecting string

                cmd.Parameters.AddWithValue("@ClientId", model.ClientId);//Add a parameters by specifying its name
                cmd.Parameters.AddWithValue("@GlobalId", model.GlobalId);
                cmd.Parameters.AddWithValue("@ModuleId", model.ModuleId);
                cmd.Parameters.AddWithValue("@PersonCode", model.PersonCode);
                cmd.Parameters.AddWithValue("@PersonType", model.PersonType);
                cmd.Parameters.AddWithValue("@PersonName", model.PersonName);
                cmd.Parameters.AddWithValue("@PersonAddress", model.PersonAddress);
                cmd.Parameters.AddWithValue("@PersonEmailId", model.PersonEmailId);
                cmd.Parameters.AddWithValue("@PersonContactNumber", model.PersonContactNumber);
                cmd.Parameters.AddWithValue("@PersonBussnessName", model.PersonBussnessName);
                cmd.Parameters.AddWithValue("@PersonOfficeNumber", model.PersonOfficeNumber);
                cmd.Parameters.AddWithValue("@PersonPancard", model.PersonPancard);
                cmd.Parameters.AddWithValue("@PersonCity", model.PersonCity);
                cmd.Parameters.AddWithValue("@PersonBankName", model.PersonBankName);
                cmd.Parameters.AddWithValue("@PersonAccountNumber", model.PersonAccountNumber);
                cmd.Parameters.AddWithValue("@PersonGstNumber", model.PersonGstNumber);
                cmd.Parameters.AddWithValue("@PaymentTerms", model.PaymentTerms);
                cmd.Parameters.AddWithValue("@CreatedBy", model.CreatedBy);
                cmd.Parameters.AddWithValue("@CreatedDate", model.CreatedDate);
                cmd.Parameters.AddWithValue("@UpdatedBy", model.UpdatedBy);
                cmd.Parameters.AddWithValue("@UpdatedDate", model.UpdatedDate);
                cmd.Parameters.AddWithValue("@ActiveFlag", model.ActiveFlag);
                cmd.Parameters.AddWithValue("@Attr1", model.Attr1);
                cmd.Parameters.AddWithValue("@Attr2", model.Attr2);
                cmd.Parameters.AddWithValue("@Attr3", model.Attr3);
                cmd.Parameters.AddWithValue("@Attr4", model.Attr4);
                cmd.Parameters.AddWithValue("@Attr5", model.Attr5);

                cmd.ExecuteNonQuery();// It's used for Execute sql command
            }
            catch (Exception ex)
            {
                throw ex;

            }

            finally
            {
                sqlcon.Close();
                cmd.Dispose();

            }
        }
    }
}
