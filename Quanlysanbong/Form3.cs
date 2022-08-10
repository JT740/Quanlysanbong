using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlysanbong.DAO;
using Quanlysanbong.DTO;

namespace Quanlysanbong
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            LoadflpTaisan();
     
            
        }


        struct bDatSan
        {
            public Khachhang kh;
            public Phieudat pdat;
            public Hoadon hdon;

        }
        bDatSan bds = new bDatSan();
        private void LoadflpTaisan()
        {
            List<Sanbong> sbl = SanbongDAO.Instance.LoadDSSan();
            foreach (Sanbong item in sbl)
            {
                Button btn = new Button() { Width = SanbongDAO.Instance.Weigh, Height = SanbongDAO.Instance.Heigh };
                btn.Text = item.Tensan;
                btn.Click += Btn_Click;
                if (item.Trangthai.ToString() == "False")
                {
                    btn.BackColor = Color.Green;
                }
                else
                {
                    btn.BackColor = Color.Red;
                }
                flpTaiSandat.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btnSan = (Button)sender;
            Sanbong sb = new Sanbong(SanbongDAO.Instance.LoadSanbong(btnSan.Text));
            txtTensan.Text = sb.Tensan;
            txtLoaisan.Text = sb.Maloai.ToString();
            LoadSan(btnSan.Text);


            //enable
            txtCccd.Enabled = true;
            txtTenkhachhang.Enabled = true;
            txtTiencoc.Enabled = true;
            txtGiodat.Enabled = true;
            txtPhutdat.Enabled = true;
            txtSogiothue.Enabled = true;
            txtSdt.Enabled = true;


        }
        void LoadSan(string tensan)
        {

            string query = "exec USP_getCTHD N'" + txtTensan.Text + "'";
            dtgThongtinphieudat.DataSource = DataProvider.Instance.ExecuteQuery(query);


        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DateTime time = new DateTime();
            bds.kh = new Khachhang();
            bds.pdat = new Phieudat();
            bds.hdon = new Hoadon();

            if (txtCccd.TextLength > 0 && txtGiodat.TextLength > 0 && txtPhutdat.TextLength > 0 && txtSdt.TextLength > 0 && txtTenkhachhang.TextLength
               > 0 && txtSogiothue.TextLength > 0)
            {
                Sanbong sb = new Sanbong(SanbongDAO.Instance.LoadSanbong(txtTensan.Text));
                bds.pdat.Tiencoc = Int32.Parse(txtTiencoc.Text);

                bds.pdat.Giodat = Int32.Parse(txtGiodat.Text) + Int32.Parse(txtPhutdat.Text) / 60;
                bds.pdat.Giotra = bds.pdat.Giodat + Int32.Parse(txtSogiothue.Text);
                time = new DateTime(dtpNgaydat.Value.Year, dtpNgaydat.Value.Month, dtpNgaydat.Value.Day);

                bds.pdat.Ngaydat = time.ToString();
                bds.kh.Sdt = txtSdt.Text;
                bds.kh.Tenkhachhang = txtTenkhachhang.Text;
                bds.kh.Cccd = txtCccd.Text;
                string query = "exec  USP_insertKhachHang N'" + bds.kh.Tenkhachhang + "', N'" + bds.kh.Sdt + "', N'" + bds.kh.Cccd + "' ";

                int data = DataProvider.Instance.Executenonquery(query);
                bds.kh = new Khachhang(KhachhangDAO.Instances.LoadSanbong(txtTenkhachhang.Text));


                bds.pdat.Makhachhang = bds.kh.Makhachhang;
                bds.pdat.Masan = Int32.Parse(sb.Masan.ToString());
            }
            else
            {
                MessageBox.Show("Thong tin khong hop le");
            }

            //them khach hang

            string query2 = "insert into Phieudatsan values(" + bds.kh.Makhachhang + "," + bds.pdat.Masan + "," + bds.pdat.Tiencoc + ",'" + bds.pdat.Ngaydat + "',4," + bds.pdat.Giotra + ",0)";
            int data2 = DataProvider.Instance.Executenoquery(query2);
            MessageBox.Show("da lm");
            flpTaiSandat.Controls.Clear();
            LoadflpTaisan();

            //them phieu dat

            // insertPDS();
        }
    }
}
