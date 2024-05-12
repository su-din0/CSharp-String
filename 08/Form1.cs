using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string m = textBox1.Text;

            string[] slova = m.Split(' ');
            MessageBox.Show($"Počet slov je {slova.Length}");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string m = textBox1.Text;
            char[] chars = { ' ' };
            string[] slova = m.Split(chars, StringSplitOptions.RemoveEmptyEntries);
            MessageBox.Show($"Počet slov je {slova.Length}");
        }
    }
}
