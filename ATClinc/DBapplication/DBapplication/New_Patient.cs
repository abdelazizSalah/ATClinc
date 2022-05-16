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
    public partial class New_Patient : Form
    {
        Controller CS = new Controller(); 
        public New_Patient()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FN.Text != "" && MN.Text != "" && LN.Text != "" && PN.Text != "" && AG.Text != "" && (MC.Checked || FC.Checked))
            {

                string s;
                if (MC.Checked) s = "M";
                else s = "F";
                int res = CS.InsertPatient(FN.Text, MN.Text, LN.Text, PN.Text, AG.Text, s);
                if (res != 0)
                {
                    res = CS.InsertPatDate(DOV.Text, PN.Text);
                    if(res == 0)
                        MessageBox.Show("Insertion Failed!");
                    else
                        MessageBox.Show("Inserted Successfully!");
                }
                else
                    MessageBox.Show("Insertion Failed!");
                 

            }
            else
                MessageBox.Show("invalid insertion");

            FN.Text = "";
            MN.Text = "";
            LN.Text = "";
            PN.Text = "";
            AG.Text = "";
            MC.Checked = false;
            FC.Checked = false;
        }

        private void PN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
