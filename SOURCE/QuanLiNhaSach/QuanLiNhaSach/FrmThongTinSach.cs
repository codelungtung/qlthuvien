using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MyLibrary;

namespace QuanLiNhaSach
{
    public partial class FrmThongTinSach : Form
    {
        KetNoi conn = new KetNoi();
        DataTable tbl_Sach;

        public FrmThongTinSach()
        {
            InitializeComponent();
        }

        public void loadComBoBoxTenTacGia()
        {
            string strsql = "SELECT * FROM TACGIA";
            loadComBoBox(strsql, cbo_TenTacGia, "TENTG", "MATACGIA");
        }

        public void loadComBoBoxTenNXB()
        {
            string strsql = "SELECT * FROM NHAXB";
            loadComBoBox(strsql, cbo_TenNhaXB, "TENNXB", "MANXB");
        }

        public void loadComBoBoxLoaiSach()
        {
            string strsql = "SELECT * FROM LOAISACH";
            loadComBoBox(strsql, cbo_LoaiSach, "TENLOAI", "MALOAISACH");
        }

        private void FrmThongTinSach_Load(object sender, EventArgs e)
        {
            loadComBoBoxLoaiSach();
            loadComBoBoxTenNXB();
            loadComBoBoxTenTacGia();
            LoadDataGridView();
            btnChon.Enabled = false;
        }

        public void loadComBoBox(string strsql, ComboBox cbo, string ten, string ma)
        {
            //conn.openConnection();
            SqlDataAdapter da = new SqlDataAdapter(strsql, conn.Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbo.DataSource = dt;
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;
        }

        public void LoadDataGridView()
        {
            string strsql;
            strsql = "SELECT * FROM SACH";
            tbl_Sach = conn.DataTable(strsql);
            dataGridViewSach.DataSource = tbl_Sach;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtTenSach.Clear();
            cbo_TenTacGia.Text = "";
            cbo_TenNhaXB.Text = "";
            cbo_LoaiSach.Text = "";
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            btnChon.Enabled = true;
        }

        public string layMaSach()
        {
            //int index = dataGridViewSach.CurrentRow.Index;
            return dataGridViewSach.CurrentRow.Cells[0].Value.ToString();
        }

        public string layTenSach()
        {
            //int index = dataGridViewSach.CurrentRow.Index;
            return dataGridViewSach.CurrentRow.Cells[1].Value.ToString();
        }

        public string layGiaSach()
        {
            //int index = dataGridViewSach.CurrentRow.Index;
            return dataGridViewSach.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimSach_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
            if (txtTenSach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập tên sách cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string strsql = "SELECT * FROM SACH WHERE TENSACH LIKE N'%" + txtTenSach.Text + "%' ";
            tbl_Sach = conn.DataTable(strsql);
            if (tbl_Sach.Rows.Count == 0)
            {
                MessageBox.Show("Không có sách thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();
            }

            dataGridViewSach.DataSource = tbl_Sach;
            txtTenSach.Clear();
            cbo_TenTacGia.Text = "";
            cbo_TenNhaXB.Text = "";
            cbo_LoaiSach.Text = "";
        }

        private void cbo_TenTacGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tacgia = cbo_TenTacGia.SelectedValue.ToString();
            string strsql;
            strsql = "SELECT * FROM SACH WHERE MATG = '" + tacgia + "'";
            tbl_Sach = conn.DataTable(strsql);
            dataGridViewSach.DataSource = tbl_Sach;
        }

        private void cbo_LoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string loaisach = cbo_LoaiSach.SelectedValue.ToString();
            string strsql;
            strsql = "SELECT * FROM SACH WHERE MALOAI = '" + loaisach + "'";
            tbl_Sach = conn.DataTable(strsql);
            dataGridViewSach.DataSource = tbl_Sach;
        }

        private void cbo_TenNhaXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string NXB = cbo_TenNhaXB.SelectedValue.ToString();
            string strsql;
            strsql = "SELECT * FROM SACH WHERE MANXB = '" + NXB + "'";
            tbl_Sach = conn.DataTable(strsql);
            dataGridViewSach.DataSource = tbl_Sach;
        }

    }
}
