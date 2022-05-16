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
    public partial class Load : Form
    {
        Controller CS = new Controller();
        string PNum; 
        public Load(String Phone)
        {
            InitializeComponent();
            PNum = Phone; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DataTable t =  CS.GetALLPhoto();
            //DG1.DataSource = t;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable t = CS.GetALLPhoto(PNum,Counter1.Value.ToString(), Counter2.Value.ToString());
            DG1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DG1.RowTemplate.Height = 300;
            DG1.AllowUserToAddRows = false;
            DG1.DataSource = t;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DG1.Columns[1];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imageColumn.Width = 600;
        }

        private void DG1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
