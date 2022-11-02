using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TABLET_BESTELLEN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectedGerechten f2 = new SelectedGerechten();
            f2.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectedDrank f3 = new SelectedDrank();
            f3.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SelectedDesserts f4 = new SelectedDesserts();
            f4.Show();
            Visible = false;
        }
    }
}
