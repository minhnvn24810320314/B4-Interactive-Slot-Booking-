namespace NGUYEN_VU_NHAT_MINH_24810320314_BAI_TAP_4
{
    partial class Form1
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
            this.grpSoDo = new System.Windows.Forms.GroupBox();
            this.pnlSoDo = new System.Windows.Forms.TableLayoutPanel();
            this.grpThongKe = new System.Windows.Forms.GroupBox();
            this.lblKhungGio = new System.Windows.Forms.Label();
            this.cboKhungGio = new System.Windows.Forms.ComboBox();
            this.lblViTriChonText = new System.Windows.Forms.Label();
            this.lblSoViTriChon = new System.Windows.Forms.Label();
            this.lblTamTinhText = new System.Windows.Forms.Label();
            this.lblTamTinhTien = new System.Windows.Forms.Label();
            this.btnXacNhanDat = new System.Windows.Forms.Button();
            this.btnHuyChon = new System.Windows.Forms.Button();
            this.pnlChuGiai = new System.Windows.Forms.Panel();
            this.lblTrong = new System.Windows.Forms.Label();
            this.pnlMauTrong = new System.Windows.Forms.Panel();
            this.lblDangChon = new System.Windows.Forms.Label();
            this.pnlMauDangChon = new System.Windows.Forms.Panel();
            this.lblDaDat = new System.Windows.Forms.Label();
            this.pnlMauDaDat = new System.Windows.Forms.Panel();

            this.grpSoDo.SuspendLayout();
            this.grpThongKe.SuspendLayout();
            this.pnlChuGiai.SuspendLayout();
            this.SuspendLayout();

            // 
            // grpSoDo
            // 
            this.grpSoDo.Controls.Add(this.pnlSoDo);
            this.grpSoDo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSoDo.Location = new System.Drawing.Point(12, 12);
            this.grpSoDo.Name = "grpSoDo";
            this.grpSoDo.Size = new System.Drawing.Size(520, 370);
            this.grpSoDo.TabIndex = 0;
            this.grpSoDo.TabStop = false;
            this.grpSoDo.Text = "Sơ đồ vị trí chỗ ngồi / Đặt bàn (4 x 5)";

            // 
            // pnlSoDo
            // 
            this.pnlSoDo.ColumnCount = 5;
            this.pnlSoDo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlSoDo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlSoDo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlSoDo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlSoDo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlSoDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSoDo.Location = new System.Drawing.Point(3, 21);
            this.pnlSoDo.Name = "pnlSoDo";
            this.pnlSoDo.RowCount = 4;
            this.pnlSoDo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlSoDo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlSoDo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlSoDo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlSoDo.Size = new System.Drawing.Size(514, 346);
            this.pnlSoDo.TabIndex = 0;

            // 
            // grpThongKe
            // 
            this.grpThongKe.Controls.Add(this.lblKhungGio);
            this.grpThongKe.Controls.Add(this.cboKhungGio);
            this.grpThongKe.Controls.Add(this.lblViTriChonText);
            this.grpThongKe.Controls.Add(this.lblSoViTriChon);
            this.grpThongKe.Controls.Add(this.lblTamTinhText);
            this.grpThongKe.Controls.Add(this.lblTamTinhTien);
            this.grpThongKe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongKe.Location = new System.Drawing.Point(545, 12);
            this.grpThongKe.Name = "grpThongKe";
            this.grpThongKe.Size = new System.Drawing.Size(260, 200);
            this.grpThongKe.TabIndex = 1;
            this.grpThongKe.TabStop = false;
            this.grpThongKe.Text = "Thông tin đặt chỗ";

            // 
            // lblKhungGio
            // 
            this.lblKhungGio.AutoSize = true;
            this.lblKhungGio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhungGio.Location = new System.Drawing.Point(15, 30);
            this.lblKhungGio.Name = "lblKhungGio";
            this.lblKhungGio.Size = new System.Drawing.Size(95, 15);
            this.lblKhungGio.Text = "Chọn khung giờ:";

            // 
            // cboKhungGio
            // 
            this.cboKhungGio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhungGio.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKhungGio.FormattingEnabled = true;
            this.cboKhungGio.Items.AddRange(new object[] {
            "Sáng (100.000đ / chỗ)",
            "Tối (150.000đ / chỗ)"});
            this.cboKhungGio.Location = new System.Drawing.Point(15, 52);
            this.cboKhungGio.Name = "cboKhungGio";
            this.cboKhungGio.Size = new System.Drawing.Size(230, 25);
            this.cboKhungGio.TabIndex = 0;
            this.cboKhungGio.SelectedIndexChanged += new System.EventHandler(this.cboKhungGio_SelectedIndexChanged);

            // 
            // lblViTriChonText
            // 
            this.lblViTriChonText.AutoSize = true;
            this.lblViTriChonText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViTriChonText.Location = new System.Drawing.Point(15, 95);
            this.lblViTriChonText.Name = "lblViTriChonText";
            this.lblViTriChonText.Size = new System.Drawing.Size(120, 15);
            this.lblViTriChonText.Text = "Số vị trí đang chọn:";

            // 
            // lblSoViTriChon
            // 
            this.lblSoViTriChon.AutoSize = true;
            this.lblSoViTriChon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoViTriChon.ForeColor = System.Drawing.Color.Blue;
            this.lblSoViTriChon.Location = new System.Drawing.Point(180, 90);
            this.lblSoViTriChon.Name = "lblSoViTriChon";
            this.lblSoViTriChon.Size = new System.Drawing.Size(19, 21);
            this.lblSoViTriChon.TabIndex = 1;
            this.lblSoViTriChon.Text = "0";

            // 
            // lblTamTinhText
            // 
            this.lblTamTinhText.AutoSize = true;
            this.lblTamTinhText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamTinhText.Location = new System.Drawing.Point(15, 135);
            this.lblTamTinhText.Name = "lblTamTinhText";
            this.lblTamTinhText.Size = new System.Drawing.Size(81, 15);
            this.lblTamTinhText.Text = "Tạm tính tiền:";

            // 
            // lblTamTinhTien
            // 
            this.lblTamTinhTien.AutoSize = true;
            this.lblTamTinhTien.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamTinhTien.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTamTinhTien.Location = new System.Drawing.Point(15, 155);
            this.lblTamTinhTien.Name = "lblTamTinhTien";
            this.lblTamTinhTien.Size = new System.Drawing.Size(51, 25);
            this.lblTamTinhTien.TabIndex = 2;
            this.lblTamTinhTien.Text = "0 VNĐ";

            // 
            // btnXacNhanDat
            // 
            this.btnXacNhanDat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnXacNhanDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhanDat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhanDat.ForeColor = System.Drawing.Color.White;
            this.btnXacNhanDat.Location = new System.Drawing.Point(545, 225);
            this.btnXacNhanDat.Name = "btnXacNhanDat";
            this.btnXacNhanDat.Size = new System.Drawing.Size(260, 45);
            this.btnXacNhanDat.TabIndex = 2;
            this.btnXacNhanDat.Text = "Xác nhận đặt chỗ";
            this.btnXacNhanDat.UseVisualStyleBackColor = false;
            this.btnXacNhanDat.Click += new System.EventHandler(this.btnXacNhanDat_Click);

            // 
            // btnHuyChon
            // 
            this.btnHuyChon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnHuyChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyChon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyChon.ForeColor = System.Drawing.Color.White;
            this.btnHuyChon.Location = new System.Drawing.Point(545, 280);
            this.btnHuyChon.Name = "btnHuyChon";
            this.btnHuyChon.Size = new System.Drawing.Size(260, 40);
            this.btnHuyChon.TabIndex = 3;
            this.btnHuyChon.Text = "Hủy chọn tất cả";
            this.btnHuyChon.UseVisualStyleBackColor = false;
            this.btnHuyChon.Click += new System.EventHandler(this.btnHuyChon_Click);

            // 
            // pnlChuGiai
            // 
            this.pnlChuGiai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChuGiai.Controls.Add(this.pnlMauTrong);
            this.pnlChuGiai.Controls.Add(this.lblTrong);
            this.pnlChuGiai.Controls.Add(this.pnlMauDangChon);
            this.pnlChuGiai.Controls.Add(this.lblDangChon);
            this.pnlChuGiai.Controls.Add(this.pnlMauDaDat);
            this.pnlChuGiai.Controls.Add(this.lblDaDat);
            this.pnlChuGiai.Location = new System.Drawing.Point(12, 390);
            this.pnlChuGiai.Name = "pnlChuGiai";
            this.pnlChuGiai.Size = new System.Drawing.Size(793, 40);
            this.pnlChuGiai.TabIndex = 4;

            // pnlMauTrong & lblTrong
            this.pnlMauTrong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMauTrong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMauTrong.Location = new System.Drawing.Point(20, 10);
            this.pnlMauTrong.Size = new System.Drawing.Size(20, 20);

            this.lblTrong.AutoSize = true;
            this.lblTrong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrong.Location = new System.Drawing.Point(45, 12);
            this.lblTrong.Text = "Còn trống";

            // pnlMauDangChon & lblDangChon
            this.pnlMauDangChon.BackColor = System.Drawing.Color.LightGreen;
            this.pnlMauDangChon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMauDangChon.Location = new System.Drawing.Point(280, 10);
            this.pnlMauDangChon.Size = new System.Drawing.Size(20, 20);

            this.lblDangChon.AutoSize = true;
            this.lblDangChon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangChon.Location = new System.Drawing.Point(305, 12);
            this.lblDangChon.Text = "Đang chọn";

            // pnlMauDaDat & lblDaDat
            this.pnlMauDaDat.BackColor = System.Drawing.Color.IndianRed;
            this.pnlMauDaDat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMauDaDat.Location = new System.Drawing.Point(550, 10);
            this.pnlMauDaDat.Size = new System.Drawing.Size(20, 20);

            this.lblDaDat.AutoSize = true;
            this.lblDaDat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaDat.Location = new System.Drawing.Point(575, 12);
            this.lblDaDat.Text = "Đã có người đặt (Đã khóa)";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(818, 442);
            this.Controls.Add(this.pnlChuGiai);
            this.Controls.Add(this.btnHuyChon);
            this.Controls.Add(this.btnXacNhanDat);
            this.Controls.Add(this.grpThongKe);
            this.Controls.Add(this.grpSoDo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sơ đồ chọn vị trí chỗ ngồi / Đặt bàn - NGUYỄN VŨ NHẬT MINH";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSoDo.ResumeLayout(false);
            this.grpThongKe.ResumeLayout(false);
            this.grpThongKe.PerformLayout();
            this.pnlChuGiai.ResumeLayout(false);
            this.pnlChuGiai.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpSoDo;
        private System.Windows.Forms.TableLayoutPanel pnlSoDo;
        private System.Windows.Forms.GroupBox grpThongKe;
        private System.Windows.Forms.Label lblKhungGio;
        private System.Windows.Forms.ComboBox cboKhungGio;
        private System.Windows.Forms.Label lblViTriChonText;
        private System.Windows.Forms.Label lblSoViTriChon;
        private System.Windows.Forms.Label lblTamTinhText;
        private System.Windows.Forms.Label lblTamTinhTien;
        private System.Windows.Forms.Button btnXacNhanDat;
        private System.Windows.Forms.Button btnHuyChon;
        private System.Windows.Forms.Panel pnlChuGiai;
        private System.Windows.Forms.Panel pnlMauTrong;
        private System.Windows.Forms.Label lblTrong;
        private System.Windows.Forms.Panel pnlMauDangChon;
        private System.Windows.Forms.Label lblDangChon;
        private System.Windows.Forms.Panel pnlMauDaDat;
        private System.Windows.Forms.Label lblDaDat;
    }
}