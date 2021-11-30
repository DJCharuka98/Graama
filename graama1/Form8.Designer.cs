namespace graama1
{
    partial class Form8
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
            this.graamaDataSet2 = new graama1.graamaDataSet2();
            this.villageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.villageTableAdapter = new graama1.graamaDataSet2TableAdapters.villageTableAdapter();
            this.graamaDataSet9 = new graama1.graamaDataSet9();
            this.nofacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nofacTableAdapter = new graama1.graamaDataSet9TableAdapters.nofacTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nofacBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.villageBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.nofacBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "graama1.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // graamaDataSet2
            // 
            this.graamaDataSet2.DataSetName = "graamaDataSet2";
            this.graamaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // villageBindingSource
            // 
            this.villageBindingSource.DataMember = "village";
            this.villageBindingSource.DataSource = this.graamaDataSet2;
            // 
            // villageTableAdapter
            // 
            this.villageTableAdapter.ClearBeforeFill = true;
            // 
            // graamaDataSet9
            // 
            this.graamaDataSet9.DataSetName = "graamaDataSet9";
            this.graamaDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nofacBindingSource
            // 
            this.nofacBindingSource.DataMember = "nofac";
            this.nofacBindingSource.DataSource = this.graamaDataSet9;
            // 
            // nofacTableAdapter
            // 
            this.nofacTableAdapter.ClearBeforeFill = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nofacBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource villageBindingSource;
        private graamaDataSet2 graamaDataSet2;
        private System.Windows.Forms.BindingSource nofacBindingSource;
        private graamaDataSet9 graamaDataSet9;
        private graamaDataSet2TableAdapters.villageTableAdapter villageTableAdapter;
        private graamaDataSet9TableAdapters.nofacTableAdapter nofacTableAdapter;
    }
}