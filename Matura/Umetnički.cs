﻿using System;
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
    public partial class Umetnički : Form
    {
        public Umetnički()
        {
            InitializeComponent();
        }

        private void PredajU_Click(object sender, EventArgs e)
        {
            Ucenici.matrica[Ucenici.br, 5] = comboBox1.Text;
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
    }
}
