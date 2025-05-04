using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SazbyDane
{
    public partial class SazbyDane : Form
    {
        public SazbyDane()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbVstup_TextChanged(object sender, EventArgs e)
        {
            Spocti();
        }
        private void cbSazba_SelectedIndexChanged(object sender, EventArgs e)
        {
            Spocti();
        }


        private void Spocti()
        {
            double vstup = 0;
            int sazba = 0;
            double vysledek = 0;
            // Osetreni pro prvn9 vstup
            if (cbSazba.SelectedIndex == -1)
            {
                cbSazba.SelectedIndex = 0;
            }


            string sazbaText= cbSazba.Text;
            sazbaText = sazbaText.Substring(0, sazbaText.IndexOf("%"));
            int.TryParse(sazbaText, out sazba);
            double.TryParse(tbVstup.Text, out vstup);
            
            

            vysledek = vstup * sazba / 100;

            if (vstup == 0)
            {
                MessageBox.Show("Zadejte platný vstup.");
            }
            else if (vstup > 0)
            {
                tbDan.Text = (vstup * sazba / 100).ToString("F2");
                tbCelkem.Text = (vstup + (vstup * sazba / 100)).ToString("F2");
            }
            
            
        
        }

       
    }
}
