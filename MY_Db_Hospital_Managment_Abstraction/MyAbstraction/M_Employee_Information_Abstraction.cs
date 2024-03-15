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
    public  class M_Employee_Information_Abstraction : I_M_Employee_Information
    {



        //this function for get datatable from sql using qry string
        //
        public DataTable GetDataTable()
        {
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class 
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand("select * from M_Employee_Information", sqlcon);//provider of ADO.Net//used to execute commands at on database
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);//Use for retrive data from sql
            DataTable _datatable = new DataTable();//object  declaration of DataTable
            adapter.Fill(_datatable);//called fill() from SqlDataAdapter class for to fill my datatable

            return _datatable;//Connecting string
       
    }

        public void SaveOeUpdateWithADO(M_Employee_Information_Model model)
        {
            string Flag = null;
            if (model.EmployeeId==0)
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
            cmd.CommandText = "Sp_M_Employee_Information";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlcon;

            cmd.Parameters.AddWithValue("@EmployeeId", model.EmployeeId);
            cmd.Parameters.AddWithValue("@EmployeeCode", model.EmployeeCode);//Add a parameters by specifying its name
            cmd.Parameters.AddWithValue("@EmployeeTitle", model.EmployeeTitle);
            cmd.Parameters.AddWithValue("@EmployeeGender", model.EmployeeGender);
            cmd.Parameters.AddWithValue("@EmployeeName", model.EmployeeName);
            cmd.Parameters.AddWithValue("@EmployeeDesignation", model.EmployeeDesignation);
            cmd.Parameters.AddWithValue("@EmployeeDepartment", model.EmployeeDepartment);
            cmd.Parameters.AddWithValue("@EmployeeDob", model.EmployeeDob);
            cmd.Parameters.AddWithValue("@EmployeeJoingDate", model.EmployeeJoingDate);
            cmd.Parameters.AddWithValue("@EmployeeAddress", model.EmployeeAddress);
            cmd.Parameters.AddWithValue("@EmployeeAddress1", model.EmployeeAddress1);
            cmd.Parameters.AddWithValue("@EmployeeCity", model.EmployeeCity);
            cmd.Parameters.AddWithValue("@EmployeePan", model.EmployeePan);
            cmd.Parameters.AddWithValue("@EmployeeAdharchard", model.EmployeeAdharchard);
            cmd.Parameters.AddWithValue("@EmployeeAlternetNo", model.EmployeeAlternetNo);
            cmd.Parameters.AddWithValue("@EmployeeMobile", model.EmployeeMobile);
            cmd.Parameters.AddWithValue("@EmployeeEmailId", model.EmployeeEmailId);
            cmd.Parameters.AddWithValue("@EmployeeBankName", model.EmployeeBankName);
            cmd.Parameters.AddWithValue("@EmployeeAccountNo", model.EmployeeAccountNo);
            cmd.Parameters.AddWithValue("@EmployeeIfscCode", model.EmployeeIfscCode);
            cmd.Parameters.AddWithValue("@EmployeeBranch", model.EmployeeBranch);
            cmd.Parameters.AddWithValue("@EmployeePhoto", model.EmployeePhoto);
            cmd.Parameters.AddWithValue("@CreatedBy", model.CreatedBy);
            cmd.Parameters.AddWithValue("@UpdateBy", model.UpdatedBy);
            cmd.Parameters.AddWithValue("@CreatedDate", model.CreatedDate);
            cmd.Parameters.AddWithValue("@UpdatedDate", model.UpdatedDate);
            cmd.Parameters.AddWithValue("@ActiveFlag", model.ActiveFlag);
            cmd.Parameters.AddWithValue("@Attr1", model.Attr1);
            cmd.Parameters.AddWithValue("@Attr2", model.Attr2);
            cmd.Parameters.AddWithValue("@Attr3", model.Attr3);
            cmd.Parameters.AddWithValue("@Attr4", model.Attr4);
            cmd.Parameters.AddWithValue("@Flag", Flag);


            cmd.ExecuteNonQuery();
        }

       
        public void SaveWithQuery(M_Employee_Information_Model model)
        {
            string qry = "Insert into M_Employee_Information (EmployeeCode,EmployeeTitle,EmployeeGender,EmployeeName,EmployeeDesignation,EmployeeDepartment,EmployeeDob,EmployeeJoingDate,EmployeeAddress,EmployeeAddress1,EmployeeCity,EmployeePan,EmployeeAdharchard,EmployeeAlternetNo,EmployeeMobile,EmployeeEmailId,EmployeeBankName,EmployeeAccountNo,EmployeeIfscCode,EmployeeBranch,EmployeePhoto,CreatedBy,UpdateBy,CreatedDate,UpdatedDate,ActiveFlag,Attr1,Attr2,Attr3,Attr4) values ('"+model.EmployeeCode + "','"+model.EmployeeTitle + "','"+model.EmployeeGender + "','"+model.EmployeeName + "','"+model.EmployeeDesignation + "','"+model.EmployeeDepartment + "',getdate(),getdate(),'"+model.EmployeeAddress + "','"+model.EmployeeAddress1 + "','"+model.EmployeeCity + "','"+model.EmployeePan + "','"+model.EmployeeAdharchard + "','"+model.EmployeeAlternetNo + "','"+model.EmployeeMobile + "','"+model.EmployeeEmailId + "','"+model.EmployeeBankName + "','"+model.EmployeeAccountNo + "','"+model.EmployeeIfscCode + "','"+model.EmployeeBranch + "','"+model.EmployeePhoto + "','"+model.CreatedBy + "','"+model.CreatedBy + "',getdate(),getdate(),'"+model.ActiveFlag + "','"+model.Attr1 + "','"+model.Attr2 + "','"+model.Attr3 + "','"+model.Attr4 + "')";// sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class 
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand();//provider of ADO.Net  //used to execute commands at on database
            cmd.CommandText = qry; //It is set or return a string that contain a provider
            cmd.CommandType = CommandType.Text; //  should  contain text of a query that must be run on the server
            cmd.Connection = sqlcon;    //Connecting string

            cmd.ExecuteNonQuery();  // It's used for Execute sql command
        }

        public void SaveWithQueryString(M_Employee_Information_Model model)
        {
            string qry = "Insert into M_Employee_Information (EmployeeCode,EmployeeTitle,EmployeeGender,EmployeeName,EmployeeDesignation,EmployeeDepartment,EmployeeDob,EmployeeJoingDate,EmployeeAddress,EmployeeAddress1,EmployeeCity,EmployeePan,EmployeeAdharchard,EmployeeAlternetNo,EmployeeMobile,EmployeeEmailId,EmployeeBankName,EmployeeAccountNo,EmployeeIfscCode,EmployeeBranch,EmployeePhoto,CreatedBy,UpdateBy,CreatedDate,UpdatedDate,ActiveFlag,Attr1,Attr2,Attr3,Attr4) values (@EmployeeCode,@EmployeeTitle,@EmployeeGender,@EmployeeName,@EmployeeDesignation,@EmployeeDepartment,@EmployeeDob,@EmployeeJoingDate,@EmployeeAddress,@EmployeeAddress1,@EmployeeCity,@EmployeePan,@EmployeeAdharchard,@EmployeeAlternetNo,@EmployeeMobile,@EmployeeEmailId,@EmployeeBankName,@EmployeeAccountNo,@EmployeeIfscCode,@EmployeeBranch,@EmployeePhoto,@CreatedBy,@UpdateBy,@CreatedDate,@UpdatedDate,@ActiveFlag,@Attr1,@Attr2,@Attr3,@Attr4)";// sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class 
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand();  //provider of ADO.Net//used to execute commands at on database


            try
            {

                cmd.CommandText = qry; //It is set or return a string that contain a provider
                cmd.CommandType = CommandType.Text;//  should  contain text of a query that must be run on the server
                cmd.Connection = sqlcon;//Connecting string

                cmd.Parameters.AddWithValue("@EmployeeCode", model.EmployeeCode);//Add a parameters by specifying its name
                cmd.Parameters.AddWithValue("@EmployeeTitle", model.EmployeeTitle);
                cmd.Parameters.AddWithValue("@EmployeeGender", model.EmployeeGender);
                cmd.Parameters.AddWithValue("@EmployeeName", model.EmployeeName);
                cmd.Parameters.AddWithValue("@EmployeeDesignation", model.EmployeeDesignation);
                cmd.Parameters.AddWithValue("@EmployeeDepartment", model.EmployeeDepartment);
                cmd.Parameters.AddWithValue("@EmployeeDob", model.EmployeeDob);
                cmd.Parameters.AddWithValue("@EmployeeJoingDate", model.EmployeeJoingDate);
                cmd.Parameters.AddWithValue("@EmployeeAddress", model.EmployeeAddress);
                cmd.Parameters.AddWithValue("@EmployeeAddress1", model.EmployeeAddress1);
                cmd.Parameters.AddWithValue("@EmployeeCity", model.EmployeeCity);
                cmd.Parameters.AddWithValue("@EmployeePan", model.EmployeePan);
                cmd.Parameters.AddWithValue("@EmployeeAdharchard", model.EmployeeAdharchard);
                cmd.Parameters.AddWithValue("@EmployeeAlternetNo", model.EmployeeAlternetNo);
                cmd.Parameters.AddWithValue("@EmployeeMobile", model.EmployeeMobile);
                cmd.Parameters.AddWithValue("@EmployeeEmailId", model.EmployeeEmailId);
                cmd.Parameters.AddWithValue("@EmployeeBankName", model.EmployeeBankName);
                cmd.Parameters.AddWithValue("@EmployeeAccountNo", model.EmployeeAccountNo);
                cmd.Parameters.AddWithValue("@EmployeeIfscCode", model.EmployeeIfscCode);
                cmd.Parameters.AddWithValue("@EmployeeBranch", model.EmployeeBranch);
                cmd.Parameters.AddWithValue("@EmployeePhoto", model.EmployeePhoto);
                cmd.Parameters.AddWithValue("@CreatedBy", model.CreatedBy);
                cmd.Parameters.AddWithValue("@UpdateBy", model.UpdatedBy);
                cmd.Parameters.AddWithValue("@CreatedDate", model.CreatedDate);
                cmd.Parameters.AddWithValue("@UpdatedDate", model.UpdatedDate);
                cmd.Parameters.AddWithValue("@ActiveFlag", model.ActiveFlag);
                cmd.Parameters.AddWithValue("@Attr1", model.Attr1);
                cmd.Parameters.AddWithValue("@Attr2", model.Attr2);
                cmd.Parameters.AddWithValue("@Attr3", model.Attr3);
                cmd.Parameters.AddWithValue("@Attr4", model.Attr4);

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

        public void SaveOrUpdatewithenityFrameWork(M_Employee_Information_Model model)
        {
            try
            {
                using (MY_Db_Hospital_ManagmentEntities db= new MY_Db_Hospital_ManagmentEntities())
                {
                    if (model.EmployeeId==0)
                    {
                        M_Employee_Information tbl = new M_Employee_Information()
                        {
                            EmployeeCode = model.EmployeeCode,
                            EmployeeTitle= model.EmployeeTitle,
                            EmployeeGender= model.EmployeeGender,
                            EmployeeName= model.EmployeeName,
                            EmployeeDesignation= model.EmployeeDesignation,
                            EmployeeDepartment= model.EmployeeDepartment,
                            EmployeeDob= model.EmployeeDob,
                            EmployeeJoingDate= model.EmployeeJoingDate,
                            EmployeeAddress= model.EmployeeAddress,
                            EmployeeAddress1= model.EmployeeAddress1,
                            EmployeeCity=   model.EmployeeCity,
                            EmployeePan= model.EmployeePan,
                            EmployeeAdharchard= model.EmployeeAdharchard,
                            EmployeeAlternetNo= model.EmployeeAlternetNo,
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
 

}
