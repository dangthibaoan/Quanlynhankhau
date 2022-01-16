using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BtlQuanlynhankhau
{
    public partial class DSNK : Form
    {
        public DSNK()
        {
            InitializeComponent();
        }
        string constr = @"Data Source=DESKTOP-E3TVU1E\SQLBAOAN;Initial Catalog=Quanlinhankhau;Integrated Security=True";
        private void DSNK_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            string sqlSelect = "select *from tblPhuong";
            con.Open();
            SqlCommand com = new SqlCommand(sqlSelect, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select idNhankhau,idTo,sTennhankhau,dNgaysinh,sQuequan,sCMND,sNghenghiep from tblNhankhau", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            DSNhankhau rp = new DSNhankhau();
            rp.SetDataSource(dt1);
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
