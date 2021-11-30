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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'graamaDataSet2.village' table. You can move, or remove it, as needed.
            this.villageTableAdapter.Fill(this.graamaDataSet2.village);
            // TODO: This line of code loads data into the 'graamaDataSet9.nofac' table. You can move, or remove it, as needed.
            this.nofacTableAdapter.Fill(this.graamaDataSet9.nofac);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
