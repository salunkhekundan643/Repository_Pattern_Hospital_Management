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
    public  class T_Medicen_Sale_Line_Abstraction : I_T_Medicen_Sale_Line
    {
        public List<T_Medicen_Sale_Line_Model> GetDataListWithADO()
        {
            throw new NotImplementedException();
        }

        public List<T_Medicen_Sale_Line> GetDataListWithEntityFramework()
        {
            throw new NotImplementedException();
        }


        //this function for get datatable from sql using qry string
        //
        public DataTable GetDataTable()
        {
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand("select * from T_Medicen_Sale_Line",sqlcon);//provider of ADO.Net//used to execute commands at on database
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);// use for retrive data from sql
            DataTable _datatable = new DataTable();//object  declaration of DataTable
            adapter.Fill(_datatable );//called fill() from SqlDataAdapter class for to fill my datatable

            return _datatable;//Connecting string


        }

        public void SaveOrUpdateWithADO(T_Medicen_Sale_Line_Model model)
        {
            string Flag = null;
            if (model.SaleLineId==0)
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
            cmd.CommandText = "Sp_T_Medicen_Sale_Line";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlcon;


            cmd.Parameters.AddWithValue("@SaleLineId", model.SaleHedarId);//Add a parameters by specifying its name
            cmd.Parameters.AddWithValue("@SaleHedarId", model.SaleHedarId);//Add a parameters by specifying its name
            cmd.Parameters.AddWithValue("@PurchaseLineId", model.PurchaseLineId);
            cmd.Parameters.AddWithValue("@ItemId", model.ItemId);
            cmd.Parameters.AddWithValue("@ItemName", model.ItemName);
            cmd.Parameters.AddWithValue("@ItemBatch", model.ItemBatch);
            cmd.Parameters.AddWithValue("@ItemPckg", model.ItemPckg);
            cmd.Parameters.AddWithValue("@ItemExpDate", model.ItemExpDate);
            cmd.Parameters.AddWithValue("@ItemMfg", model.ItemMfg);
            cmd.Parameters.AddWithValue("@ItemQty", model.ItemQty);
            cmd.Parameters.AddWithValue("@ItemMrp", model.ItemMrp);
            cmd.Parameters.AddWithValue("@ItemTotalamount", model.ItemTotalAmount);
            cmd.Parameters.AddWithValue("@Discount", model.Discount);
            cmd.Parameters.AddWithValue("@PaidUnpaid", model.PaidUnpaid);
            cmd.Parameters.AddWithValue("@Attr1", model.Attr1);
            cmd.Parameters.AddWithValue("@Attr2", model.Attr2);
            cmd.Parameters.AddWithValue("@Attr3", model.Attr3);
            cmd.Parameters.AddWithValue("@CreatedBy", model.CreatedBy);
            cmd.Parameters.AddWithValue("@UpdatedBy", model.UpdatedBy);
            cmd.Parameters.AddWithValue("@CreatedDate", model.CreatedDate);
            cmd.Parameters.AddWithValue("@UpdatedDate", model.UpdatedDate);
            cmd.Parameters.AddWithValue("@Flag", Flag);

            cmd.ExecuteNonQuery();
        }

        public void SaveOrUpdatewithenityFrameWork(T_Medicen_Sale_Line_Model model)
        {
            throw new NotImplementedException();
        }

        public void SaveWithQuery(T_Medicen_Sale_Line_Model model)
        {
            string qry = "Insert into T_Medicen_Sale_Line (SaleHedarId,PurchaseLineId,ItemId,ItemName,ItemBatch,ItemPckg,ItemExpDate,ItemMfg,ItemQty,ItemMrp,ItemTotalAmount,Discount,PaidUnpaid,Attr1,Attr2,Attr3,CreatedBy,UpdatedBy,CreatedDate,UpdatedDate) values ('"+model.SaleHedarId + "','"+model.PurchaseLineId + "','"+model.ItemId + "','"+model.ItemName + "','"+model.ItemBatch + "','"+model.ItemPckg + "',getdate(),'"+model.ItemMfg + "','"+model.ItemQty + "','"+model.ItemMrp + "','"+model.ItemTotalAmount + "','"+model.Discount + "','"+model.PaidUnpaid + "','"+model.Attr1 + "','"+model.Attr2 + "','"+model.Attr3 + "','"+model.CreatedBy + "','"+model.UpdatedBy + "',getdate(),getdate())";// sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class
            SqlConnection sqlcon = cls.Connect();//This is object of ClsFunction class
            SqlCommand cmd = new SqlCommand();//provider of ADO.Net//used to execute commands at on database
            cmd.CommandText = qry;//It is set or return a string that contain a provider
            cmd.CommandType = CommandType.Text;//should  contain text of a query that must be run on the server
            cmd.Connection = sqlcon;//Connecting string

            cmd.ExecuteNonQuery();// It's used for Execute sql command
        }

        public void SaveWithQueryString(T_Medicen_Sale_Line_Model model)
        {
            string qry = "Insert into T_Medicen_Sale_Line (SaleHedarId,PurchaseLineId,ItemId,ItemName,ItemBatch,ItemPckg,ItemExpDate,ItemMfg,ItemQty,ItemMrp,ItemTotalAmount,Discount,PaidUnpaid,Attr1,Attr2,Attr3,CreatedBy,UpdatedBy,CreatedDate,UpdatedDate) values (@SaleHedarId,@PurchaseLineId,@ItemId,@ItemName,@ItemBatch,@ItemPckg,@ItemExpDate,@ItemMfg,@ItemQty,@ItemMrp,@ItemTotalAmount,@Discount,@PaidUnpaid,@Attr1,@Attr2,@Attr3,@CreatedBy,@UpdatedBy,@CreatedDate,@UpdatedDate)";// sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class
            SqlConnection sqlcon= cls.Connect();//This is object of ClsFunction class
            SqlCommand cmd = new SqlCommand();//provider of ADO.Net//used to execute commands at on database
            try
            {



                cmd.CommandText = qry;//It is set or return a string that contain a provider
                cmd.CommandType = CommandType.Text;//should  contain text of a query that must be run on the server
                cmd.Connection = sqlcon;//Connecting string

                cmd.Parameters.AddWithValue("@SaleHedarId", model.SaleHedarId);//Add a parameters by specifying its name
                cmd.Parameters.AddWithValue("@PurchaseLineId", model.PurchaseLineId);
                cmd.Parameters.AddWithValue("@ItemId", model.ItemId);
                cmd.Parameters.AddWithValue("@ItemName", model.ItemName);
                cmd.Parameters.AddWithValue("@ItemBatch", model.ItemBatch);
                cmd.Parameters.AddWithValue("@ItemPckg", model.ItemPckg);
                cmd.Parameters.AddWithValue("@ItemExpDate", model.ItemExpDate);
                cmd.Parameters.AddWithValue("@ItemMfg", model.ItemMfg);
                cmd.Parameters.AddWithValue("@ItemQty", model.ItemQty);
                cmd.Parameters.AddWithValue("@ItemMrp", model.ItemMrp);
                cmd.Parameters.AddWithValue("@ItemTotalamount", model.ItemTotalAmount);
                cmd.Parameters.AddWithValue("@Discount", model.Discount);
                cmd.Parameters.AddWithValue("@PaidUnpaid", model.PaidUnpaid);
                cmd.Parameters.AddWithValue("@Attr1", model.Attr1);
                cmd.Parameters.AddWithValue("@Attr2", model.Attr2);
                cmd.Parameters.AddWithValue("@Attr3", model.Attr3);
                cmd.Parameters.AddWithValue("@CreatedBy", model.CreatedBy);
                cmd.Parameters.AddWithValue("@UpdatedBy", model.UpdatedBy);
                cmd.Parameters.AddWithValue("@CreatedDate", model.CreatedDate);
                cmd.Parameters.AddWithValue("@UpdatedDate", model.UpdatedDate);

                cmd.ExecuteNonQuery();// It's used for Execute sql command

            }
            catch (Exception ex) 
            {
                throw ex;
                
            }

            finally
            {
                sqlcon.Dispose();
                cmd.Dispose();
            }
        }
    }
}
