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
    public partial class Canbo : Form
    {
        public Canbo()
        {
            InitializeComponent();
        }
        private static Canbo instance;
        public static Canbo GetInstance()
        {
            if (instance == null)
                instance = new Canbo();
            return instance;
        }
        string constr = @"Data Source=DESKTOP-E3TVU1E\SQLBAOAN;Initial Catalog=Quanlinhankhau;Integrated Security=True";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Canbo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlinhankhauDataSet.tblTodanpho' table. You can move, or remove it, as needed.
            //this.tblTodanphoTableAdapter.Fill(this.quanlinhankhauDataSet.tblTodanpho);

            SqlConnection con = new SqlConnection(constr);
           
            con.Open();
            string sqlSelect = "select *from tblCanbo";
            SqlCommand com = new SqlCommand(sqlSelect, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            drgCanbo.DataSource = dt;
            
            SqlDataAdapter da1 = new SqlDataAdapter("Select idTo from tblTodanpho", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            cbbmato.DataSource = dt1;
            cbbmato.ValueMember = "idTo";
            cbbmato.DisplayMember = "idTo";
            cbbTinhtrang.Items.Add("Đang Làm");
            cbbTinhtrang.Items.Add("đã mất");
            con.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spCanbo_Them";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@PK_idCanbo", txtmaCB.Text));
            cmd.Parameters.Add(new SqlParameter("@PK_idTo", cbbmato.Text));
            cmd.Parameters.Add(new SqlParameter("@sTenCB", txttenCB.Text));
            cmd.Parameters.Add(new SqlParameter("@sTinhtrang", cbbTinhtrang.Text));
            

           

            DataTable dt = new DataTable();
            string sqlSelect = "Select idCanbo from tblCanbo where idCanbo='" + txtmaCB.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sqlSelect, con);
            da.Fill(dt);
            if (txtmaCB.Text != "" && cbbmato.Text != "" && txttenCB.Text != "" && cbbTinhtrang.Text != "" )
            {
                if (dt.Rows.Count > 0)
                {
                    DialogResult loi = MessageBox.Show("Mã Cán Bộ đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (loi == DialogResult.OK)
                        txtmaCB.Clear();
                }
                else
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    DialogResult them = MessageBox.Show("Thêm thành công", "Thêm", MessageBoxButtons.OK);
                    Canbo_Load(sender, e);
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
            cmd.CommandText = "spCanbo_Sua";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@PK_idCanbo", txtmaCB.Text));
            cmd.Parameters.Add(new SqlParameter("@PK_idTo", cbbmato.Text));
            cmd.Parameters.Add(new SqlParameter("@sTenCB", txttenCB.Text));
            cmd.Parameters.Add(new SqlParameter("@sTinhtrang", cbbTinhtrang.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            DialogResult tb = MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            Canbo_Load(sender, e);
            con.Close();
        }

        private void drgCanbo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = drgCanbo.Rows[e.RowIndex];
            txtmaCB.Text = row.Cells[0].Value.ToString();
            cbbmato.Text = row.Cells[1].Value.ToString();
            txttenCB.Text = row.Cells[2].Value.ToString();
            cbbTinhtrang.Text = row.Cells[3].Value.ToString();
            txtmaCB.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spCanbo_Xoa";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@PK_idCanbo", txtmaCB.Text));



            con.Open();
            cmd.ExecuteNonQuery();
            DialogResult tb = MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
            Canbo_Load(sender, e);
            con.Close();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql = "Select * from tblCanbo ";
            if (txtTimkiem.Text != "")
                sql += "where idCanbo like '%" + txtTimkiem.Text + "%'";

            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = con;
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.Text;
            DataTable db = new DataTable();
            ad.Fill(db);
            drgCanbo.DataSource = db;
            con.Close();
        }
    }
}
