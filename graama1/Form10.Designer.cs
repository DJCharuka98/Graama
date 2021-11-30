namespace graama1
{
    partial class Form10
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.graamaDataSet11 = new graama1.graamaDataSet11();
            this.mahapolaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahapolaTableAdapter = new graama1.graamaDataSet11TableAdapters.mahapolaTableAdapter();
            this.graamaDataSet7 = new graama1.graamaDataSet7();
            this.villageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.villageTableAdapter = new graama1.graamaDataSet7TableAdapters.villageTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahapolaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.mahapolaBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.villageBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "graama1.MahapolaReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // graamaDataSet11
            // 
            this.graamaDataSet11.DataSetName = "graamaDataSet11";
            this.graamaDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mahapolaBindingSource
            // 
            this.mahapolaBindingSource.DataMember = "mahapola";
            this.mahapolaBindingSource.DataSource = this.graamaDataSet11;
            // 
            // mahapolaTableAdapter
            // 
            this.mahapolaTableAdapter.ClearBeforeFill = true;
            // 
            // graamaDataSet7
            // 
            this.graamaDataSet7.DataSetName = "graamaDataSet7";
            this.graamaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // villageBindingSource
            // 
            this.villageBindingSource.DataMember = "village";
            this.villageBindingSource.DataSource = this.graamaDataSet7;
            // 
            // villageTableAdapter
            // 
            this.villageTableAdapter.ClearBeforeFill = true;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahapolaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource mahapolaBindingSource;
        private graamaDataSet11 graamaDataSet11;
        private System.Windows.Forms.BindingSource villageBindingSource;
        private graamaDataSet7 graamaDataSet7;
        private graamaDataSet11TableAdapters.mahapolaTableAdapter mahapolaTableAdapter;
        private graamaDataSet7TableAdapters.villageTableAdapter villageTableAdapter;
    }
}