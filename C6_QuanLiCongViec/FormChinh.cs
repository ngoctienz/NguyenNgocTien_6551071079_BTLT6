using System;
using System.Windows.Forms;

namespace C6_QuanLiCongViec
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
            CapNhatTrangThaiSoGhiChu();
        }

        private void mnuMoGhiChuMoi_Click(object sender, EventArgs e)
        {
            FormGhiChu formGhiChu = new FormGhiChu();
            formGhiChu.MdiParent = this;
            formGhiChu.FormClosed += FormGhiChu_FormClosed;
            formGhiChu.Show();
            CapNhatTrangThaiSoGhiChu();
        }

        private void FormGhiChu_FormClosed(object? sender, FormClosedEventArgs e)
        {
            // Dùng BeginInvoke để đảm bảo MdiChildren đã cập nhật lại số lượng sau khi Form con đóng hoàn tất
            this.BeginInvoke(new Action(CapNhatTrangThaiSoGhiChu));
        }

        private void CapNhatTrangThaiSoGhiChu()
        {
            lblTrangThaiSoGhiChu.Text = $"Số ghi chú đang mở: {this.MdiChildren.Length}";
        }

        private void mnuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuTileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
