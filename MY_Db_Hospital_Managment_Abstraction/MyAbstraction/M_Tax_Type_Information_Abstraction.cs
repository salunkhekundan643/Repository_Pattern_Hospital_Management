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
    public  class M_Tax_Type_Information_Abstraction : I_M_Tax_Type_Information
    {
        public List<M_Tax_Type_Information_Model> GetDataListWithADO()
        {
            throw new NotImplementedException();
        }

        public List<M_Tax_Type_Information> GetDataListWithEntityFramework()
        {
            throw new NotImplementedException();
        }


        //this function for get datatable from sql using qry string
        //
        public DataTable GetDataTable()
        {
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand("select * from M_Tax_Type_Information", sqlcon);//provider of ADO.Net//used to execute commands at on database
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);// use for retrive data from sql
            DataTable _datatable = new DataTable();//object  declaration of DataTable
            adapter.Fill(_datatable);//called fill() from SqlDataAdapter class for to fill my datatable

            return _datatable;//Connecting string


        }

        public void SaveOrUpdateWithADO(M_Tax_Type_Information_Model model)
        {
            string Flag = null;
            if (model.TaxId==0)
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
            cmd.CommandText = "Sp_M_Tax_Type_Information";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlcon;

            cmd.Parameters.AddWithValue("@TaxId", model.TaxId);
            cmd.Parameters.AddWithValue("@TaxName", model.TaxName);//Add a parameters by specifying its name
            cmd.Parameters.AddWithValue("@TaxPercent", model.TaxPercent);
            cmd.Parameters.AddWithValue("@TaxGroupId", model.TaxGroupId);
            cmd.Parameters.AddWithValue("@Flag", Flag);

            cmd.ExecuteNonQuery();
        }

        public void SaveOrUpdatewithenityFrameWork(M_Tax_Type_Information_Model model)
        {
            throw new NotImplementedException();
        }

        public void SaveWithQuery(M_Tax_Type_Information_Model model)
        {
            string qry = "Insert into M_Tax_Type_Information (TaxName,TaxPercent,TaxGroupId) values ('"+model.TaxName + "','"+model.TaxPercent + "','"+model.TaxGroupId + "')";// sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class
            SqlCommand cmd = new SqlCommand();//provider of ADO.Net//used to execute commands at on database
            cmd.CommandText = qry;//It is set or return a string that contain a provider
            cmd.CommandType = CommandType.Text;//should  contain text of a query that must be run on the server
            cmd.Connection = sqlcon;//Connecting string

            cmd.ExecuteNonQuery();// It's used for Execute sql command

        }

        public void SaveWithQueryString(M_Tax_Type_Information_Model model)
        {
            string qry = "Insert into M_Tax_Type_Information (TaxName,TaxPercent,TaxGroupId) values (@TaxName,@TaxPercent,@TaxGroupId)";// sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class   
            SqlCommand cmd = new SqlCommand();//provider of ADO.Net//used to execute commands at on database

            try
            {



                cmd.CommandText = qry;//It is set or return a string that contain a provider
                cmd.CommandType = CommandType.Text;//should  contain text of a query that must be run on the server
                cmd.Connection = sqlcon;//Connecting string

                cmd.Parameters.AddWithValue("@TaxName", model.TaxName);//Add a parameters by specifying its name
                cmd.Parameters.AddWithValue("@TaxPercent", model.TaxPercent);
                cmd.Parameters.AddWithValue("@TaxGroupId", model.TaxGroupId);

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
