namespace C5_VeXemPhim
{
    partial class FormBanVe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTenKhach = new Label();
            txtTenKhach = new TextBox();
            lblPhim = new Label();
            cboPhim = new ComboBox();
            lblSuatChieu = new Label();
            cboSuatChieu = new ComboBox();
            lblGheDaChon = new Label();
            txtGheDaChon = new TextBox();
            btnChonGhe = new Button();
            btnDatVe = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // lblTenKhach
            // 
            lblTenKhach.AutoSize = true;
            lblTenKhach.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTenKhach.Location = new Point(25, 20);
            lblTenKhach.Name = "lblTenKhach";
            lblTenKhach.Size = new Size(74, 19);
            lblTenKhach.TabIndex = 0;
            lblTenKhach.Text = "Tên khách:";
            // 
            // txtTenKhach
            // 
            txtTenKhach.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenKhach.Location = new Point(25, 45);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(250, 25);
            txtTenKhach.TabIndex = 1;
            // 
            // lblPhim
            // 
            lblPhim.AutoSize = true;
            lblPhim.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhim.Location = new Point(25, 80);
            lblPhim.Name = "lblPhim";
            lblPhim.Size = new Size(43, 19);
            lblPhim.TabIndex = 2;
            lblPhim.Text = "Phim:";
            // 
            // cboPhim
            // 
            cboPhim.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhim.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboPhim.FormattingEnabled = true;
            cboPhim.Location = new Point(25, 105);
            cboPhim.Name = "cboPhim";
            cboPhim.Size = new Size(250, 25);
            cboPhim.TabIndex = 3;
            // 
            // lblSuatChieu
            // 
            lblSuatChieu.AutoSize = true;
            lblSuatChieu.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSuatChieu.Location = new Point(25, 140);
            lblSuatChieu.Name = "lblSuatChieu";
            lblSuatChieu.Size = new Size(76, 19);
            lblSuatChieu.TabIndex = 4;
            lblSuatChieu.Text = "Suất chiếu:";
            // 
            // cboSuatChieu
            // 
            cboSuatChieu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSuatChieu.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboSuatChieu.FormattingEnabled = true;
            cboSuatChieu.Location = new Point(25, 165);
            cboSuatChieu.Name = "cboSuatChieu";
            cboSuatChieu.Size = new Size(250, 25);
            cboSuatChieu.TabIndex = 5;
            // 
            // lblGheDaChon
            // 
            lblGheDaChon.AutoSize = true;
            lblGheDaChon.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblGheDaChon.Location = new Point(25, 200);
            lblGheDaChon.Name = "lblGheDaChon";
            lblGheDaChon.Size = new Size(91, 19);
            lblGheDaChon.TabIndex = 6;
            lblGheDaChon.Text = "Ghế đã chọn:";
            // 
            // txtGheDaChon
            // 
            txtGheDaChon.BackColor = Color.White;
            txtGheDaChon.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtGheDaChon.Location = new Point(25, 225);
            txtGheDaChon.Name = "txtGheDaChon";
            txtGheDaChon.ReadOnly = true;
            txtGheDaChon.Size = new Size(250, 25);
            txtGheDaChon.TabIndex = 7;
            // 
            // btnChonGhe
            // 
            btnChonGhe.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnChonGhe.Location = new Point(90, 265);
            btnChonGhe.Name = "btnChonGhe";
            btnChonGhe.Size = new Size(90, 32);
            btnChonGhe.TabIndex = 8;
            btnChonGhe.Text = "Chọn ghế";
            btnChonGhe.UseVisualStyleBackColor = true;
            btnChonGhe.Click += btnChonGhe_Click;
            // 
            // btnDatVe
            // 
            btnDatVe.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnDatVe.Location = new Point(190, 265);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(80, 32);
            btnDatVe.TabIndex = 9;
            btnDatVe.Text = "Đặt vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.Location = new Point(280, 265);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(70, 32);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // FormBanVe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 320);
            Controls.Add(btnHuy);
            Controls.Add(btnDatVe);
            Controls.Add(btnChonGhe);
            Controls.Add(txtGheDaChon);
            Controls.Add(lblGheDaChon);
            Controls.Add(cboSuatChieu);
            Controls.Add(lblSuatChieu);
            Controls.Add(cboPhim);
            Controls.Add(lblPhim);
            Controls.Add(txtTenKhach);
            Controls.Add(lblTenKhach);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormBanVe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bán vé xem phim";
            Load += FormBanVe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTenKhach;
        private TextBox txtTenKhach;
        private Label lblPhim;
        private ComboBox cboPhim;
        private Label lblSuatChieu;
        private ComboBox cboSuatChieu;
        private Label lblGheDaChon;
        private TextBox txtGheDaChon;
        private Button btnChonGhe;
        private Button btnDatVe;
        private Button btnHuy;
    }
}
