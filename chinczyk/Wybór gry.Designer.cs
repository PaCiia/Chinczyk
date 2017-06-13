namespace chinczyk
{
    partial class wyborgry
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
            this.iloscgraczy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zatwierdz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // iloscgraczy
            // 
            this.iloscgraczy.FormattingEnabled = true;
            this.iloscgraczy.Items.AddRange(new object[] {
            "2 graczy",
            "3 graczy",
            "4 graczy"});
            this.iloscgraczy.Location = new System.Drawing.Point(63, 61);
            this.iloscgraczy.Name = "iloscgraczy";
            this.iloscgraczy.Size = new System.Drawing.Size(142, 21);
            this.iloscgraczy.TabIndex = 0;
            this.iloscgraczy.SelectedIndexChanged += new System.EventHandler(this.iloscgraczy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proszę wybrać ilość graczy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // zatwierdz
            // 
            this.zatwierdz.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zatwierdz.Location = new System.Drawing.Point(63, 145);
            this.zatwierdz.Name = "zatwierdz";
            this.zatwierdz.Size = new System.Drawing.Size(142, 32);
            this.zatwierdz.TabIndex = 2;
            this.zatwierdz.Text = "Zatwierdź";
            this.zatwierdz.UseVisualStyleBackColor = true;
            this.zatwierdz.Click += new System.EventHandler(this.zatwierdz_Click);
            // 
            // wyborgry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 189);
            this.Controls.Add(this.zatwierdz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iloscgraczy);
            this.Name = "wyborgry";
            this.Text = "Wybór gry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox iloscgraczy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button zatwierdz;
    }
}