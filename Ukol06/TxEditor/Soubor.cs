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
    public partial class Soubor : Form
    {   
        public string FilePathOpen { get; private set; }
        public string FilePathSave { get; private set; }
        public Soubor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilePathOpen = souboryIO1.FilePathOpen;
            FilePathSave = souboryIO1.FilePathSave;
            this.Close();
        }
    }
}
