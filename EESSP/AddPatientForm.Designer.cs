namespace EESSP
{
    partial class AddPatientForm
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAddP = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMI = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelBirthPlace = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.maskedTextBoxID = new System.Windows.Forms.MaskedTextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonAddP);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxMI);
            this.panel1.Controls.Add(this.labelAge);
            this.panel1.Controls.Add(this.labelBirthPlace);
            this.panel1.Controls.Add(this.labelSex);
            this.panel1.Controls.Add(this.labelDOB);
            this.panel1.Controls.Add(this.textBoxAddress);
            this.panel1.Controls.Add(this.maskedTextBoxID);
            this.panel1.Controls.Add(this.textBoxLastName);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Location = new System.Drawing.Point(9, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 314);
            this.panel1.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Location = new System.Drawing.Point(188, 229);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(90, 23);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAddP
            // 
            this.buttonAddP.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonAddP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddP.Location = new System.Drawing.Point(188, 200);
            this.buttonAddP.Name = "buttonAddP";
            this.buttonAddP.Size = new System.Drawing.Size(90, 23);
            this.buttonAddP.TabIndex = 5;
            this.buttonAddP.Text = "Add Patient";
            this.buttonAddP.UseVisualStyleBackColor = false;
            this.buttonAddP.Click += new System.EventHandler(this.buttonAddP_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "M.I.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Patient ID - CNP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Last name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Name";
            // 
            // textBoxMI
            // 
            this.textBoxMI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxMI.Location = new System.Drawing.Point(232, 77);
            this.textBoxMI.Name = "textBoxMI";
            this.textBoxMI.Size = new System.Drawing.Size(46, 20);
            this.textBoxMI.TabIndex = 3;
            this.textBoxMI.TextChanged += new System.EventHandler(this.textBoxMI_TextChanged);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(90, 215);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(32, 13);
            this.labelAge.TabIndex = 25;
            this.labelAge.Text = "Age: ";
            // 
            // labelBirthPlace
            // 
            this.labelBirthPlace.AutoSize = true;
            this.labelBirthPlace.Location = new System.Drawing.Point(90, 261);
            this.labelBirthPlace.Name = "labelBirthPlace";
            this.labelBirthPlace.Size = new System.Drawing.Size(64, 13);
            this.labelBirthPlace.TabIndex = 24;
            this.labelBirthPlace.Text = "Birth Place: ";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(90, 238);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(31, 13);
            this.labelSex.TabIndex = 23;
            this.labelSex.Text = "Sex: ";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(90, 192);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(72, 13);
            this.labelDOB.TabIndex = 22;
            this.labelDOB.Text = "Date of Birth: ";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAddress.Location = new System.Drawing.Point(20, 126);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(258, 34);
            this.textBoxAddress.TabIndex = 4;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxAddress_TextChanged);
            // 
            // maskedTextBoxID
            // 
            this.maskedTextBoxID.Location = new System.Drawing.Point(20, 31);
            this.maskedTextBoxID.Mask = "0000000000000";
            this.maskedTextBoxID.Name = "maskedTextBoxID";
            this.maskedTextBoxID.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxID.TabIndex = 0;
            this.maskedTextBoxID.TextChanged += new System.EventHandler(this.maskedTextBoxID_TextChanged);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxLastName.Location = new System.Drawing.Point(126, 77);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 2;
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxName.Location = new System.Drawing.Point(20, 77);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Age: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Birth Place: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Sex: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Date of Birth: ";
            // 
            // AddPatientForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(317, 330);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Patient";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxMI;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelBirthPlace;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxID;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAddP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}