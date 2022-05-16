using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace DBapplication
{

    public partial class Old_Patient : Form
    {
        Controller CS = new Controller();
        string ConnectionString = @"Data Source=AbdelazizPC;Initial Catalog=ClincAR;Integrated Security=True";

        public Old_Patient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button5_Click(object sender, EventArgs e)
        { // open
            OpenFileDialog OD = new OpenFileDialog();
            OD.FileName = "";
            OD.Filter = "Supported Images|*.jpg;|*.jpeg;|*.png;";
            if (OD.ShowDialog() == DialogResult.OK)
                pictureBox1.Load(OD.FileName);
        }

        private void button6_Click(object sender, EventArgs e)
        {// Save
            if (PNu.Text != "" && NewID.Text != "")
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand command = con.CreateCommand();
                var image = new ImageConverter().ConvertTo(pictureBox1.Image, typeof(Byte[]));
                command.Parameters.AddWithValue("@image", image);
                command.Parameters.AddWithValue("@phoneNumber", PNu.Text);
                command.Parameters.AddWithValue("@ID", NewID.Text);
                var phone = PNu.Text;
                if (phone != "" && image != null)
                {
                    command.CommandText = "insert into PatPic Values(@ID,@image,@phoneNumber)";
                    if (command.ExecuteNonQuery() > 0)
                        MessageBox.Show("Saved Successfully!");
                    else
                        MessageBox.Show("Image Was Not Added !");
                }
                else
                    MessageBox.Show("Please insert a Phone number and ID");

                con.Close();
                Patient_details.DataSource = CS.GetPhotosDetails(PNu.Text);

            }
            else
                MessageBox.Show("Please enter a Phone number and ID");
        }

        private void button7_Click(object sender, EventArgs e)
        { // Load
            if (PNu.Text != "")
            {
                Load l = new Load(PNu.Text);
                l.ShowDialog();
            }
            else
                MessageBox.Show("Please Enter The PhoneNumber !");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PNu.Text != "")
                Patient_details.DataSource = CS.SelectAllAboutPatient(PNu.Text);
            else
                MessageBox.Show("Please enter a phone number");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PNu.Text != "")
            {
                //set prescription
                int res = CS.UpdateVisitDate(PNu.Text);
                if (res != 0)
                {
                    // set next visit
                    if (ProsedureBox.Text != "" && CommentBox.Text != "" && DiagnoseBox.Text != "")
                    {
                        res = CS.InsertDesc(ProsedureBox.Text, CommentBox.Text, DiagnoseBox.Text, PNu.Text);
                        if (res != 0)
                        {
                            res = CS.UpdateNextVisit(PNu.Text, NVd.Text);
                            if (res != 0)
                                MessageBox.Show("Updated Successfully");
                            else
                                MessageBox.Show("Failed");
                            Patient_details.DataSource = CS.SelectPrescriptions(PNu.Text);
                        }
                        else
                            MessageBox.Show("Failed");
                    }
                    else
                    {
                        res = CS.UpdateNextVisit(PNu.Text, NVd.Text);
                        if (res != 0)
                            MessageBox.Show("Updated Successfully");
                        else
                            MessageBox.Show("Failed");
                    }
                    Patient_details.DataSource = CS.SelectAllAboutPatient(PNu.Text);
                }
            }
            else
                MessageBox.Show("Please enter a phone number");
        }

        private void PrescGB_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (PNu.Text != "")
                Patient_details.DataSource = CS.SelectPrescriptions(PNu.Text);
            else
                MessageBox.Show("Please enter a phone number");
        }

        private void PNu_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            // delete
            if (PNu.Text != "" && NewID.Text != "")
            {
                int res = CS.DeleteImg(PNu.Text, NewID.Text);
                if (res == 0)
                    MessageBox.Show("Failed To Delete");
                else
                {
                    MessageBox.Show("Deleted!");
                    Patient_details.DataSource = CS.GetPhotosDetails(PNu.Text);
                }
            }
            else
                MessageBox.Show("Please Enter a phone number and an ID");
        }

        private void GetPatientPhotos_Click(object sender, EventArgs e)
        {
            if (PNu.Text != "")
                Patient_details.DataSource = CS.GetPhotosDetails(PNu.Text);
            else
                MessageBox.Show("Please Enter The PhoneNumber !");
        }

        private void Old_Patient_Load(object sender, EventArgs e)
        {

        }
    }
}
