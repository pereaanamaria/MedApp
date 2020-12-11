using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace EESSP
{
    public class ConnectionClass
    {
        private MySqlConnection mySqlConn { get; set; }

        public ConnectionClass()
        {
            connect();
        }

        public MySqlDataReader execReader(string query)
        {
            MySqlCommand command = new MySqlCommand(query, mySqlConn);
            return command.ExecuteReader();
        }

        public DataSet ExecuteDataSet(string command, string table)
        {
            try
            {
                DataSet dataSet = new DataSet();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command, mySqlConn);
                dataAdapter.Fill(dataSet, table);
                return dataSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public bool insertCommand(string command, List<string> paramList, List<object> valueList)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = mySqlConn;
                cmd.CommandText = command;
                cmd.Prepare();
                
                for(int i=0; i<paramList.Count; i++)
                    cmd.Parameters.AddWithValue(paramList[i], valueList[i]);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return false;
        }

        private void connect()
        {
            try
            {
                string mySqlStr = "Server=localhost;Database=eessp;Uid=root;Pwd=parola";
                mySqlConn = new MySqlConnection(mySqlStr);
                mySqlConn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void disconnect()
        {
            mySqlConn.Close();
        }
    }
}
