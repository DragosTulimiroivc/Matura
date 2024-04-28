using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Matura
{
    public partial class Prikaz : Form
    {
        public Prikaz()
        {
            InitializeComponent();
        }
        private void Prikazi(int n)
        {
            textBox1.Text = Ucenici.matrica[n, 0];
            textBox2.Text = Ucenici.matrica[n, 1];
            textBox3.Text = Ucenici.matrica[n, 2];
            textBox4.Text = Ucenici.matrica[n, 3];
            textBox5.Text = Ucenici.matrica[n, 4];
            textBox6.Text = Ucenici.matrica[n, 5];
            textBox7.Text = Ucenici.matrica[n, 6];
            textBox8.Text = Ucenici.matrica[n, 7];
        }
        private void Upisi(int n)
        {
            Ucenici.matrica[n, 0] = textBox1.Text;
            Ucenici.matrica[n, 1] = textBox2.Text;
            Ucenici.matrica[n, 2] = textBox3.Text;
            Ucenici.matrica[n, 3] = textBox4.Text;
            Ucenici.matrica[n, 4] = textBox5.Text;
            Ucenici.matrica[n, 5] = textBox6.Text;
            Ucenici.matrica[n, 6] = textBox7.Text;
            Ucenici.matrica[n, 7] = textBox8.Text;
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            using (StreamWriter file = new StreamWriter(@"Ucenici.csv"))
            {
                for (int i = 0; i < Ucenici.br; i++)
                {
                    string red = "";
                    for (int j = 0; j < 8; j++)
                    {
                        red += Ucenici.matrica[i, j] + ";";
                    }
                    file.WriteLine(red);
                }
            }
            this.Hide();
            Matura o = new Matura();
            o.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Upisi(Ucenici.tr);
            }
            Ucenici.tr = 0;
            Prikazi(Ucenici.tr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Ucenici.tr > 0)
            {
                if (textBox1.Text != "")
                {
                    Upisi(Ucenici.tr);
                }
                Ucenici.tr--;
                Prikazi(Ucenici.tr);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Upisi(Ucenici.tr);
            }
            if (Ucenici.tr < Ucenici.br - 1)
            {
                Ucenici.tr++;
                Prikazi(Ucenici.tr);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Upisi(Ucenici.tr);
            }
            Ucenici.tr = Ucenici.br - 1;
            Prikazi(Ucenici.tr);
        }
    }
}
