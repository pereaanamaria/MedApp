using MySql.Data.MySqlClient;
using System;

namespace EESSP
{
    public class Patient
    {
        public int ID { get; private set; }
        public string CNP { get; private set; }
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string MiddleInitials { get; private set; }
        public string Address { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public int Age { get; private set; }
        public string Sex { get; private set; }
        public string BirthPlace { get; private set; }
        public string RegisterNr { get; private set; }
        public Doctor ReferingDoctor { get; private set; }

        private int IDDoc;
        private MySqlDataReader rowReader;

        public Patient() { }

        public Patient(int ID, string CNP, string Name, string LastName, string Address, int IDDoc, string MiddleInitials)
        {
            this.ID = ID;
            this.CNP = CNP;
            getCnpDetails(CNP);
            this.Name = Name;
            this.LastName = LastName;
            this.Address = Address;
            this.MiddleInitials = MiddleInitials;
            this.IDDoc = IDDoc;
        }

        public void getDoc(ConnectionClass connectionClass)
        {
            ReferingDoctor = new Doctor(connectionClass, IDDoc);
        }

        public void getCnpDetails(string cnp)
        {
            CNP = cnp;

            string str = cnp.Substring(0, 1);
            string yearPrefix = (str.Equals("1") || str.Equals("2")) ? "19" : ((str.Equals("3") || str.Equals("4")) ? "18" : "20");
            Sex = (str.Equals("1") || str.Equals("3") || str.Equals("5")) ? "M" : "F";
            DateOfBirth = DateTime.Parse(cnp.Substring(5, 2) + "-" + cnp.Substring(3, 2) + "-" + yearPrefix + cnp.Substring(1, 2));
            Age = getAge(DateOfBirth);
            BirthPlace = new JudeteRo().getJudet(cnp.Substring(7, 2));
            RegisterNr = cnp.Substring(9, 3);
        }

        //get age from date of birth method
        private int getAge(DateTime dateOfBirth)
        {
            var today = DateTime.Today;
            var age = today.Year - dateOfBirth.Year;
            if (dateOfBirth.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
}
