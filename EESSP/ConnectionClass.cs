﻿using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
                MessageBox.Show("Patient CNP already exists!");
            }
            return false;
        }

        public DataSet loadDataGridiew(string command, string table)
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

        public ArrayList getPatientsData(string query)
        {
            MySqlDataReader rowReader = null;
            try
            {
                ArrayList listPatients = new ArrayList();

                rowReader = execReader(query);
                if (rowReader.HasRows)
                {
                    while (rowReader.Read())
                    {
                        string cnp = rowReader["CNP"].ToString();
                        string name = rowReader["name"].ToString();
                        string lastName = rowReader["lastname"].ToString();
                        string address = rowReader["address"].ToString();
                        string mi = rowReader["MI"].ToString();
                        int idDoc = int.Parse(rowReader["IDDoc"].ToString());
                        Patient p = new Patient(this, cnp, name, lastName, address, idDoc, mi);
                        listPatients.Add(p);
                    }
                }
                rowReader.Close();
                if (listPatients.Count != 0) return listPatients;
                return null;
            }
            catch (Exception ex)
            {
                if(rowReader != null) rowReader.Close();
                return null;
            }
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
