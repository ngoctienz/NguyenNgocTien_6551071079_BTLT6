namespace C6_QuanLiCongViec
{
    partial class FormGhiChu
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
            components = new System.ComponentModel.Container();
            lblTieuDeForm = new Label();
            txtTieuDe = new TextBox();
            lblNoiDung = new Label();
            txtNoiDung = new TextBox();
            lblPriority = new Label();
            cboMucDoUuTien = new ComboBox();
            btnLuuGhiChu = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDeForm
            // 
            lblTieuDeForm.AutoSize = true;
            lblTieuDeForm.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTieuDeForm.Location = new Point(16, 12);
            lblTieuDeForm.Name = "lblTieuDeForm";
            lblTieuDeForm.Size = new Size(47, 15);
            lblTieuDeForm.TabIndex = 0;
            lblTieuDeForm.Text = "Tiêu đề";
            lblTieuDeForm.MouseDoubleClick += lblTieuDeForm_MouseDoubleClick;
            // 
            // txtTieuDe
            // 
            txtTieuDe.Location = new Point(16, 32);
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(325, 23);
            txtTieuDe.TabIndex = 1;
            txtTieuDe.TextChanged += Control_ContentChanged;
            txtTieuDe.Validating += txtTieuDe_Validating;
            txtTieuDe.Validated += txtTieuDe_Validated;
            // 
            // lblNoiDung
            // 
            lblNoiDung.AutoSize = true;
            lblNoiDung.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNoiDung.Location = new Point(16, 64);
            lblNoiDung.Name = "lblNoiDung";
            lblNoiDung.Size = new Size(57, 15);
            lblNoiDung.TabIndex = 2;
            lblNoiDung.Text = "Nội dung";
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(16, 84);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.ScrollBars = ScrollBars.Vertical;
            txtNoiDung.Size = new Size(345, 125);
            txtNoiDung.TabIndex = 3;
            txtNoiDung.TextChanged += Control_ContentChanged;
            txtNoiDung.KeyPress += txtNoiDung_KeyPress;
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPriority.Location = new Point(16, 218);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(48, 15);
            lblPriority.TabIndex = 4;
            lblPriority.Text = "Priority:";
            // 
            // cboMucDoUuTien
            // 
            cboMucDoUuTien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMucDoUuTien.FormattingEnabled = true;
            cboMucDoUuTien.Items.AddRange(new object[] { "Thấp", "Trung bình", "Cao" });
            cboMucDoUuTien.Location = new Point(16, 238);
            cboMucDoUuTien.Name = "cboMucDoUuTien";
            cboMucDoUuTien.Size = new Size(130, 23);
            cboMucDoUuTien.TabIndex = 5;
            cboMucDoUuTien.SelectedIndexChanged += Control_ContentChanged;
            // 
            // btnLuuGhiChu
            // 
            btnLuuGhiChu.Location = new Point(266, 235);
            btnLuuGhiChu.Name = "btnLuuGhiChu";
            btnLuuGhiChu.Size = new Size(95, 28);
            btnLuuGhiChu.TabIndex = 6;
            btnLuuGhiChu.Text = "Lưu";
            btnLuuGhiChu.UseVisualStyleBackColor = true;
            btnLuuGhiChu.Click += btnLuuGhiChu_Click;
            btnLuuGhiChu.MouseEnter += btnLuuGhiChu_MouseEnter;
            btnLuuGhiChu.MouseLeave += btnLuuGhiChu_MouseLeave;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // FormGhiChu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 280);
            Controls.Add(btnLuuGhiChu);
            Controls.Add(cboMucDoUuTien);
            Controls.Add(lblPriority);
            Controls.Add(txtNoiDung);
            Controls.Add(lblNoiDung);
            Controls.Add(txtTieuDe);
            Controls.Add(lblTieuDeForm);
            KeyPreview = true;
            Name = "FormGhiChu";
            StartPosition = FormStartPosition.Manual;
            Text = "Ghi chú mới";
            KeyDown += FormGhiChu_KeyDown;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDeForm;
        private TextBox txtTieuDe;
        private Label lblNoiDung;
        private TextBox txtNoiDung;
        private Label lblPriority;
        private ComboBox cboMucDoUuTien;
        private Button btnLuuGhiChu;
        private ErrorProvider errorProvider1;
    }
}
