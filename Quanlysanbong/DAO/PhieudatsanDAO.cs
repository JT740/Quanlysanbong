using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quanlysanbong.DTO;
using System.Threading.Tasks;
using Quanlysanbong.DAO;
using System.Data;

namespace Quanlysanbong.DAO
{
    internal class PhieudatsanDAO
    {
        private static PhieudatsanDAO instance;
        public static PhieudatsanDAO Instance
        {
            get { if (instance == null) instance = new PhieudatsanDAO(); return PhieudatsanDAO.instance; }
            private set { PhieudatsanDAO.instance = value; }
        }

        public Phieudat Loadlastestpds()
        {
            Phieudat pd = new Phieudat();
           
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Phieudatsan where mapds = (select max(mapds) from Phieudatsan)");
            foreach (DataRow iteam in data.Rows)
            {
                pd = new Phieudat(iteam);
            }
            return pd;
        }
    }
}
