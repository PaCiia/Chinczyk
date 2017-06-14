using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static chinczyk.Wyliczenia;

namespace chinczyk
{
    public class Pionek
    {
        public Point pozycja;
        public Gracz gracz;
        public Color kolor;
        public chinczyk plansza;
        Point[] mapa = new Point[40];
        public List<Point> sciezka = new List<Point>();
        public Button ksztalt;

        public Pionek(chinczyk plansza, Gracz gracz)
        {
            switch (gracz)
            {
                case Gracz.NIEBIESKI:
                    kolor = Kolory.kolorNiebieski;
                    break;
                case Gracz.ZIELONY:
                    kolor = Kolory.kolorZielony;
                    break;
                case Gracz.ZOLTY:
                    kolor = Kolory.kolorZolty;
                    break;
                case Gracz.CZERWONY:
                    kolor = Kolory.kolorCzerwony;
                    break;
            }

            this.plansza = plansza;
            this.gracz = gracz;
            pozycja = new Point(0, 0);


            ksztalt = new Button();
            ksztalt.Size = new Size(30, 30);
            ksztalt.BackColor = kolor;
            ksztalt.Click += new EventHandler(klikniecieNaPionek_click);

            plansza.Controls.Add(ksztalt);

            umiescWSchowku();

            zrobMape();
            stworzSciezke(gracz);
        }

        //Klikniecie pionka
        void klikniecieNaPionek_click(object sender, EventArgs e)
        {
            // to sie wywola gdy pionek zostanie klikniety
            if (czyJestWSchowku()) this.umiescNaPlanszy();
            else
                if (czyJestNaPlanszy() || czyJestWDomku()) this.wykonajRuch(2);
        }

        //Logika tworzenia ścieżki po której może się poruszać pionek
        private void stworzSciezke(Gracz gracz)
        {
            Point[] domek = new Point[4];
            switch (this.gracz)
            {
                case Gracz.NIEBIESKI:
                    domek[0] = new Point(5, 1);
                    domek[1] = new Point(5, 2);
                    domek[2] = new Point(5, 3);
                    domek[3] = new Point(5, 4);
                    break;
                case Gracz.ZIELONY:
                    domek[0] = new Point(9, 5);
                    domek[1] = new Point(8, 5);
                    domek[2] = new Point(7, 5);
                    domek[3] = new Point(6, 5);
                    break;
                case Gracz.ZOLTY:
                    domek[0] = new Point(5, 9);
                    domek[1] = new Point(5, 8);
                    domek[2] = new Point(5, 7);
                    domek[3] = new Point(5, 6);
                    break;
                case Gracz.CZERWONY:
                    domek[0] = new Point(1, 5);
                    domek[1] = new Point(2, 5);
                    domek[2] = new Point(3, 5);
                    domek[3] = new Point(4, 5);
                    break;
            }
            switch (gracz)
            {
                case Gracz.NIEBIESKI:
                    for (int i = 0; i < 40; ++i)
                        sciezka.Add(mapa[i]);
                    break;
                case Gracz.ZIELONY:
                    for (int i = 0; i < 40; ++i)
                        sciezka.Add(mapa[(i + 10) % 40]);
                    break;
                case Gracz.ZOLTY:
                    for (int i = 0; i < 40; ++i)
                        sciezka.Add(mapa[(i + 20) % 40]);
                    break;
                case Gracz.CZERWONY:
                    for (int i = 0; i < 40; ++i)
                        sciezka.Add(mapa[(i + 30) % 40]);
                    break;
            }
            for (int i = 0; i < 4; ++i)
            {
                sciezka.Add(domek[i]);
            }
        }

        //Mapa służy do tworzenia ścieżki i sprawdzenia czy pionek jest na planszy.
        private void zrobMape()
        {
            int i = 0;
            mapa[i++] = new Point(6, 0);
            mapa[i++] = new Point(6, 1);
            mapa[i++] = new Point(6, 2);
            mapa[i++] = new Point(6, 3);
            mapa[i++] = new Point(6, 4);
            mapa[i++] = new Point(7, 4);
            mapa[i++] = new Point(8, 4);
            mapa[i++] = new Point(9, 4);
            mapa[i++] = new Point(10, 4);

            mapa[i++] = new Point(10, 5);

            mapa[i++] = new Point(10, 6);
            mapa[i++] = new Point(9, 6);
            mapa[i++] = new Point(8, 6);
            mapa[i++] = new Point(7, 6);
            mapa[i++] = new Point(6, 6);
            mapa[i++] = new Point(6, 7);
            mapa[i++] = new Point(6, 8);
            mapa[i++] = new Point(6, 9);
            mapa[i++] = new Point(6, 10);

            mapa[i++] = new Point(5, 10);

            mapa[i++] = new Point(4, 10);
            mapa[i++] = new Point(4, 9);
            mapa[i++] = new Point(4, 8);
            mapa[i++] = new Point(4, 7);
            mapa[i++] = new Point(4, 6);
            mapa[i++] = new Point(3, 6);
            mapa[i++] = new Point(2, 6);
            mapa[i++] = new Point(1, 6);
            mapa[i++] = new Point(0, 6);

            mapa[i++] = new Point(0, 5);

            mapa[i++] = new Point(0, 4);
            mapa[i++] = new Point(1, 4);
            mapa[i++] = new Point(2, 4);
            mapa[i++] = new Point(3, 4);
            mapa[i++] = new Point(4, 4);
            mapa[i++] = new Point(4, 3);
            mapa[i++] = new Point(4, 2);
            mapa[i++] = new Point(4, 1);
            mapa[i++] = new Point(4, 0);

            mapa[i++] = new Point(5, 0);
        }

        //umieszcza pionek w schowku z planszy, zwraca false gdy sie nie da (5 pionków?)
        public bool umiescWSchowku()
        {
            Point[] schowek = new Point[4];
            switch (this.gracz)
            {
                case Gracz.NIEBIESKI:
                    schowek[0] = new Point(9, 0);
                    schowek[1] = new Point(10, 0);
                    schowek[2] = new Point(9, 1);
                    schowek[3] = new Point(10, 1);
                    break;
                case Gracz.ZIELONY:
                    schowek[0] = new Point(9, 9);
                    schowek[1] = new Point(10, 9);
                    schowek[2] = new Point(9, 10);
                    schowek[3] = new Point(10, 10);
                    break;
                case Gracz.ZOLTY:
                    schowek[0] = new Point(0, 9);
                    schowek[1] = new Point(1, 9);
                    schowek[2] = new Point(0, 10);
                    schowek[3] = new Point(1, 10);
                    break;
                case Gracz.CZERWONY:
                    schowek[0] = new Point(0, 0);
                    schowek[1] = new Point(1, 0);
                    schowek[2] = new Point(0, 1);
                    schowek[3] = new Point(1, 1);
                    break;
            }

            bool fail = true;
            for (int i = 0; i < 4; ++i)
            {
                bool zajete = false;
                foreach (Pionek element in plansza.pionki)
                {
                    if (element.pozycja == schowek[i])
                    {
                        zajete = true;
                        break;
                    }
                }
                if (zajete == false)
                {
                    //jezeli slot w schowek[i] jest pusty to umiesc tam pionek
                    fail = false;
                    this.pozycja = schowek[i];
                    synchronizujPozycjeZObrazem();
                    break;
                }
            }
            return fail;
        }

        //przenosi pionek z schowka na plansze
        public void umiescNaPlanszy()
        {
            Point start = new Point();
            switch (this.gracz)
            {
                case Gracz.NIEBIESKI:
                    start = new Point(6, 0);
                    break;
                case Gracz.ZIELONY:
                    start = new Point(10, 6);
                    break;
                case Gracz.ZOLTY:
                    start = new Point(4, 10);
                    break;
                case Gracz.CZERWONY:
                    start = new Point(0, 4);
                    break;
            }
            this.pozycja = start;
            synchronizujPozycjeZObrazem();
        }

        //zwraca pionek który jest na takiej samej pozycji co ten
        public Pionek sprawdzKolizje()
        {
            foreach (Pionek element in plansza.pionki)
            {
                if (element.pozycja == this.pozycja) return element;
            }
            return null;
        }

        //zwraca true gdy jest na planszy
        public bool czyJestNaPlanszy()
        {
            for (int j = 0; j < 40; ++j)
            {
                if (mapa[j] == this.pozycja) return true;
            }
            return false;
        }

        //zwraca true gdy jest w schowku
        public bool czyJestWSchowku()
        {
            Point[] schowek = new Point[4];
            switch (this.gracz)
            {
                case Gracz.NIEBIESKI:
                    schowek[0] = new Point(9, 0);
                    schowek[1] = new Point(10, 0);
                    schowek[2] = new Point(9, 1);
                    schowek[3] = new Point(10, 1);
                    break;
                case Gracz.ZIELONY:
                    schowek[0] = new Point(9, 9);
                    schowek[1] = new Point(10, 9);
                    schowek[2] = new Point(9, 10);
                    schowek[3] = new Point(10, 10);
                    break;
                case Gracz.ZOLTY:
                    schowek[0] = new Point(0, 9);
                    schowek[1] = new Point(1, 9);
                    schowek[2] = new Point(0, 10);
                    schowek[3] = new Point(1, 10);
                    break;
                case Gracz.CZERWONY:
                    schowek[0] = new Point(0, 0);
                    schowek[1] = new Point(1, 0);
                    schowek[2] = new Point(0, 1);
                    schowek[3] = new Point(1, 1);
                    break;
            }
            for (int i = 0; i < 4; ++i)
            {
                if (schowek[i] == this.pozycja) return true;
            }
            return false;
        }

        //zwraca true czy jest w domku
        public bool czyJestWDomku()
        {
            Point[] domek = new Point[4];
            switch (this.gracz)
            {
                case Gracz.NIEBIESKI:
                    domek[0] = new Point(5, 1);
                    domek[1] = new Point(5, 2);
                    domek[2] = new Point(5, 3);
                    domek[3] = new Point(5, 4);
                    break;
                case Gracz.ZIELONY:
                    domek[0] = new Point(9, 5);
                    domek[0] = new Point(8, 5);
                    domek[2] = new Point(7, 5);
                    domek[3] = new Point(6, 5);
                    break;
                case Gracz.ZOLTY:
                    domek[0] = new Point(5, 9);
                    domek[1] = new Point(5, 8);
                    domek[2] = new Point(5, 7);
                    domek[3] = new Point(5, 6);
                    break;
                case Gracz.CZERWONY:
                    domek[0] = new Point(1, 5);
                    domek[1] = new Point(2, 5);
                    domek[2] = new Point(3, 5);
                    domek[3] = new Point(4, 5);
                    break;
            }
            for (int i = 0; i < 4; ++i)
            {
                if (domek[i] == this.pozycja) return true;
            }
            return false;
        }

        //n - liczba o którą pionek chce się ruszyć
        //zwraca pozycje po n ruchach
        //Uwaga wywala wyjątek
        public Point gdzieBedzieNastepnaPozycja(uint n)
        {
            uint s = 0;
            bool odliczaj = false;
            bool czyDoliczyl = false;
            Point tmp = new Point();
            foreach (Point punkt in sciezka)
            {
                if (odliczaj)
                    ++s;
                if (s == n) { tmp = punkt; czyDoliczyl = true; break; }
                if (punkt == this.pozycja)
                    odliczaj = true;
            }
            if (czyDoliczyl == false) throw new Exception("Ruch wychodzi poza sciezke");
            return tmp;
        }

        //ustawia pozycje pionka na taką która będzie po n ruchach, zwraca false gdy się nie da (np. pola za domkiem nie istnieją)
        public bool wykonajRuch(uint n)
        {
            try
            {
                Point tmp = gdzieBedzieNastepnaPozycja(n);
                this.pozycja = tmp;
                synchronizujPozycjeZObrazem();
            }
            catch
            {
                //nie da się wykonać ruchu
                return false;
            }
            return true;
        }

        //ustawienie pionka na siłę
        public void ustawPionek(Point nowaPozycja)
        {
            this.pozycja = nowaPozycja;
            synchronizujPozycjeZObrazem();
        }

        //Ustawia ikonke pionka na aktualnej pozycji w aplikacji.
        public void synchronizujPozycjeZObrazem()
        {
            //ksztalt.Margin = new Padding(pozycja.X, pozycja.Y, 0, 0);
            Point nowaPozycja = plansza.pozycjaPionkaNaObrazie(pozycja);
            ksztalt.Location = new Point(nowaPozycja.X, nowaPozycja.Y);
        }
    }
}
