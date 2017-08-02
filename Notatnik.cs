using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik
{
    public partial class Notatnik : Form
    {
        public int liczbaZnakow { get; set; }
        public int a = 0;

        public Notatnik()
        {
            InitializeComponent();
        }
        //translator 
        
        public string TranslateWord(string word)
        {
            string url = String.Format("http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}", word, "pl|en");
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.GetEncoding(28592);
            string result = webClient.DownloadString(url);
            result = result.Substring(result.IndexOf("<span title=\"") + "<span title=\"".Length);
            result = result.Substring(result.IndexOf(">") + 1);
            result = result.Substring(0, result.IndexOf("</span>"));
            return result.Trim();
        }

        public void CzcionkaTxt(string _czcionka, string _styl, float _rozmiar)
        {
            switch (_styl)
            {
                case "zwykła":
                    txtBox.Font = new Font(_czcionka, _rozmiar, FontStyle.Regular);
                    break;
                case "pogrubiona":
                    txtBox.Font = new Font(_czcionka, _rozmiar, FontStyle.Bold);
                    break;
                case "pochyła":
                    txtBox.Font = new Font(_czcionka, _rozmiar, FontStyle.Italic);
                    break;
                case "podkreslony":
                    txtBox.Font = new Font(_czcionka, _rozmiar, FontStyle.Underline);
                    break;
                case "przekreslony":
                    txtBox.Font = new Font(_czcionka, _rozmiar, FontStyle.Strikeout);
                    break;
            }

        }
        public bool Znajdz(string _slowo, int _kolejne)
        {
            int poczatek = txtBox.Text.IndexOf(_slowo);

            for (int i = 0; i < _kolejne;i++)
            {
                poczatek = txtBox.Text.IndexOf(_slowo, poczatek + _slowo.Length);
            }

            if (poczatek != -1)
            {
                txtBox.SelectionStart = poczatek;
                txtBox.SelectionLength = _slowo.Length;
                return false;
            }
            else
            {
                txtBox.DeselectAll();
                return true;
            }
        }

        private void godzinadataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Now;
            txtBox.Text += thisDay.ToString();
        }

        private void zaznaczWszystkoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBox.SelectAll();
        }

        private void cofnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //nie dziala
            if (txtBox.CanUndo == true)
            {
                txtBox.Undo();
                txtBox.ClearUndo();
            }
        }

        private void kopiujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtBox.SelectionLength > 0) 
                txtBox.Copy();
        }

        private void wklejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBox.Paste();
        }

        private void wytnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtBox.SelectedText != "")
                txtBox.Cut();
        }

        private void usunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBox.SelectedText = "";
        }

        private void pasekStanuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pasekStanuToolStripMenuItem.Checked == false)
            {
                pasekStanuToolStripMenuItem.Checked = true;
                lblPasekStanu.Text = "Znaki:" + liczbaZnakow;
            }
            else
            {
                pasekStanuToolStripMenuItem.Checked = false;
                lblPasekStanu.Text = "" ;
            }

        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            liczbaZnakow = txtBox.Text.Count();
            if (pasekStanuToolStripMenuItem.Checked == true)
            {
                lblPasekStanu.Text = "Znaki:" + liczbaZnakow;
            }

        }

        private void wyswietlPomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://support.microsoft.com/pl-pl/products/windows?os=windows-10");
        }

        private void znajdzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //nowe okno do wpisywania szukanych rzeczy
        }

        private void zakonczToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy chcesz zapisac obecny plik?", "Nowy", MessageBoxButtons.YesNo) == DialogResult.No)
                Application.Exit();
            //else
            //zapisz plik


            /*Stream myStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }
            */
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy chcesz zapisac obecny plik?", "Nowy", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                var Form = new Notatnik();
                Form.Show();
            }
        }

        private void czcionkaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ZmianaCzcionki zmianaCzcionki = new ZmianaCzcionki(this);
            zmianaCzcionki.Show();
        }

        private void znajdzToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Znajdowanie znajdowanie = new Znajdowanie(this);
            znajdowanie.Show();
        }
    }
    }

