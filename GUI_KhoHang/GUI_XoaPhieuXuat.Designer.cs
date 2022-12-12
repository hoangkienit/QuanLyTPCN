namespace GUI_QuanLy
{
    partial class GUI_XoaPhieuXuat
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
            this.xoaPXBtn = new System.Windows.Forms.Button();
            this.dsPXView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.maPXBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsPXView)).BeginInit();
            this.SuspendLayout();
            // 
            // xoaPXBtn
            // 
            this.xoaPXBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.xoaPXBtn.Location = new System.Drawing.Point(333, 13);
            this.xoaPXBtn.Name = "xoaPXBtn";
            this.xoaPXBtn.Size = new System.Drawing.Size(119, 63);
            this.xoaPXBtn.TabIndex = 0;
            this.xoaPXBtn.Text = "Xóa phiếu xuất";
            this.xoaPXBtn.UseVisualStyleBackColor = false;
            this.xoaPXBtn.Click += new System.EventHandler(this.xoaPXBtn_Click);
            // 
            // dsPXView
            // 
            this.dsPXView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsPXView.Location = new System.Drawing.Point(26, 144);
            this.dsPXView.Name = "dsPXView";
            this.dsPXView.Size = new System.Drawing.Size(746, 258);
            this.dsPXView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập mã phiếu xuất cần xóa";
            // 
            // maPXBox
            // 
            this.maPXBox.Location = new System.Drawing.Point(26, 34);
            this.maPXBox.Name = "maPXBox";
            this.maPXBox.Size = new System.Drawing.Size(271, 20);
            this.maPXBox.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(744, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Danh sách phiếu xuất hiện có";
            // 
            // GUI_XoaPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.maPXBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dsPXView);
            this.Controls.Add(this.xoaPXBtn);
            this.Name = "GUI_XoaPhieuXuat";
            this.Text = "GUI_XoaPhieuXuat";
            this.Load += new System.EventHandler(this.GUI_XoaPhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPXView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button xoaPXBtn;
        private System.Windows.Forms.DataGridView dsPXView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maPXBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}