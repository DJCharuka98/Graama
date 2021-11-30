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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'graamaDataSet1.person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.graamaDataSet1.person);
            // TODO: This line of code loads data into the 'graamaDataSet2.village' table. You can move, or remove it, as needed.
            this.villageTableAdapter.Fill(this.graamaDataSet2.village);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
