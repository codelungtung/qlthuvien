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
    public partial class FrmDanhMucNhanVien : Form
    {
        public FrmDanhMucNhanVien()
        {
            InitializeComponent();
        }

        KetNoi conn = new KetNoi();
        DateTime now = DateTime.Now;
        DataTable tbl_NhanVien;

        string[] chucvu = { "Nhân viên", "Quản lý" };

        string[] quequan = { "An Giang", "Bà Rịa–Vũng Tàu", "Bạc Liêu", "Bắc Kạn", "Bắc Giang", "Bắc Ninh", "Bến Tre", "Bình Dương", "Bình Định", "Bình Phước", "Bình Thuận", 
                       "Cà Mau", "Cao Bằng", "Cần Thơ",	"Đà Nẵng", "Đắk Lắk", "Đắk Nông", "Điện Biên", "Đồng Nai", "Đồng Tháp", "Gia Lai", "Hà Giang", "Hà Nam", "Hà Nội", 
                       "Hà Tĩnh", "Hải Dương", "Hải Phòng", "Hòa Bình", "TP Hồ Chí Minh", "Hậu Giang", "Hưng Yên", "Khánh Hòa", "Kiên Giang", "Kon Tum", "Lai Châu", "Lào Cai", 
                       "Lạng Sơn", "Lâm Đồng", "Long An", "Nam Định", "Nghệ An", "Ninh Bình", "Ninh Thuận", "Phú Thọ", "Phú Yên", "Quảng Bình", "Quảng Nam",	"Quảng Ngãi", 
                       "Quảng Ninh", "Quảng Trị"," Sóc Trăng", "Sơn La", "Tây Ninh", "Thái Bình", "Thái Nguyên", "Thanh Hóa", "Thừa Thiên – Huế", "Tiền Giang", "Trà Vinh", 
                       "Tuyên Quang", "Vĩnh Long", "Vĩnh Phúc", "Yên Bái"};

        public void LoadDGV_NhanVien()
        {
            string strsql = "Select * from NHANVIEN";
            tbl_NhanVien = conn.DataTable(strsql);
            dgvNhanVien.DataSource = tbl_NhanVien;
        }

        private void FrmDanhMucNhanVien_Load(object sender, EventArgs e)
        {
            LoadDGV_NhanVien();
            foreach (string s in quequan)
                cbo_QueQuan.Items.Add(s);
            cbo_QueQuan.SelectedIndex = 28; //chọn mặc định là TP. Hồ Chí Minh
            foreach (string s in chucvu)
                cbo_ChucVu.Items.Add(s);
            cbo_ChucVu.SelectedIndex = 0; //chọn mặc định là Nhân viên
            
            rdo_Nam.Checked = true;

            btn_Luu.Enabled = false;
            btn_Huy.Enabled = false;

            txt_MaNhanVien.Enabled = false;
            txt_TenNhanVien.Enabled = false;
            txt_SDT.Enabled = false;
            txt_DiaChi.Enabled = false;
        }

        private void xoaGiaTriTextBox()
        {
            cbo_QueQuan.SelectedIndex = 28;
            cbo_ChucVu.SelectedIndex = 0;
            foreach (Object o in this.Controls)
            {
                if (o is TextBox)
                    ((TextBox)o).Clear();
            }
        }

        //Xử lý btn Lưu
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string strsql, gioitinh;
            if (txt_TenNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenNhanVien.Focus();
                return;
            }
            if (txt_DiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_DiaChi.Focus();
                return;
            }
            if (txt_SDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_SDT.Focus();
                return;
            }

            if (rdo_Nam.Checked == true)
                gioitinh = "Nam";
            else
                gioitinh = "Nữ";

            string strQuequan = cbo_QueQuan.SelectedItem.ToString();
            string strChucvu = cbo_ChucVu.SelectedItem.ToString();

            try
            {
                strsql = "INSERT INTO  NHANVIEN VALUES ('" + txt_MaNhanVien.Text
                    + "',N'" + txt_TenNhanVien.Text + "',N'" + gioitinh
                    + "',N'" + strChucvu + "',N'" + txt_DiaChi.Text
                    + "','" + txt_SDT.Text + "',N'" + strQuequan + "')";

                conn.Update(strsql);
                MessageBox.Show("Lưu thành công !!");
                LoadDGV_NhanVien();

                xoaGiaTriTextBox();
                btn_Xoa.Enabled = true;
                btn_Them.Enabled = true;
                btn_Sua.Enabled = true;
                btn_Huy.Enabled = false;
                btn_Luu.Enabled = false;

                txt_MaNhanVien.Enabled = false;
                txt_TenNhanVien.Enabled = false;
                txt_SDT.Enabled = false;
                txt_DiaChi.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Lưu thất bại !!");
            }
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length > 9)
            {
                //Số điện thoại chỉ 10 chữ số
                this.errorProvider1.SetError(ctr, "Số điện thoại chỉ 10 chữ số !!");
                e.Handled = true;
            }
            else
                this.errorProvider1.Clear();
        }

        ////Xử lý btn Thêm
        private void btn_Them_Click(object sender, EventArgs e)
        {
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Huy.Enabled = true;
            btn_Luu.Enabled = true;
            btn_Them.Enabled = false;
            xoaGiaTriTextBox();
            //Tạo mã nhân viên tự động
            string strsql = "Select count(*) from NHANVIEN";
            int stt = conn.getCount(strsql) + 1;
            string manv = "";
            if (stt < 10)
                manv = "NV00" + stt.ToString();
            else
                manv = "NV0" + stt.ToString();
            strsql = "Select count(*) from NHANVIEN where manv = '" +manv+ "'";
            while(conn.checkForExistence(strsql))
            {
                stt++;
                if (stt < 10)
                    manv = "NV00" + stt.ToString();
                else
                    manv = "NV0" + stt.ToString();
                strsql = "Select count(*) from NHANVIEN where manv = '" + manv + "'";
            }
            txt_MaNhanVien.Text = manv;

            txt_TenNhanVien.Enabled = true;
            txt_SDT.Enabled = true;
            txt_DiaChi.Enabled = true;
            txt_TenNhanVien.Focus();
        }

        //Xử lý btn Sua
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string strsql, gioitinh;
            if (tbl_NhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_MaNhanVien.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Kiểm tra các txt có trống không ?
            if (txt_TenNhanVien.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenNhanVien.Focus();
                return;
            }
            if (txt_DiaChi.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_DiaChi.Focus();
                return;
            }
            if (txt_SDT.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_SDT.Focus();
                return;
            }

            try
            {
                if (rdo_Nam.Checked == true)
                    gioitinh = "Nam";
                else
                    gioitinh = "Nữ";

                string strQuequan = cbo_QueQuan.SelectedItem.ToString();
                string strChucvu = cbo_ChucVu.SelectedItem.ToString();

                //Sửa theo mã nhân viên hiện ở txt_MaNhanVien
                strsql = "UPDATE NHANVIEN SET TENNV = N'" + txt_TenNhanVien.Text +
                        "',DIACHI = N'" + txt_DiaChi.Text +
                        "',SODT='" + txt_SDT.Text.Trim() + "',GIOITINH = N'" + gioitinh +
                        "',CHUCVU = N'" + strChucvu +
                        "',QUEQUAN = N'" + strQuequan +
                        "' WHERE MANV='" + txt_MaNhanVien.Text + "'";

                conn.Update(strsql);
                MessageBox.Show("Sửa thành công !!");
                LoadDGV_NhanVien();
                btn_Huy.Enabled = false;

                txt_MaNhanVien.Enabled = false;
                txt_TenNhanVien.Enabled = false;
                txt_SDT.Enabled = false;
                txt_DiaChi.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Sửa thất bại !!");
            }
        }

        //Xử lý btn Xóa
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string strsql;
            if (tbl_NhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_MaNhanVien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn nhân viên nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    strsql = "DELETE NHANVIEN WHERE MANV='" + txt_MaNhanVien.Text + "'";
                    conn.Update(strsql);
                    MessageBox.Show("Xóa thành công !!");
                    LoadDGV_NhanVien();
                    xoaGiaTriTextBox();
                }

                txt_MaNhanVien.Enabled = false;
                txt_TenNhanVien.Enabled = false;
                txt_SDT.Enabled = false;
                txt_DiaChi.Enabled = false;
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

            txt_MaNhanVien.Enabled = false;
            txt_TenNhanVien.Enabled = false;
            txt_SDT.Enabled = false;
            txt_DiaChi.Enabled = false;
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            if (btn_Them.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MaNhanVien.Focus();
                return;
            }

            if (tbl_NhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Bấm vào datagridview dữ liệu hiện lên lại các txt tương ứng
            int index = dgvNhanVien.CurrentRow.Index;
            txt_MaNhanVien.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            txt_TenNhanVien.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            if (dgvNhanVien.CurrentRow.Cells[2].Value.ToString() == "Nam")
                rdo_Nam.Checked = true;
            else
                rdo_Nu.Checked = true;
            cbo_ChucVu.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
            txt_DiaChi.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
            txt_SDT.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
            cbo_QueQuan.Text = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();

            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;

            txt_TenNhanVien.Enabled = true;
            txt_SDT.Enabled = true;
            txt_DiaChi.Enabled = true;
        }

    }
}