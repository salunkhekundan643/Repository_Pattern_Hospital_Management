using MY_Db_Hospital_Managment.Master_Model;
using MY_Db_Hospital_Managment_Interface.Master_Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using MY_Db_Hospital_Managment_Connection.My_Connection;
using My_Db_Hospital_Management_EntityFramework.MyDbContext;

namespace MY_Db_Hospital_Managment_Abstraction.MyAbstraction
{
    public  class M_Designation_Information_Abstraction : I_M_Designation_Information
    {


        //this function for get datatable from sql using qry string
        
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


        //This Function Save or Update data in sql server with ADO.Net
        //THis Function Save or Update Data With store procedure throw

        public void SaveOrUpdateWithADO(M_Designation_Information_Model model)
        {
            string Flag = null;

            // This Is Try/Catch condition
            //Try/Catch Condition use to Finding error 

            try
            {
                //This IS IF Else Condition 
                //ITs use to insert or update data in dataTable 

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

                //this Is errorlog Function Called
                //THis Function use to Save error in sql  
                //This Function help to  Finding error our Code and save this error in sql

                var st = new System.Diagnostics.StackTrace(ex, true );
                var  frame = st.GetFrame(st.FrameCount -1);
                var lineNumber = frame.GetFileLineNumber();
                ErrorLog el = new ErrorLog();
                el.Error("M_Designation_Information_Abstraction", "SaveOrUpdateWithADO",lineNumber.ToString(),ex.ToString());
            }
        }


        //This Function save data with Query throw 
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


        //This Function  Insert data in DataTable with help model   
        public void SaveWithQueryString(M_Designation_Information_Model model)
        {
            string qry = "Insert into M_Designation_Information (DesignationCode,DesignationName,DesignationQualification,DesignationDescription,CreatedDate,UpdatedDate,CreatedBy,UpdatedBy,AcFlag) values (@DesignationCode,@DesignationName,@DesignationQualification,@DesignationDescription,@CreatedDate,@UpdatedDate,@CreatedBy,@UpdatedBy,@AcFlag)";// sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class 
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class
            SqlCommand cmd =  new SqlCommand();//provider of ADO.Net//used to execute commands at on database


            // This Is Try/Catch condition
            //Try/Catch Condition use to Finding error 

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

                //this Is errorlog Function Called
                //THis Function use to Save error in sql  
                //This Function help to  Finding error our Code and save this error in sql

                var st = new System.Diagnostics.StackTrace(ex, true);
                var frame = st .GetFrame(st.FrameCount -1);
                var lineNumber =   frame.GetFileLineNumber();
                ErrorLog el = new ErrorLog();
                el.Error("M_Designation_Information_Abstraction", "SaveWithQueryString",lineNumber .ToString(),ex.ToString());

            }
            finally
            {
                sqlcon.Close();
                cmd.Dispose();
            }
        }

        //This Function return a Datatable in list form 
        //This function get data With help ADO
        public List<M_Designation_Information_Model> GetDataListWithADO()
        {
            DataTable dt = GetDataTable();
            List<M_Designation_Information_Model> _List = new List<M_Designation_Information_Model>();


            // This Is Try/Catch condition
            //Try/Catch Condition use to Finding error 

            try
            {

                //This is for Loop Condition

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    M_Designation_Information_Model model = new M_Designation_Information_Model();//Create model object 

                    model.DesignationId = Convert.ToInt32(dt.Rows[i]["DesignationId"]);
                    model.DesignationCode = dt.Rows[i]["DesignationCode"].ToString();
                    model.DesignationName = dt.Rows[i]["DesignationName"].ToString();
                    model.DesignationQualification = dt.Rows[i]["DesignationQualification"].ToString();
                    model.DesignationDescription = dt.Rows[i]["DesignationDescription"].ToString();
                    model.CreatedDate = Convert.ToDateTime(dt.Rows[i]["CreatedDate"]);
                    model.UpdatedDate = Convert.ToDateTime(dt.Rows[i]["UpdatedDate"]);
                    model.CreatedBy = Convert.ToInt32(dt.Rows[i]["CreatedBy"]);
                    model.UpdatedBy = Convert.ToInt32(dt.Rows[i]["UpdatedBy"]);
                    model.AcFlag = (dt.Rows[i]["AcFlag"]).ToString();

                    _List.Add(model);
                }
            }
            catch (Exception ex)
            {

                //this Is errorlog Function Called
                //THis Function use to Save error in sql  
                //This Function help to  Finding error our Code and save this error in sql

                var st =new System.Diagnostics.StackTrace(ex,true );
                var frame = st.GetFrame(st.FrameCount -1);
                var lineNumber = frame.GetFileLineNumber();
                ErrorLog el = new ErrorLog();
                el.Error("M_Designation_Information_Abstraction", "GetDataListWithADO",lineNumber.ToString(),ex.ToString());

            }

            return _List;
        }


        //THIS Function Save or Update Data in DataTable  with help EntityFrameWork 
        //This Function use to Insert or update  data in DataTable 
        public void SaveOrUpdateWithEntityFramework(M_Designation_Information_Model model)
        {

            // This Is Try/Catch condition
            //Try/Catch Condition use to Finding error 

            try
            {

                //This is Connection string (MY_Db_Hospital_ManagmentEntities)
                //Object decalraction of  Connection string  
                using (MY_Db_Hospital_ManagmentEntities db= new MY_Db_Hospital_ManagmentEntities())
                {

                    //This IS IF Else Condition 
                    //ITs use to insert or update data in dataTable 

                    if (model.DesignationId==0)
                    {
                        M_Designation_Information tbl = new M_Designation_Information()//This is Table Object
                        {
                            DesignationCode = model.DesignationCode,
                            DesignationName= model.DesignationDescription,
                            DesignationQualification= model.DesignationQualification,
                            DesignationDescription= model.DesignationDescription,
                            CreatedDate= model.CreatedDate,
                            UpdatedDate= model.UpdatedDate,
                            CreatedBy= model.CreatedBy,
                            UpdatedBy= model.UpdatedBy,
                            AcFlag= model.AcFlag

                        };
                        db.Entry(tbl).State=EntityState.Added;//This linq statement save data in datatable
                        db.SaveChanges();
                    }
                    else
                    {
                        M_Designation_Information tbl = new M_Designation_Information()//This is Table Object
                        {
                            DesignationCode = model.DesignationCode,
                            DesignationName = model.DesignationDescription,
                            DesignationQualification = model.DesignationQualification,
                            DesignationDescription = model.DesignationDescription,
                            CreatedDate = model.CreatedDate,
                            UpdatedDate = model.UpdatedDate,
                            CreatedBy = model.CreatedBy,
                            UpdatedBy = model.UpdatedBy,
                            AcFlag = model.AcFlag

                        };
                        db.Entry(tbl).State = EntityState.Modified;//This linq statement save data in datatable
                        db.SaveChanges();
                    }
                }
               
            }
            catch (Exception ex)
            {

                //this Is errorlog Function Called
                //THis Function use to Save error in sql  
                //This Function help to  Finding error our Code and save this error in sql

                var st = new System.Diagnostics.StackTrace(ex, true);
                var frame = st.GetFrame(st.FrameCount - 1);
                var lineNumber = frame.GetFileLineNumber();
                ErrorLog el = new ErrorLog();
                el.Error("M_Designation_Information_Abstraction", "SaveOrUpdateWithEntityFramework", lineNumber.ToString(), ex.ToString());

            }
        }


        //This Is EntityFrameWork Function 
        //This Function Get data in list format
        public List<M_Designation_Information> GetDataListWithEntityFramework()
        {
            //This is Connection string (MY_Db_Hospital_ManagmentEntities)
            //Object decalraction of  Connection string  

            MY_Db_Hospital_ManagmentEntities db = new MY_Db_Hospital_ManagmentEntities();

            return db.M_Designation_Information.ToList();//linq query
        }
    }
}
