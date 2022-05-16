
namespace DBapplication
{
    partial class New_Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Patient));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DOV = new System.Windows.Forms.DateTimePicker();
            this.FC = new System.Windows.Forms.RadioButton();
            this.MC = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PN = new System.Windows.Forms.TextBox();
            this.AG = new System.Windows.Forms.TextBox();
            this.LN = new System.Windows.Forms.TextBox();
            this.MN = new System.Windows.Forms.TextBox();
            this.FN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 44);
            this.button2.TabIndex = 13;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.DOV);
            this.groupBox1.Controls.Add(this.FC);
            this.groupBox1.Controls.Add(this.MC);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PN);
            this.groupBox1.Controls.Add(this.AG);
            this.groupBox1.Controls.Add(this.LN);
            this.groupBox1.Controls.Add(this.MN);
            this.groupBox1.Controls.Add(this.FN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 380);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert New Patient";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Date of visit";
            // 
            // DOV
            // 
            this.DOV.CustomFormat = "yyyy-MM-dd";
            this.DOV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DOV.Location = new System.Drawing.Point(431, 193);
            this.DOV.MinDate = new System.DateTime(2022, 2, 7, 0, 0, 0, 0);
            this.DOV.Name = "DOV";
            this.DOV.Size = new System.Drawing.Size(281, 22);
            this.DOV.TabIndex = 14;
            // 
            // FC
            // 
            this.FC.AutoSize = true;
            this.FC.Location = new System.Drawing.Point(431, 253);
            this.FC.Name = "FC";
            this.FC.Size = new System.Drawing.Size(75, 21);
            this.FC.TabIndex = 12;
            this.FC.TabStop = true;
            this.FC.Text = "Female";
            this.FC.UseVisualStyleBackColor = true;
            // 
            // MC
            // 
            this.MC.AutoSize = true;
            this.MC.Location = new System.Drawing.Point(289, 253);
            this.MC.Name = "MC";
            this.MC.Size = new System.Drawing.Size(59, 21);
            this.MC.TabIndex = 11;
            this.MC.TabStop = true;
            this.MC.Text = "Male";
            this.MC.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Middle Name";
            // 
            // PN
            // 
            this.PN.Location = new System.Drawing.Point(431, 121);
            this.PN.Name = "PN";
            this.PN.Size = new System.Drawing.Size(285, 22);
            this.PN.TabIndex = 5;
            // 
            // AG
            // 
            this.AG.Location = new System.Drawing.Point(435, 55);
            this.AG.Name = "AG";
            this.AG.Size = new System.Drawing.Size(281, 22);
            this.AG.TabIndex = 4;
            // 
            // LN
            // 
            this.LN.Location = new System.Drawing.Point(67, 193);
            this.LN.Name = "LN";
            this.LN.Size = new System.Drawing.Size(281, 22);
            this.LN.TabIndex = 3;
            // 
            // MN
            // 
            this.MN.Location = new System.Drawing.Point(67, 121);
            this.MN.Name = "MN";
            this.MN.Size = new System.Drawing.Size(281, 22);
            this.MN.TabIndex = 2;
            // 
            // FN
            // 
            this.FN.Location = new System.Drawing.Point(67, 55);
            this.FN.Name = "FN";
            this.FN.Size = new System.Drawing.Size(281, 22);
            this.FN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // New_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(804, 380);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "New_Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_Patient";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        protected internal System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DOV;
        private System.Windows.Forms.RadioButton FC;
        private System.Windows.Forms.RadioButton MC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PN;
        private System.Windows.Forms.TextBox AG;
        private System.Windows.Forms.TextBox LN;
        private System.Windows.Forms.TextBox MN;
        private System.Windows.Forms.TextBox FN;
        private System.Windows.Forms.Label label1;
    }
}