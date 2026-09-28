namespace C4_QuanLiDanhBa
{
    public partial class FormDanhBa : Form
    {
        private int _indexDangSua = -1;

        public FormDanhBa()
        {
            InitializeComponent();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();

            // Kiểm tra txtTen, txtSDT không rỗng
            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên và số điện thoại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nếu đang trong chế độ sửa
            if (_indexDangSua != -1)
            {
                lstLienHe.Items[_indexDangSua] = $"{ten} - {sdt}";
                _indexDangSua = -1;
                txtTen.Clear();
                txtSDT.Clear();
                MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // Chế độ thêm mới
            {
                lstLienHe.Items.Add($"{ten} - {sdt}");
                txtTen.Clear();
                txtSDT.Clear();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một liên hệ để sửa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _indexDangSua = lstLienHe.SelectedIndex;
            string selectedItem = lstLienHe.SelectedItem?.ToString() ?? "";
            int dashIndex = selectedItem.LastIndexOf(" - ");
            if (dashIndex != -1)
            {
                txtTen.Text = selectedItem.Substring(0, dashIndex);
                txtSDT.Text = selectedItem.Substring(dashIndex + 3);
            }
            else
            {
                txtTen.Text = selectedItem;
                txtSDT.Clear();
            }
            txtTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Chưa chọn item
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một liên hệ để xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Đã chọn item
            string selectedItem = lstLienHe.SelectedItem?.ToString() ?? "";
            string ten = selectedItem;
            int dashIndex = selectedItem.LastIndexOf(" - ");
            if (dashIndex != -1)
            {
                ten = selectedItem.Substring(0, dashIndex);
            }

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn xóa liên hệ {ten}?\nThao tác này không thể hoàn tác!",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                int indexXoa = lstLienHe.SelectedIndex;
                lstLienHe.Items.RemoveAt(indexXoa);

                if (_indexDangSua == indexXoa)
                {
                    _indexDangSua = -1;
                    txtTen.Clear();
                    txtSDT.Clear();
                }
                else if (_indexDangSua > indexXoa)
                {
                    _indexDangSua--;
                }

                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDanhBa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTen.Text) || !string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có dữ liệu chưa được lưu. Bạn muốn thoát không?",
                    "Cảnh báo",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (result == DialogResult.No)
                {
                    txtTen.Clear();
                    txtSDT.Clear();
                    // Thoát form
                }
                else if (result == DialogResult.Yes)
                {
                    // Thoát form
                }
            }
        }
    }
}
