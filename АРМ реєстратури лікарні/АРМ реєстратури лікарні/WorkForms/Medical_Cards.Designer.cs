namespace АРМ_реєстратури_лікарні
{
	partial class Medical_Cards
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
			this.Add_Button = new System.Windows.Forms.Button();
			this.Reload_Button = new System.Windows.Forms.Button();
			this.Card_ID_TextBox = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.Report_Button = new System.Windows.Forms.Button();
			this.Delete_Button = new System.Windows.Forms.Button();
			this.Clear_Button = new System.Windows.Forms.Button();
			this.Dispensary_Group_TextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Update_Button = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.CurrentDate_Button = new System.Windows.Forms.Button();
			this.Contingent_TextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.Date_TextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.License_Number_TextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.Contingent_ID_TextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.Dispensary_Group_ID_TextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.EDRPOU_ID_TextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// Add_Button
			// 
			this.Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Add_Button.Location = new System.Drawing.Point(928, 341);
			this.Add_Button.Name = "Add_Button";
			this.Add_Button.Size = new System.Drawing.Size(110, 35);
			this.Add_Button.TabIndex = 12;
			this.Add_Button.Text = "Додати";
			this.Add_Button.UseVisualStyleBackColor = true;
			this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
			// 
			// Reload_Button
			// 
			this.Reload_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Reload_Button.Location = new System.Drawing.Point(12, 341);
			this.Reload_Button.Name = "Reload_Button";
			this.Reload_Button.Size = new System.Drawing.Size(110, 35);
			this.Reload_Button.TabIndex = 10;
			this.Reload_Button.Text = "Оновити";
			this.Reload_Button.UseVisualStyleBackColor = true;
			this.Reload_Button.Click += new System.EventHandler(this.Reload_Button_Click);
			// 
			// Card_ID_TextBox
			// 
			this.Card_ID_TextBox.Location = new System.Drawing.Point(145, 47);
			this.Card_ID_TextBox.Name = "Card_ID_TextBox";
			this.Card_ID_TextBox.Size = new System.Drawing.Size(150, 22);
			this.Card_ID_TextBox.TabIndex = 33;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(158, 28);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(72, 16);
			this.label14.TabIndex = 32;
			this.label14.Text = "Код карти";
			// 
			// Report_Button
			// 
			this.Report_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Report_Button.Location = new System.Drawing.Point(311, 341);
			this.Report_Button.Name = "Report_Button";
			this.Report_Button.Size = new System.Drawing.Size(110, 35);
			this.Report_Button.TabIndex = 15;
			this.Report_Button.Text = "Звіт";
			this.Report_Button.UseVisualStyleBackColor = true;
			this.Report_Button.Click += new System.EventHandler(this.Report_Button_Click);
			// 
			// Delete_Button
			// 
			this.Delete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Delete_Button.Location = new System.Drawing.Point(1160, 341);
			this.Delete_Button.Name = "Delete_Button";
			this.Delete_Button.Size = new System.Drawing.Size(110, 35);
			this.Delete_Button.TabIndex = 13;
			this.Delete_Button.Text = "Видалити";
			this.Delete_Button.UseVisualStyleBackColor = true;
			this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
			// 
			// Clear_Button
			// 
			this.Clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Clear_Button.Location = new System.Drawing.Point(632, 341);
			this.Clear_Button.Name = "Clear_Button";
			this.Clear_Button.Size = new System.Drawing.Size(110, 35);
			this.Clear_Button.TabIndex = 11;
			this.Clear_Button.Text = "Очистити";
			this.Clear_Button.UseVisualStyleBackColor = true;
			this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
			// 
			// Dispensary_Group_TextBox
			// 
			this.Dispensary_Group_TextBox.Enabled = false;
			this.Dispensary_Group_TextBox.Location = new System.Drawing.Point(301, 135);
			this.Dispensary_Group_TextBox.Name = "Dispensary_Group_TextBox";
			this.Dispensary_Group_TextBox.Size = new System.Drawing.Size(300, 22);
			this.Dispensary_Group_TextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(314, 116);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(135, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Диспансерна група";
			// 
			// Update_Button
			// 
			this.Update_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Update_Button.Location = new System.Drawing.Point(1044, 341);
			this.Update_Button.Name = "Update_Button";
			this.Update_Button.Size = new System.Drawing.Size(110, 35);
			this.Update_Button.TabIndex = 14;
			this.Update_Button.Text = "Змінити";
			this.Update_Button.UseVisualStyleBackColor = true;
			this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.CurrentDate_Button);
			this.groupBox1.Controls.Add(this.Contingent_TextBox);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.Date_TextBox);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.License_Number_TextBox);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.Contingent_ID_TextBox);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.Dispensary_Group_ID_TextBox);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.EDRPOU_ID_TextBox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.Card_ID_TextBox);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.Dispensary_Group_TextBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1258, 323);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = " Дані";
			// 
			// CurrentDate_Button
			// 
			this.CurrentDate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CurrentDate_Button.Location = new System.Drawing.Point(299, 264);
			this.CurrentDate_Button.Name = "CurrentDate_Button";
			this.CurrentDate_Button.Size = new System.Drawing.Size(108, 29);
			this.CurrentDate_Button.TabIndex = 16;
			this.CurrentDate_Button.Text = "Дата";
			this.CurrentDate_Button.UseVisualStyleBackColor = true;
			this.CurrentDate_Button.Click += new System.EventHandler(this.CurrentDate_Button_Click);
			// 
			// Contingent_TextBox
			// 
			this.Contingent_TextBox.Enabled = false;
			this.Contingent_TextBox.Location = new System.Drawing.Point(301, 179);
			this.Contingent_TextBox.Name = "Contingent_TextBox";
			this.Contingent_TextBox.Size = new System.Drawing.Size(300, 22);
			this.Contingent_TextBox.TabIndex = 45;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(314, 160);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(83, 16);
			this.label7.TabIndex = 44;
			this.label7.Text = "Контингент";
			// 
			// Date_TextBox
			// 
			this.Date_TextBox.Location = new System.Drawing.Point(145, 267);
			this.Date_TextBox.Name = "Date_TextBox";
			this.Date_TextBox.Size = new System.Drawing.Size(150, 22);
			this.Date_TextBox.TabIndex = 43;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(144, 248);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(151, 16);
			this.label6.TabIndex = 42;
			this.label6.Text = "Дата реєстрації карти";
			// 
			// License_Number_TextBox
			// 
			this.License_Number_TextBox.Location = new System.Drawing.Point(145, 223);
			this.License_Number_TextBox.Name = "License_Number_TextBox";
			this.License_Number_TextBox.Size = new System.Drawing.Size(150, 22);
			this.License_Number_TextBox.TabIndex = 41;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(142, 204);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(207, 16);
			this.label5.TabIndex = 40;
			this.label5.Text = "Номер пільгового посвідчення";
			// 
			// Contingent_ID_TextBox
			// 
			this.Contingent_ID_TextBox.Location = new System.Drawing.Point(145, 179);
			this.Contingent_ID_TextBox.Name = "Contingent_ID_TextBox";
			this.Contingent_ID_TextBox.Size = new System.Drawing.Size(150, 22);
			this.Contingent_ID_TextBox.TabIndex = 39;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(158, 160);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 16);
			this.label4.TabIndex = 38;
			this.label4.Text = "Код контингенту";
			// 
			// Dispensary_Group_ID_TextBox
			// 
			this.Dispensary_Group_ID_TextBox.Location = new System.Drawing.Point(145, 135);
			this.Dispensary_Group_ID_TextBox.Name = "Dispensary_Group_ID_TextBox";
			this.Dispensary_Group_ID_TextBox.Size = new System.Drawing.Size(150, 22);
			this.Dispensary_Group_ID_TextBox.TabIndex = 37;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(142, 116);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(164, 16);
			this.label3.TabIndex = 36;
			this.label3.Text = "Код диспансерної групи";
			// 
			// EDRPOU_ID_TextBox
			// 
			this.EDRPOU_ID_TextBox.Location = new System.Drawing.Point(145, 91);
			this.EDRPOU_ID_TextBox.Name = "EDRPOU_ID_TextBox";
			this.EDRPOU_ID_TextBox.Size = new System.Drawing.Size(150, 22);
			this.EDRPOU_ID_TextBox.TabIndex = 35;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(158, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 16);
			this.label2.TabIndex = 34;
			this.label2.Text = "Код ЄДРПОУ";
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
			this.dataGridView1.TabIndex = 8;
			this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
			// 
			// Medical_Cards
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1282, 653);
			this.Controls.Add(this.Add_Button);
			this.Controls.Add(this.Reload_Button);
			this.Controls.Add(this.Report_Button);
			this.Controls.Add(this.Delete_Button);
			this.Controls.Add(this.Clear_Button);
			this.Controls.Add(this.Update_Button);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Medical_Cards";
			this.Text = "Медичні картки";
			this.Load += new System.EventHandler(this.Medical_Cards_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Add_Button;
		private System.Windows.Forms.Button Reload_Button;
		private System.Windows.Forms.TextBox Card_ID_TextBox;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button Report_Button;
		private System.Windows.Forms.Button Delete_Button;
		private System.Windows.Forms.Button Clear_Button;
		private System.Windows.Forms.TextBox Dispensary_Group_TextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Update_Button;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox Contingent_ID_TextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox Dispensary_Group_ID_TextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox EDRPOU_ID_TextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Contingent_TextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox Date_TextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox License_Number_TextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button CurrentDate_Button;
	}
}