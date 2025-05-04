using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukol2
{
    public partial class UserControl_GeneratorCitace : UserControl
    {
        public UserControl_GeneratorCitace()
        {
            InitializeComponent();
        }

        private void CreateCitace()
        {
            string citace = "";
            if (textBox_AutorPrijmeni.Text != "")
            {
                citace += textBox_AutorPrijmeni.Text + ",";
            }
            if (textBox_AutorJmeno.Text != "")
            {
                citace += textBox_AutorJmeno.Text + ", ";
            }
            if (textBox_Nazev.Text != "")
            {
                citace += textBox_Nazev.Text + ", ";
            }
            if (textBox_Rok.Text != "")
            {
                citace += textBox_Rok.Text + ", ";
            }
            if (checkBox1.Checked)
            {
                if (textBox_URL.Text != "")
                {
                    citace += "dostupné online na URL [" + textBox_URL.Text + "], ";
                }
            }
            else
            {
                if (textBox_ISBN.Text != "")
                {
                    citace += "ISBN:"+ textBox_ISBN.Text + ", ";
                }
            }
            
            if (citace != "")
            {
                textBox_Citace.Text= citace;
            }
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CreateCitace();
        }

        private void textBox_AutorJmeno_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void textBox_AutorJmeno_TextChanged(object sender, EventArgs e)
        {
            CreateCitace();
        }

        private void textBox_Nazev_TextChanged(object sender, EventArgs e)
        {
            CreateCitace();
        }

        private void textBox_Rok_TextChanged(object sender, EventArgs e)
        {
            CreateCitace();
        }

        private void textBox_ISBN_TextChanged(object sender, EventArgs e)
        {
            CreateCitace();
        }

        private void textBox_URL_TextChanged(object sender, EventArgs e)
        {
            CreateCitace();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CreateCitace();
        }
    }
}
