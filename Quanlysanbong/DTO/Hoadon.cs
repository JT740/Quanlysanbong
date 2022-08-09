using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysanbong.DTO
{
    public class Hoadon
    {
        private int mahoadon;
        private string ngaylap;
        private string giobatdau;
        private string gioketthuc;
        private int makhachang;
        private int tongtien;

        public int Mahoadon { get => mahoadon; set => mahoadon = value; }
        public string NgayLap { get => ngaylap; set => ngaylap = value; }
        public string Giobatdau { get => giobatdau; set => giobatdau = value; }
        public string Gioketthuc { get => gioketthuc; set => gioketthuc = value; }
        public int Makhachhang { get => makhachang; set => makhachang = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }


        public Hoadon(int mahoadon, string ngaylap, string giobatdau, string gioketthuc, int makhachang, int tongtien)
        {
            Mahoadon = mahoadon;
            NgayLap = ngaylap;
            Giobatdau = giobatdau;
            Gioketthuc = gioketthuc;
            Makhachhang = makhachang;
            Tongtien = tongtien;
        }

        public Hoadon(System.Data.DataRow row)
        {
            this.mahoadon = (int)row["mahoadon"];
            this.ngaylap = row["ngaylap"].ToString();
            this.giobatdau = row["giobatdau"].ToString();
            this.gioketthuc = row["gioketthuc"].ToString();
            this.makhachang = (int)row["makhachhang"];
            this.tongtien = (int)row["tongtien"];
        }
        public Hoadon()
        {

        }
    }
}
