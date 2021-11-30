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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            setGrid();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            List<string> error = new List<string>();
            string r = "";
            string w = "";
            string f = "";
            int to = 0;

            if (!fno(house.Text))
            {
                error.Add("house no");
            }
            if (inv(location.Text))
            {
                error.Add("location");
            }
            if (roof.SelectedIndex > -1)
            {
                r = roof.SelectedItem.ToString();
            }
            else
            {
                error.Add("roof");
            }
            if (wall.SelectedIndex > -1)
            {
                w = wall.SelectedItem.ToString();
            }
            else
            {
                error.Add("wall");
            }
            if (floor.SelectedIndex > -1)
            {
                f = floor.SelectedItem.ToString();
            }
            else
            {
                error.Add("floor");
            }
            if (t.SelectedIndex > -1)
            {
                to = int.Parse(t.SelectedItem.ToString());
            }
            else
            {
                error.Add("toilet");
            }
            if (error.Any())
            {
                string msg = "";
                foreach (var m in error)
                {
                    msg = msg + m + ",";
                }
                MessageBox.Show("Invalid " + msg + " details");

                return;
            }
            else
            {




                //---------------------------------------------------------------------------

                string query = "UPDATE house SET location='" + location.Text + "',roof_type='" + r + "',wall_type='" + w + "',floor_type='" + f + "',toilet_fac='" + to + "'WHERE house_no='" + int.Parse(house.Text) + "'";
                string MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=graama";
                MySqlConnection databaseconn = new MySqlConnection(MYSQLConnectionString);
                MySqlCommand databasecommand = new MySqlCommand(query, databaseconn);
                MySqlDataAdapter re = new MySqlDataAdapter(query, databaseconn);
                databasecommand.CommandTimeout = 60;
                try
                {
                    databaseconn.Open();
                    MySqlDataReader my = databasecommand.ExecuteReader();
                    MessageBox.Show("Data Updated succesfully!");
                    setGrid();
                    databaseconn.Close();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }





            }
        }
        private bool fno(string name)
        {
            string reg = @"^[0-9]+$";
            Regex re = new Regex(reg);
            if (re.IsMatch(name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool inv(string name)
        {
            if (name == "")
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
            string query = "SELECT * FROM house";
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
       private void clear()
        {
            house.Text = "";
            location.Text = "";
            roof.SelectedIndex = -1;
            wall.SelectedIndex = -1;
            floor.SelectedIndex = -1;
            t.SelectedIndex = -1;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            List<string> error = new List<string>();
            string r = "";
            string w = "";
            string f = "";
            int to = 0;

            if (!fno(house.Text))
            {
                error.Add("house no");
            }
            if(inv(location.Text))
            {
                error.Add("location");
            }
            if (roof.SelectedIndex > -1)
            {
                r = roof.SelectedItem.ToString();
            }
            else
            {
                error.Add("roof");
            }
            if (wall.SelectedIndex > -1)
            {
                w = wall.SelectedItem.ToString();
            }
            else
            {
                error.Add("wall");
            }
            if (floor.SelectedIndex > -1)
            {
                f= floor.SelectedItem.ToString();
            }
            else
            {
                error.Add("floor");
            }
            if (t.SelectedIndex > -1)
            {
                to = int.Parse(t.SelectedItem.ToString());
            }
            else
            {
                error.Add("toilet");
            }
            if (error.Any())
            {
                string msg = "";
                foreach (var m in error)
                {
                    msg = msg + m + ",";
                }
                MessageBox.Show("Invalid " + msg + " details");

                return;
            }
            else
            {
               

                string query = "SELECT * FROM house WHERE house_no='" + int.Parse(house.Text) + "'";
                //string query= "UPDATE person SET first_name='" + firstt + "',last_name='" + lastt + "',address='" + addres + "',NIC='" + ni + "',DOB='" + birth + "',joined_date='" + joinn + "',gender='" + gend + "',nation='" + nat + "',religion='" + reli + "',family_no='" + fam + "',house_no='" + housee + "'WHERE id='" + int.Parse(id.Text) + "'";

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
                        MessageBox.Show("Error..Duplicate entry for same house number!");
                    }
                    else
                    {

                        //---------------------------------------------------------------------------

                        query = "INSERT INTO house(house_no,location,roof_type,wall_type,floor_type,toilet_fac) VALUES ('" + int.Parse(house.Text) + "','" + location.Text + "','" + r + "','" + w + "','" + f + "','" + to + "');";
                        //string query= "UPDATE person SET first_name='" + firstt + "',last_name='" + lastt + "',address='" + addres + "',NIC='" + ni + "',DOB='" + birth + "',joined_date='" + joinn + "',gender='" + gend + "',nation='" + nat + "',religion='" + reli + "',family_no='" + fam + "',house_no='" + housee + "'WHERE id='" + int.Parse(id.Text) + "'";

                        MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=graama";
                        databaseconn = new MySqlConnection(MYSQLConnectionString);
                        databasecommand = new MySqlCommand(query, databaseconn);
                        databasecommand.CommandTimeout = 60;
                        try
                        {
                            databaseconn.Open();
                            my = databasecommand.ExecuteReader();
                            MessageBox.Show("Data added succesfully!");
                            setGrid();
                            databaseconn.Close();
                            clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }





                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }


        }

        private void dtb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtb.Rows[e.RowIndex];
                
                house.Text = row.Cells["house_no"].Value.ToString();

                location.Text = row.Cells["location"].Value.ToString();

                roof.Text = row.Cells["roof_type"].Value.ToString();
                wall.Text = row.Cells["wall_type"].Value.ToString();
                floor.Text = row.Cells["floor_type"].Value.ToString();
                t.Text = row.Cells["toilet_fac"].Value.ToString();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM nofac;INSERT INTO nofac SELECT house_no,location FROM house WHERE toilet_fac=0;";
            string MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=graama";
            MySqlConnection databaseconn = new MySqlConnection(MYSQLConnectionString);
            MySqlCommand databasecommand = new MySqlCommand(query, databaseconn);
            databasecommand.CommandTimeout = 60;
            try
            {
                databaseconn.Open();
                MySqlDataReader my = databasecommand.ExecuteReader();
                databaseconn.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Form8 f8 = new Form8();
            f8.ShowDialog();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form9 f8 = new Form9();
            f8.ShowDialog();
            
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (fno(house.Text))
            {
                string query = "SELECT * FROM house WHERE house_no='" + house.Text + "'";
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
                            house.Text = my.GetString("house_no");
                            location.Text = my.GetString("location");
                            roof.Text = my.GetString("roof_type");
                            wall.Text = my.GetString("wall_type");
                            floor.Text = my.GetString("floor_type");
                            t.Text = my.GetString("toilet_fac");

                        }
                    }
                    else
                    {
                        MessageBox.Show("No House Number called " + house.Text + "");
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
                MessageBox.Show("House No is invalid!");
                clear();

            }
        }
    }
}
