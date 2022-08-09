using Quanlysanbong.DAO;

namespace Quanlysanbong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string tenTaiKhoan = txtuser.Text;
            string matKhau = txtpass.Text;
            if (Login(tenTaiKhoan, matKhau))
            {
                Form2 f = new Form2();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
        }
        bool Login(string tenTaiKhoan, string matKhau)
        {

            return TaikhoanDAO.Instances.Login(tenTaiKhoan, matKhau);
        }
        //private void FormDangNhap_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        btnlogin_Click(sender, e);
        //    }
        //}

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnlogin_Click(sender, e);
            }
        }

        private void chkCheckhienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheckhienthi.Checked)
            {
                txtpass.PasswordChar = (char)0;
            }
            else
            {
                txtpass.PasswordChar = '*';
            }
        }
    }
}