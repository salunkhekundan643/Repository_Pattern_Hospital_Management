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
    public  class T_Purchase_Hedar_Abstraction : I_T_Purchase_Hedar
    {


        //this function for get datatable from sql using qry string
        //
        public DataTable GetDataTable()
        {

            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand("select * from T_Purchase_Hedar" ,sqlcon);//provider of ADO.Net//used to execute commands at on database
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);// use for retrive data from sql
            DataTable _datatable = new DataTable();//object  declaration of DataTable
            adapter.Fill(_datatable );//called fill() from SqlDataAdapter class for to fill my datatable

            return _datatable;// Connecting string

        }

        public void SaveOrUpdateWithADO(T_Purchase_Hedar_Model model)
        {
            string Flag = null;
            if (model.PurchaseHedarId==0)
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
                cmd.CommandText = "Sp_T_Purchase_Hedar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlcon;

            cmd.Parameters.AddWithValue("@PurchaseHedarId", model.PurchaseHedarId);
            cmd.Parameters.AddWithValue("@ClientId", model.ClientId);//Add a parameters by specifying its name
            cmd.Parameters.AddWithValue("@GlobalId", model.GlobalId);
            cmd.Parameters.AddWithValue("@PurchaseDocumentNo", model.PurchaseDocumentNo);
            cmd.Parameters.AddWithValue("@PurchaseStatus", model.PurchaseStatus);
            cmd.Parameters.AddWithValue("@PurchaseApprovBy", model.PurchaseApprovBy);
            cmd.Parameters.AddWithValue("@ApproveDate", model.ApproveDate);
            cmd.Parameters.AddWithValue("@PurchaseDate", model.PurchaseDate);
            cmd.Parameters.AddWithValue("@PurchaseTotalAmount", model.PurchaseTotalAmount);
            cmd.Parameters.AddWithValue("@PurchaseType", model.PurchaseType);
            cmd.Parameters.AddWithValue("@SupplierId", model.SupplierId);
            cmd.Parameters.AddWithValue("@PayTerms", model.PayTerms);
            cmd.Parameters.AddWithValue("@AgentId", model.AgentId);
            cmd.Parameters.AddWithValue("@Commision", model.Commision);
            cmd.Parameters.AddWithValue("@CommisionAmount", model.CommisionAmount);
            cmd.Parameters.AddWithValue("@TotalPurchaseAmountHedar", model.TotalPurchaseAmountHedar);
            cmd.Parameters.AddWithValue("@Remark", model.Remark);
            cmd.Parameters.AddWithValue("@CreatedBy", model.CreatedBy);
            cmd.Parameters.AddWithValue("@CreatedDate", model.CreatedDate);
            cmd.Parameters.AddWithValue("@UpdatedDate", model.UpdatedDate);
            cmd.Parameters.AddWithValue("@UpdatedBy", model.UpdatedBy);
            cmd.Parameters.AddWithValue("@Attr1", model.Attr1);
            cmd.Parameters.AddWithValue("@Attr2", model.Attr2);
            cmd.Parameters.AddWithValue("@Attr3", model.Attr3);
            cmd.Parameters.AddWithValue("@Attr4", model.Attr4);
            cmd.Parameters.AddWithValue("@Attr5", model.Attr5);
            cmd.Parameters.AddWithValue("@Attr6", model.Attr6);
            cmd.Parameters.AddWithValue("@Attr7", model.Attr7);
            cmd.Parameters.AddWithValue("@Attr8", model.Attr8);
            cmd.Parameters.AddWithValue("@Flag", Flag);

            cmd.ExecuteNonQuery();
        }

        public void SaveWithQuery(T_Purchase_Hedar_Model model)
        {
            string qry = "Insert into T_Purchase_Hedar (ClientId,GlobalId,PurchaseDocumentNo,PurchaseStatus,PurchaseApprovBy,ApproveDate,PurchaseDate,PurchaseTotalAmount,PurchaseType,SupplierId,PayTerms,AgentId,Commision,CommisionAmount,TotalPurchaseAmountHedar,Remark,CreatedBy,CreatedDate,UpdatedDate,UpdatedBy,Attr1,Attr2,Attr3,Attr4,Attr5,Attr6,Attr7,Attr8) values ('" + model.ClientId + "','" + model.GlobalId + "','" + model.PurchaseDocumentNo + "','" + model.PurchaseStatus + "','" + model.PurchaseApprovBy + "',getdate(),getdate(),'" + model.PurchaseTotalAmount + "','" + model.PurchaseType + "','" + model.SupplierId + "','" + model.PayTerms + "','" + model.AgentId + "','" + model.Commision + "','" + model.CommisionAmount + "','" + model.TotalPurchaseAmountHedar + "','" + model.Remark + "','" + model.CreatedBy + "',getdate(),getdate(),'" + model.UpdatedBy + "','" + model.Attr1 + "','" + model.Attr2 + "','" + model.Attr3 + "','" + model.Attr4 + "','" + model.Attr5 + "','" + model.Attr6 + "','" + model.Attr7 + "','" + model.Attr8 + "')";// sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand();//provider of ADO.Net//used to execute commands at on database
            cmd.CommandText = qry;//It is set or return a string that contain a provider
            cmd.CommandType = CommandType.Text;//should  contain text of a query that must be run on the server
            cmd.Connection = sqlcon;//Connecting string

            cmd.ExecuteNonQuery();  // It's used for Execute sql command
        }





        public void SaveWithQueryString(T_Purchase_Hedar_Model model)
        {
            string qry = "Insert into T_Purchase_Hedar (ClientId,GlobalId,PurchaseDocumentNo,PurchaseStatus,PurchaseApprovBy,ApproveDate,PurchaseDate,PurchaseTotalAmount,PurchaseType,SupplierId,PayTerms,AgentId,Commision,CommisionAmount,TotalPurchaseAmountHedar,Remark,CreatedBy,CreatedDate,UpdatedDate,UpdatedBy,Attr1,Attr2,Attr3,Attr4,Attr5,Attr6,Attr7,Attr8) values (@ClientId,@GlobalId,@PurchaseDocumentNo,@PurchaseStatus,@PurchaseApprovBy,@ApproveDate,@PurchaseDate,@PurchaseTotalAmount,@PurchaseType,@SupplierId,@PayTerms,@AgentId,@Commision,@CommisionAmount,@TotalPurchaseAmountHedar,@Remark,@CreatedBy,@CreatedDate,@UpdatedDate,@UpdatedBy,@Attr1,@Attr2,@Attr3,@Attr4,@Attr5,@Attr6,@Attr7,@Attr8)";// sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand();//provider of ADO.Net//used to execute commands at on database
            try
            {


                cmd.CommandText = qry;//It is set or return a string that contain a provider
                cmd.CommandType = CommandType.Text;//should  contain text of a query that must be run on the server
                cmd.Connection = sqlcon;//Connecting string


                cmd.Parameters.AddWithValue("@ClientId", model.ClientId);//Add a parameters by specifying its name
                cmd.Parameters.AddWithValue("@GlobalId", model.GlobalId);
                cmd.Parameters.AddWithValue("@PurchaseDocumentNo", model.PurchaseDocumentNo);
                cmd.Parameters.AddWithValue("@PurchaseStatus", model.PurchaseStatus);
                cmd.Parameters.AddWithValue("@PurchaseApprovBy", model.PurchaseApprovBy);
                cmd.Parameters.AddWithValue("@ApproveDate", model.ApproveDate);
                cmd.Parameters.AddWithValue("@PurchaseDate", model.PurchaseDate);
                cmd.Parameters.AddWithValue("@PurchaseTotalAmount", model.PurchaseTotalAmount);
                cmd.Parameters.AddWithValue("@PurchaseType", model.PurchaseType);
                cmd.Parameters.AddWithValue("@SupplierId", model.SupplierId);
                cmd.Parameters.AddWithValue("@PayTerms", model.PayTerms);
                cmd.Parameters.AddWithValue("@AgentId", model.AgentId);
                cmd.Parameters.AddWithValue("@Commision", model.Commision);
                cmd.Parameters.AddWithValue("@CommisionAmount", model.CommisionAmount);
                cmd.Parameters.AddWithValue("@TotalPurchaseAmountHedar", model.TotalPurchaseAmountHedar);
                cmd.Parameters.AddWithValue("@Remark", model.Remark);
                cmd.Parameters.AddWithValue("@CreatedBy", model.CreatedBy);
                cmd.Parameters.AddWithValue("@CreatedDate", model.CreatedDate);
                cmd.Parameters.AddWithValue("@UpdatedDate", model.UpdatedDate);
                cmd.Parameters.AddWithValue("@UpdatedBy", model.UpdatedBy);
                cmd.Parameters.AddWithValue("@Attr1", model.Attr1);
                cmd.Parameters.AddWithValue("@Attr2", model.Attr2);
                cmd.Parameters.AddWithValue("@Attr3", model.Attr3);
                cmd.Parameters.AddWithValue("@Attr4", model.Attr4);
                cmd.Parameters.AddWithValue("@Attr5", model.Attr5);
                cmd.Parameters.AddWithValue("@Attr6", model.Attr6);
                cmd.Parameters.AddWithValue("@Attr7", model.Attr7);
                cmd.Parameters.AddWithValue("@Attr8", model.Attr8);

                cmd.ExecuteNonQuery();// It's used for Execute sql command
            }
            catch(Exception ex)
            {
                throw ex;

            }
            finally
            {
                sqlcon.Close();
                cmd.Dispose ();
            }

        }
    }
}
    