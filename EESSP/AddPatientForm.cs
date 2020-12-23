using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EESSP
{
    public partial class AddPatientForm : Form
    {
        private ConnectionClass connectionClass;

        private int IdDoc;

        private void startForm(ConnectionClass connectionClass, int IdDoc)
        {
            InitializeComponent();
            this.connectionClass = connectionClass;
            this.IdDoc = IdDoc;
            buttonAddP.Enabled = false;
        }

        public AddPatientForm(ConnectionClass connectionClass, int IdDoc)
        {
            startForm(connectionClass, IdDoc);
        }

        public AddPatientForm(ConnectionClass connectionClass, int IdDoc, string cnp)
        {
            maskedTextBoxID.Text = cnp;
            startForm(connectionClass, IdDoc);
        }

        private void buttonAddP_Click(object sender, EventArgs e)
        {
            long cnp = long.Parse(maskedTextBoxID.Text);
            string name = textBoxName.Text;
            string lastname = textBoxLastName.Text;
            string MI = textBoxMI.Text;
            string address = textBoxAddress.Text;

            string command = "INSERT INTO patients(cnp,name,lastname,address,IDDoc,MI) VALUES(@cnp,@name,@lastname,@address,@IDDoc,@MI)";
            List<string> paramList = new List<string>();
            List<object> valueList = new List<object>();
            paramList.Add("@cnp"); valueList.Add(cnp);
            paramList.Add("@name"); valueList.Add(name);
            paramList.Add("@lastname"); valueList.Add(lastname);
            paramList.Add("@address"); valueList.Add(address);
            paramList.Add("@IDDoc"); valueList.Add(IdDoc);
            paramList.Add("@MI"); valueList.Add(MI);

            if (connectionClass.insertCommand(command, paramList, valueList))
            {
                MessageBox.Show("Successful insertion!");
                emptyFields();
            }
            else maskedTextBoxID.Text = string.Empty;
        }

        private void buttonCancelP_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void maskedTextBoxID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (maskedTextBoxID.Text.Equals(string.Empty))
                {
                    removeCNPDetails();
                }

                if (maskedTextBoxID.Text.Length == 13)
                {
                    Patient patient = new Patient();
                    patient.getCnpDetails(maskedTextBoxID.Text);
                    addPatientCNPDetails(patient);

                    checkForEmptyField();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            checkForEmptyField();
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            checkForEmptyField();
        }

        private void textBoxMI_TextChanged(object sender, EventArgs e)
        {
            checkForEmptyField();
        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
            checkForEmptyField();
        }

        private void addPatientCNPDetails(Patient p)
        {
            labelDOB.Text = "Date of Birth: " + p.DateOfBirth.ToString("dd - MMM - yyyy");
            labelAge.Text = "Age: " + p.Age;
            labelSex.Text = "Sex: " + p.Sex;
            labelBirthPlace.Text = "Birth Place: " + p.BirthPlace;
            labelRegisterNr.Text = "Register Number: " + p.RegisterNr;
        }

        private void removeCNPDetails()
        {
            labelDOB.Text = "Date of Birth: ";
            labelAge.Text = "Age: ";
            labelSex.Text = "Sex: ";
            labelBirthPlace.Text = "Birth Place: ";
            labelRegisterNr.Text = "Register Number: ";

            buttonAddP.Enabled = false;
        }

        private void emptyFields()
        {
            maskedTextBoxID.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxLastName.Text = string.Empty;
            textBoxMI.Text = string.Empty;
            textBoxAddress.Text = string.Empty;

            buttonAddP.Enabled = false;
        }

        private void checkForEmptyField()
        {
            bool cnp = maskedTextBoxID.Text.Equals("");
            bool name = textBoxName.Text.Equals("");
            bool lastName = textBoxLastName.Text.Equals("");
            bool mi = textBoxMI.Text.Equals("");
            bool address = textBoxAddress.Text.Equals("");

            if (cnp && name && lastName && mi && address) buttonAddP.Enabled = false;
            else buttonAddP.Enabled = true;
        }
    }
}
