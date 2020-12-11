using System;
using System.Collections;
using System.Windows.Forms;

namespace EESSP
{
    public partial class MainForm : Form
    {
        private Doctor userDoctor;
        private ConnectionClass connectionClass = new ConnectionClass();
        private HelperForm helperForm;

        private static ArrayList ListCNP = new ArrayList();
        private static ArrayList ListName = new ArrayList();
        private static ArrayList ListLastName = new ArrayList();
        private static ArrayList ListAddress = new ArrayList();
        private static ArrayList ListIDDoc = new ArrayList();
        private static ArrayList ListMI = new ArrayList();

        public MainForm(int IdDoc)
        {
            InitializeComponent();
            userDoctor = new Doctor(connectionClass, IdDoc);
            labelDoctorName.Text = userDoctor.Name + " " + userDoctor.LastName;
            helperForm = new HelperForm(this);
        }

        private void buttonAddP_Click(object sender, EventArgs e)
        {
            if (!maskedTextBoxID.Text.Equals("") && maskedTextBoxID.Text.Length == 13) new AddPatientForm(connectionClass, userDoctor.ID, maskedTextBoxID.Text).Show();
            else new AddPatientForm(connectionClass, userDoctor.ID).Show();

            maskedTextBoxID.Text = string.Empty;
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
            updateDatagrid();
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

                    if (patient.checkExistingPatient(connectionClass))
                    {
                        autoFillInPatient(patient);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void autoFillInPatient(Patient p)
        {
            textBoxName.Text = p.Name;
            textBoxLastName.Text = p.LastName;
            textBoxMI.Text = p.MiddelInitials;
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
    }
}
