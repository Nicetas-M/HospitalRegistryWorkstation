namespace АРМ_реєстратури_лікарні
{
	partial class Offices
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
			this.Report_Button = new System.Windows.Forms.Button();
			this.Update_Button = new System.Windows.Forms.Button();
			this.Delete_Button = new System.Windows.Forms.Button();
			this.Add_Button = new System.Windows.Forms.Button();
			this.Clear_Button = new System.Windows.Forms.Button();
			this.Reload_Button = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Office_TextBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.Office_ID_TextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
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
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.Office_TextBox);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.Office_ID_TextBox);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1258, 323);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = " Дані";
			// 
			// Office_TextBox
			// 
			this.Office_TextBox.Location = new System.Drawing.Point(552, 154);
			this.Office_TextBox.Name = "Office_TextBox";
			this.Office_TextBox.Size = new System.Drawing.Size(300, 22);
			this.Office_TextBox.TabIndex = 21;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(565, 135);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(57, 16);
			this.label8.TabIndex = 20;
			this.label8.Text = "Кабінет";
			// 
			// Office_ID_TextBox
			// 
			this.Office_ID_TextBox.Location = new System.Drawing.Point(396, 154);
			this.Office_ID_TextBox.Name = "Office_ID_TextBox";
			this.Office_ID_TextBox.Size = new System.Drawing.Size(150, 22);
			this.Office_ID_TextBox.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(409, 135);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 16);
			this.label6.TabIndex = 10;
			this.label6.Text = "Код кабінету";
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
			// Offices
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
			this.Name = "Offices";
			this.Text = "Кабінети";
			this.Load += new System.EventHandler(this.Offices_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Report_Button;
		private System.Windows.Forms.Button Update_Button;
		private System.Windows.Forms.Button Delete_Button;
		private System.Windows.Forms.Button Add_Button;
		private System.Windows.Forms.Button Clear_Button;
		private System.Windows.Forms.Button Reload_Button;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox Office_TextBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox Office_ID_TextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}