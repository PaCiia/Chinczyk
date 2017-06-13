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
            InitializeComponent();

            Form okno = new Form();
            okno.Width = 300;
            okno.Height = 250;
            okno.Text = "Wybór gry";
            okno.BackColor = Color.AliceBlue;
            okno.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            okno.ShowDialog();

            ComboBox wyborgry = new ComboBox();
            
            wyborgry.Location = new Point();
            wybor_opcji.Text = "Kliknij mnie";
            wybor_opcji.Font = new System.Drawing.Font("Arial", 3, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));

            this.comboBox1.Location = new System.Drawing.Point(477, 187);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);

            okno.Controls.Add();
            okno.Controls.Add(etykieta);
            okno.Controls.Add(wybor_opcji);
            okno.Controls.Add(przycisk);
        }

        private void plansza_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
