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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'graamaDataSet14.samurdhi' table. You can move, or remove it, as needed.
            this.samurdhiTableAdapter1.Fill(this.graamaDataSet14.samurdhi);
            // TODO: This line of code loads data into the 'graamaDataSet7.village' table. You can move, or remove it, as needed.
            this.villageTableAdapter.Fill(this.graamaDataSet7.village);
            // TODO: This line of code loads data into the 'graamaDataSet12.samurdhi' table. You can move, or remove it, as needed.
            this.samurdhiTableAdapter.Fill(this.graamaDataSet12.samurdhi);

            this.reportViewer1.RefreshReport();
        }
    }
}
