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
    public partial class FrmDangNhap : Form
    {
        KetNoi conn = new KetNoi();

        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            lblAnHien.ImageIndex = 1;
            txtMatKhau.UseSystemPasswordChar = true;
            txtTenDangNhap.Focus();
        }

        private void lblAnHien_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.UseSystemPasswordChar == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
                lblAnHien.ImageIndex = 0;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
                lblAnHien.ImageIndex = 1;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string strsql = "select count(*) from USERS where ID ='" + txtTenDangNhap.Text + "'";

                if (!conn.checkForExistence(strsql))
                {
                    MessageBox.Show("Tài khoản không tồn tại !!");
                    txtTenDangNhap.Clear();
                    txtMatKhau.Clear();
                    txtTenDangNhap.Focus();
                    conn.closeConnection();
                    return;
                }
                strsql = "select count(*) from USERS where PASSWORDS ='" 
                    + txtMatKhau.Text + "' And ID ='" + txtTenDangNhap.Text + "'";
                if (!conn.checkForExistence(strsql))
                {
                    MessageBox.Show("Mật khẩu không đúng !!");
                    txtMatKhau.Clear();
                    txtMatKhau.Focus();
                    conn.closeConnection();
                    return;
                }
                MessageBox.Show("Đăng nhập thành công !!");

                //Phân quyền vô form main
                this.Hide();
                strsql = "select count(*) from NHANVIEN,USERS where NHANVIEN.MANV=USERS.MANV and NHANVIEN.CHUCVU=N'Nhân viên' and PASSWORDS ='" + txtMatKhau.Text + "' And ID ='" + txtTenDangNhap.Text + "'";
                //if (conn.getCount(strsql) > 0)
                if (conn.checkForExistence(strsql))
                {
                    //From bị hạn chế 1 số chức năng
                    FrmMain main = new FrmMain("Nhân viên");
                    main.Show();
                }
                else
                {
                    FrmMain main = new FrmMain();
                    main.Show();
                }
            }
            catch
            {
                MessageBox.Show("Đăng nhập thất bại !!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
