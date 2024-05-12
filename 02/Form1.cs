using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string samohlasky = "aeiyou";
            int pocetSamohlasek = 0;
            string souhlasky = "bflmpsvz";
            int pocetSouhlasek = 0;
            string nepisemne = " !";
            int pocetNepisemnych = 0;

            string s = textBox1.Text;
            foreach (char item in s)
            {
                char temp = char.ToLower(item);
                if (samohlasky.Contains(temp)) ++pocetSamohlasek;
                else if (souhlasky.Contains(temp)) ++pocetSouhlasek;
                else if (nepisemne.Contains(temp)) ++pocetNepisemnych;
            }

            MessageBox.Show($"Počet samohlásek: {pocetSamohlasek}\n" +
                $"Počet souhlásek: {pocetSouhlasek}\n" +
                $"Počet nepísmenných znaků: {pocetNepisemnych}");
        }
    }
}
