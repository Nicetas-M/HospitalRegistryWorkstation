namespace АРМ_реєстратури_лікарні
{
	partial class Patients_Report
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
			this.patientsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.patients_DataSet = new АРМ_реєстратури_лікарні.DataSets.Patients_DataSet();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.PatientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.patientsDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.patients_DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PatientsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// patientsDataSetBindingSource
			// 
			this.patientsDataSetBindingSource.DataSource = this.patients_DataSet;
			this.patientsDataSetBindingSource.Position = 0;
			// 
			// patients_DataSet
			// 
			this.patients_DataSet.DataSetName = "Patients_DataSet";
			this.patients_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// reportViewer1
			// 
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource1.Name = "DataSet1";
			reportDataSource1.Value = this.patientsDataSetBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "АРМ_реєстратури_лікарні.WorkForms.Patients_Report.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(1282, 653);
			this.reportViewer1.TabIndex = 0;
			// 
			// PatientsBindingSource
			// 
			this.PatientsBindingSource.DataMember = "Patients";
			this.PatientsBindingSource.DataSource = this.patients_DataSet;
			// 
			// Patients_Report
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1282, 653);
			this.Controls.Add(this.reportViewer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Patients_Report";
			this.Text = "Patients_Report";
			this.Load += new System.EventHandler(this.Patients_Report_Load);
			((System.ComponentModel.ISupportInitialize)(this.patientsDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.patients_DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PatientsBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource patientsDataSetBindingSource;
		private DataSets.Patients_DataSet patients_DataSet;
		private System.Windows.Forms.BindingSource PatientsBindingSource;
	}
}