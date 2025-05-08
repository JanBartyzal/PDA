using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TxEditor;
using System.Windows.Forms;

namespace Kopiruj
{
    partial class SoboryIO2 : SouboryIO
    {
        public bool PridatCopyPostfix { get; set; } = false;
        private CheckBox checkBox1;

        

        public SoboryIO2()
        {

            InitializeComponent();


        }

        private void InitializeComponent()
        {

            checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox1.Location = new System.Drawing.Point(4, 75);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 17);
            this.checkBox1.Text = "Přidat postfix \"_copy\"";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.Visible = true;
            this.Controls.Add(checkBox1);
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PridatCopyPostfix = true;
                
            }
            else
            {
                PridatCopyPostfix = false;
            }
        }
    }
        
    
    
}
