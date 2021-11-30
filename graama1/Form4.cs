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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            setGrid();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

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
        private bool ismoney(string name)
        {
            string reg = @"^[0-9]+\.{0,1}[0-9]*$";
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


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            int fam=0;
            int hou=0;
            string sam="";
            string nic="";
            float r=0;
            float mo=0;
            float t=0;



            List<string> error = new List<string>();
            if(family.Text=="" || fno(family.Text)!=true)
            {
                error.Add("Family no");
            }
            if (house.Text == "" || fno(house.Text) != true)
            {
                error.Add("House no");
            }
            if (pa.Text == "" || validnic(pa.Text) != true)
            {
                error.Add("NIC");
            }
            if (real.Text == "" || ismoney(real.Text) != true)
            {
                error.Add("Real income");
            }
            if (s.SelectedIndex > -1)
            {
                sam = s.SelectedItem.ToString();
            }
            else
            {
                error.Add("Gender ");
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
                fam = int.Parse(family.Text);
                hou = int.Parse(house.Text);
                nic = pa.Text;
                r = float.Parse(real.Text);
                mo = float.Parse(money.Text);
                t = float.Parse(total.Text);
                
                string query = "SELECT * FROM family WHERE family_no='" + fam + "'";
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
                        MessageBox.Show("Error..Duplicate entry for same family number!");
                    }
                    else
                    {

                        //---------------------------------------------------------------------------

                        query = "INSERT INTO family(family_no,samurdhi_status,house_no,p_nic,real_inc,money_inc,total_inc) VALUES ('" + fam + "','" + sam + "','" + hou + "','" + nic + "','" + r + "','" + mo + "','" + t + "');";
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
                            MessageBox.Show("House number is not valid! Please Add the details regarding to the house number..");
                        }





                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }

        }
        private void setGrid()

        {
            string query = "SELECT * FROM family";
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

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void family_TextChanged(object sender, EventArgs e)
        {

        }

        private void family_Leave(object sender, EventArgs e)
        {
            float k = 0;
            int fam = 0;
            if(fno(family.Text))
            {
                 fam = int.Parse(family.Text);

                string query = "SELECT SUM(job_income) AS o FROM employee INNER JOIN (SELECT id FROM person WHERE family_no='" + fam + "') as d ON employee.person_id=d.id";
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
                            money.Text = my.GetString("o");
                            


                        }
                    }
                    else
                    {
                       money.Text = "0";
                    }
                    databaseconn.Close();
                    


                }
                catch (Exception er)
                {
                    money.Text = "0";
                }

            }
        }

        private void real_Leave(object sender, EventArgs e)
        {   if (ismoney(money.Text) && ismoney(real.Text))
            {
                float k = float.Parse(money.Text);
                float s = float.Parse(real.Text);
                float t = k + s;
                total.Text = t.ToString();
            }

        }

        private void dtb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtb.Rows[e.RowIndex];
                family.Text = row.Cells["family_no"].Value.ToString();
                house.Text = row.Cells["house_no"].Value.ToString();
                
                pa.Text = row.Cells["p_nic"].Value.ToString();

                money.Text = row.Cells["money_inc"].Value.ToString();
                real.Text = row.Cells["real_inc"].Value.ToString();
                total.Text = row.Cells["total_inc"].Value.ToString();
                s.Text = row.Cells["samurdhi_status"].Value.ToString();
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (family.Text == "")
            {
                MessageBox.Show("Error! id field is empty!");
            }
            else
            {
                string query = "DELETE FROM family WHERE family_no='" + int.Parse(family.Text) + "'";
                string MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=graama";
                MySqlConnection databaseconn = new MySqlConnection(MYSQLConnectionString);
                MySqlCommand databasecommand = new MySqlCommand(query, databaseconn);
                MySqlDataAdapter re = new MySqlDataAdapter(query, databaseconn);
                databasecommand.CommandTimeout = 60;
                try
                {
                    databaseconn.Open();
                    MySqlDataReader my = databasecommand.ExecuteReader();
                    MessageBox.Show("Data Deleted succesfully!");
                    databaseconn.Close();
                    setGrid();
                    clear();


                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            int fam = 0;
            int hou = 0;
            string sam = "";
            string nic = "";
            float r = 0;
            float mo = 0;
            float t = 0;



            List<string> error = new List<string>();
            if (family.Text == "" || fno(family.Text) != true)
            {
                error.Add("Family no");
            }
            if (house.Text == "" || fno(house.Text) != true)
            {
                error.Add("House no");
            }
            if (pa.Text == "" || validnic(pa.Text) != true)
            {
                error.Add("NIC");
            }
            if (real.Text == "" || ismoney(real.Text) != true)
            {
                error.Add("Real income");
            }
            if (s.SelectedIndex > -1)
            {
                sam = s.SelectedItem.ToString();
            }
            else
            {
                error.Add("Gender ");
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
                fam = int.Parse(family.Text);
                hou = int.Parse(house.Text);
                nic = pa.Text;
                r = float.Parse(real.Text);
                mo = float.Parse(money.Text);
                t = float.Parse(total.Text);
                Console.WriteLine(fam);
                Console.WriteLine(hou);
                Console.WriteLine(nic);
                Console.WriteLine(sam);
               // string query = "SELECT * FROM family WHERE family_no='" + fam + "'";
                string query= "UPDATE family SET house_no='" + hou + "',samurdhi_status='" + sam + "',p_nic='" + nic + "',real_inc='" + r + "',money_inc='" + mo + "',total_inc='" + t + "'WHERE family_no='" + int.Parse(family.Text) + "'"; 

                string MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=graama";
                MySqlConnection databaseconn = new MySqlConnection(MYSQLConnectionString);
                MySqlCommand databasecommand = new MySqlCommand(query, databaseconn);
                databasecommand.CommandTimeout = 60;
                try
                {
                    databaseconn.Open();
                    MySqlDataReader my = databasecommand.ExecuteReader();
                    MessageBox.Show("Successfully Updated!");
                    setGrid();
                    databaseconn.Close();
                    clear();
                   


                    
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            family.Text = "";
            house.Text = "";
            pa.Text = "";
            real.Text = "";
            money.Text = "";
            total.Text = "";
            s.SelectedIndex = -1;
        }
        private void clear()
        {
            family.Text = "";
            house.Text = "";
            pa.Text = "";
            real.Text = "";
            money.Text = "";
            total.Text = "";
            s.SelectedIndex = -1;
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {   
           
            Form5 f5 = new Form5();
            f5.ShowDialog();

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {   if (h.Text == "" && f.Text == "")
            {
                setGrid();
            }
            else if (fno(h.Text) && f.Text == "")
            {
                string query = "SELECT family_no,p_nic,total_inc,samurdhi_status FROM family WHERE house_no='" + int.Parse(h.Text) + "'";

                string MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=graama";
                MySqlConnection databaseconn = new MySqlConnection(MYSQLConnectionString);

                MySqlDataAdapter re = new MySqlDataAdapter(query, databaseconn);

                try
                {

                    databaseconn.Open();
                    DataTable dtb = new DataTable();
                    re.Fill(dtb);
                    this.dtb.DataSource = dtb;
                    databaseconn.Close();
                    clear();




                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
            else if ((fno(f.Text) && h.Text == "") || (fno(f.Text) && fno(h.Text)))
            {
                string query = "SELECT family_no,house_no,NIC,TIMESTAMPDIFF(YEAR,DOB,CURDATE()) AS age,job_type,job_income FROM person LEFT JOIN employee ON person.id=employee.person_id  WHERE family_no='" + int.Parse(f.Text) + "'";

                string MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=graama";
                MySqlConnection databaseconn = new MySqlConnection(MYSQLConnectionString);

                MySqlDataAdapter re = new MySqlDataAdapter(query, databaseconn);

                try
                {

                    databaseconn.Open();
                    DataTable dtb = new DataTable();
                    re.Fill(dtb);
                    this.dtb.DataSource = dtb;
                    databaseconn.Close();
                    clear();




                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }

        }

        private void real_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (fno(family.Text))
            {
                string query = "SELECT * FROM family WHERE family_no='" + family.Text + "'";
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
                        house.Text = my.GetString("house_no");
                        pa.Text = my.GetString("p_nic");
                        real.Text = my.GetString("real_inc");
                        money.Text = my.GetString("money_inc");
                        total.Text = my.GetString("total_inc");
                        s.Text= my.GetString("samurdhi_status");

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
                house.Text = "";
                pa.Text = "";
                s.SelectedIndex = -1;
                real.Text = "";
                money.Text = "";
                total.Text = "";

            }
        }
    }
}
