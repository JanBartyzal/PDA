using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barvy
{
    public partial class Form1 : Form
    {
        // Deklarace seznamu barev
        private List<Barva> barvy = new List<Barva>();


        public Form1()
        {
            InitializeComponent();
            // Inicializace formuláře
            initForm();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           if (radioButton1.Checked)
            {
              radioButton2.Checked = false;
            }
           else if (radioButton2.Checked)
            {
                radioButton1.Checked = false;
            }
        }


        private void initForm()
        {
            // Inicializace seznamu barev
            barvy.Add(new Barva("Cervena", 255, 0, 0));
            barvy.Add(new Barva("Zelena", 0, 255, 0));
            barvy.Add(new Barva("Modra", 0, 0, 255));
            barvy.Add(new Barva("Cerna", 0, 0, 0));
            barvy.Add(new Barva("Bila", 255, 255, 255));
            barvy.Add(new Barva("Zluta", 255, 255, 0));

            // Naplnění listBoxu barev
            foreach (Barva barva in barvy)
            {
                listBox1.Items.Add(barva);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                //seřadit vzestupne dle intezity
                barvy.Sort(Barva.Porovnat);
            }
            else if (radioButton2.Checked)
            {
                //seřadit sestupne dle intezity
                barvy.Sort((b1, b2) => Barva.Porovnat(b2, b1));
            }

            // Obnovit listBox
            listBox1.Items.Clear();
            foreach (Barva barva in barvy)
            {
                listBox1.Items.Add(barva);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton1.Checked = false;
            }
            else if (radioButton1.Checked)
            {
                radioButton2.Checked = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Barva vybranaBarva = (Barva)listBox1.SelectedItem;
            if (vybranaBarva != null)
            {
                this.numR.Value = vybranaBarva.R;
                this.numB.Value = vybranaBarva.B;
                this.numG.Value = vybranaBarva.G;
                this.tbNazev.Text = vybranaBarva.Nazev;
                this.labelIntenzita.Text = "Intenzita: " + vybranaBarva.intenzita.ToString();
            



            }
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Barva nova= new Barva(tbNazev.Text, (int)numR.Value, (int)numG.Value, (int)numB.Value);
            barvy.Add(nova);
            listBox1.Items.Add(nova);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                // Odstranění vybrané barvy ze seznamu
                barvy.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Vyberte barvu, kterou chcete odstranit.");
            }
        }

        private void dispIntenzita()
        {
            Barva nova = new Barva(tbNazev.Text, (int)numR.Value, (int)numG.Value, (int)numB.Value);
            labelIntenzita.Text = "Intenzita: " + nova.intenzita.ToString();
        }

        private void numR_ValueChanged(object sender, EventArgs e)
        {
            dispIntenzita();
        }

        private void numG_ValueChanged(object sender, EventArgs e)
        {
            dispIntenzita();
        }

        private void numB_ValueChanged(object sender, EventArgs e)
        {
            dispIntenzita();
        }
    }
}
