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
        public Form1()
        {
            InitializeComponent();
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
            cbNadrze.Items.Clear();
            foreach (Nadrz n in spravaNadrzi.ZobrazNadrze())
            {
                cbNadrze.Items.Add(n.NazevNadrze);
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
    }
}
