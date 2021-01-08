using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EESSP
{
    public partial class AddPatientForm : Form
    {
        public Patient newPatient { get; private set; }
        public DialogResult result { get; private set; }

        private ConnectionClass connectionClass;
        private int IdDoc;

        private void startForm(ConnectionClass connectionClass, int IdDoc)
        {
            InitializeComponent();
            this.connectionClass = connectionClass;
            this.IdDoc = IdDoc;
            buttonAddP.Enabled = false;
            newPatient = null;
        }

        public AddPatientForm(ConnectionClass connectionClass, int IdDoc)
        {
            startForm(connectionClass, IdDoc);
            removeCNPDetails();
        }

        public AddPatientForm(ConnectionClass connectionClass, int IdDoc, string cnp)
        {
            maskedTextBoxID.Text = cnp;
            startForm(connectionClass, IdDoc);
            removeCNPDetails();
        }

        private void buttonAddP_Click(object sender, EventArgs e)
        {
            string cnp = maskedTextBoxID.Text;
            string name = textBoxName.Text;
            string lastname = textBoxLastName.Text;
            string MI = textBoxMI.Text;
            string address = textBoxAddress.Text;

            string command = "INSERT INTO patients(IDDoc,name,MI,lastname,cnp,address) VALUES(@IDDoc,@name,@MI,@lastname,@cnp,@address)";
            List<string> paramList = new List<string>();
            List<object> valueList = new List<object>();
            paramList.Add("@IDDoc"); valueList.Add(IdDoc);
            paramList.Add("@name"); valueList.Add(name);
            paramList.Add("@MI"); valueList.Add(MI);
            paramList.Add("@lastname"); valueList.Add(lastname);
            paramList.Add("@cnp");       valueList.Add(cnp);
            paramList.Add("@address");   valueList.Add(address);

            if (connectionClass.sqlCommand(command, paramList, valueList, "Patient CNP already exists!"))
            {
                newPatient = connectionClass.checkCNP(cnp);
                newPatient.getDoc(connectionClass);
                result = MessageBox.Show("Successfully inserted!");
                emptyFields();
                Close();
            }
            else maskedTextBoxID.Text = string.Empty;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Close();
            }
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
            labelDOB.Text = p.DateOfBirth.ToString("dd - MMM - yyyy");
            labelAge.Text = p.Age.ToString();
            labelSex.Text = p.Sex;
            labelBirthPlace.Text = p.BirthPlace;
        }

        private void removeCNPDetails()
        {
            labelDOB.Text = string.Empty;
            labelAge.Text = string.Empty;
            labelSex.Text = string.Empty;
            labelBirthPlace.Text = string.Empty;

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
