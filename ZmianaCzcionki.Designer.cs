namespace Notatnik
{
    partial class ZmianaCzcionki
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.boxCzcionka = new System.Windows.Forms.ComboBox();
            this.lblPrzyklad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boxStyl = new System.Windows.Forms.ComboBox();
            this.boxRozmiar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boxPodkreslenie = new System.Windows.Forms.CheckBox();
            this.boxPrzekreslenie = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(377, 507);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(115, 34);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(510, 507);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(103, 34);
            this.btnAnuluj.TabIndex = 1;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // boxCzcionka
            // 
            this.boxCzcionka.FormattingEnabled = true;
            this.boxCzcionka.Items.AddRange(new object[] {
            "Microsoft Sans Serif",
            "Mistral",
            "Modern No. 20",
            "Monotype Corsiva",
            "MS Outlook",
            "MS Reference Sans Serif"});
            this.boxCzcionka.Location = new System.Drawing.Point(32, 80);
            this.boxCzcionka.Name = "boxCzcionka";
            this.boxCzcionka.Size = new System.Drawing.Size(160, 24);
            this.boxCzcionka.TabIndex = 2;
            this.boxCzcionka.Text = "Microsoft Sans Serif";
            this.boxCzcionka.SelectedIndexChanged += new System.EventHandler(this.boxCzcionka_SelectedIndexChanged);
            // 
            // lblPrzyklad
            // 
            this.lblPrzyklad.AutoSize = true;
            this.lblPrzyklad.Enabled = false;
            this.lblPrzyklad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrzyklad.Location = new System.Drawing.Point(423, 403);
            this.lblPrzyklad.Name = "lblPrzyklad";
            this.lblPrzyklad.Size = new System.Drawing.Size(71, 20);
            this.lblPrzyklad.TabIndex = 3;
            this.lblPrzyklad.Text = "aAbBcC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(28, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Czcionka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(216, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Styl czcionki:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(419, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rozmiar:";
            // 
            // boxStyl
            // 
            this.boxStyl.FormattingEnabled = true;
            this.boxStyl.Items.AddRange(new object[] {
            "zwykła",
            "pochyła",
            "pogrubiona"});
            this.boxStyl.Location = new System.Drawing.Point(217, 81);
            this.boxStyl.Name = "boxStyl";
            this.boxStyl.Size = new System.Drawing.Size(177, 24);
            this.boxStyl.TabIndex = 7;
            this.boxStyl.Text = "zwykła";
            this.boxStyl.SelectedIndexChanged += new System.EventHandler(this.boxStyl_SelectedIndexChanged);
            // 
            // boxRozmiar
            // 
            this.boxRozmiar.FormattingEnabled = true;
            this.boxRozmiar.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20"});
            this.boxRozmiar.Location = new System.Drawing.Point(423, 79);
            this.boxRozmiar.Name = "boxRozmiar";
            this.boxRozmiar.Size = new System.Drawing.Size(131, 24);
            this.boxRozmiar.TabIndex = 8;
            this.boxRozmiar.Text = "10";
            this.boxRozmiar.SelectedIndexChanged += new System.EventHandler(this.boxRozmiar_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(348, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "przykład: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(32, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Efekty: ";
            // 
            // boxPodkreslenie
            // 
            this.boxPodkreslenie.AutoSize = true;
            this.boxPodkreslenie.Location = new System.Drawing.Point(32, 322);
            this.boxPodkreslenie.Name = "boxPodkreslenie";
            this.boxPodkreslenie.Size = new System.Drawing.Size(112, 21);
            this.boxPodkreslenie.TabIndex = 11;
            this.boxPodkreslenie.Text = "Podkreślenie";
            this.boxPodkreslenie.UseVisualStyleBackColor = true;
            this.boxPodkreslenie.CheckedChanged += new System.EventHandler(this.boxPodkreslenie_CheckedChanged);
            // 
            // boxPrzekreslenie
            // 
            this.boxPrzekreslenie.AutoSize = true;
            this.boxPrzekreslenie.Location = new System.Drawing.Point(32, 350);
            this.boxPrzekreslenie.Name = "boxPrzekreslenie";
            this.boxPrzekreslenie.Size = new System.Drawing.Size(116, 21);
            this.boxPrzekreslenie.TabIndex = 12;
            this.boxPrzekreslenie.Text = "Przekreślenie";
            this.boxPrzekreslenie.UseVisualStyleBackColor = true;
            this.boxPrzekreslenie.CheckedChanged += new System.EventHandler(this.boxPrzekreslenie_CheckedChanged);
            // 
            // ZmianaCzcionki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 565);
            this.Controls.Add(this.boxPrzekreslenie);
            this.Controls.Add(this.boxPodkreslenie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxRozmiar);
            this.Controls.Add(this.boxStyl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrzyklad);
            this.Controls.Add(this.boxCzcionka);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnOk);
            this.Name = "ZmianaCzcionki";
            this.Text = "ZmianaCzcionki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.ComboBox boxCzcionka;
        private System.Windows.Forms.Label lblPrzyklad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox boxStyl;
        private System.Windows.Forms.ComboBox boxRozmiar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox boxPodkreslenie;
        private System.Windows.Forms.CheckBox boxPrzekreslenie;
    }
}