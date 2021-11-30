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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (us.Text.Trim() != "" || pa.Text.Trim() != "")
            {
                string p = "no";
                string reg = "";
                string name = "";
                string query = "SELECT reg_no,name,password FROM admin_info WHERE username='" + us.Text + "'";
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

                        p = my.GetString("password");
                       reg = my.GetString("reg_no");
                        name = my.GetString("name");

                    }

                    databaseconn.Close();
                }
                catch (Exception w)
                {
                    MessageBox.Show("Error occured");
                }
                if(pa.Text==p)
                {
                    Form1 f = new Form1(name,reg);
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
            }
            else
            {
                MessageBox.Show("Empty username or password");
            }



        }

        private void PanelLeft_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
