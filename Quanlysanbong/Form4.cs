using Quanlysanbong.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlysanbong
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            LoadDSSan();
            
        }

        void LoadDSSan()
        {
            dgvsan.DataSource = SanbongDAO.Instance.LoadDSSan();
            
  
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        

        private void dgvsan_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

           
        }
        bool checktensan(string tensan)
        {
            string query = "select *from San where tensan = N'" + tensan + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count>0)
            {
                return true;
            }
            return false;

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string tensan = txtten.Text;
            string trangthai = comboBox1.Text;
            int maloai = Convert.ToInt32(comboBox2.Text);


            //kiem tra ten san

            if (!checktensan(txtten.Text))
            {
                if (SanbongDAO.Instance.InsertSan(tensan, trangthai, maloai))
                {
                    MessageBox.Show("Thêm sân thành công");
                    LoadDSSan();
                    Refesh();
                }
                else
                {
                    MessageBox.Show("Lỗi ");
                }
            }
            else
                MessageBox.Show("trung ten san");
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string tensan = txtten.Text;
            string trangthai = comboBox1.Text;
            int maloai = Convert.ToInt32(comboBox2.Text);
            int masan = Convert.ToInt32(txtma.Text);


            if (!checktensan(txtten.Text))
            {
                if (SanbongDAO.Instance.EditSan(tensan, trangthai, maloai, masan))
                {
                    MessageBox.Show("Sửa sân thành công");
                    LoadDSSan();
                    Refesh();
                }
                else
                {
                    MessageBox.Show("Lỗi ");
                }
            }
            else
            {
                MessageBox.Show("Lỗi ten san ");
            }
        }

        private void dgvsan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtma.Text = dgvsan.CurrentRow.Cells[2].Value.ToString();
            txtten.Text = dgvsan.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = dgvsan.CurrentRow.Cells[0].Value.ToString();
            comboBox2.Text = dgvsan.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int masan = Convert.ToInt32(txtma.Text);


            if (SanbongDAO.Instance.XoaSan(masan))
            {
                MessageBox.Show("Xoa sân thành công");
                LoadDSSan();
                Refesh();
            }
            else
            {
                MessageBox.Show("Lỗi ");
            }
            
        }

        void Refesh()
        {
            comboBox2.Text = "";
            txtma.Text = "";
            comboBox1.Text = "";
            txtten.Text = "";

        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {

        }

        private void btnsua_Click_2(object sender, EventArgs e)
        {
            string trangthai = comboBox1.Text;
            string tensan = txtten.Text;
            int masan = Convert.ToInt32(txtma.Text);
            int maloai = Convert.ToInt32(comboBox2.Text);
        


            if (SanbongDAO.Instance.EditSan(tensan, trangthai, maloai, masan))
            {
                MessageBox.Show("Sửa sân thành công");
                LoadDSSan();
                Refesh();
            }
            else
            {
                MessageBox.Show("Lỗi ");
            }
        }
    }
}
