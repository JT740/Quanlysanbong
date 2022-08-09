using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysanbong.DTO
{
    public class Sanbong
    {
        private int masan;
        private string tensan;
        private string trangthai;
        private int maloai;
        

        public string Trangthai { get => trangthai; set => trangthai = value; }
        public string Tensan { get => tensan; set => tensan = value; }
        public int Masan { get => masan; set => masan = value; }
        public int Maloai { get => maloai; set => maloai = value; }
        


        public Sanbong(int masan, string tensan, string trangthai, int maloai )
        {
            this.masan = masan;
            this.tensan = tensan;
            this.trangthai = trangthai;
            this.maloai = maloai;
            
        }
        public Sanbong(DataRow row)
        {

            this.Masan = (int)row["masan"];
            this.Tensan = row["tensan"].ToString();
            this.Trangthai = row["trangthai"].ToString();
            this.maloai = (int)row["maloai"];
        }

        public Sanbong(Sanbong obj)
        {
            this.masan = obj.masan;
            this.tensan = obj.tensan;
            this.trangthai = obj.trangthai;
            this.maloai = obj.maloai;
            
        }


        public Sanbong() { }
    }
}
