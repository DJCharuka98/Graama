namespace graama1
{
    partial class Form11
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
            this.graamaDataSet7 = new graama1.graamaDataSet7();
            this.villageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.villageTableAdapter = new graama1.graamaDataSet7TableAdapters.villageTableAdapter();
            this.graamaDataSet12 = new graama1.graamaDataSet12();
            this.samurdhiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.samurdhiTableAdapter = new graama1.graamaDataSet12TableAdapters.samurdhiTableAdapter();
            this.graamaDataSet13 = new graama1.graamaDataSet13();
            this.graamaDataSet13BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.graamaDataSet14 = new graama1.graamaDataSet14();
            this.samurdhiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.samurdhiTableAdapter1 = new graama1.graamaDataSet14TableAdapters.samurdhiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samurdhiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet13BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samurdhiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.villageBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.samurdhiBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "graama1.SamurdiReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
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
            // graamaDataSet12
            // 
            this.graamaDataSet12.DataSetName = "graamaDataSet12";
            this.graamaDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // samurdhiBindingSource
            // 
            this.samurdhiBindingSource.DataMember = "samurdhi";
            this.samurdhiBindingSource.DataSource = this.graamaDataSet12;
            // 
            // samurdhiTableAdapter
            // 
            this.samurdhiTableAdapter.ClearBeforeFill = true;
            // 
            // graamaDataSet13
            // 
            this.graamaDataSet13.DataSetName = "graamaDataSet13";
            this.graamaDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // graamaDataSet13BindingSource
            // 
            this.graamaDataSet13BindingSource.DataSource = this.graamaDataSet13;
            this.graamaDataSet13BindingSource.Position = 0;
            // 
            // graamaDataSet14
            // 
            this.graamaDataSet14.DataSetName = "graamaDataSet14";
            this.graamaDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // samurdhiBindingSource1
            // 
            this.samurdhiBindingSource1.DataMember = "samurdhi";
            this.samurdhiBindingSource1.DataSource = this.graamaDataSet14;
            // 
            // samurdhiTableAdapter1
            // 
            this.samurdhiTableAdapter1.ClearBeforeFill = true;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samurdhiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet13BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samurdhiBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource villageBindingSource;
        private graamaDataSet7 graamaDataSet7;
        private System.Windows.Forms.BindingSource samurdhiBindingSource;
        private graamaDataSet12 graamaDataSet12;
        private graamaDataSet7TableAdapters.villageTableAdapter villageTableAdapter;
        private graamaDataSet12TableAdapters.samurdhiTableAdapter samurdhiTableAdapter;
        private graamaDataSet13 graamaDataSet13;
        private System.Windows.Forms.BindingSource graamaDataSet13BindingSource;
        private graamaDataSet14 graamaDataSet14;
        private System.Windows.Forms.BindingSource samurdhiBindingSource1;
        private graamaDataSet14TableAdapters.samurdhiTableAdapter samurdhiTableAdapter1;
    }
}