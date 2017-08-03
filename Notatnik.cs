using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        public Notatnik()
        {
            InitializeComponent();
        }

        public string TranslateWord(string word, string language)
        {
            string url = String.Format("http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}", word, language);
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

            for (int i = 0; i < _kolejne; i++)
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

        public void ZapiszJako(string _zapisz)
        {
            if (_zapisz == "zapisz")
            {
                string lines = txtBox.Text;
                System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\User\Desktop\Notatnik.txt");
                file.WriteLine(lines);
                file.Close();
            }
            else {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "txt|*.txt|doc|*.doc";
                saveFileDialog.Title = "Zapisz";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    string lines = txtBox.Text;
                    string sciezka = saveFileDialog.FileName;

                    System.IO.StreamWriter file = new System.IO.StreamWriter(sciezka);
                    file.WriteLine(lines);
                    file.Close();
                }
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
            //nie dziala zawsze
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
                lblPasekStanu.Text = "";
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

        private void zakonczToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy chcesz zapisac obecny plik?", "Nowy", MessageBoxButtons.YesNo) == DialogResult.No)
                Application.Exit();
            else
            {
                ZapiszJako("zapiszJako");
            }

        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy chcesz zapisac obecny plik?", "Nowy", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                Notatnik notatnik = new Notatnik();
                notatnik.Show();
            }
            else
                ZapiszJako("zapiszJako");
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

        private void polAngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string zaznaczone = txtBox.SelectedText;
            txtBox.SelectedText = TranslateWord(zaznaczone, "pl|en");
        }

        private void angPolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string zaznaczone = txtBox.SelectedText;
            txtBox.SelectedText = TranslateWord(zaznaczone, "en|pl");
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Plik zapisano jako Notatnik.txt");
            ZapiszJako("zapisz");
        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZapiszJako("zapiszJako");
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt|*.txt|doc|*.doc";
            openFileDialog.Title = "Otwórz";
            openFileDialog.ShowDialog();


            string filename = openFileDialog.FileName;
            string[] filelines = File.ReadAllLines(filename);

            for (int a = 0; a < filelines.Length; a++)
            {
                txtBox.Text += filelines[a];
            }

        }
    }
}

