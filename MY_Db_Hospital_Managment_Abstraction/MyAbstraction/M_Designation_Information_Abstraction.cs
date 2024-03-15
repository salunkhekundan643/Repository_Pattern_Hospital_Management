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
    public  class M_Designation_Information_Abstraction : I_M_Designation_Information
    {


        //this function for get datatable from sql using qry string
        //
        public DataTable GetDataTable()
        {
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class 
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd= new SqlCommand("select * from M_Designation_Information",sqlcon);//provider of ADO.Net//used to execute commands at on database
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);//Use for retrive data from sql
            DataTable _datatable = new DataTable();//object  declaration of DataTable
            adapter.Fill(_datatable);//called fill() from SqlDataAdapter class for to fill my datatable

            return _datatable;//Connecting string
        }

        public void SaveOrUpdateWithADO(M_Designation_Information_Model model)
        {
            string Flag = null;
            try
            {


                if (model.DesignationId == 0)
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
                cmd.CommandText = "Sp_M_Designation_Information";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = sqlcon;

                cmd.Parameters.AddWithValue("@DesignationId", model.DesignationId);
                cmd.Parameters.AddWithValue("@DesignationCode", model.DesignationCode);//Add a parameters by specifying its name
                cmd.Parameters.AddWithValue("@DesignationName", model.DesignationName);
                cmd.Parameters.AddWithValue("@DesignationQualification", model.DesignationQualification);
                cmd.Parameters.AddWithValue("@DesignationDescription", model.DesignationDescription);
                cmd.Parameters.AddWithValue("@CreatedDate", model.CreatedDate);
                cmd.Parameters.AddWithValue("@UpdatedDate", model.UpdatedDate);
                cmd.Parameters.AddWithValue("@CreatedBy", model.CreatedBy);
                cmd.Parameters.AddWithValue("@UpdatedBy", model.UpdatedBy);
                cmd.Parameters.AddWithValue("@AcFlag", model.AcFlag);
                cmd.Parameters.AddWithValue("@Flag", Flag);


                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                var st = new System.Diagnostics.StackTrace(ex, true );
                var  frame = st.GetFrame(st.FrameCount -1);
                var lineNumber = frame.GetFileLineNumber();
                ErrorLog el = new ErrorLog();
                el.Error("M_Designation_Information", "SaveOrUpdateWithADO",lineNumber.ToString(),ex.ToString());
            }
        }

       

        public void SaveWithQuery(M_Designation_Information_Model model)
        {
            string qry = "Insert into M_Designation_Information (DesignationCode,DesignationName,DesignationQualification,DesignationDescription,CreatedDate,UpdatedDate,CreatedBy,UpdatedBy,AcFlag) values ('"+model.DesignationCode + "','"+model.DesignationName + "','"+model.DesignationQualification + "','"+model.DesignationDescription + "',getdate(),getdate(),'"+model.CreatedBy + "','"+ model.UpdatedBy + "','"+model.AcFlag + "')";// sequence of character

            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class 
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class
            SqlCommand cmd = new SqlCommand();//provider of ADO.Net//used to execute commands at on database
            cmd.CommandText = qry; //It is set or return a string that contain a provider
            cmd.CommandType = CommandType.Text;//  should  contain text of a query that must be run on the server
            cmd.Connection = sqlcon;//Connecting string


            cmd.ExecuteNonQuery();// It's used for Execute sql command 
        }
            
        public void SaveWithQueryString(M_Designation_Information_Model model)
        {
            string qry = "Insert into M_Designation_Information (DesignationCode,DesignationName,DesignationQualification,DesignationDescription,CreatedDate,UpdatedDate,CreatedBy,UpdatedBy,AcFlag) values (@DesignationCode,@DesignationName,@DesignationQualification,@DesignationDescription,@CreatedDate,@UpdatedDate,@CreatedBy,@UpdatedBy,@AcFlag)";// sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class 
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class
            SqlCommand cmd =  new SqlCommand();//provider of ADO.Net//used to execute commands at on database



            try
            {


                cmd.CommandText = qry; ; //It is set or return a string that contain a provider
                cmd.CommandType = CommandType.Text;//  should  contain text of a query that must be run on the server
                cmd.Connection = sqlcon;//Connecting string


                cmd.Parameters.AddWithValue("@DesignationCode", model.DesignationCode);//Add a parameters by specifying its name
                cmd.Parameters.AddWithValue("@DesignationName", model.DesignationName);
                cmd.Parameters.AddWithValue("@DesignationQualification", model.DesignationQualification);
                cmd.Parameters.AddWithValue("@DesignationDescription", model.DesignationDescription);
                cmd.Parameters.AddWithValue("@CreatedDate", model.CreatedDate);
                cmd.Parameters.AddWithValue("@UpdatedDate", model.UpdatedDate);
                cmd.Parameters.AddWithValue("@CreatedBy", model.CreatedBy);
                cmd.Parameters.AddWithValue("@UpdatedBy", model.UpdatedBy);
                cmd.Parameters.AddWithValue("@AcFlag", model.AcFlag);

                cmd.ExecuteNonQuery();// It's used for Execute sql command 
            }
            catch(Exception ex)
            {
                var st = new System.Diagnostics.StackTrace(ex, true);
                var frame = st .GetFrame(st.FrameCount -1);
                var lineNumber =   frame.GetFileLineNumber();
                ErrorLog el = new ErrorLog();
                el.Error("M_Designation_Information", "SaveWithQueryString",lineNumber .ToString(),ex.ToString());

            }
            finally
            {
                sqlcon.Close();
                cmd.Dispose();
            }
        }
        public void SaveOrUpdateWithEntityFramework(M_Designation_Information_Model model)
        {
            throw new NotImplementedException();
        }
    }
}
