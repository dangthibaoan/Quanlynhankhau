using BtlQuanlynhankhau.QuanlinhankhauDataSetTableAdapters;
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
    public partial class Todanpho : Form
    {
        public Todanpho()
        {
            InitializeComponent();
        }
        private static Todanpho instance;
        public static Todanpho GetInstance()
        {
            if (instance == null)
                instance = new Todanpho();
            return instance;
        }
        string constr = @"Data Source=DESKTOP-E3TVU1E\SQLBAOAN;Initial Catalog=Quanlinhankhau;Integrated Security=True";
       

       
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbbmaphuong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtmato_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttencbca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttentotruong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsotamtru_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsohotline_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsothuongtru_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsotamvang_TextChanged(object sender, EventArgs e)
        {

        }
     
        private void btnsua_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
           
            cmd.Connection = con;
            cmd.CommandText = "spTodanpho_Sua";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Pk_idTodanpho", txtmato.Text));
            cmd.Parameters.Add(new SqlParameter("@Pk_idPhuong", cbbmaphuong.Text));
            cmd.Parameters.Add(new SqlParameter("@sTento", txttento.Text));
            cmd.Parameters.Add(new SqlParameter("@sTencbca", txttencbca.Text));
            cmd.Parameters.Add(new SqlParameter("@sTentotruong", txttentotruong.Text));
            cmd.Parameters.Add(new SqlParameter("@iSotamtru", txtsotamtru.Text));
            cmd.Parameters.Add(new SqlParameter("@sSĐT", txtsohotline.Text));
            cmd.Parameters.Add(new SqlParameter("@iSotamvang", txtsotamvang.Text));
            cmd.Parameters.Add(new SqlParameter("@iSothuongtru", txtsothuongtru.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            DialogResult tb = MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            Todanpho_Load(sender, e);
            con.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spTodanpho_Them";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Pk_idTodanpho", txtmato.Text));
            cmd.Parameters.Add(new SqlParameter("@Pk_idPhuong", cbbmaphuong.Text));
            cmd.Parameters.Add(new SqlParameter("@sTento", txttento.Text));
            cmd.Parameters.Add(new SqlParameter("@sTencbca", txttencbca.Text));
            cmd.Parameters.Add(new SqlParameter("@sTentotruong", txttentotruong.Text));
            cmd.Parameters.Add(new SqlParameter("@iSotamtru", txtsotamtru.Text));
            cmd.Parameters.Add(new SqlParameter("@sSĐT", txtsohotline.Text));
            cmd.Parameters.Add(new SqlParameter("@iSotamvang", txtsotamvang.Text));
            cmd.Parameters.Add(new SqlParameter("@iSothuongtru", txtsothuongtru.Text));

            DataTable dt = new DataTable();
            string sqlSelect = "Select idTo from tblTodanpho where idTo='" + txtmato.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sqlSelect, con);
            da.Fill(dt);
            if (txtmato.Text != "" && cbbmaphuong.Text != "" && txttento.Text != "" && txttencbca.Text != ""&& txttentotruong.Text!="" && txtsohotline.Text!=""&& txtsotamtru.Text!=""&& txtsotamvang.Text!=""&&txtsothuongtru.Text!="")
            {
                if (dt.Rows.Count > 0)
                {
                    DialogResult loi = MessageBox.Show("Mã tổ đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (loi == DialogResult.OK)
                        txtmato.Clear();
                }
                else
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    DialogResult them = MessageBox.Show("Thêm thành công", "Thêm", MessageBoxButtons.OK);
                    Todanpho_Load(sender, e);
                    con.Close();
                }
            }
            else
            {
                DialogResult loi = MessageBox.Show("Vui lòng nhập đầy đủ các thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void drgTodanpho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = drgTodanpho.Rows[e.RowIndex];
            txtmato.Text = row.Cells[0].Value.ToString();
            cbbmaphuong.Text = row.Cells[1].Value.ToString();
            txttento.Text = row.Cells[2].Value.ToString();
            txttencbca.Text = row.Cells[3].Value.ToString();
            txttentotruong.Text = row.Cells[4].Value.ToString();
            txtsohotline.Text = row.Cells[5].Value.ToString();
            txtsotamtru.Text = row.Cells[6].Value.ToString();
            txtsotamvang.Text = row.Cells[7].Value.ToString();
            txtsothuongtru.Text = row.Cells[8].Value.ToString();
            txtmato.Enabled = true;
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmato.Clear(); txtmato.Focus();
            
            txttento.Clear();
            txttencbca.Clear();
            txttentotruong.Clear();
            txtsohotline.Clear();
            txtsotamtru.Clear();
            txtsotamvang.Clear();
            txtsothuongtru.ResetText();

        }

        private void Todanpho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlinhankhauDataSet.tblPhuong' table. You can move, or remove it, as needed.
            this.tblPhuongTableAdapter.Fill(this.quanlinhankhauDataSet.tblPhuong);
            // TODO: This line of code loads data into the 'quanlinhankhauDataSet.tblPhuong' table. You can move, or remove it, as needed.
            // this.tblPhuongTableAdapter.Fill(this.quanlinhankhauDataSet.tblPhuong);
            // TODO: This line of code loads data into the 'quanlinhankhauDataSet.tblTodanpho' table. You can move, or remove it, as needed.
            // this.tblTodanphoTableAdapter.Fill(this.quanlinhankhauDataSet.tblTodanpho);
            SqlConnection con = new SqlConnection(constr);

            con.Open();
            string sqlSelect = "select *from tblTodanpho";
            SqlCommand com = new SqlCommand(sqlSelect, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            drgTodanpho.DataSource = dt;

            SqlDataAdapter da1 = new SqlDataAdapter("Select idPhuong from tblPhuong", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            con.Close();
        }
    }
    }

