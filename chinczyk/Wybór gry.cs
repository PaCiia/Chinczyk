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
        }
    }
}
