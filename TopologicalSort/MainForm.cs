using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopologicalSort
{
    public partial class TopologicalSort : Form
    {
        public TopologicalSort()
        {
            InitializeComponent();
        }

        private void AlgoButton_Click(object sender, EventArgs e)
        {
            webPanel1.BringToFront();
        }

        private void BeginButton_Click(object sender, EventArgs e)
        {
            beginPanel1.BringToFront();
        }

        private void ExitButt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutButt_Click(object sender, EventArgs e)
        {
            AboutButt ab = new AboutButt();
            ab.ShowDialog();
        }

        private void beginPanel1_Load(object sender, EventArgs e)
        {

        }
    }
}
