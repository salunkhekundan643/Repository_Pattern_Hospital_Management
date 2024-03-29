﻿using MY_Db_Hospital_Managment_Interface.Master_Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MY_Db_Hospital_Managment_Connection.My_Connection;
using MY_Db_Hospital_Managment.Master_Model;
using My_Db_Hospital_Management_EntityFramework.MyDbContext;

namespace MY_Db_Hospital_Managment_Abstraction.MyAbstraction
{
    public class M_Client_Registration_Abstraction : I_M_Client_Registration
    {

        //this function for get datatable from sql using qry string
        public DataTable GetDataTable()
        {
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class 
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand("select * from M_Client_Registration", sqlcon);//provider of ADO.Net//used to execute commands at on database
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);//Use for retrive data from sql
            DataTable _datatable = new DataTable();//object  declaration of DataTable
            adapter.Fill(_datatable);//called fill() from SqlDataAdapter class for to fill my datatable

            return _datatable;//Connecting string
        }


        //This Function Save or Update data in sql server with ADO.Net
        //THis Function Save or Update Data With store procedure throw

        public void SaveOrUpdatewithADO(M_Client_Registration_Model model)
        {
            string Flag = null;

            // This Is Try/Catch condition
            //Try/Catch Condition use to Finding error 
            try
            {

                //This IS IF Else Condition 
                //Its use to insert or update data in dataTable 
                if (model.ClientId == 0) 
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
                cmd.CommandText = "Sp_M_Client_Registration";//It is set or return a string that contain a provider
                cmd.CommandType = CommandType.StoredProcedure; //should contain text of a query that must be run on the server
                cmd.Connection = sqlcon;//connection string 


                cmd.Parameters.AddWithValue("@ClientId", model.ClientId);
                cmd.Parameters.AddWithValue("@ClientCode", model.ClientCode);//Add a parameters by specifying its name
                cmd.Parameters.AddWithValue("@ClientGlobalId", model.ClientGlobalId);
                cmd.Parameters.AddWithValue("@ClientName", model.ClientName);
                cmd.Parameters.AddWithValue("@ClientAddress", model.ClientAddress);
                cmd.Parameters.AddWithValue("@ClientPhone", model.ClientPhone);
                cmd.Parameters.AddWithValue("@ClientCity", model.ClientCity);
                cmd.Parameters.AddWithValue("@BusniessName", model.BusniessName);
                cmd.Parameters.AddWithValue("@ClientPan", model.ClientPan);
                cmd.Parameters.AddWithValue("@ClientRegistrationNo", model.ClientRegistrationNo);
                cmd.Parameters.AddWithValue("@ClientGST", model.ClientGST);
                cmd.Parameters.AddWithValue("@ClientLogo", model.ClientLogo);
                cmd.Parameters.AddWithValue("@ClientEmail", model.ClientEmail);
                cmd.Parameters.AddWithValue("@Password", model.Password);
                cmd.Parameters.AddWithValue("@UserName", model.UserName);
                cmd.Parameters.AddWithValue("@CreatedBy", model.CreatedBy);
                cmd.Parameters.AddWithValue("@CreatedDate", model.CreatedDate);
                cmd.Parameters.AddWithValue("@UpdatedDate", model.UpdatedDate);
                cmd.Parameters.AddWithValue("@ActiveFlag", model.ActiveFlag);
                cmd.Parameters.AddWithValue("@Attr1", model.Attr1);
                cmd.Parameters.AddWithValue("@Attr2", model.Attr2);
                cmd.Parameters.AddWithValue("@Attr3", model.Attr3);
                cmd.Parameters.AddWithValue("@Flag", Flag);

                cmd.ExecuteNonQuery();
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
                el.Error("M_Client_Registration_Abstraction", "SaveOrUpdateWithADO", lineNumber.ToString(), ex.ToString());

            }
        }


        //This Function save data with Query throw 

        public void SaveWithQuery(M_Client_Registration_Model model)
        {
            string qry = "Insert INTO M_Client_Registration (ClientCode,ClientGlobalId,ClientName,ClientAddress,ClientPhone,ClientCity,BusniessName,ClientPan,ClientRegistrationNo,ClientGST,ClientLogo,ClientEmail,Password,UserName,CreatedBy,CreatedDate,UpdatedDate,ActiveFlag,Attr1,Attr2,Attr3) VALUES" +
                "('" + model.ClientCode + "','" + model.ClientGlobalId + "','" + model.ClientName + "','" + model.ClientAddress + "','" + model.ClientPhone + "','" + model.ClientCity + "','" + model.BusniessName + "','" + model.ClientPan + "','" + model.ClientRegistrationNo + "','" + model.ClientGST + "','" + model.ClientLogo + "','" + model.ClientEmail + "','" + model.Password + "','" + model.UserName + "','" + model.CreatedBy + "',getdate(),getdate(),'" + model.ActiveFlag + "','" + model.Attr1 + "','" + model.Attr2 + "','" + model.Attr3 + "')";// sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class 
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand();//provider of ADO.Net//used to execute commands at on database
            cmd.CommandText = qry;//It is set or return a string that contain a provider
            cmd.CommandType = CommandType.Text;//  should  contain text of a query that must be run on the server
            cmd.Connection = sqlcon;//Connecting string 

            cmd.ExecuteNonQuery();//It's used for Execute sql command 


        }


        //This Function  Insert data in DataTable with help model   

        public void SaveWithQueryString(M_Client_Registration_Model model)
        {
            string qry = "Insert INTO M_Client_Registration (ClientCode,ClientGlobalId,ClientName,ClientAddress,ClientPhone,ClientCity,BusniessName,ClientPan,ClientRegistrationNo,ClientGST,ClientLogo,ClientEmail,Password,UserName,CreatedBy,CreatedDate,UpdatedDate,ActiveFlag,Attr1,Attr2,Attr3 ) VALUES (@ClientCode,@ClientGlobalId,@ClientName,@ClientAddress,@ClientPhone,@ClientCity,@BusniessName,@ClientPan,@ClientRegistrationNo,@ClientGST,@ClientLogo,@ClientEmail,@Password,@UserName,@CreatedBy,@CreatedDate,@UpdatedDate,@ActiveFlag,@Attr1,@Attr2,@Attr3 )"; //sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class 
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand();//provider of ADO.Net//used to execute commands at on database

            // This Is Try/Catch condition
            //Try/Catch Condition use to Finding error 
            try
            {


                cmd.CommandText = qry;//It is set or return a string that contain a provider
                cmd.CommandType = CommandType.Text;//  should  contain text of a query that must be run on the server
                cmd.Connection = sqlcon;//Connecting string 


                cmd.Parameters.AddWithValue("@ClientCode", model.ClientCode);//Add a parameters by specifying its name
                cmd.Parameters.AddWithValue("@ClientGlobalId", model.ClientGlobalId);
                cmd.Parameters.AddWithValue("@ClientName", model.ClientName);
                cmd.Parameters.AddWithValue("@ClientAddress", model.ClientAddress);
                cmd.Parameters.AddWithValue("@ClientPhone", model.ClientPhone);
                cmd.Parameters.AddWithValue("@ClientCity", model.ClientCity);
                cmd.Parameters.AddWithValue("@BusniessName", model.BusniessName);
                cmd.Parameters.AddWithValue("@ClientPan", model.ClientPan);
                cmd.Parameters.AddWithValue("@ClientRegistrationNo", model.ClientRegistrationNo);
                cmd.Parameters.AddWithValue("@ClientGST", model.ClientGST);
                cmd.Parameters.AddWithValue("@ClientLogo", model.ClientLogo);
                cmd.Parameters.AddWithValue("@ClientEmail", model.ClientEmail);
                cmd.Parameters.AddWithValue("@Password", model.Password);
                cmd.Parameters.AddWithValue("@UserName", model.UserName);
                cmd.Parameters.AddWithValue("@CreatedBy", model.CreatedBy);
                cmd.Parameters.AddWithValue("@CreatedDate", model.CreatedDate);
                cmd.Parameters.AddWithValue("@UpdatedDate", model.UpdatedDate);
                cmd.Parameters.AddWithValue("@ActiveFlag", model.ActiveFlag);
                cmd.Parameters.AddWithValue("@Attr1", model.Attr1);
                cmd.Parameters.AddWithValue("@Attr2", model.Attr2);
                cmd.Parameters.AddWithValue("@Attr3", model.Attr3);

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
                el.Error("M_Client_Registration_Abstraction", "SaveWithQueryString", lineNumber.ToString(), ex.ToString());

            }
            finally
            {
                sqlcon.Close();
                cmd.Dispose();
            }
        }




        //This Function return a Datatable in list form 
        //This function get data With help ADO
        public List<M_Client_Registration_Model> GetDataListWithADO()
        {
            DataTable dt = GetDataTable();
            List<M_Client_Registration_Model> _List = new List<M_Client_Registration_Model>();

            // This Is Try/Catch condition
            //Try/Catch Condition use to Finding error 
            try
            {

                //This is for Loop Condition

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    M_Client_Registration_Model model = new M_Client_Registration_Model();//Create model object 
                   
                    model.ClientId = Convert.ToInt32(dt.Rows[i]["ClientId"]);
                    model.ClientCode = dt.Rows[i]["ClientCode"].ToString();
                    model.ClientGlobalId = Convert.ToInt32(dt.Rows[i]["ClientGlobalId"]);
                    model.ClientName = dt.Rows[i]["ClientName"].ToString();
                    model.ClientAddress = dt.Rows[i]["ClientAddress"].ToString();
                    model.ClientPhone = dt.Rows[i]["ClientPhone"].ToString();
                    model.ClientCity = dt.Rows[i]["ClientCity"].ToString();
                    model.BusniessName = dt.Rows[i]["BusniessName"].ToString();
                    model.ClientPan = dt.Rows[i]["ClientPan"].ToString();
                    model.ClientRegistrationNo = dt.Rows[i]["ClientRegistrationNo"].ToString();
                    model.ClientGST = dt.Rows[i]["ClientGST"].ToString();
                    model.ClientLogo = dt.Rows[i]["ClientLogo"].ToString();
                    model.ClientEmail = dt.Rows[i]["ClientEmail"].ToString();
                    model.Password = dt.Rows[i]["Password"].ToString();
                    model.CreatedBy = Convert.ToInt32(dt.Rows[i]["CreatedBy"]);
                    model.CreatedDate = Convert.ToDateTime(dt.Rows[i]["CreatedDate"]);
                    model.UpdatedDate = Convert.ToDateTime(dt.Rows[i]["UpdatedDate"]);
                    model.ActiveFlag = dt.Rows[i]["ActiveFlag"].ToString();
                    model.Attr1 = dt.Rows[i]["Attr1"].ToString();
                    model.Attr2 = dt.Rows[i]["Attr2"].ToString();
                    model.Attr3 = Convert.ToInt32(dt.Rows[i]["Attr3"]);

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
                el.Error("M_Client_Registration_Abstraction", "GetDataList", lineNumber.ToString(), ex.ToString());
            }
            return _List;
        }




        //THIS Function Save or Update Data in DataTable  with help EntityFrameWork 
        //This Function use to Insert or update  data in DataTable 
        public void SaveOrUpdateWithEntityFrameWork(M_Client_Registration_Model model)
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
                    if (model.ClientId == 0)
                    {
                        M_Client_Registration tbl = new M_Client_Registration()//This is Table Object
                        {
                            ClientCode = model.ClientCode,
                            ClientGlobalId = model.ClientGlobalId,
                            ClientName = model.ClientName,
                            ClientAddress = model.ClientAddress,
                            ClientPhone = model.ClientPhone,
                            ClientCity = model.ClientCity,
                            BusniessName = model.BusniessName,
                            ClientPan = model.ClientPan,
                            ClientRegistrationNo = model.ClientRegistrationNo,
                            ClientGST = model.ClientGST,
                            ClientLogo = model.ClientLogo,
                            ClientEmail = model.ClientEmail,
                            Password = model.Password,
                            UserName = model.UserName,
                            CreatedBy = model.CreatedBy,
                            CreatedDate = model.CreatedDate,
                            UpdatedDate = model.UpdatedDate,
                            ActiveFlag = model.ActiveFlag,
                            Attr1 = model.Attr1,
                            Attr2 = model.Attr2,
                            Attr3 = model.Attr3,

                        };
                        db.Entry(tbl).State = EntityState.Added;//This linq statement save data in datatable 
                        db.SaveChanges();


                    }
                    else
                    {
                        M_Client_Registration tbl = new M_Client_Registration()//This is Table Object
                        {
                            ClientCode = model.ClientCode,
                            ClientGlobalId = model.ClientGlobalId,
                            ClientName = model.ClientName,
                            ClientAddress = model.ClientAddress,
                            ClientPhone = model.ClientPhone,
                            ClientCity = model.ClientCity,
                            BusniessName = model.BusniessName,
                            ClientPan = model.ClientPan,
                            ClientRegistrationNo = model.ClientRegistrationNo,
                            ClientGST = model.ClientGST,
                            ClientLogo = model.ClientLogo,
                            ClientEmail = model.ClientEmail,
                            Password = model.Password,
                            UserName = model.UserName,
                            CreatedBy = model.CreatedBy,
                            CreatedDate = model.CreatedDate,
                            UpdatedDate = model.UpdatedDate,
                            ActiveFlag = model.ActiveFlag,
                            Attr1 = model.Attr1,
                            Attr2 = model.Attr2,
                            Attr3 = model.Attr3,

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
                var lineNuber = frame.GetFileLineNumber();
                ErrorLog el = new ErrorLog();
                el.Error("M_Client_Registration_Abstraction", "SaveOrUpdateWithEntityFrameWork", lineNuber.ToString(), ex.ToString());
           
            }

        }


        //This Is EntityFrameWork Function 
        //This Function Get data in list format
        public List<M_Client_Registration> GetDataListWithEntityFramework()
        {


            //This is Connection string (MY_Db_Hospital_ManagmentEntities)
            //Object decalraction of  Connection string 
            MY_Db_Hospital_ManagmentEntities db = new MY_Db_Hospital_ManagmentEntities();

            return db.M_Client_Registration.ToList();//linq query
                                                     
        }
    }
}
