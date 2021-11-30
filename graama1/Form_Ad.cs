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
    public partial class Form_Ad : Form
    {
        

        private void setGrid()

        {
            string query = "SELECT * FROM admin_info";
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
                dataGridView1.DataSource = dtb;
                databaseconn.Close();


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public Form_Ad()
        {
            InitializeComponent();
            setGrid();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuMetroTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }
        private void addOfficer()
        {
            string regg = reg.Text;
            string namee = name.Text;
            string userr = user.Text;
            string pass = password.Text;
            string datee = date.Value.ToString("yyyy-MM-dd");
            string query = "INSERT INTO admin_info (reg_no,name,username,password,joined_date) VALUES ('" + regg + "','" + namee + "','" + userr + "','" + pass + "','" + datee + "');";
            if (regg=="" || namee=="" || userr=="" || pass=="")
            {
                MessageBox.Show("Invalid details!");
                return;
            }
            else
            {
                string MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=graama";
                MySqlConnection databaseconn = new MySqlConnection(MYSQLConnectionString);
                MySqlCommand databasecommand = new MySqlCommand(query, databaseconn);
                databasecommand.CommandTimeout = 60;
                try
                {
                    databaseconn.Open();
                    MySqlDataReader my = databasecommand.ExecuteReader();
                    MessageBox.Show("Data added succesfully!");
                    databaseconn.Close();
                    setGrid();
                    clearOfficer();
                }
                catch(Exception e)
                {
                    MessageBox.Show("Error occured!");
                    clearOfficer();
                }

            }

        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            addOfficer();
        }

        private void bunifuMetroTextbox3_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
        private void deleteOfficer()
        {
            if (reg.Text == "")
            {
                MessageBox.Show("Error! RegisterNo field is empty!");
            }
            else
            {
                string query = "DELETE FROM admin_info WHERE reg_no='" + reg.Text + "'";
                string MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=graama";
                MySqlConnection databaseconn = new MySqlConnection(MYSQLConnectionString);
                MySqlCommand databasecommand = new MySqlCommand(query, databaseconn);
                databasecommand.CommandTimeout = 60;
                try
                {
                    databaseconn.Open();
                    MySqlDataReader my = databasecommand.ExecuteReader();
                    MessageBox.Show("Details are deleted Succesfully!");
                    
                    databaseconn.Close();
                    setGrid();
                    clearOfficer();


                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                    clearOfficer();
                }
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            deleteOfficer();
        }
        private void updateOfficer()
        {
            string regg = reg.Text;
            string namee = name.Text;
            string userr = user.Text;
            string pass = password.Text;
            string datee = date.Value.ToString("yyyy-MM-dd");
           // string query = "UPDATE admin_info SET (reg_no,name,username,password,joined_date) VALUES ('" + regg + "','" + namee + "','" + userr + "','" + pass + "','" + datee + "');";
            if (regg == "" || namee == "" || userr == "" || pass == "")
            {
                MessageBox.Show("Invalid details!");
                return;
            }

            else
            {
                string query = "UPDATE admin_info SET name='" + namee + "',username='" +userr+ "',password='" + pass + "',joined_date='" + datee + "'WHERE reg_no='" + reg.Text + "'";
                string MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=graama";
                MySqlConnection databaseconn = new MySqlConnection(MYSQLConnectionString);
                MySqlCommand databasecommand = new MySqlCommand(query, databaseconn);
                databasecommand.CommandTimeout = 60;
                try
                {
                    databaseconn.Open();
                    MySqlDataReader my = databasecommand.ExecuteReader();
                    
                    
                        MessageBox.Show("Successfully upadated!");
                        clearOfficer();
                    
                    databaseconn.Close();
                    setGrid();


                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }

        }
        private void searchOfficer()
        {
            if(reg.Text == "")
            {
                MessageBox.Show("Error! RegisterNo field is empty!");
            }
            else
            {
                string query = "SELECT name,username,password,joined_date FROM admin_info WHERE reg_no='" + reg.Text + "'";
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
                            name.Text = my.GetString("name");
                            user.Text = my.GetString("username");
                            password.Text = my.GetString("password");
                            DateTime tdd = Convert.ToDateTime(my.GetString("joined_date"));
                            string t = tdd.ToString("yyyy-MM-dd");
                            date.Value = DateTime.ParseExact(t, "yyyy-M-d", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None);


                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Register Number!");
                        clearOfficer();
                    }
                    databaseconn.Close();
                    setGrid();


                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
        }
        private void clearOfficer()
        {
            reg.Text = "";
            name.Text = "";
            user.Text = "";
            password.Text = "";
            DateTime today = DateTime.UtcNow.Date;
            string td = today.ToString("yyyy-MM-dd");
            date.Value = DateTime.ParseExact(td, "yyyy-M-d", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            searchOfficer();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            clearOfficer();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            updateOfficer();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            string query = "SELECT GND_code,GND_name,division,district FROM village LIMIT 1";
            string MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=graama";
            MySqlConnection databaseconn = new MySqlConnection(MYSQLConnectionString);
            MySqlCommand databasecommand = new MySqlCommand(query, databaseconn);
            databasecommand.CommandTimeout = 60;
            databaseconn.Open();
            MySqlDataReader my = databasecommand.ExecuteReader();
            while (my.Read())
            {
                gnd_code.Text = my.GetString("GND_code");
                gnd_name.Text = my.GetString("GND_name");
                div.Text = my.GetString("division");
                dis.Text = my.GetString("district");


            }
            databaseconn.Close();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {   if(gnd_code.Text=="" || gnd_name.Text=="" || div.Text=="" || dis.Text=="")
            {
                MessageBox.Show("Invalid details!");
                return;
            }
            try
            {
                string query = "DELETE FROM village";
                string MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=graama";
                MySqlConnection databaseconn = new MySqlConnection(MYSQLConnectionString);
                MySqlCommand databasecommand = new MySqlCommand(query, databaseconn);
                databasecommand.CommandTimeout = 60;
                databaseconn.Open();
                MySqlDataReader my = databasecommand.ExecuteReader();
                databaseconn.Close();

                query = "INSERT INTO village (GND_code,GND_name,division,district) VALUES ('" + gnd_code.Text + "','" + gnd_name.Text + "','" + div.Text + "','" + dis.Text + "');";
                MySqlCommand databasecomman = new MySqlCommand(query, databaseconn);
                databasecommand.CommandTimeout = 60;
                databaseconn.Open();
                my = databasecomman.ExecuteReader();
                databaseconn.Close();
                MessageBox.Show("Village information are Succesfully Updated!");
                gnd_code.Text = "";
                gnd_name.Text = "";
                div.Text = "";
                dis.Text = "";
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            gnd_code.Text = "";
            gnd_name.Text = "";
            div.Text = "";
            dis.Text = "";
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
