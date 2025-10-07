using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_3
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void problema1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Problema1 p1 = new Problema1();
            p1.MdiParent = this;
            p1.WindowState = FormWindowState.Maximized;
            p1.Show();   
    }

        private void problema2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Problema2 p2 = new Problema2();
            p2.MdiParent = this;
            p2.WindowState = FormWindowState.Maximized;
            p2.Show();
        }

        private void problema3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Problema3 p3 = new Problema3();
            p3.MdiParent = this;
            p3.WindowState = FormWindowState.Maximized;
            p3.Show();
        }

        private void problema4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Problema4 p4 = new Problema4();
            p4.MdiParent = this;
            p4.WindowState = FormWindowState.Maximized;
            p4.Show();
        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
