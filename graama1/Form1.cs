using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace graama1
{
    public partial class Form1 : Form
    {
        public Form1(string name, string reg)
        {
            InitializeComponent();
            r.Text = reg;
            n.Text = name;
            ini();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void nn_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ini()
        {
            string query = "SELECT GND_name FROM village";
            string MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=graama";
            MySqlConnection databaseconn = new MySqlConnection(MYSQLConnectionString);
            MySqlCommand databasecommand = new MySqlCommand(query, databaseconn);
            databasecommand.CommandTimeout = 60;
            try
            {
                databaseconn.Open();
                MySqlDataReader my = databasecommand.ExecuteReader();
                if (my.HasRows)
                {
                    while (my.Read())
                    {
                        l.Text = my.GetString("GND_name");
                        

                    }
                }
                databaseconn.Close();
            }
            catch(Exception e)
            {

            }
             query = "SELECT COUNT(id) As c FROM person";
             MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=graama";
            databaseconn = new MySqlConnection(MYSQLConnectionString);
             databasecommand = new MySqlCommand(query, databaseconn);
            databasecommand.CommandTimeout = 60;
            try
            {
                databaseconn.Open();
                MySqlDataReader my = databasecommand.ExecuteReader();
                if (my.HasRows)
                {
                    while (my.Read())
                    {
                        pop.Text = my.GetString("c");


                    }
                }
                databaseconn.Close();
            }
            catch (Exception e)
            {

            }
             query = "SELECT COUNT(family_no) AS c FROM family";
           MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=graama";
           databaseconn = new MySqlConnection(MYSQLConnectionString);
            databasecommand = new MySqlCommand(query, databaseconn);
            databasecommand.CommandTimeout = 60;
            try
            {
                databaseconn.Open();
                MySqlDataReader my = databasecommand.ExecuteReader();
                if (my.HasRows)
                {
                    while (my.Read())
                    {
                        fam.Text = my.GetString("c");


                    }
                }
                databaseconn.Close();
            }
            catch (Exception e)
            {

            }
             query = "SELECT COUNT(house_no) AS c FROM house";
             MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=graama";
             databaseconn = new MySqlConnection(MYSQLConnectionString);
             databasecommand = new MySqlCommand(query, databaseconn);
            databasecommand.CommandTimeout = 60;
            try
            {
                databaseconn.Open();
                MySqlDataReader my = databasecommand.ExecuteReader();
                if (my.HasRows)
                {
                    while (my.Read())
                    {
                        hou.Text = my.GetString("c");


                    }
                }
                databaseconn.Close();
            }
            catch (Exception e)
            {

            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            Form7 ff = new Form7();
            ff.ShowDialog();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            mahapola f = new mahapola();
            f.ShowDialog();

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            cert c = new cert();
            c.ShowDialog();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
            Form_Ad f2 = new Form_Ad();
            f2.ShowDialog();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Form2 f3 = new Form2();
            f3.ShowDialog();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            samurdi s = new samurdi();
            s.ShowDialog();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            Form14 f = new Form14();
            f.ShowDialog();
        }

        private void bunifuCustomLabel2_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
