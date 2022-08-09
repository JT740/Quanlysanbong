using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysanbong.DTO
{
    public class Khachhang
    {
        private int makhachhang;
        private string tenkhachhang;
        private string sdt;
        private string cccd;

        public int Makhachhang { get => makhachhang; set => makhachhang = value; }

        public string Tenkhachhang { get => tenkhachhang; set => tenkhachhang = value; }

        public string Sdt { get => sdt; set => sdt = value; }

        public string Cccd { get => cccd; set => cccd = value; }

        public Khachhang(int makhachhang, string tenkhachhang, string sdt, string cccd)
        {
            Makhachhang = makhachhang;
            Tenkhachhang = tenkhachhang;
            Sdt = sdt;
            Cccd = cccd;
        }

        public Khachhang(System.Data.DataRow row)
        {
            this.makhachhang = (int)row["makhachhang"];
            this.tenkhachhang = row["tenkhachhang"].ToString();
            this.sdt = row["sdt"].ToString();
            this.cccd = row["cccd"].ToString();
        }
        public Khachhang()
        {

        }
        public Khachhang(Khachhang obj)
        {
            this.makhachhang = obj.makhachhang;
            this.tenkhachhang = obj.tenkhachhang;
            this.sdt = obj.sdt;
            this.cccd = obj.cccd;
        }
    }
}
