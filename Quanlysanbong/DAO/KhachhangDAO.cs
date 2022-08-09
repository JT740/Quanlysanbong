using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quanlysanbong.DTO;

namespace Quanlysanbong.DAO
{
    public class KhachhangDAO
    {
        private static KhachhangDAO instance;
        public static KhachhangDAO Instances
        {
            get { if (instance == null) instance = new KhachhangDAO(); return instance; }
            private set { instance = value; }
        }

        private KhachhangDAO() { }

        public Khachhang LoadSanbong(string tenkh)
        {
            Khachhang kh = new Khachhang();
            //DataProvider provider = new DataProvider();
            DataTable data = DataProvider.Instance.ExecuteQuery("select *  from KhachHang where tenkhachhang = N'" + tenkh + "'");
            foreach (DataRow iteam in data.Rows)
            {
                kh = new Khachhang(iteam);

            }
            return kh;

        }
    }
}
