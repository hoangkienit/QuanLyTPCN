namespace GUI_QuanLy
{
    partial class GUI_TaoPhieuXuat
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maPXBox = new System.Windows.Forms.TextBox();
            this.maKT = new System.Windows.Forms.TextBox();
            this.maSP = new System.Windows.Forms.TextBox();
            this.SL = new System.Windows.Forms.TextBox();
            this.giaXuat = new System.Windows.Forms.TextBox();
            this.ngayXuatBox = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(322, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tạo phiếu xuất";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(755, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã phiếu xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày xuất";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã kế toán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Đơn giá";
            // 
            // maPXBox
            // 
            this.maPXBox.Location = new System.Drawing.Point(30, 66);
            this.maPXBox.Name = "maPXBox";
            this.maPXBox.Size = new System.Drawing.Size(100, 20);
            this.maPXBox.TabIndex = 8;
            // 
            // maKT
            // 
            this.maKT.Location = new System.Drawing.Point(439, 69);
            this.maKT.Name = "maKT";
            this.maKT.Size = new System.Drawing.Size(100, 20);
            this.maKT.TabIndex = 10;
            // 
            // maSP
            // 
            this.maSP.Location = new System.Drawing.Point(30, 248);
            this.maSP.Name = "maSP";
            this.maSP.Size = new System.Drawing.Size(100, 20);
            this.maSP.TabIndex = 11;
            // 
            // SL
            // 
            this.SL.Location = new System.Drawing.Point(169, 248);
            this.SL.Name = "SL";
            this.SL.Size = new System.Drawing.Size(200, 20);
            this.SL.TabIndex = 12;
            // 
            // giaXuat
            // 
            this.giaXuat.Location = new System.Drawing.Point(439, 248);
            this.giaXuat.Name = "giaXuat";
            this.giaXuat.Size = new System.Drawing.Size(100, 20);
            this.giaXuat.TabIndex = 13;
            // 
            // ngayXuatBox
            // 
            this.ngayXuatBox.Location = new System.Drawing.Point(169, 66);
            this.ngayXuatBox.Name = "ngayXuatBox";
            this.ngayXuatBox.Size = new System.Drawing.Size(200, 20);
            this.ngayXuatBox.TabIndex = 14;
            // 
            // GUI_TaoPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ngayXuatBox);
            this.Controls.Add(this.giaXuat);
            this.Controls.Add(this.SL);
            this.Controls.Add(this.maSP);
            this.Controls.Add(this.maKT);
            this.Controls.Add(this.maPXBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "GUI_TaoPhieuXuat";
            this.Text = "GUI_TaoPhieuXuat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox maPXBox;
        private System.Windows.Forms.TextBox maKT;
        private System.Windows.Forms.TextBox maSP;
        private System.Windows.Forms.TextBox SL;
        private System.Windows.Forms.TextBox giaXuat;
        private System.Windows.Forms.DateTimePicker ngayXuatBox;
    }
}