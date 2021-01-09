﻿namespace EESSP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelDoctor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAddP = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCancelSearch = new System.Windows.Forms.Button();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleInitials = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearchLN = new System.Windows.Forms.TextBox();
            this.maskedTextBoxSearchCNP = new System.Windows.Forms.MaskedTextBox();
            this.textBoxSearchN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonChangeP = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonDiscard = new System.Windows.Forms.Button();
            this.labelRefDoc = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelMI = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelBirthPlace = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.domainUpDownOptions = new System.Windows.Forms.DomainUpDown();
            this.labelCNP = new System.Windows.Forms.Label();
            this.maskedTextBoxID = new System.Windows.Forms.MaskedTextBox();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonModifyP = new System.Windows.Forms.Button();
            this.buttonConsultationsP = new System.Windows.Forms.Button();
            this.buttonRemoveP = new System.Windows.Forms.Button();
            this.textBoxMI = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDoctor
            // 
            this.labelDoctor.AutoSize = true;
            this.labelDoctor.Location = new System.Drawing.Point(4, 13);
            this.labelDoctor.Name = "labelDoctor";
            this.labelDoctor.Size = new System.Drawing.Size(45, 13);
            this.labelDoctor.TabIndex = 0;
            this.labelDoctor.Text = "Doctor: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.buttonAddP);
            this.panel1.Controls.Add(this.buttonList);
            this.panel1.Controls.Add(this.labelDoctor);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 41);
            this.panel1.TabIndex = 22;
            // 
            // buttonAddP
            // 
            this.buttonAddP.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonAddP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddP.Location = new System.Drawing.Point(287, 8);
            this.buttonAddP.Name = "buttonAddP";
            this.buttonAddP.Size = new System.Drawing.Size(113, 23);
            this.buttonAddP.TabIndex = 0;
            this.buttonAddP.Text = "Add Patient";
            this.buttonAddP.UseVisualStyleBackColor = false;
            this.buttonAddP.Click += new System.EventHandler(this.buttonAddP_Click);
            // 
            // buttonList
            // 
            this.buttonList.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonList.Location = new System.Drawing.Point(420, 8);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(113, 23);
            this.buttonList.TabIndex = 1;
            this.buttonList.Text = "Patients List";
            this.buttonList.UseVisualStyleBackColor = false;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.Controls.Add(this.buttonCancelSearch);
            this.panel2.Controls.Add(this.dataGridViewPatients);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxSearchLN);
            this.panel2.Controls.Add(this.maskedTextBoxSearchCNP);
            this.panel2.Controls.Add(this.textBoxSearchN);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(564, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 344);
            this.panel2.TabIndex = 26;
            // 
            // buttonCancelSearch
            // 
            this.buttonCancelSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonCancelSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelSearch.Location = new System.Drawing.Point(223, 99);
            this.buttonCancelSearch.Name = "buttonCancelSearch";
            this.buttonCancelSearch.Size = new System.Drawing.Size(94, 22);
            this.buttonCancelSearch.TabIndex = 5;
            this.buttonCancelSearch.Text = "Cancel Search";
            this.buttonCancelSearch.UseVisualStyleBackColor = false;
            this.buttonCancelSearch.Visible = false;
            this.buttonCancelSearch.Click += new System.EventHandler(this.buttonCancelSearch_Click);
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.MiddleInitials,
            this.LastNameColumn,
            this.CNPColumn});
            this.dataGridViewPatients.Location = new System.Drawing.Point(7, 127);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPatients.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewPatients.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewPatients.Size = new System.Drawing.Size(310, 212);
            this.dataGridViewPatients.TabIndex = 17;
            this.dataGridViewPatients.Visible = false;
            this.dataGridViewPatients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatients_CellDoubleClick);
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 60;
            // 
            // MiddleInitials
            // 
            this.MiddleInitials.HeaderText = "M.I.";
            this.MiddleInitials.Name = "MiddleInitials";
            this.MiddleInitials.ReadOnly = true;
            this.MiddleInitials.Width = 50;
            // 
            // LastNameColumn
            // 
            this.LastNameColumn.HeaderText = "Last Name";
            this.LastNameColumn.Name = "LastNameColumn";
            this.LastNameColumn.ReadOnly = true;
            this.LastNameColumn.Width = 83;
            // 
            // CNPColumn
            // 
            this.CNPColumn.HeaderText = "CNP";
            this.CNPColumn.Name = "CNPColumn";
            this.CNPColumn.ReadOnly = true;
            this.CNPColumn.Width = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(222, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Search Patients";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "CNP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Name";
            // 
            // textBoxSearchLN
            // 
            this.textBoxSearchLN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxSearchLN.Location = new System.Drawing.Point(7, 60);
            this.textBoxSearchLN.Name = "textBoxSearchLN";
            this.textBoxSearchLN.Size = new System.Drawing.Size(90, 20);
            this.textBoxSearchLN.TabIndex = 3;
            this.textBoxSearchLN.TextChanged += new System.EventHandler(this.textBoxSearchLN_TextChanged);
            // 
            // maskedTextBoxSearchCNP
            // 
            this.maskedTextBoxSearchCNP.Location = new System.Drawing.Point(7, 101);
            this.maskedTextBoxSearchCNP.Mask = "0000000000000";
            this.maskedTextBoxSearchCNP.Name = "maskedTextBoxSearchCNP";
            this.maskedTextBoxSearchCNP.Size = new System.Drawing.Size(90, 20);
            this.maskedTextBoxSearchCNP.TabIndex = 4;
            this.maskedTextBoxSearchCNP.Click += new System.EventHandler(this.maskedTextBoxSearchCNP_Click);
            this.maskedTextBoxSearchCNP.TextChanged += new System.EventHandler(this.maskedTextBoxSearchCNP_TextChanged);
            // 
            // textBoxSearchN
            // 
            this.textBoxSearchN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxSearchN.Location = new System.Drawing.Point(7, 21);
            this.textBoxSearchN.Name = "textBoxSearchN";
            this.textBoxSearchN.Size = new System.Drawing.Size(90, 20);
            this.textBoxSearchN.TabIndex = 2;
            this.textBoxSearchN.TextChanged += new System.EventHandler(this.textBoxSearchN_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Last Name";
            // 
            // buttonChangeP
            // 
            this.buttonChangeP.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonChangeP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChangeP.Location = new System.Drawing.Point(420, 245);
            this.buttonChangeP.Name = "buttonChangeP";
            this.buttonChangeP.Size = new System.Drawing.Size(113, 23);
            this.buttonChangeP.TabIndex = 10;
            this.buttonChangeP.Text = "Change Patient";
            this.buttonChangeP.UseVisualStyleBackColor = false;
            this.buttonChangeP.Click += new System.EventHandler(this.buttonChangeP_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.buttonDiscard);
            this.panel3.Controls.Add(this.labelRefDoc);
            this.panel3.Controls.Add(this.labelAge);
            this.panel3.Controls.Add(this.labelDOB);
            this.panel3.Controls.Add(this.labelMI);
            this.panel3.Controls.Add(this.textBoxLastName);
            this.panel3.Controls.Add(this.labelAddress);
            this.panel3.Controls.Add(this.textBoxName);
            this.panel3.Controls.Add(this.labelBirthPlace);
            this.panel3.Controls.Add(this.textBoxAddress);
            this.panel3.Controls.Add(this.labelName);
            this.panel3.Controls.Add(this.domainUpDownOptions);
            this.panel3.Controls.Add(this.buttonChangeP);
            this.panel3.Controls.Add(this.labelCNP);
            this.panel3.Controls.Add(this.maskedTextBoxID);
            this.panel3.Controls.Add(this.labelSex);
            this.panel3.Controls.Add(this.labelLastName);
            this.panel3.Controls.Add(this.buttonConfirm);
            this.panel3.Controls.Add(this.buttonModifyP);
            this.panel3.Controls.Add(this.buttonConsultationsP);
            this.panel3.Controls.Add(this.buttonRemoveP);
            this.panel3.Controls.Add(this.textBoxMI);
            this.panel3.Location = new System.Drawing.Point(12, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(545, 297);
            this.panel3.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Refering Doctor: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Age: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Date of Birth: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "M.I.:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 58;
            this.label9.Text = "Address:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Birth Place: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 55;
            this.label11.Text = "Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 57;
            this.label12.Text = "CNP:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 51;
            this.label13.Text = "Sex: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 56;
            this.label14.Text = "Last Name:";
            // 
            // buttonDiscard
            // 
            this.buttonDiscard.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonDiscard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDiscard.Location = new System.Drawing.Point(287, 178);
            this.buttonDiscard.Name = "buttonDiscard";
            this.buttonDiscard.Size = new System.Drawing.Size(113, 23);
            this.buttonDiscard.TabIndex = 10;
            this.buttonDiscard.Text = "Discard Modification";
            this.buttonDiscard.UseVisualStyleBackColor = false;
            this.buttonDiscard.Visible = false;
            this.buttonDiscard.Click += new System.EventHandler(this.buttonDiscard_Click);
            // 
            // labelRefDoc
            // 
            this.labelRefDoc.AutoSize = true;
            this.labelRefDoc.Location = new System.Drawing.Point(118, 245);
            this.labelRefDoc.Name = "labelRefDoc";
            this.labelRefDoc.Size = new System.Drawing.Size(88, 13);
            this.labelRefDoc.TabIndex = 43;
            this.labelRefDoc.Text = "Refering Doctor: ";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(118, 177);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(32, 13);
            this.labelAge.TabIndex = 42;
            this.labelAge.Text = "Age: ";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(118, 154);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(72, 13);
            this.labelDOB.TabIndex = 39;
            this.labelDOB.Text = "Date of Birth: ";
            // 
            // labelMI
            // 
            this.labelMI.AutoSize = true;
            this.labelMI.Location = new System.Drawing.Point(118, 80);
            this.labelMI.Name = "labelMI";
            this.labelMI.Size = new System.Drawing.Size(28, 13);
            this.labelMI.TabIndex = 49;
            this.labelMI.Text = "M.I.:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxLastName.Location = new System.Drawing.Point(440, 123);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(113, 20);
            this.textBoxLastName.TabIndex = 8;
            this.textBoxLastName.Visible = false;
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            this.textBoxLastName.Enter += new System.EventHandler(this.textBoxLastName_Enter);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(118, 130);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(48, 13);
            this.labelAddress.TabIndex = 48;
            this.labelAddress.Text = "Address:";
            // 
            // textBoxName
            // 
            this.textBoxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxName.Location = new System.Drawing.Point(406, 87);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(113, 20);
            this.textBoxName.TabIndex = 8;
            this.textBoxName.Visible = false;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            // 
            // labelBirthPlace
            // 
            this.labelBirthPlace.AutoSize = true;
            this.labelBirthPlace.Location = new System.Drawing.Point(118, 223);
            this.labelBirthPlace.Name = "labelBirthPlace";
            this.labelBirthPlace.Size = new System.Drawing.Size(64, 13);
            this.labelBirthPlace.TabIndex = 41;
            this.labelBirthPlace.Text = "Birth Place: ";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAddress.Location = new System.Drawing.Point(420, 151);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(113, 46);
            this.textBoxAddress.TabIndex = 8;
            this.textBoxAddress.Visible = false;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxAddress_TextChanged);
            this.textBoxAddress.Enter += new System.EventHandler(this.textBoxAddress_Enter);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(118, 31);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 45;
            this.labelName.Text = "Name:";
            // 
            // domainUpDownOptions
            // 
            this.domainUpDownOptions.Items.Add("Name");
            this.domainUpDownOptions.Items.Add("Last Name");
            this.domainUpDownOptions.Items.Add("M.I.");
            this.domainUpDownOptions.Items.Add("CNP");
            this.domainUpDownOptions.Items.Add("Address");
            this.domainUpDownOptions.Location = new System.Drawing.Point(287, 57);
            this.domainUpDownOptions.Name = "domainUpDownOptions";
            this.domainUpDownOptions.Size = new System.Drawing.Size(113, 20);
            this.domainUpDownOptions.TabIndex = 7;
            this.domainUpDownOptions.Text = "Choose category";
            this.domainUpDownOptions.Visible = false;
            this.domainUpDownOptions.Wrap = true;
            this.domainUpDownOptions.SelectedItemChanged += new System.EventHandler(this.domainUpDownOptions_SelectedItemChanged);
            this.domainUpDownOptions.Enter += new System.EventHandler(this.domainUpDownOptions_Enter);
            // 
            // labelCNP
            // 
            this.labelCNP.AutoSize = true;
            this.labelCNP.Location = new System.Drawing.Point(118, 105);
            this.labelCNP.Name = "labelCNP";
            this.labelCNP.Size = new System.Drawing.Size(32, 13);
            this.labelCNP.TabIndex = 47;
            this.labelCNP.Text = "CNP:";
            // 
            // maskedTextBoxID
            // 
            this.maskedTextBoxID.Location = new System.Drawing.Point(298, 123);
            this.maskedTextBoxID.Mask = "0000000000000";
            this.maskedTextBoxID.Name = "maskedTextBoxID";
            this.maskedTextBoxID.Size = new System.Drawing.Size(113, 20);
            this.maskedTextBoxID.TabIndex = 8;
            this.maskedTextBoxID.Visible = false;
            this.maskedTextBoxID.Click += new System.EventHandler(this.maskedTextBoxID_Click);
            this.maskedTextBoxID.TextChanged += new System.EventHandler(this.maskedTextBoxID_TextChanged);
            this.maskedTextBoxID.Enter += new System.EventHandler(this.maskedTextBoxID_Enter);
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(118, 200);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(31, 13);
            this.labelSex.TabIndex = 40;
            this.labelSex.Text = "Sex: ";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(118, 54);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(61, 13);
            this.labelLastName.TabIndex = 46;
            this.labelLastName.Text = "Last Name:";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonConfirm.Enabled = false;
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirm.Location = new System.Drawing.Point(287, 149);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(113, 23);
            this.buttonConfirm.TabIndex = 9;
            this.buttonConfirm.Text = "Confirm Modification";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Visible = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonModifyP
            // 
            this.buttonModifyP.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonModifyP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonModifyP.Location = new System.Drawing.Point(287, 21);
            this.buttonModifyP.Name = "buttonModifyP";
            this.buttonModifyP.Size = new System.Drawing.Size(113, 23);
            this.buttonModifyP.TabIndex = 6;
            this.buttonModifyP.Text = "Modify Patient";
            this.buttonModifyP.UseVisualStyleBackColor = false;
            this.buttonModifyP.Click += new System.EventHandler(this.buttonModifyP_Click);
            // 
            // buttonConsultationsP
            // 
            this.buttonConsultationsP.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonConsultationsP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConsultationsP.Location = new System.Drawing.Point(420, 21);
            this.buttonConsultationsP.Name = "buttonConsultationsP";
            this.buttonConsultationsP.Size = new System.Drawing.Size(113, 23);
            this.buttonConsultationsP.TabIndex = 7;
            this.buttonConsultationsP.Text = "Consultations";
            this.buttonConsultationsP.UseVisualStyleBackColor = false;
            this.buttonConsultationsP.Click += new System.EventHandler(this.buttonConsultationsP_Click);
            // 
            // buttonRemoveP
            // 
            this.buttonRemoveP.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonRemoveP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemoveP.Location = new System.Drawing.Point(420, 54);
            this.buttonRemoveP.Name = "buttonRemoveP";
            this.buttonRemoveP.Size = new System.Drawing.Size(113, 23);
            this.buttonRemoveP.TabIndex = 8;
            this.buttonRemoveP.Text = "Remove Patient";
            this.buttonRemoveP.UseVisualStyleBackColor = false;
            this.buttonRemoveP.Click += new System.EventHandler(this.buttonRemoveP_Click);
            // 
            // textBoxMI
            // 
            this.textBoxMI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxMI.Location = new System.Drawing.Point(287, 87);
            this.textBoxMI.Name = "textBoxMI";
            this.textBoxMI.Size = new System.Drawing.Size(113, 20);
            this.textBoxMI.TabIndex = 8;
            this.textBoxMI.Visible = false;
            this.textBoxMI.TextChanged += new System.EventHandler(this.textBoxMI_TextChanged);
            this.textBoxMI.Enter += new System.EventHandler(this.textBoxMI_Enter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 364);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedApp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDoctor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonChangeP;
        private System.Windows.Forms.Button buttonAddP;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelRefDoc;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelMI;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelBirthPlace;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DomainUpDown domainUpDownOptions;
        private System.Windows.Forms.Label labelCNP;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxID;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonModifyP;
        private System.Windows.Forms.Button buttonConsultationsP;
        private System.Windows.Forms.Button buttonRemoveP;
        private System.Windows.Forms.TextBox textBoxMI;
        private System.Windows.Forms.Button buttonDiscard;
        private System.Windows.Forms.Button buttonCancelSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearchLN;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSearchCNP;
        private System.Windows.Forms.TextBox textBoxSearchN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleInitials;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPColumn;
    }
}