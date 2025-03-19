namespace АРМ_реєстратури_лікарні
{
	partial class Medical_Cards_Report
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
			this.medicalCardsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.medical_Cards_DataSet = new АРМ_реєстратури_лікарні.DataSets.Medical_Cards_DataSet();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.Medical_CardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.medicalCardsDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.medical_Cards_DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Medical_CardsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// medicalCardsDataSetBindingSource
			// 
			this.medicalCardsDataSetBindingSource.DataSource = this.medical_Cards_DataSet;
			this.medicalCardsDataSetBindingSource.Position = 0;
			// 
			// medical_Cards_DataSet
			// 
			this.medical_Cards_DataSet.DataSetName = "Medical_Cards_DataSet";
			this.medical_Cards_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// reportViewer1
			// 
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource1.Name = "DataSet1";
			reportDataSource1.Value = this.medicalCardsDataSetBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "АРМ_реєстратури_лікарні.WorkForms.Medical_Cards_Report.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(1282, 653);
			this.reportViewer1.TabIndex = 0;
			// 
			// Medical_CardsBindingSource
			// 
			this.Medical_CardsBindingSource.DataMember = "Medical_Cards";
			this.Medical_CardsBindingSource.DataSource = this.medical_Cards_DataSet;
			// 
			// Medical_Cards_Report
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1282, 653);
			this.Controls.Add(this.reportViewer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Medical_Cards_Report";
			this.Text = "Medical_Cards_Report";
			this.Load += new System.EventHandler(this.Medical_Cards_Report_Load);
			((System.ComponentModel.ISupportInitialize)(this.medicalCardsDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.medical_Cards_DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Medical_CardsBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource medicalCardsDataSetBindingSource;
		private DataSets.Medical_Cards_DataSet medical_Cards_DataSet;
		private System.Windows.Forms.BindingSource Medical_CardsBindingSource;
	}
}