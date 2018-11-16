using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectRaisesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            


        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double currentSalary;
            double nextYearSalary;

            currentSalary = Convert.ToDouble(txtSalary.Text);

            nextYearSalary = currentSalary * 1.04;


            lblResult.Text = "current salary is now " + nextYearSalary;
            
        }

    }
}
