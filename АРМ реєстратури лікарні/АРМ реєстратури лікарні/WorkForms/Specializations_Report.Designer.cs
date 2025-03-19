namespace АРМ_реєстратури_лікарні
{
	partial class Specializations_Report
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
			this.specializationsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.specializations_DataSet = new АРМ_реєстратури_лікарні.DataSets.Specializations_DataSet();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.SpecializationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.specializationsDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.specializations_DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SpecializationsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// specializationsDataSetBindingSource
			// 
			this.specializationsDataSetBindingSource.DataSource = this.specializations_DataSet;
			this.specializationsDataSetBindingSource.Position = 0;
			// 
			// specializations_DataSet
			// 
			this.specializations_DataSet.DataSetName = "Specializations_DataSet";
			this.specializations_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// reportViewer1
			// 
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource1.Name = "DataSet1";
			reportDataSource1.Value = this.specializationsDataSetBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "АРМ_реєстратури_лікарні.WorkForms.Specializations_Report.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(1282, 653);
			this.reportViewer1.TabIndex = 0;
			// 
			// SpecializationsBindingSource
			// 
			this.SpecializationsBindingSource.DataMember = "Specializations";
			this.SpecializationsBindingSource.DataSource = this.specializations_DataSet;
			// 
			// Specializations_Report
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1282, 653);
			this.Controls.Add(this.reportViewer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Specializations_Report";
			this.Text = "Specializations_Report";
			this.Load += new System.EventHandler(this.Specializations_Report_Load);
			((System.ComponentModel.ISupportInitialize)(this.specializationsDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.specializations_DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SpecializationsBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource specializationsDataSetBindingSource;
		private DataSets.Specializations_DataSet specializations_DataSet;
		private System.Windows.Forms.BindingSource SpecializationsBindingSource;
	}
}