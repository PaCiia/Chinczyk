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
    public partial class wyborgry : Form
    {
        public wyborgry()
        {
            InitializeComponent();
        }

        private void iloscgraczy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void zatwierdz_Click(object sender, EventArgs e)
        {
            zatwierdz.DialogResult = System.Windows.Forms.DialogResult.OK;

            /*Button rzut = new Button();
            rzut.Width = 300;
            rzut.Height = 100;
            rzut.Location = new Point(175, 200);
            rzut.Text = "Rzut";
            rzut.Font = new System.Drawing.Font("Arial", 5, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            rzut.DialogResult = System.Windows.Forms.DialogResult.OK;

            Panel plansza = new Panel();
            plansza.BackgroundImage();

            Form chinczyk = new Form();
            chinczyk.Width = 700;
            chinczyk.Height = 500;
            chinczyk.Text = "Chińczyk";
            chinczyk.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            chinczyk.Controls.Add(rzut);*/

        }
    }
}
