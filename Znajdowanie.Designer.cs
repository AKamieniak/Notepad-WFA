namespace Notatnik
{
    partial class Znajdowanie
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnZnajdz = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(87, 45);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(340, 22);
            this.txtBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Znajdź:";
            // 
            // btnZnajdz
            // 
            this.btnZnajdz.Location = new System.Drawing.Point(453, 45);
            this.btnZnajdz.Name = "btnZnajdz";
            this.btnZnajdz.Size = new System.Drawing.Size(141, 30);
            this.btnZnajdz.TabIndex = 2;
            this.btnZnajdz.Text = "Znajdź następny";
            this.btnZnajdz.UseVisualStyleBackColor = true;
            this.btnZnajdz.Click += new System.EventHandler(this.btnZnajdz_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(453, 85);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(141, 33);
            this.btnAnuluj.TabIndex = 3;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // Znajdowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 160);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZnajdz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox);
            this.Name = "Znajdowanie";
            this.Text = "Znajdowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZnajdz;
        private System.Windows.Forms.Button btnAnuluj;
    }
}