namespace АРМ_реєстратури_лікарні
{
	partial class Genders_Report
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
			this.gendersDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.genders_DataSet = new АРМ_реєстратури_лікарні.DataSets.Genders_DataSet();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.GendersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.gendersDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.genders_DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GendersBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// gendersDataSetBindingSource
			// 
			this.gendersDataSetBindingSource.DataSource = this.genders_DataSet;
			this.gendersDataSetBindingSource.Position = 0;
			// 
			// genders_DataSet
			// 
			this.genders_DataSet.DataSetName = "Genders_DataSet";
			this.genders_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// reportViewer1
			// 
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource1.Name = "DataSet1";
			reportDataSource1.Value = this.gendersDataSetBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "АРМ_реєстратури_лікарні.WorkForms.Genders_Report.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(1282, 653);
			this.reportViewer1.TabIndex = 0;
			// 
			// GendersBindingSource
			// 
			this.GendersBindingSource.DataMember = "Genders";
			this.GendersBindingSource.DataSource = this.genders_DataSet;
			// 
			// Genders_Report
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1282, 653);
			this.Controls.Add(this.reportViewer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Genders_Report";
			this.Text = "Genders_Report";
			this.Load += new System.EventHandler(this.Genders_Report_Load);
			((System.ComponentModel.ISupportInitialize)(this.gendersDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.genders_DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GendersBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource gendersDataSetBindingSource;
		private DataSets.Genders_DataSet genders_DataSet;
		private System.Windows.Forms.BindingSource GendersBindingSource;
	}
}