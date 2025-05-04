using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukol2
{
    public partial class UserControl_Password1 : UserControl
    {
        public UserControl_Password1()
        {
            InitializeComponent();
        }

        private void checkBox1_Password1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1_Password1.Checked)
            {
                textBox_Password1.PasswordChar = '\0';
            }
            else
            {
                textBox_Password1.PasswordChar = '*';
            }
        }
    }
}
