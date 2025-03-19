namespace АРМ_реєстратури_лікарні
{
	partial class Qualifications_Report
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
			this.qualificationsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.qualifications_DataSet = new АРМ_реєстратури_лікарні.DataSets.Qualifications_DataSet();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.QualificationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.qualificationsDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.qualifications_DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.QualificationsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// qualificationsDataSetBindingSource
			// 
			this.qualificationsDataSetBindingSource.DataSource = this.qualifications_DataSet;
			this.qualificationsDataSetBindingSource.Position = 0;
			// 
			// qualifications_DataSet
			// 
			this.qualifications_DataSet.DataSetName = "Qualifications_DataSet";
			this.qualifications_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// reportViewer1
			// 
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource1.Name = "DataSet1";
			reportDataSource1.Value = this.qualificationsDataSetBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "АРМ_реєстратури_лікарні.WorkForms.Qualifications_Report.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(1282, 653);
			this.reportViewer1.TabIndex = 0;
			// 
			// QualificationsBindingSource
			// 
			this.QualificationsBindingSource.DataMember = "Qualifications";
			this.QualificationsBindingSource.DataSource = this.qualifications_DataSet;
			// 
			// Qualifications_Report
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1282, 653);
			this.Controls.Add(this.reportViewer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Qualifications_Report";
			this.Text = "Qualifications_Report";
			this.Load += new System.EventHandler(this.Qualifications_Report_Load);
			((System.ComponentModel.ISupportInitialize)(this.qualificationsDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.qualifications_DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.QualificationsBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource qualificationsDataSetBindingSource;
		private DataSets.Qualifications_DataSet qualifications_DataSet;
		private System.Windows.Forms.BindingSource QualificationsBindingSource;
	}
}