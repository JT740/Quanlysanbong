using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysanbong.DTO
{
    public class Phieudat
    {
        public int Masan { get => masan; set => masan = value; }
        public int Makhachhang { get => makhachhang; set => makhachhang = value; }
        public float Tiencoc { get => tiencoc; set => tiencoc = value; }
        public float Giodat { get => giodat; set => giodat = value; }
        public float Giotra { get => giotra; set => giotra = value; }
        public int Maphieudat { get => maphieudat; set => maphieudat = value; }
        public string Ngaydat { get => ngaydat; set => ngaydat = value; }

        private int masan;

        private int makhachhang;

        private int maphieudat;

        private float tiencoc;

        private float giodat;

        private float giotra;

        private string ngaydat;
        public Phieudat(int masan, int makhachhang, int maphieudat, float tiencoc, float giodat, float giotra, string ngaydat)
        {
            this.makhachhang = makhachhang;
            this.masan = masan;
            this.maphieudat = maphieudat;
            this.tiencoc = tiencoc;
            this.giodat = giodat;
            this.Giotra = giotra;
            this.Ngaydat = ngaydat;
        }
        public Phieudat(System.Data.DataRow row)
        {
            this.maphieudat = (int)row["maphieudat"];
            this.makhachhang = (int)row["makhachhang"];
            this.masan = (int)row["masan"];
            this.tiencoc = (float)row["tiencoc"];
            this.Ngaydat = row["ngaydat"].ToString();
            this.giodat = (float)row["giodat"];
            this.giotra = (float)row["giotra"];
        }
        public Phieudat()
        {
        }
    }
}
