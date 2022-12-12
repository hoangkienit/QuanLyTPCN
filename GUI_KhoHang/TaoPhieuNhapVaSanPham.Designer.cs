namespace GUI_QuanLy
{
    partial class TaoPhieuNhapVaSanPham
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
            this.taoPNBtn = new System.Windows.Forms.Button();
            this.maPNBox = new System.Windows.Forms.TextBox();
            this.maKTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ngayNhapBox = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MASPValue = new System.Windows.Forms.TextBox();
            this.TENSPValue = new System.Windows.Forms.TextBox();
            this.GIANHAPValue = new System.Windows.Forms.TextBox();
            this.SOLUONGValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dsspView = new System.Windows.Forms.DataGridView();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsspView)).BeginInit();
            this.SuspendLayout();
            // 
            // taoPNBtn
            // 
            this.taoPNBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.taoPNBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taoPNBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.taoPNBtn.Location = new System.Drawing.Point(637, 39);
            this.taoPNBtn.Name = "taoPNBtn";
            this.taoPNBtn.Size = new System.Drawing.Size(125, 58);
            this.taoPNBtn.TabIndex = 0;
            this.taoPNBtn.Text = "Tạo phiếu";
            this.taoPNBtn.UseVisualStyleBackColor = false;
            this.taoPNBtn.Click += new System.EventHandler(this.taoPNBtn_Click);
            // 
            // maPNBox
            // 
            this.maPNBox.Location = new System.Drawing.Point(36, 57);
            this.maPNBox.Name = "maPNBox";
            this.maPNBox.Size = new System.Drawing.Size(92, 22);
            this.maPNBox.TabIndex = 1;
            this.maPNBox.TextChanged += new System.EventHandler(this.maPNBox_TextChanged);
            // 
            // maKTBox
            // 
            this.maKTBox.Location = new System.Drawing.Point(441, 57);
            this.maKTBox.Name = "maKTBox";
            this.maKTBox.Size = new System.Drawing.Size(100, 22);
            this.maKTBox.TabIndex = 3;
            this.maKTBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã phiếu nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ngày nhập";
            // 
            // ngayNhapBox
            // 
            this.ngayNhapBox.Location = new System.Drawing.Point(171, 58);
            this.ngayNhapBox.Name = "ngayNhapBox";
            this.ngayNhapBox.Size = new System.Drawing.Size(200, 22);
            this.ngayNhapBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã kế toán";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sản phẩm cần nhập";
            // 
            // MASPValue
            // 
            this.MASPValue.Location = new System.Drawing.Point(12, 202);
            this.MASPValue.Name = "MASPValue";
            this.MASPValue.Size = new System.Drawing.Size(100, 22);
            this.MASPValue.TabIndex = 9;
            // 
            // TENSPValue
            // 
            this.TENSPValue.Location = new System.Drawing.Point(139, 202);
            this.TENSPValue.Name = "TENSPValue";
            this.TENSPValue.Size = new System.Drawing.Size(185, 22);
            this.TENSPValue.TabIndex = 10;
            // 
            // GIANHAPValue
            // 
            this.GIANHAPValue.Location = new System.Drawing.Point(362, 202);
            this.GIANHAPValue.Name = "GIANHAPValue";
            this.GIANHAPValue.Size = new System.Drawing.Size(100, 22);
            this.GIANHAPValue.TabIndex = 11;
            // 
            // SOLUONGValue
            // 
            this.SOLUONGValue.Location = new System.Drawing.Point(478, 202);
            this.SOLUONGValue.Name = "SOLUONGValue";
            this.SOLUONGValue.Size = new System.Drawing.Size(100, 22);
            this.SOLUONGValue.TabIndex = 12;
            this.SOLUONGValue.TextChanged += new System.EventHandler(this.SOLUONGValue_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mã sản phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tên sản phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Giá nhập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(487, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Số lượng";
            // 
            // dsspView
            // 
            this.dsspView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsspView.Location = new System.Drawing.Point(19, 296);
            this.dsspView.Name = "dsspView";
            this.dsspView.RowHeadersWidth = 51;
            this.dsspView.RowTemplate.Height = 24;
            this.dsspView.Size = new System.Drawing.Size(743, 229);
            this.dsspView.TabIndex = 17;
            // 
            // addItemBtn
            // 
            this.addItemBtn.BackColor = System.Drawing.Color.LightCoral;
            this.addItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.addItemBtn.Location = new System.Drawing.Point(637, 183);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(125, 59);
            this.addItemBtn.TabIndex = 18;
            this.addItemBtn.Text = "Thêm sản phẩm";
            this.addItemBtn.UseVisualStyleBackColor = false;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Danh sách sản phẩm có trong kho";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(751, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 32);
            this.button1.TabIndex = 20;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TaoPhieuNhapVaSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.dsspView);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SOLUONGValue);
            this.Controls.Add(this.GIANHAPValue);
            this.Controls.Add(this.TENSPValue);
            this.Controls.Add(this.MASPValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ngayNhapBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maKTBox);
            this.Controls.Add(this.maPNBox);
            this.Controls.Add(this.taoPNBtn);
            this.Name = "TaoPhieuNhapVaSanPham";
            this.Text = "TaoPhieuNhapVaSanPham";
            this.Load += new System.EventHandler(this.TaoPhieuNhapVaSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsspView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button taoPNBtn;
        private System.Windows.Forms.TextBox maPNBox;
        private System.Windows.Forms.TextBox maKTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker ngayNhapBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MASPValue;
        private System.Windows.Forms.TextBox TENSPValue;
        private System.Windows.Forms.TextBox GIANHAPValue;
        private System.Windows.Forms.TextBox SOLUONGValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dsspView;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}