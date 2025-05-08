using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nadrz
{
    public partial class Form1 : Form
    {
        private SpravaNadrzi spravaNadrzi = new SpravaNadrzi();
        private SpravaNadrzi spravaNadrzi_debug = new SpravaNadrzi();
        public Form1()
        {
            InitializeComponent();

            spravaNadrzi_debug.PridatNadrz("Nadrz1", 100);
            spravaNadrzi_debug.PridatNadrz("Nadrz2", 200);
            spravaNadrzi_debug.PridatNadrz("Nadrz3", 300);

            LoadSeznam("seznam_nadrzi.txt");
            

            loadCbNadrze();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void buttonNovaNadrz_Click(object sender, EventArgs e)
        {
            try
            { 
            spravaNadrzi.PridatNadrz(tbNadrzNazev1.Text, Convert.ToInt32(tbNadrzObjem1.Text));
            MessageBox.Show("Nádrž byla úspěšně přidána.");
                groupBox1.Visible = false;
                tbNadrzNazev1.Text= "";
                tbNadrzObjem1.Text= "";
                loadCbNadrze();
            }
            catch (NadrzNelzeProvestOperaciException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Zadejte platný objem nádrže.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nastala chyba: " + ex.Message);
            }
            
        }
        private void loadCbNadrze()
        {
            SetriditData();
            cbNadrze.Items.Clear();
            lbNadrz.Items.Clear();
            foreach (Nadrz n in spravaNadrzi.ZobrazNadrze())
            {
                cbNadrze.Items.Add(n.NazevNadrze);
                lbNadrz.Items.Add(n.NazevNadrze + ":" + n.ToString());
            }
        }

        private void cbNadrze_SelectedIndexChanged(object sender, EventArgs e)
        {
            Nadrz nadrz = spravaNadrzi.NajdiNadrz(cbNadrze.SelectedItem.ToString());
            if (nadrz != null)
            {
                tbNadrzNazev2.Text = nadrz.NazevNadrze;
                tbNadrzObjem2.Text = nadrz.Objem.ToString();
                tbStavNadrze.Text = nadrz.StavNadrze.ToString();
                tbLitry.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nadrz nadrz = spravaNadrzi.NajdiNadrz(tbNadrzNazev2.Text);
            try
            {
                if (nadrz != null)
                {
                    nadrz.Pridat(Convert.ToInt32(tbLitry.Text));
                    tbStavNadrze.Text = nadrz.StavNadrze.ToString();
                    loadCbNadrze();
                }
                else
                {
                    MessageBox.Show("Nádrž nebyla nalezena.");
                }
            }
            catch (NelzeVlozitDoNadrzeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Zadejte platný objem k přidání.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nastala chyba: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nadrz nadrz = spravaNadrzi.NajdiNadrz(tbNadrzNazev2.Text);
            try
            {
                if (nadrz != null)
                {
                    nadrz.Odebrat(Convert.ToInt32(tbLitry.Text));
                    tbStavNadrze.Text = nadrz.StavNadrze.ToString();
                    loadCbNadrze();
                }
                else
                {
                    MessageBox.Show("Nádrž nebyla nalezena.");
                }
            }
            catch (NelzeOdebratZNadrzeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Zadejte platný objem k odebrání.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nastala chyba: " + ex.Message);
            }
        }

        private void lbNadrz_SelectedIndexChanged(object sender, EventArgs e)
        {
            Nadrz nadrz = spravaNadrzi.NajdiNadrz(lbNadrz.SelectedItem.ToString().Split(':')[0]);
            if (nadrz != null)
            {
                tbNadrzNazev2.Text = nadrz.NazevNadrze;
                tbNadrzObjem2.Text = nadrz.Objem.ToString();
                tbStavNadrze.Text = nadrz.StavNadrze.ToString();
                tbLitry.Text = "0";
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            loadCbNadrze();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            
            loadCbNadrze();
        }
        private void SetriditData()
        {
            if (radioButton1.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    spravaNadrzi.SeradVzestupID();
                }
                else if (checkBox3.Checked == true)
                {
                    spravaNadrzi.SeradVzestupStav();
                }
                else
                {
                    spravaNadrzi.SeradVzestupNadrze();
                }
            }

            if (radioButton2.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    spravaNadrzi.SeradSestupID();
                }
                else if (checkBox3.Checked == true)
                {
                    spravaNadrzi.SeradSestupStav();
                }
                else
                {
                    spravaNadrzi.SeradSestupNadrze();
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }


            loadCbNadrze();

            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
            }
            loadCbNadrze();

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
            loadCbNadrze();
        }

        private void buttonHledejID_Click(object sender, EventArgs e)
        {
            int ID = 0;
            int.TryParse(tbFindByID.Text, out ID);
            Nadrz nadrz = spravaNadrzi.NajdiNadrz(ID);
            if (nadrz != null)
            {
                tbNadrzNazev2.Text = nadrz.NazevNadrze;
                tbNadrzObjem2.Text = nadrz.Objem.ToString();
                tbStavNadrze.Text = nadrz.StavNadrze.ToString();
                tbLitry.Text = "0";
                tbVysledekHledani.Text = "Nádrž nalezena: " + nadrz.NazevNadrze + " - " + nadrz.ToString();
            }
            else
            {
                MessageBox.Show("Nádrž nebyla nalezena.");
            }


        }

        private void buttonHledenNazev_Click(object sender, EventArgs e)
        {
            Nadrz nadrz = spravaNadrzi.NajdiNadrz(tbFindByName.Text);
            if (nadrz != null)
            {
                tbNadrzNazev2.Text = nadrz.NazevNadrze;
                tbNadrzObjem2.Text = nadrz.Objem.ToString();
                tbStavNadrze.Text = nadrz.StavNadrze.ToString();
                tbLitry.Text = "0";
                tbVysledekHledani.Text = "Nádrž nalezena: " + nadrz.NazevNadrze + " - " + nadrz.ToString();
            }
            else
            {
                MessageBox.Show("Nádrž nebyla nalezena.");
            }
        }

        private void konecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oAplikaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikace pro správu nádrží.\nVerze 1.0\n");
        }

        private void uložSeznamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Uložit seznam nádrží";
            saveFileDialog.FileName = "seznam_nadrzi.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (Nadrz n in spravaNadrzi.ZobrazNadrze())
                        {
                            file.WriteLine(n.NazevNadrze + ";" + n.Objem + ";" + n.StavNadrze);
                        }
                    }
                    MessageBox.Show("Seznam nádrží byl úspěšně uložen.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nastala chyba při ukládání: " + ex.Message);
                }
            }
        }

        private void nahrajSeznamToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Načíst seznam nádrží";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    spravaNadrzi.Clear();
                    LoadSeznam(openFileDialog.FileName);
                    loadCbNadrze();
                    MessageBox.Show("Seznam nádrží byl úspěšně načten.");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nastala chyba při načítání: " + ex.Message);
                }
            }
        }

        private void nahrajDebugSeznamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spravaNadrzi.Clear();
            foreach (Nadrz n in spravaNadrzi_debug.ZobrazNadrze())
            {
                spravaNadrzi.PridatNadrz(n.NazevNadrze, n.Objem);
            }
            loadCbNadrze();
            MessageBox.Show("Seznam nádrží byl úspěšně načten.");
        }

        private void LoadSeznam(string FileName)
        {
            try
            {
                spravaNadrzi.Clear();
                using (System.IO.StreamReader file = new System.IO.StreamReader(FileName))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] parts = line.Split(';');
                        if (parts.Length == 3)
                        {
                            string nazev = parts[0];
                            int objem = Convert.ToInt32(parts[1]);
                            int stav = Convert.ToInt32(parts[2]);
                            spravaNadrzi.PridatNadrz(nazev, objem, stav);

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nastala chyba při načítání: " + ex.Message);
            }

        }

    }
}
