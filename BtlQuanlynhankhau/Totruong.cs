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
    public partial class Totruong : Form
    {
        public Totruong()
        {
            InitializeComponent();
        }
        private static Totruong instance;
        public static Totruong GetInstance()
        {
            if (instance == null)
                instance = new Totruong();
            return instance;
        }
        string constr = @"Data Source=DESKTOP-E3TVU1E\SQLBAOAN;Initial Catalog=Quanlinhankhau;Integrated Security=True";
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Totruong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlinhankhauDataSet.tblTotruong' table. You can move, or remove it, as needed.
            //this.tblTotruongTableAdapter.Fill(this.quanlinhankhauDataSet.tblTotruong);
            SqlConnection con = new SqlConnection(constr);

            con.Open();
            string sqlSelect = "select *from tblTotruong";
            SqlCommand com = new SqlCommand(sqlSelect, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            drgTotruong.DataSource = dt;

            SqlDataAdapter da1 = new SqlDataAdapter("Select idTo from tblTodanpho", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            cbbmato.DataSource = dt1;
            cbbmato.ValueMember = "idTo";
            cbbmato.DisplayMember = "idTo";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spTotruong_Them";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Pk_idTotruong", txtMatt.Text));
            cmd.Parameters.Add(new SqlParameter("@sTentotruong", txttenTT.Text));
            cmd.Parameters.Add(new SqlParameter("@PK_idTo", cbbmato.Text));
          




            DataTable dt = new DataTable();
            string sqlSelect = "Select idTotruong from tblTotruong where idTotruong='" + txtMatt.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sqlSelect, con);
            da.Fill(dt);
            if (txtMatt.Text != "" && txttenTT.Text != "" && cbbmato.Text != "")
            {
                if (dt.Rows.Count > 0)
                {
                    DialogResult loi = MessageBox.Show("Mã Tổ Trưởng đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (loi == DialogResult.OK)
                        txtMatt.Clear();
                }
                else
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    DialogResult them = MessageBox.Show("Thêm thành công", "Thêm", MessageBoxButtons.OK);
                    Totruong_Load(sender, e);
                    con.Close();
                }
            }
            else
            {
                DialogResult loi = MessageBox.Show("Vui lòng nhập đầy đủ các thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "spTotruong_Sua";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Pk_idTotruong", txtMatt.Text));
            cmd.Parameters.Add(new SqlParameter("@sTentotruong", txttenTT.Text));
            cmd.Parameters.Add(new SqlParameter("@PK_idTo", cbbmato.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            DialogResult tb = MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            Totruong_Load(sender, e);
            con.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spTotruong_Xoa";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@PK_idTotruong", txtMatt.Text));



            con.Open();
            cmd.ExecuteNonQuery();
            DialogResult tb = MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
            Totruong_Load(sender, e);
            con.Close();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql = "Select * from tblTotruong ";
            if (txtTimkiem.Text != "")
                sql += "where idTotruong like '%" + txtTimkiem.Text + "%'";

            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = con;
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.Text;
            DataTable db = new DataTable();
            ad.Fill(db);
            drgTotruong.DataSource = db;
            con.Close();
        }

        private void drgTotruong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = drgTotruong.Rows[e.RowIndex];
            txtMatt.Text = row.Cells[0].Value.ToString();
            txttenTT.Text = row.Cells[1].Value.ToString();
            cbbmato.Text = row.Cells[2].Value.ToString();
            
            txtMatt.Enabled = true;
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtMatt.Clear(); txtMatt.Focus();

            txttenTT.Clear();
            cbbmato.ResetText();
          
        }
    }
}
