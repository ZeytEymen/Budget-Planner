using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ButcePlanlamam
{
    class ClassConnection
    {

        string ConnectionString = @"Data Source=zeyt\sqlexpress;Initial Catalog=Butce;Integrated Security=True";
        SqlConnection con;

        public void OpenConection()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
            if (con.State != ConnectionState.Open)
            {
                System.Windows.Forms.MessageBox.Show("Bağlantı Hatası");
            }
        }

        public void CloseConnection()
        {
            con.Close();
        }


        public void ExecuteQueries(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
        }


        public SqlDataReader DataReader(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader CboxCek(string Query_, System.Windows.Forms.ComboBox obj, int index)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                 obj.Items.Add(dr[index].ToString());    
            }
            return dr;           
        }
        public SqlDataReader ListCek(string Query_, System.Windows.Forms.ListBox obj, int index)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                obj.Items.Add(dr[index].ToString());
            }
            return dr;
        }

        public object ShowDataInGridView(string Query_)
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }
    }
}
