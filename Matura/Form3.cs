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
    public partial class Stručni : Form
    {
        public Stručni()
        {
            InitializeComponent();
        }

        private void Dalje2_Click(object sender, EventArgs e)
        {
            Ucenici.matrica[Ucenici.br, 5] = comboBox1.Text;
            if (comboBox1.Text== "Poljoprivreda, proizvodnja i prerada hrane")
            {
                this.Hide();
                Poljoprivreda__proizvodnja_i_prerada_hrane o = new Poljoprivreda__proizvodnja_i_prerada_hrane();
                o.Show();
                this.Close();
            }
            else if (comboBox1.Text == "Šumarstvo i obrada drveta")
            {
                this.Hide();
                Šumarstvo_i_obrada_drveta o = new Šumarstvo_i_obrada_drveta();
                o.Show();
                this.Close();
            }
            else if (comboBox1.Text == "Geologija, rudarstvo i metalurgija")
            {
                this.Hide();
                Geologija__rudarstvo_i_metalurgija o = new Geologija__rudarstvo_i_metalurgija();
                o.Show();
                this.Close();
            }
            else if (comboBox1.Text == "Mašinstvo i obrada metala")
            {
                this.Hide();
                Mašinstvo_i_obrada_metala o = new Mašinstvo_i_obrada_metala();
                o.Show();
                this.Close();
            }
            else if (comboBox1.Text == "Elektrotehnika")
            {
                this.Hide();
                Elektrotehnika o = new Elektrotehnika();
                o.Show();
                this.Close();
            }
            else if (comboBox1.Text == "Hemija, nemetali i grafičarstvo")
            {
                this.Hide();
                Hemija__nemetali_i_grafičarstvo o = new Hemija__nemetali_i_grafičarstvo();
                o.Show();
                this.Close();
            }
            else if (comboBox1.Text == "Tekstilstvo i kožarstvo")
            {
                this.Hide();
                Tekstilstvo_i_kozarstvo o = new Tekstilstvo_i_kozarstvo();
                o.Show();
                this.Close();
            }
            else if (comboBox1.Text == "Geodezija i građevinarstvo")
            {
                this.Hide();
                Geodezija_i_građevinarstvo o = new Geodezija_i_građevinarstvo();
                o.Show();
                this.Close();
            }
            else if (comboBox1.Text == "Saobraćaj")
            {
                this.Hide();
                Saobraćaj o = new Saobraćaj();
                o.Show();
                this.Close();
            }
            else if (comboBox1.Text == "Trgovina, ugostiteljstvo i turizam")
            {
                this.Hide();
                Trgovina_ugostiteljstvo_i_turizam o = new Trgovina_ugostiteljstvo_i_turizam();
                o.Show();
                this.Close();
            }
            else if (comboBox1.Text == "Ekonomija, pravo i administracija")
            {
                this.Hide();
                Ekonomija_pravo_i_administracija o = new Ekonomija_pravo_i_administracija();
                o.Show();
                this.Close();
            }
            else if (comboBox1.Text == "Zdravstvo i socijalna zaštita")
            {
                this.Hide();
                Zdravstvo_i_socijalna_zaštita o = new Zdravstvo_i_socijalna_zaštita();
                o.Show();
                this.Close();
            }
            else if (comboBox1.Text == "Lične usluge")
            {
                this.Hide();
                Lične_usluge o = new Lične_usluge();
                o.Show();
                this.Close();
            }
        }
        /*Poljoprivreda, proizvodnja i prerada hrane
Šumarstvo i obrada drveta
Geologija, rudarstvo i metalurgija
Mašinstvo i obrada metala
Elektrotehnika
Hemija, nemetali i grafičarstvo
Tekstilstvo i kožarstvo
Geodezija i građevinarstvo
Saobraćaj
Trgovina, ugostiteljstvo i turizam
Ekonomija, pravo i administracija
Zdravstvo i socijalna zaštita
Lične usluge*/
    }
}
