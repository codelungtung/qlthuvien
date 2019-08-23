using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary;
using System.Data.SqlClient;

namespace QuanLiNhaSach
{
    public partial class FrmDanhMucSach : Form
    {
        public FrmDanhMucSach()
        {
            InitializeComponent();
        }

        KetNoi conn = new KetNoi();
        DataTable tbl_Sach;

        public void loadComBoBoxTenTacGia()
        {
            string strsql = "SELECT * FROM TACGIA";
            loadComBoBox(strsql, cbo_TenTacGia, "TENTG", "MATACGIA");
            cbo_TenTacGia.SelectedIndex = 0;
        }

        public void loadComBoBoxTenNXB()
        {
            string strsql = "SELECT * FROM NHAXB";
            loadComBoBox(strsql, cbo_TenNhaXB, "TENNXB", "MANXB");
            cbo_TenNhaXB.SelectedIndex = 0;
        }

        public void loadComBoBoxLoaiSach()
        {
            string strsql = "SELECT * FROM LOAISACH";
            loadComBoBox(strsql, cbo_LoaiSach, "TENLOAI", "MALOAISACH");
            cbo_LoaiSach.SelectedIndex = 0;
        }

        private void FrmDanhMucSach_Load(object sender, EventArgs e)
        {
            txt_MaSach.Enabled = false;
            btn_Luu.Enabled = false;
            btn_Huy.Enabled = false;
            txt_TenSach.Enabled = false;
            txt_SoLuong.Enabled = false;
            txt_GiaBia.Enabled = false;
            txt_GiaBan.Enabled = false;

            LoadDataGridViewSach();
            loadComBoBoxLoaiSach();
            loadComBoBoxTenNXB();
            loadComBoBoxTenTacGia();
        }

        public void loadComBoBox(string strsql, ComboBox cbo, string ten, string ma)
        {
            SqlDataAdapter da = new SqlDataAdapter(strsql, conn.Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbo.DataSource = dt;
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;
        }

        public void LoadDataGridViewSach()
        {
            string strsql;
            strsql = "SELECT * FROM SACH";
            tbl_Sach = conn.DataTable(strsql);
            dataGridViewSach.DataSource = tbl_Sach;
        }

        private void xoaGiaTriTextBox()
        {
            txt_GiaBan.Text = "";
            txt_GiaBia.Text = "";
            txt_MaSach.Text = "";
            txt_SoLuong.Text = "";
            txt_TenSach.Text = "";
        }

        private void dataGridViewSach_Click(object sender, EventArgs e)
        {

            if (btn_Them.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MaSach.Focus();
                return;
            }

            if (tbl_Sach.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Bấm vào datagridview dữ liệu hiện lên lại các txt tương ứng
            int index = dataGridViewSach.CurrentRow.Index;
            txt_MaSach.Text = dataGridViewSach.CurrentRow.Cells[0].Value.ToString();
            txt_TenSach.Text = dataGridViewSach.CurrentRow.Cells[1].Value.ToString();
            cbo_TenTacGia.SelectedValue = dataGridViewSach.CurrentRow.Cells[2].Value.ToString();
            txt_GiaBia.Text = dataGridViewSach.CurrentRow.Cells[3].Value.ToString();
            txt_GiaBan.Text = dataGridViewSach.CurrentRow.Cells[4].Value.ToString();
            cbo_LoaiSach.SelectedValue = dataGridViewSach.CurrentRow.Cells[5].Value.ToString();
            cbo_TenNhaXB.SelectedValue = dataGridViewSach.CurrentRow.Cells[6].Value.ToString();
            txt_SoLuong.Text = dataGridViewSach.CurrentRow.Cells[7].Value.ToString();

            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            txt_TenSach.Enabled = true;
            txt_SoLuong.Enabled = true;
            txt_GiaBia.Enabled = true;
            txt_GiaBan.Enabled = true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Huy.Enabled = true;
            btn_Luu.Enabled = true;
            btn_Them.Enabled = false;
            txt_TenSach.Enabled = true;
            txt_SoLuong.Enabled = true;
            txt_GiaBia.Enabled = true;
            txt_GiaBan.Enabled = true;
            xoaGiaTriTextBox();

            //Tạo mã sách tự động
            string strsql = "Select count(*) from SACH";
            int stt = conn.getCount(strsql) + 1;
            string masach= "";
            if (stt < 10)
                masach = "SACH00" + stt.ToString();
            else
                masach = "SACH0" + stt.ToString();
            strsql = "Select count(*) from  SACH where MASACH = '" + masach + "'";
            while (conn.checkForExistence(strsql))
            {
                stt++;
                if (stt < 10)
                    masach= "SACH00" + stt.ToString();
                else
                    masach = "SACH0" + stt.ToString();
                strsql = "Select count(*) from SACH where masach = '" + masach+ "'";
            }
            txt_MaSach.Text = masach;
            txt_TenSach.Focus();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {

            string strsql;
            if (txt_MaSach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MaSach.Focus();
                return;
            }
            if (txt_TenSach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenSach.Focus();
                return;
            }
            if (txt_SoLuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_SoLuong.Focus();
                return;
            }
            if (txt_GiaBia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá bìa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_GiaBia.Focus();
                return;
            }
            if (txt_GiaBan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_GiaBan.Focus();
                return;
            }

            try
            {
                strsql = "INSERT INTO SACH VALUES ('" + txt_MaSach.Text.Trim()
                    + "',N'" + txt_TenSach.Text + "','" + cbo_TenTacGia.SelectedValue.ToString() + "'," + txt_GiaBia.Text + "," + txt_GiaBan.Text
                    + ",'" + cbo_LoaiSach.SelectedValue.ToString() + "','" + cbo_TenNhaXB.SelectedValue.ToString() + "','" + txt_SoLuong.Text + "')";

                conn.Update(strsql);

                //conn.openConnection();
                LoadDataGridViewSach();

                xoaGiaTriTextBox();
                btn_Xoa.Enabled = true;
                btn_Them.Enabled = true;
                btn_Sua.Enabled = true;
                btn_Huy.Enabled = false;
                btn_Luu.Enabled = false;
                txt_MaSach.Enabled = false;
                txt_TenSach.Enabled = false;
                txt_SoLuong.Enabled = false;
                txt_GiaBia.Enabled = false;
                txt_GiaBan.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Thê !!");
            }
        }

        //Xử lý btn Sửa
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string strsql;
            if (txt_MaSach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MaSach.Focus();
                return;
            }
            if (txt_TenSach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenSach.Focus();
                return;
            }
            if (txt_SoLuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_SoLuong.Focus();
                return;
            }
            if (txt_GiaBia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá bìa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_GiaBia.Focus();
                return;
            }
            if (txt_GiaBan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_GiaBan.Focus();
                return;
            }

            try
            {
                strsql = "UPDATE SACH SET TENSACH = N'" + txt_TenSach.Text +
                        "',MATG = '" + cbo_TenTacGia.SelectedValue.ToString() +
                        "',GIABIA='" + txt_GiaBia.Text + "',GIABAN = '" + txt_GiaBan.Text +
                        "',MALOAI = '" + cbo_LoaiSach.SelectedValue.ToString() +
                        "',MANXB = '" + cbo_TenNhaXB.SelectedValue.ToString() +
                        "',SOLUONGNHAP= '" + txt_SoLuong.Text +
                        "' WHERE MASACH='" + txt_MaSach.Text + "'";

                conn.Update(strsql);
                MessageBox.Show("Sửa thành công !!");
                LoadDataGridViewSach();
                btn_Huy.Enabled = false;
                txt_TenSach.Enabled = false;
                txt_SoLuong.Enabled = false;
                txt_GiaBia.Enabled = false;
                txt_GiaBan.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Sửa thành công !!");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string strsql;
            if (tbl_Sach.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_MaSach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn cuốn sách nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    strsql = "DELETE SACH WHERE MASACH='" + txt_MaSach.Text + "'";
                    conn.Update(strsql);
                    MessageBox.Show("Xóa thành công !!");
                    LoadDataGridViewSach();
                    xoaGiaTriTextBox();
                }
                txt_TenSach.Enabled = false;
                txt_SoLuong.Enabled = false;
                txt_GiaBia.Enabled = false;
                txt_GiaBan.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Xóa thất bại !!");
            }
        }

        //Xử lý btn Hủy
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            xoaGiaTriTextBox();
            btn_Huy.Enabled = false;
            btn_Them.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Luu.Enabled = false;

            txt_MaSach.Enabled = false;
            txt_TenSach.Enabled = false;
            txt_SoLuong.Enabled = false;
            txt_GiaBia.Enabled = false;
            txt_GiaBan.Enabled = false;
        }

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_GiaBia_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_GiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}