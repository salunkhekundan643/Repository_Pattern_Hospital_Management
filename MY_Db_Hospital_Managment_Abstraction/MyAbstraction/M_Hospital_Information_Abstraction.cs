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
using My_Db_Hospital_Management_EntityFramework.MyDbContext;
using System.Data.Entity;

namespace MY_Db_Hospital_Managment_Abstraction.MyAbstraction
{
    public class M_Hospital_Information_Abstraction : I_M_Hospital_Information
    {

        //this function for get datatable from sql using qry string
        public DataTable GetDataTable()
        {
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class 
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand("Select * from M_Hospital_Information", sqlcon);//provider of ADO.Net//used to execute commands at on database
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);//Use for retrive data from sql
            DataTable _datatable = new DataTable();//object  declaration of DataTable
            adapter.Fill(_datatable);//called fill() from SqlDataAdapter class for to fill my datatable

            return _datatable;  //Connecting string

        }



        //This Function Save or Update data in sql server with ADO.Net
        //THis Function Save or Update Data With store procedure throw

        public void SaveOrUpdateWithADO(M_Hospital_Information_Model model)
        {
            string Flag = null;

            // This Is Try/Catch condition
            //Try/Catch Condition use to Finding error 

            try
            {

                //This IS IF Else Condition 
                //Its use to insert or update data in dataTable 
                if (model.HospitalId == 0)
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
                cmd.Connection = sqlcon;

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


                cmd.ExecuteNonQuery();//It's used for Execute sql command 
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
                el.Error("M_Hospital_Information_Abstraction", "SaveOrUpdateWithADO", lineNumber.ToString(), ex.ToString());

            }
        }


        //This Function save data with Query throw 

        public void SaveWithQuery(M_Hospital_Information_Model model)
        {
            string qry = "Insert into M_Hospital_Information (HospitalName,HospitalAddress,HospitalEmailAddress,Logo,HospitalCity,HospitalPan,HospitalContactNumber,HospitalContactNumber1,Hospitalwedsite,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate) values ('" + model.HospitalName + "','" + model.HospitalAddress + "','" + model.HospitalEmailAddress + "','" + model.Logo + "','" + model.HospitalCity + "','" + model.HospitalPan + "','" + model.HospitalContactNumber + "','" + model.HospitalContactNumber1 + "','" + model.Hospitalwedsite + "','" + model.CreatedBy + "',getdate(),'" + model.UpdatedBy + "',getdate())";// sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class 
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class
            SqlCommand cmd = new SqlCommand();//provider of ADO.Net//used to execute commands at on database
            cmd.CommandText = qry;//It is set or return a string that contain a provider
            cmd.CommandType = CommandType.Text;//  should  contain text of a query that must be run on the server
            cmd.Connection = sqlcon;    //Connecting string

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
            catch (Exception ex)
            {
                //this Is errorlog Function Called
                //THis Function use to Save error in sql  
                //This Function help to  Finding error our Code and save this error in sql

                var st = new System.Diagnostics.StackTrace(ex, true);
                var frame = st.GetFrame(st.FrameCount - 1);
                var lineNumber = frame.GetFileLineNumber();
                ErrorLog el = new ErrorLog();
                el.Error("M_Hospital_Information_Abstraction", "SaveWithQueryString", lineNumber.ToString(), ex.ToString());
            }
            finally
            {
                sqlcon.Close();
                cmd.Dispose();
            }
        }

        //This Function return a Datatable in list form 
        //This function get data With help ADO

        public List<M_Hospital_Information_Model> GetDataListWithADO()
        {
            DataTable dt = GetDataTable();
            List<M_Hospital_Information_Model> _List = new List<M_Hospital_Information_Model>();

            // This Is Try/Catch condition
            //Try/Catch Condition use to Finding error 

            try
            {

                //This is for Loop Condition

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    M_Hospital_Information_Model model = new M_Hospital_Information_Model(); //Create model object 
                    model.HospitalId = Convert.ToInt32(dt.Rows[i]["HospitalId"]);
                    model.HospitalName = dt.Rows[i]["HospitalName"].ToString();
                    model.HospitalAddress = dt.Rows[i]["HospitalAddress"].ToString();
                    model.Logo = dt.Rows[i]["Logo"].ToString();
                    model.HospitalCity = dt.Rows[i]["HospitalCity"].ToString();
                    model.HospitalPan = dt.Rows[i]["HospitalPan"].ToString();
                    model.HospitalContactNumber = dt.Rows[i]["HospitalContactNumber"].ToString();
                    model.HospitalContactNumber1 = dt.Rows[i]["HospitalContactNumber1"].ToString();
                    model.Hospitalwedsite = dt.Rows[i]["Hospitalwedsite"].ToString();
                    model.CreatedBy = Convert.ToInt32(dt.Rows[i]["CreatedBy"]);
                    model.CreatedDate = Convert.ToDateTime(dt.Rows[i]["CreatedDate"]);
                    model.UpdatedBy = Convert.ToInt32(dt.Rows[i]["UpdatedBy"]);
                    model.UpdatedDate = Convert.ToDateTime(dt.Rows[i]["UpdatedDate"]);

                    _List.Add(model);

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
                el.Error("M_Hospital_Information_Abstraction", "GetDataListWithADO", lineNumber.ToString(), ex.ToString());

            }
            return _List;
        }


        //THIS Function Save or Update Data in DataTable  with help EntityFrameWork 
        //This Function use to Insert or update  data in DataTable 

        public void SaveOrUpdatewithenityFrameWork(M_Hospital_Information_Model model)
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

                    if (model.HospitalId == 0)
                    {
                        M_Hospital_Information tbl = new M_Hospital_Information()//This is Table Object
                        {

                            HospitalName = model.HospitalName,
                            HospitalAddress = model.HospitalAddress,
                            HospitalEmailAddress= model.HospitalEmailAddress,
                            Logo= model.Logo,
                            HospitalCity= model.HospitalCity,
                            HospitalPan= model.HospitalPan,
                            HospitalContactNumber = model.HospitalContactNumber,
                            HospitalContactNumber1= model.HospitalContactNumber1,
                            Hospitalwedsite= model.Hospitalwedsite,
                            CreatedBy = model.CreatedBy,
                            CreatedDate= model.CreatedDate,
                            UpdatedBy= model.UpdatedBy,
                            UpdatedDate= model.UpdatedDate,

                        };
                        db.Entry(tbl).State = EntityState.Added;//This linq statement save data in datatable 
                        db.SaveChanges();

                    }
                    else
                    {
                        M_Hospital_Information tbl = new M_Hospital_Information()//This is Table Object
                        {

                            HospitalName = model.HospitalName,
                            HospitalAddress = model.HospitalAddress,
                            HospitalEmailAddress = model.HospitalEmailAddress,
                            Logo = model.Logo,
                            HospitalCity = model.HospitalCity,
                            HospitalPan = model.HospitalPan,
                            HospitalContactNumber = model.HospitalContactNumber,
                            HospitalContactNumber1 = model.HospitalContactNumber1,
                            Hospitalwedsite = model.Hospitalwedsite,
                            CreatedBy = model.CreatedBy,
                            CreatedDate = model.CreatedDate,
                            UpdatedBy = model.UpdatedBy,
                            UpdatedDate = model.UpdatedDate,

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
                el.Error("M_Hospital_Information_Abstraction", "SaveOrUpdatewithenityFrameWork", lineNumber.ToString(), ex.ToString());

            }

        }


        //This Is EntityFrameWork Function 
        //This Function Get data in list format

        public List<M_Hospital_Information> GetDataListWithEntityFramework()
        {

            //This is Connection string (MY_Db_Hospital_ManagmentEntities)
            //Object decalraction of  Connection string  

            MY_Db_Hospital_ManagmentEntities db = new MY_Db_Hospital_ManagmentEntities();

            return db.M_Hospital_Information.ToList();//linq query        
        }
    }
}

