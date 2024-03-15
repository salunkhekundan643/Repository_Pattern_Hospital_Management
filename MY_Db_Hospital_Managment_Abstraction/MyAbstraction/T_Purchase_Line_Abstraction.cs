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
    public  class T_Purchase_Line_Abstraction:I_T_Purchase_Line
    {


        //this function for get datatable from sql using qry string
        //
        public DataTable GetDataTable()
        {
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand("select * from T_Purchase_Line",sqlcon);//provider of ADO.Net//used to execute commands at on database
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);// use for retrive data from sql
            DataTable _datatable = new DataTable();//object  declaration of DataTable
            adapter.Fill(_datatable );//called fill() from SqlDataAdapter class for to fill my datatable

            return _datatable;// Connecting string

        }

        public void SaveOrUpdateWithADO(T_Purchase_Line_Model model)
        {
            string Flag = null;
            if (model.PurchaseLineId==0)
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

            cmd.CommandText = "Sp_T_Purchase_Line";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection= sqlcon;
            cmd.Parameters.AddWithValue("@PurchaseLineId", model.PurchaseLineId);//Add a parameters by specifying its name
            cmd.Parameters.AddWithValue("@PurchaseHedar", model.PurchaseHedar);//Add a parameters by specifying its name
            cmd.Parameters.AddWithValue("@ClientId", model.ClientId);
            cmd.Parameters.AddWithValue("@GlobalId", model.GlobalId);
            cmd.Parameters.AddWithValue("@ItemId", model.ItemId);
            cmd.Parameters.AddWithValue("@ItemQty", model.ItemQty);
            cmd.Parameters.AddWithValue("@ItemTotalStripQty", model.ItemTotalStripQty);
            cmd.Parameters.AddWithValue("@ItemStripQty", model.ItemStripQty);
            cmd.Parameters.AddWithValue("@ItemPerUnitRate", model.ItemPerUnitRate);
            cmd.Parameters.AddWithValue("@ItemUnit", model.ItemUnit);
            cmd.Parameters.AddWithValue("@ItemRate", model.ItemRate);
            cmd.Parameters.AddWithValue("@ItemPacking", model.ItemPacking);
            cmd.Parameters.AddWithValue("@TaxId", model.TaxId);
            cmd.Parameters.AddWithValue("@GodownId", model.GodownId);
            cmd.Parameters.AddWithValue("@BranchId", model.BranchId);
            cmd.Parameters.AddWithValue("@DevileryDate", model.DevileryDate);
            cmd.Parameters.AddWithValue("@TotalAmount", model.TotalAmount);
            cmd.Parameters.AddWithValue("@TaxType", model.TaxType);
            cmd.Parameters.AddWithValue("@BasicAmount", model.BasicAmount);
            cmd.Parameters.AddWithValue("@TaxAmount", model.TaxAmount);
            cmd.Parameters.AddWithValue("@QualityCheck", model.QualityCheck);
            cmd.Parameters.AddWithValue("@BatchNO", model.BatchNO);
            cmd.Parameters.AddWithValue("@BatchDate", model.BatchDate);
            cmd.Parameters.AddWithValue("@ExpireDate", model.ExpireDate);
            cmd.Parameters.AddWithValue("@ItemMrp", model.ItemMrp);
            cmd.Parameters.AddWithValue("@ItemDiscount", model.ItemDiscount);
            cmd.Parameters.AddWithValue("@ItemMediRate", model.ItemMediRate);
            cmd.Parameters.AddWithValue("@MediQty", model.MediQty);
            cmd.Parameters.AddWithValue("@GstVat", model.GstVat);
            cmd.Parameters.AddWithValue("@Sgst", model.Sgst);
            cmd.Parameters.AddWithValue("@Igst", model.Igst);
            cmd.Parameters.AddWithValue("@MediTotalAmount", model.MediTotalAmount);
            cmd.Parameters.AddWithValue("@CreatedBy", model.CreatedBy);
            cmd.Parameters.AddWithValue("@UpdatedBy", model.UpdatedBy);
            cmd.Parameters.AddWithValue("@CreatedDate", model.CreatedDate);
            cmd.Parameters.AddWithValue("@UpdatedDate", model.UpdatedDate);
            cmd.Parameters.AddWithValue("@Attr1", model.Attr1);
            cmd.Parameters.AddWithValue("@Attr2", model.Attr2);
            cmd.Parameters.AddWithValue("@Attr3", model.Attr3);
            cmd.Parameters.AddWithValue("@Attr4", model.Attr4);
            cmd.Parameters.AddWithValue("@Attr5", model.Attr5);
            cmd.Parameters.AddWithValue("@Attr6", model.Attr6);
            cmd.Parameters.AddWithValue("@Attr7", model.Attr7);
            cmd.Parameters.AddWithValue("@HsnCode", model.HsnCode);
            cmd.Parameters.AddWithValue("@SachDiscount", model.SachDiscount);
            cmd.Parameters.AddWithValue("@CompanyName", model.CompanyName);
            cmd.Parameters.AddWithValue("@FreeQty", model.FreeQty);
            cmd.Parameters.AddWithValue("@PackingId", model.PackingId);
            cmd.Parameters.AddWithValue("@DiscountAmount", model.DiscountAmount);
            cmd.Parameters.AddWithValue("@Flag", Flag);


            cmd.ExecuteNonQuery();
        }

        public void SaveWithQuery(T_Purchase_Line_Model model)
        {
            string qry = "INsert into T_Purchase_Line (PurchaseHedar,ClientId,GlobalId,ItemId,ItemQty,ItemTotalStripQty,ItemStripQty,ItemPerUnitRate,ItemUnit,ItemRate,ItemPacking,TaxId,GodownId,BranchId,DevileryDate,TotalAmount,TaxType,BasicAmount,TaxAmount,QualityCheck,BatchNO,BatchDate,ExpireDate,ItemMrp,ItemDiscount,ItemMediRate,MediQty,GstVat,Sgst,Igst,MediTotalAmount,CreatedBy,UpdatedBy,CreatedDate,UpdatedDate,Attr1,Attr2,Attr3,Attr4,Attr5,Attr6,Attr7,HsnCode,SachDiscount,CompanyName,FreeQty,PackingId,DiscountAmount) values ('" + model.PurchaseHedar + "','" + model.ClientId + "','" + model.GlobalId + "','" + model.ItemId + "','" + model.ItemQty + "','" + model.ItemTotalStripQty + "','" + model.ItemStripQty + "','" + model.ItemPerUnitRate + "','" + model.ItemUnit + "','" + model.ItemRate + "','" + model.ItemPacking + "','" + model.TaxId + "','" + model.GodownId + "','" + model.BranchId + "',getdate(),'" + model.TotalAmount + "','" + model.TaxType + "','" + model.BasicAmount + "','" + model.TaxAmount + "','" + model.QualityCheck + "','" + model.BatchNO + "',getdate(),getdate(),'" + model.ItemMrp + "','" + model.ItemDiscount + "','" + model.ItemMediRate + "','" + model.MediQty + "','" + model.GstVat + "','" + model.Sgst + "','" + model.Igst + "','" + model.MediTotalAmount + "','" + model.CreatedBy + "',getdate(),getdate(),getdate(),'" + model.Attr1 + "','" + model.Attr2 + "','" + model.Attr3 + "','" + model.Attr4 + "','" + model.Attr5 + "','" + model.Attr6 + "','" + model.Attr7 + "','" + model.HsnCode + "','" + model.SachDiscount + "','" + model.CompanyName + "','" + model.FreeQty + "','" + model.PackingId + "','" + model.DiscountAmount + "')";// sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand();//provider of ADO.Net//used to execute commands at on database
            cmd.CommandText = qry;//It is set or return a string that contain a provider
            cmd.CommandType = CommandType.Text;//should  contain text of a query that must be run on the server
            cmd.Connection = sqlcon;// Connecting string


            cmd.ExecuteNonQuery();// It's used for Execute sql command
        }





        public void SaveWithQueryString(T_Purchase_Line_Model model)
        {
            string qry = "INsert into T_Purchase_Line (PurchaseHedar,ClientId,GlobalId,ItemId,ItemQty,ItemTotalStripQty,ItemStripQty,ItemPerUnitRate,ItemUnit,ItemRate,ItemPacking,TaxId,GodownId,BranchId,DevileryDate,TotalAmount,TaxType,BasicAmount,TaxAmount,QualityCheck,BatchNO,BatchDate,ExpireDate,ItemMrp,ItemDiscount,ItemMediRate,MediQty,GstVat,Sgst,Igst,MediTotalAmount,CreatedBy,UpdatedBy,CreatedDate,UpdatedDate,Attr1,Attr2,Attr3,Attr4,Attr5,Attr6,Attr7,HsnCode,SachDiscount,CompanyName,FreeQty,PackingId,DiscountAmount) values (@PurchaseHedar, @ClientId, @GlobalId, @ItemId, @ItemQty, @ItemTotalStripQty, @ItemStripQty, @ItemPerUnitRate, @ItemUnit, @ItemRate, @ItemPacking, @TaxId, @GodownId, @BranchId, @DevileryDate, @TotalAmount, @TaxType, @BasicAmount, @TaxAmount, @QualityCheck, @BatchNO, @BatchDate, @ExpireDate, @ItemMrp, @ItemDiscount, @ItemMediRate, @MediQty, @GstVat, @Sgst, @Igst, @MediTotalAmount, @CreatedBy, @UpdatedBy, @CreatedDate, @UpdatedDate, @Attr1, @Attr2, @Attr3, @Attr4, @Attr5, @Attr6, @Attr7, @HsnCode, @SachDiscount, @CompanyName, @FreeQty, @PackingId, @DiscountAmount)";// sequence of character

            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand();//provider of ADO.Net//used to execute commands at on database

            try
            {



                cmd.CommandText = qry;//It is set or return a string that contain a provider
                cmd.CommandType = CommandType.Text;//should  contain text of a query that must be run on the server
                cmd.Connection = sqlcon;//Connecting string

                cmd.Parameters.AddWithValue("@PurchaseHedar", model.PurchaseHedar);//Add a parameters by specifying its name
                cmd.Parameters.AddWithValue("@ClientId", model.ClientId);
                cmd.Parameters.AddWithValue("@GlobalId", model.GlobalId);
                cmd.Parameters.AddWithValue("@ItemId", model.ItemId);
                cmd.Parameters.AddWithValue("@ItemQty", model.ItemQty);
                cmd.Parameters.AddWithValue("@ItemTotalStripQty", model.ItemTotalStripQty);
                cmd.Parameters.AddWithValue("@ItemStripQty", model.ItemStripQty);
                cmd.Parameters.AddWithValue("@ItemPerUnitRate", model.ItemPerUnitRate);
                cmd.Parameters.AddWithValue("@ItemUnit", model.ItemUnit);
                cmd.Parameters.AddWithValue("@ItemRate", model.ItemRate);
                cmd.Parameters.AddWithValue("@ItemPacking", model.ItemPacking);
                cmd.Parameters.AddWithValue("@TaxId", model.TaxId);
                cmd.Parameters.AddWithValue("@GodownId", model.GodownId);
                cmd.Parameters.AddWithValue("@BranchId", model.BranchId);
                cmd.Parameters.AddWithValue("@DevileryDate", model.DevileryDate);
                cmd.Parameters.AddWithValue("@TotalAmount", model.TotalAmount);
                cmd.Parameters.AddWithValue("@TaxType", model.TaxType);
                cmd.Parameters.AddWithValue("@BasicAmount", model.BasicAmount);
                cmd.Parameters.AddWithValue("@TaxAmount", model.TaxAmount);
                cmd.Parameters.AddWithValue("@QualityCheck", model.QualityCheck);
                cmd.Parameters.AddWithValue("@BatchNO", model.BatchNO);
                cmd.Parameters.AddWithValue("@BatchDate", model.BatchDate);
                cmd.Parameters.AddWithValue("@ExpireDate", model.ExpireDate);
                cmd.Parameters.AddWithValue("@ItemMrp", model.ItemMrp);
                cmd.Parameters.AddWithValue("@ItemDiscount", model.ItemDiscount);
                cmd.Parameters.AddWithValue("@ItemMediRate", model.ItemMediRate);
                cmd.Parameters.AddWithValue("@MediQty", model.MediQty);
                cmd.Parameters.AddWithValue("@GstVat", model.GstVat);
                cmd.Parameters.AddWithValue("@Sgst", model.Sgst);
                cmd.Parameters.AddWithValue("@Igst", model.Igst);
                cmd.Parameters.AddWithValue("@MediTotalAmount", model.MediTotalAmount);
                cmd.Parameters.AddWithValue("@CreatedBy", model.CreatedBy);
                cmd.Parameters.AddWithValue("@UpdatedBy", model.UpdatedBy);
                cmd.Parameters.AddWithValue("@CreatedDate", model.CreatedDate);
                cmd.Parameters.AddWithValue("@UpdatedDate", model.UpdatedDate);
                cmd.Parameters.AddWithValue("@Attr1", model.Attr1);
                cmd.Parameters.AddWithValue("@Attr2", model.Attr2);
                cmd.Parameters.AddWithValue("@Attr3", model.Attr3);
                cmd.Parameters.AddWithValue("@Attr4", model.Attr4);
                cmd.Parameters.AddWithValue("@Attr5", model.Attr5);
                cmd.Parameters.AddWithValue("@Attr6", model.Attr6);
                cmd.Parameters.AddWithValue("@Attr7", model.Attr7);
                cmd.Parameters.AddWithValue("@HsnCode", model.HsnCode);
                cmd.Parameters.AddWithValue("@SachDiscount", model.SachDiscount);
                cmd.Parameters.AddWithValue("@CompanyName", model.CompanyName);
                cmd.Parameters.AddWithValue("@FreeQty", model.FreeQty);
                cmd.Parameters.AddWithValue("@PackingId", model.PackingId);
                cmd.Parameters.AddWithValue("@DiscountAmount", model.DiscountAmount);


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
