using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mapa
{
    internal class Lokace
    {
        public string Nazev;
        public int X;
        public int Y;
        
    }

    public partial class Form1 : Form
    {
        private List<Lokace> lokace = new List<Lokace>();

        public Form1()
        {
            InitializeComponent();
            InitMapa();
        }

        private void InitMapa()
        {
         
            lokace.Add(new Lokace() { Nazev = "Praha", X = 275, Y = 210 });
            lokace.Add(new Lokace() { Nazev = "Brno", X = 540, Y = 380 });
            lokace.Add(new Lokace() { Nazev = "Olomouc", X = 660, Y = 310 });
            lokace.Add(new Lokace() { Nazev = "Plzeň", X = 180, Y = 285 });
            lokace.Add(new Lokace() { Nazev = "Hradec Králové", X = 435, Y = 210 });
            lokace.Add(new Lokace() { Nazev = "Zlín", X = 665, Y = 350 });
            lokace.Add(new Lokace() { Nazev = "Ústí nad Labem", X = 225, Y = 140 });
            lokace.Add(new Lokace() { Nazev = "Liberec", X = 330, Y = 135 });
            lokace.Add(new Lokace() { Nazev = "Karlovy Vary", X = 145, Y = 205 });





            foreach (var l in lokace)
            {
                listBox1.Items.Add(l.Nazev);
            }


            foreach (var l in lokace)
            {
                Rectangle area = new Rectangle(l.X, l.Y, 20, 20);
                Graphics g = pictureBox1.CreateGraphics();
                g.FillRectangle(Brushes.Red, area);
                g.DrawString(l.Nazev, new Font("Arial", 10), Brushes.Black, l.X, l.Y);
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Vyberte lokaci");
                return;
            }
            
            string loc=listBox1.SelectedItem.ToString();
            bool foundIt = false;
            int CursorX = 0;
            int CursorY = 0;
            int diffX= 0;
            int diffY= 0;

            foreach (var l in lokace)
            {
                if (l.Nazev == loc)
                {
                    Rectangle area = new Rectangle(l.X, l.Y, 20, 20);
                    CursorX = Cursor.Position.X - pictureBox1.Location.X - this.Location.X - 9;
                    CursorY = Cursor.Position.Y - pictureBox1.Location.Y - this.Location.Y - 31;
                    diffX = CursorX - l.X;
                    diffY = CursorY - l.Y;
                    if (diffX<20 && diffY<20)
                    {
                        Graphics g = pictureBox1.CreateGraphics();
                        g.FillRectangle(Brushes.Red, area);
                        g.DrawString(l.Nazev, new Font("Arial", 10), Brushes.Black, l.X, l.Y);
                        //pictureBox1.Refresh();
                        foundIt = true;
                    }
                }
            }
            
            if (!foundIt)
            {
                MessageBox.Show("Není to "+loc+", vzdalenost X:" + (diffX).ToString() + ", Y: "+ (diffY).ToString());

                //ActiveForm.Text =loc + ", X:" + (CursorX).ToString() + ", Y: " + (CursorY).ToString();
            }


        }
    }
}
