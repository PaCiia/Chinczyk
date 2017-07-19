using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace licencjat
{

    public partial class Form1 : Form
    {
        //zmienne do wyników algorytmów
        #region
        private string a1;
        private string a2;
        private string a3;
        private string a4;
        private string a5;
        private string a6;
        private string a7;
        private string a8;
        private string a9;
        private string a10;
        private string a11;
        private string a12;
        private string a13;
        private string a14;
        private string a15;
        private string a16;
        private string a17;
        private string a18;
        private string a19;
        private string a20;
        #endregion


        public Form1()
        {
            InitializeComponent();
        }
        private void DlugoscTrasy_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void WartoscZlecenia_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void IloscZalad_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void IloscRozlad_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void IloscKmPustych_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void IloscKmPelnych_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DlugoscPostoju_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Zatwierdz_Click(object sender, EventArgs e)
        {
            bool fail = false;

            int tak = 0;
            int nie = 0;
            string ostateczny;

            string trasa = DlugoscTrasy.Text;
            int t = int.Parse(trasa);

            string cena = WartoscZlecenia.Text;
            int c = int.Parse(cena);

            string zalad = IloscZalad.Text;
            int z = int.Parse(zalad);

            string rozlad = IloscRozlad.Text;
            int r = int.Parse(rozlad);

            string pustekm = IloscKmPustych.Text;
            int km0 = int.Parse(pustekm);

            string pelnekm = IloscKmPelnych.Text;
            int km = int.Parse(pelnekm);

            string dni = DlugoscPostoju.Text;
            int d = int.Parse(dni);

            if (t != km + km0)
            {
                Label blad = new Label();
                blad.Text = "Niezgodne dane! Długość trasy nie jest równa sumie ilości kilometrów pustych i kilometrów z towarem.";
                blad.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
                blad.Location = new Point(0, 10);
                blad.Width = 520;
                blad.Height = 20;

                Button ok = new Button();
                ok.Text = "OK";
                ok.Font = new System.Drawing.Font("Arial", 3, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
                ok.Location = new Point(210, 40);
                ok.Width = 100;
                ok.Height = 50;
                ok.DialogResult = DialogResult.Cancel;

                Form error = new Form();
                error.Width = 510;
                error.Height = 150;
                error.Text = "Błąd";
                error.BackColor = Color.MistyRose;
                error.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

                error.Controls.Add(blad);
                error.Controls.Add(ok);
                fail = true;
                error.ShowDialog();
                
            }
            //drzewa
            #region
            //drzewo1
            #region
            Label drzewo1 = new Label();
            drzewo1.Text = "Wynik pierwszego drzewa:";
            drzewo1.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            drzewo1.Location = new Point(0, 0);
            drzewo1.Width = 230;
            drzewo1.Height = 20;
            #endregion

            //drzewo2
            #region
            Label drzewo2 = new Label();
            drzewo2.Text = "Wynik drugiego drzewa:";
            drzewo2.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            drzewo2.Location = new Point(0, 20);
            drzewo2.Width = 230;
            drzewo2.Height = 20;
            #endregion

            //drzewo3
            #region
            Label drzewo3 = new Label();
            drzewo3.Text = "Wynik trzeciego drzewa:";
            drzewo3.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            drzewo3.Location = new Point(0, 40);
            drzewo3.Width = 230;
            drzewo3.Height = 20;
            #endregion

            //drzewo4
            #region
            Label drzewo4 = new Label();
            drzewo4.Text = "Wynik czwartego drzewa:";
            drzewo4.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            drzewo4.Location = new Point(0, 60);
            drzewo4.Width = 230;
            drzewo4.Height = 20;
            #endregion

            //drzewo5
            #region
            Label drzewo5 = new Label();
            drzewo5.Text = "Wynik piątego drzewa:";
            drzewo5.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            drzewo5.Location = new Point(0, 80);
            drzewo5.Width = 230;
            drzewo5.Height = 20;
            #endregion

            //drzewo6
            #region
            Label drzewo6 = new Label();
            drzewo6.Text = "Wynik szóstego drzewa:";
            drzewo6.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            drzewo6.Location = new Point(0, 100);
            drzewo6.Width = 230;
            drzewo6.Height = 20;
            #endregion

            //drzewo7
            #region
            Label drzewo7 = new Label();
            drzewo7.Text = "Wynik siódmego drzewa:";
            drzewo7.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            drzewo7.Location = new Point(0, 120);
            drzewo7.Width = 230;
            drzewo7.Height = 20;
            #endregion

            //drzewo8
            #region
            Label drzewo8 = new Label();
            drzewo8.Text = "Wynik ósmego drzewa:";
            drzewo8.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            drzewo8.Location = new Point(0, 140);
            drzewo8.Width = 230;
            drzewo8.Height = 20;
            #endregion

            //drzewo9
            #region
            Label drzewo9 = new Label();
            drzewo9.Text = "Wynik dziewiątego drzewa:";
            drzewo9.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            drzewo9.Location = new Point(0, 160);
            drzewo9.Width = 230;
            drzewo9.Height = 20;
            #endregion

            //drzewo10
            #region
            Label drzewo10 = new Label();
            drzewo10.Text = "Wynik dziesiątego drzewa:";
            drzewo10.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            drzewo10.Location = new Point(0, 180);
            drzewo10.Width = 230;
            drzewo10.Height = 20;
            #endregion

            //drzewo11
            #region
            Label drzewo11 = new Label();
            drzewo11.Text = "Wynik jedenastego drzewa:";
            drzewo11.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            drzewo11.Location = new Point(0, 200);
            drzewo11.Width = 230;
            drzewo11.Height = 20;
            #endregion

            //drzewo12
            #region
            Label drzewo12 = new Label();
            drzewo12.Text = "Wynik dwunastego drzewa:";
            drzewo12.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            drzewo12.Location = new Point(0, 220);
            drzewo12.Width = 230;
            drzewo12.Height = 20;
            #endregion

            //drzewo13
            #region
            Label drzewo13 = new Label();
            drzewo13.Text = "Wynik trzynastego drzewa:";
            drzewo13.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            drzewo13.Location = new Point(0, 240);
            drzewo13.Width = 230;
            drzewo13.Height = 20;
            #endregion

            //drzewo14
            #region
            Label drzewo14 = new Label();
            drzewo14.Text = "Wynik czternastego drzewa:";
            drzewo14.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            drzewo14.Location = new Point(0, 260);
            drzewo14.Width = 230;
            drzewo14.Height = 20;
            #endregion

            //drzewo15
            #region
            Label drzewo15 = new Label();
            drzewo15.Text = "Wynik piętnastego drzewa:";
            drzewo15.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            drzewo15.Location = new Point(0, 280);
            drzewo15.Width = 230;
            drzewo15.Height = 20;
            #endregion

            //drzewo16
            #region
            Label drzewo16 = new Label();
            drzewo16.Text = "Wynik szesnastego drzewa:";
            drzewo16.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            drzewo16.Location = new Point(0, 300);
            drzewo16.Width = 230;
            drzewo16.Height = 20;
            #endregion

            //drzewo17
            #region
            Label drzewo17 = new Label();
            drzewo17.Text = "Wynik siedemnastego drzewa:";
            drzewo17.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            drzewo17.Location = new Point(0, 320);
            drzewo17.Width = 230;
            drzewo17.Height = 20;
            #endregion

            //drzewo18
            #region
            Label drzewo18 = new Label();
            drzewo18.Text = "Wynik osiemnastego drzewa:";
            drzewo18.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            drzewo18.Location = new Point(0, 340);
            drzewo18.Width = 230;
            drzewo18.Height = 20;
            #endregion

            //drzewo19
            #region
            Label drzewo19 = new Label();
            drzewo19.Text = "Wynik dziewiętnastego drzewa:";
            drzewo19.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            drzewo19.Location = new Point(0, 360);
            drzewo19.Width = 230;
            drzewo19.Height = 20;
            #endregion

            //drzewo20
            #region
            Label drzewo20 = new Label();
            drzewo20.Text = "Wynik dwudziestego drzewa:";
            drzewo20.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            drzewo20.Location = new Point(0, 380);
            drzewo20.Width = 230;
            drzewo20.Height = 20;
            #endregion
            #endregion

            //algorytmy
            #region
            //algorytm1
            #region
            if (t > 800)
            {
                if ((c/t)>1 || c / (km0 + km) > 1)
                {
                    a1 = "Wziąć zlecenie";
                    ++tak;
                }
                else
                {
                    if (z + r > 2)
                    {
                        a1 = "Nie brać zlecenia";
                        ++nie;
                    }
                    else
                    {
                        a1 = "Wziąć zlecenie";
                        ++tak;
                    }
                }
            }
            else
            {
                a1 = "Wziąć zlecenie";
                ++tak;
            }
            #endregion

            //algorytm2
            #region
            if ((c / t) > 1 || c / (km0 + km) > 1)
            {
                a2 = "Wziąć zlecenie";
            }
            else
            {
                if (t > 800)
                {
                    if (z + r > 2)
                    {
                        a2 = "Nie brać zlecenia";
                        ++nie;
                    }
                    else
                    {
                        a2 = "Wziąć zlecenie";
                        ++tak;
                    }
                }
                else
                {
                    a2 = "Wziąć zlecenie";
                    ++tak;
                }
            }
            #endregion

            //algorytm3
            #region
            if (z > 2 || r>2)
            {
                if (t > 800 )
                {
                    if ((c / t) > 1 || c / (km0 + km) > 1)
                    {
                        a3 = "Wziąć zlecenie";
                        ++tak;
                    }
                    else
                    {
                        a3 = "Nie brać zlecenia";
                        ++nie;
                    }
                }
                else
                {
                    a3 = "Wziąć zlecenie";
                    ++tak;
                }
            }
            else
            {
                if ((c / t) > 1)
                {
                    a3 = "Wziąć zlecenie";
                    ++tak;
                }
                else
                {
                    if (t > 800)
                    {
                        a3 = "Nie brać zlecenia";
                        ++nie;
                    }
                    else
                    {
                        a3 = "Wziąć zlecenie";
                        ++tak;
                    }
                }
            }
            #endregion

            //algorytm4
            #region
            if (z > 2 || r > 2)
            {
                if ((c / t) > 1 || c / (km0 + km) > 1)
                {
                    a4 = "Wziąć zlecenie";
                    ++tak;
                }
                else
                {
                    if (d > 1)
                    {
                        a4 = "Wziąć zlecenie";
                        ++tak;
                    }
                    else
                    {
                        a4 = "Nie brać zlecenia";
                        ++nie;
                    }
                }
            }
            else
            {
                if ((c / t) > 1)
                {
                    a4 = "Wziąć zlecenie";
                    ++tak;
                }
                else
                {
                    if (km0>50)
                    {
                        a4 = "Nie brać zlecenia";
                        ++nie;
                    }
                    else
                    {
                        a4 = "Wziąć zlecenie";
                        ++tak;
                    }
                }
            }
            #endregion

            //algorytm5
            #region
            if ((c / t) > 1 || c / (km0 + km) > 1)
            {
                a5 = "Wziąć zlecenie";
                ++tak;
            }
            else
            {
                if (z>2 || r>2)
                {
                    a5 = "Nie brać zlecenia";
                    ++nie;
                }
                else
                {
                    a5 = "Wziąć zlecenie";
                    ++tak;
                }
            }
            #endregion

            //algorytm6
            #region
            if (t > 800)
            {
                if ((c / t) > 1 || c / (km0 + km) > 1)
                {
                    a6 = "Wziąć zlecenie";
                    ++tak;
                }
                else
                {
                    if (d > 2)
                    {
                        a6 = "Wziąć zlecenie";
                        ++tak;
                    }
                    else
                    {
                        a6 = "Nie brać zlecenia";
                        ++nie;
                    }
                }
            }
            else
            {
                a6 = "Wziąć zlecenie";
                ++tak;
            }
            #endregion

            //algorytm7
            #region
            if (t>800)
            {
                if ((c / t) > 1 || c / (km0 + km) > 1)
                {
                    if (km0>50)
                    {
                        if (d > 2)
                        {
                            a7 = "Wziąć zlecenie";
                            ++tak;
                        }
                        else
                        {
                            a7 = "Nie brać zlecenia";
                            ++nie;
                        }
                    }
                    else
                    {
                        a7 = "Wziąć zlecenie";
                        ++tak;
                    }
                }
                else
                {
                    if (z > 3 || r > 3)
                    {
                        if(d>2)
                        {
                            a7 = "Wziąć zlecenie";
                            ++tak;
                        }
                        else
                        {
                            a7 = "Nie brać zlecenia";
                            ++nie;
                        }
                    }
                    else
                    {
                        if (km0 > 50)
                        {
                            a7 = "Nie brać zlecenia";
                            ++nie;
                        }
                        else
                        {
                            a7 = "Wziąć zlecenie";
                            ++tak;
                        }
                    }
                }
            }
            else
            {
                if ((c / t) > 1 || c / (km0 + km) > 1)
                {
                    if (z > 4 || r > 4)
                    {
                        a7 = "Nie brać zlecenia";
                        ++nie;
                    }
                    else
                    {
                        a7 = "Wziąć zlecenie";
                        ++tak;
                    }
                }
                else
                {
                    if (z>2||r>2)
                    {
                        if (d > 2)
                        {
                            a7 = "Wziąć zlecenie";
                            ++tak;
                        }
                        else
                        {
                            a7 = "Nie brać zlecenia";
                            ++nie;
                        }
                    }
                    else
                    {
                        a7 = "Wziąć zlecenie";
                        ++tak;
                    }
                }
            }
            #endregion

            //algorytm8
            #region
            if (d > 2)
            {
                a8 = "Wziąć zlecenie";
                ++tak;
            }
            else
            {
                if (km0 > 50)
                {
                    if ((c / t) > 1 || c / (km0 + km) > 1)
                    {
                        a8 = "Wziąć zlecenie";
                        ++tak;
                    }
                    else
                    {
                        a8 = "Nie brać zlecenia";
                        ++nie;
                    }
                }
                else
                {
                    if (z > 2 || r > 2)
                    {
                        a8 = "Nie brać zlecenia";
                        ++nie;
                    }
                    else
                    {
                        a8 = "Wziąć zlecenie";
                        ++tak;
                    }
                }
            }
            #endregion

            //algorytm9
            #region
            if ((c / t) > 1 || c / (km0 + km) > 1)
            {
                if (z + r > 4)
                {
                    if (km0 > 50)
                    {
                        a9 = "Nie brać zlecenia";
                        ++nie;
                    }
                    else
                    {
                        a9 = "Wziąć zlecenie";
                        ++tak;
                    }
                }
                else
                {
                    a9 = "Wziąć zlecenie";
                    ++tak;
                }
            }
            else
            {
                if (z + r > 3)
                {
                    if (d > 2)
                    {
                        a9 = "Wziąć zlecenie";
                        ++tak;
                    }
                    else
                    {
                        a9 = "Nie brać zlecenia";
                        ++nie;
                    }
                }
                else
                {
                    if (km0 > 50)
                    {
                        a9 = "Nie brać zlecenia";
                        ++nie;
                    }
                    else
                    {
                        a9 = "Wziąć zlecenie";
                        ++tak;
                    }
                }
            }
            #endregion

            //algorytm10
            #region
            if ((c / t) > 1 || c / (km0 + km) > 1)
            {
                a10 = "Wziąć zlecenie";
                ++tak;
            }
            else
            {
                if (d > 2)
                {
                    a10 = "Wziąć zlecenie";
                    ++tak;
                }
                else
                {
                    if (z + r > 4)
                    {
                        a10 = "Nie brać zlecenia";
                        ++nie;
                    }
                    else
                    {
                        if (km0 > 50)
                        {
                            a10 = "Nie brać zlecenia";
                            ++nie;
                        }
                        else
                        {
                            if (z + r > 3)
                            {
                                a10 = "Nie brać zlecenia";
                                ++nie;
                            }
                            else
                            {
                                a10 = "Wziąć zlecenie";
                                ++tak;
                            }
                        }
                    }
                }
            }
            #endregion

            //algorytm11
            #region
            if ((c / t) > 1 || c / (km0 + km) > 1)
            {
                if (z + r > 4)
                {
                    if (km0 > 50)
                    {
                        a11 = "Nie brać zlecenia";
                        ++nie;
                    }
                    else
                    {
                        a11 = "Wziąć zlecenie";
                        ++tak;
                    }
                }
                else
                {
                    a11 = "Wziąć zlecenie";
                    ++tak;
                }
            }
            else
            {
                if (d > 2)
                {
                    a11 = "Wziąć zlecenie";
                    ++tak;
                }
                else
                {
                    if (r + z > 2)
                    {
                        if (km0 > 50)
                        {
                            a11 = "Nie brać zlecenia";
                            ++nie;
                        }
                        else
                        {
                            a11 = "Wziąć zlecenie";
                            ++tak;
                        }
                    }
                    else
                    {
                        a11 = "Wziąć zlecenie";
                        ++tak;
                    }
                }
            }
            #endregion

            //algorytm12
            #region
            if (km0 > 50)
            {
                if ((c / t) > 1 || c / (km0 + km) > 1)
                {
                    a12 = "Wziąć zlecenie";
                    ++tak;
                }
                else
                {
                    if (z + r > 3)
                    {
                        a12 = "Nie brać zlecenia";
                        ++nie;
                    }
                    else
                    {
                        a12 = "Wziąć zlecenie";
                        ++tak;
                    }
                }
            }
            else
            {
                if (z + r > 4)
                {
                    if((c / t) > 1 || c / (km0 + km) > 1)
                    {
                        a12 = "Wziąć zlecenie";
                        ++tak;
                    }
                    else
                    {
                        if (d > 2)
                        {
                            a12 = "Wziąć zlecenie";
                            ++tak;
                        }
                        else
                        {
                            a12 = "Nie brać zlecenia";
                            ++nie;
                        }
                    }
                }
                else
                {
                    if ((c / t) > 1 || c / (km0 + km) > 1)
                    {
                        a12 = "Wziąć zlecenie";
                        ++tak;
                    }
                    else
                    {
                        a12 = "Nie brać zlecenia";
                        ++nie;
                    }
                }
            }
            #endregion

            //algorytm13
            #region
            if (km0 > 50)
            {
                if ((c / t) > 1 || c / (km0 + km) > 1)
                {
                    a13 = "Wziąć zlecenie";
                    ++tak;
                }
                else
                {
                    if (z + r > 3)
                    {
                        if (d > 2)
                        {
                            a13 = "Wziać zlecenie";
                            ++tak;
                        }
                        else
                        {
                            a13 = "Nie brać zlecenia";
                            ++nie;
                        }
                    }
                    else
                    {
                        a13 = "Wziąć zlecenie";
                        ++tak;
                    }
                }
            }
            else
            {
                if (z + r > 4)
                {
                    if ((c / t) > 1 || c / (km0 + km) > 1)
                    {
                        a13 = "Wziąć zlecenie";
                        ++tak;
                    }
                    else
                    {
                        if (d > 2)
                        {
                            a13 = "Wziąć zlecenie";
                            ++tak;
                        }
                        else
                        {
                            a13 = "Nie brać zlecenia";
                            ++nie;
                        }
                    }
                }
                else
                {
                    if ((c / t) > 1 || c / (km0 + km) > 1)
                    {
                        a13 = "Wziąć zlecenie";
                        ++tak;
                    }
                    else
                    {
                        a13 = "Nie brać zlecenia";
                        ++nie;
                    }
                }
            }
            #endregion

            //algorytm14
            #region
            if (km0 > 50)
            {
                if (d > 2)
                {
                    a14 = "Wziąć zlecenie";
                    ++tak;
                }
                else
                {
                    if ((c / t) > 1 || c / (km0 + km) > 1)
                    {
                        a14 = "Wziąć zlecenie";
                        ++tak;
                    }
                    else
                    {
                        if (z + r > 3)
                        {
                            a14 = "Nie brać zlecenia";
                            ++nie;
                        }
                        else
                        {
                            a14 = "Wziąć zlecenie";
                            ++tak;
                        }
                    }
                }
            }
            else
            {
                a14 = "Wziąć zlecenie";
                ++tak;
            }
            #endregion

            //algorytm15
            #region
            if (km0 > 50)
            {
                if (d > 2)
                {
                    a15 = "Wziąć zlecenie";
                    ++tak;
                }
                else
                {
                    if ((c / t) > 1 || c / (km0 + km) > 1)
                    {
                        a15 = "Wziąć zlecenie";
                        ++tak;
                    }
                    else
                    {
                        if (z + r > 3)
                        {
                            a15 = "Nie brać zlecenia";
                            ++nie;
                        }
                        else
                        {
                            a15 = "Wziąć zlecenie";
                            ++tak;
                        }
                    }
                }
            }
            else
            {
                if (d > 2)
                {
                    a15 = "Wziąć zlecenie";
                    ++tak;
                }
                else
                {
                    a15 = "Nie brać zlecenia";
                    ++nie;
                }
            }
            #endregion

            //algorytm16
            #region
            if (km0 > 50)
            {
                if (d > 2)
                {
                    a16 = "Wziąć zlecenie";
                    ++tak;
                }
                else
                {
                    if ((c / t) > 1 || c / (km0 + km) > 1)
                    {
                        a16 = "Wziąć zlecenie";
                        ++tak;
                    }
                    else
                    {
                        if (z + r > 3)
                        {
                            a16 = "Nie brać zlecenia";
                            ++nie;
                        }
                        else
                        {
                            a16 = "Wziąć zlecenie";
                            ++tak;
                        }
                    }
                }
            }
            else
            {
                if (d > 2)
                {
                    a16 = "Wziąć zlecenie";
                    ++tak;
                }
                else
                {
                    if((c / t) > 1 || c / (km0 + km) > 1)
                    {
                        a16 = "Wziąć zlecenie";
                        ++tak;
                    }
                    else
                    {
                        a16 = "Nie brać zlecenia";
                        ++nie;
                    }
                }
            }
            #endregion

            //algorytm17
            #region
            if (d > 2)
            {
                a17 = "Wziąć zlecenie";
                ++tak;
            }
            else
            {
                if ((c / t) > 1 || c / (km0 + km) > 1)
                {
                    a17 = "Wziąć zlecenie";
                    ++tak;
                }
                else
                {
                    if (z + r > 3)
                    {
                        a17 = "Nie brać zlecenia";
                        ++nie;
                    }
                    else
                    {
                        a17 = "Wziąć zlecenie";
                        ++tak;
                    }
                }
            }
            #endregion

            //algorytm18
            #region
            if (d > 2)
            {
                a18 = "Wziąć zlecenie";
                ++tak;
            }
            else
            {
                if (z + r > 4)
                {
                    a18 = "Nie brać zlecenia";
                    ++nie;
                }
                else
                {
                    if (km0 > 50)
                    {
                        if((c / t) > 1 || c / (km0 + km) > 1)
                        {
                            a18 = "Wziąć zlecenie";
                            ++tak;
                        }
                        else
                        {
                            a18 = "Nie brać zlecenia";
                            ++nie;
                        }
                    }
                    else
                    {
                        a18 = "Nie brać zlecenia";
                        ++nie;
                    }
                }
            }
            #endregion

            //algorytm19
            #region
            if (d > 2)
            {
                a19 = "Wziąć zlecenie";
                ++tak;
            }
            else
            {
                if (z + r > 4)
                {
                    a19 = "Nie brać zlecenia";
                    ++nie;
                }
                else
                {
                    if (km0 > 50)
                    {
                        if ((c / t) > 1 || c / (km0 + km) > 1)
                        {
                            a19 = "Wziąć zlecenie";
                            ++tak;
                        }
                        else
                        {
                            if (z + r > 3)
                            {
                                a19 = "Nie brać zlecenia";
                                ++nie;
                            }
                            else
                            {
                                a19 = "Wziąć zlecenie";
                                ++tak;
                            }
                        }
                    }
                    else
                    {
                        a19 = "Nie brać zlecenia";
                        ++nie;
                    }
                }
            }
            #endregion

            //algorytm20
            #region
            if (d > 2)
            {
                a20 = "Wziąć zlecenie";
                ++tak;
            }
            else
            {
                if (km0 > 50)
                {
                    if((c / t) > 1 || c / (km0 + km) > 1)
                    {
                        a20 = "Wziąć zlecenie";
                        ++tak;
                    }
                    else
                    {
                        a20 = "Nie brać zlecenia";
                        ++nie;
                    }
                }
                else
                {
                    if ((c / t) > 1 || c / (km0 + km) > 1)
                    {
                        a20 = "Wziąć zlecenie";
                        ++tak;
                    }
                    else
                    {
                        if (z + r > 3)
                        {
                            a20 = "Nie brać zlecenia";
                            ++nie;
                        }
                        else
                        {
                            a20 = "Wziąć zlecenie";
                            ++tak;
                        }
                    }
                }
            }
            #endregion

            if (tak > nie)
            {
                ostateczny = "WEŹ ZLECENIE";
            }
            else
            {
                ostateczny = "NIE BIERZ ZLECENIA";
            }

            #endregion

            //wyniki
            #region
            //wynik1
            #region
            Label wynik1 = new Label();
            wynik1.Text = a1;
            wynik1.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            wynik1.Location = new Point(240, 0);
            wynik1.Width = 150;
            wynik1.Height = 20;
            #endregion

            //wynik2
            #region
            Label wynik2 = new Label();
            wynik2.Text = a2;
            wynik2.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            wynik2.Location = new Point(240, 20);
            wynik2.Width = 150;
            wynik2.Height = 20;
            #endregion

            //wynik3
            #region
            Label wynik3 = new Label();
            wynik3.Text = a3;
            wynik3.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            wynik3.Location = new Point(240, 40);
            wynik3.Width = 150;
            wynik3.Height = 20;
            #endregion

            //wynik4
            #region
            Label wynik4 = new Label();
            wynik4.Text = a4;
            wynik4.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            wynik4.Location = new Point(240, 60);
            wynik4.Width = 150;
            wynik4.Height = 20;
            #endregion

            //wynik5
            #region
            Label wynik5 = new Label();
            wynik5.Text = a5;
            wynik5.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            wynik5.Location = new Point(240, 80);
            wynik5.Width = 150;
            wynik5.Height = 20;
            #endregion

            //wynik6
            #region
            Label wynik6 = new Label();
            wynik6.Text = a6;
            wynik6.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            wynik6.Location = new Point(240, 100);
            wynik6.Width = 150;
            wynik6.Height = 20;
            #endregion

            //wynik7
            #region
            Label wynik7 = new Label();
            wynik7.Text = a7;
            wynik7.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            wynik7.Location = new Point(240, 120);
            wynik7.Width = 150;
            wynik7.Height = 20;
            #endregion

            //wynik8
            #region
            Label wynik8 = new Label();
            wynik8.Text = a8;
            wynik8.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            wynik8.Location = new Point(240, 140);
            wynik8.Width = 150;
            wynik8.Height = 20;
            #endregion

            //wynik9
            #region
            Label wynik9 = new Label();
            wynik9.Text = a9;
            wynik9.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            wynik9.Location = new Point(240, 160);
            wynik9.Width = 150;
            wynik9.Height = 20;
            #endregion

            //wynik10
            #region
            Label wynik10 = new Label();
            wynik10.Text = a10;
            wynik10.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            wynik10.Location = new Point(240, 180);
            wynik10.Width = 150;
            wynik10.Height = 20;
            #endregion

            //wynik11
            #region
            Label wynik11 = new Label();
            wynik11.Text = a11;
            wynik11.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            wynik11.Location = new Point(240, 200);
            wynik11.Width = 150;
            wynik11.Height = 20;
            #endregion

            //wynik12
            #region
            Label wynik12 = new Label();
            wynik12.Text = a12;
            wynik12.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            wynik12.Location = new Point(240, 220);
            wynik12.Width = 150;
            wynik12.Height = 20;
            #endregion

            //wynik13
            #region
            Label wynik13 = new Label();
            wynik13.Text = a13;
            wynik13.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            wynik13.Location = new Point(240, 240);
            wynik13.Width = 150;
            wynik13.Height = 20;
            #endregion

            //wynik14
            #region
            Label wynik14 = new Label();
            wynik14.Text = a14;
            wynik14.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            wynik14.Location = new Point(240, 260);
            wynik14.Width = 150;
            wynik14.Height = 20;
            #endregion

            //wynik15
            #region
            Label wynik15 = new Label();
            wynik15.Text = a15;
            wynik15.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            wynik15.Location = new Point(240, 280);
            wynik15.Width = 150;
            wynik15.Height = 20;
            #endregion

            //wynik16
            #region
            Label wynik16 = new Label();
            wynik16.Text = a16;
            wynik16.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            wynik16.Location = new Point(240, 300);
            wynik16.Width = 150;
            wynik16.Height = 20;
            #endregion

            //wynik17
            #region
            Label wynik17 = new Label();
            wynik17.Text = a17;
            wynik17.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            wynik17.Location = new Point(240, 320);
            wynik17.Width = 150;
            wynik17.Height = 20;
            #endregion

            //wynik18
            #region
            Label wynik18 = new Label();
            wynik18.Text = a18;
            wynik18.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            wynik18.Location = new Point(240, 340);
            wynik18.Width = 150;
            wynik18.Height = 20;
            #endregion

            //wynik19
            #region
            Label wynik19 = new Label();
            wynik19.Text = a19;
            wynik19.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            wynik19.Location = new Point(240, 360);
            wynik19.Width = 150;
            wynik19.Height = 20;
            #endregion

            //wynik20
            #region
            Label wynik20 = new Label();
            wynik20.Text = a20;
            wynik20.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            wynik20.Location = new Point(240, 380);
            wynik20.Width = 150;
            wynik20.Height = 20;
            #endregion

            //wynik "za"
            #region
            Label wynikza = new Label();
            wynikza.Text = "Ilość wyniku ,,Wziąć zlecenie'':";
            wynikza.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            wynikza.Location = new Point(0, 420);
            wynikza.Width = 240;
            wynikza.Height = 20;
            #endregion

            //wynik "za" ilość
            #region
            Label wynikzailosc = new Label();
            wynikzailosc.Text = tak.ToString();
            wynikzailosc.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            wynikzailosc.Location = new Point(240, 420);
            wynikzailosc.Width = 50;
            wynikzailosc.Height = 20;
            #endregion

            //wynik "przeciw"
            #region
            Label wynikprzeciw = new Label();
            wynikprzeciw.Text = "Ilość wyniku ,,Nie brać zlecenia'':";
            wynikprzeciw.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            wynikprzeciw.Location = new Point(0, 440);
            wynikprzeciw.Width = 240;
            wynikprzeciw.Height = 20;
            #endregion

            //wynik "przeciw" ilość
            #region
            Label wynikprzeciwilosc = new Label();
            wynikprzeciwilosc.Text = nie.ToString();
            wynikprzeciwilosc.Font = new System.Drawing.Font("Arial", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            wynikprzeciwilosc.Location = new Point(240, 440);
            wynikprzeciwilosc.Width = 50;
            wynikprzeciwilosc.Height = 20;
            #endregion

            //wynik końcowy
            #region
            Label wynikkoncowy = new Label();
            wynikkoncowy.Text = ostateczny;
            wynikkoncowy.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            wynikkoncowy.ForeColor = Color.Red;
            wynikkoncowy.Location = new Point(0, 500);
            wynikkoncowy.Width = 500;
            wynikkoncowy.Height = 200;
            #endregion

            #endregion


            Form wyniki = new Form();
            wyniki.Width = 420;
            wyniki.Height = 600;
            wyniki.Text = "Wyniki";
            wyniki.BackColor = Color.LemonChiffon;
            wyniki.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            //add drzewo
            #region
            wyniki.Controls.Add(drzewo1);
            wyniki.Controls.Add(drzewo2);
            wyniki.Controls.Add(drzewo3);
            wyniki.Controls.Add(drzewo4);
            wyniki.Controls.Add(drzewo5);
            wyniki.Controls.Add(drzewo6);
            wyniki.Controls.Add(drzewo7);
            wyniki.Controls.Add(drzewo8);
            wyniki.Controls.Add(drzewo9);
            wyniki.Controls.Add(drzewo10);
            wyniki.Controls.Add(drzewo11);
            wyniki.Controls.Add(drzewo12);
            wyniki.Controls.Add(drzewo13);
            wyniki.Controls.Add(drzewo14);
            wyniki.Controls.Add(drzewo15);
            wyniki.Controls.Add(drzewo16);
            wyniki.Controls.Add(drzewo17);
            wyniki.Controls.Add(drzewo18);
            wyniki.Controls.Add(drzewo19);
            wyniki.Controls.Add(drzewo20);
            #endregion

            //add wynik
            #region
            wyniki.Controls.Add(wynik1);
            wyniki.Controls.Add(wynik2);
            wyniki.Controls.Add(wynik3);
            wyniki.Controls.Add(wynik4);
            wyniki.Controls.Add(wynik5);
            wyniki.Controls.Add(wynik6);
            wyniki.Controls.Add(wynik7);
            wyniki.Controls.Add(wynik8);
            wyniki.Controls.Add(wynik9);
            wyniki.Controls.Add(wynik10);
            wyniki.Controls.Add(wynik11);
            wyniki.Controls.Add(wynik12);
            wyniki.Controls.Add(wynik13);
            wyniki.Controls.Add(wynik14);
            wyniki.Controls.Add(wynik15);
            wyniki.Controls.Add(wynik16);
            wyniki.Controls.Add(wynik17);
            wyniki.Controls.Add(wynik18);
            wyniki.Controls.Add(wynik19);
            wyniki.Controls.Add(wynik20);
            wyniki.Controls.Add(wynikprzeciw);
            wyniki.Controls.Add(wynikprzeciwilosc);
            wyniki.Controls.Add(wynikza);
            wyniki.Controls.Add(wynikzailosc);
            wyniki.Controls.Add(wynikkoncowy);
            #endregion


            if (!fail)    wyniki.ShowDialog();
        }
    }
}