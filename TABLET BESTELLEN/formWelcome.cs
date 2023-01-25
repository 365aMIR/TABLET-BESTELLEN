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
    public partial class formWelcome : Form
    {
        public formWelcome()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formSoepen f2 = new formSoepen();
            f2.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formOrderList f3 = new formOrderList();
            f3.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            SelectedHelp f4 = new SelectedHelp();
            f4.Show();
            Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void formWelcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDay.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnLogo_Click_1(object sender, EventArgs e)
        {
            formWelcome f1 = new formWelcome();
            f1.Show();
            Visible = false;
        }
    }
}
