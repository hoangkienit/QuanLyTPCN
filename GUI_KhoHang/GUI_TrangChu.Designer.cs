namespace GUI_QuanLy
{
    partial class GUI_TrangChu
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
            this.qlPNBtn = new System.Windows.Forms.Button();
            this.qlPXBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.sanphamView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sanphamView)).BeginInit();
            this.SuspendLayout();
            // 
            // qlPNBtn
            // 
            this.qlPNBtn.Location = new System.Drawing.Point(11, 62);
            this.qlPNBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.qlPNBtn.Name = "qlPNBtn";
            this.qlPNBtn.Size = new System.Drawing.Size(119, 46);
            this.qlPNBtn.TabIndex = 0;
            this.qlPNBtn.Text = "Quản lý phiếu nhập";
            this.qlPNBtn.UseVisualStyleBackColor = true;
            this.qlPNBtn.Click += new System.EventHandler(this.qlPNBtn_Click);
            // 
            // qlPXBtn
            // 
            this.qlPXBtn.Location = new System.Drawing.Point(11, 173);
            this.qlPXBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.qlPXBtn.Name = "qlPXBtn";
            this.qlPXBtn.Size = new System.Drawing.Size(119, 45);
            this.qlPXBtn.TabIndex = 1;
            this.qlPXBtn.Text = "Quản lý phiếu xuất";
            this.qlPXBtn.UseVisualStyleBackColor = true;
            this.qlPXBtn.Click += new System.EventHandler(this.qlPXBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 284);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "Thống kê ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // sanphamView
            // 
            this.sanphamView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sanphamView.Location = new System.Drawing.Point(166, 34);
            this.sanphamView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sanphamView.Name = "sanphamView";
            this.sanphamView.RowHeadersWidth = 51;
            this.sanphamView.RowTemplate.Height = 24;
            this.sanphamView.Size = new System.Drawing.Size(458, 333);
            this.sanphamView.TabIndex = 3;
            // 
            // GUI_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 395);
            this.Controls.Add(this.sanphamView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.qlPXBtn);
            this.Controls.Add(this.qlPNBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GUI_TrangChu";
            this.Text = "GUI_TrangChu";
            this.Load += new System.EventHandler(this.GUI_TrangChu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sanphamView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button qlPNBtn;
        private System.Windows.Forms.Button qlPXBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView sanphamView;
    }
}