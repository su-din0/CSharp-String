using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
        V TextBox je dán řetězec slov.
        Slova jsou oddělena jednou mezerou.
        Vypište nejdelší slovo.
        */

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            char[] chars = { ' ' };
            string[] slova = text.Split(chars, StringSplitOptions.RemoveEmptyEntries);

            string nejdelsiSlovo = "";
            foreach (string slovo in slova)
            {
                if (slovo.Length > nejdelsiSlovo.Length) nejdelsiSlovo = slovo;
            }
        }
    }
}
