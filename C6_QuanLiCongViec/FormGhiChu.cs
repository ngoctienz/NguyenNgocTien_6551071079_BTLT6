using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace C6_QuanLiCongViec
{
    public partial class FormGhiChu : Form
    {
        private Color defaultBtnColor;
        private bool isContentChanged = false;

        public FormGhiChu()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            defaultBtnColor = btnLuuGhiChu.BackColor;

            if (cboMucDoUuTien.Items.Count > 0)
            {
                cboMucDoUuTien.SelectedItem = "Cao";
            }

            // Đặt lại cờ sau khi khởi tạo giá trị ban đầu
            isContentChanged = false;
        }

        private void Control_ContentChanged(object? sender, EventArgs e)
        {
            isContentChanged = true;
        }

        private void FormGhiChu_KeyDown(object sender, KeyEventArgs e)
        {
            // Ctrl+S: Lưu ghi chú
            if (e.Control && e.KeyCode == Keys.S)
            {
                e.SuppressKeyPress = true; // Chặn tiếng beep mặc định
                btnLuuGhiChu.PerformClick();
            }
            // Escape: Hỏi xác nhận đóng nếu nội dung đã thay đổi
            else if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                if (isContentChanged)
                {
                    DialogResult result = MessageBox.Show(
                        "Nội dung đã thay đổi. Bạn có chắc chắn muốn đóng ghi chú?",
                        "Xác nhận đóng",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void txtNoiDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép các phím điều khiển (như Backspace, Enter, Ctrl+C...)
            if (!char.IsControl(e.KeyChar))
            {
                // Giới hạn tối đa 500 ký tự
                if (txtNoiDung.Text.Length - txtNoiDung.SelectionLength >= 500)
                {
                    e.Handled = true; // Chặn ký tự thêm
                }
            }
        }

        private void lblTieuDeForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Phóng to / thu nhỏ cửa sổ ghi chú con
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnLuuGhiChu_MouseEnter(object sender, EventArgs e)
        {
            // Hiệu ứng hover khi rê chuột vào
            btnLuuGhiChu.BackColor = Color.LightSkyBlue;
        }

        private void btnLuuGhiChu_MouseLeave(object sender, EventArgs e)
        {
            // Khôi phục màu nền ban đầu khi rời chuột
            btnLuuGhiChu.BackColor = defaultBtnColor;
        }

        private void txtTieuDe_Validating(object sender, CancelEventArgs e)
        {
            string text = txtTieuDe.Text.Trim();
            if (string.IsNullOrEmpty(text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTieuDe, "Tiêu đề không được để trống!");
                txtTieuDe.BackColor = Color.MistyRose;
            }
            else if (txtTieuDe.Text.Length > 50)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTieuDe, "Tiêu đề không được vượt quá 50 ký tự!");
                txtTieuDe.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void txtTieuDe_Validated(object sender, EventArgs e)
        {
            // Xóa lỗi và đưa màu nền về trắng khi hợp lệ
            errorProvider1.SetError(txtTieuDe, "");
            txtTieuDe.BackColor = Color.White;
        }

        private void btnLuuGhiChu_Click(object sender, EventArgs e)
        {
            // Trigger toàn bộ Validating trên form
            if (!this.ValidateChildren())
            {
                return; // Còn lỗi thì dừng lại
            }

            // Hợp lệ: Đổi tiêu đề cửa sổ con thành txtTieuDe.Text
            this.Text = txtTieuDe.Text;
            isContentChanged = false;
            MessageBox.Show("Đã lưu ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
