using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TxEditor
{
    public partial class SouboryIO : UserControl
    {
        public string FilePathOpen { get; private set; }
        public string FilePathSave { get; private set; }

        public string FileNameOpen { get; private set; }
        public string FileNameSave { get; private set; }


        public SouboryIO()
        {
            InitializeComponent();
            FilePathOpen= String.Empty;
            FilePathSave= String.Empty;
            FileNameOpen= String.Empty;
            FileNameSave= String.Empty;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|CSV files (*.csv)|*.csv";
            openFileDialog.Title = "Otevřít soubor";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                tbFileOpen.Text = filePath;
                FilePathOpen = filePath;
                FileNameOpen = System.IO.Path.GetFileName(filePath);

            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|CSV files (*.csv)|*.csv";
            saveFileDialog.Title = "Uložit soubor";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                tbFileSave.Text = filePath;
                FilePathSave = filePath;
                FileNameSave = System.IO.Path.GetFileName(filePath);
            }
        }

      
        
    }
}
