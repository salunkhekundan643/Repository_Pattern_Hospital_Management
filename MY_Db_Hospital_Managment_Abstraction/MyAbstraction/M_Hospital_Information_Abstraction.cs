using MY_Db_Hospital_Managment.Master_Model;
using MY_Db_Hospital_Managment_Interface.Master_Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MY_Db_Hospital_Managment_Connection.My_Connection;

namespace MY_Db_Hospital_Managment_Abstraction.MyAbstraction
{
    public  class M_Hospital_Information_Abstraction : I_M_Hospital_Information
    {




        //this function for get datatable from sql using qry string
        //
        public DataTable GetDataTable()
        {
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class 
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand("Select * from M_Hospital_Information",sqlcon);//provider of ADO.Net//used to execute commands at on database
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);//Use for retrive data from sql
            DataTable _datatable = new DataTable();//object  declaration of DataTable
            adapter.Fill(_datatable);//called fill() from SqlDataAdapter class for to fill my datatable

            return _datatable;  //Connecting string

        }

        public void SaveOrUpdateWithADO(M_Hospital_Information_Model model)
        {
            string Flag = null;
            if (model.HospitalId==0)
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
            cmd.CommandText = "Sp_M_Hospital_Information";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection= sqlcon;

            cmd.Parameters.AddWithValue("@HospitalId", model.HospitalId);
            cmd.Parameters.AddWithValue("@HospitalName", model.HospitalName);//Add a parameters by specifying its name
            cmd.Parameters.AddWithValue("@HospitalAddress", model.HospitalAddress);
            cmd.Parameters.AddWithValue("@HospitalEmailAddress", model.HospitalEmailAddress);
            cmd.Parameters.AddWithValue("@Logo", model.Logo);
            cmd.Parameters.AddWithValue("@HospitalCity", model.HospitalCity);
            cmd.Parameters.AddWithValue("@HospitalPan", model.HospitalPan);
            cmd.Parameters.AddWithValue("@HospitalContactNumber", model.HospitalContactNumber);
            cmd.Parameters.AddWithValue("@HospitalContactNumber1", model.HospitalContactNumber1);
            cmd.Parameters.AddWithValue("@Hospitalwedsite", model.Hospitalwedsite);
            cmd.Parameters.AddWithValue("@CreatedBy", model.CreatedBy);
            cmd.Parameters.AddWithValue("@CreatedDate", model.CreatedDate);
            cmd.Parameters.AddWithValue("@UpdatedBy", model.UpdatedBy);
            cmd.Parameters.AddWithValue("@UpdatedDate", model.UpdatedDate);
            cmd.Parameters.AddWithValue("@Flag", Flag);


            cmd.ExecuteNonQuery();
        }

        public void SaveWithQuery(M_Hospital_Information_Model model)
        {
            string qry= "Insert into M_Hospital_Information (HospitalName,HospitalAddress,HospitalEmailAddress,Logo,HospitalCity,HospitalPan,HospitalContactNumber,HospitalContactNumber1,Hospitalwedsite,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate) values ('"+model.HospitalName + "','"+model.HospitalAddress + "','"+model.HospitalEmailAddress + "','"+ model.Logo + "','"+model.HospitalCity + "','"+model.HospitalPan + "','"+model.HospitalContactNumber + "','"+model.HospitalContactNumber1 + "','"+model.Hospitalwedsite + "','"+model.CreatedBy + "',getdate(),'"+model.UpdatedBy + "',getdate())";// sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class 
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class
            SqlCommand cmd = new SqlCommand();//provider of ADO.Net//used to execute commands at on database
            cmd.CommandText = qry;//It is set or return a string that contain a provider
            cmd.CommandType=CommandType.Text;//  should  contain text of a query that must be run on the server
            cmd.Connection= sqlcon;    //Connecting string

            cmd.ExecuteNonQuery();  // It's used for Execute sql command
        }

        public void SaveWithQueryString(M_Hospital_Information_Model model)
        {
            string qry = "Insert into M_Hospital_Information (HospitalName,HospitalAddress,HospitalEmailAddress,Logo,HospitalCity,HospitalPan,HospitalContactNumber,HospitalContactNumber1,Hospitalwedsite,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate) values (@HospitalName,@@HospitalAddress,@HospitalEmailAddress,@Logo,@HospitalCity,@HospitalPan,@HospitalContactNumber,@HospitalContactNumber1,@Hospitalwedsite,@CreatedBy,@CreatedDate,@UpdatedBy,@UpdatedDate)";// sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class 
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class
            SqlCommand cmd = new SqlCommand();//provider of ADO.Net//used to execute commands at on database

            try
            {
                cmd.CommandText = qry;//  should  contain text of a query that must be run on the server
                cmd.CommandType = CommandType.Text;//  should  contain text of a query that must be run on the server
                cmd.Connection = sqlcon;    //Connecting string

                cmd.Parameters.AddWithValue("@HospitalName", model.HospitalName);//Add a parameters by specifying its name
                cmd.Parameters.AddWithValue("@HospitalAddress", model.HospitalAddress);
                cmd.Parameters.AddWithValue("@HospitalEmailAddress", model.HospitalEmailAddress);
                cmd.Parameters.AddWithValue("@Logo", model.Logo);
                cmd.Parameters.AddWithValue("@HospitalCity", model.HospitalCity);
                cmd.Parameters.AddWithValue("@HospitalPan", model.HospitalPan);
                cmd.Parameters.AddWithValue("@HospitalContactNumber", model.HospitalContactNumber);
                cmd.Parameters.AddWithValue("@HospitalContactNumber1", model.HospitalContactNumber1);
                cmd.Parameters.AddWithValue("@Hospitalwedsite", model.Hospitalwedsite);
                cmd.Parameters.AddWithValue("@CreatedBy", model.CreatedBy);
                cmd.Parameters.AddWithValue("@CreatedDate", model.CreatedDate);
                cmd.Parameters.AddWithValue("@UpdatedBy", model.UpdatedBy);
                cmd.Parameters.AddWithValue("@UpdatedDate", model.UpdatedDate);

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
