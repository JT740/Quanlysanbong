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

namespace Quanlysanbong
{
    public partial class FormDoiPass : Form
    {
        public FormDoiPass()
        {
            InitializeComponent();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string username = txtTaikhoan.Text;
            string pass = txtMatKhau.Text;
            string newpass = txtMatKhauMoi.Text;
            string newpassapply = txtXacNhanMK.Text;
            if (txtTaikhoan.Text == "" || txtMatKhau.Text == "" || txtMatKhauMoi.Text == "" || txtXacNhanMK.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập đủ thông tin");
            }
            if (check(username, pass))
            {
                if (check1(username, pass, newpass)/*&& newpass == newpassapply*/)
                {
                    MessageBox.Show("ok");
                }
                //string query = "exec [dbo].[SP_Update_Pass] N'" + txtTaikhoan.Text + "',N'" + txtMatKhau.Text + "' ,N'" + txtMatKhauMoi.Text + "'";

                ////DataTable result = DataProvider.Instance.ExecuteQuery(query);

            }

            else if (newpass != newpassapply)
            {
                MessageBox.Show("Mật khẩu xác nhận phải giống mật khẩu mới");

            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không chính xác");
            }


        }
        bool check(string username, string pass)//ktra có tài khoản không
        {
            string query = "select * from Acount where username = N'" + username + "' and pass = N'" + pass + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            if (result.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }



        bool check1(string username,string pass,string newpass)
        {
            string query = "exec [dbo].[SP_Update_Pass] N'" + txtTaikhoan.Text + "',N'" + txtMatKhau.Text + "' ,N'" + txtMatKhauMoi.Text + "'";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            if (result.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Form f = new Form2();
                f.Show();
                this.Hide();

            }
        }

        private void chkHienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThi.Checked)
            {
                txtMatKhau.PasswordChar = (char)0;
                txtMatKhauMoi.PasswordChar = (char)0;
                txtXacNhanMK.PasswordChar = (char)0;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
                txtMatKhauMoi.PasswordChar = '*';
                txtXacNhanMK.PasswordChar = '*';
            }
        }
    }
}
