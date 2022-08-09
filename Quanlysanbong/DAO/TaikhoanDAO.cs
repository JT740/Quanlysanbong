using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quanlysanbong.DTO;

namespace Quanlysanbong.DAO
{
    public class TaikhoanDAO
    {
        private static TaikhoanDAO instance;

        public static TaikhoanDAO Instances
        {
            get { if (instance == null) instance = new TaikhoanDAO(); return instance; }
            private set { instance = value; }
        }

        private TaikhoanDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query = "select * from Acount where username	=N'" + userName + "' and pass = N'" + passWord + "'";
            
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            if (result.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
