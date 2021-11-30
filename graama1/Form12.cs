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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'graamaDataSet21.curcert' table. You can move, or remove it, as needed.
            this.curcertTableAdapter.Fill(this.graamaDataSet21.curcert);
            // TODO: This line of code loads data into the 'graamaDataSet19.village' table. You can move, or remove it, as needed.
            //this.villageTableAdapter2.Fill(this.graamaDataSet19.village);
            // TODO: This line of code loads data into the 'graamaDataSet18.certi' table. You can move, or remove it, as needed.
            //this.certiTableAdapter.Fill(this.graamaDataSet18.certi);
            // TODO: This line of code loads data into the 'graamaDataSet16.village' table. You can move, or remove it, as needed.
            //this.villageTableAdapter1.Fill(this.graamaDataSet16.village);


            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
