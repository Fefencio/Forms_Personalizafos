using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            var pnl = sender as Panel;
            pnl.BackColor = Color.Transparent;
        }


        private void panel_MouseEnter(object sender, EventArgs e)
        {
            var pnl = sender as Panel;
            pnl.BackColor = Color.DarkBlue;
        }

        private void pnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnMaximasize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pnMimimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnBordTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(Cursor.Position.X + e.X, Cursor.Position.Y + e.Y);
            }
        }
    }
}
