using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TxEditor
{
    public partial class Form1 : Form
    {
        private string filenameSave= string.Empty;
        private string filenameOpen= string.Empty;
        SouboryIO souboryIO = new SouboryIO();

        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "";
            toolStripStatusLabel2.Text = "";
            toolStripStatusLabel3.Text = "";

        }

        public bool SaveFile()
        {

            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filenameSave))
                {
                    file.WriteLine(tbEdit.Text);

                }
                MessageBox.Show("Soubor byl úspěšně uložen.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nastala chyba při ukládání: " + ex.Message);
                return false;
            }
            return true;

        }

        public void LoadFile()
        {
            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(filenameOpen))
                {
                    string text = file.ReadToEnd();
                    tbEdit.Text = text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nastala chyba při načítání: " + ex.Message);
            }
        }

        private void ShowSaveDialog()
        {
            MessageBox.Show("Vyberte soubor pro uložení");
            Soubor soubor = new Soubor();
            
            soubor.ShowDialog();
            filenameSave = soubor.FilePathSave;
            if (filenameSave != string.Empty)
            {
                SaveFile();
                toolStripStatusLabel2.Text = "Uložen: "+ System.IO.Path.GetFileName(filenameSave);
            }
            else
            {
                MessageBox.Show("Nebyl vybrán žádný soubor pro uložení.");
            }
        }
        private void ShowLoadDialog()
        {
            MessageBox.Show("Vyberte soubor pro otevření");
            Soubor soubor = new Soubor();
            soubor.ShowDialog();
            filenameOpen = soubor.FilePathOpen;
            if (filenameOpen != string.Empty)
            {
                LoadFile();
                toolStripStatusLabel3.Text = "Nahrán: " +System.IO.Path.GetFileName(filenameOpen);
            }
            else
            {
                MessageBox.Show("Nebyl vybrán žádný soubor pro otevření.");
            }
        }

        private void UpdateInfo()
        {
            int pocet = tbEdit.Text.Length;
            int radek = tbEdit.Lines.Length;
            int pocetSlov= tbEdit.Text.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
        
            toolStripStatusLabel1.Text = "Počet znaků: " + pocet.ToString() + "/ slov:" + pocetSlov.ToString() + "/řádek:" + radek.ToString() ;

        }


        private void novýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbEdit.Text.Length != 0)
            {
                DialogResult result = MessageBox.Show("Chcete uložit změny?", "Uložit změny", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (filenameSave != string.Empty)
                    {
                        SaveFile();
                    }
                    else
                    {
                        ShowSaveDialog();
                    }
                }

                else if (result == DialogResult.No)
                {
                    tbEdit.Clear();
                }
                
            }
            else
            {
                tbEdit.Clear();
            }
        }

        private void otevřítToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbEdit.Text.Length != 0)
            {
                DialogResult result = MessageBox.Show("Chcete uložit změny?", "Uložit změny", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (filenameOpen != string.Empty)
                    {
                        SaveFile();
                    }
                    else
                    {
                        ShowSaveDialog();
                    }

                }

            }
            tbEdit.Clear();
            if (filenameOpen != string.Empty)
            {
                LoadFile();
            }
            else
            {
                ShowLoadDialog();
            }
            

        }

        private void uložitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbEdit.Text.Length!=0)
            {
                if (souboryIO.FilePathSave == String.Empty)
                {
                    if (filenameSave != string.Empty)
                    {
                        SaveFile();
                    }
                    else
                    {
                        ShowSaveDialog();
                    }
                }
                else
                {
                    SaveFile();
                }
            }
            else
            {
                MessageBox.Show("Žádný text k uložení.");
            }
        }

        private void uložitJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbEdit.Text.Length != 0)
            {

                if (filenameSave != string.Empty)
                {
                    SaveFile();
                }
                else
                {
                    ShowSaveDialog();
                }

            }
            else
            {
                MessageBox.Show("Žádný text k uložení.");
            }

        }

        private void zavřítToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbEdit.Text.Length != 0)
            {
                if (MessageBox.Show("Chcete uložit změny?", "Uložit změny", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    if (souboryIO.FilePathSave == String.Empty)
                    {
                        if (filenameSave != string.Empty)
                        {
                            SaveFile();
                        }
                        else
                        {
                            ShowSaveDialog();
                        }
                    }
                    else
                    {
                        SaveFile();
                    }
                }


            }
        }

        private void oAplikaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Textový editor\nVerze 1.0\n", "O aplikaci", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void konecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbEdit.Text.Length != 0)
            {
                if (MessageBox.Show("Chcete uložit změny?", "Uložit změny", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    if (souboryIO.FilePathSave == String.Empty)
                    {
                        ShowSaveDialog();
                    }
                    else
                    {
                        SaveFile();
                    }
                }


            }

            if (MessageBox.Show("Opravdu chcete ukončit aplikaci?", "Ukončit aplikaci", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }

           

        }

        private void tbEdit_TextChanged(object sender, EventArgs e)
        {
            UpdateInfo();
        }
    }
}
