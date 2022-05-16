using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class ClincAT : Form
    {
        public ClincAT()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            New_Patient NP = new New_Patient();
            NP.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Old_Patient OP = new Old_Patient();
            OP.ShowDialog(); 
        }
    }
}
