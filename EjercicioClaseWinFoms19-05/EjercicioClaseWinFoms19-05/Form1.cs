using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioClaseWinFoms19_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Libro> biblioteca = new List<Libro>();

            biblioteca.Add(new Libro("Artigue Arcangel", "Mi libro"));
            biblioteca.Add(new Libro("Artigue Manuel", "Libro de Manuel"));
            biblioteca.Add(new Libro("Artigue Horacio", "Finanzas"));

            foreach (Libro l in biblioteca)
            {
                listBox1.Items.Add(l.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Libro> biblioteca = new List<Libro>();

            biblioteca.Add(new Libro("Artigue Arcangel", "Mi libro"));
            biblioteca.Add(new Libro("Artigue Manuel", "Libro de Manuel"));
            biblioteca.Add(new Libro("Artigue Horacio", "Finanzas"));

            biblioteca.Sort();
            
            foreach (Libro l in biblioteca)
            {
                listBox1.Items.Add(l.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
