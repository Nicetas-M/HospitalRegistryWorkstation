namespace АРМ_реєстратури_лікарні
{
	partial class Contingents_Report
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
			this.contingentsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.contingents_DataSet = new АРМ_реєстратури_лікарні.DataSets.Contingents_DataSet();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.ContingentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.contingentsDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.contingents_DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ContingentsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// contingentsDataSetBindingSource
			// 
			this.contingentsDataSetBindingSource.DataSource = this.contingents_DataSet;
			this.contingentsDataSetBindingSource.Position = 0;
			// 
			// contingents_DataSet
			// 
			this.contingents_DataSet.DataSetName = "Contingents_DataSet";
			this.contingents_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// reportViewer1
			// 
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource1.Name = "DataSet1";
			reportDataSource1.Value = this.contingentsDataSetBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "АРМ_реєстратури_лікарні.WorkForms.Contingents_Report.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(1382, 553);
			this.reportViewer1.TabIndex = 0;
			// 
			// ContingentsBindingSource
			// 
			this.ContingentsBindingSource.DataMember = "Contingents";
			this.ContingentsBindingSource.DataSource = this.contingents_DataSet;
			// 
			// Contingents_Report
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1382, 553);
			this.Controls.Add(this.reportViewer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Contingents_Report";
			this.Text = "Contingents_Report";
			this.Load += new System.EventHandler(this.Contingents_Report_Load);
			((System.ComponentModel.ISupportInitialize)(this.contingentsDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.contingents_DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ContingentsBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource contingentsDataSetBindingSource;
		private DataSets.Contingents_DataSet contingents_DataSet;
		private System.Windows.Forms.BindingSource ContingentsBindingSource;
	}
}