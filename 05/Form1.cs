using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string abecedniZnaky = "abcdefghijklmnopqrstuvwxyz";
            string[] morseovyZnaky = {
                ".-", "-...", "-.-.", "-..",
                ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--",
                "-.", "---", ".--.", "--.-", ".-.",
                "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."
            };
            string m = textBox1.Text;

            char[] oddelovacSlov = { '/' };
            string[] slova = m.Split(oddelovacSlov, StringSplitOptions.RemoveEmptyEntries);

            foreach (string slovo in slova)
            {
                char[] oddelovacZnaku = { ' ' };
                string[] znaky = slovo.Split(oddelovacZnaku, StringSplitOptions.RemoveEmptyEntries);
                foreach (string znak in znaky)
                {
                    int index = abecedniZnaky.IndexOf(znak);
                    if (index != -1)
                    {
                        textBox2.Text += morseovyZnaky[index] + " ";
                    }
                    else
                    {
                        textBox2.Text += "??? ";
                    }
                }
                textBox2.Text += "/ ";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string abecedniZnaky = "abcdefghijklmnopqrstuvwxyz";
            string[] morseovyZnaky = {
                ".-", "-...", "-.-.", "-..",
                ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--",
                "-.", "---", ".--.", "--.-", ".-.",
                "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."
            };
            string m = textBox1.Text;
            char[] oddelovacSlov = { '/' };
            string[] slova = m.Split(oddelovacSlov, StringSplitOptions.RemoveEmptyEntries);

            foreach (string slovo in slova)
            {
                char[] oddelovacZnaku = { ' ' };
                string[] znaky = slovo.Split(oddelovacZnaku, StringSplitOptions.RemoveEmptyEntries);
                foreach (string znak in znaky)
                {
                    int index = Array.IndexOf(morseovyZnaky, znak);
                    if (index != -1)
                    {
                        textBox2.Text += abecedniZnaky[index] + " ";
                    }
                    else
                    {
                        textBox2.Text += "???";
                    }
                }
                textBox2.Text += "/";
            }
        }
    }
}
