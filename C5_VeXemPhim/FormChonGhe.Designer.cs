namespace C5_VeXemPhim
{
    partial class FormChonGhe
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
            lstGhe = new ListBox();
            lblGheDaChon = new Label();
            btnXacNhan = new Button();
            btnBoQua = new Button();
            SuspendLayout();
            // 
            // lstGhe
            // 
            lstGhe.ColumnWidth = 46;
            lstGhe.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lstGhe.FormattingEnabled = true;
            lstGhe.IntegralHeight = false;
            lstGhe.ItemHeight = 28;
            lstGhe.Location = new Point(25, 20);
            lstGhe.MultiColumn = true;
            lstGhe.Name = "lstGhe";
            lstGhe.Size = new Size(245, 92);
            lstGhe.TabIndex = 0;
            lstGhe.SelectedIndexChanged += lstGhe_SelectedIndexChanged;
            // 
            // lblGheDaChon
            // 
            lblGheDaChon.AutoSize = true;
            lblGheDaChon.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblGheDaChon.Location = new Point(25, 125);
            lblGheDaChon.Name = "lblGheDaChon";
            lblGheDaChon.Size = new Size(82, 19);
            lblGheDaChon.TabIndex = 1;
            lblGheDaChon.Text = "Đang chọn: ";
            // 
            // btnXacNhan
            // 
            btnXacNhan.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnXacNhan.Location = new Point(105, 160);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(80, 30);
            btnXacNhan.TabIndex = 2;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnBoQua.Location = new Point(195, 160);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(75, 30);
            btnBoQua.TabIndex = 3;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // FormChonGhe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 210);
            Controls.Add(btnBoQua);
            Controls.Add(btnXacNhan);
            Controls.Add(lblGheDaChon);
            Controls.Add(lstGhe);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormChonGhe";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chọn ghế";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstGhe;
        private Label lblGheDaChon;
        private Button btnXacNhan;
        private Button btnBoQua;
    }
}
