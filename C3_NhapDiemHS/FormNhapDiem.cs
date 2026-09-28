using System.Globalization;

namespace C3_NhapDiemHS
{
    public partial class FormNhapDiem : Form
    {
        public FormNhapDiem()
        {
            InitializeComponent();
            DangKyEnterChuyenField();
        }

        /// <summary>
        /// Duyệt tất cả TextBox trên form và đăng ký phím Enter để chuyển focus sang control kế tiếp.
        /// Riêng txtAnh khi nhấn Enter sẽ thực hiện nhấn nút btnLuu.
        /// </summary>
        private void DangKyEnterChuyenField()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox txt)
                {
                    txt.KeyPress += (sender, e) =>
                    {
                        if (e.KeyChar == (char)Keys.Enter)
                        {
                            e.Handled = true;
                            if (sender == txtAnh)
                            {
                                btnLuu.PerformClick();
                            }
                            else
                            {
                                SelectNextControl((Control)sender!, true, true, true, true);
                            }
                        }
                    };
                }
            }
        }

        /// <summary>
        /// Xử lý sự kiện Enter (nhận focus) cho các ô điểm: bôi xanh toàn bộ nội dung cũ để gõ đè.
        /// </summary>
        private void txtDiem_Enter(object? sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                txt.SelectAll();
            }
        }

        /// <summary>
        /// Kiểm tra và lưu thông tin học sinh cùng điểm số vào ListBox.
        /// </summary>
        private void btnLuu_Click(object? sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hopLe = true;

            if (string.IsNullOrWhiteSpace(txtMaHS.Text))
            {
                errorProvider1.SetError(txtMaHS, "Vui lòng nhập Mã học sinh.");
                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider1.SetError(txtHoTen, "Vui lòng nhập Họ tên.");
                hopLe = false;
            }

            bool KiemTraDiem(TextBox txt, string tenMon, out decimal diem)
            {
                string text = txt.Text.Trim().Replace(',', '.');
                if (!decimal.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out diem) || diem < 0.0m || diem > 10.0m)
                {
                    errorProvider1.SetError(txt, $"{tenMon} phải từ 0.0 đến 10.0");
                    return false;
                }
                return true;
            }

            bool toanHopLe = KiemTraDiem(txtToan, "Điểm Toán", out decimal diemToan);
            bool vanHopLe = KiemTraDiem(txtVan, "Điểm Văn", out decimal diemVan);
            bool anhHopLe = KiemTraDiem(txtAnh, "Điểm Anh", out decimal diemAnh);

            if (!toanHopLe || !vanHopLe || !anhHopLe)
            {
                hopLe = false;
            }

            if (!hopLe)
            {
                return;
            }

            string strToan = (diemToan % 1 == 0) ? diemToan.ToString("0.0", CultureInfo.InvariantCulture) : diemToan.ToString("0.##", CultureInfo.InvariantCulture);
            string strVan = (diemVan % 1 == 0) ? diemVan.ToString("0.0", CultureInfo.InvariantCulture) : diemVan.ToString("0.##", CultureInfo.InvariantCulture);
            string strAnh = (diemAnh % 1 == 0) ? diemAnh.ToString("0.0", CultureInfo.InvariantCulture) : diemAnh.ToString("0.##", CultureInfo.InvariantCulture);

            string dongHocSinh = $"{txtMaHS.Text.Trim()} | {txtHoTen.Text.Trim()} | T:{strToan} V:{strVan} A:{strAnh}";
            lstDanhSach.Items.Add(dongHocSinh);

            XoaTrang();
        }

        /// <summary>
        /// Xóa trắng nội dung nhập trên form và đưa con trỏ về ô txtMaHS.
        /// </summary>
        private void XoaTrang()
        {
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();
            errorProvider1.Clear();
            txtMaHS.Focus();
        }

        private void btnXoaTrang_Click(object? sender, EventArgs e)
        {
            XoaTrang();
        }
    }
}
