using MY_Db_Hospital_Managment.Master_Model;
using MY_Db_Hospital_Managment_Interface.Master_Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MY_Db_Hospital_Managment_Connection.My_Connection;
using My_Db_Hospital_Management_EntityFramework.MyDbContext;

namespace MY_Db_Hospital_Managment_Abstraction.MyAbstraction
{
    public class M_Employee_Information_Abstraction : I_M_Employee_Information
    {



        //this function for get datatable from sql using qry string
        
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



        //This Function Save or Update data in sql server with ADO.Net
        //THis Function Save or Update Data With store procedure throw

        public void SaveOeUpdateWithADO(M_Employee_Information_Model model)
        {
            string Flag = null;
            try
            {



                if (model.EmployeeId == 0)
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
            catch (Exception ex)
            {
                //This Is errorlog Function Called
                //This Function use to Save error in sql  
                //This Function help to  Finding error our Code and save this error in sql

                var st = new System.Diagnostics.StackTrace(ex, true);
                var frame = st.GetFrame(st.FrameCount - 1);
                var lineNumber = frame.GetFileLineNumber();
                ErrorLog el = new ErrorLog();
                el.Error("M_Employee_Information_Abstraction", "GetDataListWithADO", lineNumber.ToString(), ex.ToString());

            }
        }


        //This Function  Insert data in DataTable with help model   

        public void SaveWithQuery(M_Employee_Information_Model model)
        {
            string qry = "Insert into M_Employee_Information (EmployeeCode,EmployeeTitle,EmployeeGender,EmployeeName,EmployeeDesignation,EmployeeDepartment,EmployeeDob,EmployeeJoingDate,EmployeeAddress,EmployeeAddress1,EmployeeCity,EmployeePan,EmployeeAdharchard,EmployeeAlternetNo,EmployeeMobile,EmployeeEmailId,EmployeeBankName,EmployeeAccountNo,EmployeeIfscCode,EmployeeBranch,EmployeePhoto,CreatedBy,UpdateBy,CreatedDate,UpdatedDate,ActiveFlag,Attr1,Attr2,Attr3,Attr4) values ('" + model.EmployeeCode + "','" + model.EmployeeTitle + "','" + model.EmployeeGender + "','" + model.EmployeeName + "','" + model.EmployeeDesignation + "','" + model.EmployeeDepartment + "',getdate(),getdate(),'" + model.EmployeeAddress + "','" + model.EmployeeAddress1 + "','" + model.EmployeeCity + "','" + model.EmployeePan + "','" + model.EmployeeAdharchard + "','" + model.EmployeeAlternetNo + "','" + model.EmployeeMobile + "','" + model.EmployeeEmailId + "','" + model.EmployeeBankName + "','" + model.EmployeeAccountNo + "','" + model.EmployeeIfscCode + "','" + model.EmployeeBranch + "','" + model.EmployeePhoto + "','" + model.CreatedBy + "','" + model.CreatedBy + "',getdate(),getdate(),'" + model.ActiveFlag + "','" + model.Attr1 + "','" + model.Attr2 + "','" + model.Attr3 + "','" + model.Attr4 + "')";// sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class 
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand();//provider of ADO.Net  //used to execute commands at on database
            cmd.CommandText = qry; //It is set or return a string that contain a provider
            cmd.CommandType = CommandType.Text; //  should  contain text of a query that must be run on the server
            cmd.Connection = sqlcon;    //Connecting string

            cmd.ExecuteNonQuery();  // It's used for Execute sql command
        }

        //This Function  Insert data in DataTable with help model   
        public void SaveWithQueryString(M_Employee_Information_Model model)
        {
            string qry = "Insert into M_Employee_Information (EmployeeCode,EmployeeTitle,EmployeeGender,EmployeeName,EmployeeDesignation,EmployeeDepartment,EmployeeDob,EmployeeJoingDate,EmployeeAddress,EmployeeAddress1,EmployeeCity,EmployeePan,EmployeeAdharchard,EmployeeAlternetNo,EmployeeMobile,EmployeeEmailId,EmployeeBankName,EmployeeAccountNo,EmployeeIfscCode,EmployeeBranch,EmployeePhoto,CreatedBy,UpdateBy,CreatedDate,UpdatedDate,ActiveFlag,Attr1,Attr2,Attr3,Attr4) values (@EmployeeCode,@EmployeeTitle,@EmployeeGender,@EmployeeName,@EmployeeDesignation,@EmployeeDepartment,@EmployeeDob,@EmployeeJoingDate,@EmployeeAddress,@EmployeeAddress1,@EmployeeCity,@EmployeePan,@EmployeeAdharchard,@EmployeeAlternetNo,@EmployeeMobile,@EmployeeEmailId,@EmployeeBankName,@EmployeeAccountNo,@EmployeeIfscCode,@EmployeeBranch,@EmployeePhoto,@CreatedBy,@UpdateBy,@CreatedDate,@UpdatedDate,@ActiveFlag,@Attr1,@Attr2,@Attr3,@Attr4)";// sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class 
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand();  //provider of ADO.Net//used to execute commands at on database


            // This Is Try/Catch condition
            //Try/Catch Condition use to Finding error

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
                //This Is errorlog Function Called
                //This Function use to Save error in sql  
                //This Function help to  Finding error our Code and save this error in sql

                var st = new System.Diagnostics.StackTrace(ex, true);
                var frame = st.GetFrame(st.FrameCount - 1);
                var lineNumber = frame.GetFileLineNumber();
                ErrorLog el = new ErrorLog();
                el.Error("M_Employee_Information_Abstraction", "SaveWithQueryString", lineNumber.ToString(), ex.ToString());

            }
            finally
            {
                sqlcon.Close();
                cmd.Dispose();
            }

        }

        //This Function return a Datatable in list form 
        //This function get data With help ADO

        public List<M_Employee_Information_Model> GetDataListWithADO()
        {
            DataTable dt = GetDataTable();
            List<M_Employee_Information_Model> _List = new List<M_Employee_Information_Model>();


            // This Is Try/Catch condition
            //Try/Catch Condition use to Finding error 

            try
            {

                //This is for Loop Condition

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    M_Employee_Information_Model model = new M_Employee_Information_Model(); //Create model object 
                    model.EmployeeId = Convert.ToInt32(dt.Rows[i]["EmployeeId"]);
                    model.EmployeeCode = dt.Rows[i]["EmployeeCode"].ToString();
                    model.EmployeeTitle = Convert.ToInt32(dt.Rows[i]["EmployeeTitle"]);
                    model.EmployeeGender = Convert.ToInt32(dt.Rows[i]["EmployeeGender"]);
                    model.EmployeeName = dt.Rows[i]["Name"].ToString();
                    model.EmployeeDesignation = Convert.ToInt32(dt.Rows[i]["EmployeeDesignation"]);
                    model.EmployeeDepartment = Convert.ToInt32(dt.Rows[i]["EmployeeDepartment"]);
                    model.EmployeeDob = Convert.ToDateTime(dt.Rows[i]["EmployeeDob"]);
                    model.EmployeeJoingDate = Convert.ToDateTime(dt.Rows[i]["EmployeeJoingDate"]);
                    model.EmployeeAddress = dt.Rows[i]["EmployeeAddress"].ToString();
                    model.EmployeeAddress1 = dt.Rows[i]["EmployeeAddress1"].ToString();
                    model.EmployeeCity = dt.Rows[i]["EmployeeCity"].ToString();
                    model.EmployeePan = dt.Rows[i]["EmployeePan"].ToString();
                    model.EmployeeAdharchard = dt.Rows[i]["EmployeeAdharchard"].ToString();
                    model.EmployeeAlternetNo = dt.Rows[i]["EmployeeAlternetNo"].ToString();
                    model.EmployeeMobile = dt.Rows[i]["EmployeeMobile"].ToString();
                    model.EmployeeEmailId = dt.Rows[i]["EmployeeEmailId"].ToString();
                    model.EmployeeBankName = Convert.ToInt32(dt.Rows[i]["EmployeeBankName"]);
                    model.EmployeeAccountNo = dt.Rows[i]["EmployeeAccountNo"].ToString();
                    model.EmployeeIfscCode = dt.Rows[i]["EmployeeIfscCode"].ToString();
                    model.EmployeeBranch = Convert.ToInt32(dt.Rows[i]["EmployeeBranch"]);
                    model.EmployeePhoto = dt.Rows[i]["EmployeePhoto"].ToString();
                    model.CreatedBy = Convert.ToInt32(dt.Rows[i]["CreatedBy"]);
                    model.UpdatedBy = Convert.ToInt32(dt.Rows[i]["UpdatedBy"]);
                    model.CreatedDate = Convert.ToDateTime(dt.Rows[i]["CreatedDate"]);
                    model.UpdatedDate = Convert.ToDateTime(dt.Rows[i]["UpdatedDate"]);
                    model.ActiveFlag = Convert.ToBoolean(dt.Rows[i]["ActiveFlag"]);
                    model.Attr1 = dt.Rows[i]["Attr1"].ToString();
                    model.Attr2 = dt.Rows[i]["Attr2"].ToString();
                    model.Attr3 = dt.Rows[i]["Attr3"].ToString();
                    model.Attr4 = Convert.ToInt32(dt.Rows[i]["Attr4"]);

                    _List .Add(model);
                }
            }
            catch (Exception ex)
            {
                //This Is errorlog Function Called
                //This Function use to Save error in sql  
                //This Function help to  Finding error our Code and save this error in sql

                var st = new System.Diagnostics.StackTrace(ex, true);
                var frame = st.GetFrame(st.FrameCount - 1);
                var lineNumber = frame.GetFileLineNumber();
                ErrorLog el = new ErrorLog();
                el.Error("M_Employee_Information_Abstraction", "GetDataListWithADO", lineNumber.ToString(), ex.ToString());

            }

            return _List;
        }


        //THIS Function Save or Update Data in DataTable  with help EntityFrameWork 
        //This Function use to Insert or update  data in DataTable 

        public void SaveOrUpdatewithenityFrameWork(M_Employee_Information_Model model)
        {

            // This Is Try/Catch condition
            //Try/Catch Condition use to Finding error 

            try
            {

                //This is Connection string (MY_Db_Hospital_ManagmentEntities)
                //Object decalraction of  Connection string  

                using (MY_Db_Hospital_ManagmentEntities db = new MY_Db_Hospital_ManagmentEntities())
                {

                    //This IS IF Else Condition 
                    //ITs use to insert or update data in dataTable 

                    if (model.EmployeeId == 0)
                    {
                        M_Employee_Information tbl = new M_Employee_Information()//This is Table Object
                        {
                            EmployeeCode = model.EmployeeCode,
                            EmployeeTitle = model.EmployeeTitle,
                            EmployeeGender = model.EmployeeGender,
                            EmployeeName = model.EmployeeName,
                            EmployeeDesignation = model.EmployeeDesignation,
                            EmployeeDepartment = model.EmployeeDepartment,
                            EmployeeDob = model.EmployeeDob,
                            EmployeeJoingDate = model.EmployeeJoingDate,
                            EmployeeAddress = model.EmployeeAddress,
                            EmployeeAddress1 = model.EmployeeAddress1,
                            EmployeeCity = model.EmployeeCity,
                            EmployeePan = model.EmployeePan,
                            EmployeeAdharchard = model.EmployeeAdharchard,
                            EmployeeAlternetNo = model.EmployeeAlternetNo,
                        };
                        db.Entry(tbl).State = EntityState.Added;//This linq statement save data in datatable 
                        db.SaveChanges();

                    }
                    else
                    {
                        M_Employee_Information tbl = new M_Employee_Information()//This is Table Object
                        {
                            EmployeeCode = model.EmployeeCode,
                            EmployeeTitle = model.EmployeeTitle,
                            EmployeeGender = model.EmployeeGender,
                            EmployeeName = model.EmployeeName,
                            EmployeeDesignation = model.EmployeeDesignation,
                            EmployeeDepartment = model.EmployeeDepartment,
                            EmployeeDob = model.EmployeeDob,
                            EmployeeJoingDate = model.EmployeeJoingDate,
                            EmployeeAddress = model.EmployeeAddress,
                            EmployeeAddress1 = model.EmployeeAddress1,
                            EmployeeCity = model.EmployeeCity,
                            EmployeePan = model.EmployeePan,
                            EmployeeAdharchard = model.EmployeeAdharchard,
                            EmployeeAlternetNo = model.EmployeeAlternetNo,
                        };
                        db.Entry(tbl).State = EntityState.Modified;//This linq statement save data in datatable 
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                //This Is errorlog Function Called
                //This Function use to Save error in sql  
                //This Function help to  Finding error our Code and save this error in sql

                var st = new System.Diagnostics.StackTrace(ex, true);
                var frame = st.GetFrame(st.FrameCount - 1);
                var lineNumber = frame.GetFileLineNumber();
                ErrorLog el = new ErrorLog();
                el.Error("M_Employee_Information_Abstraction", "SaveOrUpdateWithEntityFramework", lineNumber.ToString(), ex.ToString());

            }
        }


        //This Is EntityFrameWork Function 
        //This Function Get data in list format

        public List<M_Employee_Information> GetDataListWithEntityFramework()
        {

            //This is Connection string (MY_Db_Hospital_ManagmentEntities)
            //Object decalraction of  Connection string  

            MY_Db_Hospital_ManagmentEntities db = new MY_Db_Hospital_ManagmentEntities();

            return db.M_Employee_Information.ToList();//linq query        
        }
    }
}
