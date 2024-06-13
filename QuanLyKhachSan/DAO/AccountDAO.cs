using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyKhachSan.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance1 {
            get => instance == null ? instance = new AccountDAO() : instance;
            private set => instance = value;}

        private AccountDAO() { }

        public bool Login(string username, string password)
        {
            string query = @"SELECT * FROM dbo.MatKhau WHERE username like N'"+username+"' AND password like N'"+password+"'";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        public bool UpdatePassword(string username, string newPassword, string query)
        {
            

            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, new object[] { newPassword, username });

            return rowsAffected > 0;
        }
    }
}
