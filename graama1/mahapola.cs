using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace graama1
{
	public partial class mahapola : Form
	{
		public mahapola()
		{
			InitializeComponent();
			mcount();
		}

		private void mahapola_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			//DialogResult confirmPrint = MessageBox.Show("Are you sure you want to print the list?", "Confirm Printing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			string g = "Yes";
			string query = "DELETE FROM mahapola;INSERT INTO mahapola SELECT first_name,last_name,NIC,person.family_no,total_inc,university FROM person INNER JOIN uni_student ON person.id=uni_student.person_id INNER JOIN family ON person.family_no=family.family_no WHERE uni_student.mahapola_status='" + g + "'";
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
			catch (Exception ee)
			{
				MessageBox.Show(ee.Message);
			}
			Form10 f = new Form10();
			f.ShowDialog();
		}
		private void setGrid()
		{
			string g = "Yes";
			string query = "SELECT first_name,last_name,NIC,person.family_no,total_inc AS family_income,university FROM person INNER JOIN uni_student ON person.id=uni_student.person_id INNER JOIN family ON person.family_no=family.family_no WHERE uni_student.mahapola_status='" + g + "'";
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

		private void button1_Click(object sender, EventArgs e)
        {
			setGrid();
			/*foreach(DataGridViewColumn c in dtb.Columns)
            {
				c.DefaultCellStyle.Font = new Font("Arial", 8.5F, GraphicsUnit.Pixel);
            }*/
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
		private void mcount()
        {
			string g = "Yes";
			string iid = "";
			string query = "SELECT Count(person.id) As c FROM person INNER JOIN uni_student ON person.id=uni_student.person_id INNER JOIN family ON person.family_no=family.family_no WHERE uni_student.mahapola_status='" + g + "'";
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
					iid = my.GetString("c");
				}

				databaseconn.Close();
				l.Text = iid;


			}
			catch(Exception ee)
            {
				MessageBox.Show(ee.Message);
            }

		}

        private void button3_Click(object sender, EventArgs e)
        {
			if(name.Checked==true)
            {
				string g = "Yes";
				string query = "SELECT first_name,last_name,NIC,person.family_no,total_inc AS family_income,university FROM person INNER JOIN uni_student ON person.id=uni_student.person_id INNER JOIN family ON person.family_no=family.family_no WHERE uni_student.mahapola_status='" + g + "' AND first_name='" + text.Text + "'";
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
			else if (nic.Checked == true)
			{
				string g = "Yes";
				string query = "SELECT first_name,last_name,NIC,person.family_no,total_inc AS family_income,university FROM person INNER JOIN uni_student ON person.id=uni_student.person_id INNER JOIN family ON person.family_no=family.family_no WHERE uni_student.mahapola_status='" + g + "' AND NIC='" + text.Text + "'";
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

		}

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
			this.Hide();
        }
    }
}
