
namespace YurtKayıtSistemiii
{
    partial class FrmOgrenciRapor
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
            this.OgrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.YurtkayıtDataSet22 = new YurtKayıtSistemiii.YurtkayıtDataSet22();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.OgrenciTableAdapter = new YurtKayıtSistemiii.YurtkayıtDataSet22TableAdapters.OgrenciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OgrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YurtkayıtDataSet22)).BeginInit();
            this.SuspendLayout();
            // 
            // OgrenciBindingSource
            // 
            this.OgrenciBindingSource.DataMember = "Ogrenci";
            this.OgrenciBindingSource.DataSource = this.YurtkayıtDataSet22;
            // 
            // YurtkayıtDataSet22
            // 
            this.YurtkayıtDataSet22.DataSetName = "YurtkayıtDataSet22";
            this.YurtkayıtDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.OgrenciBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "YurtKayıtSistemiii.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1595, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // OgrenciTableAdapter
            // 
            this.OgrenciTableAdapter.ClearBeforeFill = true;
            // 
            // FrmOgrenciRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1595, 450);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOgrenciRapor";
            this.Text = "Ögrenci Rapor";
            this.Load += new System.EventHandler(this.FrmOgrenciRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OgrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YurtkayıtDataSet22)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OgrenciBindingSource;
        private YurtkayıtDataSet22 YurtkayıtDataSet22;
        private YurtkayıtDataSet22TableAdapters.OgrenciTableAdapter OgrenciTableAdapter;
    }
}