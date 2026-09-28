namespace C6_QuanLiCongViec
{
    partial class FormChinh
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
            menuStrip1 = new MenuStrip();
            mnuTep = new ToolStripMenuItem();
            mnuMoGhiChuMoi = new ToolStripMenuItem();
            mnuSapXepCuaSo = new ToolStripMenuItem();
            mnuSubCascade = new ToolStripMenuItem();
            mnuSubTileHorizontal = new ToolStripMenuItem();
            mnuSubTileVertical = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuThoat = new ToolStripMenuItem();
            mnuCuaSo = new ToolStripMenuItem();
            mnuCascade = new ToolStripMenuItem();
            mnuTileHorizontal = new ToolStripMenuItem();
            mnuTileVertical = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblTrangThaiSoGhiChu = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuTep, mnuCuaSo });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(884, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuTep
            // 
            mnuTep.DropDownItems.AddRange(new ToolStripItem[] { mnuMoGhiChuMoi, mnuSapXepCuaSo, toolStripSeparator1, mnuThoat });
            mnuTep.Name = "mnuTep";
            mnuTep.Size = new Size(37, 20);
            mnuTep.Text = "&Tệp";
            // 
            // mnuMoGhiChuMoi
            // 
            mnuMoGhiChuMoi.Name = "mnuMoGhiChuMoi";
            mnuMoGhiChuMoi.ShortcutKeys = Keys.Control | Keys.N;
            mnuMoGhiChuMoi.Size = new Size(207, 22);
            mnuMoGhiChuMoi.Text = "&Mở ghi chú mới";
            mnuMoGhiChuMoi.Click += mnuMoGhiChuMoi_Click;
            // 
            // mnuSapXepCuaSo
            // 
            mnuSapXepCuaSo.DropDownItems.AddRange(new ToolStripItem[] { mnuSubCascade, mnuSubTileHorizontal, mnuSubTileVertical });
            mnuSapXepCuaSo.Name = "mnuSapXepCuaSo";
            mnuSapXepCuaSo.Size = new Size(207, 22);
            mnuSapXepCuaSo.Text = "Sắp xếp cửa sổ";
            // 
            // mnuSubCascade
            // 
            mnuSubCascade.Name = "mnuSubCascade";
            mnuSubCascade.Size = new Size(134, 22);
            mnuSubCascade.Text = "Xếp tầng";
            mnuSubCascade.Click += mnuCascade_Click;
            // 
            // mnuSubTileHorizontal
            // 
            mnuSubTileHorizontal.Name = "mnuSubTileHorizontal";
            mnuSubTileHorizontal.Size = new Size(134, 22);
            mnuSubTileHorizontal.Text = "Xếp ngang";
            mnuSubTileHorizontal.Click += mnuTileHorizontal_Click;
            // 
            // mnuSubTileVertical
            // 
            mnuSubTileVertical.Name = "mnuSubTileVertical";
            mnuSubTileVertical.Size = new Size(134, 22);
            mnuSubTileVertical.Text = "Xếp dọc";
            mnuSubTileVertical.Click += mnuTileVertical_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(204, 6);
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuThoat.Size = new Size(207, 22);
            mnuThoat.Text = "Th&oát";
            mnuThoat.Click += mnuThoat_Click;
            // 
            // mnuCuaSo
            // 
            mnuCuaSo.DropDownItems.AddRange(new ToolStripItem[] { mnuCascade, mnuTileHorizontal, mnuTileVertical });
            mnuCuaSo.Name = "mnuCuaSo";
            mnuCuaSo.Size = new Size(55, 20);
            mnuCuaSo.Text = "&Cửa sổ";
            // 
            // mnuCascade
            // 
            mnuCascade.Name = "mnuCascade";
            mnuCascade.Size = new Size(134, 22);
            mnuCascade.Text = "Xếp tầng";
            mnuCascade.Click += mnuCascade_Click;
            // 
            // mnuTileHorizontal
            // 
            mnuTileHorizontal.Name = "mnuTileHorizontal";
            mnuTileHorizontal.Size = new Size(134, 22);
            mnuTileHorizontal.Text = "Xếp ngang";
            mnuTileHorizontal.Click += mnuTileHorizontal_Click;
            // 
            // mnuTileVertical
            // 
            mnuTileVertical.Name = "mnuTileVertical";
            mnuTileVertical.Size = new Size(134, 22);
            mnuTileVertical.Text = "Xếp dọc";
            mnuTileVertical.Click += mnuTileVertical_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTrangThaiSoGhiChu });
            statusStrip1.Location = new Point(0, 539);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(884, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTrangThaiSoGhiChu
            // 
            lblTrangThaiSoGhiChu.Name = "lblTrangThaiSoGhiChu";
            lblTrangThaiSoGhiChu.Size = new Size(127, 17);
            lblTrangThaiSoGhiChu.Text = "Số ghi chú đang mở: 0";
            // 
            // FormChinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormChinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý ghi chú công việc";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuTep;
        private ToolStripMenuItem mnuMoGhiChuMoi;
        private ToolStripMenuItem mnuSapXepCuaSo;
        private ToolStripMenuItem mnuSubCascade;
        private ToolStripMenuItem mnuSubTileHorizontal;
        private ToolStripMenuItem mnuSubTileVertical;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuCuaSo;
        private ToolStripMenuItem mnuCascade;
        private ToolStripMenuItem mnuTileHorizontal;
        private ToolStripMenuItem mnuTileVertical;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTrangThaiSoGhiChu;
    }
}
