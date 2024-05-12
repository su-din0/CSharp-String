using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            int k = -1;

            foreach (char item in s)
            {
                if (char.IsDigit(item))
                {
                    k = int.Parse(item.ToString());
                    break;
                }
            }

            if (k == -1)
            {
                textBox1.Text = s;
                return;
            }
            else if(k >= s.Length)
            {
                textBox1.Text = "";
                return;
            }
            else
            {
                s = s.Remove(s.Length - k, k);
                textBox1.Text = s;
            }
        }
    }
}
