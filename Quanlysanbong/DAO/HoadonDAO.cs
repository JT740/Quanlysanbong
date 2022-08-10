using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlysanbong.DTO;

namespace Quanlysanbong.DAO
{
    public class HoadonDAO
    {
        private static HoadonDAO instance;

        public static HoadonDAO Instance
        {
            get { if (instance == null) instance = new HoadonDAO(); return HoadonDAO.instance; }
            private set { HoadonDAO.instance = value; }
        }
        private HoadonDAO() { }

        public void Insert_hoadon(string datetime, int mapds, float giobatdat, float gioketthuc, int makh, float tongtien)
        {
            Hoadon hd = new Hoadon();
           
            string query = "insert into HoaDon values(" + mapds + ",'" + datetime + "'," + giobatdat + "," + gioketthuc + "," + makh + "," + tongtien + ",0)";
            int data = DataProvider.Instance.Executenonquery(query);
        }
    }
}
