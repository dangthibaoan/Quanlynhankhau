using CrystalDecisions.Windows.Forms;

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
    public partial class Phuong : Form
    {
        public Phuong()
        {
            InitializeComponent();
        }
        private static Phuong instance;
        public static Phuong GetInstance()
        {
            if (instance == null)
                instance = new Phuong();
            return instance;
        }

        string constr = @"Data Source=DESKTOP-E3TVU1E\SQLBAOAN;Initial Catalog=Quanlinhankhau;Integrated Security=True";

       
       
     
        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "spPhuong_Sua";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@PK_idPhuong", txtMaphuong.Text));
            cmd.Parameters.Add(new SqlParameter("@sTenphuong", txtTenphuong.Text));
            cmd.Parameters.Add(new SqlParameter("@iSoto", txtSotodanpho.Text));
            cmd.Parameters.Add(new SqlParameter("@iSoNK", txtsoNK.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            DialogResult tb = MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            Phuong_Load(sender, e);
            con.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Phuong_Them";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@PK_idPhuong", txtMaphuong.Text));
            cmd.Parameters.Add(new SqlParameter("@sTenphuong", txtTenphuong.Text));
            cmd.Parameters.Add(new SqlParameter("@iSoto", txtSotodanpho.Text));
            cmd.Parameters.Add(new SqlParameter("@iSoNK", txtsoNK.Text));

            DataTable dt = new DataTable();
            string sqlSelect = "Select idPhuong from tblPhuong where idPhuong='" + txtMaphuong.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sqlSelect, con);
            da.Fill(dt);
            if (txtMaphuong.Text != "" && txtTenphuong.Text != "" && txtSotodanpho.Text != "" && txtsoNK.Text != "")
            {
                if (dt.Rows.Count > 0)
                {
                    DialogResult loi = MessageBox.Show("Mã phường đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (loi == DialogResult.OK)
                        txtMaphuong.Clear();
                }
                else
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    DialogResult them = MessageBox.Show("Thêm thành công", "Thêm", MessageBoxButtons.OK);
                    Phuong_Load(sender, e);
                    con.Close();
                }
            }
            else
            {
                DialogResult loi = MessageBox.Show("Vui lòng nhập đầy đủ các thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgrPhuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
            DataGridViewRow row = new DataGridViewRow();
            row = dgrPhuong.Rows[e.RowIndex];
            txtMaphuong.Text = row.Cells[0].Value.ToString();
            txtTenphuong.Text = row.Cells[1].Value.ToString();
            txtSotodanpho.Text = row.Cells[2].Value.ToString();
            txtsoNK.Text = row.Cells[3].Value.ToString();
            txtMaphuong.Enabled = true;
           
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            
           
            txtMaphuong.Clear(); txtMaphuong.Focus();
            txtTenphuong.Clear();
            txtSotodanpho.Clear();
            txtsoNK.ResetText();
           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Phuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlinhankhauDataSet.tblPhuong' table. You can move, or remove it, as needed.
            // this.tblPhuongTableAdapter.Fill(this.quanlinhankhauDataSet.tblPhuong);
            SqlConnection con = new SqlConnection(constr);
            string sqlSelect = "select *from tblPhuong";
            con.Open();
            SqlCommand com = new SqlCommand(sqlSelect, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgrPhuong.DataSource = dt;
          

            con.Close();
        }

        private void btnbaoCao_Click(object sender, EventArgs e)
        {

            DSP dSP = new DSP();
            dSP.Show();
        }
    }
}
