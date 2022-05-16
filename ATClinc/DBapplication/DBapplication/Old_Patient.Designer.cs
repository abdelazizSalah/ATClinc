
namespace DBapplication
{
    partial class Old_Patient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Old_Patient));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NVd = new System.Windows.Forms.DateTimePicker();
            this.SetNextVisit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GetPatientPhotos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.GetDetails = new System.Windows.Forms.Button();
            this.Patient_details = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.PNu = new System.Windows.Forms.TextBox();
            this.PrescGB = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ProsedureBox = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DiagnoseBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CommentBox = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NewID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Patient_details)).BeginInit();
            this.PrescGB.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(872, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NVd);
            this.groupBox1.Location = new System.Drawing.Point(12, 375);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 52);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Next Visit";
            // 
            // NVd
            // 
            this.NVd.CustomFormat = "yyyy/MM/dd";
            this.NVd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NVd.Location = new System.Drawing.Point(13, 21);
            this.NVd.Name = "NVd";
            this.NVd.Size = new System.Drawing.Size(134, 22);
            this.NVd.TabIndex = 0;
            // 
            // SetNextVisit
            // 
            this.SetNextVisit.Location = new System.Drawing.Point(195, 377);
            this.SetNextVisit.Name = "SetNextVisit";
            this.SetNextVisit.Size = new System.Drawing.Size(671, 52);
            this.SetNextVisit.TabIndex = 2;
            this.SetNextVisit.Text = "Save";
            this.SetNextVisit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SetNextVisit.UseVisualStyleBackColor = true;
            this.SetNextVisit.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GetPatientPhotos);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.GetDetails);
            this.groupBox2.Controls.Add(this.Patient_details);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.PNu);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1006, 255);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Get_Patient_details";
            // 
            // GetPatientPhotos
            // 
            this.GetPatientPhotos.Location = new System.Drawing.Point(830, 51);
            this.GetPatientPhotos.Name = "GetPatientPhotos";
            this.GetPatientPhotos.Size = new System.Drawing.Size(164, 23);
            this.GetPatientPhotos.TabIndex = 5;
            this.GetPatientPhotos.Text = "Get Patient Photos";
            this.GetPatientPhotos.UseVisualStyleBackColor = true;
            this.GetPatientPhotos.Click += new System.EventHandler(this.GetPatientPhotos_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(652, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Get  Prescriptions";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // GetDetails
            // 
            this.GetDetails.Location = new System.Drawing.Point(469, 51);
            this.GetDetails.Name = "GetDetails";
            this.GetDetails.Size = new System.Drawing.Size(177, 23);
            this.GetDetails.TabIndex = 3;
            this.GetDetails.Text = "GetDetails";
            this.GetDetails.UseVisualStyleBackColor = true;
            this.GetDetails.Click += new System.EventHandler(this.button3_Click);
            // 
            // Patient_details
            // 
            this.Patient_details.AllowUserToAddRows = false;
            this.Patient_details.AllowUserToDeleteRows = false;
            this.Patient_details.AllowUserToResizeRows = false;
            this.Patient_details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Patient_details.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Patient_details.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.Patient_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Patient_details.Location = new System.Drawing.Point(4, 79);
            this.Patient_details.Name = "Patient_details";
            this.Patient_details.RowHeadersWidth = 51;
            this.Patient_details.RowTemplate.Height = 24;
            this.Patient_details.Size = new System.Drawing.Size(993, 164);
            this.Patient_details.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phone Number";
            // 
            // PNu
            // 
            this.PNu.Location = new System.Drawing.Point(6, 51);
            this.PNu.Name = "PNu";
            this.PNu.Size = new System.Drawing.Size(457, 22);
            this.PNu.TabIndex = 0;
            this.PNu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PNu_KeyPress);
            // 
            // PrescGB
            // 
            this.PrescGB.Controls.Add(this.groupBox6);
            this.PrescGB.Controls.Add(this.groupBox5);
            this.PrescGB.Controls.Add(this.groupBox3);
            this.PrescGB.Controls.Add(this.SetNextVisit);
            this.PrescGB.Controls.Add(this.groupBox1);
            this.PrescGB.Controls.Add(this.button1);
            this.PrescGB.Location = new System.Drawing.Point(12, 273);
            this.PrescGB.Name = "PrescGB";
            this.PrescGB.Size = new System.Drawing.Size(1006, 442);
            this.PrescGB.TabIndex = 4;
            this.PrescGB.TabStop = false;
            this.PrescGB.Text = "Prescreptions";
            this.PrescGB.Enter += new System.EventHandler(this.PrescGB_Enter);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ProsedureBox);
            this.groupBox6.Location = new System.Drawing.Point(9, 71);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(487, 293);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Procedure";
            // 
            // ProsedureBox
            // 
            this.ProsedureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProsedureBox.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProsedureBox.Location = new System.Drawing.Point(3, 18);
            this.ProsedureBox.Name = "ProsedureBox";
            this.ProsedureBox.Size = new System.Drawing.Size(481, 272);
            this.ProsedureBox.TabIndex = 2;
            this.ProsedureBox.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DiagnoseBox);
            this.groupBox5.Location = new System.Drawing.Point(9, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(988, 44);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Diagnose";
            // 
            // DiagnoseBox
            // 
            this.DiagnoseBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiagnoseBox.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiagnoseBox.Location = new System.Drawing.Point(3, 18);
            this.DiagnoseBox.Name = "DiagnoseBox";
            this.DiagnoseBox.Size = new System.Drawing.Size(982, 28);
            this.DiagnoseBox.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CommentBox);
            this.groupBox3.Location = new System.Drawing.Point(502, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(495, 290);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comment";
            // 
            // CommentBox
            // 
            this.CommentBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommentBox.Font = new System.Drawing.Font("Arial", 10.8F);
            this.CommentBox.Location = new System.Drawing.Point(3, 18);
            this.CommentBox.Name = "CommentBox";
            this.CommentBox.Size = new System.Drawing.Size(489, 269);
            this.CommentBox.TabIndex = 0;
            this.CommentBox.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.NewID);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.Clear);
            this.groupBox4.Controls.Add(this.Load);
            this.groupBox4.Controls.Add(this.Save);
            this.groupBox4.Controls.Add(this.Open);
            this.groupBox4.Location = new System.Drawing.Point(1036, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(392, 703);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pictures";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 608);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // NewID
            // 
            this.NewID.Location = new System.Drawing.Point(101, 605);
            this.NewID.Name = "NewID";
            this.NewID.Size = new System.Drawing.Size(190, 22);
            this.NewID.TabIndex = 5;
            this.NewID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PNu_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(9, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 578);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(297, 633);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(89, 64);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Delete";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(202, 633);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(89, 64);
            this.Load.TabIndex = 4;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.button7_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(110, 633);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(86, 64);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.button6_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(9, 633);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(95, 64);
            this.Open.TabIndex = 2;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.button5_Click);
            // 
            // Old_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1437, 727);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.PrescGB);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1455, 774);
            this.MinimumSize = new System.Drawing.Size(1455, 774);
            this.Name = "Old_Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Old_Patient";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Patient_details)).EndInit();
            this.PrescGB.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SetNextVisit;
        private System.Windows.Forms.DateTimePicker NVd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button GetDetails;
        private System.Windows.Forms.DataGridView Patient_details;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PNu;
        private System.Windows.Forms.GroupBox PrescGB;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button GetPatientPhotos;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox DiagnoseBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox CommentBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RichTextBox ProsedureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewID;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}