using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EESSP
{
    public partial class MainForm : Form
    {
        private Doctor userDoctor;
        private ConnectionClass connectionClass = new ConnectionClass();
        private HelperForm helperForm;

        private ArrayList patients;
        public Patient selectedPatient = null;
        private AddPatientForm addForm = null;

        public MainForm(int IdDoc)
        {
            InitializeComponent();
            userDoctor = new Doctor(connectionClass, IdDoc);
            labelDoctor.Text = "Doctor: " + userDoctor.Name + " " + userDoctor.LastName;
            helperForm = new HelperForm(this);
            removePatientDetails();
        }
        
        private void buttonAddP_Click(object sender, EventArgs e)
        {
            if (!maskedTextBoxSearchCNP.Text.Equals("") && maskedTextBoxSearchCNP.Text.Length == 13) addForm = new AddPatientForm(connectionClass, userDoctor.IDDoc, maskedTextBoxSearchCNP.Text);
            else addForm = new AddPatientForm(connectionClass, userDoctor.IDDoc);

            addForm.Show();
            addForm.FormClosed += new FormClosedEventHandler(AddPatietForm_FormClosed);
        }

        void AddPatietForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (addForm.result == DialogResult.OK)
            {
                selectedPatient = addForm.newPatient;
                patientDetails();
            }
            
            buttonCancelSearch_Click(sender, e);
            maskedTextBoxID.Text = string.Empty;
        }

        private void buttonList_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelSearch_Click(object sender, EventArgs e)
        {
            textBoxSearchN.Text = string.Empty;
            textBoxSearchLN.Text = string.Empty;
            maskedTextBoxSearchCNP.Text = string.Empty;

            dataGridViewPatients.Rows.Clear();
        }

        private void buttonModifyP_Click(object sender, EventArgs e)
        {
            if (selectedPatient == null)
            {
                MessageBox.Show("No patient selected!");
                return;
            }

            buttonDiscard.Visible = true;
            buttonRemoveP.Enabled = false;
            buttonConsultationsP.Enabled = false;

            domainUpDownOptions.Visible = true;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string option = "";
            string modifiedField = "";
            switch (domainUpDownOptions.Text)
            {
                case "Name":
                    {
                        option = "name";
                        modifiedField = textBoxName.Text;
                        break;
                    }
                case "Last Name":
                    {
                        option = "lastname";
                        modifiedField = textBoxLastName.Text;
                        break;
                    }
                case "M.I.":
                    {
                        option = "MI";
                        modifiedField = textBoxMI.Text;
                        break;
                    }
                case "CNP":
                    {
                        option = "cnp";
                        modifiedField = maskedTextBoxID.Text;
                        break;
                    }
                case "Address":
                    {
                        option = "address";
                        modifiedField = textBoxAddress.Text;
                        break;
                    }
            }
            var confirmResult = MessageBox.Show("Are you sure to modify this patient?", "Modify Patient", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                string command = "UPDATE patients SET " + option + "=@" + option + " WHERE ID=@ID";
                List<string> paramList = new List<string>();
                List<object> valueList = new List<object>();
                paramList.Add("@" + option); valueList.Add(modifiedField);
                paramList.Add("@ID"); valueList.Add(selectedPatient.ID);

                if (connectionClass.sqlCommand(command, paramList, valueList, "Patient could not be modified!"))
                {
                    MessageBox.Show("Successfully updated!");
                    buttonDiscard_Click(sender, e);
                    selectedPatient = connectionClass.updatePatient(selectedPatient.ID);
                    patientDetails();
                }
            }
        }

        private void buttonDiscard_Click(object sender, EventArgs e)
        {
            textBoxName.Text = string.Empty;
            textBoxLastName.Text = string.Empty;
            textBoxMI.Text = string.Empty;
            maskedTextBoxID.Text = string.Empty;
            textBoxAddress.Text = string.Empty;

            makeAllBoxesInvisible();

            buttonRemoveP.Enabled = true;
            buttonConsultationsP.Enabled = true;

            domainUpDownOptions.Text = "Choose category";
            domainUpDownOptions.Visible = false;
            buttonConfirm.Visible = false;
            buttonDiscard.Visible = false;
        }

        private void buttonConsultationsP_Click(object sender, EventArgs e)
        {
            if (selectedPatient == null)
            {
                MessageBox.Show("No patient selected!");
                return;
            }

            new ConsultationsForm(connectionClass, selectedPatient).Show();
        }

        private void buttonRemoveP_Click(object sender, EventArgs e)
        {
            if (selectedPatient == null)
            {
                MessageBox.Show("No patient selected!");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this patient?","Delete Patient",MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                string command = "DELETE FROM patients WHERE ID=@ID";
                List<string> paramList = new List<string>();
                List<object> valueList = new List<object>();
                paramList.Add("@ID"); valueList.Add(selectedPatient.ID);

                if (connectionClass.sqlCommand(command, paramList, valueList, "Patient could not be deleted!"))
                {
                    MessageBox.Show("Successfully deleted!");
                    buttonChangeP_Click(sender, e);
                }
            }
        }

        private void buttonChangeP_Click(object sender, EventArgs e)
        {
            if (selectedPatient == null)
            {
                MessageBox.Show("No patient selected!");
                return;
            }

            removePatientDetails();
            buttonDiscard_Click(sender, e);
        }

        private void textBoxSearchN_TextChanged(object sender, EventArgs e)
        {
            if (checkNoEmptySearch()) updateDataGrid();
            else dataGridViewPatients.Rows.Clear();
        }

        private void textBoxSearchLN_TextChanged(object sender, EventArgs e)
        {
            if (checkNoEmptySearch()) updateDataGrid();
            else dataGridViewPatients.Rows.Clear();
        }

        private void maskedTextBoxSearchCNP_Click(object sender, EventArgs e)
        {
            maskedTextBoxSearchCNP.Select(0, 0);
        }

        private void maskedTextBoxSearchCNP_TextChanged(object sender, EventArgs e)
        {
            if (checkNoEmptySearch()) updateDataGrid();
            else dataGridViewPatients.Rows.Clear();
        }

        private void dataGridViewPatients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedPatient = (Patient)patients[e.RowIndex];
                if (selectedPatient != null) patientDetails();

                buttonCancelSearch_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Choose a valid row.\n" + ex.ToString());
            }
        }

        private void domainUpDownOptions_SelectedItemChanged(object sender, EventArgs e)
        {
            makeAllBoxesInvisible();

            if (domainUpDownOptions.Text.Equals("Choose category"))
            {
                buttonConfirm.Visible = false;
                return;
            }

            switch (domainUpDownOptions.Text)
            {
                case "Name":
                    {
                        textBoxName.Visible = true;
                        break;
                    }
                case "Last Name":
                    {
                        textBoxLastName.Visible = true;
                        break;
                    }
                case "M.I.":
                    {
                        textBoxMI.Visible = true;
                        break;
                    }
                case "CNP":
                    {
                        maskedTextBoxID.Visible = true;
                        break;
                    }
                case "Address":
                    {
                        textBoxAddress.Visible = true;
                        break;
                    }
            }

            buttonConfirm.Visible = true;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            buttonConfirm.Enabled = false;
            if (checkAllNotEmptyFields()) buttonConfirm.Enabled = true;
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            buttonConfirm.Enabled = false;
            if (checkAllNotEmptyFields()) buttonConfirm.Enabled = true;
        }

        private void textBoxMI_TextChanged(object sender, EventArgs e)
        {
            buttonConfirm.Enabled = false;
            if (checkAllNotEmptyFields()) buttonConfirm.Enabled = true;
        }

        private void maskedTextBoxID_Click(object sender, EventArgs e)
        {
            maskedTextBoxID.Select(0, 0);
        }

        private void maskedTextBoxID_TextChanged(object sender, EventArgs e)
        {
            buttonConfirm.Enabled = false;
            if (!checkAllNotEmptyFields()) return;

            if (maskedTextBoxID.Text.Length == 13)
            {
                if (connectionClass.checkCNP(maskedTextBoxID.Text) == null)
                {
                    buttonConfirm.Enabled = true;
                }
                else MessageBox.Show("CNP already exists.");
            }
        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
            buttonConfirm.Enabled = false;
            if (checkAllNotEmptyFields()) buttonConfirm.Enabled = true;
        }

        private void updateDataGrid()
        {
            string query = "select * from patients where ";
            query += "name like \'" + textBoxSearchN.Text + "%\' and ";
            query += "lastname like \'" + textBoxSearchLN.Text + "%\' and ";
            query += "CNP like \'" + maskedTextBoxSearchCNP.Text + "%\'";

            patients = connectionClass.getPatientsData(query);

            dataGridViewPatients.Rows.Clear();

            if (patients != null)
            {
                foreach (Patient p in patients)
                {
                    DataGridViewRow newRow = new DataGridViewRow();

                    newRow.CreateCells(dataGridViewPatients);
                    newRow.Cells[0].Value = p.Name;
                    newRow.Cells[1].Value = p.MiddleInitials;
                    newRow.Cells[2].Value = p.LastName;
                    newRow.Cells[3].Value = p.CNP;
                    dataGridViewPatients.Rows.Add(newRow);
                }
            }
        }

        private void makeAllBoxesInvisible()
        {
            textBoxName.Visible = false;
            textBoxLastName.Visible = false;
            textBoxMI.Visible = false;
            maskedTextBoxID.Visible = false;
            textBoxAddress.Visible = false;
        }

        private bool checkAllNotEmptyFields()
        {
            if (textBoxName.Text == string.Empty &&
                textBoxLastName.Text == string.Empty &&
                textBoxMI.Text == string.Empty &&
                maskedTextBoxID.Text == string.Empty &&
                textBoxAddress.Text == string.Empty) return false;
            return true;
        }

        private bool checkNoEmptySearch()
        {
            if (textBoxSearchN.Text == string.Empty &&
                textBoxSearchLN.Text == string.Empty &&
                maskedTextBoxSearchCNP.Text == string.Empty) return false;
            return true;
        }

        private void patientDetails()
        {
            labelName.Text = selectedPatient.Name;
            labelLastName.Text = selectedPatient.LastName;
            labelMI.Text = selectedPatient.MiddleInitials;
            labelCNP.Text = selectedPatient.CNP;
            labelAddress.Text = selectedPatient.Address;
            labelDOB.Text = selectedPatient.DateOfBirth.ToString("dd - MMM - yyyy");
            labelAge.Text = selectedPatient.Age.ToString();
            labelSex.Text = selectedPatient.Sex;
            labelBirthPlace.Text = selectedPatient.BirthPlace;
            selectedPatient.getDoc(connectionClass);
            labelRefDoc.Text = selectedPatient.ReferingDoctor.Name + " " + selectedPatient.ReferingDoctor.LastName;
        }

        private void removePatientDetails()
        {
            labelName.Text = string.Empty;
            labelLastName.Text = string.Empty;
            labelMI.Text = string.Empty;
            labelCNP.Text = string.Empty;
            labelAddress.Text = string.Empty;
            labelDOB.Text = string.Empty;
            labelAge.Text = string.Empty;
            labelSex.Text = string.Empty;
            labelBirthPlace.Text = string.Empty;
            labelRefDoc.Text = string.Empty;
        }
    }
}
