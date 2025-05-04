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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string text = "";
            if(checkBox1.Checked)
            {
                text = "Password v1 \r\n";
            }
            if (checkBox2.Checked)
            {
                text += "Password v2 \r\n";
            }
            if (checkBox3.Checked)
            {
                text += "Password v3 \r\n";
            }
            if (checkBox4.Checked)
            {
                text += "Citace \r\n";
            }

            if (text == "")
            {
                text = "Nic nebylo vybráno";
            }

            MessageBox.Show(text, "Vybrane checkboxy");

        }

        private void hideUserControls()
        {
            userControl_Password11.Visible = false;
            userControl_Password21.Visible = false;
            userControl_Password31.Visible = false;
            userControl_GeneratorCitace1.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            hideUserControls();
            if (radioButton1.Checked)
            {
                userControl_Password11.Visible = true;

            }
        }

       
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            hideUserControls();

            if (radioButton2.Checked)
            {
                userControl_Password21.Visible = true;
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            hideUserControls();

            if (radioButton3.Checked)
            {
                userControl_Password31.Visible = true;

            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                userControl_GeneratorCitace1.Visible = true;

            }
        }
    }
}
