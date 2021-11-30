namespace graama1
{
    partial class Form12
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
            this.certiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.graamaDataSet18 = new graama1.graamaDataSet18();
            this.villageBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.graamaDataSet19 = new graama1.graamaDataSet19();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.graamaDataSet15 = new graama1.graamaDataSet15();
            this.characterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.characterTableAdapter = new graama1.graamaDataSet15TableAdapters.characterTableAdapter();
            this.graamaDataSet7 = new graama1.graamaDataSet7();
            this.villageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.villageTableAdapter = new graama1.graamaDataSet7TableAdapters.villageTableAdapter();
            this.graamaDataSet11 = new graama1.graamaDataSet11();
            this.mahapolaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahapolaTableAdapter = new graama1.graamaDataSet11TableAdapters.mahapolaTableAdapter();
            this.graamaDataSet16 = new graama1.graamaDataSet16();
            this.villageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.villageTableAdapter1 = new graama1.graamaDataSet16TableAdapters.villageTableAdapter();
            this.certiTableAdapter = new graama1.graamaDataSet18TableAdapters.certiTableAdapter();
            this.villageTableAdapter2 = new graama1.graamaDataSet19TableAdapters.villageTableAdapter();
            this.graamaDataSet21 = new graama1.graamaDataSet21();
            this.curcertBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.curcertTableAdapter = new graama1.graamaDataSet21TableAdapters.curcertTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.certiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahapolaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcertBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // certiBindingSource
            // 
            this.certiBindingSource.DataMember = "certi";
            this.certiBindingSource.DataSource = this.graamaDataSet18;
            // 
            // graamaDataSet18
            // 
            this.graamaDataSet18.DataSetName = "graamaDataSet18";
            this.graamaDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // villageBindingSource2
            // 
            this.villageBindingSource2.DataMember = "village";
            this.villageBindingSource2.DataSource = this.graamaDataSet19;
            // 
            // graamaDataSet19
            // 
            this.graamaDataSet19.DataSetName = "graamaDataSet19";
            this.graamaDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.curcertBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "graama1.certReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // graamaDataSet15
            // 
            this.graamaDataSet15.DataSetName = "graamaDataSet15";
            this.graamaDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // characterBindingSource
            // 
            this.characterBindingSource.DataMember = "character";
            this.characterBindingSource.DataSource = this.graamaDataSet15;
            // 
            // characterTableAdapter
            // 
            this.characterTableAdapter.ClearBeforeFill = true;
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
            // graamaDataSet16
            // 
            this.graamaDataSet16.DataSetName = "graamaDataSet16";
            this.graamaDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // villageBindingSource1
            // 
            this.villageBindingSource1.DataMember = "village";
            this.villageBindingSource1.DataSource = this.graamaDataSet16;
            // 
            // villageTableAdapter1
            // 
            this.villageTableAdapter1.ClearBeforeFill = true;
            // 
            // certiTableAdapter
            // 
            this.certiTableAdapter.ClearBeforeFill = true;
            // 
            // villageTableAdapter2
            // 
            this.villageTableAdapter2.ClearBeforeFill = true;
            // 
            // graamaDataSet21
            // 
            this.graamaDataSet21.DataSetName = "graamaDataSet21";
            this.graamaDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // curcertBindingSource
            // 
            this.curcertBindingSource.DataMember = "curcert";
            this.curcertBindingSource.DataSource = this.graamaDataSet21;
            // 
            // curcertTableAdapter
            // 
            this.curcertTableAdapter.ClearBeforeFill = true;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form12";
            this.Text = "Form12";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.certiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahapolaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graamaDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curcertBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource characterBindingSource;
        private graamaDataSet15 graamaDataSet15;
        private System.Windows.Forms.BindingSource villageBindingSource;
        private graamaDataSet7 graamaDataSet7;
        private graamaDataSet15TableAdapters.characterTableAdapter characterTableAdapter;
        private graamaDataSet7TableAdapters.villageTableAdapter villageTableAdapter;
        private System.Windows.Forms.BindingSource mahapolaBindingSource;
        private graamaDataSet11 graamaDataSet11;
        private graamaDataSet11TableAdapters.mahapolaTableAdapter mahapolaTableAdapter;
        private graamaDataSet16 graamaDataSet16;
        private System.Windows.Forms.BindingSource villageBindingSource1;
        private graamaDataSet16TableAdapters.villageTableAdapter villageTableAdapter1;
        private graamaDataSet18 graamaDataSet18;
        private System.Windows.Forms.BindingSource certiBindingSource;
        private graamaDataSet18TableAdapters.certiTableAdapter certiTableAdapter;
        private graamaDataSet19 graamaDataSet19;
        private System.Windows.Forms.BindingSource villageBindingSource2;
        private graamaDataSet19TableAdapters.villageTableAdapter villageTableAdapter2;
        private graamaDataSet21 graamaDataSet21;
        private System.Windows.Forms.BindingSource curcertBindingSource;
        private graamaDataSet21TableAdapters.curcertTableAdapter curcertTableAdapter;
    }
}