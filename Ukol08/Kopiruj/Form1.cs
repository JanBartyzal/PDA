using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Kopiruj
{
    public partial class Form1 : Form
    {
        SoboryIO2 sbr1 = new SoboryIO2();
        Dictionary<string, string> zamena = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
            this.Controls.Add(sbr1);
            
           

        }

        private void cbMale_CheckedChanged(object sender, EventArgs e)
        {
            cbVelke.Checked = false;
            cbInvariant.Checked = false;

        }

        private void UpravNahled()
        {
            // takhle by to bylo normmalne v textovem souboru... :)
            //pri ukladani je ulozeni pres binarni writer a kazdy znak se ulozi jako byte po samostatne konverzi

            string text=textBoxSrc.Text;
            if (cbMale.Checked)
            {
                text = text.ToLower();
            }
            if (cbVelke.Checked)
            {
                text = text.ToUpper();
            }
            if (cbInvariant.Checked)
            {
                text = text.ToUpperInvariant();
            }
            if (cbTrim.Checked)
            {
                text = text.Trim();
            }

            textBoxDest.Text = text;
        }

        private void buttonNahled_Click(object sender, EventArgs e)
        {
            if (sbr1.FileNameOpen != String.Empty)
            {
                string text = System.IO.File.ReadAllText(sbr1.FilePathOpen);
                textBoxSrc.Text = text;
                UpravNahled();
            }
        }

        private void cbVelke_CheckedChanged(object sender, EventArgs e)
        {
            cbMale.Checked = false;
            cbInvariant.Checked = false;
            UpravNahled();
        }

        private void cbInvariant_CheckedChanged(object sender, EventArgs e)
        {
            cbMale.Checked = false;
            cbVelke.Checked = false;
            UpravNahled();
        }

        private void cbTrim_CheckedChanged(object sender, EventArgs e)
        {
            UpravNahled();
        }

        private void buttonUloz_Click(object sender, EventArgs e)
        {
            string FilePathSave = "";

            if (sbr1.PridatCopyPostfix)
            {
                string fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(sbr1.FileNameOpen);
                string fileExtension = System.IO.Path.GetExtension(sbr1.FileNameOpen);
                string newFileName = $"{fileNameWithoutExtension}_copy{fileExtension}";

                FilePathSave = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(sbr1.FilePathOpen), newFileName);
            }
            else
            {
                if (sbr1.FileNameSave != String.Empty)
                {
                    FilePathSave = sbr1.FilePathSave;
                }
                else
                {                     MessageBox.Show("Nejprve vyberte soubor pro uložení.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                   return;
                }

            }

            if (sbr1.FileNameOpen != String.Empty)
            {
                BinaryWriter bw = new BinaryWriter(new FileStream(FilePathSave, FileMode.Create, FileAccess.Write));


                using (StreamReader reader = new StreamReader(sbr1.FilePathOpen))
                {
                    int whiteSpaceNum=0;
                    while (!reader.EndOfStream)
                    {
                        char znaky = (char)reader.Read();

                        if (char.IsLetter(znaky))
                        {
                            if (cbMale.Checked)
                            {
                                znaky = char.ToLower(znaky);
                            }
                            else if (cbVelke.Checked)
                            {
                                znaky = char.ToUpper(znaky);
                            }
                            else if (cbInvariant.Checked)
                            {
                                znaky = char.ToUpperInvariant(znaky);
                            }
                        }
                        if (cbTrim.Checked)
                        {
                            if (char.IsWhiteSpace(znaky))
                            {
                                whiteSpaceNum++;
                                
                            }
                            else
                            {
                                whiteSpaceNum = 0;

                            }
                        }

                        if (whiteSpaceNum < 2)
                        {
                            bw.Write(znaky);     
                        }
                    }
                }

                bw.Close();

            
                MessageBox.Show("Soubor byl úspěšně uložen.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nejprve vyberte soubor pro otevření a uložení.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxSrc_TextChanged(object sender, EventArgs e)
        {
            UpravNahled();
        }
    }
}
