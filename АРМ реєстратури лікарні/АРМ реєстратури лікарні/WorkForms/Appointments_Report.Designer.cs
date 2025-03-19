namespace АРМ_реєстратури_лікарні
{
	partial class Appointments_Report
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
			this.appointmentsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.appointments_DataSet = new АРМ_реєстратури_лікарні.DataSets.Appointments_DataSet();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.AppointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.appointmentsDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.appointments_DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AppointmentsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// appointmentsDataSetBindingSource
			// 
			this.appointmentsDataSetBindingSource.DataSource = this.appointments_DataSet;
			this.appointmentsDataSetBindingSource.Position = 0;
			// 
			// appointments_DataSet
			// 
			this.appointments_DataSet.DataSetName = "Appointments_DataSet";
			this.appointments_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// reportViewer1
			// 
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource1.Name = "DataSet1";
			reportDataSource1.Value = this.appointmentsDataSetBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "АРМ_реєстратури_лікарні.WorkForms.Appointments_Report.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(1382, 553);
			this.reportViewer1.TabIndex = 0;
			// 
			// AppointmentsBindingSource
			// 
			this.AppointmentsBindingSource.DataMember = "Appointments";
			this.AppointmentsBindingSource.DataSource = this.appointments_DataSet;
			// 
			// Appointments_Report
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1382, 553);
			this.Controls.Add(this.reportViewer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Appointments_Report";
			this.Text = "Appointments_Report";
			this.Load += new System.EventHandler(this.Appointments_Report_Load);
			((System.ComponentModel.ISupportInitialize)(this.appointmentsDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.appointments_DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AppointmentsBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource appointmentsDataSetBindingSource;
		private DataSets.Appointments_DataSet appointments_DataSet;
		private System.Windows.Forms.BindingSource AppointmentsBindingSource;
	}
}