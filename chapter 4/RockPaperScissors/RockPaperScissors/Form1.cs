using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int rock = 1;
                int paper = 1;
                int scissors = 1;
            string stringResult;
            Random ranComputerInput = new Random();
            int computerInput;
            computerInput = ranComputerInput.Next(rock, paper, scissors);
            int result;

            
            if (computerInput = rock && txtInput = paper )
            
                
        }
    }
}
