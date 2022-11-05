using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.Controllers
{
    internal class DataProvider
    {
        // Tạo Singleton khởi tạo kết nối 1 lần duy nhất
        // trong cả vòng đời ứng dụng
        // và sử dụng không cần tạo đối tượng (phương thức tĩnh - static)
        private static DataProvider ?instance;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider();  return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        private DataProvider() {}


        private string strConnect = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "Database\\BTLCSharp.mdf;Integrated Security=True";
        private SqlConnection connection = null;



        // Kết nối đến CSDL
        public void ConnectToDatabase()
        {
            connection = new SqlConnection(strConnect);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // Đóng kết nối CSDL
        public void DisconnectToDataBase()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // Đọc dữ liệu từ database và trả về data table
        public DataTable ReadTable(string sql)
        {
            ConnectToDatabase();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);

            DisconnectToDataBase();

            return table;
        }

        // Truy vấn dữ liệu từ database
        public int ExecuteNonQuery(string sql)
        {
            int data = 0;
            if(sql != null)
            {
                ConnectToDatabase();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = sql;
                data = command.ExecuteNonQuery();
                DisconnectToDataBase();
            }

            // Trả về số dòng thành công
            return data;
        }

        public object ExecuteScalar(string sql)
        {
            object data = 0;
            if (sql != null)
            {
                ConnectToDatabase();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = sql;
                data = command.ExecuteScalar();
                DisconnectToDataBase();
            }

            // Trả về ô đầu tiên của dữ liệu trả về
            // (count, total,...)
            return data;
        }
    }
}
