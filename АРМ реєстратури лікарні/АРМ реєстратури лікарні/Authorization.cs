using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace АРМ_реєстратури_лікарні
{
	public partial class Authorization : Form
	{
		SqlConnection sqlConnection = new SqlConnection();

		string connectionString = "Server=DESKTOP-RS3EUDK\\MSSQLSERVER01; Database=registryDB; Integrated Security=true; TrustServerCertificate=True; Trusted_Connection=True; Encrypt=True";

		public Authorization()
		{
			InitializeComponent();
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			if (sqlConnection.State != ConnectionState.Open)
			{
				sqlConnection.ConnectionString = connectionString;

				try
				{
					await sqlConnection.OpenAsync();    //відкриття підключення
				}
				catch (SqlException ex)
				{
					MessageBox.Show(ex.Message);
				}
				finally
				{
					//MessageBox.Show("Підключення відчинено");

					//ПОЛУЧЕНИЕ ИНФОРМАЦИИ О ПОДКЛЮЧЕННОЙ БД
					/*MessageBox.Show("Строка подключения: " + sqlConnection.ConnectionString + "\n" +
									"База данных: " + sqlConnection.Database + "\n" +
									"Сервер: " + sqlConnection.DataSource + "\n" +
									"Версия сервера: " + sqlConnection.ServerVersion + "\n" +
									"Состояние: " + sqlConnection.State + "\n");
									*/
				}
			}

			using (SqlCommand command = new SqlCommand("SELECT Name, Password FROM Users WHERE Name = '" + Login_TextBox.Text + "'", sqlConnection))
			{
				using (SqlDataReader reader = await command.ExecuteReaderAsync())
				{
					if (reader.HasRows)
					{
						bool isOpen = false;
						while (await reader.ReadAsync())
						{
							if (Login_TextBox.Text == (string)reader["Name"] && Password_MaskedTextBox.Text == (string)reader["Password"])
							{
								isOpen = true;
								MessageBox.Show("Вхід виконано успішно");
								break;
							}
						}

						reader.Close();
						if (isOpen)
						{
							Password_MaskedTextBox.Clear();
							new MainButtonForm() { parentForm = this, sqlConnection = this.sqlConnection, username = Login_TextBox.Text }.Show();
							this.Hide();
						}
						else
							MessageBox.Show("Невдала спроба входу");
					}
					else
						MessageBox.Show("Невдала спроба входу");
				}
			}
		}

		private void Authorization_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (sqlConnection.State == ConnectionState.Open)    //закриття підключення до БД, якщо воно відкрито
			{
				sqlConnection.Close();
				sqlConnection.Dispose();
				//MessageBox.Show("Підключення зачинено");
			}
		}

		private void Login_TextBox_TextChanged(object sender, EventArgs e)
		{
			button1.Enabled = Login_TextBox.TextLength > 0 ? (Password_MaskedTextBox.TextLength > 0 ? true : false) : false;
		}

		private void Password_MaskedTextBox_TextChanged(object sender, EventArgs e)
		{
			button1.Enabled = Password_MaskedTextBox.TextLength > 0 ? (Login_TextBox.TextLength > 0 ? true : false) : false;
		}

		private void Login_TextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((Keys)e.KeyChar == Keys.Enter)
				Password_MaskedTextBox.Focus();
		}

		private void Password_MaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((Keys)e.KeyChar == Keys.Enter)
				button1.Focus();
		}
	}
}
