namespace C3_NhapDiemHS
{
    partial class FormNhapDiem
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
            lblMaHS = new Label();
            lblHoTen = new Label();
            lblToan = new Label();
            lblVan = new Label();
            lblAnh = new Label();
            txtMaHS = new TextBox();
            txtHoTen = new TextBox();
            txtToan = new TextBox();
            txtVan = new TextBox();
            txtAnh = new TextBox();
            btnLuu = new Button();
            btnXoaTrang = new Button();
            lstDanhSach = new ListBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblMaHS
            // 
            lblMaHS.AutoSize = true;
            lblMaHS.Location = new Point(20, 18);
            lblMaHS.Name = "lblMaHS";
            lblMaHS.Size = new Size(58, 21);
            lblMaHS.TabIndex = 10;
            lblMaHS.TabStop = false;
            lblMaHS.Text = "Mã HS";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(175, 18);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(56, 21);
            lblHoTen.TabIndex = 11;
            lblHoTen.TabStop = false;
            lblHoTen.Text = "Họ tên";
            // 
            // lblToan
            // 
            lblToan.AutoSize = true;
            lblToan.Location = new Point(345, 18);
            lblToan.Name = "lblToan";
            lblToan.Size = new Size(82, 21);
            lblToan.TabIndex = 12;
            lblToan.TabStop = false;
            lblToan.Text = "Điểm Toán";
            // 
            // lblVan
            // 
            lblVan.AutoSize = true;
            lblVan.Location = new Point(495, 18);
            lblVan.Name = "lblVan";
            lblVan.Size = new Size(77, 21);
            lblVan.TabIndex = 13;
            lblVan.TabStop = false;
            lblVan.Text = "Điểm Văn";
            // 
            // lblAnh
            // 
            lblAnh.AutoSize = true;
            lblAnh.Location = new Point(645, 18);
            lblAnh.Name = "lblAnh";
            lblAnh.Size = new Size(78, 21);
            lblAnh.TabIndex = 14;
            lblAnh.TabStop = false;
            lblAnh.Text = "Điểm Anh";
            // 
            // txtMaHS
            // 
            txtMaHS.Location = new Point(20, 48);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(130, 29);
            txtMaHS.TabIndex = 0;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(175, 48);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(145, 29);
            txtHoTen.TabIndex = 1;
            // 
            // txtToan
            // 
            txtToan.Location = new Point(345, 48);
            txtToan.Name = "txtToan";
            txtToan.Size = new Size(125, 29);
            txtToan.TabIndex = 2;
            txtToan.Enter += txtDiem_Enter;
            // 
            // txtVan
            // 
            txtVan.Location = new Point(495, 48);
            txtVan.Name = "txtVan";
            txtVan.Size = new Size(125, 29);
            txtVan.TabIndex = 3;
            txtVan.Enter += txtDiem_Enter;
            // 
            // txtAnh
            // 
            txtAnh.Location = new Point(645, 48);
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(125, 29);
            txtAnh.TabIndex = 4;
            txtAnh.Enter += txtDiem_Enter;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(76, 175, 80);
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.FlatAppearance.BorderColor = Color.DarkGray;
            btnLuu.Location = new Point(20, 95);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(115, 38);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.BackColor = Color.FromArgb(204, 204, 204);
            btnXoaTrang.FlatStyle = FlatStyle.Flat;
            btnXoaTrang.FlatAppearance.BorderColor = Color.DarkGray;
            btnXoaTrang.Location = new Point(145, 95);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(130, 38);
            btnXoaTrang.TabIndex = 6;
            btnXoaTrang.Text = "Xóa Trắng";
            btnXoaTrang.UseVisualStyleBackColor = false;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // lstDanhSach
            // 
            lstDanhSach.FormattingEnabled = true;
            lstDanhSach.ItemHeight = 21;
            lstDanhSach.Location = new Point(20, 148);
            lstDanhSach.Name = "lstDanhSach";
            lstDanhSach.Size = new Size(765, 277);
            lstDanhSach.TabIndex = 7;
            lstDanhSach.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormNhapDiem
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 445);
            Controls.Add(lblMaHS);
            Controls.Add(lblHoTen);
            Controls.Add(lblToan);
            Controls.Add(lblVan);
            Controls.Add(lblAnh);
            Controls.Add(txtMaHS);
            Controls.Add(txtHoTen);
            Controls.Add(txtToan);
            Controls.Add(txtVan);
            Controls.Add(txtAnh);
            Controls.Add(btnLuu);
            Controls.Add(btnXoaTrang);
            Controls.Add(lstDanhSach);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormNhapDiem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhập điểm học sinh";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaHS;
        private Label lblHoTen;
        private Label lblToan;
        private Label lblVan;
        private Label lblAnh;
        private TextBox txtMaHS;
        private TextBox txtHoTen;
        private TextBox txtToan;
        private TextBox txtVan;
        private TextBox txtAnh;
        private Button btnLuu;
        private Button btnXoaTrang;
        private ListBox lstDanhSach;
        private ErrorProvider errorProvider1;
    }
}
