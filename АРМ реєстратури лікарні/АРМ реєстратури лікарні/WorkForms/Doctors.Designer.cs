namespace АРМ_реєстратури_лікарні
{
	partial class Doctors
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
			this.Doctor_ID_TextBox = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.BeginLunchBreak_TextBox = new System.Windows.Forms.TextBox();
			this.EndLunchBreak_TextBox = new System.Windows.Forms.TextBox();
			this.BeginWorkDay_TextBox = new System.Windows.Forms.TextBox();
			this.EndWorkDay_TextBox = new System.Windows.Forms.TextBox();
			this.Office_TextBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.Status_TextBox = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.Qualification_TextBox = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.Specialization_TextBox = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.Schedule_ID_TextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.Office_ID_TextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.Status_ID_TextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.Qualification_ID_TextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.Specialization_ID_TextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.Phone_TextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Full_Name_TextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Reload_Button = new System.Windows.Forms.Button();
			this.Clear_Button = new System.Windows.Forms.Button();
			this.Add_Button = new System.Windows.Forms.Button();
			this.Delete_Button = new System.Windows.Forms.Button();
			this.Update_Button = new System.Windows.Forms.Button();
			this.Report_Button = new System.Windows.Forms.Button();
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
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.Doctor_ID_TextBox);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.BeginLunchBreak_TextBox);
			this.groupBox1.Controls.Add(this.EndLunchBreak_TextBox);
			this.groupBox1.Controls.Add(this.BeginWorkDay_TextBox);
			this.groupBox1.Controls.Add(this.EndWorkDay_TextBox);
			this.groupBox1.Controls.Add(this.Office_TextBox);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.Status_TextBox);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.Qualification_TextBox);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.Specialization_TextBox);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.Schedule_ID_TextBox);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.Office_ID_TextBox);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.Status_ID_TextBox);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.Qualification_ID_TextBox);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.Specialization_ID_TextBox);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.Phone_TextBox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.Full_Name_TextBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1258, 323);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = " Дані";
			// 
			// Doctor_ID_TextBox
			// 
			this.Doctor_ID_TextBox.Enabled = false;
			this.Doctor_ID_TextBox.Location = new System.Drawing.Point(22, 103);
			this.Doctor_ID_TextBox.Name = "Doctor_ID_TextBox";
			this.Doctor_ID_TextBox.Size = new System.Drawing.Size(150, 22);
			this.Doctor_ID_TextBox.TabIndex = 33;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(35, 84);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(88, 16);
			this.label14.TabIndex = 32;
			this.label14.Text = "Код доктора";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(953, 160);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(240, 16);
			this.label13.TabIndex = 31;
			this.label13.Text = "Початок та кінець обідньої перерви";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(964, 116);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(216, 16);
			this.label12.TabIndex = 30;
			this.label12.Text = "Початок та кінець робочого дня";
			// 
			// BeginLunchBreak_TextBox
			// 
			this.BeginLunchBreak_TextBox.Enabled = false;
			this.BeginLunchBreak_TextBox.Location = new System.Drawing.Point(917, 179);
			this.BeginLunchBreak_TextBox.Name = "BeginLunchBreak_TextBox";
			this.BeginLunchBreak_TextBox.Size = new System.Drawing.Size(150, 22);
			this.BeginLunchBreak_TextBox.TabIndex = 29;
			// 
			// EndLunchBreak_TextBox
			// 
			this.EndLunchBreak_TextBox.Enabled = false;
			this.EndLunchBreak_TextBox.Location = new System.Drawing.Point(1073, 179);
			this.EndLunchBreak_TextBox.Name = "EndLunchBreak_TextBox";
			this.EndLunchBreak_TextBox.Size = new System.Drawing.Size(150, 22);
			this.EndLunchBreak_TextBox.TabIndex = 27;
			// 
			// BeginWorkDay_TextBox
			// 
			this.BeginWorkDay_TextBox.Enabled = false;
			this.BeginWorkDay_TextBox.Location = new System.Drawing.Point(917, 135);
			this.BeginWorkDay_TextBox.Name = "BeginWorkDay_TextBox";
			this.BeginWorkDay_TextBox.Size = new System.Drawing.Size(150, 22);
			this.BeginWorkDay_TextBox.TabIndex = 25;
			// 
			// EndWorkDay_TextBox
			// 
			this.EndWorkDay_TextBox.Enabled = false;
			this.EndWorkDay_TextBox.Location = new System.Drawing.Point(1073, 135);
			this.EndWorkDay_TextBox.Name = "EndWorkDay_TextBox";
			this.EndWorkDay_TextBox.Size = new System.Drawing.Size(150, 22);
			this.EndWorkDay_TextBox.TabIndex = 23;
			// 
			// Office_TextBox
			// 
			this.Office_TextBox.Enabled = false;
			this.Office_TextBox.Location = new System.Drawing.Point(563, 213);
			this.Office_TextBox.Name = "Office_TextBox";
			this.Office_TextBox.Size = new System.Drawing.Size(300, 22);
			this.Office_TextBox.TabIndex = 21;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(576, 194);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(57, 16);
			this.label8.TabIndex = 20;
			this.label8.Text = "Кабінет";
			// 
			// Status_TextBox
			// 
			this.Status_TextBox.Enabled = false;
			this.Status_TextBox.Location = new System.Drawing.Point(563, 169);
			this.Status_TextBox.Name = "Status_TextBox";
			this.Status_TextBox.Size = new System.Drawing.Size(300, 22);
			this.Status_TextBox.TabIndex = 19;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(576, 150);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(53, 16);
			this.label9.TabIndex = 18;
			this.label9.Text = "Статус";
			// 
			// Qualification_TextBox
			// 
			this.Qualification_TextBox.Enabled = false;
			this.Qualification_TextBox.Location = new System.Drawing.Point(563, 125);
			this.Qualification_TextBox.Name = "Qualification_TextBox";
			this.Qualification_TextBox.Size = new System.Drawing.Size(300, 22);
			this.Qualification_TextBox.TabIndex = 17;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(576, 106);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(89, 16);
			this.label10.TabIndex = 16;
			this.label10.Text = "Кваліфікація";
			// 
			// Specialization_TextBox
			// 
			this.Specialization_TextBox.Enabled = false;
			this.Specialization_TextBox.Location = new System.Drawing.Point(563, 81);
			this.Specialization_TextBox.Name = "Specialization_TextBox";
			this.Specialization_TextBox.Size = new System.Drawing.Size(300, 22);
			this.Specialization_TextBox.TabIndex = 15;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(576, 62);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(96, 16);
			this.label11.TabIndex = 14;
			this.label11.Text = "Cпеціалізація";
			// 
			// Schedule_ID_TextBox
			// 
			this.Schedule_ID_TextBox.Location = new System.Drawing.Point(992, 91);
			this.Schedule_ID_TextBox.Name = "Schedule_ID_TextBox";
			this.Schedule_ID_TextBox.Size = new System.Drawing.Size(150, 22);
			this.Schedule_ID_TextBox.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(1005, 72);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(97, 16);
			this.label7.TabIndex = 12;
			this.label7.Text = "Код розкладу";
			// 
			// Office_ID_TextBox
			// 
			this.Office_ID_TextBox.Location = new System.Drawing.Point(407, 213);
			this.Office_ID_TextBox.Name = "Office_ID_TextBox";
			this.Office_ID_TextBox.Size = new System.Drawing.Size(150, 22);
			this.Office_ID_TextBox.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(420, 194);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 16);
			this.label6.TabIndex = 10;
			this.label6.Text = "Код кабінету";
			// 
			// Status_ID_TextBox
			// 
			this.Status_ID_TextBox.Location = new System.Drawing.Point(407, 169);
			this.Status_ID_TextBox.Name = "Status_ID_TextBox";
			this.Status_ID_TextBox.Size = new System.Drawing.Size(150, 22);
			this.Status_ID_TextBox.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(420, 150);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 16);
			this.label5.TabIndex = 8;
			this.label5.Text = "Код статусу";
			// 
			// Qualification_ID_TextBox
			// 
			this.Qualification_ID_TextBox.Location = new System.Drawing.Point(407, 125);
			this.Qualification_ID_TextBox.Name = "Qualification_ID_TextBox";
			this.Qualification_ID_TextBox.Size = new System.Drawing.Size(150, 22);
			this.Qualification_ID_TextBox.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(420, 106);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Код кваліфікації";
			// 
			// Specialization_ID_TextBox
			// 
			this.Specialization_ID_TextBox.Location = new System.Drawing.Point(407, 81);
			this.Specialization_ID_TextBox.Name = "Specialization_ID_TextBox";
			this.Specialization_ID_TextBox.Size = new System.Drawing.Size(150, 22);
			this.Specialization_ID_TextBox.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(420, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Код спеціалізації";
			// 
			// Phone_TextBox
			// 
			this.Phone_TextBox.Location = new System.Drawing.Point(22, 191);
			this.Phone_TextBox.Name = "Phone_TextBox";
			this.Phone_TextBox.Size = new System.Drawing.Size(300, 22);
			this.Phone_TextBox.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(35, 172);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Телефон";
			// 
			// Full_Name_TextBox
			// 
			this.Full_Name_TextBox.Location = new System.Drawing.Point(22, 147);
			this.Full_Name_TextBox.Name = "Full_Name_TextBox";
			this.Full_Name_TextBox.Size = new System.Drawing.Size(300, 22);
			this.Full_Name_TextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 128);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "ПІБ";
			// 
			// Reload_Button
			// 
			this.Reload_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Reload_Button.Location = new System.Drawing.Point(12, 341);
			this.Reload_Button.Name = "Reload_Button";
			this.Reload_Button.Size = new System.Drawing.Size(110, 35);
			this.Reload_Button.TabIndex = 2;
			this.Reload_Button.Text = "Оновити";
			this.Reload_Button.UseVisualStyleBackColor = true;
			this.Reload_Button.Click += new System.EventHandler(this.Reload_Button_Click);
			// 
			// Clear_Button
			// 
			this.Clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Clear_Button.Location = new System.Drawing.Point(632, 341);
			this.Clear_Button.Name = "Clear_Button";
			this.Clear_Button.Size = new System.Drawing.Size(110, 35);
			this.Clear_Button.TabIndex = 3;
			this.Clear_Button.Text = "Очистити";
			this.Clear_Button.UseVisualStyleBackColor = true;
			this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
			// 
			// Add_Button
			// 
			this.Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Add_Button.Location = new System.Drawing.Point(928, 341);
			this.Add_Button.Name = "Add_Button";
			this.Add_Button.Size = new System.Drawing.Size(110, 35);
			this.Add_Button.TabIndex = 4;
			this.Add_Button.Text = "Додати";
			this.Add_Button.UseVisualStyleBackColor = true;
			this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
			// 
			// Delete_Button
			// 
			this.Delete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Delete_Button.Location = new System.Drawing.Point(1160, 341);
			this.Delete_Button.Name = "Delete_Button";
			this.Delete_Button.Size = new System.Drawing.Size(110, 35);
			this.Delete_Button.TabIndex = 5;
			this.Delete_Button.Text = "Видалити";
			this.Delete_Button.UseVisualStyleBackColor = true;
			this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
			// 
			// Update_Button
			// 
			this.Update_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Update_Button.Location = new System.Drawing.Point(1044, 341);
			this.Update_Button.Name = "Update_Button";
			this.Update_Button.Size = new System.Drawing.Size(110, 35);
			this.Update_Button.TabIndex = 6;
			this.Update_Button.Text = "Змінити";
			this.Update_Button.UseVisualStyleBackColor = true;
			this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
			// 
			// Report_Button
			// 
			this.Report_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Report_Button.Location = new System.Drawing.Point(311, 341);
			this.Report_Button.Name = "Report_Button";
			this.Report_Button.Size = new System.Drawing.Size(110, 35);
			this.Report_Button.TabIndex = 7;
			this.Report_Button.Text = "Звіт";
			this.Report_Button.UseVisualStyleBackColor = true;
			this.Report_Button.Click += new System.EventHandler(this.Report_Button_Click);
			// 
			// Doctors
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
			this.Name = "Doctors";
			this.Text = "Лікарі";
			this.Load += new System.EventHandler(this.Doctors_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button Reload_Button;
		private System.Windows.Forms.TextBox Schedule_ID_TextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox Office_ID_TextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox Status_ID_TextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox Qualification_ID_TextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox Specialization_ID_TextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Phone_TextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Full_Name_TextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Office_TextBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox Status_TextBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox Qualification_TextBox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox Specialization_TextBox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox BeginLunchBreak_TextBox;
		private System.Windows.Forms.TextBox EndLunchBreak_TextBox;
		private System.Windows.Forms.TextBox BeginWorkDay_TextBox;
		private System.Windows.Forms.TextBox EndWorkDay_TextBox;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox Doctor_ID_TextBox;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button Clear_Button;
		private System.Windows.Forms.Button Add_Button;
		private System.Windows.Forms.Button Delete_Button;
		private System.Windows.Forms.Button Update_Button;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button Report_Button;
	}
}