using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
        Je dán řetězec slov, slova jsou oddělena jednou nebo více mezerami.
        Do komponenty ListBox vypište všechna slova, která obsahují nějakou cifru.
        */

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            char[] chars = { ' ' };
            string[] slova = s.Split(chars, StringSplitOptions.RemoveEmptyEntries);

            listBox1.Items.Clear();

            //Procházíme slova
            foreach (string slovo in slova)
            {
                bool obsahuje = false;

                //Procházíme znaky
                foreach (char znak in slovo)
                {
                    
                    //Pokud je cifra, přepíše se logická hodnota a cyklus se přeruší
                    if(char.IsDigit(znak))
                    {
                        obsahuje = true;
                        break;
                    }
                }

                if (obsahuje) listBox1.Items.Add(slovo);
            }

        }
    }
}
