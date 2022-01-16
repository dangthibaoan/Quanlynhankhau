using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BtlQuanlynhankhau
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void phuongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phuong phuong = new Phuong();
            phuong.MdiParent = this;
            phuong.Show();
        }

        private void todanphoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Todanpho todanpho = new Todanpho();
            todanpho.MdiParent = this;
            todanpho.Show();

        }

        private void nhankhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhankhau nhankhau = new Nhankhau();
            nhankhau.MdiParent = this;
            nhankhau.Show();
        }

        private void nptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nguoiphuthuoc nguoiphuthuoc = new Nguoiphuthuoc();
            nguoiphuthuoc.MdiParent = this;
            nguoiphuthuoc.Show();
        }

        private void thoattoolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cánBộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Canbo canbo = new Canbo();
            canbo.MdiParent = this;
            canbo.Show();
        }

        private void ThongketoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thongke thongke = new Thongke();
            thongke.MdiParent = this;
            thongke.Show();
        }
        private void thoatToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tổTrưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Totruong totruong = new Totruong();
            totruong.MdiParent = this;
            totruong.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
