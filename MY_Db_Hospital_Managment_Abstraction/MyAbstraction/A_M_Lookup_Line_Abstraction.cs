using MY_Db_Hospital_Managment_Interface.Master_Interface;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MY_Db_Hospital_Managment_Connection.My_Connection;
using System.Data.SqlClient;
using System.Data;
using MY_Db_Hospital_Managment.Master_Model;
using static System.Net.Mime.MediaTypeNames;
using My_Db_Hospital_Management_EntityFramework.MyDbContext;



namespace MY_Db_Hospital_Managment_Abstraction.MyAbstraction
{
    public  class A_M_Lookup_Line_Abstraction : I_A_M_Lookup_Line
    {

        //this function for get datatable from sql using qry string
        
        public DataTable GetDataTable()
        {
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class 
            SqlConnection sqlcon =cls.Connect();//called connect() method from Clsfunction class 
            SqlCommand cmd = new SqlCommand("select * from A_M_Lookup_Line", sqlcon);//provider of ADO.Net//used to execute commands at on database
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);//Use for retrive data from sql
            DataTable _datatable = new DataTable();//object  declaration of DataTable
            adapter.Fill(_datatable);//called fill() from SqlDataAdapter class for to fill my datatable

            return _datatable;//Connecting string 
        }
    
        public DataTable GetDataTableThrughSp()
        {
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class 
            SqlConnection sqlcon = cls.Connect();//called connect() method from Clsfunction class 
            SqlCommand cmd = new SqlCommand("A_M_Lookup_Line", sqlcon);//provider of ADO.Net//used to execute commands at on database
            cmd.CommandType = CommandType.StoredProcedure;//called fill() from SqlDataAdapter class for to fill my datatable
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);//Use for retrive data from sql
            DataTable _datatable = new DataTable();//object  declaration of DataTable
            adapter.Fill(_datatable);//called fill() from SqlDataAdapter class for to fill my datatable

            return _datatable;//Connecting string 
        }

        //This Functin get data in datatable with Id 
        public DataTable GetDataTableWithId(int id)
        {
 
            string qry = "select * from A_M_Lookup_Line where id="+id;//sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class 
            SqlConnection sqlcon = cls.Connect();//called connect() method from Clsfunction class 
            SqlCommand cmd = new SqlCommand(qry, sqlcon);//provider of ADO.Net//used to execute commands at on database
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);//Use for retrive data from sql
            DataTable _datatable = new DataTable();//object  declaration of DataTable
            adapter.Fill(_datatable);//called fill() from SqlDataAdapter class for to fill my datatable

            return _datatable;//Connecting string 
        }
        public DataTable GetDataTableWithName(string start,string END)
        {
            string qry = "select * from A_M_Lookup_Line where line_name like '" + start+"%"+END+"'";//sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class 
            SqlConnection sqlcon = cls.Connect();//called connect() method from Clsfunction class 
            SqlCommand cmd = new SqlCommand(qry, sqlcon);//provider of ADO.Net//used to execute commands at on database
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);// Use for retrive data from sql
            DataTable _datatable = new DataTable();//object  declaration of DataTable
            adapter.Fill(_datatable);//called fill() from SqlDataAdapter class for to fill my datatable

            return _datatable;//Connecting string 
        }

        public void SaveOrUpdateWithADO(A_M_Lookup_Line_Model model)
        {
            string Flag = null;
            try
            {


                if (model.LineId == 0)//This is IF Else Condition 
                {
                    Flag = "I";
                }
                else
                {
                    Flag = "U";
                }


                ClsFunction cls = new ClsFunction();//This is object of ClsFunction class 
                SqlConnection sqlcon = cls.Connect();//called connect() method from Clsfunction class 
                SqlCommand cmd = new SqlCommand();//provider of ADO.Net//used to execute commands at on database
                cmd.CommandText = "Sp_A_M_Lookup_Line";//It is set or return a string that contain a provider
                cmd.CommandType = CommandType.StoredProcedure; //should contain text of a query that must be run on the server
                cmd.Connection = sqlcon;//connection string 

                cmd.Parameters.AddWithValue("@LineId", model.LineId);
                cmd.Parameters.AddWithValue("@ClientId", model.ClientId);//Add a parameters by specifying its name
                cmd.Parameters.AddWithValue("@GlobalId", model.GlobalId);
                cmd.Parameters.AddWithValue("@LookupId", model.LookupId);
                cmd.Parameters.AddWithValue("@LineName", model.LineName);
                cmd.Parameters.AddWithValue("@LineDescription", model.LineDescription);
                cmd.Parameters.AddWithValue("@CreatedBy", model.CreatedBy);
                cmd.Parameters.AddWithValue("@CreatedDate", model.CreatedDate);
                cmd.Parameters.AddWithValue("@UpdatedBy", model.UpdatedBy);
                cmd.Parameters.AddWithValue("@UpdatedDate", model.UpdatedDate);
                cmd.Parameters.AddWithValue("@Flag", Flag);

                cmd.ExecuteNonQuery();//It's used for Execute sql command 
            }
            catch (Exception ex)
            {

                var st = new System.Diagnostics.StackTrace(ex, true);
                var frame = st.GetFrame(st.FrameCount - 1);
                var lineNumber = frame.GetFileLineNumber();
                ErrorLog el = new ErrorLog();
                el.Error("A_M_Lookup_Line", "SaveOrUpdateWithADO", lineNumber.ToString(), ex.ToString());
            }

        }

        public void SaveWithQuery(A_M_Lookup_Line_Model model)
        {
            string qry = "Insert INTO A_M_Lookup_Line (ClientId,GlobalId,LookupId,LineName,LineDescripition,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate)  values  ('" + model.ClientId+"','"+model.GlobalId+"','"+model.LookupId+"','"+model.LineName+"','"+model.LineDescription+"','"+model.CreatedBy+"','"+model.CreatedDate+"','"+model.UpdatedBy+"','"+model.UpdatedDate+"')";//sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class 
            SqlConnection sqlcon = cls.Connect();//called connect() method from Clsfunction class 
            SqlCommand cmd = new SqlCommand(qry, sqlcon);//provider of ADO.Net//used to execute commands at on database

            cmd.ExecuteNonQuery();//It's used for Execute sql command 

        }
        public void SaveWithQueryString (A_M_Lookup_Line_Model model)
        {
            string qry = "Insert INTO A_M_Lookup_Line ([ClientId],[GlobalId],[LookupId],[LineName],[LineDescription],[CreatedBy],[CreatedDate],[UpdatedBy],[UpdatedDate]) values (@ClientId,@GlobalId,@LookupId,@LineName,@LineDescription,@CreatedBy,@CreatedDate,@UpdatedBy,@UpdatedDate)";//sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class 
            SqlConnection sqlcon = cls.Connect();//called connect() method from Clsfunction class 
            SqlCommand cmd = new SqlCommand();//provider of ADO.Net//used to execute commands at on database

            try
            {
                cmd.CommandText = qry;//It is set or return a string that contain a provider
                cmd.CommandType = CommandType.Text;//  should  contain text of a query that must be run on the server
                cmd.Connection = sqlcon;//Connecting string 

                cmd.Parameters.AddWithValue("@ClientId", model.ClientId);//Add a parameters by specifying its name
                cmd.Parameters.AddWithValue("@GlobalId", model.GlobalId);
                cmd.Parameters.AddWithValue("@LookupId", model.LookupId);
                cmd.Parameters.AddWithValue("@LineName", model.LineName);
                cmd.Parameters.AddWithValue("@LineDescription", model.LineDescription);
                cmd.Parameters.AddWithValue("@CreatedBy", model.CreatedBy);
                cmd.Parameters.AddWithValue("@CreatedDate", model.CreatedDate);
                cmd.Parameters.AddWithValue("@UpdatedBy", model.UpdatedBy);
                cmd.Parameters.AddWithValue("@UpdatedDate", model.UpdatedDate);

                cmd.ExecuteNonQuery();//It's used for Execute sql command 
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

        public  List<A_M_Lookup_Line_Model> GetDataList()
        {
            DataTable dt = GetDataTable();
            List<A_M_Lookup_Line_Model> _List= new List<A_M_Lookup_Line_Model> ();
            try
            {


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    A_M_Lookup_Line_Model model = new A_M_Lookup_Line_Model();
                    model.LineId = Convert.ToInt32(dt.Rows[i]["LineId"]);
                    model.ClientId = Convert.ToInt32(dt.Rows[i]["ClientId"]);
                    model.GlobalId = Convert.ToInt32(dt.Rows[i]["GlobalId"]);
                    model.LookupId = Convert.ToInt32(dt.Rows[i]["LookupId"]);
                    model.LineName = dt.Rows[i]["LineName"].ToString();
                    model.LineDescription = dt.Rows[i]["LineDescription"].ToString();
                    model.CreatedBy = Convert.ToInt32(dt.Rows[i]["CreatedBy"]);
                    model.CreatedDate = Convert.ToDateTime(dt.Rows[i]["CreatedDate"]);
                    model.UpdatedBy = Convert.ToInt32(dt.Rows[i]["UpdatedBy"]);
                    model.UpdatedDate = Convert.ToDateTime(dt.Rows[i]["CreatedDate"]);

                    _List.Add(model);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return _List;
        }

        public void SaveOrUpdateWithEntityFrameWork(A_M_Lookup_Line_Model model)
        {
            try
            {
                using (MY_Db_Hospital_ManagmentEntities db = new MY_Db_Hospital_ManagmentEntities())
                {
                    if (model.LineId==0)
                    {   
                        A_M_Lookup_Line tbl = new A_M_Lookup_Line()
                        {
                            ClientId = model.ClientId,
                            GlobalId= model.GlobalId,
                            LookupId= model.LookupId,
                            LineName= model.LineName,
                            LineDescription= model.LineDescription,
                            CreatedBy= model.CreatedBy,
                            CreatedDate= model.CreatedDate, 
                            UpdatedBy= model.UpdatedBy,
                            UpdatedDate= model.UpdatedDate, 
                        };
                        db.Entry(tbl).State=EntityState.Added;
                        db.SaveChanges();   

                    }
                    else
                    {
                        A_M_Lookup_Line tbl = new A_M_Lookup_Line()
                        {
                            ClientId = model.ClientId,
                            GlobalId = model.GlobalId,
                            LookupId = model.LookupId,
                            LineName = model.LineName,
                            LineDescription = model.LineDescription,
                            CreatedBy = model.CreatedBy,
                            CreatedDate = model.CreatedDate,
                            UpdatedBy = model.UpdatedBy,
                            UpdatedDate = model.UpdatedDate,
                        };
                        db.Entry(tbl).State = EntityState.Modified;
                        db.SaveChanges();
                    }

                }
            }
            catch(Exception ex)
            {
                var st = new System.Diagnostics.StackTrace(ex, true );
                var frame=st.GetFrame(st.FrameCount -1 );
                var lineNumber= frame.GetFileLineNumber();
                ErrorLog el = new ErrorLog();
                el.Error("A_M_Lookup_Line", "SaveOrUpdateWithEntityFrameWork",lineNumber.ToString(),ex.ToString());

            }
        }

        public List<A_M_Lookup_Line_Model> GetDataListWithADO()
        {
            throw new Exception();
        }

        public List<A_M_Lookup_Hedar> GetDataListWithEntityFramework()
        {

            //This is Connection string (MY_Db_Hospital_ManagmentEntities)
            //Object decalraction of  Connection string  

            MY_Db_Hospital_ManagmentEntities db = new MY_Db_Hospital_ManagmentEntities();

            return db.A_M_Lookup_Hedar.ToList();
        }
    }
}
