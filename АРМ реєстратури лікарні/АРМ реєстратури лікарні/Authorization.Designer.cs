namespace АРМ_реєстратури_лікарні
{
	partial class Authorization
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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Login_TextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Password_MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(92, 231);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(191, 44);
			this.button1.TabIndex = 0;
			this.button1.Text = "Авторизуватися";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(90, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Логін:";
			// 
			// Login_TextBox
			// 
			this.Login_TextBox.Location = new System.Drawing.Point(92, 62);
			this.Login_TextBox.Name = "Login_TextBox";
			this.Login_TextBox.Size = new System.Drawing.Size(190, 22);
			this.Login_TextBox.TabIndex = 3;
			this.Login_TextBox.TextChanged += new System.EventHandler(this.Login_TextBox_TextChanged);
			this.Login_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_TextBox_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(90, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Пароль:";
			// 
			// Password_MaskedTextBox
			// 
			this.Password_MaskedTextBox.Location = new System.Drawing.Point(92, 151);
			this.Password_MaskedTextBox.Name = "Password_MaskedTextBox";
			this.Password_MaskedTextBox.PasswordChar = '*';
			this.Password_MaskedTextBox.Size = new System.Drawing.Size(190, 22);
			this.Password_MaskedTextBox.TabIndex = 7;
			this.Password_MaskedTextBox.TextChanged += new System.EventHandler(this.Password_MaskedTextBox_TextChanged);
			this.Password_MaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_MaskedTextBox_KeyPress);
			// 
			// Authorization
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(376, 323);
			this.Controls.Add(this.Password_MaskedTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Login_TextBox);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Authorization";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Авторизація";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Authorization_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Login_TextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MaskedTextBox Password_MaskedTextBox;
	}
}