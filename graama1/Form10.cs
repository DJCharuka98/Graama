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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'graamaDataSet11.mahapola' table. You can move, or remove it, as needed.
            this.mahapolaTableAdapter.Fill(this.graamaDataSet11.mahapola);
            // TODO: This line of code loads data into the 'graamaDataSet7.village' table. You can move, or remove it, as needed.
            this.villageTableAdapter.Fill(this.graamaDataSet7.village);

            this.reportViewer1.RefreshReport();
        }
    }
}
