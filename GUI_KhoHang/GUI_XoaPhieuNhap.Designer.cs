namespace GUI_QuanLy
{
    partial class GUI_XoaPhieuNhap
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
            this.xoaBtn = new System.Windows.Forms.Button();
            this.dsPNView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.maPNBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsPNView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(557, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // xoaBtn
            // 
            this.xoaBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.xoaBtn.Location = new System.Drawing.Point(219, 29);
            this.xoaBtn.Name = "xoaBtn";
            this.xoaBtn.Size = new System.Drawing.Size(106, 45);
            this.xoaBtn.TabIndex = 1;
            this.xoaBtn.Text = "Xoá phiếu nhập";
            this.xoaBtn.UseVisualStyleBackColor = false;
            this.xoaBtn.Click += new System.EventHandler(this.xoaBtn_Click);
            // 
            // dsPNView
            // 
            this.dsPNView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsPNView.Location = new System.Drawing.Point(25, 141);
            this.dsPNView.Name = "dsPNView";
            this.dsPNView.Size = new System.Drawing.Size(534, 197);
            this.dsPNView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập mã phiếu nhập cần xóa";
            // 
            // maPNBox
            // 
            this.maPNBox.Location = new System.Drawing.Point(28, 42);
            this.maPNBox.Name = "maPNBox";
            this.maPNBox.Size = new System.Drawing.Size(144, 20);
            this.maPNBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Danh sách phiếu nhập hiện có";
            // 
            // GUI_XoaPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maPNBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dsPNView);
            this.Controls.Add(this.xoaBtn);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GUI_XoaPhieuNhap";
            this.Text = "GUI_XoaPhieuNhap";
            this.Load += new System.EventHandler(this.GUI_XoaPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPNView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button xoaBtn;
        private System.Windows.Forms.DataGridView dsPNView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maPNBox;
        private System.Windows.Forms.Label label2;
    }
}