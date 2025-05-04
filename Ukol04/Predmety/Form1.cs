using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predmety
{
    public partial class Form1 : Form
    {
        Vyuka vyuka;
        public Form1()
        {
            InitializeComponent();
            vyuka = new Vyuka();
            vyuka.PridatPredmet(new Predmet("Matematika", "MAT"));
            vyuka.PridatPredmet(new Predmet("Fyzika", "FYZ"));
            vyuka.PridatPredmet(new Predmet("Chemie", "CHE"));
            vyuka.PridatPredmet(new Predmet("Biologie", "BIO"));
            vyuka.PridatPredmet(new Predmet("Informatika", "INF"));
            vyuka.PridatPredmet(new Predmet("Dějepis", "DEJ"));
            vyuka.PridatPredmet(new Predmet("Zeměpis", "ZEM"));

            loadPredmety();





        }

        private void loadPredmety()
        {
            
            foreach (Predmet predmet in vyuka.predmety)
            {
                addCheckBox(predmet);
                addRadioButton(predmet);
            }
        }

        private void addCheckBox(Predmet predmet)
        {
           
            CheckBox checkBox = new CheckBox();
            checkBox.Text = predmet.Zkratka + " - " + predmet.Nazev;
            checkBox.Tag = predmet;
            checkBox.CheckedChanged += new EventHandler(checkBox_CheckedChanged);
            checkBox.AutoSize = true;
            checkBox.Location = new Point(10, 20 + (vyuka.predmety.IndexOf(predmet) * 20));
            this.groupBox1.Controls.Add(checkBox);

            if (vyuka.zvolene.Contains(predmet))
            {
                checkBox.Checked = true;
            }
            else
            {
                checkBox.Checked = false;
            }
        }

        private void addRadioButton(Predmet predmet)
        {
            RadioButton radioButton = new RadioButton();
            radioButton.Text = predmet.Zkratka + " - " + predmet.Nazev;
            radioButton.Tag = predmet;
            radioButton.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            radioButton.AutoSize = true;
            radioButton.Location = new Point(10, 20 + (vyuka.predmety.IndexOf(predmet) * 20));
            this.groupBox2.Controls.Add(radioButton);
        }
         
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            Predmet predmet = (Predmet)checkBox.Tag;

            if (checkBox.Checked)
            {
                vyuka.ZvolitPredmet(predmet);
                
            }
            else
            {
                vyuka.OdebratZvolenyPredmet(predmet);
            }

            tbZvolene.Text = "";
            foreach (Predmet p in vyuka.zvolene)
            {
                tbZvolene.Text += p.Nazev + "; ";
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            Predmet predmet = (Predmet)radioButton.Tag;

           tbInfo.Text = predmet.Nazev + " - " + predmet.Zkratka;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool pridano = vyuka.PridatPredmet(new Predmet(textBox1.Text, textBox2.Text));
            if (pridano)
            {
                MessageBox.Show("Předmět přidán.");
                loadPredmety();
            }
            else
            {
                MessageBox.Show("Předmět již existuje.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.Title = "Uložit soubor";
            saveFileDialog.FileName = "predmety.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog.FileName))
                {
                    foreach (Predmet predmet in vyuka.predmety)
                    {
                        file.WriteLine(predmet.Zkratka + ";" + predmet.Nazev);
                    }
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.Title = "Uložit soubor";
            saveFileDialog.FileName = "predmety.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog.FileName))
                {
                    foreach (Predmet predmet in vyuka.zvolene)
                    {
                        file.WriteLine(predmet.Zkratka + ";" + predmet.Nazev);
                    }
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";
            openFileDialog.Title = "Načíst soubor";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog.FileName))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] parts = line.Split(';');
                        if (parts.Length == 2)
                        {
                            Predmet predmet = new Predmet(parts[1], parts[0]);
                            vyuka.PridatPredmet(predmet);
                            addCheckBox(predmet);
                        }
                    }
                }
            }
        }
    }
}
