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
    public partial class FormTapas : Form
    {

        int PW;
        bool hide;


        public FormTapas()
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

        private void lblSoepen_Click(object sender, EventArgs e)
        {
            formSoepen f5 = new formSoepen();
            f5.Show();
            Visible = false;
        }

        private void lblTapas_Click(object sender, EventArgs e)
        {

        }

        private void lblSalades_Click(object sender, EventArgs e)
        {
            formSalades f7 = new formSalades();
            f7.Show();
            Visible = false;
        }

        private void lblDesserts_Click(object sender, EventArgs e)
        {
            formDessert f8 = new formDessert();
            f8.Show();
            Visible = false;
        }

        private void lblHeader_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formWelcome f1 = new formWelcome();
            f1.Show();
            Visible = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht21.Text, lblPrice21.Text);

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

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void FormTapas_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht.Text, lblPrice.Text);
        }

        private void bntLogo_Click(object sender, EventArgs e)
        {
            formWelcome f1 = new formWelcome();
            f1.Show();
            Visible = false;
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht2.Text, lblPrice2.Text);

        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht3.Text, lblPrice3.Text);

        }

        private void btnAdd4_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht4.Text, lblPrice4.Text);

        }

        private void btnAdd5_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht5.Text, lblPrice5.Text);

        }

        private void btnAdd6_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht6.Text, lblPrice6.Text);

        }

        private void btnAdd7_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht7.Text, lblPrice7.Text);

        }

        private void btnAdd8_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht8.Text, lblPrice8.Text);

        }

        private void btnAdd9_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht9.Text, lblPrice9.Text);

        }

        private void btnAdd10_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht10.Text, lblPrice10.Text);

        }

        private void btnAdd11_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht11.Text, lblPrice11.Text);

        }

        private void btnAdd12_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht12.Text, lblPrice12.Text);

        }

        private void btnAdd13_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht13.Text, lblPrice13.Text);

        }

        private void btnAdd14_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht14.Text, lblPrice14.Text);

        }

        private void btnAdd15_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht15.Text, lblPrice15.Text);

        }

        private void btnAdd16_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht16.Text, lblPrice16.Text);

        }

        private void btnAdd17_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht17.Text, lblPrice17.Text);

        }

        private void btnAdd18_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht18.Text, lblPrice18.Text);

        }

        private void btnAdd19_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht19.Text, lblPrice19.Text);

        }

        private void btnAdd20_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht20.Text, lblPrice20.Text);

        }

        private void btnAdd22_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht22.Text, lblPrice22.Text);

        }

        private void btnAdd23_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht23.Text, lblPrice23.Text);

        }

        private void btnAdd24_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht24.Text, lblPrice24.Text);

        }

        private void btnAdd25_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht25.Text, lblPrice25.Text);

        }

        private void btnAdd26_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht26.Text, lblPrice26.Text);

        }

        private void btnAdd27_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht27.Text, lblPrice27.Text);

        }

        private void btnAdd28_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht28.Text, lblPrice28.Text);

        }

        private void btnAdd29_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht29.Text, lblPrice29.Text);

        }

        private void btnAdd30_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht30.Text, lblPrice30.Text);

        }

        private void btnAdd31_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht31.Text, lblPrice31.Text);

        }

        private void btnAdd32_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht32.Text, lblPrice32.Text);

        }

        private void btnAdd33_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht33.Text, lblPrice33.Text);

        }

        private void btnAdd34_Click(object sender, EventArgs e)
        {
            dgvTest.Rows.Add(lblGerecht34.Text, lblPrice34.Text);

        }

        private void btnCart_Click_1(object sender, EventArgs e)
        {
            if (hide) btnCart.Text = "";
            else btnCart.Text = "";
            timer1.Start();
        }
    }
}
