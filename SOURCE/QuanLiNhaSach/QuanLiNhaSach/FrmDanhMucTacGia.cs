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
    public partial class FrmDanhMucTacGia : Form
    {
        public FrmDanhMucTacGia()
        {
            InitializeComponent();
        }

        KetNoi conn = new KetNoi();
        DataTable tbl_TacGia;

        string[] quequan = { "An Giang", "Bà Rịa–Vũng Tàu", "Bạc Liêu", "Bắc Kạn", "Bắc Giang", "Bắc Ninh", "Bến Tre", "Bình Dương", "Bình Định", "Bình Phước", "Bình Thuận", 
                       "Cà Mau", "Cao Bằng", "Cần Thơ",	"Đà Nẵng", "Đắk Lắk", "Đắk Nông", "Điện Biên", "Đồng Nai", "Đồng Tháp", "Gia Lai", "Hà Giang", "Hà Nam", "Hà Nội", 
                       "Hà Tĩnh", "Hải Dương", "Hải Phòng", "Hòa Bình", "TP Hồ Chí Minh", "Hậu Giang", "Hưng Yên", "Khánh Hòa", "Kiên Giang", "Kon Tum", "Lai Châu", "Lào Cai", 
                       "Lạng Sơn", "Lâm Đồng", "Long An", "Nam Định", "Nghệ An", "Ninh Bình", "Ninh Thuận", "Phú Thọ", "Phú Yên", "Quảng Bình", "Quảng Nam",	"Quảng Ngãi", 
                       "Quảng Ninh", "Quảng Trị"," Sóc Trăng", "Sơn La", "Tây Ninh", "Thái Bình", "Thái Nguyên", "Thanh Hóa", "Thừa Thiên – Huế", "Tiền Giang", "Trà Vinh", 
                       "Tuyên Quang", "Vĩnh Long", "Vĩnh Phúc", "Yên Bái", "Nước ngoài"};

        public void LoadDataGridView()
        {
            string strsql;
            strsql = "SELECT * FROM TACGiA";
            tbl_TacGia = conn.DataTable(strsql);
            dataGridViewTacGia.DataSource = tbl_TacGia;
        }

        private void FrmDanhMucTacGia_Load(object sender, EventArgs e)
        {
            txt_MaTacGia.Enabled = false;
            btn_Luu.Enabled = false;
            btn_Huy.Enabled = false;
            txt_TenTacGia.Enabled = false;
            txt_DiaChi.Enabled = false;
            conn.openConnection();
            LoadDataGridView();
            foreach (string s in quequan)
            {
                cboQueQuan.Items.Add(s);
            }
            cboQueQuan.SelectedIndex = 28;
        }

        private void xoaGiaTriTextBoxTacGia()
        {
            //txt_MaNhanVien.Text = "";
            //txt_TenNhanVien.Text = "";
            //txt_DiaChi.Text = "";
            //txt_SDT.Text = "";
            //txt_ChucVuNV.Text = "";
            foreach (Object o in this.Controls)
            {
                if (o is TextBox)
                    ((TextBox)o).Clear();
            }
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            if (btn_Them.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MaTacGia.Focus();
                return;
            }

            if (tbl_TacGia.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int index = dataGridViewTacGia.CurrentRow.Index;
            txt_MaTacGia.Text = dataGridViewTacGia.CurrentRow.Cells[0].Value.ToString();
            txt_TenTacGia.Text = dataGridViewTacGia.CurrentRow.Cells[1].Value.ToString();
            txt_DiaChi.Text = dataGridViewTacGia.CurrentRow.Cells[2].Value.ToString();
            cboQueQuan.SelectedItem = dataGridViewTacGia.CurrentRow.Cells[3].Value.ToString();
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            txt_TenTacGia.Enabled = true;
            txt_DiaChi.Enabled = true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Huy.Enabled = true;
            btn_Luu.Enabled = true;
            btn_Them.Enabled = false;
            txt_TenTacGia.Enabled = true;
            txt_DiaChi.Enabled = true;
            xoaGiaTriTextBoxTacGia();
            //Tạo mã tác giả tự động
            string strsql = "Select count(*) from TACGIA";
            int stt = conn.getCount(strsql) + 1;
            string matg = "";
            if (stt < 10)
                matg = "TG0" + stt.ToString();
            else
                matg = "TG" + stt.ToString();
            strsql = "Select count(*) from  TACGIA where matacgia = '" + matg + "'";
            while (conn.checkForExistence(strsql))
            {
                stt++;
                if (stt < 10)
                    matg = "TG0" + stt.ToString();
                else
                    matg = "TG" + stt.ToString();
                strsql = "Select count(*) from TACGIA where matacgia = '" + matg + "'";
            }
            txt_MaTacGia.Text = matg;
            txt_TenTacGia.Focus();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string strsql;
            if (tbl_TacGia.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_MaTacGia.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn tác giả nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                strsql = "DELETE TACGiA WHERE MATACGIA ='" + txt_MaTacGia.Text + "'";
                conn.Update(strsql);
                LoadDataGridView();
                xoaGiaTriTextBoxTacGia();
            }
            txt_TenTacGia.Enabled = false;
            txt_DiaChi.Enabled = false;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string strsql;
            if (tbl_TacGia.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (Object o in this.Controls)
            {
                if (o is TextBox)
                {
                    if (((TextBox)o).Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Bạn phải nhập " + ((TextBox)o).Text.ToLower(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ((TextBox)o).Focus();
                        return;
                    }
                }
            }

            strsql = "UPDATE TACGIA SET TENTG = N'" + txt_TenTacGia.Text +
                    "',DIACHI = N'" + txt_DiaChi.Text +
                    "',QUEQUAN = N'" + cboQueQuan.SelectedItem.ToString() +
                    "' WHERE MATACGIA='" + txt_MaTacGia.Text + "'";

            conn.Update(strsql);
            LoadDataGridView();
            btn_Huy.Enabled = false;
            txt_TenTacGia.Enabled = false;
            txt_DiaChi.Enabled = false;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string strsql;
            if (txt_MaTacGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MaTacGia.Focus();
                return;
            }
            if (txt_TenTacGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenTacGia.Focus();
                return;
            }
            if (txt_DiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_DiaChi.Focus();
                return;
            }

            string strQuequan = cboQueQuan.Text;

            strsql = "INSERT INTO  TACGIA VALUES ('" + txt_MaTacGia.Text
                    + "',N'" + txt_TenTacGia.Text +
                      "',N'" + strQuequan
                    + "',N'" + txt_DiaChi.Text + "')";


            conn.Update(strsql);

            LoadDataGridView();

            xoaGiaTriTextBoxTacGia();
            btn_Xoa.Enabled = true;
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Huy.Enabled = false;
            btn_Luu.Enabled = false;
            txt_MaTacGia.Enabled = false;
            txt_TenTacGia.Enabled = false;
            txt_DiaChi.Enabled = false;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            xoaGiaTriTextBoxTacGia();
            btn_Huy.Enabled = false;
            btn_Them.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Luu.Enabled = false;
            txt_MaTacGia.Enabled = false;
        }
    }
}