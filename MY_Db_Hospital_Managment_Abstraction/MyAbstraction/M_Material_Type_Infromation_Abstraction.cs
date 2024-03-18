using MY_Db_Hospital_Managment.Master_Model;
using MY_Db_Hospital_Managment_Interface.Master_Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MY_Db_Hospital_Managment_Connection.My_Connection;
using My_Db_Hospital_Management_EntityFramework.MyDbContext;

namespace MY_Db_Hospital_Managment_Abstraction.MyAbstraction
{
    public  class M_Material_Type_Infromation_Abstraction : I_M_Material_Type_Infromation
    {

        //this function for get datatable from sql using qry string
        public DataTable GetDataTable()
        {
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class 
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand("select * from M_Material_Type_Infromation",sqlcon);//provider of ADO.Net//used to execute commands at on database
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);//use for retrive data from sql
            DataTable _datatable = new DataTable();//object  declaration of DataTable
            adapter.Fill(_datatable);//called fill() from SqlDataAdapter class for to fill my datatable

            return _datatable;//Connecting string
        }

        public void SaveOrUpdateWithADO(M_Material_Type_Infromation_Model model)
        {
            string Flag = null;
            if (model.MaterialTypeId==0)
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
            cmd.CommandText = "Sp_M_Material_Type_Infromation";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlcon;

            cmd.Parameters.AddWithValue("@MaterialTypeId", model.MaterialTypeId);
            cmd.Parameters.AddWithValue("@MaterialType", model.MaterialType);
            cmd.Parameters.AddWithValue("@GlobalId", model.GlobalId);
            cmd.Parameters.AddWithValue("@CreatedBy", model.CreatedBy);
            cmd.Parameters.AddWithValue("@CreatedDate", model.CreatedDate);
            cmd.Parameters.AddWithValue("@UpdatedBy", model.UpdatedBy);
            cmd.Parameters.AddWithValue("@UpdatedDate", model.UpdatedDate);
            cmd.Parameters.AddWithValue("@Flag", Flag);

            cmd.ExecuteNonQuery();
        }

       

        public void SaveWithQuery(M_Material_Type_Infromation_Model model)
        {
            string qry = "Insert into M_Material_Type_Infromation (MaterialType,GlobalId,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate) values ('"+model.MaterialType + "','"+model.GlobalId + "','"+model.CreatedBy + "',getdate(),'"+model.UpdatedBy + "',getdate())";// sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class 
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand();//provider of ADO.Net//used to execute commands at on database
            cmd.CommandText = qry;//It is set or return a string that contain a provider
            cmd.CommandType = CommandType.Text;//should  contain text of a query that must be run on the server
            cmd.Connection = sqlcon;//Connecting string

            cmd.ExecuteNonQuery();// It's used for Execute sql command


        }


        public void SaveWithQueryString(M_Material_Type_Infromation_Model model)
        {
            string qry = "Insert into M_Material_Type_Infromation (MaterialType,GlobalId,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate) values (@MaterialType,@GlobalId,@CreatedBy,@CreatedDate,@UpdatedBy,@UpdatedDate)";// sequence of character
            ClsFunction cls = new ClsFunction();//This is object of ClsFunction class 
            SqlConnection sqlcon = cls.Connect();//called connect() method form Clsfunction class 
            SqlCommand cmd = new SqlCommand();//provider of ADO.Net//used to execute commands at on database

            try
            {

                cmd.CommandText = qry;//It is set or return a string that contain a provider
                cmd.CommandType = CommandType.Text;//should  contain text of a query that must be run on the server
                cmd.Connection = sqlcon;//Connecting string

                cmd.Parameters.AddWithValue("@MaterialType", model.MaterialType);
                cmd.Parameters.AddWithValue("@GlobalId", model.GlobalId);
                cmd.Parameters.AddWithValue("@CreatedBy", model.CreatedBy);
                cmd.Parameters.AddWithValue("@CreatedDate", model.CreatedDate);
                cmd.Parameters.AddWithValue("@UpdatedBy", model.UpdatedBy);
                cmd.Parameters.AddWithValue("@UpdatedDate", model.UpdatedDate);

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
        public List<M_Material_Type_Infromation_Model> GetDataListWithADO()
        {
            throw new NotImplementedException();
        }
        public void SaveOrUpdatewithenityFrameWork(M_Material_Type_Infromation_Model model)
        {
            throw new NotImplementedException();
        }

        public List<M_Material_Type_Infromation> GetDataListWithEntityFramework()
        {
            throw new NotImplementedException();
        }
    }
}
