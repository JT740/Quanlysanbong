using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlysanbong.DTO;
using Quanlysanbong.DAO;

namespace Quanlysanbong
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            loadHoadon();
        }
        void loadHoadon()
        {
            string query = "exec USP_getHOADON";
            dgvhoadon.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }

        private void dgvhoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int i;
            i = dgvhoadon.CurrentCell.RowIndex;
            txttenkh.Text = dgvhoadon.Rows[i].Cells[0].Value.ToString();
            txttensan.Text = dgvhoadon.Rows[i].Cells[1].Value.ToString();
            txtbatdau.Text = dgvhoadon.Rows[i].Cells[3].Value.ToString();
            txtketthuc.Text = dgvhoadon.Rows[i].Cells[4].Value.ToString();
            txttien.Text = dgvhoadon.Rows[i].Cells[7].Value.ToString();
            txtNgaydat.Text = dgvhoadon.Rows[i].Cells[2].Value.ToString();

        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            string queryUdhd = "exec USP_thanhtoan N'" + txttensan.Text + "' , '" + txtNgaydat.Text + "',"+txtbatdau.Text+","+txtketthuc.Text+"";

            int data = DataProvider.Instance.Executenonquery(queryUdhd);

            txttenkh.Clear();
            txttensan.Clear();
            txtbatdau.Clear();
            txtketthuc.Clear();
            txttien.Clear();
            MessageBox.Show("thanh toan thanh cong");
            loadHoadon();
        }
    }
}
