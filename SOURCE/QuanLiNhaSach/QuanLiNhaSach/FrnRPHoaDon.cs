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
    public partial class FrnRPHoaDon : Form
    {
        public FrnRPHoaDon()
        {
            InitializeComponent();
        }

        string sohoadon;

        public FrnRPHoaDon(string sohd)
        {
            InitializeComponent();
            sohoadon = sohd;
        }

        private void frmRP_Load(object sender, EventArgs e)
        {
            ReportHoaDon rpt = new ReportHoaDon();
            crystalReportViewer1.ReportSource = rpt;

            //Lọc theo số hóa đơn hiện hành trong form Hóa đơn bán sách
            rpt.SetParameterValue("sohoadon", sohoadon);

            //Không phải nhập pass mỗi lần form load lên
            rpt.SetDatabaseLogon("sa", "sa2012", "LAPTOP-V3N8G0SP", "QLNHASACH");


            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.Refresh();
            
        }
    }
}
