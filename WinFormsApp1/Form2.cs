using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            dateTimePicker2.CustomFormat = "dd.MM.yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;

            dateTimePicker3.CustomFormat = "dd.MM.yyyy";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<string> list_tabPage1 = new List<string>() { $"{Form1.countPatients}", "0" };

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is TextBox || control is DateTimePicker)
                    list_tabPage1.Add(control.Text.ToString().Length == 0 ? "" : control.Text.ToString());
            }
            Form1.listData_tabPage1.Add(list_tabPage1);

            List<string> list_tabPage2 = new List<string>() { $"{Form1.countPatients}", "0" };

            foreach (Control control in flowLayoutPanel2.Controls)
            {
                if (control is TextBox || control is DateTimePicker)
                    list_tabPage2.Add(control.Text.ToString().Length == 0 ? "" : control.Text.ToString());
            }
            Form1.listData_tabPage2.Add(list_tabPage2);

            ++Form1.countPatients;

            ClearFields();
        }

        private void ClearFields()
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is TextBox || control is DateTimePicker)
                    control.Text = string.Empty;
            }

            foreach (Control control in flowLayoutPanel2.Controls)
            {
                if (control is TextBox || control is DateTimePicker)
                    control.Text = string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
