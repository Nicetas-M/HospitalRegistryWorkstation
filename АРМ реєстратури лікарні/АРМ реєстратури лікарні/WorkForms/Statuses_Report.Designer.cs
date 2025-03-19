namespace АРМ_реєстратури_лікарні
{
	partial class Statuses_Report
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
			this.statusesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.statuses_DataSet = new АРМ_реєстратури_лікарні.DataSets.Statuses_DataSet();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.StatusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.statusesDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statuses_DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.StatusesBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// statusesDataSetBindingSource
			// 
			this.statusesDataSetBindingSource.DataSource = this.statuses_DataSet;
			this.statusesDataSetBindingSource.Position = 0;
			// 
			// statuses_DataSet
			// 
			this.statuses_DataSet.DataSetName = "Statuses_DataSet";
			this.statuses_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// reportViewer1
			// 
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource1.Name = "DataSet1";
			reportDataSource1.Value = this.statusesDataSetBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "АРМ_реєстратури_лікарні.WorkForms.Statuses_Report.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(1382, 553);
			this.reportViewer1.TabIndex = 0;
			// 
			// StatusesBindingSource
			// 
			this.StatusesBindingSource.DataMember = "Statuses";
			this.StatusesBindingSource.DataSource = this.statuses_DataSet;
			// 
			// Statuses_Report
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1382, 553);
			this.Controls.Add(this.reportViewer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Statuses_Report";
			this.Text = "Statuses_Report";
			this.Load += new System.EventHandler(this.Statuses_Report_Load);
			((System.ComponentModel.ISupportInitialize)(this.statusesDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statuses_DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.StatusesBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource statusesDataSetBindingSource;
		private DataSets.Statuses_DataSet statuses_DataSet;
		private System.Windows.Forms.BindingSource StatusesBindingSource;
	}
}