namespace АРМ_реєстратури_лікарні
{
	partial class Doctors_Schedules
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.BeginLunchBreak_TextBox = new System.Windows.Forms.TextBox();
			this.EndLunchBreak_TextBox = new System.Windows.Forms.TextBox();
			this.BeginWorkDay_TextBox = new System.Windows.Forms.TextBox();
			this.EndWorkDay_TextBox = new System.Windows.Forms.TextBox();
			this.Schedule_ID_TextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Update_Button = new System.Windows.Forms.Button();
			this.Delete_Button = new System.Windows.Forms.Button();
			this.Add_Button = new System.Windows.Forms.Button();
			this.Clear_Button = new System.Windows.Forms.Button();
			this.Reload_Button = new System.Windows.Forms.Button();
			this.Report_Button = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.BeginLunchBreak_TextBox);
			this.groupBox1.Controls.Add(this.EndLunchBreak_TextBox);
			this.groupBox1.Controls.Add(this.BeginWorkDay_TextBox);
			this.groupBox1.Controls.Add(this.EndWorkDay_TextBox);
			this.groupBox1.Controls.Add(this.Schedule_ID_TextBox);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1258, 323);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = " Дані";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(244, 179);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(240, 16);
			this.label13.TabIndex = 31;
			this.label13.Text = "Початок та кінець обідньої перерви";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(255, 135);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(216, 16);
			this.label12.TabIndex = 30;
			this.label12.Text = "Початок та кінець робочого дня";
			// 
			// BeginLunchBreak_TextBox
			// 
			this.BeginLunchBreak_TextBox.Enabled = false;
			this.BeginLunchBreak_TextBox.Location = new System.Drawing.Point(208, 198);
			this.BeginLunchBreak_TextBox.Name = "BeginLunchBreak_TextBox";
			this.BeginLunchBreak_TextBox.Size = new System.Drawing.Size(150, 22);
			this.BeginLunchBreak_TextBox.TabIndex = 29;
			// 
			// EndLunchBreak_TextBox
			// 
			this.EndLunchBreak_TextBox.Enabled = false;
			this.EndLunchBreak_TextBox.Location = new System.Drawing.Point(364, 198);
			this.EndLunchBreak_TextBox.Name = "EndLunchBreak_TextBox";
			this.EndLunchBreak_TextBox.Size = new System.Drawing.Size(150, 22);
			this.EndLunchBreak_TextBox.TabIndex = 27;
			// 
			// BeginWorkDay_TextBox
			// 
			this.BeginWorkDay_TextBox.Enabled = false;
			this.BeginWorkDay_TextBox.Location = new System.Drawing.Point(208, 154);
			this.BeginWorkDay_TextBox.Name = "BeginWorkDay_TextBox";
			this.BeginWorkDay_TextBox.Size = new System.Drawing.Size(150, 22);
			this.BeginWorkDay_TextBox.TabIndex = 25;
			// 
			// EndWorkDay_TextBox
			// 
			this.EndWorkDay_TextBox.Enabled = false;
			this.EndWorkDay_TextBox.Location = new System.Drawing.Point(364, 154);
			this.EndWorkDay_TextBox.Name = "EndWorkDay_TextBox";
			this.EndWorkDay_TextBox.Size = new System.Drawing.Size(150, 22);
			this.EndWorkDay_TextBox.TabIndex = 23;
			// 
			// Schedule_ID_TextBox
			// 
			this.Schedule_ID_TextBox.Location = new System.Drawing.Point(283, 110);
			this.Schedule_ID_TextBox.Name = "Schedule_ID_TextBox";
			this.Schedule_ID_TextBox.Size = new System.Drawing.Size(150, 22);
			this.Schedule_ID_TextBox.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(296, 91);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(97, 16);
			this.label7.TabIndex = 12;
			this.label7.Text = "Код розкладу";
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
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
			// 
			// Update_Button
			// 
			this.Update_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Update_Button.Location = new System.Drawing.Point(1044, 341);
			this.Update_Button.Name = "Update_Button";
			this.Update_Button.Size = new System.Drawing.Size(110, 35);
			this.Update_Button.TabIndex = 11;
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
			this.Delete_Button.TabIndex = 10;
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
			this.Add_Button.TabIndex = 9;
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
			this.Clear_Button.TabIndex = 8;
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
			this.Reload_Button.TabIndex = 7;
			this.Reload_Button.Text = "Оновити";
			this.Reload_Button.UseVisualStyleBackColor = true;
			this.Reload_Button.Click += new System.EventHandler(this.Reload_Button_Click);
			// 
			// Report_Button
			// 
			this.Report_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Report_Button.Location = new System.Drawing.Point(311, 341);
			this.Report_Button.Name = "Report_Button";
			this.Report_Button.Size = new System.Drawing.Size(110, 35);
			this.Report_Button.TabIndex = 12;
			this.Report_Button.Text = "Звіт";
			this.Report_Button.UseVisualStyleBackColor = true;
			this.Report_Button.Click += new System.EventHandler(this.Report_Button_Click);
			// 
			// Doctors_Schedules
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
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Doctors_Schedules";
			this.Text = "Розклад лікарів";
			this.Load += new System.EventHandler(this.Doctors_Schedules_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox BeginLunchBreak_TextBox;
		private System.Windows.Forms.TextBox EndLunchBreak_TextBox;
		private System.Windows.Forms.TextBox BeginWorkDay_TextBox;
		private System.Windows.Forms.TextBox EndWorkDay_TextBox;
		private System.Windows.Forms.TextBox Schedule_ID_TextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button Update_Button;
		private System.Windows.Forms.Button Delete_Button;
		private System.Windows.Forms.Button Add_Button;
		private System.Windows.Forms.Button Clear_Button;
		private System.Windows.Forms.Button Reload_Button;
		private System.Windows.Forms.Button Report_Button;
	}
}