using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySQLDBManager
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection();

        MySqlCommand cmd = new MySqlCommand();

        MySqlDataReader reader;

        public Form1()
        {
            InitializeComponent();
        }

        public void LoginVisibleChange(bool change)
        {
            tbDatabase.Visible = change;
            tbPassword.Visible = change;
            tbPort.Visible = change;
            tbServer.Visible = change;
            tbUser.Visible = change;

            lServer.Visible = change;
            lDatabase.Visible = change;
            lPassword.Visible = change;
            lPort.Visible = change;
            lUser.Visible = change;

            bConnect.Visible = change;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.ConnectionString = "Server=localhost;Database=cssdb;User ID=destine;Password=destine";

            con.Open();
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "CREATE TABLE abc(Weight INT, Name TEXT, Breed TEXT)";
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            lErrorConnect.Visible = false;

            MySqlConnection con = new MySqlConnection("Server=" + tbServer.Text + ";Port=" + tbPort.Text + ";Database=" + tbDatabase.Text + ";User ID= " + tbUser.Text + ";Password=" + tbPassword.Text);

            try
            {
                con.Open();
                LoginVisibleChange(false);
            }

            catch (Exception)
            {
                lErrorConnect.Visible = true;
                //throw;
            }

            finally
            {
                lDataBaseName.Visible = true;
                lSelectTable.Visible = true;
                lDataBaseName.Text = "Database: " + tbDatabase.Text;

                cbTable.Visible = true;

                cmd = con.CreateCommand();
                cmd.CommandText = "select table_name from information_schema.tables where table_schema='" + tbDatabase.Text + "'";
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbTable.Items.Add(reader["TABLE_NAME"].ToString());
                }
                con.Close();
            }
        }
    
}
}