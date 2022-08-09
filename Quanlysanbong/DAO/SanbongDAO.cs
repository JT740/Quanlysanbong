using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quanlysanbong.DTO;


namespace Quanlysanbong.DAO
{
    public class SanbongDAO
    {
        private static SanbongDAO instance;
        public static SanbongDAO Instance
        {
            get { if (instance == null) instance = new SanbongDAO(); return SanbongDAO.instance; }
            private set { SanbongDAO.instance = value; }
        }
        public int Weigh = 80;
        public int Heigh = 80;

        private SanbongDAO() { }
        public List<Sanbong> LoadDSSan()
        {
            List<Sanbong> sbList = new List<Sanbong>();
            //DataProvider provider = new DataProvider();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from San");
            foreach (DataRow iteam in data.Rows)
            {
                Sanbong sb = new Sanbong(iteam);
                sbList.Add(sb);
                
            }
            return sbList;

        }
        public Sanbong LoadSanbong(string tensan)
        {
            Sanbong sb = new Sanbong();
            //DataProvider provider = new DataProvider();
            DataTable data =DataProvider.Instance.ExecuteQuery("select * from San where tensan = N'" + tensan + "'");
            foreach (DataRow iteam in data.Rows)
            {
                sb = new Sanbong(iteam);

            }
            return sb;

        }

        public bool InsertSan( string tensan, string trangthai, int maloai)
        {
            string query = string.Format("insert San (tensan,trangthai,maloai) values (N'{0}', '{1}', '{2}')",  tensan, trangthai, maloai);
            //int kq = DataProvider.Instance.Executenonquery(query);
            int kq = DataProvider.Instance.Executenonquery(query);
            return kq > 0;
        }

        public bool EditSan( string tensan, string trangthai, int maloai, int masan)
        {
            string query = string.Format("UPDATE San SET tensan =  N'{0}', trangthai = 0 , maloai = {2}  where masan = '{3}'", tensan,trangthai,maloai,masan); 
            
            int kq = DataProvider.Instance.Executenonquery(query); 
            
            return kq > 0; 
            
        }

        public bool XoaSan(int masan)
        {
            string query = string.Format("Delete San  where masan = {0}",  masan);

            int kq = DataProvider.Instance.Executenonquery(query);
            return kq > 0;
        }

    }
}
