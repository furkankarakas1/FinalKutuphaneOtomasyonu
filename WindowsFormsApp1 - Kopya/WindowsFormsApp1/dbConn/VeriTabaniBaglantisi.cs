using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.dbConn
{
    class VeriTabaniBaglantisi
     {

        private SqlDataAdapter dataAdapter;
        public SqlConnection baglanti;

        public VeriTabaniBaglantisi()
        {
            dataAdapter = new SqlDataAdapter();
            baglanti = new SqlConnection(@"Data Source=DESKTOP-EOR3B17\MSSQLSERVER1;Initial Catalog=theData;Integrated Security=True");

        }

        private SqlConnection openConnection()
        {

            if(baglanti.State == ConnectionState.Closed || baglanti.State == System.Data.ConnectionState.Broken)
            {
                baglanti.Open();
            }

            return baglanti;

        }

        public DataTable executeSelectQuery(String _query,SqlParameter[] sqlParameter)
        {

            SqlCommand myCommand = new SqlCommand();
            DataTable dataTable = new DataTable();
            dataTable = null;

            DataSet ds = new DataSet();

            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myCommand.ExecuteNonQuery();

                dataAdapter.SelectCommand = myCommand;
                dataAdapter.Fill(ds);
                dataTable = ds.Tables[0];

            }
            catch (SqlException e) {
                Console.WriteLine("Hata : Connection.ExecuteSelectQuery - Query : " + _query + "\n Exception :" + e.StackTrace.ToString());
                return null;
            }
            finally { }


            return dataTable;
        }








        public bool executeInsertQuery(String _query, SqlParameter[] sqlParameter)
        {

            SqlCommand myCommand = new SqlCommand();
  
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                dataAdapter.InsertCommand = myCommand;
                myCommand.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                Console.WriteLine("Hata : Connection.ExecuteInsertQuery - Query : " + _query + "\n Exception :" + e.StackTrace.ToString());
                return false;
            }
            finally { }


            return true;

        }





        public bool executeUpdateQuery(String _query, SqlParameter[] sqlParameter)
        {

            SqlCommand myCommand = new SqlCommand();


            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                dataAdapter.UpdateCommand = myCommand;
                myCommand.ExecuteNonQuery();

            }

            catch (SqlException e)
            {
                Console.WriteLine("Hata : Connection.ExecuteUpdateQuery - Query :  " + _query + "\n Exception :" + e.StackTrace.ToString());
                return false;
            }
            finally { }


            return true;
        }












        public bool executeDeleteQuery(String _query)
        {

            SqlCommand myCommand = new SqlCommand(); 
            
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                dataAdapter.UpdateCommand = myCommand;
                myCommand.ExecuteNonQuery();



            }
            catch (SqlException e)
            {
                Console.WriteLine("Hata : Connection.ExecuteDeleteQuery - Query :  " + _query + "\n Exception :" + e.StackTrace.ToString());
                return false;
            }
            finally { }


            return true;
        }




    }
}
