namespace АРМ_реєстратури_лікарні
{
	partial class Medical_Services_Report
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
			this.medicalServicesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.medical_Services_DataSet = new АРМ_реєстратури_лікарні.DataSets.Medical_Services_DataSet();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.Medical_ServicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.medicalServicesDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.medical_Services_DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Medical_ServicesBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// medicalServicesDataSetBindingSource
			// 
			this.medicalServicesDataSetBindingSource.DataSource = this.medical_Services_DataSet;
			this.medicalServicesDataSetBindingSource.Position = 0;
			// 
			// medical_Services_DataSet
			// 
			this.medical_Services_DataSet.DataSetName = "Medical_Services_DataSet";
			this.medical_Services_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// reportViewer1
			// 
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource1.Name = "DataSet1";
			reportDataSource1.Value = this.medicalServicesDataSetBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "АРМ_реєстратури_лікарні.WorkForms.Medical_Services_Report.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(1282, 653);
			this.reportViewer1.TabIndex = 0;
			// 
			// Medical_ServicesBindingSource
			// 
			this.Medical_ServicesBindingSource.DataMember = "Medical_Services";
			this.Medical_ServicesBindingSource.DataSource = this.medical_Services_DataSet;
			// 
			// Medical_Services_Report
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1282, 653);
			this.Controls.Add(this.reportViewer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Medical_Services_Report";
			this.Text = "Medical_Service_Report";
			this.Load += new System.EventHandler(this.Medical_Service_Report_Load);
			((System.ComponentModel.ISupportInitialize)(this.medicalServicesDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.medical_Services_DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Medical_ServicesBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource medicalServicesDataSetBindingSource;
		private DataSets.Medical_Services_DataSet medical_Services_DataSet;
		private System.Windows.Forms.BindingSource Medical_ServicesBindingSource;
	}
}