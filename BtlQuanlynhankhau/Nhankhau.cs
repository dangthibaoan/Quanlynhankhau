using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BtlQuanlynhankhau
{
    public partial class Nhankhau : Form
    {
        public Nhankhau()
        {
            InitializeComponent();
        }
        private static Nhankhau instance;
        public static Nhankhau GetInstance()
        {
            if (instance == null)
                instance = new Nhankhau();
            return instance;
        }
        string constr = @"Data Source=DESKTOP-E3TVU1E\SQLBAOAN;Initial Catalog=Quanlinhankhau;Integrated Security=True";
      
        private void Nhankhau_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlinhankhauDataSet.tblNhankhau' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'quanlinhankhauDataSet.tblTodanpho' table. You can move, or remove it, as needed.
            //this.tblTodanphoTableAdapter.Fill(this.quanlinhankhauDataSet.tblTodanpho);
            SqlConnection con = new SqlConnection(constr);
            con.Open();

            SqlDataAdapter da1 = new SqlDataAdapter("Select idTo from tblTodanpho", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            cbbmato.DataSource = dt1;
            cbbmato.ValueMember = "idTo";
            cbbmato.DisplayMember = "idTo";
            loaddata();
            cbbgioitinh.Items.Add("Nam");
            cbbgioitinh.Items.Add("Nữ");
            cbbttht.Items.Add("thường trú");
            cbbttht.Items.Add("tạm trú");
            cbbttht.Items.Add("tạm vắng");
            cbbttht.Items.Add("mới sinh");
            cbbttht.Items.Add("chuyển đi");
            cbbttht.Items.Add("đã mất");
           
            con.Close();
        }
        void loaddata()
        {
            SqlConnection conection;
            SqlCommand command;
            conection = new SqlConnection(constr);
            conection.Open();
            command = conection.CreateCommand();
            command.CommandText = "select * from tblNhankhau";
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = command;
            dt.Clear();
            da.Fill(dt);
            dgrnhankhau.DataSource = dt;

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "spNhankhau_Sua";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@PK_idNhankhau", txtmank.Text));
            cmd.Parameters.Add(new SqlParameter("@PK_idTo", cbbmato.Text));
            cmd.Parameters.Add(new SqlParameter("@sTennhankhau", txthoTen.Text));
            cmd.Parameters.Add(new SqlParameter("@sTenkhac", txttenKhac.Text));
            cmd.Parameters.Add(new SqlParameter("@dNgaysinh", Convert.ToDateTime(datens.Text, new CultureInfo("vi-vn"))));
            cmd.Parameters.Add(new SqlParameter("@sQuequan", txtqueQuan.Text));
            cmd.Parameters.Add(new SqlParameter("@sGioitinh", cbbgioitinh.Text));
            cmd.Parameters.Add(new SqlParameter("@sCMND", txtCMND.Text));
            cmd.Parameters.Add(new SqlParameter("@sDantoc", txtDantoc.Text));
            cmd.Parameters.Add(new SqlParameter("@sNghenghiep", txtnghenghiep.Text));
            cmd.Parameters.Add(new SqlParameter("@sTinhtrang", cbbttht.Text));

            con.Open();
            cmd.ExecuteNonQuery();
            DialogResult tb = MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            Nhankhau_Load(sender, e);
            con.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spNhankhau_Them";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@PK_idNhankhau", txtmank.Text));
            cmd.Parameters.Add(new SqlParameter("@PK_idTo", cbbmato.Text));
            cmd.Parameters.Add(new SqlParameter("@sTennhankhau", txthoTen.Text));
            cmd.Parameters.Add(new SqlParameter("@sTenkhac", txttenKhac.Text));
            cmd.Parameters.Add(new SqlParameter("@dNgaysinh", Convert.ToDateTime(datens.Text, new CultureInfo("vi-vn"))));
            cmd.Parameters.Add(new SqlParameter("@sQuequan", txtqueQuan.Text));
            cmd.Parameters.Add(new SqlParameter("@sGioitinh", cbbgioitinh.Text));
            cmd.Parameters.Add(new SqlParameter("@sCMND", txtCMND.Text));
            cmd.Parameters.Add(new SqlParameter("@sDantoc", txtDantoc.Text));
            cmd.Parameters.Add(new SqlParameter("@sNghenghiep", txtnghenghiep.Text));
            cmd.Parameters.Add(new SqlParameter("@sTinhtrang", cbbttht.Text));

            DataTable dt = new DataTable();
            string sqlSelect = "Select idNhankhau from tblNhankhau where idNhankhau='" + txtmank.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sqlSelect, con);
            da.Fill(dt);
            if (txtmank.Text != "" && cbbmato.Text != "" && txthoTen.Text != "" && txttenKhac.Text != "" && datens.Text != "" && txtqueQuan.Text != "" && cbbgioitinh.Text != "" && txtCMND.Text != "" && txtDantoc.Text != "" && txtnghenghiep.Text != "" && cbbttht.Text != "")
            {
                if (dt.Rows.Count > 0)
                {
                    DialogResult loi = MessageBox.Show("Mã Nhân khẩu đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (loi == DialogResult.OK)
                        txtmank.Clear();
                }
                else
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    DialogResult them = MessageBox.Show("Thêm thành công", "Thêm", MessageBoxButtons.OK);
                    Nhankhau_Load(sender, e);
                    con.Close();
                }
            }
            else
            {
                DialogResult loi = MessageBox.Show("Vui lòng nhập đầy đủ các thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgrnhankhau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgrnhankhau.Rows[e.RowIndex];
            txtmank.Text = row.Cells[0].Value.ToString();
            cbbmato.Text = row.Cells[1].Value.ToString();
            txthoTen.Text = row.Cells[2].Value.ToString();
            txttenKhac.Text = row.Cells[3].Value.ToString();
            datens.Text = row.Cells[4].Value.ToString();
            txtqueQuan.Text = row.Cells[5].Value.ToString();
            cbbgioitinh.Text = row.Cells[6].Value.ToString();
            txtCMND.Text = row.Cells[7].Value.ToString();
            txtDantoc.Text = row.Cells[8].Value.ToString();
            txtnghenghiep.Text = row.Cells[9].Value.ToString();
            cbbttht.Text = row.Cells[10].Value.ToString();
            txtmank.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spNhankhau_Xoa";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@PK_idNhankhau", txtmank.Text));



            con.Open();
            cmd.ExecuteNonQuery();
            DialogResult tb = MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
            Nhankhau_Load(sender, e);
            con.Close();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql = "Select * from tblNhanKhau ";
            if (txtSearch.Text != "")
                sql += "where idNhankhau like '%" + txtSearch.Text + "%'";

            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = con;
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.Text;
            DataTable db = new DataTable();
            ad.Fill(db);
            dgrnhankhau.DataSource = db;
            con.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtmank.Clear(); txtmank.Focus();

            cbbmato.ResetText();
            txthoTen.Clear();
            txttenKhac.Clear();
            txttenKhac.Clear();
            datens.ResetText();
            txtqueQuan.Clear();
            cbbgioitinh.ResetText();
            txtCMND.Clear();
            txtDantoc.Clear();
            txtnghenghiep.Clear();
            
            cbbttht.ResetText();
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            DSNK dSNK = new DSNK();
            dSNK.Show();
        }
    }
}
