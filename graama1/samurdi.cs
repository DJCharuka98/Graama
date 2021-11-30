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
	public partial class samurdi : Form
	{
		public samurdi()
		{
			InitializeComponent();
			scount();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{

		}
		/*private void setGrid()
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
		*/
		private void button2_Click(object sender, EventArgs e)
		{
			//DialogResult confirmPrint = MessageBox.Show("Are you sure you want to print the list?", "Confirm Printing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			//if (confirmPrint == DialogResult.Yes)
			//
			string g = "Receiving";
			string query = "DELETE FROM samurdhi;INSERT INTO samurdhi SELECT family_no,house_no,p_nic,total_inc FROM family WHERE samurdhi_status='" + g + "'";
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
			Form11 ff = new Form11();
			ff.ShowDialog();

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}
		private void scount()
        {
			string iid = "";
			string g = "Receiving";
			string query = "SELECT COUNT(family_no) AS c FROM family WHERE samurdhi_status='" + g + "'";
			string MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=graama";
			MySqlConnection databaseconn = new MySqlConnection(MYSQLConnectionString);
			MySqlCommand databasecommand = new MySqlCommand(query, databaseconn);
			//MySqlDataAdapter re = new MySqlDataAdapter(query, databaseconn);
			databasecommand.CommandTimeout = 60;
			try
			{
				databaseconn.Open();
				MySqlDataReader my = databasecommand.ExecuteReader();

				while (my.Read())
				{
					iid = my.GetString("c");
				}


				label10.Text = iid;
				databaseconn.Close();



			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
			query = "SELECT COUNT(family_no) AS c FROM family";
			 MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=graama";
			databaseconn = new MySqlConnection(MYSQLConnectionString);
			 databasecommand = new MySqlCommand(query, databaseconn);
			//MySqlDataAdapter re = new MySqlDataAdapter(query, databaseconn);
			databasecommand.CommandTimeout = 60;
			try
			{
				databaseconn.Open();
				MySqlDataReader my = databasecommand.ExecuteReader();

				while (my.Read())
				{
					iid = my.GetString("c");
				}


				label1.Text = iid;
				databaseconn.Close();



			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
			float per = (float.Parse(label10.Text) / float.Parse(label1.Text))* 100;
			label11.Text = per.ToString()+"%";
		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			mahapola m = new mahapola();
			m.ShowDialog();
		}

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
			this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
			setGrid();
        }
		private void setGrid()
        {

			string g = "Receiving";
			string query = "SELECT * FROM family WHERE samurdhi_status='" + g + "'";
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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

		private void button4_Click(object sender, EventArgs e)
        {
			float above = 0;
			float below = 0;
			string query = "";
			if(ismoney(a.Text) && b.Text=="")
            {
				above = float.Parse(a.Text);

				 query = "SELECT * FROM family WHERE total_inc>='" + above + "'";
				string MYSQLConnectionStrin = "datasource=127.0.0.1;port=3306;username=root;password=;database=graama";
				MySqlConnection databasecon = new MySqlConnection(MYSQLConnectionStrin);
				MySqlCommand databasecomman = new MySqlCommand(query, databasecon);
				MySqlDataAdapter ree = new MySqlDataAdapter(query, databasecon);
				databasecomman.CommandTimeout = 60;
				try
				{
					databasecon.Open();

					DataTable dtb = new DataTable();
					ree.Fill(dtb);
					this.dtb.DataSource = dtb;
					databasecon.Close();


				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			else if (ismoney(b.Text) && a.Text == "")
			{
				below = float.Parse(b.Text);

				query = "SELECT * FROM family WHERE total_inc<='" + below + "'";
				string MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=graama";
				MySqlConnection databaseconn = new MySqlConnection(MYSQLConnectionString);
				MySqlCommand databasecommand = new MySqlCommand(query, databaseconn);
				MySqlDataAdapter reee = new MySqlDataAdapter(query, databaseconn);
				databasecommand.CommandTimeout = 60;
				try
				{
					databaseconn.Open();

					DataTable dtb = new DataTable();
					reee.Fill(dtb);
					this.dtb.DataSource = dtb;
					databaseconn.Close();


				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			else if (ismoney(b.Text) && ismoney(a.Text))
			{
				below = float.Parse(b.Text);
				above = float.Parse(a.Text);


				query = "SELECT * FROM family WHERE total_inc<='" + below + "' AND total_inc>='" + above + "'";
				string MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=graama";
				MySqlConnection databaseconn = new MySqlConnection(MYSQLConnectionString);
				MySqlCommand databasecommand = new MySqlCommand(query, databaseconn);
				MySqlDataAdapter reee = new MySqlDataAdapter(query, databaseconn);
				databasecommand.CommandTimeout = 60;
				try
				{
					databaseconn.Open();

					DataTable dtb = new DataTable();
					reee.Fill(dtb);
					this.dtb.DataSource = dtb;
					databaseconn.Close();


				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			else
            {
				MessageBox.Show("Invalid income details!");
            }

		}

        private void button3_Click(object sender, EventArgs e)
        {
			if (name.Checked == true)
			{
				string query = "SELECT first_name,last_name,NIC,person.family_no,family.house_no,total_inc AS family_income,samurdhi_status FROM person INNER JOIN family ON family.family_no=person.family_no WHERE person.first_name='" + text.Text + "'";
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
				
				string query = "SELECT first_name,last_name,NIC,person.family_no,family.house_no,total_inc AS family_income,samurdhi_status FROM person INNER JOIN family ON family.family_no=person.family_no WHERE person.NIC='" + text.Text + "'";
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
    }
}
