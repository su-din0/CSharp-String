using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = textBox1.Lines;

            for (int i = 0; i < lines.Length; i++)
            {
                string radek = lines[i];
                radek = radek.Trim(' ');
                char prvniZnak = char.ToUpper(radek[0]);

                //Nadbytečné mezery
                while (radek.Contains("  "))
                {
                    radek = radek.Replace("  ", " ");
                }

                //Tečky
                radek = radek.TrimEnd('.');
                radek += ".";


                string newLine = prvniZnak + radek.Substring(1);
                lines[i] = newLine;
            }

            textBox1.Lines = lines;
        }
    }
}
