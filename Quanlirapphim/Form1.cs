using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlirapphim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pHIMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timkiemphim tk = new timkiemphim();
            tk.ShowDialog();
        }

        private void lỊCHCHIẾUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timkiemlich tk = new timkiemlich();
            tk.ShowDialog();
        }
    }
}
