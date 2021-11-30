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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'graamaDataSet23.family' table. You can move, or remove it, as needed.
            this.familyTableAdapter1.Fill(this.graamaDataSet23.family);
            // TODO: This line of code loads data into the 'graamaDataSet7.village' table. You can move, or remove it, as needed.
            this.villageTableAdapter.Fill(this.graamaDataSet7.village);
            // TODO: This line of code loads data into the 'graamaDataSet6.family' table. You can move, or remove it, as needed.
            //this.familyTableAdapter.Fill(this.graamaDataSet6.family);
            // TODO: This line of code loads data into the 'graamaDataSet4.filterfam' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'graamaDataSet3.filterfam' table. You can move, or remove it, as needed.


            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
