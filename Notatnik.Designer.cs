namespace Notatnik
{
    partial class Notatnik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBox = new System.Windows.Forms.TextBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaStronyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakonczToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cofnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wytnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopiujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wklejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.znajdzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaznaczWszystkoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.godzinadataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zawijanieCzcionkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czcionkaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.widokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasekStanuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyswietlPomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPasekStanu = new System.Windows.Forms.Label();
            this.czcionkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.translatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polAngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.angPolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBox.Location = new System.Drawing.Point(12, 41);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(580, 348);
            this.txtBox.TabIndex = 1;
            this.txtBox.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edycjaToolStripMenuItem,
            this.zawijanieCzcionkiToolStripMenuItem,
            this.widokToolStripMenuItem,
            this.pomocToolStripMenuItem,
            this.translatorToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(620, 28);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "Menu";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.otwórzToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.zapiszJakoToolStripMenuItem,
            this.ustawieniaStronyToolStripMenuItem,
            this.zakonczToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.plikToolStripMenuItem.Text = "Plik ";
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.nowyToolStripMenuItem.Text = "Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.otwórzToolStripMenuItem.Text = "Otwórz...";
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.zapiszJakoToolStripMenuItem.Text = "Zapisz jako...";
            // 
            // ustawieniaStronyToolStripMenuItem
            // 
            this.ustawieniaStronyToolStripMenuItem.Name = "ustawieniaStronyToolStripMenuItem";
            this.ustawieniaStronyToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.ustawieniaStronyToolStripMenuItem.Text = "Ustawienia strony...";
            // 
            // zakonczToolStripMenuItem
            // 
            this.zakonczToolStripMenuItem.Name = "zakonczToolStripMenuItem";
            this.zakonczToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.zakonczToolStripMenuItem.Text = "Zakończ";
            this.zakonczToolStripMenuItem.Click += new System.EventHandler(this.zakonczToolStripMenuItem_Click);
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cofnijToolStripMenuItem,
            this.wytnijToolStripMenuItem,
            this.kopiujToolStripMenuItem,
            this.wklejToolStripMenuItem,
            this.usunToolStripMenuItem,
            this.znajdzToolStripMenuItem,
            this.zaznaczWszystkoToolStripMenuItem,
            this.godzinadataToolStripMenuItem});
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.edycjaToolStripMenuItem.Text = "Edycja";
            // 
            // cofnijToolStripMenuItem
            // 
            this.cofnijToolStripMenuItem.Name = "cofnijToolStripMenuItem";
            this.cofnijToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.cofnijToolStripMenuItem.Text = "Cofnij";
            this.cofnijToolStripMenuItem.Click += new System.EventHandler(this.cofnijToolStripMenuItem_Click);
            // 
            // wytnijToolStripMenuItem
            // 
            this.wytnijToolStripMenuItem.Name = "wytnijToolStripMenuItem";
            this.wytnijToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.wytnijToolStripMenuItem.Text = "Wytnij";
            this.wytnijToolStripMenuItem.Click += new System.EventHandler(this.wytnijToolStripMenuItem_Click);
            // 
            // kopiujToolStripMenuItem
            // 
            this.kopiujToolStripMenuItem.Name = "kopiujToolStripMenuItem";
            this.kopiujToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.kopiujToolStripMenuItem.Text = "Kopiuj";
            this.kopiujToolStripMenuItem.Click += new System.EventHandler(this.kopiujToolStripMenuItem_Click);
            // 
            // wklejToolStripMenuItem
            // 
            this.wklejToolStripMenuItem.Name = "wklejToolStripMenuItem";
            this.wklejToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.wklejToolStripMenuItem.Text = "Wklej";
            this.wklejToolStripMenuItem.Click += new System.EventHandler(this.wklejToolStripMenuItem_Click);
            // 
            // usunToolStripMenuItem
            // 
            this.usunToolStripMenuItem.Name = "usunToolStripMenuItem";
            this.usunToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.usunToolStripMenuItem.Text = "Usuń";
            this.usunToolStripMenuItem.Click += new System.EventHandler(this.usunToolStripMenuItem_Click);
            // 
            // znajdzToolStripMenuItem
            // 
            this.znajdzToolStripMenuItem.Name = "znajdzToolStripMenuItem";
            this.znajdzToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.znajdzToolStripMenuItem.Text = "Znajdź...";
            this.znajdzToolStripMenuItem.Click += new System.EventHandler(this.znajdzToolStripMenuItem_Click_1);
            // 
            // zaznaczWszystkoToolStripMenuItem
            // 
            this.zaznaczWszystkoToolStripMenuItem.Name = "zaznaczWszystkoToolStripMenuItem";
            this.zaznaczWszystkoToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.zaznaczWszystkoToolStripMenuItem.Text = "Zaznacz wszystko";
            this.zaznaczWszystkoToolStripMenuItem.Click += new System.EventHandler(this.zaznaczWszystkoToolStripMenuItem_Click);
            // 
            // godzinadataToolStripMenuItem
            // 
            this.godzinadataToolStripMenuItem.Name = "godzinadataToolStripMenuItem";
            this.godzinadataToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.godzinadataToolStripMenuItem.Text = "Godzina/data";
            this.godzinadataToolStripMenuItem.Click += new System.EventHandler(this.godzinadataToolStripMenuItem_Click);
            // 
            // zawijanieCzcionkiToolStripMenuItem
            // 
            this.zawijanieCzcionkiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.czcionkaToolStripMenuItem1});
            this.zawijanieCzcionkiToolStripMenuItem.Name = "zawijanieCzcionkiToolStripMenuItem";
            this.zawijanieCzcionkiToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.zawijanieCzcionkiToolStripMenuItem.Text = "Format";
            // 
            // czcionkaToolStripMenuItem1
            // 
            this.czcionkaToolStripMenuItem1.Name = "czcionkaToolStripMenuItem1";
            this.czcionkaToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.czcionkaToolStripMenuItem1.Text = "Czcionka...";
            this.czcionkaToolStripMenuItem1.Click += new System.EventHandler(this.czcionkaToolStripMenuItem1_Click);
            // 
            // widokToolStripMenuItem
            // 
            this.widokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasekStanuToolStripMenuItem});
            this.widokToolStripMenuItem.Name = "widokToolStripMenuItem";
            this.widokToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.widokToolStripMenuItem.Text = "Widok";
            // 
            // pasekStanuToolStripMenuItem
            // 
            this.pasekStanuToolStripMenuItem.Name = "pasekStanuToolStripMenuItem";
            this.pasekStanuToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.pasekStanuToolStripMenuItem.Text = "Pasek Stanu";
            this.pasekStanuToolStripMenuItem.Click += new System.EventHandler(this.pasekStanuToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wyswietlPomocToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // wyswietlPomocToolStripMenuItem
            // 
            this.wyswietlPomocToolStripMenuItem.Name = "wyswietlPomocToolStripMenuItem";
            this.wyswietlPomocToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.wyswietlPomocToolStripMenuItem.Text = "Wyświetl pomoc";
            this.wyswietlPomocToolStripMenuItem.Click += new System.EventHandler(this.wyswietlPomocToolStripMenuItem_Click);
            // 
            // lblPasekStanu
            // 
            this.lblPasekStanu.AutoSize = true;
            this.lblPasekStanu.Location = new System.Drawing.Point(444, 415);
            this.lblPasekStanu.Name = "lblPasekStanu";
            this.lblPasekStanu.Size = new System.Drawing.Size(0, 17);
            this.lblPasekStanu.TabIndex = 4;
            // 
            // czcionkaToolStripMenuItem
            // 
            this.czcionkaToolStripMenuItem.Name = "czcionkaToolStripMenuItem";
            this.czcionkaToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.czcionkaToolStripMenuItem.Text = "Czcionka";
            // 
            // translatorToolStripMenuItem
            // 
            this.translatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.polAngToolStripMenuItem,
            this.angPolToolStripMenuItem});
            this.translatorToolStripMenuItem.Name = "translatorToolStripMenuItem";
            this.translatorToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.translatorToolStripMenuItem.Text = "Translator";
            // 
            // polAngToolStripMenuItem
            // 
            this.polAngToolStripMenuItem.Name = "polAngToolStripMenuItem";
            this.polAngToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.polAngToolStripMenuItem.Text = "Pol - Ang";
            this.polAngToolStripMenuItem.Click += new System.EventHandler(this.polAngToolStripMenuItem_Click);
            // 
            // angPolToolStripMenuItem
            // 
            this.angPolToolStripMenuItem.Name = "angPolToolStripMenuItem";
            this.angPolToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.angPolToolStripMenuItem.Text = "Ang - Pol";
            this.angPolToolStripMenuItem.Click += new System.EventHandler(this.angPolToolStripMenuItem_Click);
            // 
            // Notatnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 444);
            this.Controls.Add(this.lblPasekStanu);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Notatnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notatnik";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakonczToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cofnijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem znajdzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaznaczWszystkoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem godzinadataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasekStanuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyswietlPomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaStronyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem wytnijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopiujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wklejToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usunToolStripMenuItem;
        private System.Windows.Forms.Label lblPasekStanu;
        private System.Windows.Forms.ToolStripMenuItem zawijanieCzcionkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czcionkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czcionkaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem translatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polAngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem angPolToolStripMenuItem;
    }
}

