using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = textBox1.Text;
            string message;
            if (result == " ")
            {
                message = "Введіть правильне значення";
            }

            else if (int.TryParse(result, out int c))
            {
                message = "Ви ввели число " + c;
            }
            else
            {
                message = "Введіть правильне значення";
            }
            string caption = "Solution";
            MessageBox.Show(message, caption);
        }
    }
}