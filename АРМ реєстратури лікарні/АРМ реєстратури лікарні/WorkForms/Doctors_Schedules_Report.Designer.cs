namespace АРМ_реєстратури_лікарні
{
	partial class Doctors_Schedules_Report
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
			this.doctorsSchedulesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.doctors_Schedules_DataSet = new АРМ_реєстратури_лікарні.DataSets.Doctors_Schedules_DataSet();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.Doctors_SchedulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.doctorsSchedulesDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.doctors_Schedules_DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Doctors_SchedulesBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// doctorsSchedulesDataSetBindingSource
			// 
			this.doctorsSchedulesDataSetBindingSource.DataSource = this.doctors_Schedules_DataSet;
			this.doctorsSchedulesDataSetBindingSource.Position = 0;
			// 
			// doctors_Schedules_DataSet
			// 
			this.doctors_Schedules_DataSet.DataSetName = "Doctors_Schedules_DataSet";
			this.doctors_Schedules_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// reportViewer1
			// 
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource1.Name = "DataSet1";
			reportDataSource1.Value = this.doctorsSchedulesDataSetBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "АРМ_реєстратури_лікарні.WorkForms.Doctors_Schedules_Report.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(1382, 553);
			this.reportViewer1.TabIndex = 0;
			// 
			// Doctors_SchedulesBindingSource
			// 
			this.Doctors_SchedulesBindingSource.DataMember = "Doctors_Schedules";
			this.Doctors_SchedulesBindingSource.DataSource = this.doctors_Schedules_DataSet;
			// 
			// Doctors_Schedules_Report
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1382, 553);
			this.Controls.Add(this.reportViewer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Doctors_Schedules_Report";
			this.Text = "Doctors_Schedules_Report";
			this.Load += new System.EventHandler(this.Doctors_Schedules_Report_Load);
			((System.ComponentModel.ISupportInitialize)(this.doctorsSchedulesDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.doctors_Schedules_DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Doctors_SchedulesBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource doctorsSchedulesDataSetBindingSource;
		private DataSets.Doctors_Schedules_DataSet doctors_Schedules_DataSet;
		private System.Windows.Forms.BindingSource Doctors_SchedulesBindingSource;
	}
}