using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace Flower_Management_System.Database
{
    public class System_Database_SQL
    {
        private SqlConnection connect;
        private SqlCommand command;
        private SqlDataAdapter data_adapter;

        public SqlConnection Connect
        {
            get
            {
                return connect;
            }
            set
            {
                connect = value;
            }

        }
        public SqlCommand Command
        {
            get
            {
                return command;
            }
            set
            {
                command = value;
            }
        }
        public SqlDataAdapter Data_adapter
        {
            get
            {
                return data_adapter;
            }
            set
            {
                data_adapter = value;
            }
        }

        internal System_Database_SQL()
        {
            Connect = new SqlConnection(@"Data Source=DESKTOP-DLP1BUU;Initial Catalog=Flower_Management_System;Integrated Security=True");
            Command = new SqlCommand();
        }
        internal bool Check_Exist_Value(string value_check)
        {
            // Mở kết nối
            Connect.Open();

            Command.CommandText = value_check;

            Command.CommandType = CommandType.Text;
            Command.Connection = Connect;
            Command.ExecuteNonQuery();

            SqlDataReader reader = Command.ExecuteReader();

            if (reader.Read())
            {
                Command.Dispose();
                Connect.Close();
                return true;
            }
            else
            {
                Command.Dispose();
                Connect.Close();
                return false;
            }
        }

        internal DataTable Get_Database(string query_SQL_command)
        {
            Connect.Open();

            Command.CommandText = query_SQL_command; // command execute here
            Command.CommandType = CommandType.Text;
            Command.Connection = Connect;
            Command.ExecuteNonQuery();

            SqlDataAdapter Data_Adapter = new SqlDataAdapter(Command);

            DataTable storage = new DataTable();

            // Đưa vào kho
            Data_Adapter.Fill(storage);

            // Đóng kết nối
            Connect.Close();

            return storage;
        }
        internal void Basic_Query(string query)
        {
            Connect.Open();

            Command.CommandText = query;

            Command.CommandType = CommandType.Text;
            Command.Connection = Connect;
            Command.ExecuteNonQuery();
            Command.Dispose();

            Connect.Close();
        }
        internal void Advance_Query(string image_location, string query)
        {
            Connect.Open();

            byte[] image_byte = null;

            FileStream fstream = new FileStream(image_location, FileMode.Open, FileAccess.Read);
            BinaryReader breader = new BinaryReader(fstream);
            image_byte = breader.ReadBytes((int)fstream.Length);

            Command.CommandText = query;

            Command.CommandType = CommandType.Text;
            Command.Connection = Connect;
            Command.Parameters.Clear();
            Command.Parameters.Add(new SqlParameter("@img", image_byte));

            Command.ExecuteNonQuery();

            Command.Dispose();

            Connect.Close();
        }
        internal void Advance_Query(byte[] image_byte, string query)
        {
            Connect.Open();
         
            Command.CommandText = query;

            Command.CommandType = CommandType.Text;
            Command.Connection = Connect;
            Command.Parameters.Clear();
            Command.Parameters.Add(new SqlParameter("@img", image_byte));

            Command.ExecuteNonQuery();

            Command.Dispose();

            Connect.Close();
        }


        internal object Search_Value_From_Database(string search_query)
        {
            object DataSource;
            Connect.Open();

            Command.CommandText = search_query;

            Command.CommandType = CommandType.Text;
            Command.Connection = Connect;

            Command.ExecuteNonQuery();
            Data_adapter = new SqlDataAdapter(Command);

            DataTable storage = new DataTable();
            Data_adapter.Fill(storage);
            DataSource = storage;
            Command.Dispose();

            Connect.Close();
            return DataSource;
        }

        internal object GetColumnValue(string query)
        {
            Connect.Open();
            Command.CommandText = query;
            Command.Connection = Connect;
            var result = Command.ExecuteScalar();
            Command.Dispose();
            Connect.Close();
            return result;
        }
    }
}
