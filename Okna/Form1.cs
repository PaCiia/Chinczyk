using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label etykieta = new Label();
            etykieta.Text = "Wprowadź odległość";
            etykieta.Font = new System.Drawing.Font("Arial", 6, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            etykieta.Location = new Point(175, 50);
            etykieta.Width = 1000;
            etykieta.Height = 70;

            TextBox pole_tekstowe = new TextBox();
            pole_tekstowe.Width = 350;
            pole_tekstowe.Location = new Point(175, 100);


            CheckBox wybor_opcji = new CheckBox();
            wybor_opcji.Location = new Point(175, 150);
            wybor_opcji.Text = "Kliknij mnie";
            wybor_opcji.Font = new System.Drawing.Font("Arial", 3, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));

            Button przycisk = new Button();
            przycisk.Width = 300;
            przycisk.Height = 100;
            przycisk.Location = new Point(175, 200);
            przycisk.Text = "Oblicz";
            przycisk.Font = new System.Drawing.Font("Arial", 5, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            przycisk.BackColor = Color.LightSkyBlue;
            przycisk.DialogResult = System.Windows.Forms.DialogResult.OK;

            Form okno = new Form();
            okno.Width = 700;
            okno.Height = 500;
            okno.Text = "Moje drugie okno";
            okno.BackColor = Color.LemonChiffon;
            okno.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            okno.Controls.Add(pole_tekstowe);
            okno.Controls.Add(etykieta);
            okno.Controls.Add(wybor_opcji);
            okno.Controls.Add(przycisk);

            okno.ShowDialog();

            string odl = pole_tekstowe.Text;
            double i = double.Parse(odl);

            double wynik = i * (6.4185 * (10 ^ 23)) * (6 * 10 ^ 24) / (7 * 7);

            string k = wynik.ToString();

            label1.Text = wybor_opcji.Checked.ToString();
            label2.Text = pole_tekstowe.Text;
            label2.Text = k;

            //okno.Show();  //wszystkie nowe okna wyłączą się przy zamknięciu głównego
            //okno.ShowDialog();  //przy otwarciu nowego okna nie można wrócić do głównego póki jest otwarte nowe

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 600;
            dataGridView1.RowCount = 500;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = i + j;
                }
            }
        }
    }
}