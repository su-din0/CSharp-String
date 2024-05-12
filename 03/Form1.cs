using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string Zasifruj(string text, int posun)
        {
            string zasifrovanyText = "";
            foreach (char znak in text)
            {
                if (char.IsLetter(znak))
                {
                    char zasifrovanyZnak = (char)(znak + posun);
                    if ((char.IsLower(znak) && zasifrovanyZnak > 'z') || (char.IsUpper(znak) && zasifrovanyZnak > 'Z'))
                    {
                        zasifrovanyZnak = (char)(zasifrovanyZnak - 26);
                    }
                    zasifrovanyText += zasifrovanyZnak;
                }
                else
                {
                    zasifrovanyText += znak;
                }
            }
            return zasifrovanyText;
        }

        static string OdSifruj(string text, int posun)
        {
            string odSifrovanyText = "";
            foreach (char znak in text)
            {
                if (char.IsLetter(znak))
                {
                    char odSifrovanyZnak = (char)(znak - posun);
                    if ((char.IsLower(znak) && odSifrovanyZnak < 'a') || (char.IsUpper(znak) && odSifrovanyZnak < 'A'))
                    {
                        odSifrovanyZnak = (char)(odSifrovanyZnak + 26);
                    }
                    odSifrovanyText += odSifrovanyZnak;
                }
                else
                {
                    odSifrovanyText += znak;
                }
            }
            return odSifrovanyText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string m = textBox1.Text;
            int posun = int.Parse(textBox2.Text);

            textBox3.Text = Zasifruj(m, posun);
            textBox4.Text = OdSifruj(textBox3.Text, posun);

        }
    }
}
