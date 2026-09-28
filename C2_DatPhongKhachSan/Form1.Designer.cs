namespace C2_DatPhongKhachSan
{
    partial class FormDatPhong
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
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblCCCD = new Label();
            txtCCCD = new TextBox();
            lblNgayNhan = new Label();
            txtNgayNhan = new TextBox();
            lblNgayTra = new Label();
            txtNgayTra = new TextBox();
            lblSoNguoiLon = new Label();
            txtSoNguoiLon = new TextBox();
            lblSoTreEm = new Label();
            txtSoTreEm = new TextBox();
            btnDatPhong = new Button();
            errorProvider1 = new ErrorProvider(components);
            errorProviderDung = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDung).BeginInit();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(70, 20);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(54, 20);
            lblHoTen.TabIndex = 7;
            lblHoTen.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(70, 45);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(380, 27);
            txtHoTen.TabIndex = 0;
            txtHoTen.Validating += txtHoTen_Validating;
            txtHoTen.Validated += TextBox_Validated;
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.Location = new Point(70, 85);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(68, 20);
            lblCCCD.TabIndex = 8;
            lblCCCD.Text = "Số CCCD";
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(70, 110);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(380, 27);
            txtCCCD.TabIndex = 1;
            txtCCCD.Validating += txtCCCD_Validating;
            txtCCCD.Validated += TextBox_Validated;
            // 
            // lblNgayNhan
            // 
            lblNgayNhan.AutoSize = true;
            lblNgayNhan.Location = new Point(70, 150);
            lblNgayNhan.Name = "lblNgayNhan";
            lblNgayNhan.Size = new Size(125, 20);
            lblNgayNhan.TabIndex = 9;
            lblNgayNhan.Text = "Ngày nhận phòng";
            // 
            // txtNgayNhan
            // 
            txtNgayNhan.Location = new Point(70, 175);
            txtNgayNhan.Name = "txtNgayNhan";
            txtNgayNhan.Size = new Size(380, 27);
            txtNgayNhan.TabIndex = 2;
            txtNgayNhan.Validating += txtNgayNhan_Validating;
            txtNgayNhan.Validated += TextBox_Validated;
            // 
            // lblNgayTra
            // 
            lblNgayTra.AutoSize = true;
            lblNgayTra.Location = new Point(70, 215);
            lblNgayTra.Name = "lblNgayTra";
            lblNgayTra.Size = new Size(107, 20);
            lblNgayTra.TabIndex = 10;
            lblNgayTra.Text = "Ngày trả phòng";
            // 
            // txtNgayTra
            // 
            txtNgayTra.Location = new Point(70, 240);
            txtNgayTra.Name = "txtNgayTra";
            txtNgayTra.Size = new Size(380, 27);
            txtNgayTra.TabIndex = 3;
            txtNgayTra.Validating += txtNgayTra_Validating;
            txtNgayTra.Validated += TextBox_Validated;
            // 
            // lblSoNguoiLon
            // 
            lblSoNguoiLon.AutoSize = true;
            lblSoNguoiLon.Location = new Point(70, 280);
            lblSoNguoiLon.Name = "lblSoNguoiLon";
            lblSoNguoiLon.Size = new Size(95, 20);
            lblSoNguoiLon.TabIndex = 11;
            lblSoNguoiLon.Text = "Số người lớn";
            // 
            // txtSoNguoiLon
            // 
            txtSoNguoiLon.Location = new Point(70, 305);
            txtSoNguoiLon.Name = "txtSoNguoiLon";
            txtSoNguoiLon.Size = new Size(380, 27);
            txtSoNguoiLon.TabIndex = 4;
            txtSoNguoiLon.Validating += txtSoNguoiLon_Validating;
            txtSoNguoiLon.Validated += TextBox_Validated;
            // 
            // lblSoTreEm
            // 
            lblSoTreEm.AutoSize = true;
            lblSoTreEm.Location = new Point(70, 345);
            lblSoTreEm.Name = "lblSoTreEm";
            lblSoTreEm.Size = new Size(74, 20);
            lblSoTreEm.TabIndex = 12;
            lblSoTreEm.Text = "Số trẻ em";
            // 
            // txtSoTreEm
            // 
            txtSoTreEm.Location = new Point(70, 370);
            txtSoTreEm.Name = "txtSoTreEm";
            txtSoTreEm.Size = new Size(380, 27);
            txtSoTreEm.TabIndex = 5;
            txtSoTreEm.Validating += txtSoTreEm_Validating;
            txtSoTreEm.Validated += TextBox_Validated;
            // 
            // btnDatPhong
            // 
            btnDatPhong.BackColor = Color.FromArgb(0, 120, 215);
            btnDatPhong.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            btnDatPhong.ForeColor = Color.White;
            btnDatPhong.Location = new Point(70, 420);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(380, 38);
            btnDatPhong.TabIndex = 6;
            btnDatPhong.Text = "Đặt Phòng";
            btnDatPhong.UseVisualStyleBackColor = false;
            btnDatPhong.Click += btnDatPhong_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProviderDung
            // 
            errorProviderDung.ContainerControl = this;
            // 
            // FormDatPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 480);
            Controls.Add(btnDatPhong);
            Controls.Add(txtSoTreEm);
            Controls.Add(lblSoTreEm);
            Controls.Add(txtSoNguoiLon);
            Controls.Add(lblSoNguoiLon);
            Controls.Add(txtNgayTra);
            Controls.Add(lblNgayTra);
            Controls.Add(txtNgayNhan);
            Controls.Add(lblNgayNhan);
            Controls.Add(txtCCCD);
            Controls.Add(lblCCCD);
            Controls.Add(txtHoTen);
            Controls.Add(lblHoTen);
            Name = "FormDatPhong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đặt phòng khách sạn";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDung).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblCCCD;
        private TextBox txtCCCD;
        private Label lblNgayNhan;
        private TextBox txtNgayNhan;
        private Label lblNgayTra;
        private TextBox txtNgayTra;
        private Label lblSoNguoiLon;
        private TextBox txtSoNguoiLon;
        private Label lblSoTreEm;
        private TextBox txtSoTreEm;
        private Button btnDatPhong;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProviderDung;
    }
}
