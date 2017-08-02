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
    public partial class ZmianaCzcionki : Form
    {
        public string styl, czcionka;
        public float rozmiar = 10;
        Notatnik notatnik = new Notatnik();

        public ZmianaCzcionki(Notatnik _notatnik)
        {
            InitializeComponent();
            notatnik = _notatnik;
        }


        public void Przyklad()
        {
            string styl = Convert.ToString(boxStyl.SelectedItem);
            int rozmiar = Convert.ToInt32(boxRozmiar.SelectedItem);
            string czcionka = Convert.ToString(boxCzcionka.SelectedItem);
            

            if (rozmiar == 0)
            {
                rozmiar = 10;
            }

            switch (styl)
            {
                case "zwykła":
                    lblPrzyklad.Font = new Font(czcionka, rozmiar, FontStyle.Regular);
                    break;
                case "pogrubiona":
                    lblPrzyklad.Font = new Font(czcionka, rozmiar, FontStyle.Bold);
                    break;
                case "pochyła":
                    lblPrzyklad.Font = new Font(czcionka, rozmiar, FontStyle.Italic);
                    break;
            }

            if (boxPodkreslenie.Checked)
            {
                boxPrzekreslenie.Enabled = false;
                lblPrzyklad.Font = new Font(czcionka, rozmiar, FontStyle.Underline);
            }
            else
                boxPrzekreslenie.Enabled = true;

            if (boxPrzekreslenie.Checked)
            {
                boxPodkreslenie.Enabled = false;
                lblPrzyklad.Font = new Font(czcionka, rozmiar, FontStyle.Strikeout);
            }
            else
                boxPodkreslenie.Enabled = true;

        }


        private void boxCzcionka_SelectedIndexChanged(object sender, EventArgs e)
        {
            Przyklad();
        }

        private void boxStyl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Przyklad();
        }

        private void boxRozmiar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Przyklad();
        }

        private void boxPodkreslenie_CheckedChanged(object sender, EventArgs e)
        {
            Przyklad();
        }

        private void boxPrzekreslenie_CheckedChanged(object sender, EventArgs e)
        {
            Przyklad();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            styl = Convert.ToString(boxStyl.SelectedItem);
            rozmiar = Convert.ToInt32(boxRozmiar.SelectedItem);
            czcionka = Convert.ToString(boxCzcionka.SelectedItem);
            if (boxPodkreslenie.Checked)
            {
                styl = "podkreslony";
            }

            if (boxPrzekreslenie.Checked)
            {
                styl = "przekreslony";

            }
            notatnik.CzcionkaTxt(czcionka, styl, rozmiar);
            this.Close();
            
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
