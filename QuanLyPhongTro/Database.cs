using Microsoft.Data.SqlClient;

namespace QuanLyPhongTro
{
    public class Database
    {
        private static readonly string connectionString =
            @"Server=DESKTOP-12K56S9\SQLEXPRESS;Database=QuanLyPhongTro;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}