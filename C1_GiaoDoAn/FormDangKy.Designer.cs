namespace C1_GiaoDoAn
{
    partial class FormDangKy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblDangKi = new Label();
            lblVuiLong = new Label();
            lblHoTen = new Label();
            lblSoDienThoai = new Label();
            lblEmail = new Label();
            lblMatKhau = new Label();
            lblXacThucMatKhau = new Label();
            txtHoTen = new TextBox();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            txtMatKhau = new TextBox();
            txtXacNhanMK = new TextBox();
            btnDangKy = new Button();
            btnHuy = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblDangKi
            // 
            lblDangKi.AutoSize = true;
            lblDangKi.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblDangKi.Location = new Point(40, 21);
            lblDangKi.Name = "lblDangKi";
            lblDangKi.Size = new Size(273, 35);
            lblDangKi.TabIndex = 0;
            lblDangKi.Text = "Đăng kí tài khoản mới";
            // 
            // lblVuiLong
            // 
            lblVuiLong.AutoSize = true;
            lblVuiLong.Location = new Point(40, 70);
            lblVuiLong.Name = "lblVuiLong";
            lblVuiLong.Size = new Size(214, 20);
            lblVuiLong.TabIndex = 1;
            lblVuiLong.Text = "Vui lòng nhập đầy đủ thông tin";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(161, 121);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(54, 20);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ tên";
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Location = new Point(118, 165);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(97, 20);
            lblSoDienThoai.TabIndex = 3;
            lblSoDienThoai.Text = "Số điện thoại";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(169, 212);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new Point(145, 253);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(70, 20);
            lblMatKhau.TabIndex = 5;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // lblXacThucMatKhau
            // 
            lblXacThucMatKhau.AutoSize = true;
            lblXacThucMatKhau.Location = new Point(82, 297);
            lblXacThucMatKhau.Name = "lblXacThucMatKhau";
            lblXacThucMatKhau.Size = new Size(134, 20);
            lblXacThucMatKhau.TabIndex = 6;
            lblXacThucMatKhau.Text = "Xác nhận mật khẩu";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(236, 124);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(231, 27);
            txtHoTen.TabIndex = 7;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(236, 168);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(231, 27);
            txtSDT.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(236, 212);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(231, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(236, 254);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(231, 27);
            txtMatKhau.TabIndex = 10;
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Location = new Point(236, 295);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.PasswordChar = '*';
            txtXacNhanMK.Size = new Size(231, 27);
            txtXacNhanMK.TabIndex = 11;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.Blue;
            btnDangKy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDangKy.ForeColor = SystemColors.ButtonHighlight;
            btnDangKy.Location = new Point(169, 372);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(94, 29);
            btnDangKy.TabIndex = 12;
            btnDangKy.Text = "Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(311, 372);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 13;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormDangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 419);
            Controls.Add(btnHuy);
            Controls.Add(btnDangKy);
            Controls.Add(txtXacNhanMK);
            Controls.Add(txtMatKhau);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtHoTen);
            Controls.Add(lblXacThucMatKhau);
            Controls.Add(lblMatKhau);
            Controls.Add(lblEmail);
            Controls.Add(lblSoDienThoai);
            Controls.Add(lblHoTen);
            Controls.Add(lblVuiLong);
            Controls.Add(lblDangKi);
            Name = "FormDangKy";
            Text = "Đăng ký tài khoản";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDangKi;
        private Label lblVuiLong;
        private Label lblHoTen;
        private Label lblSoDienThoai;
        private Label lblEmail;
        private Label lblMatKhau;
        private Label lblXacThucMatKhau;
        private TextBox txtHoTen;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private TextBox txtMatKhau;
        private TextBox txtXacNhanMK;
        private Button btnDangKy;
        private Button btnHuy;
        private ErrorProvider errorProvider1;
    }
}
