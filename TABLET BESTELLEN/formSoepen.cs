using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;





namespace TABLET_BESTELLEN
{
    public partial class formSoepen : Form

    {
        int PW;
        bool hide;

        public formSoepen()
        {
            InitializeComponent();
            PW = Spanel.Height;
            hide = false;
            string connStr = "server=10.50.0.32;user=Developers;database=holey;port=3306;password=4TtPsApwdJjmD5FfwYittUxgj";
            // MySqlConnection con = new MySqlConnection(@"server=10.50.0.32;useri=Developers;password=4TtPsApwdJjmD5FfwYittUxgj;database=holey"); 

            //SqlConnection con = new SqlConnection(@"Data Source = 10.50.0.32; Initial Catalog = holey; Integrated Security = True");

            MySqlConnection con = new MySqlConnection(connStr);
            MySqlCommand command = new MySqlCommand();
            string cmd;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formWelcome f1 = new formWelcome();
            f1.Show();
            Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            SelectedHelp f4 = new SelectedHelp();
            f4.Show();
            Visible = false;
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            formWelcome f1 = new formWelcome();
            f1.Show();
            Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblTapas_Click(object sender, EventArgs e)
        {
            FormTapas f6 = new FormTapas();
            f6.Show();
            Visible = false;
        }

        private void btnCart_Click_1(object sender, EventArgs e)
        {
            if (hide) btnCart.Text = "";
            else btnCart.Text = "";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = DateTime.Now.ToLongTimeString();

            if (hide)
            {
                Spanel.Height = Spanel.Height + 300;
                if (Spanel.Height >= PW)
                {
                    timer1.Stop();
                    hide = false;
                    this.Refresh();
                }


            }
            else
            {
                Spanel.Height = Spanel.Height - 300;
                if (Spanel.Height <= 0)
                {
                    timer1.Stop();
                    hide = true;
                    this.Refresh();
                }
            }


        }

        private void dgvTest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // if (dgvTest.Columns[e.ColumnIndex].Name == "Delete")
            // {
            //     if (MessageBox.Show("Are you sure u want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;

            //}
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }

        private void Spanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht.Text, lblPrice.Text);

        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht2.Text, lblPrice2.Text);
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht3.Text, lblPrice3.Text);

        }

        private void button5_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection(@"server=10.50.0.32;user=Developers;database=holey;port=3306;password=4TtPsApwdJjmD5FfwYittUxgj");

            for (int i = 0; i < dgvTest.Rows.Count - 0; i++)
            {
                MySqlCommand cmd = new MySqlCommand(@"INSERT INTO bestellingen (Dish, price, status, datum, tafel) VALUES('" + dgvTest.Rows[i].Cells[0].Value + "','" + dgvTest.Rows[i].Cells[1].Value + "','" + 1 + "','" + label1.Text + "','" + 1 + "')", conn);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            //timer1.Start();
            btnAmount.Text = dgvTest.Rows.Count.ToString();
            dgvTest.Rows.Clear();

        }

        private void lblPrice2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formSoepen_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToLongTimeString();

        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            formWelcome f1 = new formWelcome();
            f1.Show();
            Visible = false;
        }

        private void btnAmount_Click(object sender, EventArgs e)
        {

        }

        private void lblSoepen_Click_1(object sender, EventArgs e)
        {

        }

        private void lblTapas_Click_1(object sender, EventArgs e)
        {

        }

        private void lblDesserts_Click_1(object sender, EventArgs e)
        {

        }

        private void lblSalades_Click_1(object sender, EventArgs e)
        {

        }

        private void lblDrinks_Click(object sender, EventArgs e)
        {
            formDrinks f11 = new formDrinks();
            f11.Show();
            Visible = false;
        }

        private void lblDesserts_Click(object sender, EventArgs e)
        {
            formDessert f8 = new formDessert();
            f8.Show();
            Visible = false;
        }

        private void lblSalades_Click(object sender, EventArgs e)
        {
            formSalades f7 = new formSalades();
            f7.Show();
            Visible = false;
        }

        private void lblSoepen_Click(object sender, EventArgs e)
        {
            formSoepen f10 = new formSoepen();
            f10.Show();
            Visible = false;
        }
    }
}
