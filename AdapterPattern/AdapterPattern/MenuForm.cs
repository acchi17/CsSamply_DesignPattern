using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdapterPattern.Functions;

namespace AdapterPattern
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button01_Click(object sender, EventArgs e)
        {
            using (var f = new ExecForm(new Function01()))
            {
                f.ShowDialog();
            }
        }

        private void button02_Click(object sender, EventArgs e)
        {
            using (var f = new ExecForm(new Function02()))
            {
                f.ShowDialog();
            }
        }

        private void button00_Click(object sender, EventArgs e)
        {
            using (var f = new ExecForm(new Function00Adapter()))
            {
                f.ShowDialog();
            }
        }
    }
}
