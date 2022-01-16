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
    public partial class Thongke : Form
    {
        public Thongke()
        {
            InitializeComponent();
        }

        private void bntdscb_Click(object sender, EventArgs e)
        {
           // Phuongdanhsach rb = new Phuongdanhsach();
           // crystalReportViewer1.ReportSource = rb;
        }

        private void Thongke_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
        }
        string constr = @"Data Source=DESKTOP-E3TVU1E\SQLBAOAN;Initial Catalog=Quanlinhankhau;Integrated Security=True";
        private void btnphuongmoi_Click(object sender, EventArgs e)
        {
            

        }
    }
}
