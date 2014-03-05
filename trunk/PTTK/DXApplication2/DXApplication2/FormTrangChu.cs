using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication2
{
    public partial class FormTrangChu : DevExpress.XtraEditors.XtraForm
    {
        public FormTrangChu()
        {
            InitializeComponent();            
            ShowData();
        }

        public static DataTable GetData()
        {
            DataTable tb = new DataTable();

            string ConnectionString = @"Data Source=THIEUQUANG\SQLEXPRESS;Initial Catalog=QLKhoHang;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string sql = "select * from nhanvien";

            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandType = CommandType.Text;
            command.CommandText = sql;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(tb);

            con.Close();
            return tb;
        }

        private void ShowData()
        {
            DataTable tb = new DataTable();
            tb = GetData();

            int column = tb.Columns.Count;
         
            
                
           
            
        }

        private void DonHang_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            FormDangNhap form = new FormDangNhap();
            form.MdiParent = this;
            form.Show();
            
        }
    }
}
