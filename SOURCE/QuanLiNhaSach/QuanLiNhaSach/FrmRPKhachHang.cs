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
    public partial class FrmRPKhachHang : Form
    {
        public FrmRPKhachHang()
        {
            InitializeComponent();
        }

        private void FrmRPKhachHang_Load(object sender, EventArgs e)
        {
            ReportKhachHang rpt = new ReportKhachHang();
            crystalReportViewer1.ReportSource = rpt;

            //Không phải nhập pass mỗi lần form load lên
            rpt.SetDatabaseLogon("sa", "sa2012", "LAPTOP-V3N8G0SP", "QLNHASACH");


            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.Refresh();
        }
    }
}
