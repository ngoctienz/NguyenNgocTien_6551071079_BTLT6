using System;
using System.Windows.Forms;

namespace C5_VeXemPhim
{
    public partial class FormBanVe : Form
    {
        public FormBanVe()
        {
            InitializeComponent();
        }

        private void FormBanVe_Load(object sender, EventArgs e)
        {
            // Khởi tạo danh sách phim mẫu
            cboPhim.Items.AddRange(new string[]
            {
                "Chiến binh cuối cùng",
                "Avatar: Dòng chảy của nước",
                "Kẻ hủy diệt",
                "Doraemon: Vùng đất lý tưởng"
            });

            // Khởi tạo danh sách suất chiếu mẫu
            cboSuatChieu.Items.AddRange(new string[]
            {
                "17:00",
                "19:00",
                "20:30",
                "22:00"
            });

            // Thiết lập giá trị mặc định theo mẫu giao diện
            if (cboPhim.Items.Count > 0)
                cboPhim.SelectedIndex = 0; // Chiến binh cuối cùng

            if (cboSuatChieu.Items.Count > 1)
                cboSuatChieu.SelectedIndex = 1; // 19:00
        }

        private void btnChonGhe_Click(object sender, EventArgs e)
        {
            // Mở dialog chọn ghế bằng ShowDialog() trong khối using()
            using (FormChonGhe dlg = new FormChonGhe(txtGheDaChon.Text))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtGheDaChon.Text = dlg.GheChon;
                }
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            // Kiểm tra đủ thông tin
            if (string.IsNullOrWhiteSpace(txtTenKhach.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhach.Focus();
                return;
            }

            if (cboPhim.SelectedIndex == -1 && string.IsNullOrWhiteSpace(cboPhim.Text))
            {
                MessageBox.Show("Vui lòng chọn phim!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPhim.Focus();
                return;
            }

            if (cboSuatChieu.SelectedIndex == -1 && string.IsNullOrWhiteSpace(cboSuatChieu.Text))
            {
                MessageBox.Show("Vui lòng chọn suất chiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSuatChieu.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGheDaChon.Text))
            {
                MessageBox.Show("Vui lòng chọn ghế trước khi đặt vé!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnChonGhe.Focus();
                return;
            }

            // Hiển thị hộp thoại xác nhận đặt vé
            string thongBao = $"XÁC NHẬN ĐẶT VÉ THÀNH CÔNG!\n\n" +
                              $"- Tên khách: {txtTenKhach.Text.Trim()}\n" +
                              $"- Phim: {cboPhim.Text}\n" +
                              $"- Suất chiếu: {cboSuatChieu.Text}\n" +
                              $"- Ghế: {txtGheDaChon.Text}\n" +
                              $"- Giá: 75.000đ/vé";

            MessageBox.Show(thongBao, "Thông tin vé", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa thông tin nhập liệu
            txtTenKhach.Clear();
            txtGheDaChon.Clear();
            if (cboPhim.Items.Count > 0)
                cboPhim.SelectedIndex = 0;
            if (cboSuatChieu.Items.Count > 1)
                cboSuatChieu.SelectedIndex = 1;

            txtTenKhach.Focus();
        }
    }
}
