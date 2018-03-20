using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2017_QLKH
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhoHang.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.quanLyKhoHang.KHACHHANG);

        }

        private void bt_quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
        }
    }
}
