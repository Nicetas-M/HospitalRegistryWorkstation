namespace АРМ_реєстратури_лікарні
{
	partial class Dispensary_Groups_Report
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
			this.dispensaryGroupsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dispensary_Groups_DataSet = new АРМ_реєстратури_лікарні.DataSets.Dispensary_Groups_DataSet();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.Dispensary_GroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dispensaryGroupsDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dispensary_Groups_DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dispensary_GroupsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dispensaryGroupsDataSetBindingSource
			// 
			this.dispensaryGroupsDataSetBindingSource.DataSource = this.dispensary_Groups_DataSet;
			this.dispensaryGroupsDataSetBindingSource.Position = 0;
			// 
			// dispensary_Groups_DataSet
			// 
			this.dispensary_Groups_DataSet.DataSetName = "Dispensary_Groups_DataSet";
			this.dispensary_Groups_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// reportViewer1
			// 
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource1.Name = "DataSet1";
			reportDataSource1.Value = this.dispensaryGroupsDataSetBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "АРМ_реєстратури_лікарні.WorkForms.Dispensary_Groups_Report.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(1282, 653);
			this.reportViewer1.TabIndex = 0;
			// 
			// Dispensary_GroupsBindingSource
			// 
			this.Dispensary_GroupsBindingSource.DataMember = "Dispensary_Groups";
			this.Dispensary_GroupsBindingSource.DataSource = this.dispensary_Groups_DataSet;
			// 
			// Dispensary_Groups_Report
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1282, 653);
			this.Controls.Add(this.reportViewer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Dispensary_Groups_Report";
			this.Text = "Dispensary_Groups_Report";
			this.Load += new System.EventHandler(this.Dispensary_Groups_Report_Load);
			((System.ComponentModel.ISupportInitialize)(this.dispensaryGroupsDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dispensary_Groups_DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dispensary_GroupsBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource dispensaryGroupsDataSetBindingSource;
		private DataSets.Dispensary_Groups_DataSet dispensary_Groups_DataSet;
		private System.Windows.Forms.BindingSource Dispensary_GroupsBindingSource;
	}
}