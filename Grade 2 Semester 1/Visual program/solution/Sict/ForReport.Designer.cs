
namespace Sict
{
    partial class ForReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForReport));
            this.PRINTGRADEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SictDataSet1 = new Sict.SictDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PRINTGRADETableAdapter = new Sict.SictDataSet1TableAdapters.PRINTGRADETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PRINTGRADEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SictDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // PRINTGRADEBindingSource
            // 
            this.PRINTGRADEBindingSource.DataMember = "PRINTGRADE";
            this.PRINTGRADEBindingSource.DataSource = this.SictDataSet1;
            // 
            // SictDataSet1
            // 
            this.SictDataSet1.DataSetName = "SictDataSet1";
            this.SictDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PRINTGRADEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sict.Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1218, 718);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // PRINTGRADETableAdapter
            // 
            this.PRINTGRADETableAdapter.ClearBeforeFill = true;
            // 
            // ForReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 718);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForReport";
            this.Text = "ForReport";
            this.Load += new System.EventHandler(this.ForReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PRINTGRADEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SictDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PRINTGRADEBindingSource;
        private SictDataSet1 SictDataSet1;
        private SictDataSet1TableAdapters.PRINTGRADETableAdapter PRINTGRADETableAdapter;
    }
}