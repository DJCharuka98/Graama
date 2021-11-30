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
    public partial class Form2 : Form
    {
        public DataTable dttb;
        public Form2()
        {
            InitializeComponent();
            setGrid();
            this.dttb=new DataTable();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (first.Text == "")
            {
                first.Text = "First Name";
                first.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

            if (first.Text == "First Name")
            {
                first.Text = "";
                first.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {

            if (last.Text == "Last Name")
            {
                last.Text = "";
                last.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (last.Text == "")
            {
                last.Text = "Last Name";
                last.ForeColor = Color.Gray;
            }
        }

       

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel11_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel12_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel16_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel17_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (address.Text == "Address Line 1")
            {
                address.Text = "";
                address.ForeColor = Color.Black;
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (address.Text == "")
            {
                address.Text = "Address Line 1";
                address.ForeColor = Color.Gray;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (telephone.Text == "T.P")
            {
                telephone.Text = "";
                telephone.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (telephone.Text == "")
            {
                telephone.Text = "T.P";
                telephone.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (mobile.Text == "Mobile")
            {
                mobile.Text = "";
                mobile.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (mobile.Text == "")
            {
                mobile.Text = "Mobile";
                mobile.ForeColor = Color.Gray;
            }
        }

        private void textBox10_Enter(object sender, EventArgs e)
        {
            if (gname.Text == "Guardian Name")
            {
                gname.Text = "";
                gname.ForeColor = Color.Black;
            }
        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            if (gname.Text == "")
            {
                gname.Text = "Guardian Name";
                gname.ForeColor = Color.Gray;
            }
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            if (gnic.Text == "Guardian NIC")
            {
                gnic.Text = "";
                gnic.ForeColor = Color.Black;
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {

            if (gnic.Text == "")
            {
                gnic.Text = "Guardian NIC";
                gnic.ForeColor = Color.Gray;
            }
        }

        private void textBox11_Enter(object sender, EventArgs e)
        {
            if (school.Text == "School")
            {
                school.Text = "";
                school.ForeColor = Color.Black;
            }
        }

        private void textBox11_Leave(object sender, EventArgs e)
        {
            if (school.Text == "")
            {
                school.Text = "School";
                school.ForeColor = Color.Gray;
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for(int ix=0;ix<gender.Items.Count;ix++)
            {
                if(ix!=e.Index)
                {
                    gender.SetItemChecked(ix, false);
                }
            }
        }

        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < marry.Items.Count; ix++)
            {
                if (ix != e.Index)
                {
                    marry.SetItemChecked(ix, false);
                }
            }
        }

        private void checkedListBox4_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < gov.Items.Count; ix++)
            {
                if (ix != e.Index)
                {
                    gov.SetItemChecked(ix, false);
                }
            }
        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (id.Text == "")
            {
                MessageBox.Show("Error! Duplicate Entry for same id!");
                return;
            }
            List<String> list = new List<String>();
            string gend = "", nat = "", reli = "";

            string firstt = first.Text;
            string lastt = last.Text;
            string addres = address.Text;
            string tp = telephone.Text;
            string mobil = mobile.Text;

            if (!validname(lastt) || !validname(firstt))
            {
                list.Add("name ");
            }
            if (invalidaddress(addres))
            {
                list.Add("address ");
            }
            if (isvalidphone(tp) == false || isvalidphone(mobil) == false)
            {
                list.Add("Phone ");
            }
            string birth = dob.Value.ToString("yyyy-MM-dd");
            string joinn = join.Value.ToString("yyyy-MM-dd");
            string ni = nic.Text;
            if (gender.SelectedIndex > -1)
            {
                gend = gender.SelectedItem.ToString();
            }
            else
            {
                list.Add("Gender ");
            }
            DateTime birthh = dob.Value;
            DateTime today = DateTime.UtcNow.Date;
            TimeSpan diff = today.Subtract(birthh);
            var agee = (int)diff.Days / 365;
            if (!validnic(ni))
            {
                if (agee >= 18)
                {
                    list.Add("NIC ");
                }
            }
            string housee = house.Text;
            string fam = family.Text;

            if (!fno(fam) || !fno(housee))
            {
                list.Add("HouseNo or FamilyNo ");
            }
            string gen = getSelectItem(gender);
            if (nation.SelectedIndex > -1)
            {
                nat = nation.SelectedItem.ToString();
            }
            else
            {
                list.Add("nation ");
            }
            if (religion.SelectedIndex > -1)
            {
                reli = religion.SelectedItem.ToString();
            }
            else
            {
                list.Add("religion ");
            }

            string g_name = "";
            string g_nic = "";
            string sch = "";
            string v = "";
            string mar = "";
            float jin = 0;
            float oin = 0;
            string go = "";
            string un = "";
            string mahp = "";

            if (agee <= 18)
            {
                g_name = gname.Text;
                g_nic = gnic.Text;
                sch = school.Text;
                if (!validnic(g_nic))
                {

                    list.Add("guardian NIC ");

                }
                if (!validgname(g_name))
                {
                    list.Add("Guardian Name ");
                }
                if (sch == "School")
                {
                    sch = "";
                }
            }

            else
            {
                v = getSelectItem(vote);
                mar = getSelectItem(marry);
                if (emp.GetItemCheckState(0) == CheckState.Checked)
                {

                    if (ismoney(jincome.Text))
                    {
                        jin = float.Parse(jincome.Text);

                    }
                    else
                    {
                        list.Add("income ");
                    }
                    go = getSelectItem(gov);
                }
                if (ismoney(oincome.Text))
                {
                    oin = float.Parse(oincome.Text);

                }

                if (stu.GetItemCheckState(0) == CheckState.Checked)
                {

                    un = uni.Text;
                    if (mahapola.SelectedIndex > -1)
                    {
                        mahp = mahapola.SelectedItem.ToString();
                    }
                    else
                    {
                        list.Add("mahapola ");
                    }
                }

            }



            if (list.Any())
            {
                string msg = "";
                foreach (var m in list)
                {
                    msg = msg + m + ",";
                }
                MessageBox.Show("Invalid " + msg + " details");

                return;
            }
            else
            {
               
                var nv = DBNull.Value;
                if (agee < 16)
                {
                    ni = "";
                }
                //string query = "INSERT INTO person(id,first_name,last_name,address,NIC,DOB,joined_date,gender,nation,religion,family_no,house_no) VALUES ('" +nv+ "','" + firstt + "','" + lastt + "','" + addres + "','" + ni + "','" + birth + "','" + joinn + "','" + gend + "','" + nat + "','" + reli + "','" + fam+ "','" + housee + "');";
                string query = "UPDATE person SET first_name='" + firstt + "',last_name='" + lastt + "',address='" + addres + "',NIC='" + ni + "',DOB='" + birth + "',joined_date='" + joinn + "',gender='" + gend + "',nation='" + nat + "',religion='" + reli + "',family_no='" + fam + "',house_no='" + housee + "'WHERE id='" + int.Parse(id.Text) + "'";

                string MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=graama";
                MySqlConnection databaseconn = new MySqlConnection(MYSQLConnectionString);
                MySqlCommand databasecommand = new MySqlCommand(query, databaseconn);
                databasecommand.CommandTimeout = 60;
                try
                {
                    databaseconn.Open();
                    MySqlDataReader my = databasecommand.ExecuteReader();
                   
                    databaseconn.Close();

                    databasecommand = new MySqlCommand("SELECT * FROM person ORDER BY id DESC LIMIT 1;", databaseconn);
                    databasecommand.CommandTimeout = 60;
                    databaseconn.Open();
                    my = databasecommand.ExecuteReader();
                    string iid = "";
                    while (my.Read())
                    {
                        iid = my.GetString("id");
                    }
                    databaseconn.Close();
                    Console.WriteLine(iid);
                    if (agee <= 18)
                    {
                        // query = "INSERT INTO child(person_id,guardian_name,guardian_NIC,school) VALUES ('" + iid + "','" + g_name + "','" + g_nic + "','" + sch + "');";
                        query = "UPDATE child SET guardian_name='" + g_name + "',guardian_NIC='" + g_nic + "',school='" + sch + "'WHERE person_id='" + int.Parse(id.Text) + "'";
                        databasecommand = new MySqlCommand(query, databaseconn);
                        databasecommand.CommandTimeout = 60;
                        databaseconn.Open();
                        my = databasecommand.ExecuteReader();
                        databaseconn.Close();

                    }
                    else if (agee > 18)
                    {
                        //query = "INSERT INTO adult(person_id,married_status,vote_status) VALUES ('" + iid + "','" + mar + "','" + v + "');";
                        query = "UPDATE adult SET married_status='" + mar + "',vote_status='" + v + "'WHERE person_id='" + int.Parse(id.Text) + "'";

                        databasecommand = new MySqlCommand(query, databaseconn);
                        databasecommand.CommandTimeout = 60;
                        databaseconn.Open();
                        my = databasecommand.ExecuteReader();
                        databaseconn.Close();
                        if (emp.GetItemCheckState(0) == CheckState.Checked)
                        {

                            //query = "INSERT INTO employee(person_id,job_type,job_income,other_income) VALUES ('" + iid + "','" + go + "','" + jin + "','" + oin + "');";
                            query = "UPDATE employee SET job_type='" + go + "',job_income='" + jin + "',other_income='" + oin + "'WHERE person_id='" + int.Parse(id.Text) + "'";
                            databasecommand = new MySqlCommand(query, databaseconn);
                            databasecommand.CommandTimeout = 60;
                            databaseconn.Open();
                            my = databasecommand.ExecuteReader();
                            databaseconn.Close();
                        }

                        if (emp.GetItemCheckState(1) == CheckState.Checked)
                        {

                            //query = "INSERT INTO unemployee(person_id,other_income) VALUES ('" + iid + "','" + oin + "');";
                            query = "UPDATE unemployee SET other_income='" + oin + "'WHERE person_id='" + int.Parse(id.Text) + "'";
                            databasecommand = new MySqlCommand(query, databaseconn);
                            databasecommand.CommandTimeout = 60;
                            databaseconn.Open();
                            my = databasecommand.ExecuteReader();
                            databaseconn.Close();
                        }
                        if (stu.GetItemCheckState(0) == CheckState.Checked)
                        {

                            //query = "INSERT INTO uni_student(person_id,university,mahapola_status) VALUES ('" + iid + "','" + un + "','" + mahp + "');";
                            query = "UPDATE uni_student SET university='" + un + "',mahapola_status='" + mahp + "'WHERE person_id='" + int.Parse(id.Text) + "'";
                            databasecommand = new MySqlCommand(query, databaseconn);
                            databasecommand.CommandTimeout = 60;
                            databaseconn.Open();
                            my = databasecommand.ExecuteReader(); 
                            databaseconn.Close();
                        }
                    }
                    if (telephone.Text != "T.P" || mobile.Text != "Mobile")
                    {
                        if (telephone.Text == "T.P") { tp = ""; }
                        if (mobile.Text == "T.P") { mobil = ""; }

                        //query = "INSERT INTO contacts(person_id,telephone_no,mobile_no) VALUES ('" + iid + "','" + tp + "','" + mobil + "');";
                        query = "UPDATE contacts SET telephone_no='" + tp + "',mobile_no='" + mobil + "'WHERE person_id='" + int.Parse(id.Text) + "'";
                        databasecommand = new MySqlCommand(query, databaseconn);
                        databasecommand.CommandTimeout = 60;
                        databaseconn.Open();
                        my = databasecommand.ExecuteReader();
                        databaseconn.Close();
                    }





                    MessageBox.Show("Data updated succesfully!");
                    clear();
                    setGrid();


                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);

                }





            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_Enter(object sender, EventArgs e)
        {
            if (oincome.Text == "0.00")
            {
                oincome.Text = "";
                oincome.ForeColor = Color.Black;
            }
        }

        private void textBox12_Leave(object sender, EventArgs e)
        {
            if (oincome.Text == "")
            {
                oincome.Text = "0.00";
                oincome.ForeColor = Color.Gray;
            }
        }

        private void checkedListBox5_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < vote.Items.Count; ix++)
            {
                if (ix != e.Index)
                {
                    vote.SetItemChecked(ix, false);
                }
            }
        }


        private void checkedListBox3_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < emp.Items.Count; ix++)
            {
                if (ix != e.Index)
                {
                    emp.SetItemChecked(ix, false);
                }
            }
        }

        private void textBox13_Enter(object sender, EventArgs e)
        {

            if (jincome.Text == "0.00")
            {
                jincome.Text = "";
                jincome.ForeColor = Color.Black;
            }
        }

        private void textBox13_Leave(object sender, EventArgs e)
        {
            if (jincome.Text == "")
            {
                jincome.Text = "0.00";
                jincome.ForeColor = Color.Gray;
            }
        }
        private string getSelectItem(CheckedListBox Box)
        {
            string l="";
            for(int i=0;i<Box.Items.Count;i++)
            {
                if(Box.GetItemChecked(i))
                {
                    l = (string)Box.Items[i];
                }
            }
            return l;
        }
        private  bool isvalidphone(string phone)
        {
            if (phone == "T.P" || phone == "Mobile")
            {
                return true;
            }
            else
            {
                string reg = @"^[0][0-9]{9}$";
                Regex re = new Regex(reg);
                if (re.IsMatch(phone))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
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
        private bool validname(string name)
        {   if(name=="First Name" ||name=="Last Name")
            {
                return false;
            }
            string reg = @"^[a-zA-Z]+\W*[a-zA-z]*$";
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
        private bool invalidaddress(string name)
        {
           if(name=="Address Line 1")
            {
                return true;
            }
           else
            {
                return false;
            }
        }
        private bool validgname(string name)
        {
            if(name=="Guardian Name")
            {
                return false;
            }
            else if(!validname(name))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {   if(id.Text!="")
            {
                MessageBox.Show("Error! Duplicate Entry for same id!");
                return;
            }
            List<String> list = new List<String>();
            string gend="", nat="", reli="";

            string firstt = first.Text;
            string lastt = last.Text;
            string addres = address.Text;
            string tp = telephone.Text;
            string mobil = mobile.Text;
            
            if (!validname(lastt) || !validname(firstt))
            {
                list.Add("name ");
            }
            if (invalidaddress(addres))
            {
                list.Add("address ");
            }
            if (isvalidphone(tp)==false || isvalidphone(mobil)==false)
            {
                list.Add("Phone ");
            }
            string birth = dob.Value.ToString("yyyy-MM-dd");
            string joinn=join.Value.ToString("yyyy-MM-dd");
            string ni = nic.Text;
            if (gender.SelectedIndex > -1)
            {
                 gend = gender.SelectedItem.ToString();
            }
            else
            {
                list.Add("Gender ");
            }
            DateTime birthh = dob.Value;
            DateTime today = DateTime.UtcNow.Date;
            TimeSpan diff = today.Subtract(birthh);
            var agee = (int)diff.Days / 365;
            if (!validnic(ni))
            {
                if (agee >= 18)
                {
                    list.Add("NIC ");
                }
            }
            string housee = house.Text;
            string fam = family.Text;

            if (!fno(fam) || !fno(housee))
            {
                list.Add("HouseNo or FamilyNo ");
            }
            string gen = getSelectItem(gender);
            if(nation.SelectedIndex>-1)
            {
                 nat = nation.SelectedItem.ToString();
            }
            else
            {
                list.Add("nation ");
            }
            if (religion.SelectedIndex > -1)
            {
                 reli = religion.SelectedItem.ToString();
            }
            else
            {
                list.Add("religion ");
            }

            string g_name = "";
            string g_nic = "";
            string sch = "";
            string v = "";
            string mar = "";
            float jin = 0;
            float oin = 0;
            string go = "";
            string un = "";
            string mahp = "";

            if (agee <= 18)
            {
                g_name = gname.Text;
                 g_nic = gnic.Text;
                 sch = school.Text;
                if (!validnic(g_nic))
                {

                    list.Add("guardian NIC ");

                }
                if(!validgname(g_name))
                {
                    list.Add("Guardian Name ");
                }
                if(sch=="School")
                {
                    sch = "";
                }
            }

            else
            {
                 v = getSelectItem(vote);
                 mar = getSelectItem(marry);
                if (emp.GetItemCheckState(0) == CheckState.Checked)
                {

                    if (ismoney(jincome.Text))
                    {
                        jin = float.Parse(jincome.Text);
                        
                    }
                    else
                    {
                        list.Add("income ");
                    }
                     go = getSelectItem(gov);
                }
                if (ismoney(oincome.Text))
                {
                     oin = float.Parse(oincome.Text);

                }

                if (stu.GetItemCheckState(0) == CheckState.Checked)
                {

                     un = uni.Text;
                    if (mahapola.SelectedIndex > -1)
                    {
                        mahp = mahapola.SelectedItem.ToString();
                    }
                    else
                    {
                        list.Add("mahapola ");
                    }
                }

            }

         

            if(list.Any())
            {
                string msg = "";
                foreach(var m in list)
                {
                    msg = msg + m+",";
                }
                MessageBox.Show("Invalid " + msg + " details");
               
                return;
            }
            else
            {
                Console.WriteLine(firstt);
                Console.WriteLine(lastt);
                Console.WriteLine(addres);
                Console.WriteLine(ni);
                Console.WriteLine(birth);
                Console.WriteLine(joinn);
                Console.WriteLine(reli);
                Console.WriteLine(nat);
                Console.WriteLine(housee);
                Console.WriteLine(fam);
                var nv =DBNull.Value;
                if(agee<16)
                {
                    ni = "";
                }
                string query = "INSERT INTO person(first_name,last_name,address,NIC,DOB,joined_date,gender,nation,religion,family_no,house_no) VALUES ('" + firstt + "','" + lastt + "','" + addres + "','" + ni + "','" + birth + "','" + joinn + "','" + gend + "','" + nat + "','" + reli + "','" + fam+ "','" + housee + "');";
                //string query= "UPDATE person SET first_name='" + firstt + "',last_name='" + lastt + "',address='" + addres + "',NIC='" + ni + "',DOB='" + birth + "',joined_date='" + joinn + "',gender='" + gend + "',nation='" + nat + "',religion='" + reli + "',family_no='" + fam + "',house_no='" + housee + "'WHERE id='" + int.Parse(id.Text) + "'";

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

                    databasecommand = new MySqlCommand("SELECT * FROM person ORDER BY id DESC LIMIT 1;", databaseconn);
                    databasecommand.CommandTimeout = 60;
                    databaseconn.Open();
                     my = databasecommand.ExecuteReader();
                    string iid = "";
                        while (my.Read())
                        {
                            iid = my.GetString("id");
                        }
                    databaseconn.Close();
                    Console.WriteLine(iid);
                    if(agee<=18)
                    {
                       query = "INSERT INTO child(person_id,guardian_name,guardian_NIC,school) VALUES ('" + iid + "','" + g_name + "','" + g_nic + "','" + sch + "');";
                       //query= "UPDATE child SET guardian_name='" + g_name + "',guardian_NIC='" + g_nic + "',school='" + sch + "'WHERE person_id='" + int.Parse(id.Text) + "'";
                        databasecommand = new MySqlCommand(query, databaseconn);
                        databasecommand.CommandTimeout = 60;
                        databaseconn.Open();
                        my = databasecommand.ExecuteReader(); 
                        databaseconn.Close();

                    }
                    else if(agee>18)
                    {
                        query = "INSERT INTO adult(person_id,married_status,vote_status) VALUES ('" + iid + "','" + mar + "','" + v + "');";
                       // query = "UPDATE adult SET married_status='" + mar + "',vote_status='" + v + "'WHERE person_id='" + int.Parse(id.Text) + "'";

                        databasecommand = new MySqlCommand(query, databaseconn);
                        databasecommand.CommandTimeout = 60;
                        databaseconn.Open();
                        my = databasecommand.ExecuteReader();
                        databaseconn.Close();
                        if (emp.GetItemCheckState(0) == CheckState.Checked)
                        {

                            query = "INSERT INTO employee(person_id,job_type,job_income,other_income) VALUES ('" + iid + "','" + go + "','" + jin + "','" + oin + "');";
                            //query = "UPDATE employee SET job_type='" + go + "',job_income='" + jin + "',other_income='" + oin + "'WHERE person_id='" + int.Parse(id.Text) + "'";
                            databasecommand = new MySqlCommand(query, databaseconn);
                            databasecommand.CommandTimeout = 60;
                            databaseconn.Open();
                            my = databasecommand.ExecuteReader(); 
                            databaseconn.Close();
                        }

                        if (emp.GetItemCheckState(1) == CheckState.Checked)
                        {

                            query = "INSERT INTO unemployee(person_id,other_income) VALUES ('" + iid + "','" + oin + "');";
                           // query = "UPDATE unemployee SET other_income='" +oin +  "'WHERE person_id='" + int.Parse(id.Text) + "'";
                            databasecommand = new MySqlCommand(query, databaseconn);
                            databasecommand.CommandTimeout = 60;
                            databaseconn.Open();
                            my = databasecommand.ExecuteReader();
                            databaseconn.Close();
                        }
                        if (stu.GetItemCheckState(0) == CheckState.Checked)
                        {

                            query = "INSERT INTO uni_student(person_id,university,mahapola_status) VALUES ('" + iid + "','" + un + "','" + mahp + "');";
                           // query = "UPDATE uni_student SET university='" + un + "',mahapola_status='" +mahp  + "'WHERE person_id='" + int.Parse(id.Text) + "'";
                            databasecommand = new MySqlCommand(query, databaseconn);
                            databasecommand.CommandTimeout = 60;
                            databaseconn.Open();
                            my = databasecommand.ExecuteReader(); MessageBox.Show("Data added succesfully!");
                            databaseconn.Close();
                        }
                    }
                    if(telephone.Text!="T.P" ||mobile.Text!="Mobile" )
                    {   if(telephone.Text == "T.P") { tp = ""; }
                        if (mobile.Text == "T.P") { mobil = ""; }

                       query = "INSERT INTO contacts(person_id,telephone_no,mobile_no) VALUES ('" + iid + "','" + tp + "','" + mobil + "');";
                        //query = "UPDATE contacts SET telephone_no='" + tp + "',mobile_no='" + mobil + "'WHERE person_id='" + int.Parse(id.Text) + "'";
                        databasecommand = new MySqlCommand(query, databaseconn);
                        databasecommand.CommandTimeout = 60;
                        databaseconn.Open();
                        my = databasecommand.ExecuteReader(); 
                        databaseconn.Close();
                    }
                    

                   
                  


                    clear();
                   setGrid();
                    
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                   
                }

                



            }


        }


        private void dob_Leave(object sender, EventArgs e)
        {
            DateTime birth = dob.Value;
            DateTime today = DateTime.UtcNow.Date;
            TimeSpan diff = today.Subtract(birth);
           
            var d = (int)diff.Days/365;
            age.Text = d.ToString();
            
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    id.Text = row.Cells["id"].Value.ToString();
                    first.Text = row.Cells["first_name"].Value.ToString();
                    first.ForeColor = Color.Black;
                    last.Text = row.Cells["last_name"].Value.ToString();
                    last.ForeColor = Color.Black;
                    address.Text = row.Cells["address"].Value.ToString();
                    address.ForeColor = Color.Black;
                    family.Text = row.Cells["family_no"].Value.ToString();
                    house.Text = row.Cells["house_no"].Value.ToString();
                    nic.Text = row.Cells["NIC"].Value.ToString();
                    DateTime tdd = Convert.ToDateTime(row.Cells["joined_date"].Value.ToString());
                    string t = tdd.ToString("yyyy-MM-dd");
                    join.Value = DateTime.ParseExact(t, "yyyy-M-d", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None);
                    tdd = Convert.ToDateTime(row.Cells["DOB"].Value.ToString());
                    t = tdd.ToString("yyyy-MM-dd");
                    dob.Value = DateTime.ParseExact(t, "yyyy-M-d", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None);
                    DateTime birthh = dob.Value;
                    DateTime today = DateTime.UtcNow.Date;
                    TimeSpan diff = today.Subtract(birthh);
                    var agee = (int)diff.Days / 365;
                    age.Text = agee.ToString();
                    religion.Text = row.Cells["religion"].Value.ToString();
                    nation.Text = row.Cells["nation"].Value.ToString();
                    gender.Text = row.Cells["gender"].Value.ToString();
                    for (int ix = 0; ix < gender.Items.Count; ix++)
                    {
                        if ((string)gender.Items[ix] == gender.Text)
                        {
                            gender.SetItemChecked(ix, true);
                        }

                    }
                    string query = "SELECT telephone_no,mobile_no FROM contacts WHERE person_id='" + row.Cells["id"].Value + "'";
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
                                telephone.Text = my.GetString("telephone_no");
                                telephone.ForeColor = Color.Black;
                                mobile.Text = my.GetString("mobile_no");
                                mobile.ForeColor = Color.Black;





                            }
                        }
                        else
                        {
                            telephone.Text = "T.P";
                            mobile.Text = "Mobile";
                            telephone.ForeColor = Color.Silver;
                            mobile.ForeColor = Color.Silver;
                        }
                        databaseconn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error occured!");
                    }
                    query = "SELECT married_status,vote_status FROM adult WHERE person_id='" + row.Cells["id"].Value + "'";
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
                                for (int ix = 0; ix < marry.Items.Count; ix++)
                                {
                                    if ((string)marry.Items[ix] == my.GetString("married_status"))
                                    {
                                        marry.SetItemChecked(ix, true);
                                    }

                                }
                                for (int ix = 0; ix < vote.Items.Count; ix++)
                                {
                                    if ((string)vote.Items[ix] == my.GetString("vote_status"))
                                    {
                                        vote.SetItemChecked(ix, true);
                                    }

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error occured!");
                    }
                    query = "SELECT guardian_name,guardian_NIC,school FROM child WHERE person_id='" + row.Cells["id"].Value + "'";
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
                                gname.Text = my.GetString("guardian_name");
                                gnic.Text = my.GetString("guardian_NIC");
                                school.Text = my.GetString("school");
                                gname.ForeColor = Color.Black;
                                gnic.ForeColor = Color.Black;
                                school.ForeColor = Color.Black;
                                for (int ix = 0; ix < marry.Items.Count; ix++)
                                {

                                    marry.SetItemChecked(ix, false);


                                }
                                for (int ix = 0; ix < gov.Items.Count; ix++)
                                {

                                    gov.SetItemChecked(ix, false);


                                }
                                for (int ix = 0; ix < vote.Items.Count; ix++)
                                {

                                    vote.SetItemChecked(ix, false);


                                }

                            }

                        }
                        else
                        {
                            gname.Text = "Guardian name";
                            gnic.Text = "Guardian NIC";
                            school.Text = "School";
                            gname.ForeColor = Color.Silver;
                            gnic.ForeColor = Color.Silver;
                            school.ForeColor = Color.Silver;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error occured!");
                    }
                    databaseconn.Close();
                    query = "SELECT * FROM employee WHERE person_id='" + row.Cells["id"].Value + "'";
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
                            emp.SetItemChecked(0, true);
                            emp.SetItemChecked(1, false);
                            while (my.Read())
                            {
                                jincome.Text = my.GetString("job_income");
                                oincome.Text = my.GetString("other_income");

                                jincome.ForeColor = Color.Black;
                                oincome.ForeColor = Color.Black;
                                for (int ix = 0; ix < gov.Items.Count; ix++)
                                {
                                    if ((string)gov.Items[ix] == my.GetString("job_type"))
                                    {
                                        gov.SetItemChecked(ix, true);
                                    }

                                }


                            }

                        }
                        else
                        {
                            jincome.Text = "0.00";
                            oincome.Text = "0.00";

                            jincome.ForeColor = Color.Silver;
                            oincome.ForeColor = Color.Silver;
                            emp.SetItemChecked(1, false);
                            emp.SetItemChecked(0, false);
                            databaseconn.Close();
                            query = "SELECT other_income FROM unemployee WHERE person_id='" + row.Cells["id"].Value + "'";
                            MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=graama";
                            databaseconn = new MySqlConnection(MYSQLConnectionString);
                            databasecommand = new MySqlCommand(query, databaseconn);
                            databasecommand.CommandTimeout = 60;
                            try
                            {
                                databaseconn.Open();
                                my = databasecommand.ExecuteReader();
                                if (my.HasRows)
                                {
                                    emp.SetItemChecked(1, true);
                                    emp.SetItemChecked(0, false);
                                    while (my.Read())
                                    {

                                        oincome.Text = my.GetString("other_income");


                                        oincome.ForeColor = Color.Black;


                                    }
                                    for (int ix = 0; ix < gov.Items.Count; ix++)
                                    {

                                        gov.SetItemChecked(ix, false);


                                    }

                                }
                                else
                                {
                                    oincome.Text = "0.00";


                                    oincome.ForeColor = Color.Silver;

                                    emp.SetItemChecked(0, false);
                                    emp.SetItemChecked(1, false);

                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("error occured!");
                            }
                            databaseconn.Close();


                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error occured!");
                    }
                    databaseconn.Close();

                    //------------------------
                    query = "SELECT * FROM uni_student WHERE person_id='" + row.Cells["id"].Value + "'";
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
                                uni.Text = my.GetString("university");

                                mahapola.Text = my.GetString("mahapola_status");

                                uni.ForeColor = Color.Black;
                                stu.SetItemChecked(0, true);



                            }

                        }
                        else
                        {
                            stu.SetItemChecked(0, false);
                            uni.Text = "";
                            mahapola.Text = "";
                        }
                    }
                    catch (Exception ex)
                    {
                       //
                    }
                    databaseconn.Close();





                }
            }
            catch(Exception ee)
            {
                MessageBox.Show("Error occured!");
            }
        }
        private void setGrid()

        {
            string query = "SELECT * FROM person";
            string MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=graama";
            MySqlConnection databaseconn = new MySqlConnection(MYSQLConnectionString);
            MySqlCommand databasecommand = new MySqlCommand(query, databaseconn);
            MySqlDataAdapter re = new MySqlDataAdapter(query, databaseconn);
            databasecommand.CommandTimeout = 60;
            try
            {
                databaseconn.Open();
                //MySqlDataReader my = databasecommand.ExecuteReader();
                //MessageBox.Show("Data added succesfully!");
                //databaseconn.Close();
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

        private void dob_Leave_1(object sender, EventArgs e)
        {
            DateTime birth = dob.Value;
            DateTime today = DateTime.UtcNow.Date;
            TimeSpan diff = today.Subtract(birth);

            var d = (int)diff.Days / 365;
            age.Text = d.ToString();
        }
        private void clear()
        {
            id.Text = "";
            first.Text = "First Name";
            first.ForeColor = Color.Silver;
            last.Text = "Last Name";
            last.ForeColor = Color.Silver;
            address.Text = "Address Line 1";
            address.ForeColor = Color.Silver;
            age.Text = "";
            DateTime today = DateTime.UtcNow.Date;
            string td = today.ToString("yyyy-MM-dd");
            dob.Value = DateTime.ParseExact(td, "yyyy-M-d", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None);
            join.Value = DateTime.ParseExact(td, "yyyy-M-d", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None);
            nic.Text = "";
            house.Text = "";
            family.Text = "";
            for (int ix = 0; ix < gender.Items.Count; ix++)
            {
                
                    gender.SetItemChecked(ix, false);
                
            }
            this.religion.SelectedIndex = -1;
            this.nation.SelectedIndex = -1;
            for (int ix = 0; ix < vote.Items.Count; ix++)
            {

                vote.SetItemChecked(ix, false);

            }
            for (int ix = 0; ix < marry.Items.Count; ix++)
            {

                marry.SetItemChecked(ix, false);

            }
            for (int ix = 0; ix < emp.Items.Count; ix++)
            {

                gender.SetItemChecked(ix, false);

            }
            gname.Text = "Guardian Name"; gname.ForeColor = Color.Silver;
            gnic.Text = "Guardian NIC"; gnic.ForeColor = Color.Silver;
            school.Text = "School"; school.ForeColor = Color.Silver;
            uni.Text = "";
            this.mahapola.SelectedIndex = -1;
            for (int ix = 0; ix < gov.Items.Count; ix++)
            {

               gov.SetItemChecked(ix, false);

            }
            jincome.Text = "0.00";jincome.ForeColor = Color.Silver;
            oincome.Text = "0.00"; oincome.ForeColor = Color.Silver;



        }

        private void uni_Enter(object sender, EventArgs e)
        {
            uni.ForeColor = Color.Black;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {   if(id.Text=="")
            {
                MessageBox.Show("Error! id field is empty!");
            }
            string query = "DELETE FROM adult WHERE person_id='" + int.Parse(id.Text) + "';DELETE FROM child WHERE " +
                "person_id='" + int.Parse(id.Text) + "';DELETE FROM employee WHERE person_id='" + int.Parse(id.Text) + "';" +
                "DELETE FROM unemployee WHERE person_id='" + int.Parse(id.Text) + "';" +
                "DELETE FROM uni_student WHERE person_id='" + int.Parse(id.Text) + "';" +
                "DELETE FROM contacts WHERE person_id='" + int.Parse(id.Text) + "';" +
                "DELETE FROM person WHERE id='" + int.Parse(id.Text) + "';";
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


            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            //Report1 r1 = new Report1();
            Form3 f3 = new Form3();
           
            f3.ShowDialog();


        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            string q = "SELECT * FROM PERSON";
            if (fcat.SelectedIndex <= -1)
            {
                if (fgen.SelectedIndex <= -1)
                {
                    if (flage.Text == "" && fhage.Text == "")
                    {
                        q = "SELECT id,first_name,last_name,address,TIMESTAMPDIFF(YEAR,DOB,CURDATE()) AS age,NIC,house_no,family_no FROM person";
                    }
                    else if (flage.Text == "" && fhage.Text != "")
                    {
                        int maxage = 0;
                        try { maxage = int.Parse(fhage.Text); }
                        catch (Exception ee) { MessageBox.Show("Invalid age values!"); }

                        q = "SELECT id,first_name,last_name,address,TIMESTAMPDIFF(YEAR,DOB,CURDATE()) AS age,NIC,house_no " +
                            "FROM person WHERE TIMESTAMPDIFF(YEAR,DOB,CURDATE())<='" + maxage + "';";
                    }
                    else if (flage.Text != "" && fhage.Text == "")
                    {
                        int minage = 0;
                        try { minage = int.Parse(flage.Text); }
                        catch (Exception ee) { MessageBox.Show("Invalid age values!"); }

                        q = "SELECT id,first_name,last_name,address,TIMESTAMPDIFF(YEAR,DOB,CURDATE()) AS age," +
                            "NIC,house_no FROM person WHERE TIMESTAMPDIFF(YEAR,DOB,CURDATE())>='" + minage + "';";
                    }
                    else if (flage.Text != "" && fhage.Text != "")
                    {
                        int minage = 0;
                        int maxage = 0;
                        try
                        {
                            minage = int.Parse(flage.Text);
                            maxage = int.Parse(fhage.Text);
                        }
                        catch (Exception ee) { MessageBox.Show("Invalid age values!"); }

                        q = "SELECT id,first_name,last_name,address,TIMESTAMPDIFF(YEAR,DOB,CURDATE()) AS age," +
                            "NIC,house_no FROM person WHERE TIMESTAMPDIFF(YEAR,DOB,CURDATE())>='" + minage + "' && " +
                            "TIMESTAMPDIFF(YEAR,DOB,CURDATE())<='" + maxage + "';";
                    }

                }
                else if (fgen.SelectedIndex > -1)
                {
                    string g = fgen.Text;
                    if (flage.Text == "" && fhage.Text == "")
                    {
                        q = "SELECT id,first_name,last_name,address,TIMESTAMPDIFF(YEAR,DOB,CURDATE()) AS age,NIC,house_no " +
                            "FROM person WHERE gender='" + g + "';";
                    }
                    else if (flage.Text == "" && fhage.Text != "")
                    {
                        int maxage = 0;
                        try { maxage = int.Parse(fhage.Text); }
                        catch (Exception ee) { MessageBox.Show("Invalid age values!"); }

                        q = "SELECT id,first_name,last_name,address,TIMESTAMPDIFF(YEAR,DOB,CURDATE()) AS age,NIC,house_no " +
                            "FROM person WHERE TIMESTAMPDIFF(YEAR,DOB,CURDATE())<='" + maxage + "' && gender='" + g + "';";
                    }
                    else if (flage.Text != "" && fhage.Text == "")
                    {
                        int minage = 0;
                        try { minage = int.Parse(flage.Text); }
                        catch (Exception ee) { MessageBox.Show("Invalid age values!"); }

                        q = "SELECT id,first_name,last_name,address,TIMESTAMPDIFF(YEAR,DOB,CURDATE()) AS " +
                            "age,NIC,house_no FROM person WHERE TIMESTAMPDIFF(YEAR,DOB,CURDATE())>='" + minage + "' && gender='" + g + "';";
                    }
                    else if (flage.Text != "" && fhage.Text != "")
                    {
                        int minage = 0;
                        int maxage = 0;
                        try
                        {
                            minage = int.Parse(flage.Text);
                            maxage = int.Parse(fhage.Text);
                        }
                        catch (Exception ee) { MessageBox.Show("Invalid age values!"); }

                        q = "SELECT id,first_name,last_name,address,TIMESTAMPDIFF(YEAR,DOB,CURDATE()) AS " +
                            "age,NIC,house_no FROM person WHERE TIMESTAMPDIFF(YEAR,DOB,CURDATE())>='" + minage + "' " +
                            "&& TIMESTAMPDIFF(YEAR,DOB,CURDATE())<='" + maxage + "' && gender='" + g + "';";
                    }

                }


            }
            else if (fcat.SelectedIndex == 0)
            {

                if (fgen.SelectedIndex <= -1)
                {
                    if (flage.Text == "" && fhage.Text == "")
                    {
                        q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR,DOB,CURDATE()) AS age,house_no,guardian_name,guardian_NIC FROM person INNER JOIN child ON person.id=child.person_id";
                    }
                    else if (flage.Text == "" && fhage.Text != "")
                    {
                        int maxage = 0;
                        try { maxage = int.Parse(fhage.Text); }
                        catch (Exception ee) { MessageBox.Show("Invalid age values!"); }

                        q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR,DOB,CURDATE()) AS age,house_no,guardian_name,guardian_NIC FROM person INNER JOIN child ON person.id=child.person_id WHERE TIMESTAMPDIFF(YEAR,DOB,CURDATE())<='" + maxage + "';";
                    }
                    else if (flage.Text != "" && fhage.Text == "")
                    {
                        int minage = 0;
                        try { minage = int.Parse(flage.Text); }
                        catch (Exception ee) { MessageBox.Show("Invalid age values!"); }

                        q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR,DOB,CURDATE()) AS age,house_no,guardian_name,guardian_NIC FROM person INNER JOIN child ON person.id=child.person_id WHERE TIMESTAMPDIFF(YEAR,DOB,CURDATE())>='" + minage + "';";
                    }
                    else if (flage.Text != "" && fhage.Text != "")
                    {
                        int minage = 0;
                        int maxage = 0;
                        try
                        {
                            minage = int.Parse(flage.Text);
                            maxage = int.Parse(fhage.Text);
                        }
                        catch (Exception ee) { MessageBox.Show("Invalid age values!"); }

                        q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR,DOB,CURDATE()) AS age,house_no,guardian_name,guardian_NIC FROM person INNER JOIN child ON person.id=child.person_id WHERE TIMESTAMPDIFF(YEAR,DOB,CURDATE())>='" + minage + "' && TIMESTAMPDIFF(YEAR,DOB,CURDATE())<='" + maxage + "';";
                    }

                }
                else if (fgen.SelectedIndex > -1)
                {
                    string g = fgen.Text;
                    if (flage.Text == "" && fhage.Text == "")
                    {
                        q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR,DOB,CURDATE()) AS age,house_no,guardian_name,guardian_NIC FROM person INNER JOIN child ON person.id=child.person_id WHERE gender='" + g + "';";
                    }
                    else if (flage.Text == "" && fhage.Text != "")
                    {
                        int maxage = 0;
                        try { maxage = int.Parse(fhage.Text); }
                        catch (Exception ee) { MessageBox.Show("Invalid age values!"); }

                        q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR,DOB,CURDATE()) AS age,house_no,guardian_name,guardian_NIC FROM person INNER JOIN child ON person.id=child.person_id WHERE TIMESTAMPDIFF(YEAR,DOB,CURDATE())<='" + maxage + "' && gender='" + g + "';";
                    }
                    else if (flage.Text != "" && fhage.Text == "")
                    {
                        int minage = 0;
                        try { minage = int.Parse(flage.Text); }
                        catch (Exception ee) { MessageBox.Show("Invalid age values!"); }

                        q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR,DOB,CURDATE()) AS age,house_no,guardian_name,guardian_NIC FROM person INNER JOIN child ON person.id=child.person_id WHERE TIMESTAMPDIFF(YEAR,DOB,CURDATE())>='" + minage + "' && gender='" + g + "';";
                    }
                    else if (flage.Text != "" && fhage.Text != "")
                    {
                        int minage = 0;
                        int maxage = 0;
                        try
                        {
                            minage = int.Parse(flage.Text);
                            maxage = int.Parse(fhage.Text);
                        }
                        catch (Exception ee) { MessageBox.Show("Invalid age values!"); }

                        q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR,DOB,CURDATE()) AS age,house_no,guardian_name,guardian_NIC FROM person INNER JOIN child ON person.id=child.person_id WHERE TIMESTAMPDIFF(YEAR,DOB,CURDATE())>='" + minage + "' && TIMESTAMPDIFF(YEAR,DOB,CURDATE())<='" + maxage + "' && gender='" + g + "';";
                    }

                }
            }
            else if (fcat.SelectedIndex == 1)
            {

               
                    if (fgen.SelectedIndex <= -1)
                    {
                        if (flage.Text == "" && fhage.Text == "")
                        {
                            q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR, DOB, CURDATE()) AS age, house_no, married_status, vote_status FROM person INNER JOIN adult ON person.id = adult.person_id";
                        }
                        else if (flage.Text == "" && fhage.Text != "")
                        {
                            int maxage = 0;
                            try { maxage = int.Parse(fhage.Text); }
                            catch (Exception ee) { MessageBox.Show("Invalid age values!"); }

                            q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR, DOB, CURDATE()) AS age, house_no, married_status, vote_status FROM person INNER JOIN adult ON person.id = adult.person_id WHERE TIMESTAMPDIFF(YEAR,DOB,CURDATE())<='" + maxage + "';";
                        }
                        else if (flage.Text != "" && fhage.Text == "")
                        {
                            int minage = 0;
                            try { minage = int.Parse(flage.Text); }
                            catch (Exception ee) { MessageBox.Show("Invalid age values!"); }

                            q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR, DOB, CURDATE()) AS age, house_no, married_status, vote_status FROM person INNER JOIN adult ON person.id = adult.person_id WHERE TIMESTAMPDIFF(YEAR,DOB,CURDATE())>='" + minage + "';";
                        }
                        else if (flage.Text != "" && fhage.Text != "")
                        {
                            int minage = 0;
                            int maxage = 0;
                            try
                            {
                                minage = int.Parse(flage.Text);
                                maxage = int.Parse(fhage.Text);
                            }
                            catch (Exception ee) { MessageBox.Show("Invalid age values!"); }

                            q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR, DOB, CURDATE()) AS age, house_no, married_status, vote_status FROM person INNER JOIN adult ON person.id = adult.person_id WHERE TIMESTAMPDIFF(YEAR,DOB,CURDATE())>='" + minage + "' && TIMESTAMPDIFF(YEAR,DOB,CURDATE())<='" + maxage + "';";
                        }

                    }
                    else if (fgen.SelectedIndex > -1)
                    {
                        string g = fgen.Text;
                        if (flage.Text == "" && fhage.Text == "")
                        {
                            q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR, DOB, CURDATE()) AS age, house_no, married_status, vote_status FROM person INNER JOIN adult ON person.id = adult.person_id WHERE gender='" + g + "';";
                        }
                        else if (flage.Text == "" && fhage.Text != "")
                        {
                            int maxage = 0;
                            try { maxage = int.Parse(fhage.Text); }
                            catch (Exception ee) { MessageBox.Show("Invalid age values!"); }

                            q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR, DOB, CURDATE()) AS age, house_no, married_status, vote_status FROM person INNER JOIN adult ON person.id = adult.person_id WHERE TIMESTAMPDIFF(YEAR,DOB,CURDATE())<='" + maxage + "' && gender='" + g + "';";
                        }
                        else if (flage.Text != "" && fhage.Text == "")
                        {
                            int minage = 0;
                            try { minage = int.Parse(flage.Text); }
                            catch (Exception ee) { MessageBox.Show("Invalid age values!"); }

                            q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR, DOB, CURDATE()) AS age, house_no, married_status, vote_status FROM person INNER JOIN adult ON person.id = adult.person_id WHERE TIMESTAMPDIFF(YEAR,DOB,CURDATE())>='" + minage + "' && gender='" + g + "';";
                        }
                        else if (flage.Text != "" && fhage.Text != "")
                        {
                            int minage = 0;
                            int maxage = 0;
                            try
                            {
                                minage = int.Parse(flage.Text);
                                maxage = int.Parse(fhage.Text);
                            }
                            catch (Exception ee) { MessageBox.Show("Invalid age values!"); }

                            q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR, DOB, CURDATE()) AS age, house_no, married_status, vote_status FROM person INNER JOIN adult ON person.id = adult.person_id WHERE TIMESTAMPDIFF(YEAR,DOB,CURDATE())>='" + minage + "' && TIMESTAMPDIFF(YEAR,DOB,CURDATE())<='" + maxage + "' && gender='" + g + "';";
                        }

                    }

                
            }
            if (fcat.SelectedIndex == 2)
            {
                
                if (fgen.SelectedIndex <= -1)
                {
                    if (flage.Text == "" && fhage.Text == "")
                    {
                        q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR, DOB, CURDATE()) AS age, house_no,job_income, job_type FROM person INNER JOIN employee ON person.id = employee.person_id";
                    }
                    else if (flage.Text == "" && fhage.Text != "")
                    {
                        int maxage = 0;
                        try { maxage = int.Parse(fhage.Text); }
                        catch (Exception ee) { MessageBox.Show("Invalid age values!"); }

                        q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR, DOB, CURDATE()) AS age, house_no,job_income, job_type FROM person INNER JOIN employee ON person.id = employee.person_id WHERE TIMESTAMPDIFF(YEAR,DOB,CURDATE())<='" + maxage + "';";
                    }
                    else if (flage.Text != "" && fhage.Text == "")
                    {
                        int minage = 0;
                        try { minage = int.Parse(flage.Text); }
                        catch (Exception ee) { MessageBox.Show("Invalid age values!"); }

                        q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR, DOB, CURDATE()) AS age, house_no,job_income, job_type FROM person INNER JOIN employee ON person.id = employee.person_id WHERE TIMESTAMPDIFF(YEAR,DOB,CURDATE())>='" + minage + "';";
                    }
                    else if (flage.Text != "" && fhage.Text != "")
                    {
                        int minage = 0;
                        int maxage = 0;
                        try
                        {
                            minage = int.Parse(flage.Text);
                            maxage = int.Parse(fhage.Text);
                        }
                        catch (Exception ee) { MessageBox.Show("Invalid age values!"); }

                        q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR, DOB, CURDATE()) AS age, house_no,job_income, job_type FROM person INNER JOIN employee ON person.id = employee.person_id WHERE TIMESTAMPDIFF(YEAR,DOB,CURDATE())>='" + minage + "' && TIMESTAMPDIFF(YEAR,DOB,CURDATE())<='" + maxage + "';";
                    }

                }
                else if (fgen.SelectedIndex > -1)
                {
                    string g = fgen.Text;
                    if (flage.Text == "" && fhage.Text == "")
                    {
                        q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR, DOB, CURDATE()) AS age, house_no,job_income, job_type FROM person INNER JOIN employee ON person.id = employee.person_id WHERE gender='" + g + "';";
                    }
                    else if (flage.Text == "" && fhage.Text != "")
                    {
                        int maxage = 0;
                        try { maxage = int.Parse(fhage.Text); }
                        catch (Exception ee) { MessageBox.Show("Invalid age values!"); }

                        q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR, DOB, CURDATE()) AS age, house_no,job_income, job_type FROM person INNER JOIN employee ON person.id = employee.person_id WHERE TIMESTAMPDIFF(YEAR,DOB,CURDATE())<='" + maxage + "' && gender='" + g + "';";
                    }
                    else if (flage.Text != "" && fhage.Text == "")
                    {
                        int minage = 0;
                        try { minage = int.Parse(flage.Text); }
                        catch (Exception ee) { MessageBox.Show("Invalid age values!"); }

                        q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR, DOB, CURDATE()) AS age, house_no,job_income, job_type FROM person INNER JOIN employee ON person.id = employee.person_id WHERE TIMESTAMPDIFF(YEAR,DOB,CURDATE())>='" + minage + "' && gender='" + g + "';";
                    }
                    else if (flage.Text != "" && fhage.Text != "")
                    {
                        int minage = 0;
                        int maxage = 0;
                        try
                        {
                            minage = int.Parse(flage.Text);
                            maxage = int.Parse(fhage.Text);
                        }
                        catch (Exception ee) { MessageBox.Show("Invalid age values!"); }

                        q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR, DOB, CURDATE()) AS age, house_no,job_income, job_type FROM person INNER JOIN employee ON person.id = employee.person_id WHERE TIMESTAMPDIFF(YEAR,DOB,CURDATE())>='" + minage + "' && TIMESTAMPDIFF(YEAR,DOB,CURDATE())<='" + maxage + "' && gender='" + g + "';";
                    }

                }


            }
            if (fcat.SelectedIndex ==3)
            {
                
                if (fgen.SelectedIndex <= -1)
                {
                    if (flage.Text == "" && fhage.Text == "")
                    {
                        q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR, DOB, CURDATE()) AS age, house_no, other_income FROM person INNER JOIN unemployee ON person.id = unemployee.person_id";
                    }
                    else if (flage.Text == "" && fhage.Text != "")
                    {
                        int maxage = 0;
                        try { maxage = int.Parse(fhage.Text); }
                        catch (Exception ee) { MessageBox.Show("Invalid age values!"); }

                        q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR, DOB, CURDATE()) AS age, house_no, other_income FROM person INNER JOIN unemployee ON person.id = unemployee.person_id WHERE TIMESTAMPDIFF(YEAR,DOB,CURDATE())<='" + maxage + "';";
                    }
                    else if (flage.Text != "" && fhage.Text == "")
                    {
                        int minage = 0;
                        try { minage = int.Parse(flage.Text); }
                        catch (Exception ee) { MessageBox.Show("Invalid age values!"); }

                        q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR, DOB, CURDATE()) AS age, house_no, other_income FROM person INNER JOIN unemployee ON person.id = unemployee.person_id WHERE TIMESTAMPDIFF(YEAR,DOB,CURDATE())>='" + minage + "';";
                    }
                    else if (flage.Text != "" && fhage.Text != "")
                    {
                        int minage = 0;
                        int maxage = 0;
                        try
                        {
                            minage = int.Parse(flage.Text);
                            maxage = int.Parse(fhage.Text);
                        }
                        catch (Exception ee) { MessageBox.Show("Invalid age values!"); }

                        q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR, DOB, CURDATE()) AS age, house_no, other_income FROM person INNER JOIN unemployee ON person.id = unemployee.person_id WHERE TIMESTAMPDIFF(YEAR,DOB,CURDATE())>='" + minage + "' && TIMESTAMPDIFF(YEAR,DOB,CURDATE())<='" + maxage + "';";
                    }

                }
                else if (fgen.SelectedIndex > -1)
                {
                    string g = fgen.Text;
                    if (flage.Text == "" && fhage.Text == "")
                    {
                        q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR, DOB, CURDATE()) AS age, house_no, other_income FROM person INNER JOIN unemployee ON person.id = unemployee.person_id WHERE gender='" + g + "';";
                    }
                    else if (flage.Text == "" && fhage.Text != "")
                    {
                        int maxage = 0;
                        try { maxage = int.Parse(fhage.Text); }
                        catch (Exception ee) { MessageBox.Show("Invalid age values!"); }

                        q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR, DOB, CURDATE()) AS age, house_no, other_income FROM person INNER JOIN unemployee ON person.id = unemployee.person_id WHERE TIMESTAMPDIFF(YEAR,DOB,CURDATE())<='" + maxage + "' && gender='" + g + "';";
                    }
                    else if (flage.Text != "" && fhage.Text == "")
                    {
                        int minage = 0;
                        try { minage = int.Parse(flage.Text); }
                        catch (Exception ee) { MessageBox.Show("Invalid age values!"); }

                        q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR, DOB, CURDATE()) AS age, house_no, other_income FROM person INNER JOIN unemployee ON person.id = unemployee.person_id WHERE TIMESTAMPDIFF(YEAR,DOB,CURDATE())>='" + minage + "' && gender='" + g + "';";
                    }
                    else if (flage.Text != "" && fhage.Text != "")
                    {
                        int minage = 0;
                        int maxage = 0;
                        try
                        {
                            minage = int.Parse(flage.Text);
                            maxage = int.Parse(fhage.Text);
                        }
                        catch (Exception ee) { MessageBox.Show("Invalid age values!"); }

                        q = "SELECT person.id,first_name,last_name,address,TIMESTAMPDIFF(YEAR, DOB, CURDATE()) AS age, house_no, other_income FROM person INNER JOIN unemployee ON person.id = unemployee.person_id WHERE TIMESTAMPDIFF(YEAR,DOB,CURDATE())>='" + minage + "' && TIMESTAMPDIFF(YEAR,DOB,CURDATE())<='" + maxage + "' && gender='" + g + "';";
                    }

                }


            }



            //------
            string MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=graama";
            MySqlConnection databaseconn = new MySqlConnection(MYSQLConnectionString);
            MySqlCommand databasecommand = new MySqlCommand(q, databaseconn);
            MySqlDataAdapter re = new MySqlDataAdapter(q, databaseconn);
            databasecommand.CommandTimeout = 60;
            try
            {
                databaseconn.Open();
                //MySqlDataReader my = databasecommand.ExecuteReader();
                //MessageBox.Show("Data added succesfully!");
                //databaseconn.Close();
                DataTable dtb = new DataTable();
                re.Fill(dtb);
                dataGridView1.DataSource = dtb;
                databaseconn.Close();
                re.Fill(dttb);

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            fcat.Text = "";
            fgen.Text = "";
            flage.Text = "";
            fhage.Text = "";
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

        }

        private void last_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
