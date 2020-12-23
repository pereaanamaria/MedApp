using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace EESSP
{
    public partial class MainForm : Form
    {
        private Doctor userDoctor;
        private ConnectionClass connectionClass = new ConnectionClass();
        private HelperForm helperForm;

        private ArrayList patients;
        private Patient selectedPatient = null;

        public MainForm(int IdDoc)
        {
            InitializeComponent();
            userDoctor = new Doctor(connectionClass, IdDoc);
            labelDoctorName.Text = userDoctor.Name + " " + userDoctor.LastName;
            helperForm = new HelperForm(this);
        }

        private void buttonAddP_Click(object sender, EventArgs e)
        {
            if (selectedPatient != null)
            {
                MessageBox.Show("The patient is already registered.");
                return;
            }

            if (!maskedTextBoxID.Text.Equals("") && maskedTextBoxID.Text.Length == 13) new AddPatientForm(connectionClass, userDoctor.IDDoc, maskedTextBoxID.Text).Show();
            else new AddPatientForm(connectionClass, userDoctor.IDDoc).Show();

            buttonCancelP_Click(sender, e);
            maskedTextBoxID.Text = string.Empty;
        }

        private void buttonModifyP_Click(object sender, EventArgs e)
        {
            if(!checkAllNotEmptyFields())
            {
                MessageBox.Show("Search for a patient.");
                return;
            }

            string cnp = maskedTextBoxID.Text;
            string name = textBoxName.Text;
            string lastname = textBoxLastName.Text;
            string MI = textBoxMI.Text;
            string address = textBoxAddress.Text;
            selectedPatient.getDoc(connectionClass);
            
            string command = "UPDATE patients SET cnp=@cnp, name=@name, lastname =@lastname, address=@address, IDDoc=@IDDoc, MI=@MI WHERE ID=@ID";
            List<string> paramList = new List<string>();
            List<object> valueList = new List<object>();
            paramList.Add("@cnp");       valueList.Add(cnp);
            paramList.Add("@name");      valueList.Add(name);
            paramList.Add("@lastname");  valueList.Add(lastname);
            paramList.Add("@address");   valueList.Add(address);
            paramList.Add("@IDDoc");     valueList.Add(selectedPatient.ReferingDoctor.IDDoc);
            paramList.Add("@MI");        valueList.Add(MI);
            paramList.Add("@ID");        valueList.Add(selectedPatient.ID);

            if (connectionClass.sqlCommand(command, paramList, valueList, "Patient could not be modified!"))
            {
                MessageBox.Show("Successfully updated!");
            }
        }

        private void buttonRemoveP_Click(object sender, EventArgs e)
        {
            if (!checkAllNotEmptyFields())
            {
                MessageBox.Show("Search for a patient.");
                return;
            }

            string command = "DELETE FROM patients WHERE ID=@ID";
            List<string> paramList = new List<string>();
            List<object> valueList = new List<object>();
            paramList.Add("@ID");    valueList.Add(selectedPatient.ID);

            if (connectionClass.sqlCommand(command, paramList, valueList, "Patient could not be deleted!"))
            {
                MessageBox.Show("Successfully deleted!");
                buttonCancelP_Click(sender, e);
            }
        }

        private void buttonCancelP_Click(object sender, EventArgs e)
        {
            textBoxName.Text = string.Empty;
            textBoxLastName.Text = string.Empty;
            textBoxMI.Text = string.Empty;
            maskedTextBoxID.Text = string.Empty;
            textBoxAddress.Text = string.Empty;
            labelRefDoc.Text = "Refering Doctor:";
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (checkAllNotEmptyFields()) updateDataGrid();
            else dataGridViewPatients.Rows.Clear();
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            if (checkAllNotEmptyFields()) updateDataGrid();
            else dataGridViewPatients.Rows.Clear();
        }

        private void textBoxMI_TextChanged(object sender, EventArgs e)
        {
            if (checkAllNotEmptyFields()) updateDataGrid();
            else dataGridViewPatients.Rows.Clear();
        }

        private void maskedTextBoxID_Click(object sender, EventArgs e)
        {
            this.maskedTextBoxID.Select(0, 0);
        }

        private void maskedTextBoxID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (maskedTextBoxID.Text.Equals(string.Empty))
                {
                    removeCNPDetails();
                }

                if (checkAllNotEmptyFields()) updateDataGrid();
                else dataGridViewPatients.Rows.Clear();

                if (maskedTextBoxID.Text.Length == 13)
                {
                    Patient patient = new Patient();
                    patient.getCnpDetails(maskedTextBoxID.Text);
                    addPatientCNPDetails(patient);

                    if (patient.checkExistingPatient(connectionClass))
                    {
                        autoFillInPatient(patient);
                        selectedPatient = patient;
                    }
                    else selectedPatient = null;
                }
                else selectedPatient = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
            if (checkAllNotEmptyFields()) updateDataGrid();
            else dataGridViewPatients.Rows.Clear();
        }

        private void dataGridViewPatients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                postPatient(e.RowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Choose a valid row.\n" + ex.ToString());
            }
        }

        private void autoFillInPatient(Patient p)
        {
            textBoxName.Text = p.Name;
            textBoxLastName.Text = p.LastName;
            textBoxMI.Text = p.MiddleInitials;
            textBoxAddress.Text = p.Address;
            labelRefDoc.Text = "Refering Doctor: " + p.ReferingDoctor.Name + " " + p.ReferingDoctor.LastName;
        }

        private void addPatientCNPDetails(Patient p)
        {
            labelDOB.Text = "Date of Birth: " + p.DateOfBirth.ToString("dd - MMM - yyyy");
            labelAge.Text = "Age: " + p.Age;
            labelSex.Text = "Sex: " + p.Sex;
            labelBirthPlace.Text = "Birth Place: " +p.BirthPlace;
            labelRegisterNr.Text = "Register Number: " + p.RegisterNr;
        }

        private void removeCNPDetails()
        {
            labelDOB.Text = "Date of Birth: ";
            labelAge.Text = "Age: ";
            labelSex.Text = "Sex: ";
            labelBirthPlace.Text = "Birth Place: ";
            labelRegisterNr.Text = "Register Number: ";
        }
        
        private void updateDataGrid()
        {
            string query = "select * from patients where ";
            query += "name like \'" + textBoxName.Text + "%\' and ";
            query += "lastname like \'" + textBoxLastName.Text + "%\' and ";
            query += "MI like \'%" + textBoxMI.Text + "%\' and ";
            query += "CNP like \'" + maskedTextBoxID.Text + "%\' and ";
            query += "address like \'%" + textBoxAddress.Text + "%\'";

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
                    newRow.Cells[4].Value = p.Address;
                    p.getDoc(connectionClass);
                    newRow.Cells[5].Value = p.ReferingDoctor.Name + " " + p.ReferingDoctor.LastName;
                    dataGridViewPatients.Rows.Add(newRow);
                }
            }
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

        private void postPatient(int rowIndex)
        {
            selectedPatient = (Patient) patients[rowIndex];
            textBoxName.Text = selectedPatient.Name;
            textBoxMI.Text = selectedPatient.MiddleInitials;
            textBoxLastName.Text = selectedPatient.LastName;
            maskedTextBoxID.Text = selectedPatient.CNP;
            textBoxAddress.Text = selectedPatient.Address;
        }
    }
}
