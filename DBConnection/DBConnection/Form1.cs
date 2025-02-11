﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace DBConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string testConnect = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=DESKTOP-32LIGLH\SQLEXPRESS";

            OleDbConnection connection = new OleDbConnection();

            {
                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.ConnectionString = testConnect;
                        connection.Open();
                        MessageBox.Show("Соединение с базой данных выполнено успешно");
                    }
                    else
                        MessageBox.Show("Соединение с базой данных уже установлено");

                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                        MessageBox.Show("Соединение с базой данных закрыто");
                    }
                    else
                        MessageBox.Show("Соединение с базой данных уже закрыто");

                }
                catch (OleDbException XcpSQL)
                {

                    foreach (OleDbError se in XcpSQL.Errors)
                    {
                        MessageBox.Show(se.Message,
                        "SQL Error code " + se.NativeError,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                }

                catch (Exception Xcp)
                {
                    MessageBox.Show(Xcp.Message, "Unexpected Exception",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string testConnect = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=DESKTOP-32LIGLH\SQLEXPRESS";

            OleDbConnection connection = new OleDbConnection();

            connection.ConnectionString = testConnect;
            connection.Open();

            if (connection.State == ConnectionState.Closed)
            {
                MessageBox.Show("Сначала подключитесь к базе");
                return;
            }
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "SELECT COUNT(*) FROM Products";
            int number = (int)command.ExecuteScalar();
            label1.Text = number.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string testConnect = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=DESKTOP-32LIGLH\SQLEXPRESS";

            OleDbConnection connection = new OleDbConnection();

            connection.ConnectionString = testConnect;
            connection.Open();

            OleDbCommand command = connection.CreateCommand();
            command.CommandText = "SELECT ProductName FROM Products";
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                listView1.Items.Add(reader["ProductName"].ToString());
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string testConnect = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=DESKTOP-32LIGLH\SQLEXPRESS";

            OleDbConnection connection = new OleDbConnection(testConnect);
            connection.Open();
            OleDbTransaction OleTran = connection.BeginTransaction();
            OleDbCommand command = connection.CreateCommand();
            command.Transaction = OleTran;
            try
            {
                command.CommandText =
              "INSERT INTO Products (ProductName) VALUES('Wrong size')";
                command.ExecuteNonQuery();
                command.CommandText =
               "INSERT INTO Products (ProductName) VALUES('Wrong color')";
                command.ExecuteNonQuery();

                OleTran.Commit();
                MessageBox.Show("Both records were written to database");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.Message,
                "SQL Error code ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                try
                {
                    OleTran.Rollback();
                }
                catch (Exception exRollback)
                {
                    MessageBox.Show(exRollback.Message);
                }

            }

            connection.Close();
        }

    }
}
