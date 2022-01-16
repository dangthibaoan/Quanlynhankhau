using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BtlQuanlynhankhau
{
    public partial class Dangnhap : Form
    {
       
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {

        }
        private void login()
        {
            if (txtTendn.Text.Length == 0 && txtMatKhau.Text.Length == 0)
                MessageBox.Show("Bạn hãy nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                if (this.txtTendn.Text.Length == 0)
                MessageBox.Show("Bạn hãy điền UserName", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                    if (this.txtMatKhau.Text.Length == 0)
                MessageBox.Show("Bạn hãy nhập Password", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-E3TVU1E\SQLBAOAN;Initial Catalog=Quanlinhankhau;Integrated Security=True");
            try
            {
                menu fm = new menu();
                Dangnhap f1 = new Dangnhap();
                conn.Open();
                string tk = txtTendn.Text;
                string mk = txtMatKhau.Text;
                string sql = "SELECT *FROM Account where Username='" + tk + "' AND Password= '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    fm.Show();
                }
                login();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
             DialogResult tb = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                Application.Exit();
        }
        private void Dangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
         if(MessageBox.Show("Thoát chương trình?","Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }
    }
}
