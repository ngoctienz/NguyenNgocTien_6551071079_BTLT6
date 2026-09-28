using System;
using System.Windows.Forms;

namespace C5_VeXemPhim
{
    public partial class FormChonGhe : Form
    {
        public string GheChon { get; private set; } = string.Empty;

        public FormChonGhe() : this(string.Empty)
        {
        }

        public FormChonGhe(string gheHienTai)
        {
            InitializeComponent();
            KhoiTaoDanhSachGhe();

            if (!string.IsNullOrEmpty(gheHienTai) && lstGhe.Items.Contains(gheHienTai))
            {
                lstGhe.SelectedItem = gheHienTai;
            }
            else
            {
                lblGheDaChon.Text = "Đang chọn: ";
            }
        }

        private void KhoiTaoDanhSachGhe()
        {
            lstGhe.Items.Clear();

            // Sắp xếp theo cột để hiển thị ListBox MultiColumn:
            // Cột 1: A1, B1, C1
            // Cột 2: A2, B2, C2
            // Cột 3: A3, B3, C3
            // Cột 4: A4, B4, C4
            // Cột 5: A5, B5, C5
            for (int col = 1; col <= 5; col++)
            {
                lstGhe.Items.Add($"A{col}");
                lstGhe.Items.Add($"B{col}");
                lstGhe.Items.Add($"C{col}");
            }
        }

        private void lstGhe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGhe.SelectedItem != null)
            {
                lblGheDaChon.Text = $"Đang chọn: {lstGhe.SelectedItem}";
            }
            else
            {
                lblGheDaChon.Text = "Đang chọn: ";
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (lstGhe.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một ghế!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GheChon = lstGhe.SelectedItem.ToString() ?? string.Empty;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
