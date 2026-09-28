namespace C4_QuanLiDanhBa
{
    partial class FormDanhBa
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
            lstLienHe = new ListBox();
            lblTen = new Label();
            txtTen = new TextBox();
            lblSDT = new Label();
            txtSDT = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lstLienHe
            // 
            lstLienHe.Font = new Font("Segoe UI", 10F);
            lstLienHe.FormattingEnabled = true;
            lstLienHe.ItemHeight = 23;
            lstLienHe.Location = new Point(18, 18);
            lstLienHe.Name = "lstLienHe";
            lstLienHe.Size = new Size(335, 349);
            lstLienHe.TabIndex = 0;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Font = new Font("Segoe UI", 10F);
            lblTen.Location = new Point(370, 18);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(36, 23);
            lblTen.TabIndex = 1;
            lblTen.Text = "Tên";
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 10F);
            txtTen.Location = new Point(370, 44);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(275, 30);
            txtTen.TabIndex = 2;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Segoe UI", 10F);
            lblSDT.Location = new Point(370, 87);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(111, 23);
            lblSDT.TabIndex = 3;
            lblSDT.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI", 10F);
            txtSDT.Location = new Point(370, 113);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(275, 30);
            txtSDT.TabIndex = 4;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10F);
            btnThem.Location = new Point(530, 160);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(115, 34);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 10F);
            btnSua.Location = new Point(530, 204);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(115, 34);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10F);
            btnXoa.Location = new Point(530, 248);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(115, 34);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10F);
            btnThoat.Location = new Point(530, 333);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(115, 34);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // FormDanhBa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 386);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtSDT);
            Controls.Add(lblSDT);
            Controls.Add(txtTen);
            Controls.Add(lblTen);
            Controls.Add(lstLienHe);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormDanhBa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý danh bạ";
            FormClosing += FormDanhBa_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstLienHe;
        private Label lblTen;
        private TextBox txtTen;
        private Label lblSDT;
        private TextBox txtSDT;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
    }
}
