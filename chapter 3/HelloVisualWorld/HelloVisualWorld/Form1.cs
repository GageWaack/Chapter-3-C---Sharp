using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloVisualWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblHello.Visible = true;
        }

        private void btngoodbye_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Goodbye :)";
        }

        private void btnreally_Click(object sender, EventArgs e)
        {
            lblHello.Visible = false;
        }
    }
}
