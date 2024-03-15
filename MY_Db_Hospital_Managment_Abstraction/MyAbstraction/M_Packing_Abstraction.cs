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
    public  class M_Packing_Abstraction : I_M_Packing
    {


        //this function for get datatable from sql using qry string
        //
        public DataTable GetDataTable()
        {
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand("select * from M_Packing", sqlcon);//provider of ADO.Net//used to execute commands at on database
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);// use for retrive data from sql
            DataTable _datatable = new DataTable();//object  declaration of DataTable
            adapter.Fill(_datatable);//called fill() from SqlDataAdapter class for to fill my datatable

            return _datatable;//Connecting string


        }

        public void SaveOrupdateWithADO(M_Packing_Model model)
        {
            string Flag = null;
            if (model.PackingId==0)
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
            cmd.CommandText = "Sp_M_Packing";
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Connection=sqlcon;

            cmd.Parameters.AddWithValue("@PackingId", model.PackingId);
            cmd.Parameters.AddWithValue("@PackingName", model.PackingName);
            cmd.Parameters.AddWithValue("@FirstPackingConvert", model.FirstPackingConvert);
            cmd.Parameters.AddWithValue("@SecondPackingConvert", model.SecondPackingConvert);
            cmd.Parameters.AddWithValue("@Attr1", model.Attr1);
            cmd.Parameters.AddWithValue("@Attr2", model.Attr2);
            cmd.Parameters.AddWithValue("@Flag", Flag);


            cmd.ExecuteNonQuery();

        }

        public void SaveWithQuery(M_Packing_Model model)
        {
            string qry = "Insert into M_Packing (PackingName,FirstPackingConvert,SecondPackingConvert,Attr1,Attr2) values ('"+model.PackingName + "','"+model.FirstPackingConvert + "','"+model.SecondPackingConvert + "','"+model.Attr1 + "','"+model.Attr2+"')";// sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand();//provider of ADO.Net//used to execute commands at on database
            cmd.CommandText=qry;//It is set or return a string that contain a provider
            cmd.CommandType = CommandType.Text;//should  contain text of a query that must be run on the server
            cmd.Connection = sqlcon;//Connecting string

            cmd.ExecuteNonQuery();// It's used for Execute sql command
        }

        public void SaveWithQueryString (M_Packing_Model model)
        {
            string qry = "Insert into M_Packing (PackingName,FirstPackingConvert,SecondPackingConvert,Attr1,Attr2) values (@PackingName,@FirstPackingConvert,@SecondPackingConvert,@Attr1,@Attr2)";// sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand();//provider of ADO.Net//used to execute commands at on database
            try
            {

                cmd.CommandText = qry;//It is set or return a string that contain a provider    
                cmd.CommandType = CommandType.Text;//should  contain text of a query that must be run on the server
                cmd.Connection = sqlcon; //Connecting string

                cmd.Parameters.AddWithValue("@PackingName", model.PackingName);
                cmd.Parameters.AddWithValue("@FirstPackingConvert", model.FirstPackingConvert);
                cmd.Parameters.AddWithValue("@SecondPackingConvert", model.SecondPackingConvert);
                cmd.Parameters.AddWithValue("@Attr1", model.Attr1);
                cmd.Parameters.AddWithValue("@Attr2", model.Attr2);

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
