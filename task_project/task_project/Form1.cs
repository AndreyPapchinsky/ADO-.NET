using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = personDataSet1.Person;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlDataAdapter1.Update(personDataSet1);
                MessageBox.Show("Save");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                "SQL Error code ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                sqlDataAdapter1.Fill(personDataSet1.Person);
                BindingSource productsBindingSource = new BindingSource(personDataSet1, "Person");
                dataGridView1.DataSource = productsBindingSource;
        }
    }
}
