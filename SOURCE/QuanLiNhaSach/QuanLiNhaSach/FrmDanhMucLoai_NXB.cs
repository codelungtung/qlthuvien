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
namespace QuanLiNhaSach
{
    public partial class FrmDanhMucLoai_NXB : Form
    {
        public FrmDanhMucLoai_NXB()
        {
            InitializeComponent();
        }

        KetNoi conn = new KetNoi();
        DataTable dtNXB, dtTheLoai;

        public void LoadDataGridViewNXB()
        {
            string strsql;
            strsql = "SELECT * FROM NHAXB";
            dtNXB = conn.DataTable(strsql);
            dataGridViewNXB.DataSource = dtNXB;
        }

        public void LoadDataGridViewTheloai()
        {
            string strsql;
            strsql = "SELECT * FROM LOAISACH";
            dtTheLoai = conn.DataTable(strsql);
            dataGridViewTheloai.DataSource = dtTheLoai;
        }

        private void xoaGiaTriTextBoxNXB()
        {
            txt_MaNXB.Text = "";
            txt_TenNXB.Text = "";
            txt_DiaChiNXB.Text = "";
        }

        private void xoaGiaTriTextBoxTheloai()
        {
            txt_MaTheLoai.Text = "";
            txt_TenTheLoai.Text = "";
        }

        private void FrmDanhMucLoai_NXB_Load(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                txt_MaNXB.Enabled = false;
                txt_TenNXB.Enabled = false;
                txt_DiaChiNXB.Enabled = false;
                btn_LuuNXB.Enabled = false;
                conn.openConnection();
                LoadDataGridViewNXB();
            }
            if (tabControl1.SelectedIndex == 1)
            {
                txt_MaTheLoai.Enabled = false;
                txt_TenTheLoai.Enabled = false;
                btn_LuuNXB.Enabled = false;
                conn.openConnection();
                LoadDataGridViewTheloai();
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                txt_MaNXB.Enabled = false;
                btn_LuuNXB.Enabled = false;
                conn.openConnection();
                LoadDataGridViewNXB();
            }
            if (tabControl1.SelectedIndex == 1)
            {
                txt_MaTheLoai.Enabled = false;
                txt_TenTheLoai.Enabled = false;
                btn_LuuNXB.Enabled = false;
                conn.openConnection();
                LoadDataGridViewTheloai();
            }
        }

        private void btn_ThemNXB_Click(object sender, EventArgs e)
        {
            btn_SuaNXB.Enabled = false;
            btn_XoaNXB.Enabled = false;
            btn_LuuNXB.Enabled = true;
            btn_ThemNXB.Enabled = false;
            xoaGiaTriTextBoxNXB();
            //Tạo mã nhà xuất bản tự động
            string strsql = "Select count(*) from NHAXB";
            int stt = conn.getCount(strsql) + 1;
            string manxb = "";
            if (stt < 10)
                manxb = "XB0" + stt.ToString();
            else
                manxb = "XB" + stt.ToString();
            strsql = "Select count(*) from  NHAXB where MANXB = '" + manxb + "'";
            while (conn.checkForExistence(strsql))
            {
                stt++;
                if (stt < 10)
                    manxb = "XB0" + stt.ToString();
                else
                    manxb = "XB" + stt.ToString();
                strsql = "Select count(*) from NHAXB where manxb = '" + manxb + "'";
            }
            txt_MaNXB.Text = manxb;

            txt_TenNXB.Enabled = true;
            txt_DiaChiNXB.Enabled = true;
        }

        private void btn_XoaNXB_Click(object sender, EventArgs e)
        {
            string strsql;
            if (dtNXB.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_MaNXB.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn nhà xuất bản nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                strsql = "DELETE NHAXB WHERE MANXB='" + txt_MaNXB.Text + "'";
                conn.Update(strsql);
                LoadDataGridViewNXB();
                xoaGiaTriTextBoxNXB();
            }

            txt_TenNXB.Enabled = false;
            txt_DiaChiNXB.Enabled = false;
        }

        private void btn_LuuNXB_Click(object sender, EventArgs e)
        {
            string strsql;
            if (txt_MaNXB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MaNXB.Focus();
                return;
            }
            if (txt_TenNXB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenNXB.Focus();
                return;
            }
            if (txt_DiaChiNXB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_DiaChiNXB.Focus();
                return;
            }


            strsql = "INSERT INTO  NHAXB VALUES ('" + txt_MaNXB.Text.Trim()
                + "' ,N'" + txt_TenNXB.Text + "',N'" + txt_DiaChiNXB.Text + "')";


            conn.Update(strsql);

            LoadDataGridViewNXB();

            xoaGiaTriTextBoxNXB();
            btn_XoaNXB.Enabled = true;
            btn_ThemNXB.Enabled = true;
            btn_SuaNXB.Enabled = true;
            btn_LuuNXB.Enabled = false;
            txt_MaNXB.Enabled = false;

            txt_TenNXB.Enabled = false;
            txt_DiaChiNXB.Enabled = false;
        }


        private void btn_ThemTL_Click(object sender, EventArgs e)
        {
            btn_SuaTL.Enabled = false;
            btn_XoaTL.Enabled = false;
            btn_LuuTL.Enabled = true;
            btn_ThemTL.Enabled = false;
            txt_TenTheLoai.Enabled = true;
            xoaGiaTriTextBoxTheloai();
            //Tạo mã thể loại tự động
            string strsql = "Select count(*) from LOAISACH";
            int stt = conn.getCount(strsql) + 1;
            string maloaisach = "";
            if (stt < 10)
                maloaisach = "0" + stt.ToString();
            else
                maloaisach = "" + stt.ToString();
            strsql = "Select count(*) from  LOAISACH where MALOAISACH = '" + maloaisach + "'";
            while (conn.checkForExistence(strsql))
            {
                stt++;
                if (stt < 10)
                    maloaisach = "0" + stt.ToString();
                else
                    maloaisach = "" + stt.ToString();
                strsql = "Select count(*) from LOAISACH where maloaisach = '" + maloaisach + "'";
            }
            txt_MaTheLoai.Text = maloaisach;
        }

        private void btn_LuuTL_Click(object sender, EventArgs e)
        {
            string strsql;
            if (txt_MaTheLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MaTheLoai.Focus();
                return;
            }
            if (txt_TenTheLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenTheLoai.Focus();
                return;
            }

            strsql = "INSERT INTO  LOAISACH VALUES ('" + txt_MaTheLoai.Text.Trim()
                + "',N'" + txt_TenTheLoai.Text + "')";


            conn.Update(strsql);

            LoadDataGridViewTheloai();

            xoaGiaTriTextBoxTheloai();
            btn_XoaTL.Enabled = true;
            btn_ThemTL.Enabled = true;
            btn_SuaTL.Enabled = true;
            btn_LuuTL.Enabled = false;
            txt_MaTheLoai.Enabled = false;

            txt_TenTheLoai.Enabled = false;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewNXB_Click(object sender, EventArgs e)
        {
            if (btn_ThemNXB.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MaNXB.Focus();
                return;
            }

            if (dtNXB.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int index = dataGridViewNXB.CurrentRow.Index;
            txt_MaNXB.Text = dataGridViewNXB.CurrentRow.Cells[0].Value.ToString();
            txt_TenNXB.Text = dataGridViewNXB.CurrentRow.Cells[1].Value.ToString();
            txt_DiaChiNXB.Text = dataGridViewNXB.CurrentRow.Cells[2].Value.ToString();
            btn_SuaNXB.Enabled = true;
            btn_XoaNXB.Enabled = true;

            txt_TenNXB.Enabled = true;
            txt_DiaChiNXB.Enabled = true;
        }

        private void dataGridViewTheloai_Click(object sender, EventArgs e)
        {

            if (btn_ThemTL.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MaTheLoai.Focus();
                return;
            }

            if (dtTheLoai.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int index = dataGridViewTheloai.CurrentRow.Index;
            txt_MaTheLoai.Text = dataGridViewTheloai.CurrentRow.Cells[0].Value.ToString();
            txt_TenTheLoai.Text = dataGridViewTheloai.CurrentRow.Cells[1].Value.ToString();
            btn_SuaTL.Enabled = true;
            btn_XoaTL.Enabled = true;

            txt_TenTheLoai.Enabled = true;
        }

        private void btn_SuaTL_Click(object sender, EventArgs e)
        {
            string strsql;
            if (dtTheLoai.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_MaTheLoai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn thể loại nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_TenTheLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenTheLoai.Focus();
                return;
            }

            strsql = "UPDATE LOAISACH SET TENLOAI = N'" + txt_TenTheLoai.Text +
                    "' WHERE MALOAISACH='" + txt_MaTheLoai.Text + "'";

            conn.Update(strsql);
            LoadDataGridViewTheloai();

            txt_TenTheLoai.Enabled = false;
        }

        private void btn_SuaNXB_Click(object sender, EventArgs e)
        {
            string strsql;
            if (dtNXB.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_MaNXB.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn nhà xuất bản nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_TenNXB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenNXB.Focus();
                return;
            }

            strsql = "UPDATE NHAXB SET TENNXB = N'" + txt_TenNXB.Text +
                    "' WHERE MANXB='" + txt_MaNXB.Text + "'";

            conn.Update(strsql);
            LoadDataGridViewNXB();

            txt_TenNXB.Enabled = false;
            txt_DiaChiNXB.Enabled = false;
        }

        private void btn_XoaTL_Click(object sender, EventArgs e)
        {

            string strsql;
            if (dtTheLoai.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_MaTheLoai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn thể loại nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                strsql = "DELETE LOAISACH WHERE MALOAISACH='" + txt_MaTheLoai.Text + "'";
                conn.Update(strsql);
                LoadDataGridViewTheloai();
                xoaGiaTriTextBoxTheloai();
            }

            txt_TenTheLoai.Enabled = false;
        }
    }
}
