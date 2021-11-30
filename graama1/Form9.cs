using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graama1
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'graamaDataSet8.house' table. You can move, or remove it, as needed.
            this.houseTableAdapter.Fill(this.graamaDataSet8.house);
            // TODO: This line of code loads data into the 'graamaDataSet7.village' table. You can move, or remove it, as needed.
            this.villageTableAdapter.Fill(this.graamaDataSet7.village);

            this.reportViewer1.RefreshReport();
        }
    }
}
