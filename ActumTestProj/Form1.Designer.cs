namespace ActumTestProj
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveTraining = new System.Windows.Forms.Button();
            this.trainDesc = new System.Windows.Forms.TextBox();
            this.trainName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSaveEmployee = new System.Windows.Forms.Button();
            this.empBrtDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.empSurname = new System.Windows.Forms.TextBox();
            this.empName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trainingsCmb = new System.Windows.Forms.ComboBox();
            this.visitDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSaveAttend = new System.Windows.Forms.Button();
            this.employeeCmb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.employeeCmb2 = new System.Windows.Forms.ComboBox();
            this.btnGetTrainings = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveTraining);
            this.panel1.Controls.Add(this.trainDesc);
            this.panel1.Controls.Add(this.trainName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 173);
            this.panel1.TabIndex = 0;
            // 
            // btnSaveTraining
            // 
            this.btnSaveTraining.Enabled = false;
            this.btnSaveTraining.Location = new System.Drawing.Point(86, 126);
            this.btnSaveTraining.Name = "btnSaveTraining";
            this.btnSaveTraining.Size = new System.Drawing.Size(75, 23);
            this.btnSaveTraining.TabIndex = 2;
            this.btnSaveTraining.Text = "Save";
            this.btnSaveTraining.UseVisualStyleBackColor = true;
            this.btnSaveTraining.Click += new System.EventHandler(this.BtnSaveTraining_Click);
            // 
            // trainDesc
            // 
            this.trainDesc.Location = new System.Drawing.Point(86, 75);
            this.trainDesc.Name = "trainDesc";
            this.trainDesc.Size = new System.Drawing.Size(125, 20);
            this.trainDesc.TabIndex = 1;
            this.trainDesc.TextChanged += new System.EventHandler(this.trainDesc_TextChanged);
            // 
            // trainName
            // 
            this.trainName.Location = new System.Drawing.Point(86, 46);
            this.trainName.Name = "trainName";
            this.trainName.Size = new System.Drawing.Size(125, 20);
            this.trainName.TabIndex = 1;
            this.trainName.TextChanged += new System.EventHandler(this.trainName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Training";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSaveEmployee);
            this.panel2.Controls.Add(this.empBrtDate);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.empSurname);
            this.panel2.Controls.Add(this.empName);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(249, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 173);
            this.panel2.TabIndex = 0;
            // 
            // btnSaveEmployee
            // 
            this.btnSaveEmployee.Enabled = false;
            this.btnSaveEmployee.Location = new System.Drawing.Point(83, 126);
            this.btnSaveEmployee.Name = "btnSaveEmployee";
            this.btnSaveEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEmployee.TabIndex = 2;
            this.btnSaveEmployee.Text = "Save";
            this.btnSaveEmployee.UseVisualStyleBackColor = true;
            this.btnSaveEmployee.Click += new System.EventHandler(this.BtnSaveEmployee_Click);
            // 
            // empBrtDate
            // 
            this.empBrtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.empBrtDate.Location = new System.Drawing.Point(83, 95);
            this.empBrtDate.Name = "empBrtDate";
            this.empBrtDate.Size = new System.Drawing.Size(125, 20);
            this.empBrtDate.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "BirthDate";
            // 
            // empSurname
            // 
            this.empSurname.Location = new System.Drawing.Point(83, 70);
            this.empSurname.Name = "empSurname";
            this.empSurname.Size = new System.Drawing.Size(125, 20);
            this.empSurname.TabIndex = 1;
            this.empSurname.TextChanged += new System.EventHandler(this.empSurname_TextChanged);
            // 
            // empName
            // 
            this.empName.Location = new System.Drawing.Point(83, 47);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(125, 20);
            this.empName.TabIndex = 1;
            this.empName.TextChanged += new System.EventHandler(this.empName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Surname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Employee";
            // 
            // trainingsCmb
            // 
            this.trainingsCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trainingsCmb.FormattingEnabled = true;
            this.trainingsCmb.Location = new System.Drawing.Point(78, 46);
            this.trainingsCmb.Name = "trainingsCmb";
            this.trainingsCmb.Size = new System.Drawing.Size(125, 21);
            this.trainingsCmb.TabIndex = 3;
            this.trainingsCmb.DropDown += new System.EventHandler(this.trainingsCmb_DropDown);
            this.trainingsCmb.TextChanged += new System.EventHandler(this.trainingsCmb_TextChanged);
            // 
            // visitDate
            // 
            this.visitDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.visitDate.Location = new System.Drawing.Point(78, 73);
            this.visitDate.Name = "visitDate";
            this.visitDate.Size = new System.Drawing.Size(125, 20);
            this.visitDate.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Visit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Training";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Employee";
            // 
            // btnSaveAttend
            // 
            this.btnSaveAttend.Enabled = false;
            this.btnSaveAttend.Location = new System.Drawing.Point(85, 124);
            this.btnSaveAttend.Name = "btnSaveAttend";
            this.btnSaveAttend.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAttend.TabIndex = 2;
            this.btnSaveAttend.Text = "Save";
            this.btnSaveAttend.UseVisualStyleBackColor = true;
            this.btnSaveAttend.Click += new System.EventHandler(this.btnSaveAttend_Click);
            // 
            // employeeCmb
            // 
            this.employeeCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeCmb.FormattingEnabled = true;
            this.employeeCmb.Location = new System.Drawing.Point(78, 19);
            this.employeeCmb.Name = "employeeCmb";
            this.employeeCmb.Size = new System.Drawing.Size(125, 21);
            this.employeeCmb.TabIndex = 4;
            this.employeeCmb.DropDown += new System.EventHandler(this.employeeCmb_DropDown);
            this.employeeCmb.TextChanged += new System.EventHandler(this.employeeCmb_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Employee";
            // 
            // employeeCmb2
            // 
            this.employeeCmb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeCmb2.FormattingEnabled = true;
            this.employeeCmb2.Location = new System.Drawing.Point(81, 43);
            this.employeeCmb2.Name = "employeeCmb2";
            this.employeeCmb2.Size = new System.Drawing.Size(125, 21);
            this.employeeCmb2.TabIndex = 4;
            this.employeeCmb2.DropDown += new System.EventHandler(this.employeeCmb2_DropDown);
            this.employeeCmb2.TextChanged += new System.EventHandler(this.employeeCmb2_TextChanged);
            // 
            // btnGetTrainings
            // 
            this.btnGetTrainings.Enabled = false;
            this.btnGetTrainings.Location = new System.Drawing.Point(56, 83);
            this.btnGetTrainings.Name = "btnGetTrainings";
            this.btnGetTrainings.Size = new System.Drawing.Size(125, 23);
            this.btnGetTrainings.TabIndex = 5;
            this.btnGetTrainings.Text = "Get Latest Trainings";
            this.btnGetTrainings.UseVisualStyleBackColor = true;
            this.btnGetTrainings.Click += new System.EventHandler(this.btnGetTrainings_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.employeeCmb);
            this.panel3.Controls.Add(this.btnSaveAttend);
            this.panel3.Controls.Add(this.trainingsCmb);
            this.panel3.Controls.Add(this.visitDate);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(22, 194);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 162);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnGetTrainings);
            this.panel4.Controls.Add(this.employeeCmb2);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(251, 194);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(219, 161);
            this.panel4.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 374);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox trainDesc;
        private System.Windows.Forms.TextBox trainName;
        private System.Windows.Forms.DateTimePicker empBrtDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox empSurname;
        private System.Windows.Forms.TextBox empName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSaveTraining;
        private System.Windows.Forms.Button btnSaveEmployee;
        private System.Windows.Forms.DateTimePicker visitDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox trainingsCmb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSaveAttend;
        private System.Windows.Forms.ComboBox employeeCmb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox employeeCmb2;
        private System.Windows.Forms.Button btnGetTrainings;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

