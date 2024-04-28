using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matura
{
    public partial class Matura : Form
    {
        public Matura()
        {
            InitializeComponent();
        }

        private void Dalje1_Click(object sender, EventArgs e)
        {
            Ucenici.matrica[Ucenici.br, 0] = textBox3.Text;
            Ucenici.matrica[Ucenici.br, 1] = textBox1.Text;
            Ucenici.matrica[Ucenici.br, 2] = textBox2.Text;
            Ucenici.matrica[Ucenici.br, 3] = textBox4.Text;
            Ucenici.matrica[Ucenici.br, 4] = comboBox1.Text;
            if (comboBox1.Text == "Opšti")
            {
                this.Hide();
                Opšti o = new Opšti();
                o.Show();
            }
            else if (comboBox1.Text == "Stručni")
            {
                this.Hide();
                Stručni o = new Stručni();
                o.Show();
            }
            else if (comboBox1.Text == "Umetnički")
            {
                this.Hide();
                Umetnički o = new Umetnički();
                o.Show();
            }
        }

        private void prikazi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prikaz o = new Prikaz();
            o.Show();
        }
    }
    class Ucenici
    {
        public static string[,] matrica=new string[1000,10];
        public static int br=0;
        public static int tr = 0;
        public Ucenici()
        {
            matrica = new string[1000, 10];
            br = 0;
        }
    }
}
