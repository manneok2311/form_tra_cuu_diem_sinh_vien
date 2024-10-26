using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Form_Tra_Cứu_Điểm_Sinh_Viên
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> dsachsinhvien;
        public Form1()
        {
            InitializeComponent();
            dsachsinhvien = new Dictionary<string, string>
            {
                { "SV01", "Điểm: 3.4"},
                { "SV02", "Điểm:8.9"},
                { "SV03", "Điểm:5.8"},
                { "SV04", "Điểm:10"}
            };
        }
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            string masinhvien=txtMaSinhVien.Text.Trim();
            if(dsachsinhvien.ContainsKey(masinhvien) )
            {
                lblKetQua.Text = $"Mã sinh viên:{masinhvien}  -  {dsachsinhvien[masinhvien]}";
            }
            else
            {
                lblKetQua.Text = "Không có sinh viên trong danh sách!!";
            }
        }
    }
}
