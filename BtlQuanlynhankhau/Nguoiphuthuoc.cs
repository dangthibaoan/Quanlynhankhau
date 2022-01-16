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
    public partial class Nguoiphuthuoc : Form
    {
        public Nguoiphuthuoc()
        {
            InitializeComponent();
        }
        private static Nguoiphuthuoc instance;
        public static Nguoiphuthuoc GetInstance()
        {
            if (instance == null)
                instance = new Nguoiphuthuoc();
            return instance;
        }
        string constr = @"Data Source=DESKTOP-E3TVU1E\SQLBAOAN;Initial Catalog=Quanlinhankhau;Integrated Security=True";
        private void NguoiPhuThuoc_Load_1(object sender, EventArgs e)
        {
            
        }
        void loaddata()
        {
            SqlConnection conection;
            SqlCommand command;
            conection = new SqlConnection(constr);
            conection.Open();
            command = conection.CreateCommand();
            command.CommandText = "select * from tblNguoiphuthuoc";
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = command;
            dt.Clear();
            da.Fill(dt);
            dgrNguoiphuthuoc.DataSource = dt;
            
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spNguoiphuthuoc_Them";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@PK_idNguoiphuthuoc", txtmanpt.Text));
            cmd.Parameters.Add(new SqlParameter("@PK_idTo", cbbmato.Text));
            cmd.Parameters.Add(new SqlParameter("@PK_idNhankhau", cbbmachuho.Text));
            cmd.Parameters.Add(new SqlParameter("@sTennhankhau", txttenChuho.Text));
            cmd.Parameters.Add(new SqlParameter("@sTenkhac", txttenKhac.Text));
            
            cmd.Parameters.Add(new SqlParameter("@dNgaysinh", Convert.ToDateTime(datens.Text, new CultureInfo("vi-vn"))));
            cmd.Parameters.Add(new SqlParameter("@sQuequan", txtqueQuan.Text));
            cmd.Parameters.Add(new SqlParameter("@sGioitinh", cbbgioiTinh.Text));
            cmd.Parameters.Add(new SqlParameter("@sCMND", txtCMND.Text));
            cmd.Parameters.Add(new SqlParameter("@sDantoc", txtdanToc.Text));
            cmd.Parameters.Add(new SqlParameter("@sNghenghiep", txtngheNghiep.Text));
            cmd.Parameters.Add(new SqlParameter("@sQHchuho", txtqhChuho.Text));
            cmd.Parameters.Add(new SqlParameter("@sTinhtrang", cbbtinhTrang.Text));

            DataTable dt = new DataTable();
            string sqlSelect = "Select idNguoiphuthuoc from tblNguoiphuthuoc where idNguoiphuthuoc='" + txtmanpt.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sqlSelect, con);
            da.Fill(dt);
            if (txtmanpt.Text != "" && cbbmato.Text != "" && cbbmachuho.Text != "" && txttenChuho.Text != "" && txttenKhac.Text != "" &&   datens.Text != "" && txtqueQuan.Text != "" && cbbgioiTinh.Text != "" && txtCMND.Text!="" && txtdanToc.Text != "" && txtngheNghiep.Text!="" &&txtqhChuho.Text!=""&&cbbtinhTrang.Text!="")
            {
                if (dt.Rows.Count > 0)
                {
                    DialogResult loi = MessageBox.Show("Mã người phụ thuộc đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (loi == DialogResult.OK)
                        txtmanpt.Clear();
                }
                else
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    DialogResult them = MessageBox.Show("Thêm thành công", "Thêm", MessageBoxButtons.OK);
                    NguoiPhuThuoc_Load_1(sender, e);
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
            cmd.CommandText = "spNguoiphuthuoc_Sua";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@PK_idNguoiphuthuoc", txtmanpt.Text));
            cmd.Parameters.Add(new SqlParameter("@PK_idTo", cbbmato.Text));
            cmd.Parameters.Add(new SqlParameter("@PK_idNhankhau", cbbmachuho.Text));
            cmd.Parameters.Add(new SqlParameter("@sTennhankhau", txttenChuho.Text));
            cmd.Parameters.Add(new SqlParameter("@sTenkhac", txttenKhac.Text));
           
            cmd.Parameters.Add(new SqlParameter("@dNgaysinh", Convert.ToDateTime(datens.Text, new CultureInfo("vi-vn"))));
            cmd.Parameters.Add(new SqlParameter("@sQuequan", txtqueQuan.Text));
            cmd.Parameters.Add(new SqlParameter("@sGioitinh", cbbgioiTinh.Text));
            cmd.Parameters.Add(new SqlParameter("@sCMND", txtCMND.Text));
            cmd.Parameters.Add(new SqlParameter("@sDantoc", txtdanToc.Text));
            cmd.Parameters.Add(new SqlParameter("@sNghenghiep", txtngheNghiep.Text));
            cmd.Parameters.Add(new SqlParameter("@sQHchuho", txtqhChuho.Text));
            cmd.Parameters.Add(new SqlParameter("@sTinhtrang", cbbtinhTrang.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            DialogResult tb = MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            NguoiPhuThuoc_Load_1(sender, e);
            con.Close();
        }

        private void dgrNguoiphuthuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgrNguoiphuthuoc.Rows[e.RowIndex];
            txtmanpt.Text = row.Cells[0].Value.ToString();
            cbbmato.Text = row.Cells[1].Value.ToString();
            cbbmachuho.Text = row.Cells[2].Value.ToString();
            txttenChuho.Text = row.Cells[3].Value.ToString();
            txttenKhac.Text = row.Cells[4].Value.ToString();
            datens.Text = row.Cells[5].Value.ToString();
            txtqueQuan.Text = row.Cells[6].Value.ToString();
            
            cbbgioiTinh.Text = row.Cells[7].Value.ToString();
            txtCMND.Text = row.Cells[8].Value.ToString();
            txtdanToc.Text = row.Cells[9].Value.ToString();
            txtngheNghiep.Text = row.Cells[10].Value.ToString();
            txtqhChuho.Text = row.Cells[11].Value.ToString();
            cbbtinhTrang.Text = row.Cells[12].Value.ToString();
            txtmanpt.Enabled = true;
        }

        private void Nguoiphuthuoc_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlinhankhauDataSet.tblNguoiphuthuoc' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'quanlinhankhauDataSet.tblNguoiphuthuoc' table. You can move, or remove it, as needed.
            //this.tblNguoiphuthuocTableAdapter.Fill(this.quanlinhankhauDataSet.tblNguoiphuthuoc);
            SqlConnection con = new SqlConnection(constr);
            con.Open();

            SqlDataAdapter da1 = new SqlDataAdapter("Select idTo from tblTodanpho", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            cbbmato.DataSource = dt1;
            cbbmato.ValueMember = "idTo";
            cbbmato.DisplayMember = "idTo";
            loaddata();
            cbbgioiTinh.Items.Add("Nam");
            cbbgioiTinh.Items.Add("Nữ");
            cbbtinhTrang.Items.Add("thường trú");
            cbbtinhTrang.Items.Add("tạm trú");
            cbbtinhTrang.Items.Add("tạm vắng");
            cbbtinhTrang.Items.Add("mới sinh");
            cbbtinhTrang.Items.Add("chuyển đi");
            cbbtinhTrang.Items.Add("đã mất");
            SqlDataAdapter da2 = new SqlDataAdapter("Select idNhankhau,sTennhankhau from tblNhankhau", con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cbbmachuho.DataSource = dt2;
            cbbmachuho.ValueMember = "sTennhankhau";
            cbbmachuho.DisplayMember = "idNhankhau";
            con.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spNguoiphuthuoc_Xoa";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@PK_idNguoiphuthuoc", txtmanpt.Text));



            con.Open();
            cmd.ExecuteNonQuery();
            DialogResult tb = MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
            NguoiPhuThuoc_Load_1(sender, e);
            con.Close();
        }

        private void btntimKiem_Click(object sender, EventArgs e)
        {
            string sql = "Select * from tblNguoiphuthuoc ";
            if (txttimKiem.Text != "")
                sql += "where idNguoiphuthuoc like '%" + txttimKiem.Text + "%'";

            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = con;
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.Text;
            DataTable db = new DataTable();
            ad.Fill(db);
            dgrNguoiphuthuoc.DataSource = db;
            con.Close();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtmanpt.Clear(); txtmanpt.Focus();

            cbbmato.ResetText();
            cbbmachuho.ResetText();
            txttenChuho.Clear();
            txttenKhac.Clear();
            datens.ResetText();
            txtqueQuan.Clear();
            cbbgioiTinh.ResetText();
            txtCMND.Clear();
            txtdanToc.Clear();
            txtngheNghiep.Clear();
            txtqhChuho.Clear();
            cbbtinhTrang.ResetText();
        }
    }
}
