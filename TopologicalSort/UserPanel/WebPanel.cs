using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopologicalSort.UserPanel
{
    public partial class WebPanel : UserControl
    {
        public WebPanel()
        {
            InitializeComponent();
            webBrowser.Navigate("https://neerc.ifmo.ru/wiki/index.php?title=Использование_обхода_в_глубину_для_топологической_сортировки");
        }

        private void BeginButton_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("https://neerc.ifmo.ru/wiki/index.php?title=Использование_обхода_в_глубину_для_топологической_сортировки");
        }
    }
}
