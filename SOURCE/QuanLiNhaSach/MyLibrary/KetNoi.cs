using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace MyLibrary
{
    public class KetNoi
    {
        private SqlConnection con;
        private string strCon;
        private DataSet dset;

        public SqlConnection Con
        {
            get { return con; }
            set { con = value; }
        }

        public string strConnection
        {
            get { return strCon; }
            set { strCon = value; }
        }

        public DataSet Dset
        {
          get { return dset; }
          set { dset = value; }
        }

        public KetNoi()
        {
            //strConnection = @"Data source = TXPSIUBUCWC5KQD\SQLEXPRESS; Initial Catalog = NHASACH; User ID = sa; Password = 1010";
            strConnection = @"Data source = LAPTOP-V3N8G0SP; Initial Catalog = QLNHASACH; User ID = sa; Password = sa2012";
            Con = new SqlConnection(strConnection);
        }

        public KetNoi(string pStrCon)
        {
            strConnection = "@" + pStrCon;
            Con = new SqlConnection(strConnection);
        }

        public void openConnection()
        {
            Con = new SqlConnection();
            Con.ConnectionString = strConnection;
            if (Con.State == ConnectionState.Open)
                Con.Close();
            Con.Open();
        }

        public void closeConnection()
        {
            if (Con.State == ConnectionState.Open)
                Con.Close();
            Con.Dispose();
        }

        //Dùng để thêm, xóa, sửa
        public void Update(string s)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            cmd.CommandText = s;
            cmd.ExecuteNonQuery();
            closeConnection();
        }

        public double layGiaTriCuaBang(string s)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand(s, Con);
            double t = Convert.ToDouble (cmd.ExecuteScalar());       
            closeConnection();
            return t;
        }

        public int getCount(string s)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            cmd.CommandText = s;
            int count = (int)cmd.ExecuteScalar();
            closeConnection();
            return count;
        }

        public bool checkForExistence(string s)
        {
            int count = getCount(s);
            if(count > 0)
                return true;
            return false;
        }

        public SqlDataReader getDataReader(string s)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            cmd.CommandText = s;
            SqlDataReader data = cmd.ExecuteReader();
            openConnection();
            return data;
        }

        public SqlDataAdapter addTableToDataSet(string s, string tablename)
        {
            SqlDataAdapter data = new SqlDataAdapter(s, Con);
            data.Fill(Dset, tablename);
            return data;
        }

        public DataTable DataTable(string s)
        {
            openConnection();
            SqlDataAdapter data = new SqlDataAdapter(s, Con);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }

    }
}
