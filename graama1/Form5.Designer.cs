namespace graama1
{
    partial class Form5
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
            this.familyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.graamaDataSet6 = new graama1.graamaDataSet6();
            this.villageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.graamaDataSet7 = new graama1.graamaDataSet7();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.graamaDataSet3 = new graama1.graamaDataSet3();
            this.filterfamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filterfamTableAdapter = new graama1.graamaDataSet3TableAdapters.filterfamTableAdapter();
            this.graamaDataSet4 = new graama1.graamaDataSet4();
            this.graamaDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filterfamBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.filterfamTableAdapter1 = new graama1.graamaDataSet4TableAdapters.filterfamTableAdapter();
            this.graamaDataSet5 = new graama1.graamaDataSet5();
            this.graamaDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.familyTableAdapter = new graama1.graamaDataSet6TableAdapters.familyTableAdapter();
            this.villageTableAdapter = new graama1.graamaDataSet7TableAdapters.villageTableAdapter();
            this.graamaDataSet23 = new graama1.graamaDataSet23();
            this.familyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.familyTableAdapter1 = new graama1.graamaDataSet23TableAdapters.familyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.familyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterfamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterfamBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // familyBindingSource
            // 
            this.familyBindingSource.DataMember = "family";
            this.familyBindingSource.DataSource = this.graamaDataSet6;
            // 
            // graamaDataSet6
            // 
            this.graamaDataSet6.DataSetName = "graamaDataSet6";
            this.graamaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // villageBindingSource
            // 
            this.villageBindingSource.DataMember = "village";
            this.villageBindingSource.DataSource = this.graamaDataSet7;
            // 
            // graamaDataSet7
            // 
            this.graamaDataSet7.DataSetName = "graamaDataSet7";
            this.graamaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.familyBindingSource1;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.villageBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "graama1.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // graamaDataSet3
            // 
            this.graamaDataSet3.DataSetName = "graamaDataSet3";
            this.graamaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filterfamBindingSource
            // 
            this.filterfamBindingSource.DataMember = "filterfam";
            this.filterfamBindingSource.DataSource = this.graamaDataSet3;
            // 
            // filterfamTableAdapter
            // 
            this.filterfamTableAdapter.ClearBeforeFill = true;
            // 
            // graamaDataSet4
            // 
            this.graamaDataSet4.DataSetName = "graamaDataSet4";
            this.graamaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // graamaDataSet4BindingSource
            // 
            this.graamaDataSet4BindingSource.DataSource = this.graamaDataSet4;
            this.graamaDataSet4BindingSource.Position = 0;
            // 
            // filterfamBindingSource1
            // 
            this.filterfamBindingSource1.DataMember = "filterfam";
            this.filterfamBindingSource1.DataSource = this.graamaDataSet4BindingSource;
            // 
            // filterfamTableAdapter1
            // 
            this.filterfamTableAdapter1.ClearBeforeFill = true;
            // 
            // graamaDataSet5
            // 
            this.graamaDataSet5.DataSetName = "graamaDataSet5";
            this.graamaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // graamaDataSet5BindingSource
            // 
            this.graamaDataSet5BindingSource.DataSource = this.graamaDataSet5;
            this.graamaDataSet5BindingSource.Position = 0;
            // 
            // familyTableAdapter
            // 
            this.familyTableAdapter.ClearBeforeFill = true;
            // 
            // villageTableAdapter
            // 
            this.villageTableAdapter.ClearBeforeFill = true;
            // 
            // graamaDataSet23
            // 
            this.graamaDataSet23.DataSetName = "graamaDataSet23";
            this.graamaDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // familyBindingSource1
            // 
            this.familyBindingSource1.DataMember = "family";
            this.familyBindingSource1.DataSource = this.graamaDataSet23;
            // 
            // familyTableAdapter1
            // 
            this.familyTableAdapter1.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.familyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterfamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterfamBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private graamaDataSet3 graamaDataSet3;
        private System.Windows.Forms.BindingSource filterfamBindingSource;
        private graamaDataSet3TableAdapters.filterfamTableAdapter filterfamTableAdapter;
        private graamaDataSet4 graamaDataSet4;
        private System.Windows.Forms.BindingSource graamaDataSet4BindingSource;
        private System.Windows.Forms.BindingSource filterfamBindingSource1;
        private graamaDataSet4TableAdapters.filterfamTableAdapter filterfamTableAdapter1;
        private graamaDataSet5 graamaDataSet5;
        private System.Windows.Forms.BindingSource graamaDataSet5BindingSource;
        private graamaDataSet6 graamaDataSet6;
        private System.Windows.Forms.BindingSource familyBindingSource;
        private graamaDataSet6TableAdapters.familyTableAdapter familyTableAdapter;
        private graamaDataSet7 graamaDataSet7;
        private System.Windows.Forms.BindingSource villageBindingSource;
        private graamaDataSet7TableAdapters.villageTableAdapter villageTableAdapter;
        private graamaDataSet23 graamaDataSet23;
        private System.Windows.Forms.BindingSource familyBindingSource1;
        private graamaDataSet23TableAdapters.familyTableAdapter familyTableAdapter1;
    }
}