using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PresentationLayers
{
    public partial class Chuongtrinh : Form
    {
        public Chuongtrinh()
        {
            InitializeComponent();
        }
           
        private void đăngNhậpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
