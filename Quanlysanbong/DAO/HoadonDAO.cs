using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
