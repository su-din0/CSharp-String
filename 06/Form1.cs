using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06
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
            int i = 0;
            while (i < m.Length)
            {
                char znak = m[i];
                if (char.IsUpper(znak)) m = m.Remove(i, 1);
                else ++i;
            }

            textBox2.Text = m;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string m = textBox1.Text;

            m = m.Replace("*", "");

            textBox2.Text = m;
        }
    }
}
