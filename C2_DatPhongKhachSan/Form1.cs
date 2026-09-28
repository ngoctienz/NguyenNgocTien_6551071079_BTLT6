using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace C2_DatPhongKhachSan
{
    public partial class FormDatPhong : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool DestroyIcon(IntPtr handle);

        public FormDatPhong()
        {
            InitializeComponent();
            KhoiTaoIconDung();
        }

        // Tạo icon dấu tích xanh (✔) cho errorProviderDung khi nhập đúng
        private void KhoiTaoIconDung()
        {
            using (Bitmap bmp = new Bitmap(16, 16))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.Transparent);
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    using (Pen pen = new Pen(Color.FromArgb(46, 139, 87), 2.5f))
                    {
                        pen.StartCap = LineCap.Round;
                        pen.EndCap = LineCap.Round;
                        g.DrawLine(pen, 2.5f, 8.5f, 6.5f, 13f);
                        g.DrawLine(pen, 6.5f, 13f, 13.5f, 3.5f);
                    }
                }
                IntPtr hIcon = bmp.GetHicon();
                using (Icon tempIcon = Icon.FromHandle(hIcon))
                {
                    errorProviderDung.Icon = (Icon)tempIcon.Clone();
                }
                DestroyIcon(hIcon);
            }
            errorProviderDung.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        // 1. Kiểm tra txtHoTen: không để trống
        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống!");
                errorProviderDung.SetError(txtHoTen, "");
                txtHoTen.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
                errorProviderDung.SetError(txtHoTen, "Hợp lệ");
                txtHoTen.BackColor = Color.Honeydew;
            }
        }

        // 2. Kiểm tra txtCCCD: đúng 12 chữ số
        private void txtCCCD_Validating(object sender, CancelEventArgs e)
        {
            string cccd = txtCCCD.Text.Trim();
            if (cccd.Length != 12 || !cccd.All(char.IsDigit))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCCCD, "Số CCCD phải gồm đúng 12 chữ số!");
                errorProviderDung.SetError(txtCCCD, "");
                txtCCCD.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtCCCD, "");
                errorProviderDung.SetError(txtCCCD, "Hợp lệ");
                txtCCCD.BackColor = Color.Honeydew;
            }
        }

        // 3. Kiểm tra txtNgayNhan: parse được "dd/MM/yyyy" và >= hôm nay
        private void txtNgayNhan_Validating(object sender, CancelEventArgs e)
        {
            if (!DateTime.TryParseExact(txtNgayNhan.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayNhan))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNgayNhan, "Ngày nhận phòng phải có định dạng dd/MM/yyyy!");
                errorProviderDung.SetError(txtNgayNhan, "");
                txtNgayNhan.BackColor = Color.MistyRose;
            }
            else if (ngayNhan.Date < DateTime.Today)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNgayNhan, "Ngày nhận phòng phải từ ngày hôm nay trở đi!");
                errorProviderDung.SetError(txtNgayNhan, "");
                txtNgayNhan.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtNgayNhan, "");
                errorProviderDung.SetError(txtNgayNhan, "Hợp lệ");
                txtNgayNhan.BackColor = Color.Honeydew;
            }
        }

        // 4. Kiểm tra txtNgayTra: parse được và lớn hơn ngày nhận
        private void txtNgayTra_Validating(object sender, CancelEventArgs e)
        {
            if (!DateTime.TryParseExact(txtNgayTra.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayTra))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNgayTra, "Ngày trả phòng phải có định dạng dd/MM/yyyy!");
                errorProviderDung.SetError(txtNgayTra, "");
                txtNgayTra.BackColor = Color.MistyRose;
            }
            else if (DateTime.TryParseExact(txtNgayNhan.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayNhan) && ngayTra.Date <= ngayNhan.Date)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNgayTra, "Ngày trả phải sau ngày nhận");
                errorProviderDung.SetError(txtNgayTra, "");
                txtNgayTra.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtNgayTra, "");
                errorProviderDung.SetError(txtNgayTra, "Hợp lệ");
                txtNgayTra.BackColor = Color.Honeydew;
            }
        }

        // 5. Kiểm tra txtSoNguoiLon: là số nguyên 1-4
        private void txtSoNguoiLon_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtSoNguoiLon.Text.Trim(), out int soNguoiLon) || soNguoiLon < 1 || soNguoiLon > 4)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSoNguoiLon, "Số người lớn phải là số nguyên từ 1 đến 4!");
                errorProviderDung.SetError(txtSoNguoiLon, "");
                txtSoNguoiLon.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtSoNguoiLon, "");
                errorProviderDung.SetError(txtSoNguoiLon, "Hợp lệ");
                txtSoNguoiLon.BackColor = Color.Honeydew;
            }
        }

        // 6. Kiểm tra txtSoTreEm: là số nguyên 0-3
        private void txtSoTreEm_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtSoTreEm.Text.Trim(), out int soTreEm) || soTreEm < 0 || soTreEm > 3)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSoTreEm, "Số trẻ em phải là số nguyên từ 0 đến 3!");
                errorProviderDung.SetError(txtSoTreEm, "");
                txtSoTreEm.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtSoTreEm, "");
                errorProviderDung.SetError(txtSoTreEm, "Hợp lệ");
                txtSoTreEm.BackColor = Color.Honeydew;
            }
        }

        // 7. Sự kiện Validated: xác nhận field đã hợp lệ -> đặt BackColor = Color.Honeydew và hiện dấu tích xanh
        private void TextBox_Validated(object sender, EventArgs e)
        {
            if (sender is TextBox tb)
            {
                tb.BackColor = Color.Honeydew;
                errorProvider1.SetError(tb, "");
                errorProviderDung.SetError(tb, "Hợp lệ");
            }
        }

        // 8. Sự kiện btnDatPhong_Click: tính số đêm = (ngày trả - ngày nhận).Days và hiện MessageBox
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }

            if (DateTime.TryParseExact(txtNgayNhan.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayNhan) &&
                DateTime.TryParseExact(txtNgayTra.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayTra))
            {
                int soDem = (ngayTra.Date - ngayNhan.Date).Days;
                string thongTin = $"Đặt phòng thành công!\n\n" +
                                  $"Họ tên khách: {txtHoTen.Text.Trim()}\n" +
                                  $"Số CCCD: {txtCCCD.Text.Trim()}\n" +
                                  $"Ngày nhận phòng: {ngayNhan:dd/MM/yyyy}\n" +
                                  $"Ngày trả phòng: {ngayTra:dd/MM/yyyy}\n" +
                                  $"Số đêm: {soDem} đêm\n" +
                                  $"Số người lớn: {txtSoNguoiLon.Text.Trim()}\n" +
                                  $"Số trẻ em: {txtSoTreEm.Text.Trim()}";

                MessageBox.Show(thongTin, "Thông tin đặt phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
