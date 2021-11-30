using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace graama1
{
    public partial class Form14 : Form
    {
        public string dat;
        public string cur;
        public Form14()
        {
            InitializeComponent();
            this.dat = "";
            this.cur = DateTime.UtcNow.Date.ToString("yyyy-MM-dd");
            setGrid();
        }
        private bool validnic(string nic)
        {
            string reg = @"^[1-9][0-9]{8}[v|V]$";
            Regex re = new Regex(reg);
            if (re.IsMatch(nic))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void setGrid()
        {
            string query = "SELECT * FROM certires";
            string MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=graama";
            MySqlConnection databaseconn = new MySqlConnection(MYSQLConnectionString);
            MySqlCommand databasecommand = new MySqlCommand(query, databaseconn);
            MySqlDataAdapter re = new MySqlDataAdapter(query, databaseconn);
            databasecommand.CommandTimeout = 60;
            try
            {
                databaseconn.Open();

                DataTable dtb = new DataTable();
                re.Fill(dtb);
                this.dtb.DataSource = dtb;
                databaseconn.Close();


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (validnic(nic.Text))
            {
                string query = "SELECT first_name,last_name,NIC,address,joined_date FROM person WHERE NIC='" + nic.Text + "'";
                string MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=graama";
                MySqlConnection databaseconn = new MySqlConnection(MYSQLConnectionString);
                MySqlCommand databasecommand = new MySqlCommand(query, databaseconn);

                databasecommand.CommandTimeout = 60;
                try
                {
                    databaseconn.Open();
                    MySqlDataReader my = databasecommand.ExecuteReader();

                    while (my.Read())
                    {
                        name.Text = my.GetString("first_name") + " " + my.GetString("last_name");
                        address.Text = my.GetString("address");
                        dat = Convert.ToDateTime(my["joined_date"]).ToString("yyyy-MM-dd");
                    }

                    databaseconn.Close();


                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
            else
            {
                name.Text = "";
                address.Text = "";
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Console.WriteLine(dat);
            string query = "INSERT INTO certires VALUES ('" + DBNull.Value + "','" + nic.Text + "','" + purpose.Text + "','" + des.Text + "','" + cur + "');DELETE FROM curcert;INSERT INTO curcert VALUES ('" + name.Text + "','" + nic.Text + "','" + address.Text + "','" + des.Text + "','" + dat + "','" + cur + "','" + purpose.Text + "');";
            //string query= "UPDATE person SET first_name='" + firstt + "',last_name='" + lastt + "',address='" + addres + "',NIC='" + ni + "',DOB='" + birth + "',joined_date='" + joinn + "',gender='" + gend + "',nation='" + nat + "',religion='" + reli + "',family_no='" + fam + "',house_no='" + housee + "'WHERE id='" + int.Parse(id.Text) + "'";

            string MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=graama";
            MySqlConnection databaseconn = new MySqlConnection(MYSQLConnectionString);
            MySqlCommand databasecommand = new MySqlCommand(query, databaseconn);
            databasecommand.CommandTimeout = 60;
            try
            {
                databaseconn.Open();
                MySqlDataReader my = databasecommand.ExecuteReader();

                setGrid();
                databaseconn.Close();
                clear();
            }
            catch (Exception ex)
            {

            }
            Form15 k = new Form15();
           k.ShowDialog();
        }
        private void clear()
        {
            nic.Text = "";
            name.Text = "";
            address.Text = "";
            purpose.Text = "";
            des.Text = "";
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM certires WHERE NIC='" + n.Text + "'";
            string MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=graama";
            MySqlConnection databaseconn = new MySqlConnection(MYSQLConnectionString);
            MySqlCommand databasecommand = new MySqlCommand(query, databaseconn);
            MySqlDataAdapter re = new MySqlDataAdapter(query, databaseconn);
            databasecommand.CommandTimeout = 60;
            try
            {
                databaseconn.Open();

                DataTable dtb = new DataTable();
                re.Fill(dtb);
                this.dtb.DataSource = dtb;
                databaseconn.Close();


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void jsushu_Click(object sender, EventArgs e)
        {

        }
    }
}
