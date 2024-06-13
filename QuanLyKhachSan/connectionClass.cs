using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace QuanLyKhachSan
{
    internal class connectionClass
    {
        private static string connectionString = @"Data Source=DESKTOP-TL18LO4\SQLEXPRESS
                                                ;Initial Catalog=PMQLKS;User ID=sa; Password=123321;";
    
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
