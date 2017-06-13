using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chinczyk
{
    public partial class chinczyk : Form

    {

        public chinczyk()
        {

            Opacity = 0;

            Label wyborgraczy = new Label();
            wyborgraczy.Location= new Point(30, 24);
            wyborgraczy.Size = new Size(227, 18);
            wyborgraczy.Text = "Proszę wybrać ilość graczy";
            wyborgraczy.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));

            ComboBox iloscgraczy = new ComboBox();
            iloscgraczy.Location = Location = new Point(63, 61);
            iloscgraczy.Size = new Size(150, 21);
            iloscgraczy.Items.AddRange(new object[] {
            "2 graczy",
            "3 graczy",
            "4 graczy"});

            Button zatwierdz = new Button();
            zatwierdz.Size = new Size(150, 32);
            zatwierdz.Location = new Point(63,145);
            zatwierdz.Text = "Zatwierdź";
            zatwierdz.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            zatwierdz.DialogResult = System.Windows.Forms.DialogResult.OK;
    
            Form wyborgry = new Form();//okno z pytaniem
            wyborgry.Text = "Wybór gry";
            wyborgry.Size = new Size(300,250);

            wyborgry.Controls.Add(wyborgraczy);
            wyborgry.Controls.Add(iloscgraczy);
            wyborgry.Controls.Add(zatwierdz);
            Opacity = 100;
            wyborgry.ShowDialog();

            InitializeComponent();
        }
        

        private void plansza_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void rzut_Click(object sender, EventArgs e)
        {

        }

        private void kostka_Paint(object sender, PaintEventArgs e)
        {

        }

        private void znacznik_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
