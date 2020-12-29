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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelDoctor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCancelSearch = new System.Windows.Forms.Button();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearchLN = new System.Windows.Forms.TextBox();
            this.maskedTextBoxSearchCNP = new System.Windows.Forms.MaskedTextBox();
            this.textBoxSearchN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddP = new System.Windows.Forms.Button();
            this.buttonChangeP = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.labelDoctor.Location = new System.Drawing.Point(5, 5);
            this.labelDoctor.Name = "labelDoctor";
            this.labelDoctor.Size = new System.Drawing.Size(45, 13);
            this.labelDoctor.TabIndex = 0;
            this.labelDoctor.Text = "Doctor: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.labelDoctor);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 24);
            this.panel1.TabIndex = 2;
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
            this.panel2.Location = new System.Drawing.Point(12, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 311);
            this.panel2.TabIndex = 0;
            // 
            // buttonCancelSearch
            // 
            this.buttonCancelSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonCancelSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelSearch.Location = new System.Drawing.Point(200, 98);
            this.buttonCancelSearch.Name = "buttonCancelSearch";
            this.buttonCancelSearch.Size = new System.Drawing.Size(94, 22);
            this.buttonCancelSearch.TabIndex = 3;
            this.buttonCancelSearch.Text = "Cancel Search";
            this.buttonCancelSearch.UseVisualStyleBackColor = false;
            this.buttonCancelSearch.Click += new System.EventHandler(this.buttonCancelSearch_Click);
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.LastNameColumn,
            this.CNPColumn});
            this.dataGridViewPatients.Location = new System.Drawing.Point(7, 135);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPatients.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewPatients.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPatients.Size = new System.Drawing.Size(287, 169);
            this.dataGridViewPatients.TabIndex = 17;
            this.dataGridViewPatients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatients_CellDoubleClick);
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
            this.label6.Location = new System.Drawing.Point(5, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Search Patients";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "CNP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Name";
            // 
            // textBoxSearchLN
            // 
            this.textBoxSearchLN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxSearchLN.Location = new System.Drawing.Point(106, 59);
            this.textBoxSearchLN.Name = "textBoxSearchLN";
            this.textBoxSearchLN.Size = new System.Drawing.Size(90, 20);
            this.textBoxSearchLN.TabIndex = 1;
            this.textBoxSearchLN.TextChanged += new System.EventHandler(this.textBoxSearchLN_TextChanged);
            // 
            // maskedTextBoxSearchCNP
            // 
            this.maskedTextBoxSearchCNP.Location = new System.Drawing.Point(202, 59);
            this.maskedTextBoxSearchCNP.Mask = "0000000000000";
            this.maskedTextBoxSearchCNP.Name = "maskedTextBoxSearchCNP";
            this.maskedTextBoxSearchCNP.Size = new System.Drawing.Size(90, 20);
            this.maskedTextBoxSearchCNP.TabIndex = 2;
            this.maskedTextBoxSearchCNP.Click += new System.EventHandler(this.maskedTextBoxSearchCNP_Click);
            this.maskedTextBoxSearchCNP.TextChanged += new System.EventHandler(this.maskedTextBoxSearchCNP_TextChanged);
            // 
            // textBoxSearchN
            // 
            this.textBoxSearchN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxSearchN.Location = new System.Drawing.Point(10, 59);
            this.textBoxSearchN.Name = "textBoxSearchN";
            this.textBoxSearchN.Size = new System.Drawing.Size(90, 20);
            this.textBoxSearchN.TabIndex = 0;
            this.textBoxSearchN.TextChanged += new System.EventHandler(this.textBoxSearchN_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Last Name";
            // 
            // buttonAddP
            // 
            this.buttonAddP.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonAddP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddP.Location = new System.Drawing.Point(22, 20);
            this.buttonAddP.Name = "buttonAddP";
            this.buttonAddP.Size = new System.Drawing.Size(113, 23);
            this.buttonAddP.TabIndex = 4;
            this.buttonAddP.Text = "Add Patient";
            this.buttonAddP.UseVisualStyleBackColor = false;
            this.buttonAddP.Click += new System.EventHandler(this.buttonAddP_Click);
            // 
            // buttonChangeP
            // 
            this.buttonChangeP.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonChangeP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChangeP.Location = new System.Drawing.Point(438, 303);
            this.buttonChangeP.Name = "buttonChangeP";
            this.buttonChangeP.Size = new System.Drawing.Size(113, 23);
            this.buttonChangeP.TabIndex = 9;
            this.buttonChangeP.Text = "Change Patient";
            this.buttonChangeP.UseVisualStyleBackColor = false;
            this.buttonChangeP.Click += new System.EventHandler(this.buttonChangeP_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.buttonDiscard);
            this.panel3.Controls.Add(this.labelRefDoc);
            this.panel3.Controls.Add(this.buttonAddP);
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
            this.panel3.Location = new System.Drawing.Point(319, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(568, 341);
            this.panel3.TabIndex = 4;
            // 
            // buttonDiscard
            // 
            this.buttonDiscard.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonDiscard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDiscard.Location = new System.Drawing.Point(305, 236);
            this.buttonDiscard.Name = "buttonDiscard";
            this.buttonDiscard.Size = new System.Drawing.Size(113, 23);
            this.buttonDiscard.TabIndex = 9;
            this.buttonDiscard.Text = "Discard Modification";
            this.buttonDiscard.UseVisualStyleBackColor = false;
            this.buttonDiscard.Visible = false;
            this.buttonDiscard.Click += new System.EventHandler(this.buttonDiscard_Click);
            // 
            // labelRefDoc
            // 
            this.labelRefDoc.AutoSize = true;
            this.labelRefDoc.Location = new System.Drawing.Point(36, 293);
            this.labelRefDoc.Name = "labelRefDoc";
            this.labelRefDoc.Size = new System.Drawing.Size(88, 13);
            this.labelRefDoc.TabIndex = 43;
            this.labelRefDoc.Text = "Refering Doctor: ";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(36, 225);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(32, 13);
            this.labelAge.TabIndex = 42;
            this.labelAge.Text = "Age: ";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(36, 202);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(72, 13);
            this.labelDOB.TabIndex = 39;
            this.labelDOB.Text = "Date of Birth: ";
            // 
            // labelMI
            // 
            this.labelMI.AutoSize = true;
            this.labelMI.Location = new System.Drawing.Point(36, 128);
            this.labelMI.Name = "labelMI";
            this.labelMI.Size = new System.Drawing.Size(28, 13);
            this.labelMI.TabIndex = 49;
            this.labelMI.Text = "M.I.:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxLastName.Location = new System.Drawing.Point(305, 145);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(113, 20);
            this.textBoxLastName.TabIndex = 7;
            this.textBoxLastName.Visible = false;
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(36, 178);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(48, 13);
            this.labelAddress.TabIndex = 48;
            this.labelAddress.Text = "Address:";
            // 
            // textBoxName
            // 
            this.textBoxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxName.Location = new System.Drawing.Point(305, 146);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(113, 20);
            this.textBoxName.TabIndex = 7;
            this.textBoxName.Visible = false;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelBirthPlace
            // 
            this.labelBirthPlace.AutoSize = true;
            this.labelBirthPlace.Location = new System.Drawing.Point(36, 271);
            this.labelBirthPlace.Name = "labelBirthPlace";
            this.labelBirthPlace.Size = new System.Drawing.Size(64, 13);
            this.labelBirthPlace.TabIndex = 41;
            this.labelBirthPlace.Text = "Birth Place: ";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAddress.Location = new System.Drawing.Point(305, 145);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(113, 46);
            this.textBoxAddress.TabIndex = 7;
            this.textBoxAddress.Visible = false;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxAddress_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(36, 79);
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
            this.domainUpDownOptions.Location = new System.Drawing.Point(305, 115);
            this.domainUpDownOptions.Name = "domainUpDownOptions";
            this.domainUpDownOptions.Size = new System.Drawing.Size(113, 20);
            this.domainUpDownOptions.TabIndex = 6;
            this.domainUpDownOptions.Text = "Choose category";
            this.domainUpDownOptions.Visible = false;
            this.domainUpDownOptions.Wrap = true;
            this.domainUpDownOptions.SelectedItemChanged += new System.EventHandler(this.domainUpDownOptions_SelectedItemChanged);
            // 
            // labelCNP
            // 
            this.labelCNP.AutoSize = true;
            this.labelCNP.Location = new System.Drawing.Point(36, 153);
            this.labelCNP.Name = "labelCNP";
            this.labelCNP.Size = new System.Drawing.Size(32, 13);
            this.labelCNP.TabIndex = 47;
            this.labelCNP.Text = "CNP:";
            // 
            // maskedTextBoxID
            // 
            this.maskedTextBoxID.Location = new System.Drawing.Point(305, 145);
            this.maskedTextBoxID.Mask = "0000000000000";
            this.maskedTextBoxID.Name = "maskedTextBoxID";
            this.maskedTextBoxID.Size = new System.Drawing.Size(113, 20);
            this.maskedTextBoxID.TabIndex = 7;
            this.maskedTextBoxID.Visible = false;
            this.maskedTextBoxID.Click += new System.EventHandler(this.maskedTextBoxID_Click);
            this.maskedTextBoxID.TextChanged += new System.EventHandler(this.maskedTextBoxID_TextChanged);
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(36, 248);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(31, 13);
            this.labelSex.TabIndex = 40;
            this.labelSex.Text = "Sex: ";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(36, 102);
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
            this.buttonConfirm.Location = new System.Drawing.Point(305, 207);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(113, 23);
            this.buttonConfirm.TabIndex = 8;
            this.buttonConfirm.Text = "Confirm Modification";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Visible = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonModifyP
            // 
            this.buttonModifyP.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonModifyP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonModifyP.Location = new System.Drawing.Point(305, 79);
            this.buttonModifyP.Name = "buttonModifyP";
            this.buttonModifyP.Size = new System.Drawing.Size(113, 23);
            this.buttonModifyP.TabIndex = 5;
            this.buttonModifyP.Text = "Modify Patient";
            this.buttonModifyP.UseVisualStyleBackColor = false;
            this.buttonModifyP.Click += new System.EventHandler(this.buttonModifyP_Click);
            // 
            // buttonConsultationsP
            // 
            this.buttonConsultationsP.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonConsultationsP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConsultationsP.Location = new System.Drawing.Point(438, 79);
            this.buttonConsultationsP.Name = "buttonConsultationsP";
            this.buttonConsultationsP.Size = new System.Drawing.Size(113, 23);
            this.buttonConsultationsP.TabIndex = 6;
            this.buttonConsultationsP.Text = "Consultations";
            this.buttonConsultationsP.UseVisualStyleBackColor = false;
            this.buttonConsultationsP.Click += new System.EventHandler(this.buttonConsultationsP_Click);
            // 
            // buttonRemoveP
            // 
            this.buttonRemoveP.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonRemoveP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemoveP.Location = new System.Drawing.Point(438, 112);
            this.buttonRemoveP.Name = "buttonRemoveP";
            this.buttonRemoveP.Size = new System.Drawing.Size(113, 23);
            this.buttonRemoveP.TabIndex = 7;
            this.buttonRemoveP.Text = "Remove Patient";
            this.buttonRemoveP.UseVisualStyleBackColor = false;
            this.buttonRemoveP.Click += new System.EventHandler(this.buttonRemoveP_Click);
            // 
            // textBoxMI
            // 
            this.textBoxMI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxMI.Location = new System.Drawing.Point(305, 145);
            this.textBoxMI.Name = "textBoxMI";
            this.textBoxMI.Size = new System.Drawing.Size(113, 20);
            this.textBoxMI.TabIndex = 7;
            this.textBoxMI.Visible = false;
            this.textBoxMI.TextChanged += new System.EventHandler(this.textBoxMI_TextChanged);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPColumn;
        private System.Windows.Forms.Button buttonDiscard;
        private System.Windows.Forms.Button buttonCancelSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearchLN;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSearchCNP;
        private System.Windows.Forms.TextBox textBoxSearchN;
        private System.Windows.Forms.Label label2;
    }
}