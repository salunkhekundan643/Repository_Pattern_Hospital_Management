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
    public  class M_Item_Information_Abstraction : I_M_Item_Information
    {

        //this function for get datatable from sql using qry string
        //
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
            if (model.ItemId==0)
            {
                Flag = "I";

            }
            else 
            {
                Flag = "U";
            }

            ClsFunction cls = new ClsFunction();
            SqlConnection sqlcon= cls.Connect();
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

        public void SaveWithQuery(M_Item_Information_Model model)
        {
            string qry = "Insert into M_Item_Information (ItemCode,ItemType,ItemName,ItemManufactionName,ItemPacinking,ItemUseName,ItemDescription,ItemStartDate,ItemEndDate,ItemFirstUnit,ItemSecondUnit,ItemConversionFirstFactor,ItemConversionSecondfactor,ItemIsStockebal,ItemQualityCheck,ItemReturnPolicy,ItemMinQTY,ItemMaxQTY,ItemHsnCode,ItemPoType,ItemTaxApply,ItemPoTaxGroup,ItemSaleTaxGroup,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,ActiveFlag,Attr1,Attr2,Attr3,Attr4,Attr5,Attr6) values ('"+model.ItemCode + "','"+model.ItemType + "','"+model.ItemName + "','"+model.ItemManufactionName + "','"+model.ItemPacinking + "','"+model.ItemUseName + "','"+model.ItemDescription + "',getdate(),getdate(),'"+model.ItemFirstUnit + "','"+model.ItemSecondUnit + "','"+model.ItemConversionFirstFactor + "','"+model.ItemConversionSecondFactor + "','"+model.ItemIsStockebal + "','"+model.ItemQualityCheck + "','"+model.ItemReturnPolicy + "','"+model.ItemMinQTY + "','"+model.ItemMaxQTY + "','"+model.ItemHsnCode + "','"+model.ItemPoType + "','"+model.ItemTaxApply + "','"+model.ItemPoTaxGroup + "','"+model.ItemSaleTaxGroup + "','"+model.CreatedBy + "',getdate(),'"+model.UpdatedBy + "',getdate(),'"+model.ActiveFlag + "','"+model.Attr1 + "','"+model.Attr2 + "','"+model.Attr3 + "','"+model.Attr4 + "','"+model.Attr5 + "','"+model.Attr6 + "')";// sequence of character
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
            string qry = "Insert into M_Item_Information (ItemCode,ItemType,ItemName,ItemManufactionName,ItemPacinking,ItemUseName,ItemDescription,ItemStartDate,ItemEndDate,ItemFirstUnit,ItemSecondUnit,ItemConversionFirstFactor,ItemConversionSecondfactor,ItemIsStockebal,ItemQualityCheck,ItemReturnPolicy,ItemMinQTY,ItemMaxQTY,ItemHsnCode,ItemPoType,ItemTaxApply,ItemPoTaxGroup,ItemSaleTaxGroup,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,ActiveFlag,Attr1,Attr2,Attr3,Attr4,Attr5,Attr6) values (@ItemCode,@ItemType,@ItemName,@ItemManufactionName,@ItemPacinking,@ItemUseName,@ItemDescription,@ItemStartDate,@ItemEndDate,@ItemFirstUnit,@ItemSecondUnit,@ItemConversionFirstFactor,@ItemConversionSecondFactor,@ItemIsStockebal,@ItemQualityCheck,@ItemReturnPolicy,@ItemMinQTY,@ItemMaxQTY,@ItemHsnCode,@ItemPoType,@ItemTaxApply,@ItemPoTaxGroup,@ItemSaleTaxGroup,@CreatedBy,@CreatedDate,@UpdatedBy,@UpdatedDate,@ActiveFlag,@Attr1,@Attr2,@Attr3,@Attr4,@Attr5,@Attr6)";// sequence of character
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
           

