using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaSach
{
    public partial class FrmMain : Form
    {
        //Form main quyền quản lý
        public FrmMain()
        {
            InitializeComponent();
        }

        //Form main quyền nhân viên
        public FrmMain(string chucvu)
        {
            InitializeComponent();
            btn_NhanVien.Enabled = false;
            toolStripBtnNhanVien.Enabled = false;
            nhânViênToolStripMenuItem.Enabled = false;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
        //XỬ LÝ THANH MENU STRIP
        //Chương trình
        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDangNhap dangnhap = new FrmDangNhap();
            this.Hide();
            dangnhap.ShowDialog();
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Danh mục
        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDanhMucSach dms = new FrmDanhMucSach();
            this.Visible = false;
            dms.ShowDialog();
            this.Visible = true;
        }
        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDanhMucTacGia dmtg = new FrmDanhMucTacGia();
            this.Visible = false;
            dmtg.ShowDialog();
            this.Visible = true;
        }
        private void thểLoại_NXBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDanhMucLoai_NXB dmtlnxb = new FrmDanhMucLoai_NXB();
            this.Visible = false;
            dmtlnxb.ShowDialog();
            dmtlnxb.tabControl1.SelectedIndex = 1;
            this.Visible = true;
        }
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDanhMucNhanVien dmnv = new FrmDanhMucNhanVien();
            this.Visible = false;
            dmnv.ShowDialog();
            this.Visible = true;
        }

        //Nghiệp vụ
        private void lậpHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHoaDonBanSach hoadon = new FrmHoaDonBanSach();
            this.Visible = false;
            hoadon.ShowDialog();
            this.Visible = true;
        }

        //Thống kê
        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRPKhachHang kh = new FrmRPKhachHang();
            this.Visible = false;
            kh.ShowDialog();
            this.Visible = true;
        }

        //Giới thiệu
        private void thôngTinNhómToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string gth = "\n1. Hoàng Mạnh Cường \t MSSV: 2001160180 \n2. Nguyễn Huỳnh Bá Huy \t MSSV: 2001160250 \n3. Nguyễn Ngọc Tuấn Khôi \t MSSV: 2001160259";
            MessageBox.Show(gth, "Danh sách thành viên nhóm");
        }
        private void thôngTinNhàSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chào mừng đến với WORLD BOOKSTORE", "Thông tin nhà sách");
        }


        //Xử LÝ THANH TOOL STRIP
        private void toolStripBtnSach_Click(object sender, EventArgs e)
        {
            FrmThongTinSach tts = new FrmThongTinSach();
            this.Visible = false;
            tts.ShowDialog();
            this.Visible = true;
        }
        private void toolStripBtnNhanVien_Click(object sender, EventArgs e)
        {
            FrmDanhMucNhanVien dmnv = new FrmDanhMucNhanVien();
            this.Visible = false;
            dmnv.ShowDialog();
            this.Visible = true;
        }
        private void toolStripBtnHoaDon_Click(object sender, EventArgs e)
        {
            FrmHoaDonBanSach hd = new FrmHoaDonBanSach();
            this.Visible = false;
            hd.ShowDialog();
            this.Visible = true;
        }
        private void toolStripBtnThongKe_Click(object sender, EventArgs e)
        {
            FrmRPKhachHang kh = new FrmRPKhachHang();
            this.Visible = false;
            kh.ShowDialog();
            this.Visible = true;
        }


        //XỬ LÝ 4 BUTTONS
        private void btn_Sach_Click(object sender, EventArgs e)
        {
            FrmDanhMucSach dms = new FrmDanhMucSach();
            this.Visible = false;
            dms.ShowDialog();
            this.Visible = true;
        }
        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            FrmDanhMucNhanVien dmnv = new FrmDanhMucNhanVien();
            this.Visible = false;
            dmnv.ShowDialog();
            this.Visible = true;
        }
        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            FrmHoaDonBanSach hoadon = new FrmHoaDonBanSach();
            this.Visible = false;
            hoadon.ShowDialog();
            this.Visible = true;
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            FrmRPKhachHang kh = new FrmRPKhachHang();
            this.Visible = false;
            kh.ShowDialog();
            this.Visible = true;
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThongTinSach tts = new FrmThongTinSach();
            this.Visible = false;
            tts.ShowDialog();
            this.Visible = true;
        }

        
    }
}
