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
using System.Data.Entity;

namespace MY_Db_Hospital_Managment_Abstraction.MyAbstraction
{
    public class M_Item_Information_Abstraction : I_M_Item_Information
    {

        //this function for get datatable from sql using qry string
        public DataTable GetDataTable()
        {
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class 
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand("select * from M_Item_Information", sqlcon);//provider of ADO.Net//used to execute commands at on database
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);//Use for retrive data from sql
            DataTable _datatable = new DataTable();//object  declaration of DataTable
            adapter.Fill(_datatable);//called fill() from SqlDataAdapter class for to fill my datatable

            return _datatable;//Connecting string

        }

        public void SaveOrUpdateWithADO(M_Item_Information_Model model)
        {
            string Flag = null;

            try
            {


                if (model.ItemId == 0)
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
                cmd.CommandText = "Sp_M_Item_Information";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = sqlcon;

                cmd.Parameters.AddWithValue("@ItemId", model.ItemId);
                cmd.Parameters.AddWithValue("@ItemCode", model.ItemCode);//Add a parameters by specifying its name
                cmd.Parameters.AddWithValue("@ItemType", model.ItemType);
                cmd.Parameters.AddWithValue("@ItemName", model.ItemName);
                cmd.Parameters.AddWithValue("@ItemManufactionName", model.ItemManufactionName);
                cmd.Parameters.AddWithValue("@ItemPacinking", model.ItemPacinking);
                cmd.Parameters.AddWithValue("@ItemUseName", model.ItemUseName);
                cmd.Parameters.AddWithValue("@ItemDescription", model.ItemDescription);
                cmd.Parameters.AddWithValue("@ItemStartDate", model.ItemStartDate);
                cmd.Parameters.AddWithValue("@ItemEndDate", model.ItemEndDate);
                cmd.Parameters.AddWithValue("@ItemFirstUnit", model.ItemFirstUnit);
                cmd.Parameters.AddWithValue("@ItemSecondUnit", model.ItemSecondUnit);
                cmd.Parameters.AddWithValue("@ItemConversionFirstFactor", model.ItemConversionFirstFactor);
                cmd.Parameters.AddWithValue("@ItemConversionSecondFactor", model.ItemConversionSecondFactor);
                cmd.Parameters.AddWithValue("@ItemIsStockebal", model.ItemIsStockebal);
                cmd.Parameters.AddWithValue("@ItemQualityCheck", model.ItemQualityCheck);
                cmd.Parameters.AddWithValue("@ItemReturnPolicy", model.ItemReturnPolicy);
                cmd.Parameters.AddWithValue("@ItemMinQTY", model.ItemMinQTY);
                cmd.Parameters.AddWithValue("@ItemMaxQTY", model.ItemMaxQTY);
                cmd.Parameters.AddWithValue("@ItemHsnCode", model.ItemHsnCode);
                cmd.Parameters.AddWithValue("@ItemPoType", model.ItemPoType);
                cmd.Parameters.AddWithValue("@ItemTaxApply", model.ItemTaxApply);
                cmd.Parameters.AddWithValue("@ItemPoTaxGroup", model.ItemPoTaxGroup);
                cmd.Parameters.AddWithValue("@ItemSaleTaxGroup", model.ItemSaleTaxGroup);
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
                cmd.Parameters.AddWithValue("@Attr6", model.Attr6);
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
                el.Error("M_Item_Information_Abstraction", "SaveOrUpdateWithADO", lineNumber.ToString(), ex.ToString());

            }
        }


        public void SaveWithQuery(M_Item_Information_Model model)
        {
            string qry = "Insert into M_Item_Information (ItemCode,ItemType,ItemName,ItemManufactionName,ItemPacinking,ItemUseName,ItemDescription,ItemStartDate,ItemEndDate,ItemFirstUnit,ItemSecondUnit,ItemConversionFirstFactor,ItemConversionSecondFactor,ItemIsStockebal,ItemQualityCheck,ItemReturnPolicy,ItemMinQTY,ItemMaxQTY,ItemHsnCode,ItemPoType,ItemTaxApply,ItemPoTaxGroup,ItemSaleTaxGroup,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,ActiveFlag,Attr1,Attr2,Attr3,Attr4,Attr5,Attr6) values ('" + model.ItemCode + "','" + model.ItemType + "','" + model.ItemName + "','" + model.ItemManufactionName + "','" + model.ItemPacinking + "','" + model.ItemUseName + "','" + model.ItemDescription + "',getdate(),getdate(),'" + model.ItemFirstUnit + "','" + model.ItemSecondUnit + "','" + model.ItemConversionFirstFactor + "','" + model.ItemConversionSecondFactor + "','" + model.ItemIsStockebal + "','" + model.ItemQualityCheck + "','" + model.ItemReturnPolicy + "','" + model.ItemMinQTY + "','" + model.ItemMaxQTY + "','" + model.ItemHsnCode + "','" + model.ItemPoType + "','" + model.ItemTaxApply + "','" + model.ItemPoTaxGroup + "','" + model.ItemSaleTaxGroup + "','" + model.CreatedBy + "',getdate(),'" + model.UpdatedBy + "',getdate(),'" + model.ActiveFlag + "','" + model.Attr1 + "','" + model.Attr2 + "','" + model.Attr3 + "','" + model.Attr4 + "','" + model.Attr5 + "','" + model.Attr6 + "')";// sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class 
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class
            SqlCommand cmd = new SqlCommand();//provider of ADO.Net//used to execute commands at on database
            cmd.CommandText = qry;//It is set or return a string that contain a provider
            cmd.CommandType = CommandType.Text;//should  contain text of a query that must be run on the server
            cmd.Connection = sqlcon;//Connecting string

            cmd.ExecuteNonQuery();// It's used for Execute sql command


        }

        public void SaveWithQueryString(M_Item_Information_Model model)
        {
            string qry = "Insert into M_Item_Information (ItemCode,ItemType,ItemName,ItemManufactionName,ItemPacinking,ItemUseName,ItemDescription,ItemStartDate,ItemEndDate,ItemFirstUnit,ItemSecondUnit,ItemConversionFirstFactor,ItemConversionSecondFactor,ItemIsStockebal,ItemQualityCheck,ItemReturnPolicy,ItemMinQTY,ItemMaxQTY,ItemHsnCode,ItemPoType,ItemTaxApply,ItemPoTaxGroup,ItemSaleTaxGroup,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,ActiveFlag,Attr1,Attr2,Attr3,Attr4,Attr5,Attr6) values (@ItemCode,@ItemType,@ItemName,@ItemManufactionName,@ItemPacinking,@ItemUseName,@ItemDescription,@ItemStartDate,@ItemEndDate,@ItemFirstUnit,@ItemSecondUnit,@ItemConversionFirstFactor,@ItemConversionSecondFactor,@ItemIsStockebal,@ItemQualityCheck,@ItemReturnPolicy,@ItemMinQTY,@ItemMaxQTY,@ItemHsnCode,@ItemPoType,@ItemTaxApply,@ItemPoTaxGroup,@ItemSaleTaxGroup,@CreatedBy,@CreatedDate,@UpdatedBy,@UpdatedDate,@ActiveFlag,@Attr1,@Attr2,@Attr3,@Attr4,@Attr5,@Attr6)";// sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class 
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class
            SqlCommand cmd = new SqlCommand();//provider of ADO.Net//used to execute commands at on database
            try
            {


                cmd.CommandText = qry;//It is set or return a string that contain a provider
                cmd.CommandType = CommandType.Text;//  should  contain text of a query that must be run on the server
                cmd.Connection = sqlcon;//Connecting string

                cmd.Parameters.AddWithValue("@ItemCode", model.ItemCode);//Add a parameters by specifying its name
                cmd.Parameters.AddWithValue("@ItemType", model.ItemType);
                cmd.Parameters.AddWithValue("@ItemName", model.ItemName);
                cmd.Parameters.AddWithValue("@ItemManufactionName", model.ItemManufactionName);
                cmd.Parameters.AddWithValue("@ItemPacinking", model.ItemPacinking);
                cmd.Parameters.AddWithValue("@ItemUseName", model.ItemUseName);
                cmd.Parameters.AddWithValue("@ItemDescription", model.ItemDescription);
                cmd.Parameters.AddWithValue("@ItemStartDate", model.ItemStartDate);
                cmd.Parameters.AddWithValue("@ItemEndDate", model.ItemEndDate);
                cmd.Parameters.AddWithValue("@ItemFirstUnit", model.ItemFirstUnit);
                cmd.Parameters.AddWithValue("@ItemSecondUnit", model.ItemSecondUnit);
                cmd.Parameters.AddWithValue("@ItemConversionFirstFactor", model.ItemConversionFirstFactor);
                cmd.Parameters.AddWithValue("@ItemConversionSecondFactor", model.ItemConversionSecondFactor);
                cmd.Parameters.AddWithValue("@ItemIsStockebal", model.ItemIsStockebal);
                cmd.Parameters.AddWithValue("@ItemQualityCheck", model.ItemQualityCheck);
                cmd.Parameters.AddWithValue("@ItemReturnPolicy", model.ItemReturnPolicy);
                cmd.Parameters.AddWithValue("@ItemMinQTY", model.ItemMinQTY);
                cmd.Parameters.AddWithValue("@ItemMaxQTY", model.ItemMaxQTY);
                cmd.Parameters.AddWithValue("@ItemHsnCode", model.ItemHsnCode);
                cmd.Parameters.AddWithValue("@ItemPoType", model.ItemPoType);
                cmd.Parameters.AddWithValue("@ItemTaxApply", model.ItemTaxApply);
                cmd.Parameters.AddWithValue("@ItemPoTaxGroup", model.ItemPoTaxGroup);
                cmd.Parameters.AddWithValue("@ItemSaleTaxGroup", model.ItemSaleTaxGroup);
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
                cmd.Parameters.AddWithValue("@Attr6", model.Attr6);

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
                el.Error("M_Item_Information_Abstraction", "SaveWithQueryString", lineNumber.ToString(), ex.ToString());
            }
            finally
            {
                sqlcon.Close();
                cmd.Dispose();
            }

        }
        public List<M_Item_Information_Model> GetDataListWithADO()
        {
            DataTable dt = GetDataTable();
            List<M_Item_Information_Model> _List = new List<M_Item_Information_Model>();

            // This Is Try/Catch condition
            //Try/Catch Condition use to Finding error 
            try
            {

                //This is for Loop Condition

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    M_Item_Information_Model model = new M_Item_Information_Model(); //Create model object 
                    model.ItemId = Convert.ToInt32(dt.Rows[i]["ItemId"]);
                    model.ItemCode =dt.Rows[i]["ItemCode"].ToString();
                    model.ItemType = Convert.ToInt32(dt.Rows[i]["ItemType"]);
                    model.ItemName =dt.Rows[i]["ItemName"].ToString();
                    model.ItemManufactionName = dt.Rows[i]["ItemManufactionName"].ToString();
                    model.ItemPacinking = Convert.ToInt32(dt.Rows[i]["ItemPacinking"]);
                    model.ItemUseName =dt.Rows[i]["ItemUseName"].ToString();
                    model.ItemDescription =dt.Rows[i]["ItemDescription"].ToString();
                    model.ItemStartDate = Convert.ToDateTime(dt.Rows[i]["ItemStartDate"]);
                    model.ItemEndDate = Convert.ToDateTime(dt.Rows[i]["ItemEndDate"]);
                    model.ItemFirstUnit = Convert.ToInt32(dt.Rows[i]["ItemFirstUnit"]);
                    model.ItemSecondUnit = Convert.ToInt32(dt.Rows[i]["ItemSecondUnit"]);
                    model.ItemConversionFirstFactor = Convert.ToDecimal(dt.Rows[i]["ItemConversionFirstFactor"]);
                    model.ItemConversionSecondFactor = Convert.ToDecimal(dt.Rows[i]["ItemConversionSecondFactor"]);
                    model.ItemIsStockebal = Convert.ToBoolean(dt.Rows[i]["ItemIsStockebal"]);
                    model.ItemQualityCheck = Convert.ToBoolean(dt.Rows[i]["ItemQualityCheck"]);
                    model.ItemReturnPolicy = Convert.ToBoolean(dt.Rows[i]["ItemReturnPolicy"]);
                    model.ItemMinQTY = Convert.ToDecimal(dt.Rows[i]["ItemMinQTY"]);
                    model.ItemMaxQTY = Convert.ToDecimal(dt.Rows[i]["ItemMaxQTY"]);
                    model.ItemHsnCode =dt.Rows[i]["ItemHsnCode"].ToString();
                    model.ItemPoType = Convert.ToInt32(dt.Rows[i]["ItemPoType"]);
                    model.ItemTaxApply = Convert.ToBoolean(dt.Rows[i]["ItemTaxApply"]);
                    model.ItemPoTaxGroup = Convert.ToDecimal(dt.Rows[i]["ItemPoTaxGroup"]);
                    model.ItemSaleTaxGroup = Convert.ToDecimal(dt.Rows[i]["ItemSaleTaxGroup"]);
                    model.CreatedBy = Convert.ToInt32(dt.Rows[i]["CreatedBy"]);
                    model.CreatedDate = Convert.ToDateTime(dt.Rows[i]["CreatedDate"]);
                    model.UpdatedBy = Convert.ToInt32(dt.Rows[i]["UpdatedBy"]);
                    model.UpdatedDate = Convert.ToDateTime(dt.Rows[i]["UpdatedDate"]);
                    model.ActiveFlag = Convert.ToBoolean(dt.Rows[i]["ActiveFlag"]);
                    model.Attr1 = dt.Rows[i]["Attr1"].ToString();
                    model.Attr2= dt.Rows[i]["Attr2"].ToString();
                    model.Attr3= dt.Rows[i]["Attr3"].ToString();
                    model.Attr4 = Convert.ToInt32(dt.Rows[i]["Attr4"]);
                    model.Attr5 = Convert.ToInt32(dt.Rows[i]["Attr5"]);
                    model.Attr6 = Convert.ToInt32(dt.Rows[i]["Attr6"]);

                    _List.Add(model);



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
                el.Error("M_Item_Information_Abstraction", "GetDataListWithADO", lineNumber.ToString(), ex.ToString());

            }
            return _List;
        }

        public void SaveOrUpdatewithenityFrameWork(M_Item_Information_Model model)
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

                    if (model.ItemId == 0)
                    {
                        M_Item_Information tbl = new M_Item_Information()
                        {
                            ItemCode = model.ItemCode,
                            ItemType= model.ItemType,
                            ItemName=model.ItemName,
                            ItemManufactionName = model.ItemManufactionName,
                            ItemPacinking = model.ItemPacinking,
                            ItemUseName= model.ItemUseName,
                            ItemDescription = model.ItemDescription,
                            ItemStartDate = model.ItemStartDate,
                            ItemEndDate = model.ItemEndDate,
                            ItemFirstUnit = model.ItemFirstUnit,
                            ItemSecondUnit= model.ItemSecondUnit,
                            ItemConversionFirstFactor= model.ItemConversionFirstFactor,
                            ItemConversionSecondFactor = model.ItemConversionSecondFactor,


                        };
                        db.Entry(tbl).State = EntityState.Added;//This linq statement save data in datatable 
                        db.SaveChanges();

                    }
                    else
                    {

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
                el.Error("M_Item_Information_Abstraction", "SaveOrUpdateWithEntityFrameWork", lineNumber.ToString(), ex.ToString());

            }
        }
            public List<M_Item_Information> GetDataListWithEntityFramework()
            {
                //This is Connection string (MY_Db_Hospital_ManagmentEntities)
                //Object decalraction of  Connection string  

                MY_Db_Hospital_ManagmentEntities db = new MY_Db_Hospital_ManagmentEntities();

                return db.M_Item_Information.ToList();//linq query
            }

        }
    }
           

