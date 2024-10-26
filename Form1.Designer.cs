namespace Form_Tra_Cứu_Điểm_Sinh_Viên
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMaSinhVien = new TextBox();
            btnTraCuu = new Button();
            label2 = new Label();
            lblKetQua = new Label();
            SuspendLayout();
            // 
            // txtMaSinhVien
            // 
            txtMaSinhVien.Location = new Point(190, 156);
            txtMaSinhVien.Name = "txtMaSinhVien";
            txtMaSinhVien.PlaceholderText = "Nhập mã sinh viên";
            txtMaSinhVien.Size = new Size(265, 27);
            txtMaSinhVien.TabIndex = 0;
            // 
            // btnTraCuu
            // 
            btnTraCuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTraCuu.Location = new Point(495, 156);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(94, 29);
            btnTraCuu.TabIndex = 2;
            btnTraCuu.Text = "Tra cứu";
            btnTraCuu.UseVisualStyleBackColor = true;
            btnTraCuu.Click += btnTraCuu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(240, 66);
            label2.Name = "label2";
            label2.Size = new Size(315, 31);
            label2.TabIndex = 3;
            label2.Text = "Form tra cứu điểm sinh viên";
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKetQua.Location = new Point(259, 238);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(223, 25);
            lblKetQua.TabIndex = 4;
            lblKetQua.Text = "Kết quả sẽ hiện thị ở đây";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblKetQua);
            Controls.Add(label2);
            Controls.Add(btnTraCuu);
            Controls.Add(txtMaSinhVien);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaSinhVien;
        private Button btnTraCuu;
        private Label label2;
        private Label lblKetQua;
    }
}
