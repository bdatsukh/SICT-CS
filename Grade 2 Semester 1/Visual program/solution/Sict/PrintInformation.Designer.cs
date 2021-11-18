
namespace Sict
{
    partial class PrintInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintInformation));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SictDataSet = new Sict.SictDataSet();
            this.STUDENTINFORMATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.STUDENTINFORMATIONTableAdapter = new Sict.SictDataSetTableAdapters.STUDENTINFORMATIONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SictDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STUDENTINFORMATIONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.STUDENTINFORMATIONBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sict.StudentReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1218, 718);
            this.reportViewer1.TabIndex = 0;
            // 
            // SictDataSet
            // 
            this.SictDataSet.DataSetName = "SictDataSet";
            this.SictDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // STUDENTINFORMATIONBindingSource
            // 
            this.STUDENTINFORMATIONBindingSource.DataMember = "STUDENTINFORMATION";
            this.STUDENTINFORMATIONBindingSource.DataSource = this.SictDataSet;
            // 
            // STUDENTINFORMATIONTableAdapter
            // 
            this.STUDENTINFORMATIONTableAdapter.ClearBeforeFill = true;
            // 
            // PrintInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 718);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrintInformation";
            this.Text = "PrintInformation";
            this.Load += new System.EventHandler(this.PrintInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SictDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STUDENTINFORMATIONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource STUDENTINFORMATIONBindingSource;
        private SictDataSet SictDataSet;
        private SictDataSetTableAdapters.STUDENTINFORMATIONTableAdapter STUDENTINFORMATIONTableAdapter;
    }
}