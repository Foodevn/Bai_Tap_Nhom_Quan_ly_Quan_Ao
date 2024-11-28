namespace XemLaiHoaDon
{
    partial class FrmXemDSHang
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cbbNhomMatHang = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.lblTongKet = new System.Windows.Forms.Label();
			this.btnThemHang = new System.Windows.Forms.Button();
			this.lvDS = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Lọc và tìm kiếm";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Nhóm mặt hàng";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(129, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "Danh sách mặt hàng";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(315, 46);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(144, 16);
			this.label4.TabIndex = 1;
			this.label4.Text = "Tên hoặc mã mặt hàng";
			// 
			// cbbNhomMatHang
			// 
			this.cbbNhomMatHang.FormattingEnabled = true;
			this.cbbNhomMatHang.Location = new System.Drawing.Point(120, 43);
			this.cbbNhomMatHang.Name = "cbbNhomMatHang";
			this.cbbNhomMatHang.Size = new System.Drawing.Size(166, 24);
			this.cbbNhomMatHang.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(465, 43);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Xóa bộ lọc";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// lblTongKet
			// 
			this.lblTongKet.AutoSize = true;
			this.lblTongKet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTongKet.ForeColor = System.Drawing.Color.Red;
			this.lblTongKet.Location = new System.Drawing.Point(573, 45);
			this.lblTongKet.Name = "lblTongKet";
			this.lblTongKet.Size = new System.Drawing.Size(15, 16);
			this.lblTongKet.TabIndex = 4;
			this.lblTongKet.Text = "0";
			// 
			// btnThemHang
			// 
			this.btnThemHang.Location = new System.Drawing.Point(849, 46);
			this.btnThemHang.Name = "btnThemHang";
			this.btnThemHang.Size = new System.Drawing.Size(138, 31);
			this.btnThemHang.TabIndex = 5;
			this.btnThemHang.Text = "Thêm mặt hàng";
			this.btnThemHang.UseVisualStyleBackColor = true;
			this.btnThemHang.Click += new System.EventHandler(this.btnThemHang_Click);
			// 
			// lvDS
			// 
			this.lvDS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
			this.lvDS.GridLines = true;
			this.lvDS.HideSelection = false;
			this.lvDS.Location = new System.Drawing.Point(16, 135);
			this.lvDS.Name = "lvDS";
			this.lvDS.Size = new System.Drawing.Size(1024, 453);
			this.lvDS.TabIndex = 6;
			this.lvDS.UseCompatibleStateImageBehavior = false;
			this.lvDS.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Mã số";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Nhóm sản phẩm";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Tên sản phẩm";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Giá bán";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Số lượng";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Nhà cung ";
			this.columnHeader6.Width = 151;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Màu ";
			this.columnHeader7.Width = 104;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Size";
			this.columnHeader8.Width = 90;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Ghi chú";
			this.columnHeader9.Width = 97;
			// 
			// FrmXemDSHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1052, 613);
			this.Controls.Add(this.lvDS);
			this.Controls.Add(this.btnThemHang);
			this.Controls.Add(this.lblTongKet);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.cbbNhomMatHang);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmXemDSHang";
			this.Text = "Danh sách mặt hàng";
			this.Load += new System.EventHandler(this.FrmXemDSHang_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbNhomMatHang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTongKet;
        private System.Windows.Forms.Button btnThemHang;
        private System.Windows.Forms.ListView lvDS;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}