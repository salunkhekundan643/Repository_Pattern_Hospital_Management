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
    public  class T_Medicen_Sale_Hedar_Abstraction: I_T_Medicen_Sale_Hedar
    {
        public List<T_Medicen_Sale_Hedar_Model> GetDataListWithADO()
        {
            throw new NotImplementedException();
        }

        public List<T_Medicen_Sale_Hedar> GetDataListWithEntityFramework()
        {
            throw new NotImplementedException();
        }


        //this function for get datatable from sql using qry string
        //
        public DataTable GetDataTable()
        {
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand("select * from T_Medicen_Sale_Hedar",sqlcon);//provider of ADO.Net//used to execute commands at on database
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);// use for retrive data from sql
            DataTable _datatable = new DataTable();//object  declaration of DataTable
            adapter.Fill(_datatable );//called fill() from SqlDataAdapter class for to fill my datatable

            return _datatable;//Connecting string

        }

        public void SaveOrUpdateWithADO(T_Medicen_Sale_Hedar_Model model)
        {
            string Flag = null;
            if (model.Sale_Hedar_Id==0)
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
            cmd.CommandText = "Sp_T_Medicen_Sale_Hedar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlcon;

            cmd.Parameters.AddWithValue("@Sale_Hedar_Id", model.Sale_Hedar_Id);
            cmd.Parameters.AddWithValue("@Sale_Date", model.Sale_Date);//Add a parameters by specifying its name
            cmd.Parameters.AddWithValue("@Client_Id", model.Client_Id);
            cmd.Parameters.AddWithValue("@Global_Id", model.Global_Id);
            cmd.Parameters.AddWithValue("@Sale_Document_Number", model.Sale_Document_Number);
            cmd.Parameters.AddWithValue("@Customer_Name", model.Customer_Name);
            cmd.Parameters.AddWithValue("@Discount_Percentage", model.Discount_Percentage);
            cmd.Parameters.AddWithValue("@Discount_In_Rupees", model.Discount_In_Rupees);
            cmd.Parameters.AddWithValue("@Discount_Amount_Percentage", model.Discount_Amount_Percentage);
            cmd.Parameters.AddWithValue("@Discount_Amount_Rupees", model.Discount_Amount_Rupees);
            cmd.Parameters.AddWithValue("@Total_Amount", model.Total_Amount);
            cmd.Parameters.AddWithValue("@Contact_No", model.Contact_No);
            cmd.Parameters.AddWithValue("@Dr_Name", model.Dr_Name);
            cmd.Parameters.AddWithValue("@Address", model.Address);
            cmd.Parameters.AddWithValue("@Attr1", model.Attr1);
            cmd.Parameters.AddWithValue("@Attr2", model.Attr2);
            cmd.Parameters.AddWithValue("@Created_Date", model.Created_Date);
            cmd.Parameters.AddWithValue("@Updated_Date", model.Updated_Date);
            cmd.Parameters.AddWithValue("@Created_By", model.Created_By);
            cmd.Parameters.AddWithValue("@Updated_By", model.Updated_By);
            cmd.Parameters.AddWithValue("@Flag", Flag);

            cmd.ExecuteNonQuery();
        }

        public void SaveOrUpdatewithenityFrameWork(T_Medicen_Sale_Hedar_Model model)
        {
            throw new NotImplementedException();
        }

        public void SaveWithQuery(T_Medicen_Sale_Hedar_Model model)
        {
                string qry = "Insert into T_Medicen_Sale_Hedar (Sale_Date,Client_Id,Global_Id,Sale_Document_Number,Customer_Name,Discount_Percentage,Discount_In_Rupees,Discount_Amount_Percentage,Discount_Amount_Rupees,Total_Amount,Contact_No,Dr_Name,Address,Attr1,Attr2,Created_Date,Updated_Date,Created_By,Updated_By) VALUES (getdate(),'" + model.Client_Id+"','"+model.Global_Id+"','"+model.Sale_Document_Number+"','"+model.Customer_Name+"','"+model.Discount_Percentage+"','"+model.Discount_In_Rupees+"','"+model.Discount_Amount_Percentage+"','"+model.Discount_Amount_Rupees+"','"+model.Total_Amount+"','"+model.Contact_No + "','"+model.Dr_Name+"','"+model.Address+"','"+model.Attr1+"','"+model.Attr2+"',getdate(),getdate(),'"+model.Created_By+"','"+model.Updated_By+"')";// sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand();//provider of ADO.Net//used to execute commands at on database
            cmd.CommandText = qry;//It is set or return a string that contain a provider
            cmd.CommandType = CommandType.Text;//should  contain text of a query that must be run on the server
            cmd.Connection = sqlcon;//Connecting string

            cmd.ExecuteNonQuery();// It's used for Execute sql command
        }

        public void SaveWithQueryString(T_Medicen_Sale_Hedar_Model model)
        {
            string qry = "Insert into T_Medicen_Sale_Hedar (Sale_Date,Client_Id,Global_Id,Sale_Document_Number,Customer_Name,Discount_Percentage,Discount_In_Rupees,Discount_Amount_Percentage,Discount_Amount_Rupees,Total_Amount,Contact_No,Dr_Name,Address,Attr1,Attr2,Created_Date,Updated_Date,Created_By,Updated_By) VALUES  (@Sale_Date,@Client_Id,@Global_Id,@Sale_Document_Number,@Customer_Name,@Discount_Percentage,@Discount_In_Rupees,@Discount_Amount_Percentage,@Discount_Amount_Rupees,@Total_Amount,@Contact_No,@Dr_Name,@Address,@Attr1,@Attr2,@Created_Date,@Updated_Date,@Created_By,@Updated_By)";// sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd= new SqlCommand();//provider of ADO.Net//used to execute commands at on database
            try
            {


                cmd.CommandText = qry;//It is set or return a string that contain a provider
                cmd.CommandType = CommandType.Text;//should  contain text of a query that must be run on the server
                cmd.Connection = sqlcon;//Connecting string

                cmd.Parameters.AddWithValue("@Sale_Date", model.Sale_Date);//Add a parameters by specifying its name
                cmd.Parameters.AddWithValue("@Client_Id", model.Client_Id);
                cmd.Parameters.AddWithValue("@Global_Id", model.Global_Id);
                cmd.Parameters.AddWithValue("@Sale_Document_Number", model.Sale_Document_Number);
                cmd.Parameters.AddWithValue("@Customer_Name", model.Customer_Name);
                cmd.Parameters.AddWithValue("@Discount_Percentage", model.Discount_Percentage);
                cmd.Parameters.AddWithValue("@Discount_In_Rupees", model.Discount_In_Rupees);
                cmd.Parameters.AddWithValue("@Discount_Amount_Percentage", model.Discount_Amount_Percentage);
                cmd.Parameters.AddWithValue("@Discount_Amount_Rupees", model.Discount_Amount_Rupees);
                cmd.Parameters.AddWithValue("@Total_Amount", model.Total_Amount);
                cmd.Parameters.AddWithValue("@Contact_No", model.Contact_No);
                cmd.Parameters.AddWithValue("@Dr_Name", model.Dr_Name);
                cmd.Parameters.AddWithValue("@Address", model.Address);
                cmd.Parameters.AddWithValue("@Attr1", model.Attr1);
                cmd.Parameters.AddWithValue("@Attr2", model.Attr2);
                cmd.Parameters.AddWithValue("@Created_Date", model.Created_Date);
                cmd.Parameters.AddWithValue("@Updated_Date", model.Updated_Date);
                cmd.Parameters.AddWithValue("@Created_By", model.Created_By);
                cmd.Parameters.AddWithValue("@Updated_By", model.Updated_By);

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
