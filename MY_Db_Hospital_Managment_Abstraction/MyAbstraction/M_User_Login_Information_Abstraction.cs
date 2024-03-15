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

namespace MY_Db_Hospital_Managment_Abstraction.MyAbstraction
{
    public  class M_User_Login_Information_Abstraction : I_M_User_Login_Information
    {


        //this function for get datatable from sql using qry string
        //
        public DataTable GetDataTable()
        {
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand("select * from M_User_Login_Information",sqlcon);//provider of ADO.Net//used to execute commands at on database
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);// use for retrive data from sql
            DataTable _datatable = new DataTable();//object  declaration of DataTable
            adapter.Fill(_datatable);//called fill() from SqlDataAdapter class for to fill my datatable

            return _datatable;//Connecting string


        }

        public void SaveOrUpdateWithADO(M_User_Login_Information_Model model)
        {
            string Flag = null;
            if (model.UserId==0)
            {
                Flag = "I";

            }
            else
            {
                Flag = "U";
            }

            ClsFunction cls = new ClsFunction();
            SqlConnection sqlcon = cls.Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Sp_M_User_Login_Information";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection= sqlcon;

            cmd.Parameters.AddWithValue("@UserId", model.UserId);
            cmd.Parameters.AddWithValue("@UserName", model.UserName);//Add a parameters by specifying its name
            cmd.Parameters.AddWithValue("@UserPassword", model.UserPassword);
            cmd.Parameters.AddWithValue("@UserConfirmPassword", model.UserConfirmPassword);
            cmd.Parameters.AddWithValue("@EmployeeId", model.EmployeeId);
            cmd.Parameters.AddWithValue("@CreatedBy", model.CreatedBy);
            cmd.Parameters.AddWithValue("@CreatedDate", model.CreatedDate);
            cmd.Parameters.AddWithValue("@UpdatedBy", model.UpdatedBy);
            cmd.Parameters.AddWithValue("@Updateddate", model.UpdatedDate);
            cmd.Parameters.AddWithValue("@Attr1", model.Attr1);
            cmd.Parameters.AddWithValue("@Attr2", model.Attr2);
            cmd.Parameters.AddWithValue("@Attr3", model.Attr3);
            cmd.Parameters.AddWithValue("@Attr4", model.Attr4);
            cmd.Parameters.AddWithValue("@Flag", Flag);


            cmd.ExecuteNonQuery();
        }

        public void SaveWithQuery(M_User_Login_Information_Model model)
        {
            string qry = "Insert into M_User_Login_Information (UserName,UserPassword,UserConfirmPassword,EmployeeId,CreatedBy,CreatedDate,UpdatedBy,Updateddate,Attr1,Attr2,attr3,Attr4) values ('" + model.UserName + "','"+model.UserPassword + "','"+model.UserConfirmPassword + "','"+model.EmployeeId + "','"+model.CreatedBy + "',getdate(),'"+model.UpdatedBy + "',getdate(),'"+model.Attr1 + "','"+model.Attr2 + "','"+model.Attr3 + "','"+model.Attr4 + "')";// sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand();//provider of ADO.Net//used to execute commands at on database
            cmd.CommandText = qry;//It is set or return a string that contain a provider
            cmd.CommandType = CommandType.Text;//should  contain text of a query that must be run on the server
            cmd.Connection = sqlcon;//Connecting string

            cmd.ExecuteNonQuery();// It's used for Execute sql command

        }

        public void SaveWithQueryString(M_User_Login_Information_Model model)
        {
            string qry = "Insert into M_User_Login_Information (UserName,UserPassword,UserConfirmPassword,EmployeeId,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,Attr1,Attr2,Attr3,Attr4) values (@UserName,@UserPassword,@UserConfirmPassword,@EmployeeId,@CreatedBy,@CreatedDate,@UpdatedBy,@UpdatedDate,@Attr1,@Attr2,@Attr3,@Attr4)";// sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand();//provider of ADO.Net//used to execute commands at on database
            try
            {



                cmd.CommandText = qry;//It is set or return a string that contain a provider
                cmd.CommandType = CommandType.Text;//should  contain text of a query that must be run on the server
                cmd.Connection = sqlcon;//Connecting string

                cmd.Parameters.AddWithValue("@UserName", model.UserName);//Add a parameters by specifying its name
                cmd.Parameters.AddWithValue("@UserPassword", model.UserPassword);
                cmd.Parameters.AddWithValue("@UserConfirmPassword", model.UserConfirmPassword);
                cmd.Parameters.AddWithValue("@EmployeeId", model.EmployeeId);
                cmd.Parameters.AddWithValue("@CreatedBy", model.CreatedBy);
                cmd.Parameters.AddWithValue("@CreatedDate", model.CreatedDate);
                cmd.Parameters.AddWithValue("@UpdatedBy", model.UpdatedBy);
                cmd.Parameters.AddWithValue("@Updateddate", model.UpdatedDate);
                cmd.Parameters.AddWithValue("@Attr1", model.Attr1);
                cmd.Parameters.AddWithValue("@Attr2", model.Attr2);
                cmd.Parameters.AddWithValue("@Attr3", model.Attr3);
                cmd.Parameters.AddWithValue("@Attr4", model.Attr4);

                cmd.ExecuteNonQuery();// It's used for Execute sql command
            }
            catch(Exception ex)
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
