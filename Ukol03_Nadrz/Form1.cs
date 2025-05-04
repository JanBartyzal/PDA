using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukol03_Nadrz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_nova_Click(object sender, EventArgs e)
        {
           _nadrz = new Nadrz(int.Parse(textBox1.Text));
            label_celkem.Text = _nadrz.ToString();

            label_celkem.Visible = true;
            button_pridat.Visible = true;
            button_odebrat.Visible = true;
            textBox2.Visible = true;
            label2.Visible = true;

            button_nova.Visible = false;
            textBox1.Visible = false;
            label1.Visible = false;


        }

        private void button_pridat_Click(object sender, EventArgs e)
        {
            try
            {
                _nadrz.Pridat(int.Parse(textBox2.Text));
                label_celkem.Text = _nadrz.ToString();
                MessageBox.Show("Přidáno " + textBox2.Text + " litrů vody.", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NadrzNelzeProvestOperaciException ex)
            {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Zadejte platné číslo.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Zadejte menší číslo.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nastala neočekávaná chyba: " + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_odebrat_Click(object sender, EventArgs e)
        {
            try
            {
                _nadrz.Odebrat(int.Parse(textBox2.Text));
                label_celkem.Text = _nadrz.ToString();
                MessageBox.Show("Odebráno " + textBox2.Text + " litrů vody.","Informace",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (NadrzNelzeProvestOperaciException ex)
            {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Zadejte platné číslo.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Zadejte menší číslo.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nastala neočekávaná chyba: " + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
