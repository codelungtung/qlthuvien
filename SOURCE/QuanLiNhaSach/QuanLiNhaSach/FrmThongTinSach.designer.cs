namespace QuanLiNhaSach
{
    partial class FrmThongTinSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongTinSach));
            this.cbo_LoaiSach = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_TenTacGia = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_TenNhaXB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.imglstChonSach = new System.Windows.Forms.ImageList(this.components);
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimSach = new System.Windows.Forms.Button();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewSach = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTieuDe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSach)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_LoaiSach
            // 
            this.cbo_LoaiSach.FormattingEnabled = true;
            this.cbo_LoaiSach.Location = new System.Drawing.Point(331, 115);
            this.cbo_LoaiSach.Name = "cbo_LoaiSach";
            this.cbo_LoaiSach.Size = new System.Drawing.Size(121, 31);
            this.cbo_LoaiSach.TabIndex = 24;
            this.cbo_LoaiSach.SelectedIndexChanged += new System.EventHandler(this.cbo_LoaiSach_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 23;
            this.label7.Text = "Thể loại";
            // 
            // cbo_TenTacGia
            // 
            this.cbo_TenTacGia.FormattingEnabled = true;
            this.cbo_TenTacGia.Location = new System.Drawing.Point(102, 112);
            this.cbo_TenTacGia.Name = "cbo_TenTacGia";
            this.cbo_TenTacGia.Size = new System.Drawing.Size(133, 31);
            this.cbo_TenTacGia.TabIndex = 22;
            this.cbo_TenTacGia.SelectedIndexChanged += new System.EventHandler(this.cbo_TenTacGia_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Tác giả";
            // 
            // cbo_TenNhaXB
            // 
            this.cbo_TenNhaXB.FormattingEnabled = true;
            this.cbo_TenNhaXB.Location = new System.Drawing.Point(644, 115);
            this.cbo_TenNhaXB.Name = "cbo_TenNhaXB";
            this.cbo_TenNhaXB.Size = new System.Drawing.Size(135, 31);
            this.cbo_TenNhaXB.TabIndex = 20;
            this.cbo_TenNhaXB.SelectedIndexChanged += new System.EventHandler(this.cbo_TenNhaXB_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nhà xuất bản";
            // 
            // btnChon
            // 
            this.btnChon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChon.ImageIndex = 2;
            this.btnChon.ImageList = this.imglstChonSach;
            this.btnChon.Location = new System.Drawing.Point(719, 365);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(104, 37);
            this.btnChon.TabIndex = 18;
            this.btnChon.Text = "   Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // imglstChonSach
            // 
            this.imglstChonSach.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstChonSach.ImageStream")));
            this.imglstChonSach.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstChonSach.Images.SetKeyName(0, "search.png");
            this.imglstChonSach.Images.SetKeyName(1, "clear.png");
            this.imglstChonSach.Images.SetKeyName(2, "if_shoping_cart_filled_82973.png");
            this.imglstChonSach.Images.SetKeyName(3, "undo.JPG");
            // 
            // btnXoa
            // 
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.ImageIndex = 1;
            this.btnXoa.ImageList = this.imglstChonSach;
            this.btnXoa.Location = new System.Drawing.Point(885, 114);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 31);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "  Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimSach
            // 
            this.btnTimSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimSach.ImageIndex = 0;
            this.btnTimSach.ImageList = this.imglstChonSach;
            this.btnTimSach.Location = new System.Drawing.Point(885, 71);
            this.btnTimSach.Name = "btnTimSach";
            this.btnTimSach.Size = new System.Drawing.Size(102, 30);
            this.btnTimSach.TabIndex = 16;
            this.btnTimSach.Text = "Tìm";
            this.btnTimSach.UseVisualStyleBackColor = true;
            this.btnTimSach.Click += new System.EventHandler(this.btnTimSach_Click);
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(102, 73);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(677, 30);
            this.txtTenSach.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tên sách";
            // 
            // dataGridViewSach
            // 
            this.dataGridViewSach.AllowUserToAddRows = false;
            this.dataGridViewSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSach.Location = new System.Drawing.Point(24, 167);
            this.dataGridViewSach.Name = "dataGridViewSach";
            this.dataGridViewSach.Size = new System.Drawing.Size(963, 188);
            this.dataGridViewSach.TabIndex = 25;
            this.dataGridViewSach.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.ImageIndex = 3;
            this.btnThoat.ImageList = this.imglstChonSach;
            this.btnThoat.Location = new System.Drawing.Point(879, 365);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(108, 37);
            this.btnThoat.TabIndex = 27;
            this.btnThoat.Text = "  Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Blue;
            this.lblTieuDe.Location = new System.Drawing.Point(376, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(319, 41);
            this.lblTieuDe.TabIndex = 31;
            this.lblTieuDe.Text = "THÔNG TIN SÁCH";
            // 
            // FrmThongTinSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1012, 411);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dataGridViewSach);
            this.Controls.Add(this.cbo_LoaiSach);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbo_TenTacGia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbo_TenNhaXB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTimSach);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmThongTinSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn sách";
            this.Load += new System.EventHandler(this.FrmThongTinSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_LoaiSach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_TenTacGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_TenNhaXB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimSach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewSach;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ImageList imglstChonSach;
        private System.Windows.Forms.Label lblTieuDe;
    }
}