namespace licencjat
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DlugoscTrasy = new System.Windows.Forms.TextBox();
            this.WartoscZlecenia = new System.Windows.Forms.TextBox();
            this.IloscZalad = new System.Windows.Forms.TextBox();
            this.IloscRozlad = new System.Windows.Forms.TextBox();
            this.IloscKmPustych = new System.Windows.Forms.TextBox();
            this.IloscKmPelnych = new System.Windows.Forms.TextBox();
            this.DlugoscPostoju = new System.Windows.Forms.TextBox();
            this.Zatwierdz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Długość trasy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wartość zlecenia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ilość załadunków";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ilość rozładunków";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ilość kilometrów pustych";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ilość kilometrów z załadunkiem";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ilość dni postoju kierowcy";
            // 
            // DlugoscTrasy
            // 
            this.DlugoscTrasy.Location = new System.Drawing.Point(191, 22);
            this.DlugoscTrasy.Name = "DlugoscTrasy";
            this.DlugoscTrasy.Size = new System.Drawing.Size(146, 20);
            this.DlugoscTrasy.TabIndex = 7;
            this.DlugoscTrasy.TextChanged += new System.EventHandler(this.DlugoscTrasy_TextChanged);
            // 
            // WartoscZlecenia
            // 
            this.WartoscZlecenia.Location = new System.Drawing.Point(191, 48);
            this.WartoscZlecenia.Name = "WartoscZlecenia";
            this.WartoscZlecenia.Size = new System.Drawing.Size(146, 20);
            this.WartoscZlecenia.TabIndex = 8;
            this.WartoscZlecenia.TextChanged += new System.EventHandler(this.WartoscZlecenia_TextChanged);
            // 
            // IloscZalad
            // 
            this.IloscZalad.Location = new System.Drawing.Point(191, 74);
            this.IloscZalad.Name = "IloscZalad";
            this.IloscZalad.Size = new System.Drawing.Size(146, 20);
            this.IloscZalad.TabIndex = 9;
            this.IloscZalad.TextChanged += new System.EventHandler(this.IloscZalad_TextChanged);
            // 
            // IloscRozlad
            // 
            this.IloscRozlad.Location = new System.Drawing.Point(191, 100);
            this.IloscRozlad.Name = "IloscRozlad";
            this.IloscRozlad.Size = new System.Drawing.Size(146, 20);
            this.IloscRozlad.TabIndex = 10;
            this.IloscRozlad.TextChanged += new System.EventHandler(this.IloscRozlad_TextChanged);
            // 
            // IloscKmPustych
            // 
            this.IloscKmPustych.Location = new System.Drawing.Point(191, 126);
            this.IloscKmPustych.Name = "IloscKmPustych";
            this.IloscKmPustych.Size = new System.Drawing.Size(146, 20);
            this.IloscKmPustych.TabIndex = 11;
            this.IloscKmPustych.TextChanged += new System.EventHandler(this.IloscKmPustych_TextChanged);
            // 
            // IloscKmPelnych
            // 
            this.IloscKmPelnych.Location = new System.Drawing.Point(191, 152);
            this.IloscKmPelnych.Name = "IloscKmPelnych";
            this.IloscKmPelnych.Size = new System.Drawing.Size(146, 20);
            this.IloscKmPelnych.TabIndex = 12;
            this.IloscKmPelnych.TextChanged += new System.EventHandler(this.IloscKmPelnych_TextChanged);
            // 
            // DlugoscPostoju
            // 
            this.DlugoscPostoju.Location = new System.Drawing.Point(191, 178);
            this.DlugoscPostoju.Name = "DlugoscPostoju";
            this.DlugoscPostoju.Size = new System.Drawing.Size(146, 20);
            this.DlugoscPostoju.TabIndex = 13;
            this.DlugoscPostoju.TextChanged += new System.EventHandler(this.DlugoscPostoju_TextChanged);
            // 
            // Zatwierdz
            // 
            this.Zatwierdz.Location = new System.Drawing.Point(96, 228);
            this.Zatwierdz.Name = "Zatwierdz";
            this.Zatwierdz.Size = new System.Drawing.Size(168, 32);
            this.Zatwierdz.TabIndex = 14;
            this.Zatwierdz.Text = "Zatwierdź";
            this.Zatwierdz.UseVisualStyleBackColor = true;
            this.Zatwierdz.Click += new System.EventHandler(this.Zatwierdz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(361, 280);
            this.Controls.Add(this.Zatwierdz);
            this.Controls.Add(this.DlugoscPostoju);
            this.Controls.Add(this.IloscKmPelnych);
            this.Controls.Add(this.IloscKmPustych);
            this.Controls.Add(this.IloscRozlad);
            this.Controls.Add(this.IloscZalad);
            this.Controls.Add(this.WartoscZlecenia);
            this.Controls.Add(this.DlugoscTrasy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dane";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DlugoscTrasy;
        private System.Windows.Forms.TextBox WartoscZlecenia;
        private System.Windows.Forms.TextBox IloscZalad;
        private System.Windows.Forms.TextBox IloscRozlad;
        private System.Windows.Forms.TextBox IloscKmPustych;
        private System.Windows.Forms.TextBox IloscKmPelnych;
        private System.Windows.Forms.TextBox DlugoscPostoju;
        private System.Windows.Forms.Button Zatwierdz;
    }
}

