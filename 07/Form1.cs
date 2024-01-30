using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
        Je dán řetězec slov, slova jsou oddělena jednou nebo více mezerami.
        Vypusťte z řetězce všechny nadbytečné mezery. 
        */
        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            while (s.Contains("  "))
            {
                s = s.Replace("  ", " ");
            }

            textBox1.Text = s;
        }
    }
}
