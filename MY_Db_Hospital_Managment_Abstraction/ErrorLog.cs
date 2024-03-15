using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using MY_Db_Hospital_Managment_Connection.My_Connection;
namespace MY_Db_Hospital_Managment_Abstraction
{
    public  class ErrorLog
    {
        public void Error(string ClassName ,string FunctionName,string LineNumber,string ErrorMessage)
        {
            ClsFunction cls= new ClsFunction();
            SqlConnection sqlcon = cls.Connect();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.CommandText = "Sp_ErrorLog";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = sqlcon;

                cmd.Parameters.AddWithValue("@ClassName", ClassName);
                cmd.Parameters.AddWithValue("@FunctionName", FunctionName);
                cmd.Parameters.AddWithValue("@LineNumber", LineNumber);
                cmd.Parameters.AddWithValue("@ErrorMessage", ErrorMessage);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;

            }

 
        }
        
    }
}
