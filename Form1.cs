using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NGUYEN_VU_NHAT_MINH_24810320314_BAI_TAP_4
{
    public partial class Form1 : Form
    {
        // Khai báo bảng màu trạng thái chỗ ngồi
        private readonly Color MAU_TRONG = Color.WhiteSmoke;       // Chưa chọn (Trắng / Xám nhạt)
        private readonly Color MAU_DANG_CHON = Color.LightGreen;   // Đang chọn (Xanh lá)
        private readonly Color MAU_DA_DAT = Color.IndianRed;       // Đã khóa / Đặt trước (Đỏ)

        // Đơn giá tương ứng
        private const int GIA_SANG = 100000;
        private const int GIA_TOI = 150000;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set mặc định chọn Khung giờ Sáng
            cboKhungGio.SelectedIndex = 0;

            // Khởi tạo 20 vị trí bằng vòng lặp FOR
            TaoSoDoViTri(20);

            // Giả định khóa trước 2 vị trí để minh họa trạng thái Đã đặt (Vị trí 3 và 12)
            KhoaViTriBanDau(new int[] { 3, 12 });

            // Cập nhật thống kê ban đầu
            CapNhatThongKeRealtime();
        }

        /// <summary>
        /// Tạo động ma trận 20 Button vị trí dùng vòng lặp for
        /// </summary>
        private void TaoSoDoViTri(int tongSoViTri)
        {
            pnlSoDo.Controls.Clear();

            for (int i = 1; i <= tongSoViTri; i++)
            {
                Button btn = new Button
                {
                    Text = $"Vị trí {i}",
                    Name = $"btnViTri_{i}",
                    Dock = DockStyle.Fill,
                    Margin = new Padding(4),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = MAU_TRONG,
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    Tag = "TRONG" // Dùng Tag để lưu trạng thái vị trí: TRONG | DANG_CHON | DA_DAT
                };

                btn.FlatAppearance.BorderColor = Color.LightGray;

                // GÁN CHUNG 1 HÀM XỬ LÝ SỰ KIỆN CLICK CHO TẤT CẢ 20 BUTTON
                btn.Click += Vitri_Click;

                pnlSoDo.Controls.Add(btn);
            }
        }

        /// <summary>
        /// Hàm xử lý sự kiện Click dùng chung cho toàn bộ 20 nút vị trí
        /// </summary>
        private void Vitri_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            string trangThai = btn.Tag.ToString();

            // 1. Nếu vị trí đã bị khóa/đã đặt -> Báo lỗi không thể chọn
            if (trangThai == "DA_DAT")
            {
                MessageBox.Show($"Chỗ [{btn.Text}] đã có người đặt trước. Vui lòng chọn vị trí khác!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Chuyển đổi trạng thái giữa TRỐNG <-> ĐANG CHỌN
            if (trangThai == "TRONG")
            {
                btn.BackColor = MAU_DANG_CHON;
                btn.Tag = "DANG_CHON";
            }
            else if (trangThai == "DANG_CHON")
            {
                btn.BackColor = MAU_TRONG;
                btn.Tag = "TRONG";
            }

            // 3. Cập nhật thống kê tiền và số chỗ Realtime
            CapNhatThongKeRealtime();
        }

        /// <summary>
        /// Hàm tính toán số lượng vị trí đang chọn và tạm tính tiền Realtime
        /// </summary>
        private void CapNhatThongKeRealtime()
        {
            int soViTriChon = 0;

            // Duyệt qua tất cả 20 nút trong TableLayoutPanel
            foreach (Control ctrl in pnlSoDo.Controls)
            {
                if (ctrl is Button btn && btn.Tag != null && btn.Tag.ToString() == "DANG_CHON")
                {
                    soViTriChon++;
                }
            }

            // Xác định đơn giá theo khung giờ
            int donGia = (cboKhungGio.SelectedIndex == 0) ? GIA_SANG : GIA_TOI;
            long tongTien = (long)soViTriChon * donGia;

            // Hiển thị lên giao diện
            lblSoViTriChon.Text = soViTriChon.ToString();
            lblTamTinhTien.Text = string.Format("{0:N0} VNĐ", tongTien);
        }

        private void cboKhungGio_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Khi thay đổi khung giờ -> Tính lại tổng tiền Realtime ngay lập tức
            CapNhatThongKeRealtime();
        }

        private void btnHuyChon_Click(object sender, EventArgs e)
        {
            // Đưa tất cả các vị trí đang chọn về trạng thái Trống
            foreach (Control ctrl in pnlSoDo.Controls)
            {
                if (ctrl is Button btn && btn.Tag != null && btn.Tag.ToString() == "DANG_CHON")
                {
                    btn.BackColor = MAU_TRONG;
                    btn.Tag = "TRONG";
                }
            }

            CapNhatThongKeRealtime();
        }

        private void btnXacNhanDat_Click(object sender, EventArgs e)
        {
            List<string> dsChon = new List<string>();

            foreach (Control ctrl in pnlSoDo.Controls)
            {
                if (ctrl is Button btn && btn.Tag != null && btn.Tag.ToString() == "DANG_CHON")
                {
                    dsChon.Add(btn.Text);
                }
            }

            if (dsChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 vị trí chỗ ngồi trước khi xác nhận!",
                                "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string khungGioText = cboKhungGio.SelectedItem.ToString();
            string danhSachGhe = string.Join(", ", dsChon);
            string tongTienText = lblTamTinhTien.Text;

            // Thông báo xác nhận thành công
            string thongBao = $"ĐẶT CHỖ THÀNH CÔNG!\n" +
                              $"------------------------------------\n" +
                              $"• Khách hàng: Nguyễn Vũ Nhật Minh\n" +
                              $"• Khung giờ: {khungGioText}\n" +
                              $"• Vị trí đặt ({dsChon.Count}): {danhSachGhe}\n" +
                              $"• Tổng thanh toán: {tongTienText}";

            MessageBox.Show(thongBao, "Xác nhận đặt chỗ thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Chuyển các vị trí vừa chọn sang trạng thái ĐÃ ĐẶT (Đỏ / Khóa)
            foreach (Control ctrl in pnlSoDo.Controls)
            {
                if (ctrl is Button btn && btn.Tag != null && btn.Tag.ToString() == "DANG_CHON")
                {
                    btn.BackColor = MAU_DA_DAT;
                    btn.ForeColor = Color.White;
                    btn.Tag = "DA_DAT";
                }
            }

            CapNhatThongKeRealtime();
        }

        /// <summary>
        /// Khóa sẵn một số vị trí để làm dữ liệu mẫu ban đầu
        /// </summary>
        private void KhoaViTriBanDau(int[] danhSachSoViTri)
        {
            foreach (int stt in danhSachSoViTri)
            {
                string btnName = $"btnViTri_{stt}";
                Control[] founds = pnlSoDo.Controls.Find(btnName, false);
                if (founds.Length > 0 && founds[0] is Button btn)
                {
                    btn.BackColor = MAU_DA_DAT;
                    btn.ForeColor = Color.White;
                    btn.Tag = "DA_DAT";
                }
            }
        }
    }
}