using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EESSP
{
    public partial class ConsultationsForm : Form
    {
        private ConnectionClass connectionClass;

        private Patient selectedPatient;
        private int currentConsultation;
        private ArrayList cims, consultations;
        private Consultation selectedConsultation = null;

        public ConsultationsForm(ConnectionClass connectionClass, Patient selectedPatient)
        {
            InitializeComponent();

            this.connectionClass = connectionClass;
            this.selectedPatient = selectedPatient;
            labelPatient.Text = selectedPatient.Name + " " + selectedPatient.LastName;

            currentConsultation = connectionClass.getLastConsultation();
            cims = connectionClass.getListCIM();
            createAutoSuggest();
            emptyFields();
            clickedAdd();
            updateDataGrid();
            if(consultations == null || consultations.Count == 0)
            {
                buttonModify.Enabled = false;
                buttonRemove.Enabled = false;
                buttonReport.Enabled = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            clickedAdd();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            emptyFields();
            invisibleAll();
            labelOption.Text = "Modify a consultation";
            visibleModifyAndRemove();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            emptyFields();
            invisibleAll();
            labelOption.Text = "Delete a consultation";
            visibleModifyAndRemove();
        }


        private void buttonReport_Click(object sender, EventArgs e)
        {
            emptyFields();
            invisibleAll();
            labelOption.Text = "Generate consultation report";

            PatientReport1.SetParameterValue("cnpParam", selectedPatient.CNP);
            new ReportsForm(PatientReport1).Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            switch (labelOption.Text)
            {
                case "Add new consultation":
                    {
                        insertConsultation();
                        break;
                    }
                case "Modify a consultation":
                    {
                        if (selectedConsultation == null) MessageBox.Show("No consultation selected!");
                        else updateConsultation();
                        break;
                    }
                case "Delete a consultation":
                    {
                        if (selectedConsultation == null) MessageBox.Show("No consultation selected!");
                        else deleteConsultation();
                        break;
                    }
            }
        }

        private void buttonDiscard_Click(object sender, EventArgs e)
        {
            emptyFields();
            buttonConfirm.Enabled = false;
        }

        private void radioButtonToday_CheckedChanged(object sender, EventArgs e)
        {
            if (!labelOption.Text.Contains("Add") && radioButtonToday.Checked) updateDataGrid();
            buttonConfirm.Enabled = radioButtonToday.Checked && !textBoxDiagnostic.Text.Equals("");
        }

        private void radioButtonAnotherDate_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBoxDate.Visible = radioButtonAnotherDate.Checked;
            if (!radioButtonAnotherDate.Checked) maskedTextBoxDate.Text = string.Empty;
            buttonConfirm.Enabled = radioButtonAnotherDate.Checked && !maskedTextBoxDate.Text.Equals("  -  -") && !textBoxDiagnostic.Text.Equals("");
        }

        private void maskedTextBoxDate_Click(object sender, EventArgs e)
        {
            maskedTextBoxDate.Select(0, 0);
        }

        private void maskedTextBoxDate_TextChanged(object sender, EventArgs e)
        {
            if (!labelOption.Text.Contains("Add")) updateDataGrid();
            buttonConfirm.Enabled = radioButtonAnotherDate.Checked && !maskedTextBoxDate.Text.Equals("  -  -") && !textBoxDiagnostic.Text.Equals("");
        }

        private void maskedTextBoxDate_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput) MessageBox.Show("Date is not valid.");
        }

        private void numericUpDownSearchID_ValueChanged(object sender, EventArgs e)
        {
            updateDataGrid();
        }

        private void textBoxDiagnostic_TextChanged(object sender, EventArgs e)
        {
            buttonConfirm.Enabled = radioButtonToday.Checked || (radioButtonAnotherDate.Checked && !maskedTextBoxDate.Text.Equals(""));
        }

        private void textBoxDiagnostic_KeyDown(object sender, KeyEventArgs e)
        {
            updateDataGrid();
        }

        private void textBoxDiagnostic_KeyUp(object sender, KeyEventArgs e)
        {
            updateDataGrid();
        }

        private void dataGridViewConsultations_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedConsultation = (Consultation)consultations[e.RowIndex];

                if (selectedConsultation != null)
                {
                    emptyFields();

                    numericUpDownSearchID.Visible = false;
                    checkBoxDate.Checked = true;
                    checkBoxDiagnostic.Checked = true;
                    labelIdC.Text = selectedConsultation.ID.ToString();
                    labelIdC.Visible = true;

                    textBoxDiagnostic.Text = new CimCodes(cims, selectedConsultation.CIM, "Diagnostic").Diagnostic;
                    radioButtonToday.Checked = selectedConsultation.Date.Equals(DateTime.Today.ToString("dd-MM-yyyy"));
                    radioButtonAnotherDate.Checked = !selectedConsultation.Date.Equals(DateTime.Today.ToString("dd-MM-yyyy"));
                    if (radioButtonAnotherDate.Checked) maskedTextBoxDate.Text = selectedConsultation.Date;

                    buttonConfirm.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Choose a valid row.\n" + ex.ToString());
            }
        }

        private void checkBoxID_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownSearchID.Visible = checkBoxID.Checked;
        }

        private void checkBoxDiagnostic_CheckedChanged(object sender, EventArgs e)
        {
            textBoxDiagnostic.Visible = checkBoxDiagnostic.Checked;
        }

        private void checkBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonToday.Visible = checkBoxDate.Checked;
            radioButtonAnotherDate.Visible = checkBoxDate.Checked;
            maskedTextBoxDate.Visible = radioButtonAnotherDate.Checked && checkBoxDate.Checked;
        }

        private void clickedAdd()
        {
            emptyFields();
            invisibleAll();
            labelOption.Text = "Add new consultation";
            visibleAdd();
            labelIdC.Text = currentConsultation.ToString();
            ActiveControl = textBoxDiagnostic;
        }

        private void insertConsultation()
        {
            string cim = new CimCodes(cims, textBoxDiagnostic.Text, "ID").ID;
            string date = (radioButtonToday.Checked) ? DateTime.Today.ToString("dd-MM-yyyy") : maskedTextBoxDate.Text;

            Consultation consultation = new Consultation(currentConsultation, selectedPatient.ID, cim, date);

            string command = "INSERT INTO consultations(IdPatient,CIM,ConsDate) VALUES(@IdPatient,@CIM,@ConsDate)";
            List<string> paramList = new List<string>();
            List<object> valueList = new List<object>();
            paramList.Add("@IdPatient");   valueList.Add(consultation.IdPatient);
            paramList.Add("@CIM");         valueList.Add(consultation.CIM);
            paramList.Add("@ConsDate");    valueList.Add(consultation.Date);

            if (connectionClass.sqlCommand(command, paramList, valueList, "Invalid operation!"))
            {
                currentConsultation += 1;
                MessageBox.Show("Successfully inserted!");
                emptyFields();
                visibleAdd();

                buttonModify.Enabled = true;
                buttonRemove.Enabled = true;
                buttonReport.Enabled = true;
            }
        }

        private void updateConsultation()
        {
            var confirmResult = MessageBox.Show("Are you sure to modify this patient?", "Modify Patient", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                string cim = new CimCodes(cims, textBoxDiagnostic.Text, "ID").ID;
                string date = (radioButtonToday.Checked) ? DateTime.Today.ToString("dd-MM-yyyy") : maskedTextBoxDate.Text;

                string command = "UPDATE consultations SET CIM=@CIM, ConsDate=@ConsDate WHERE ID=@ID";
                List<string> paramList = new List<string>();
                List<object> valueList = new List<object>();
                paramList.Add("@CIM"); valueList.Add(cim);
                paramList.Add("@ConsDate"); valueList.Add(date);
                paramList.Add("@ID"); valueList.Add(selectedConsultation.ID);

                if (connectionClass.sqlCommand(command, paramList, valueList, "Consultation could not be modified!"))
                {
                    MessageBox.Show("Successfully updated!");
                    emptyFields();
                    labelIdC.Visible = false;
                    buttonConfirm.Enabled = false;
                }
            }
        }

        private void deleteConsultation()
        {
            if (selectedPatient == null)
            {
                MessageBox.Show("No consultation selected!");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this consultation?", "Delete Consultation", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                string command = "DELETE FROM consultations WHERE ID=@ID";
                List<string> paramList = new List<string>();
                List<object> valueList = new List<object>();
                paramList.Add("@ID"); valueList.Add(selectedConsultation.ID);

                if (connectionClass.sqlCommand(command, paramList, valueList, "Consultation could not be deleted!"))
                {
                    MessageBox.Show("Successfully deleted!");
                    updateDataGrid();
                    emptyFields();
                }
            }
        }

        private void updateDataGrid()
        {
            int id = (int) numericUpDownSearchID.Value;
            string cim = new CimCodes(cims, textBoxDiagnostic.Text, "ID").ID;
            string date = (radioButtonToday.Checked) ? DateTime.Today.ToString("dd-MM-yyyy") : maskedTextBoxDate.Text;

            int count = 0;

            string query = "select * from consultations where ";
            if (checkBoxID.Checked)
            {
                query += "ID=" + id;
                count++;
            }
            if(checkBoxDiagnostic.Checked)
            {
                if (count > 0) query += " and ";
                query += "CIM like \'%" + cim + "%\'";
                count++;
            }
            if(checkBoxDate.Checked)
            {
                if (count > 0) query += " and ";
                query += "ConsDate like \'%" + date + "%\'";
                count++;
            }
            if (count > 0) query += " and ";
            query += "IdPatient=" + selectedPatient.ID;

            consultations = connectionClass.getConsultationsData(query);

            dataGridViewConsultations.Rows.Clear();
            if (consultations != null)
            {
                foreach (Consultation cons in consultations)
                {
                    DataGridViewRow newRow = new DataGridViewRow();

                    newRow.CreateCells(dataGridViewConsultations);
                    newRow.Cells[0].Value = cons.ID;
                    newRow.Cells[1].Value = cons.Date;
                    newRow.Cells[2].Value = new CimCodes(cims, cons.CIM, "Diagnostic").Diagnostic;
                    dataGridViewConsultations.Rows.Add(newRow);
                }
            }
        }

        private void createAutoSuggest()
        {
            var source = new AutoCompleteStringCollection();
            string[] diagnostics = new string[cims.Count];
            int count = 0;

            foreach (CimCodes cim in cims)
            {
                diagnostics[count] = cim.Diagnostic;
                count++;
            }
            source.AddRange(diagnostics);

            textBoxDiagnostic.AutoCompleteCustomSource = source;
        }

        private void emptyFields()
        {
            if (consultations != null && consultations.Count > 0)
            {
                Consultation cons = (Consultation)consultations[0];
                numericUpDownSearchID.Value = cons.ID;
            }
            else numericUpDownSearchID.Value = numericUpDownSearchID.Minimum;

            textBoxDiagnostic.Text = string.Empty;

            radioButtonToday.Checked = true;
            radioButtonAnotherDate.Checked = false;
            maskedTextBoxDate.Text = string.Empty;
            labelIdC.Visible = false;

            checkBoxID.Checked = false;
            checkBoxDate.Checked = false;
            checkBoxDiagnostic.Checked = false;

            updateDataGrid();

            buttonConfirm.Enabled = false;
        }

        private void visibleAdd()
        {
            label2.Visible = true;
            labelIdC.Visible = true;
            labelIdC.Text = currentConsultation.ToString();

            label4.Visible = true;
            labelDiagnostic.Visible = true;
            textBoxDiagnostic.Visible = true;

            label5.Visible = true;
            radioButtonToday.Visible = true;
            radioButtonAnotherDate.Visible = true;

            buttonConfirm.Visible = true;
            buttonDiscard.Visible = true;
        }

        private void visibleModifyAndRemove()
        {
            label6.Visible = true;
            label2.Visible = true;
            label4.Visible = true;
            label5.Visible = true;

            buttonConfirm.Visible = true;
            buttonDiscard.Visible = true;

            checkBoxID.Visible = true;
            checkBoxDate.Visible = true;
            checkBoxDiagnostic.Visible = true;

            dataGridViewConsultations.Visible = true;
            ActiveControl = checkBoxID;
        }

        private void invisibleAll()
        {
            label6.Visible = false;

            label2.Visible = false;
            labelIdC.Visible = false;
            numericUpDownSearchID.Visible = false;

            label4.Visible = false;
            labelDiagnostic.Visible = false;
            textBoxDiagnostic.Visible = false;

            label5.Visible = false;
            radioButtonToday.Visible = false;
            radioButtonAnotherDate.Visible = false;
            maskedTextBoxDate.Visible = false;

            buttonConfirm.Visible = false;
            buttonDiscard.Visible = false;

            checkBoxID.Visible = false;
            checkBoxDate.Visible = false;
            checkBoxDiagnostic.Visible = false;

            dataGridViewConsultations.Visible = false;
        }
    }
}
