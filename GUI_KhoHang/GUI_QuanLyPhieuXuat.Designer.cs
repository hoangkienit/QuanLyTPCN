namespace GUI_QuanLy
{
    partial class GUI_QuanLyPhieuXuat
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
            this.dsPXView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.taoBtn = new System.Windows.Forms.Button();
            this.xoaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsPXView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách phiếu xuất";
            // 
            // dsPXView
            // 
            this.dsPXView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsPXView.Location = new System.Drawing.Point(15, 42);
            this.dsPXView.Name = "dsPXView";
            this.dsPXView.Size = new System.Drawing.Size(605, 356);
            this.dsPXView.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(751, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // taoBtn
            // 
            this.taoBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.taoBtn.Location = new System.Drawing.Point(658, 88);
            this.taoBtn.Name = "taoBtn";
            this.taoBtn.Size = new System.Drawing.Size(107, 59);
            this.taoBtn.TabIndex = 3;
            this.taoBtn.Text = "Tạo phiếu xuất";
            this.taoBtn.UseVisualStyleBackColor = false;
            this.taoBtn.Click += new System.EventHandler(this.taoBtn_Click);
            // 
            // xoaBtn
            // 
            this.xoaBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.xoaBtn.Location = new System.Drawing.Point(658, 236);
            this.xoaBtn.Name = "xoaBtn";
            this.xoaBtn.Size = new System.Drawing.Size(107, 66);
            this.xoaBtn.TabIndex = 4;
            this.xoaBtn.Text = "Xóa phiếu xuất";
            this.xoaBtn.UseVisualStyleBackColor = false;
            this.xoaBtn.Click += new System.EventHandler(this.xoaBtn_Click);
            // 
            // GUI_QuanLyPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xoaBtn);
            this.Controls.Add(this.taoBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dsPXView);
            this.Controls.Add(this.label1);
            this.Name = "GUI_QuanLyPhieuXuat";
            this.Text = "GUI_PhieuXuat";
            this.Load += new System.EventHandler(this.GUI_PhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPXView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dsPXView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button taoBtn;
        private System.Windows.Forms.Button xoaBtn;
    }
}