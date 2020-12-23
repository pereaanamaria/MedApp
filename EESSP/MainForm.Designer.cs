namespace EESSP
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelDoctor = new System.Windows.Forms.Label();
            this.labelDoctorName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.monthCalendarMain = new System.Windows.Forms.MonthCalendar();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPagePatients = new System.Windows.Forms.TabPage();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.labelRefDoc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMI = new System.Windows.Forms.TextBox();
            this.buttonCancelP = new System.Windows.Forms.Button();
            this.buttonRemoveP = new System.Windows.Forms.Button();
            this.buttonModifyP = new System.Windows.Forms.Button();
            this.buttonAddP = new System.Windows.Forms.Button();
            this.labelRegisterNr = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelBirthPlace = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxID = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MIColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPagePatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDoctor
            // 
            this.labelDoctor.AutoSize = true;
            this.labelDoctor.Location = new System.Drawing.Point(11, 11);
            this.labelDoctor.Name = "labelDoctor";
            this.labelDoctor.Size = new System.Drawing.Size(45, 13);
            this.labelDoctor.TabIndex = 0;
            this.labelDoctor.Text = "Doctor: ";
            // 
            // labelDoctorName
            // 
            this.labelDoctorName.AutoSize = true;
            this.labelDoctorName.Location = new System.Drawing.Point(52, 11);
            this.labelDoctorName.Name = "labelDoctorName";
            this.labelDoctorName.Size = new System.Drawing.Size(10, 13);
            this.labelDoctorName.TabIndex = 1;
            this.labelDoctorName.Text = ".";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.labelDoctor);
            this.panel1.Controls.Add(this.labelDoctorName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 37);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.Controls.Add(this.monthCalendarMain);
            this.panel2.Location = new System.Drawing.Point(12, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 391);
            this.panel2.TabIndex = 0;
            // 
            // monthCalendarMain
            // 
            this.monthCalendarMain.ForeColor = System.Drawing.SystemColors.WindowText;
            this.monthCalendarMain.Location = new System.Drawing.Point(4, 4);
            this.monthCalendarMain.Name = "monthCalendarMain";
            this.monthCalendarMain.TabIndex = 0;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPagePatients);
            this.tabControlMain.Location = new System.Drawing.Point(255, 55);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(628, 391);
            this.tabControlMain.TabIndex = 3;
            // 
            // tabPagePatients
            // 
            this.tabPagePatients.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPagePatients.Controls.Add(this.dataGridViewPatients);
            this.tabPagePatients.Controls.Add(this.labelRefDoc);
            this.tabPagePatients.Controls.Add(this.label5);
            this.tabPagePatients.Controls.Add(this.textBoxMI);
            this.tabPagePatients.Controls.Add(this.buttonCancelP);
            this.tabPagePatients.Controls.Add(this.buttonRemoveP);
            this.tabPagePatients.Controls.Add(this.buttonModifyP);
            this.tabPagePatients.Controls.Add(this.buttonAddP);
            this.tabPagePatients.Controls.Add(this.labelRegisterNr);
            this.tabPagePatients.Controls.Add(this.labelAge);
            this.tabPagePatients.Controls.Add(this.labelBirthPlace);
            this.tabPagePatients.Controls.Add(this.labelSex);
            this.tabPagePatients.Controls.Add(this.labelDOB);
            this.tabPagePatients.Controls.Add(this.label4);
            this.tabPagePatients.Controls.Add(this.textBoxAddress);
            this.tabPagePatients.Controls.Add(this.label3);
            this.tabPagePatients.Controls.Add(this.maskedTextBoxID);
            this.tabPagePatients.Controls.Add(this.label2);
            this.tabPagePatients.Controls.Add(this.textBoxLastName);
            this.tabPagePatients.Controls.Add(this.label1);
            this.tabPagePatients.Controls.Add(this.textBoxName);
            this.tabPagePatients.Location = new System.Drawing.Point(4, 22);
            this.tabPagePatients.Name = "tabPagePatients";
            this.tabPagePatients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePatients.Size = new System.Drawing.Size(620, 365);
            this.tabPagePatients.TabIndex = 0;
            this.tabPagePatients.Text = "Patients";
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.LastNameColumn,
            this.MIColumn,
            this.CNPColumn,
            this.AddressColumn,
            this.DoctorColumn});
            this.dataGridViewPatients.Location = new System.Drawing.Point(17, 211);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPatients.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Tan;
            this.dataGridViewPatients.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPatients.Size = new System.Drawing.Size(587, 140);
            this.dataGridViewPatients.TabIndex = 17;
            this.dataGridViewPatients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatients_CellDoubleClick);
            // 
            // labelRefDoc
            // 
            this.labelRefDoc.AutoSize = true;
            this.labelRefDoc.Location = new System.Drawing.Point(14, 182);
            this.labelRefDoc.Name = "labelRefDoc";
            this.labelRefDoc.Size = new System.Drawing.Size(88, 13);
            this.labelRefDoc.TabIndex = 16;
            this.labelRefDoc.Text = "Refering Doctor: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "M.I.";
            // 
            // textBoxMI
            // 
            this.textBoxMI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxMI.Location = new System.Drawing.Point(229, 32);
            this.textBoxMI.Name = "textBoxMI";
            this.textBoxMI.Size = new System.Drawing.Size(46, 20);
            this.textBoxMI.TabIndex = 2;
            this.textBoxMI.TextChanged += new System.EventHandler(this.textBoxMI_TextChanged);
            // 
            // buttonCancelP
            // 
            this.buttonCancelP.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonCancelP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelP.Location = new System.Drawing.Point(491, 148);
            this.buttonCancelP.Name = "buttonCancelP";
            this.buttonCancelP.Size = new System.Drawing.Size(113, 23);
            this.buttonCancelP.TabIndex = 8;
            this.buttonCancelP.Text = "Cancel";
            this.buttonCancelP.UseVisualStyleBackColor = false;
            this.buttonCancelP.Click += new System.EventHandler(this.buttonCancelP_Click);
            // 
            // buttonRemoveP
            // 
            this.buttonRemoveP.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonRemoveP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemoveP.Location = new System.Drawing.Point(491, 119);
            this.buttonRemoveP.Name = "buttonRemoveP";
            this.buttonRemoveP.Size = new System.Drawing.Size(113, 23);
            this.buttonRemoveP.TabIndex = 7;
            this.buttonRemoveP.Text = "Remove Patient";
            this.buttonRemoveP.UseVisualStyleBackColor = false;
            this.buttonRemoveP.Click += new System.EventHandler(this.buttonRemoveP_Click);
            // 
            // buttonModifyP
            // 
            this.buttonModifyP.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonModifyP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonModifyP.Location = new System.Drawing.Point(491, 90);
            this.buttonModifyP.Name = "buttonModifyP";
            this.buttonModifyP.Size = new System.Drawing.Size(113, 23);
            this.buttonModifyP.TabIndex = 6;
            this.buttonModifyP.Text = "Modify Patient";
            this.buttonModifyP.UseVisualStyleBackColor = false;
            this.buttonModifyP.Click += new System.EventHandler(this.buttonModifyP_Click);
            // 
            // buttonAddP
            // 
            this.buttonAddP.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonAddP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddP.Location = new System.Drawing.Point(491, 60);
            this.buttonAddP.Name = "buttonAddP";
            this.buttonAddP.Size = new System.Drawing.Size(113, 23);
            this.buttonAddP.TabIndex = 5;
            this.buttonAddP.Text = "Add Patient";
            this.buttonAddP.UseVisualStyleBackColor = false;
            this.buttonAddP.Click += new System.EventHandler(this.buttonAddP_Click);
            // 
            // labelRegisterNr
            // 
            this.labelRegisterNr.AutoSize = true;
            this.labelRegisterNr.Location = new System.Drawing.Point(14, 158);
            this.labelRegisterNr.Name = "labelRegisterNr";
            this.labelRegisterNr.Size = new System.Drawing.Size(92, 13);
            this.labelRegisterNr.TabIndex = 12;
            this.labelRegisterNr.Text = "Register Number: ";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(14, 90);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(32, 13);
            this.labelAge.TabIndex = 11;
            this.labelAge.Text = "Age: ";
            // 
            // labelBirthPlace
            // 
            this.labelBirthPlace.AutoSize = true;
            this.labelBirthPlace.Location = new System.Drawing.Point(14, 136);
            this.labelBirthPlace.Name = "labelBirthPlace";
            this.labelBirthPlace.Size = new System.Drawing.Size(64, 13);
            this.labelBirthPlace.TabIndex = 10;
            this.labelBirthPlace.Text = "Birth Place: ";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(14, 113);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(31, 13);
            this.labelSex.TabIndex = 9;
            this.labelSex.Text = "Sex: ";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(14, 67);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(72, 13);
            this.labelDOB.TabIndex = 8;
            this.labelDOB.Text = "Date of Birth: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAddress.Location = new System.Drawing.Point(387, 32);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(217, 20);
            this.textBoxAddress.TabIndex = 4;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxAddress_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Patient ID - CNP";
            // 
            // maskedTextBoxID
            // 
            this.maskedTextBoxID.Location = new System.Drawing.Point(281, 32);
            this.maskedTextBoxID.Mask = "0000000000000";
            this.maskedTextBoxID.Name = "maskedTextBoxID";
            this.maskedTextBoxID.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxID.TabIndex = 3;
            this.maskedTextBoxID.Click += new System.EventHandler(this.maskedTextBoxID_Click);
            this.maskedTextBoxID.TextChanged += new System.EventHandler(this.maskedTextBoxID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxLastName.Location = new System.Drawing.Point(123, 32);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 1;
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxName.Location = new System.Drawing.Point(17, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 60;
            // 
            // LastNameColumn
            // 
            this.LastNameColumn.HeaderText = "Last Name";
            this.LastNameColumn.Name = "LastNameColumn";
            this.LastNameColumn.ReadOnly = true;
            this.LastNameColumn.Width = 83;
            // 
            // MIColumn
            // 
            this.MIColumn.HeaderText = "M. I.";
            this.MIColumn.Name = "MIColumn";
            this.MIColumn.ReadOnly = true;
            this.MIColumn.Width = 53;
            // 
            // CNPColumn
            // 
            this.CNPColumn.HeaderText = "CNP";
            this.CNPColumn.Name = "CNPColumn";
            this.CNPColumn.ReadOnly = true;
            this.CNPColumn.Width = 54;
            // 
            // AddressColumn
            // 
            this.AddressColumn.HeaderText = "Address";
            this.AddressColumn.Name = "AddressColumn";
            this.AddressColumn.ReadOnly = true;
            this.AddressColumn.Width = 70;
            // 
            // DoctorColumn
            // 
            this.DoctorColumn.HeaderText = "Doctor\'s Name";
            this.DoctorColumn.Name = "DoctorColumn";
            this.DoctorColumn.ReadOnly = true;
            this.DoctorColumn.Width = 102;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 458);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedApp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPagePatients.ResumeLayout(false);
            this.tabPagePatients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDoctor;
        private System.Windows.Forms.Label labelDoctorName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MonthCalendar monthCalendarMain;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPagePatients;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelBirthPlace;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelRegisterNr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMI;
        private System.Windows.Forms.Button buttonCancelP;
        private System.Windows.Forms.Button buttonRemoveP;
        private System.Windows.Forms.Button buttonModifyP;
        private System.Windows.Forms.Button buttonAddP;
        private System.Windows.Forms.Label labelRefDoc;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MIColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorColumn;
    }
}