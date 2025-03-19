namespace АРМ_реєстратури_лікарні
{
	partial class Appointments
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Service_TextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.Patient_TextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Service_ID_TextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.Patient_ID_TextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.Time_TextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.Appointment_ID_TextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Report_Button = new System.Windows.Forms.Button();
			this.Update_Button = new System.Windows.Forms.Button();
			this.Delete_Button = new System.Windows.Forms.Button();
			this.Add_Button = new System.Windows.Forms.Button();
			this.Clear_Button = new System.Windows.Forms.Button();
			this.Reload_Button = new System.Windows.Forms.Button();
			this.CurrentDate_Button = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 382);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(1258, 259);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.CurrentDate_Button);
			this.groupBox1.Controls.Add(this.Service_TextBox);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.Patient_TextBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.Service_ID_TextBox);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.Patient_ID_TextBox);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.Time_TextBox);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.Appointment_ID_TextBox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1258, 323);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = " Дані";
			// 
			// Service_TextBox
			// 
			this.Service_TextBox.Enabled = false;
			this.Service_TextBox.Location = new System.Drawing.Point(781, 163);
			this.Service_TextBox.Name = "Service_TextBox";
			this.Service_TextBox.Size = new System.Drawing.Size(300, 22);
			this.Service_TextBox.TabIndex = 45;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(794, 144);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(122, 16);
			this.label6.TabIndex = 44;
			this.label6.Text = "Медична послуга";
			// 
			// Patient_TextBox
			// 
			this.Patient_TextBox.Enabled = false;
			this.Patient_TextBox.Location = new System.Drawing.Point(781, 119);
			this.Patient_TextBox.Name = "Patient_TextBox";
			this.Patient_TextBox.Size = new System.Drawing.Size(300, 22);
			this.Patient_TextBox.TabIndex = 43;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(794, 100);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 16);
			this.label1.TabIndex = 42;
			this.label1.Text = "Пацієнт";
			// 
			// Service_ID_TextBox
			// 
			this.Service_ID_TextBox.Location = new System.Drawing.Point(625, 163);
			this.Service_ID_TextBox.Name = "Service_ID_TextBox";
			this.Service_ID_TextBox.Size = new System.Drawing.Size(150, 22);
			this.Service_ID_TextBox.TabIndex = 41;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(625, 144);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(150, 16);
			this.label5.TabIndex = 40;
			this.label5.Text = "Код медичної послуги";
			// 
			// Patient_ID_TextBox
			// 
			this.Patient_ID_TextBox.Location = new System.Drawing.Point(625, 119);
			this.Patient_ID_TextBox.Name = "Patient_ID_TextBox";
			this.Patient_ID_TextBox.Size = new System.Drawing.Size(150, 22);
			this.Patient_ID_TextBox.TabIndex = 39;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(638, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 16);
			this.label4.TabIndex = 38;
			this.label4.Text = "Код пацієнта";
			// 
			// Time_TextBox
			// 
			this.Time_TextBox.Enabled = false;
			this.Time_TextBox.Location = new System.Drawing.Point(122, 163);
			this.Time_TextBox.Name = "Time_TextBox";
			this.Time_TextBox.Size = new System.Drawing.Size(300, 22);
			this.Time_TextBox.TabIndex = 37;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(135, 144);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 16);
			this.label3.TabIndex = 36;
			this.label3.Text = "Дата та час запису";
			// 
			// Appointment_ID_TextBox
			// 
			this.Appointment_ID_TextBox.Enabled = false;
			this.Appointment_ID_TextBox.Location = new System.Drawing.Point(122, 119);
			this.Appointment_ID_TextBox.Name = "Appointment_ID_TextBox";
			this.Appointment_ID_TextBox.Size = new System.Drawing.Size(300, 22);
			this.Appointment_ID_TextBox.TabIndex = 35;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(135, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 16);
			this.label2.TabIndex = 34;
			this.label2.Text = "Код запису";
			// 
			// Report_Button
			// 
			this.Report_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Report_Button.Location = new System.Drawing.Point(311, 341);
			this.Report_Button.Name = "Report_Button";
			this.Report_Button.Size = new System.Drawing.Size(110, 35);
			this.Report_Button.TabIndex = 13;
			this.Report_Button.Text = "Звіт";
			this.Report_Button.UseVisualStyleBackColor = true;
			this.Report_Button.Click += new System.EventHandler(this.Report_Button_Click);
			// 
			// Update_Button
			// 
			this.Update_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Update_Button.Location = new System.Drawing.Point(1044, 341);
			this.Update_Button.Name = "Update_Button";
			this.Update_Button.Size = new System.Drawing.Size(110, 35);
			this.Update_Button.TabIndex = 12;
			this.Update_Button.Text = "Змінити";
			this.Update_Button.UseVisualStyleBackColor = true;
			this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
			// 
			// Delete_Button
			// 
			this.Delete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Delete_Button.Location = new System.Drawing.Point(1160, 341);
			this.Delete_Button.Name = "Delete_Button";
			this.Delete_Button.Size = new System.Drawing.Size(110, 35);
			this.Delete_Button.TabIndex = 11;
			this.Delete_Button.Text = "Видалити";
			this.Delete_Button.UseVisualStyleBackColor = true;
			this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
			// 
			// Add_Button
			// 
			this.Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Add_Button.Location = new System.Drawing.Point(928, 341);
			this.Add_Button.Name = "Add_Button";
			this.Add_Button.Size = new System.Drawing.Size(110, 35);
			this.Add_Button.TabIndex = 10;
			this.Add_Button.Text = "Додати";
			this.Add_Button.UseVisualStyleBackColor = true;
			this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
			// 
			// Clear_Button
			// 
			this.Clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Clear_Button.Location = new System.Drawing.Point(632, 341);
			this.Clear_Button.Name = "Clear_Button";
			this.Clear_Button.Size = new System.Drawing.Size(110, 35);
			this.Clear_Button.TabIndex = 9;
			this.Clear_Button.Text = "Очистити";
			this.Clear_Button.UseVisualStyleBackColor = true;
			this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
			// 
			// Reload_Button
			// 
			this.Reload_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Reload_Button.Location = new System.Drawing.Point(12, 341);
			this.Reload_Button.Name = "Reload_Button";
			this.Reload_Button.Size = new System.Drawing.Size(110, 35);
			this.Reload_Button.TabIndex = 8;
			this.Reload_Button.Text = "Оновити";
			this.Reload_Button.UseVisualStyleBackColor = true;
			this.Reload_Button.Click += new System.EventHandler(this.Reload_Button_Click);
			// 
			// CurrentDate_Button
			// 
			this.CurrentDate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CurrentDate_Button.Location = new System.Drawing.Point(428, 160);
			this.CurrentDate_Button.Name = "CurrentDate_Button";
			this.CurrentDate_Button.Size = new System.Drawing.Size(108, 29);
			this.CurrentDate_Button.TabIndex = 46;
			this.CurrentDate_Button.Text = "Дата";
			this.CurrentDate_Button.UseVisualStyleBackColor = true;
			this.CurrentDate_Button.Click += new System.EventHandler(this.CurrentDate_Button_Click);
			// 
			// Appointments
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1282, 653);
			this.Controls.Add(this.Report_Button);
			this.Controls.Add(this.Update_Button);
			this.Controls.Add(this.Delete_Button);
			this.Controls.Add(this.Add_Button);
			this.Controls.Add(this.Clear_Button);
			this.Controls.Add(this.Reload_Button);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Appointments";
			this.Text = "Записи до лікарів";
			this.Load += new System.EventHandler(this.Appointments_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button Report_Button;
		private System.Windows.Forms.Button Update_Button;
		private System.Windows.Forms.Button Delete_Button;
		private System.Windows.Forms.Button Add_Button;
		private System.Windows.Forms.Button Clear_Button;
		private System.Windows.Forms.Button Reload_Button;
		private System.Windows.Forms.TextBox Appointment_ID_TextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Service_ID_TextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox Patient_ID_TextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox Time_TextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Service_TextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox Patient_TextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button CurrentDate_Button;
	}
}