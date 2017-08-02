using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik
{
    public partial class Znajdowanie : Form
    {
        Notatnik notatnik = new Notatnik();
        public int i = 0;

        public Znajdowanie(Notatnik _notatnik)
        {
            InitializeComponent();
            notatnik = _notatnik;
        }

        private void btnZnajdz_Click(object sender, EventArgs e)
        {
            string slowo = txtBox.Text;
            if (notatnik.Znajdz(slowo, i))
            {
                i = 0;
                notatnik.Znajdz(slowo, i);
                i++;
            }
            else
                i++;
            notatnik.Activate();

        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
