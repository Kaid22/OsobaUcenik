using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osobaUcenik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Ucenik u = new Ucenik();
        Osoba o = new Osoba();
        private void button1_Click(object sender, EventArgs e)
        {
            u.Ime = textBox1.Text;
            u.Prezime = textBox2.Text;
            u.Roditelj = textBox3.Text;
            u.Odeljenje = textBox4.Text;
            u.Smer = textBox5.Text;
            u.Profil = textBox6.Text;
            richTextBox1.Text = u.Podaci();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            o.Ime = textBox1.Text;
            o.Prezime = textBox2.Text;
            o.Roditelj = textBox3.Text;
            richTextBox1.Text = o.Podaci();
        }
    }
}
