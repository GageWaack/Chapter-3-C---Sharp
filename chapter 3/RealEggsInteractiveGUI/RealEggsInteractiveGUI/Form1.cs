using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEggsInteractiveGUI
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

        private void btnConvert_Click(object sender, EventArgs e)
        {
            int chicken1;
            int chicken2;
            int chicken3;
            int chicken4;
            int chicken5;
            int total;
            int dozen;
            int remainderEggs;



            chicken1 = Convert.ToInt32(txtChicken1.Text);
            chicken2 = Convert.ToInt32(txtChicken2.Text);
            chicken3 = Convert.ToInt32(txtChicken3.Text);
            chicken4 = Convert.ToInt32(txtChicken4.Text);
            chicken5 = Convert.ToInt32(txtChicken5.Text);
            total = chicken1 + chicken2 + chicken3 + chicken4 + chicken5;
            dozen = total / 12;
            remainderEggs = total % 12;
            lblResult.Text = "You have " + dozen + " dozen eggs and " + remainderEggs + 
                " eggs remaining";



        }

    }

}

