namespace QuanLiNhaSach
{
    partial class FrmHoaDonBanSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoaDonBanSach));
            this.dataGridViewCTHD = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txt_MaKhach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SoDT = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_TenKhach = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbo_MaNV = new System.Windows.Forms.ComboBox();
            this.btn_HoaDonMoi = new System.Windows.Forms.Button();
            this.btn_ChonSach = new System.Windows.Forms.Button();
            this.grpKetQua = new System.Windows.Forms.GroupBox();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_TenSachChon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_MaSachChon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_ThemCTHD = new System.Windows.Forms.Button();
            this.txt_NgayBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SoHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.grpCTHD = new System.Windows.Forms.GroupBox();
            this.btn_ThemSach = new System.Windows.Forms.Button();
            this.btn_ThemVaoHD = new System.Windows.Forms.Button();
            this.grpKhachHang = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_TongTienHD = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_InHD = new System.Windows.Forms.Button();
            this.cbo_HoaDon = new System.Windows.Forms.ComboBox();
            this.btnLoadHoaDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grpKetQua.SuspendLayout();
            this.grpCTHD.SuspendLayout();
            this.grpKhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCTHD
            // 
            this.dataGridViewCTHD.AllowUserToAddRows = false;
            this.dataGridViewCTHD.AllowUserToOrderColumns = true;
            this.dataGridViewCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCTHD.Location = new System.Drawing.Point(15, 29);
            this.dataGridViewCTHD.Name = "dataGridViewCTHD";
            this.dataGridViewCTHD.Size = new System.Drawing.Size(1029, 175);
            this.dataGridViewCTHD.TabIndex = 1;
            this.dataGridViewCTHD.Click += new System.EventHandler(this.dataGridViewCTHD_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "search.png");
            this.imageList1.Images.SetKeyName(1, "cart.png");
            this.imageList1.Images.SetKeyName(2, "phieuthu.png");
            this.imageList1.Images.SetKeyName(3, "ghi.png");
            this.imageList1.Images.SetKeyName(4, "cancel_f2.png");
            // 
            // txt_MaKhach
            // 
            this.txt_MaKhach.Location = new System.Drawing.Point(130, 24);
            this.txt_MaKhach.Name = "txt_MaKhach";
            this.txt_MaKhach.ReadOnly = true;
            this.txt_MaKhach.Size = new System.Drawing.Size(191, 30);
            this.txt_MaKhach.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã khách";
            // 
            // txt_SoDT
            // 
            this.txt_SoDT.Location = new System.Drawing.Point(432, 65);
            this.txt_SoDT.Name = "txt_SoDT";
            this.txt_SoDT.Size = new System.Drawing.Size(172, 30);
            this.txt_SoDT.TabIndex = 5;
            this.txt_SoDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoDT_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(350, 72);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 23);
            this.label18.TabIndex = 0;
            this.label18.Text = "SĐT";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(517, 28);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(56, 27);
            this.radNu.TabIndex = 4;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(432, 29);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(70, 27);
            this.radNam.TabIndex = 3;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(350, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 23);
            this.label16.TabIndex = 7;
            this.label16.Text = "Giới tính";
            // 
            // txt_TenKhach
            // 
            this.txt_TenKhach.Location = new System.Drawing.Point(130, 65);
            this.txt_TenKhach.Name = "txt_TenKhach";
            this.txt_TenKhach.Size = new System.Drawing.Size(191, 30);
            this.txt_TenKhach.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(122, 23);
            this.label17.TabIndex = 7;
            this.label17.Text = "Họ tên khách";
            // 
            // cbo_MaNV
            // 
            this.cbo_MaNV.FormattingEnabled = true;
            this.cbo_MaNV.Location = new System.Drawing.Point(470, 80);
            this.cbo_MaNV.Name = "cbo_MaNV";
            this.cbo_MaNV.Size = new System.Drawing.Size(182, 31);
            this.cbo_MaNV.TabIndex = 31;
            // 
            // btn_HoaDonMoi
            // 
            this.btn_HoaDonMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_HoaDonMoi.ImageIndex = 3;
            this.btn_HoaDonMoi.ImageList = this.imageList1;
            this.btn_HoaDonMoi.Location = new System.Drawing.Point(1176, 65);
            this.btn_HoaDonMoi.Name = "btn_HoaDonMoi";
            this.btn_HoaDonMoi.Size = new System.Drawing.Size(156, 59);
            this.btn_HoaDonMoi.TabIndex = 20;
            this.btn_HoaDonMoi.Text = "Hóa đơn mới";
            this.btn_HoaDonMoi.UseVisualStyleBackColor = true;
            this.btn_HoaDonMoi.Click += new System.EventHandler(this.btn_HoaDonMoi_Click);
            // 
            // btn_ChonSach
            // 
            this.btn_ChonSach.Location = new System.Drawing.Point(520, 259);
            this.btn_ChonSach.Name = "btn_ChonSach";
            this.btn_ChonSach.Size = new System.Drawing.Size(105, 62);
            this.btn_ChonSach.TabIndex = 18;
            this.btn_ChonSach.Text = "Chọn sách";
            this.btn_ChonSach.UseVisualStyleBackColor = true;
            this.btn_ChonSach.Click += new System.EventHandler(this.btn_ChonSach_Click);
            // 
            // grpKetQua
            // 
            this.grpKetQua.Controls.Add(this.txt_ThanhTien);
            this.grpKetQua.Controls.Add(this.label1);
            this.grpKetQua.Controls.Add(this.txt_SoLuong);
            this.grpKetQua.Controls.Add(this.label11);
            this.grpKetQua.Controls.Add(this.txt_TenSachChon);
            this.grpKetQua.Controls.Add(this.label10);
            this.grpKetQua.Controls.Add(this.txt_DonGia);
            this.grpKetQua.Controls.Add(this.label9);
            this.grpKetQua.Controls.Add(this.txt_MaSachChon);
            this.grpKetQua.Controls.Add(this.label8);
            this.grpKetQua.Controls.Add(this.btn_ThemCTHD);
            this.grpKetQua.Location = new System.Drawing.Point(676, 134);
            this.grpKetQua.Name = "grpKetQua";
            this.grpKetQua.Size = new System.Drawing.Size(656, 187);
            this.grpKetQua.TabIndex = 19;
            this.grpKetQua.TabStop = false;
            this.grpKetQua.Text = "Kết quả chọn sách";
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Location = new System.Drawing.Point(112, 115);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.ReadOnly = true;
            this.txt_ThanhTien.Size = new System.Drawing.Size(195, 30);
            this.txt_ThanhTien.TabIndex = 8;
            this.txt_ThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_ThanhTien.TextChanged += new System.EventHandler(this.txt_ThanhTien_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thành tiền";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(469, 69);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(172, 30);
            this.txt_SoLuong.TabIndex = 1;
            this.txt_SoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_SoLuong.TextChanged += new System.EventHandler(this.txt_SoLuong_TextChanged);
            this.txt_SoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoLuong_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(339, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 23);
            this.label11.TabIndex = 6;
            this.label11.Text = "Số lượng mua";
            // 
            // txt_TenSachChon
            // 
            this.txt_TenSachChon.Location = new System.Drawing.Point(112, 69);
            this.txt_TenSachChon.Name = "txt_TenSachChon";
            this.txt_TenSachChon.ReadOnly = true;
            this.txt_TenSachChon.Size = new System.Drawing.Size(195, 30);
            this.txt_TenSachChon.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "Tên sách";
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Location = new System.Drawing.Point(469, 27);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.ReadOnly = true;
            this.txt_DonGia.Size = new System.Drawing.Size(172, 30);
            this.txt_DonGia.TabIndex = 4;
            this.txt_DonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(339, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 23);
            this.label9.TabIndex = 5;
            this.label9.Text = "Đơn giá";
            // 
            // txt_MaSachChon
            // 
            this.txt_MaSachChon.Location = new System.Drawing.Point(112, 24);
            this.txt_MaSachChon.Name = "txt_MaSachChon";
            this.txt_MaSachChon.ReadOnly = true;
            this.txt_MaSachChon.Size = new System.Drawing.Size(195, 30);
            this.txt_MaSachChon.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "Mã sách";
            // 
            // btn_ThemCTHD
            // 
            this.btn_ThemCTHD.Location = new System.Drawing.Point(510, 111);
            this.btn_ThemCTHD.Name = "btn_ThemCTHD";
            this.btn_ThemCTHD.Size = new System.Drawing.Size(131, 70);
            this.btn_ThemCTHD.TabIndex = 17;
            this.btn_ThemCTHD.Text = "Thêm vào CTHD";
            this.btn_ThemCTHD.UseVisualStyleBackColor = true;
            this.btn_ThemCTHD.Click += new System.EventHandler(this.btn_ThemCTHD_Click);
            // 
            // txt_NgayBan
            // 
            this.txt_NgayBan.Location = new System.Drawing.Point(867, 81);
            this.txt_NgayBan.Name = "txt_NgayBan";
            this.txt_NgayBan.ReadOnly = true;
            this.txt_NgayBan.Size = new System.Drawing.Size(201, 30);
            this.txt_NgayBan.TabIndex = 25;
            this.txt_NgayBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(702, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ngày lập hóa đơn";
            // 
            // txt_SoHD
            // 
            this.txt_SoHD.Location = new System.Drawing.Point(124, 81);
            this.txt_SoHD.Name = "txt_SoHD";
            this.txt_SoHD.ReadOnly = true;
            this.txt_SoHD.Size = new System.Drawing.Size(218, 30);
            this.txt_SoHD.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Số hóa đơn";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Blue;
            this.lblTieuDe.Location = new System.Drawing.Point(574, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(370, 41);
            this.lblTieuDe.TabIndex = 30;
            this.lblTieuDe.Text = "HÓA ĐƠN BÁN SÁCH";
            // 
            // grpCTHD
            // 
            this.grpCTHD.Controls.Add(this.btn_ThemSach);
            this.grpCTHD.Controls.Add(this.dataGridViewCTHD);
            this.grpCTHD.Controls.Add(this.btn_InHD);
            this.grpCTHD.Controls.Add(this.btn_ThemVaoHD);
            this.grpCTHD.Location = new System.Drawing.Point(12, 327);
            this.grpCTHD.Name = "grpCTHD";
            this.grpCTHD.Size = new System.Drawing.Size(1320, 218);
            this.grpCTHD.TabIndex = 21;
            this.grpCTHD.TabStop = false;
            this.grpCTHD.Text = "Chi tiết hóa đơn";
            // 
            // btn_ThemSach
            // 
            this.btn_ThemSach.Location = new System.Drawing.Point(1064, 38);
            this.btn_ThemSach.Name = "btn_ThemSach";
            this.btn_ThemSach.Size = new System.Drawing.Size(113, 69);
            this.btn_ThemSach.TabIndex = 19;
            this.btn_ThemSach.Text = "Thêm sách";
            this.btn_ThemSach.UseVisualStyleBackColor = true;
            this.btn_ThemSach.Click += new System.EventHandler(this.btn_ThemSach_Click);
            // 
            // btn_ThemVaoHD
            // 
            this.btn_ThemVaoHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemVaoHD.ImageIndex = 2;
            this.btn_ThemVaoHD.ImageList = this.imageList1;
            this.btn_ThemVaoHD.Location = new System.Drawing.Point(1064, 125);
            this.btn_ThemVaoHD.Name = "btn_ThemVaoHD";
            this.btn_ThemVaoHD.Size = new System.Drawing.Size(113, 69);
            this.btn_ThemVaoHD.TabIndex = 16;
            this.btn_ThemVaoHD.Text = "Thêm vào hóa đơn";
            this.btn_ThemVaoHD.UseVisualStyleBackColor = true;
            this.btn_ThemVaoHD.Click += new System.EventHandler(this.btn_ThemVaoHD_Click);
            // 
            // grpKhachHang
            // 
            this.grpKhachHang.Controls.Add(this.txt_MaKhach);
            this.grpKhachHang.Controls.Add(this.label4);
            this.grpKhachHang.Controls.Add(this.txt_SoDT);
            this.grpKhachHang.Controls.Add(this.label18);
            this.grpKhachHang.Controls.Add(this.radNu);
            this.grpKhachHang.Controls.Add(this.radNam);
            this.grpKhachHang.Controls.Add(this.label16);
            this.grpKhachHang.Controls.Add(this.txt_TenKhach);
            this.grpKhachHang.Controls.Add(this.label17);
            this.grpKhachHang.Location = new System.Drawing.Point(12, 134);
            this.grpKhachHang.Name = "grpKhachHang";
            this.grpKhachHang.Size = new System.Drawing.Size(613, 119);
            this.grpKhachHang.TabIndex = 15;
            this.grpKhachHang.TabStop = false;
            this.grpKhachHang.Text = "Thông tin khách hàng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(399, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 23);
            this.label13.TabIndex = 27;
            this.label13.Text = "Mã NV";
            // 
            // txt_TongTienHD
            // 
            this.txt_TongTienHD.Location = new System.Drawing.Point(658, 563);
            this.txt_TongTienHD.Name = "txt_TongTienHD";
            this.txt_TongTienHD.ReadOnly = true;
            this.txt_TongTienHD.Size = new System.Drawing.Size(214, 30);
            this.txt_TongTienHD.TabIndex = 23;
            this.txt_TongTienHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(487, 566);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 23);
            this.label12.TabIndex = 24;
            this.label12.Text = "Tổng tiền hóa đơn";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.ImageIndex = 4;
            this.btn_Thoat.ImageList = this.imageList1;
            this.btn_Thoat.Location = new System.Drawing.Point(1202, 551);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(130, 52);
            this.btn_Thoat.TabIndex = 22;
            this.btn_Thoat.Text = "  Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_InHD
            // 
            this.btn_InHD.Location = new System.Drawing.Point(1193, 125);
            this.btn_InHD.Name = "btn_InHD";
            this.btn_InHD.Size = new System.Drawing.Size(112, 69);
            this.btn_InHD.TabIndex = 32;
            this.btn_InHD.Text = "In hóa đơn";
            this.btn_InHD.UseVisualStyleBackColor = true;
            this.btn_InHD.Click += new System.EventHandler(this.btn_InHD_Click);
            // 
            // cbo_HoaDon
            // 
            this.cbo_HoaDon.FormattingEnabled = true;
            this.cbo_HoaDon.Location = new System.Drawing.Point(142, 276);
            this.cbo_HoaDon.Name = "cbo_HoaDon";
            this.cbo_HoaDon.Size = new System.Drawing.Size(191, 31);
            this.cbo_HoaDon.TabIndex = 33;
            this.cbo_HoaDon.SelectedIndexChanged += new System.EventHandler(this.cbo_HoaDon_SelectedIndexChanged);
            // 
            // btnLoadHoaDon
            // 
            this.btnLoadHoaDon.Location = new System.Drawing.Point(16, 259);
            this.btnLoadHoaDon.Name = "btnLoadHoaDon";
            this.btnLoadHoaDon.Size = new System.Drawing.Size(112, 57);
            this.btnLoadHoaDon.TabIndex = 20;
            this.btnLoadHoaDon.Text = "Load các hóa đơn";
            this.btnLoadHoaDon.UseVisualStyleBackColor = true;
            this.btnLoadHoaDon.Click += new System.EventHandler(this.btnLoadHoaDon_Click);
            // 
            // FrmHoaDonBanSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1352, 610);
            this.Controls.Add(this.btnLoadHoaDon);
            this.Controls.Add(this.cbo_HoaDon);
            this.Controls.Add(this.cbo_MaNV);
            this.Controls.Add(this.btn_HoaDonMoi);
            this.Controls.Add(this.btn_ChonSach);
            this.Controls.Add(this.grpKetQua);
            this.Controls.Add(this.txt_NgayBan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_SoHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.grpCTHD);
            this.Controls.Add(this.grpKhachHang);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_TongTienHD);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_Thoat);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHoaDonBanSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn bán sách";
            this.Load += new System.EventHandler(this.FrmHoaDonBanSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grpKetQua.ResumeLayout(false);
            this.grpKetQua.PerformLayout();
            this.grpCTHD.ResumeLayout(false);
            this.grpKhachHang.ResumeLayout(false);
            this.grpKhachHang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCTHD;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbo_MaNV;
        private System.Windows.Forms.Button btn_HoaDonMoi;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_ChonSach;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_NgayBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpCTHD;
        private System.Windows.Forms.Button btn_ThemVaoHD;
        private System.Windows.Forms.GroupBox grpKhachHang;
        private System.Windows.Forms.TextBox txt_MaKhach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SoDT;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_TenKhach;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_TongTienHD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_ThemCTHD;
        private System.Windows.Forms.Button btn_ThemSach;
        public System.Windows.Forms.TextBox txt_TenSachChon;
        public System.Windows.Forms.TextBox txt_DonGia;
        public System.Windows.Forms.TextBox txt_MaSachChon;
        public System.Windows.Forms.TextBox txt_SoLuong;
        public System.Windows.Forms.GroupBox grpKetQua;
        private System.Windows.Forms.Button btn_InHD;
        public System.Windows.Forms.TextBox txt_SoHD;
        private System.Windows.Forms.Button btnLoadHoaDon;
        private System.Windows.Forms.ComboBox cbo_HoaDon;

    }
}