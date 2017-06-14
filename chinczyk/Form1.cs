using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static chinczyk.Wyliczenia;

namespace chinczyk
{
    public partial class chinczyk : Form

    {
        Image[] diceImages;
        int dice;
        Random rand;

        private int iloscGraczy = 0;
        List<Gracz> gracze = new List<Gracz>();
        public List<Pionek> pionki = new List<Pionek>();
        Point pozycjaPoczatku;

        public chinczyk()
        {

            //Opacity = 0;

            Label wyborgraczy = new Label();
            wyborgraczy.Location = new Point(30, 24);
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
            zatwierdz.Location = new Point(63, 145);
            zatwierdz.Text = "Zatwierdź";
            zatwierdz.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            zatwierdz.DialogResult = System.Windows.Forms.DialogResult.OK;

            Form wyborgry = new Form();//okno z pytaniem
            wyborgry.Text = "Wybór gry";
            wyborgry.Size = new Size(300, 250);

            wyborgry.Controls.Add(wyborgraczy);
            wyborgry.Controls.Add(iloscgraczy);
            wyborgry.Controls.Add(zatwierdz);
            Opacity = 100;
            wyborgry.ShowDialog();

            pozycjaPoczatku = new Point(318 + 20 + 3 + 3 + 1 + 2, 28 + 30 + 30 - 4 + 3);

            int wybranyIndex = iloscgraczy.SelectedIndex;
            switch (wybranyIndex)
            {
                case -1:
                    //źle
                    throw new Exception("Musisz wybrać ilość graczy!");
                    break;
                case 0:
                    //2 graczy
                    iloscGraczy = 2;
                    stworzGracza(Gracz.NIEBIESKI);
                    stworzGracza(Gracz.ZOLTY);
                    break;
                case 1:
                    //3 graczy
                    iloscGraczy = 3;
                    stworzGracza(Gracz.NIEBIESKI);
                    stworzGracza(Gracz.ZOLTY);
                    stworzGracza(Gracz.ZIELONY);
                    break;
                case 2:
                    //4 graczy
                    iloscGraczy = 4;
                    stworzGracza(Gracz.NIEBIESKI);
                    stworzGracza(Gracz.ZOLTY);
                    stworzGracza(Gracz.ZIELONY);
                    stworzGracza(Gracz.CZERWONY);
                    break;
            }

            InitializeComponent();

        }

        private void stworzGracza(Gracz gracz)
        {
            gracze.Add(gracz);
            for (int i = 0; i < 4; ++i)
            {
                Pionek pionek = new Pionek(this, gracz);
                pionki.Add(pionek);
            }
        }

        private void plansza_Paint(object sender, PaintEventArgs e)
        {

        }

        public Point pozycjaPionkaNaObrazie(Point p)
        {
            Point pozycja0 = pozycjaPoczatku;
            float x = p.X;
            float y = p.Y;
            const float offset = 50.5f;
            pozycja0.X += (int)(x * offset);
            pozycja0.Y += (int)(y * offset);
            return pozycja0;
        }

        private void rzut_Click(object sender, EventArgs e)
        {
            dice = rand.Next(1, 7);

            kostka.BackgroundImage = diceImages[dice];
        }

        private void kostka_Paint(object sender, PaintEventArgs e)
        {
            diceImages = new Image[7];
            diceImages[0] = Properties.Resources.Dice_0_svg;
            diceImages[1] = Properties.Resources.Dice_1;
            diceImages[2] = Properties.Resources.Dice_2;
            diceImages[3] = Properties.Resources.Dice_3;
            diceImages[4] = Properties.Resources.Dice_4;
            diceImages[5] = Properties.Resources.Dice_5;
            diceImages[6] = Properties.Resources.Dice_6;

            rand = new Random();
        }

        private void znacznik_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chinczyk_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void kolejkagracza_Click(object sender, EventArgs e)
        {

        }
    }
}
