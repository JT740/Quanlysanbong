using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysanbong.DTO
{
    internal class Loaisan
    {
        private int maloai;
        private string tenloai;
        private int giatien;


        public int Maloai { get => maloai; set => maloai = value; }
        public string Tenloai { get => tenloai; set => tenloai = value; }
        public int Giatien { get => giatien; set => giatien = value; }

        public Loaisan(int maloai, int tenlaoi, int giatien)
        {
            this.maloai = maloai;
            this.giatien = giatien;
            this.tenloai = tenloai;
        }

        public Loaisan(System.Data.DataRow row)
        {
            this.maloai = (int)row["maloai"];
            this.tenloai = row["tenloai"].ToString();
            this.giatien = (int)row["giatien"];
        }

        public Loaisan() { }

        public Loaisan(Loaisan obj)
        {
            this.maloai = obj.maloai;
            this.tenloai = obj.tenloai;
            this.giatien = obj.giatien;
        }
    }
}
