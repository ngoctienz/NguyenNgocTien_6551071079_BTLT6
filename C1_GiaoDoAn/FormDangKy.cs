using System;
namespace C1_GiaoDoAn
{
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private bool KiemTraHopLe()
        {
            bool oke = true;

            string hoTen = txtHoTen.Text;
            if (string.IsNullOrEmpty(hoTen) || hoTen.Length < 3)
            {
                errorProvider1.SetError(txtHoTen, "Họ tên chưa đúng");
                oke = false;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
            }

            string sdt = txtSDT.Text;
            if (!System.Text.RegularExpressions.Regex.IsMatch(sdt, @"^0\d{9}$"))
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại phải gồm đúng 10 chữ số và bắt đầu bằng số 0");
                oke = false;
            }
            else
            {
                errorProvider1.SetError(txtSDT, "");
            }

            string email = txtEmail.Text.Trim();
            int viTriA = email.IndexOf('@');
            if (viTriA == -1 || email.IndexOf('.', viTriA) == -1 || email.EndsWith("."))
            {
                errorProvider1.SetError(txtEmail, "Email phải chứa '@' và có dấu '.' phía sau '@'!");
                oke = false;

            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }

            if (txtMatKhau.Text.Length < 6)
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu phải có tối thiểu 6 ký tự!");
                oke = false;
            }
            else
            {
                errorProvider1.SetError(txtMatKhau, "");
            }

            if (txtXacNhanMK.Text != txtMatKhau.Text || string.IsNullOrEmpty(txtXacNhanMK.Text))
            {
                errorProvider1.SetError(txtXacNhanMK, "Mật khẩu xác nhận không khớp!");
                oke = false;
            }
            else
            {
                errorProvider1.SetError(txtXacNhanMK, "");
            }
            return oke;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe()) return;
            MessageBox.Show("Đăng ký thành công! Chào mừng " + txtHoTen.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.CausesValidation = false;
            errorProvider1.Clear();
            this.Close();

        }
    }
}
