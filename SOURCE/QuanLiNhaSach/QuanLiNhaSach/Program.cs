using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaSach
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmDanhMucNhanVien());
            //Application.Run(new FrmMain());
            Application.Run(new FrmDangNhap());
            //Application.Run(new FrmDanhMucLoai_NXB());
            //Application.Run(new FrmDanhMucTacGia());
            //Application.Run(new FrmHoaDonBanSach());
            //Application.Run(new FrmThongTinSach());
            //Application.Run(new FrmDanhMucSach());
        }
    }
}
