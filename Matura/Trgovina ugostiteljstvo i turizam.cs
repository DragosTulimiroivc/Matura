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
    public partial class Trgovina_ugostiteljstvo_i_turizam : Form
    {
        public Trgovina_ugostiteljstvo_i_turizam()
        {
            InitializeComponent();
        }

        private void Dalje_Click(object sender, EventArgs e)
        {
            Ucenici.matrica[Ucenici.br, 6] = comboBox1.Text;
            Ucenici.br++;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
