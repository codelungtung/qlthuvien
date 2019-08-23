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
    public partial class FrmHoaDonBanSach : Form
    {
        KetNoi conn = new KetNoi();
        DataTable tbl_CTHoaDon;
        DateTime now = DateTime.Now;

        public FrmHoaDonBanSach()
        {
            InitializeComponent();
        }

        public void loadComBoBoxMaNV()
        {
            string strsql = "SELECT * FROM NHANVIEN";
            SqlDataReader rd = conn.getDataReader(strsql);
            while (rd.Read())
            {
                cbo_MaNV.Items.Add(rd["MANV"].ToString());
            }
            cbo_MaNV.SelectedIndex = 0;
        }

        public void LoadDataGridViewCTHD()
        {
            string strsql;
            strsql = "Select count(*) from CT_HOADON where SOHOADON = '" + txt_SoHD.Text + "'";
            if (conn.checkForExistence(strsql))
            {
                strsql = "SELECT * FROM CT_HOADON where SOHOADON = '" + txt_SoHD.Text + "'"; 
                tbl_CTHoaDon = conn.DataTable(strsql);
                dataGridViewCTHD.DataSource = tbl_CTHoaDon;
            }
        }

        public void loadCombo_HD()
        {
            string strsql = "SELECT * FROM HOADON";
            conn.openConnection();
            SqlDataAdapter da = new SqlDataAdapter(strsql, conn.Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbo_HoaDon.DataSource = dt;
            cbo_HoaDon.DisplayMember = "SOHOADON";
            cbo_HoaDon.ValueMember = "SOHOADON";
            cbo_HoaDon.SelectedIndex = 0;
        }

        private void btnLoadHoaDon_Click(object sender, EventArgs e)
        {
            loadCombo_HD();
            string sohd = cbo_HoaDon.SelectedValue.ToString();
            string strsql = "SELECT * FROM CT_HOADON WHERE SOHOADON = '" + sohd + "'";
            tbl_CTHoaDon = conn.DataTable(strsql);
            dataGridViewCTHD.DataSource = tbl_CTHoaDon;

        }

        private void cbo_HoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sohd = cbo_HoaDon.SelectedValue.ToString();
            string strsql = "SELECT * FROM CT_HOADON WHERE SOHOADON = '" + sohd + "'";
            tbl_CTHoaDon = conn.DataTable(strsql);
            dataGridViewCTHD.DataSource = tbl_CTHoaDon;
            strsql = "SELECT TONGGIATRI FROM HOADON WHERE SOHOADON = '" + sohd + "'";
            double tongtien = conn.layGiaTriCuaBang(strsql);
            txt_TongTienHD.Text = tongtien.ToString();
        }

        private void FrmHoaDonBanSach_Load(object sender, EventArgs e)
        {
            radNam.Checked = true;
            txt_NgayBan.Text = now.ToString("dd/MM/yyyy");

            loadComBoBoxMaNV();

            btn_ThemCTHD.Enabled = false;    
            btn_ThemSach.Enabled = false;
            btn_ThemVaoHD.Enabled = false;
            btn_ChonSach.Enabled = false;
            btn_InHD.Enabled = false;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChonSach_Click(object sender, EventArgs e)
        {
            FrmThongTinSach frm = new FrmThongTinSach();
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
        }

        private void dataGridViewCTHD_Click(object sender, EventArgs e)
        {
            if (tbl_CTHoaDon.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int index = dataGridViewCTHD.CurrentRow.Index;
            txt_SoHD.Text = dataGridViewCTHD.CurrentRow.Cells[0].Value.ToString();
            txt_MaSachChon.Text = dataGridViewCTHD.CurrentRow.Cells[1].Value.ToString();
            txt_SoLuong.Text = dataGridViewCTHD.CurrentRow.Cells[2].Value.ToString();
            txt_DonGia.Text = dataGridViewCTHD.CurrentRow.Cells[3].Value.ToString();
            txt_ThanhTien.Text = dataGridViewCTHD.CurrentRow.Cells[4].Value.ToString();

            txt_TongTienHD.Text = tinhThanhTien().ToString();
            //double tongtien = conn.layGiaTriCuaBang(strsql);
            //txt_TongTienHD.Text = tongtien.ToString();
            btn_ThemCTHD.Enabled = false;
        }

        //xử lý btn Hóa đơn mới
        private void btn_HoaDonMoi_Click(object sender, EventArgs e)
        {
            dataGridViewCTHD.DataSource = null;

            //Tạo số hóa đơn tự động
            string strsql = "Select count(*) from HOADON";
            int stt = conn.getCount(strsql) + 1;
            string sohoadon = "";
            if (stt < 10)
                sohoadon = "HD"+ now.ToString("ddMM") +"00"+ stt.ToString();
            else
                sohoadon = "HD" + now.ToString("ddMM") + "0" + stt.ToString();
            strsql = "Select count(*) from HOADON where  SOHOADON = '" + sohoadon + "'";
            while (conn.checkForExistence(strsql))
            {
                stt++;
                if (stt < 10)
                    sohoadon = "HD" + now.ToString("ddMM") + "00" + stt.ToString();
                else
                    sohoadon = "HD" + now.ToString("ddMM") + "0" + stt.ToString();
                strsql = "Select count(*) from HOADON where SOHOADON = '" + sohoadon + "'";
            }
            txt_SoHD.Text = sohoadon;

            foreach (Object o in grpKhachHang.Controls)
            {
                if (o is TextBox)
                    ((TextBox)o).Clear();
            }
            txt_MaSachChon.Enabled = false;
            txt_TenSachChon.Enabled = false;
            txt_ThanhTien.Enabled = false;
            txt_DonGia.Enabled = false;

            //Tạo mã khách hàng tự động
            strsql = "Select count(*) from KHACHHANG";
            stt = conn.getCount(strsql) + 1;
            string makh = "";
            if (stt < 10)
                makh = "KH" + now.ToString("ddMM") + "00" + stt.ToString();
            else
                makh = "KH" + now.ToString("ddMM") + "0" + stt.ToString();
            strsql = "Select count(*) from KHACHHANG where MAKH = '" + makh + "'";
            while (conn.checkForExistence(strsql))
            {
                stt++;
                if (stt < 10)
                    makh = "KH" + now.ToString("ddMM") + "00" + stt.ToString();
                else
                    makh = "KH" + now.ToString("ddMM") + "0" + stt.ToString();
                strsql = "Select count(*) from KHACHHANG where MAKH = '" + makh + "'";
            }
            txt_MaKhach.Text = makh;
            btn_ChonSach.Enabled = true;
            txt_TenKhach.Focus();
        }
       
        public double tinhThanhTien()
        {
            double thanhtien = 0;
            int n = dataGridViewCTHD.Rows.Count;
            for (int i = 0; i < n; i++)
                thanhtien += float.Parse(dataGridViewCTHD.Rows[i].Cells[4].Value.ToString());
            return thanhtien;
        }

        private void btn_ThemCTHD_Click(object sender, EventArgs e)
        {
            try
            {
                string strsql = "SELECT SOLUONGNHAP FROM SACH WHERE MASACH = '" + txt_MaSachChon.Text + "'";
                double soluong = conn.layGiaTriCuaBang(strsql);
                if (MessageBox.Show("Xác nhận mua sách", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
                if (soluong > float.Parse(txt_SoLuong.Text))
                {
                    string gioitinh;
                    if (radNam.Checked == true)
                        gioitinh = "Nam";
                    else
                        gioitinh = "Nữ";
                    //Khi thêm 1 cuốn sách mới của hóa đơn đang hiện hành vào cthd thì không thêm mã hóa đơn và khách hàng mới
                    strsql = "Select count(*) from KHACHHANG where MAKH = '" + txt_MaKhach.Text + "'";
                    if (!conn.checkForExistence(strsql))
                    {
                        strsql = "INSERT INTO KHACHHANG VALUES ('" + txt_MaKhach.Text
                                + "',N'" + txt_TenKhach.Text +
                                  "',N'" + gioitinh
                               + "','" + txt_SoDT.Text + "')";
                        conn.Update(strsql);
                    }
                    strsql = "Select count(*) from HOADON where SOHOADON = '" + txt_SoHD.Text + "'";
                    if (!conn.checkForExistence(strsql))
                    {
                        strsql = "INSERT INTO HOADON VALUES ('" + txt_SoHD.Text
                                + "','" + txt_NgayBan.Text +
                                  "', 0, 0,'" + cbo_MaNV.SelectedItem.ToString()
                               + "','" + txt_MaKhach.Text + "')";
                        conn.Update(strsql);
                    }

                    //Thêm cthd mới
                    strsql = "INSERT INTO  CT_HOADON VALUES ('" + txt_SoHD.Text
                            + "','" + txt_MaSachChon.Text +
                              "'," + float.Parse(txt_SoLuong.Text)
                            + "," + float.Parse(txt_DonGia.Text)
                            + "," + float.Parse(txt_ThanhTien.Text) + ")";

                    conn.Update(strsql);
                    LoadDataGridViewCTHD();
                    btn_ThemCTHD.Enabled = false;
                    txt_TongTienHD.Text = tinhThanhTien().ToString();

                    //update lại số lượng sách
                    double soluongconlai = soluong - double.Parse(txt_SoLuong.Text);
                    strsql = "UPDATE SACH SET SOLUONGNHAP ='" + soluongconlai + "' where MASACH ='" + txt_MaSachChon.Text + "'";
                    conn.Update(strsql);
                    btn_ThemVaoHD.Enabled = true;
                    btn_ThemSach.Enabled = true;
                }
                else
                    MessageBox.Show("Không đủ số lượng sách!!!");
            }
            catch
            {
                MessageBox.Show("Đã chọn sách này!!!", "Thông báo");
            }
        }

        //Xử lý btn Chọn sách
        private void btn_ChonSach_Click(object sender, EventArgs e)
        {
            try
            {
                FrmThongTinSach frm = new FrmThongTinSach();
                frm.ShowDialog();
                //Lấy giá trị từ form Thông tin sách cho grp Kết quả form Hóa đơn
                txt_MaSachChon.Text = frm.layMaSach();
                txt_TenSachChon.Text = frm.layTenSach();
                txt_DonGia.Text = frm.layGiaSach();

                txt_SoLuong.Clear();
                txt_SoLuong.Focus();

                btn_ChonSach.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Đã chọn sách này!!", "Thông báo");
            }
        }

        //Xử lý txt số lượng
        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Không cho nhập chữ
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_SoLuong.Text.Trim().Length != 0)
                {
                    int soluong = Int32.Parse(txt_SoLuong.Text);
                    int dongia = Int32.Parse(txt_DonGia.Text);
                    txt_ThanhTien.Text = (soluong * dongia).ToString();
                }
                else
                    txt_ThanhTien.Text = "";
            }
            catch
            {
                MessageBox.Show("Mời bạn chọn sách!!");
            }
        }

        //Khi txt Thành tiền có giá trị btn Thêm CTHD sẽ hiện ra
        private void txt_ThanhTien_TextChanged(object sender, EventArgs e)
        {
            if (txt_ThanhTien.Text.Trim().Length != 0)
                btn_ThemCTHD.Enabled = true;
            else
                btn_ThemCTHD.Enabled = false;
        }
        
        //Xử lý btn Thêm vào hóa đơn
        private void btn_ThemVaoHD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Khách có mua thêm sách nữa không ??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                return; 
                //Yes là khách mua thêm sách
                //No là ko mua thêm và lập hóa đơn
            }
            try
            {
                string strsql = "UPDATE HOADON SET TONGGIATRI= " + txt_TongTienHD.Text + " WHERE SOHOADON= '" + txt_SoHD.Text + "'";
                conn.Update(strsql);
                MessageBox.Show("Thêm hóa đơn thành công !!","Thông báo");
                btn_InHD.Enabled = true;
                btn_ThemVaoHD.Enabled = false;
                btn_ThemSach.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Thêm hóa đơn thất bại !!", "Thông báo");
            }      
        }

        //Xử lý txt Số ĐT
        private void txt_SoDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length > 9)
            {
                //Số điện thoại 10 chỉ 10 chữ số
                this.errorProvider1.SetError(ctr, "Số điện thoại đã vượt 10 chữ số !!");
                e.Handled = true;
            }
            else
                this.errorProvider1.Clear();
        }

        private void btn_ThemSach_Click(object sender, EventArgs e)
        {
            //Khi bấm Thêm sách btn Chọn sách hiện lên
            btn_ChonSach.Enabled = true;
        }

        private void btn_InHD_Click(object sender, EventArgs e)
        {
            btn_InHD.Enabled = false;
            FrnRPHoaDon frmrpt = new FrnRPHoaDon(txt_SoHD.Text);
            frmrpt.ShowDialog();
        }

       

    }
}
