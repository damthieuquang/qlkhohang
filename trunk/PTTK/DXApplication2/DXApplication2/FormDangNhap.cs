using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using DTO;

namespace DXApplication2
{
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public FormDangNhap()
        {
            InitializeComponent();            
        }

        private bool trangThai = false;

        private void KiemTra()
        {
            string loi = "";
            if (textBoxMaNhanVien.Text == "")
            {
                loi = "Mã nhân viên không được để trống";
                trangThai = false;
            }
            else if (textBoxMatKhau.Text == "")
            {
                loi = "Mật khẩu không được để trống";
                trangThai = false;
            }
            else
            {
                NhanVienDTO nhanVienDTO = NhanVienBUS.SelectNhanVienById(textBoxMaNhanVien.Text);
                if (nhanVienDTO != null)
                {
                    if (nhanVienDTO.MatKhau.Equals(textBoxMatKhau.Text))
                    {
                        trangThai = true;
                        ThongTin.NhanVienDTO = nhanVienDTO;
                    }
                    else
                    {
                        loi = "Mật khẩu không hợp lệ";
                        trangThai = false;
                    }

                }
                else
                {
                    loi = "Mã nhân viên không hợp lệ";
                    trangThai = false;
                }
            }

            if (trangThai == true)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(loi);
            }
        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (trangThai == false)
                Application.Exit();
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            KiemTra();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonThoat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                KiemTra();
        }
    }
}