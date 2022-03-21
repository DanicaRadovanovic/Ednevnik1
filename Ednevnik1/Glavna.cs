using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ednevnik1
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void OsobeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Osoba frm_Osoba = new Osoba();
            frm_Osoba.Show();
        }

        private void Glavna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Glavna_Load(object sender, EventArgs e)
        {
            string user = Program.user_ime + " " + Program.user_prezime;
            label1.Text = user;
        }
    }
}
