using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace EESSP
{
    class Doctor
    {
        public int ID { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public string Name { get; private set; }
        public string LastName { get; private set; }

        public Doctor(ConnectionClass connectionClass, int id)
        {
            ID = id;
            createDoc(connectionClass);
        }

        public Doctor(ConnectionClass connectionClass, string id)
        {
            ID = int.Parse(id);
            createDoc(connectionClass);
        }

        private void createDoc(ConnectionClass connectionClass)
        {
            try
            {
                string query = "select * from doctors WHERE ID=" + ID;
                MySqlDataReader rowReader = connectionClass.execReader(query);
                if (rowReader.HasRows)
                {
                    while (rowReader.Read())
                    {
                        UserName = rowReader["username"].ToString();
                        Password = rowReader["password"].ToString();
                        Name = rowReader["name"].ToString();
                        LastName = rowReader["lastname"].ToString();

                    }
                    rowReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
