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
    public partial class ExecForm : Form
    {
        private IFunctions _functions;
        public ExecForm(IFunctions functions)
        {
            InitializeComponent();

            _functions = functions;
        }

        private void buttonExec_Click(object sender, EventArgs e)
        {
            labelResult.Text = _functions.GetResult().ToString();
        }
    }
}
