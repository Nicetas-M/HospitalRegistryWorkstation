using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АРМ_реєстратури_лікарні
{
	public partial class MainButtonForm : Form
	{
		public Form parentForm; //посилається на батьківську форму
		public SqlConnection sqlConnection = null;  //приймає відкрите з'єднання з базою даних при відкритті форми
		public string username; //ім'я авторизованого користувача

		public MainButtonForm()
		{
			InitializeComponent();
		}

		private async void MainButtonForm_Load(object sender, EventArgs e)
		{
			using (SqlCommand command = new SqlCommand("SELECT Users FROM Users WHERE Name = '" + username + "'", sqlConnection))
			{
				using (SqlDataReader reader = await command.ExecuteReaderAsync())
				{
					await reader.ReadAsync();
					Users_Button.Enabled = Users_Button.Visible = ((string)reader[0] == "Так" ? true : false);
				}
			}
		}

		private void MainButtonForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			parentForm.Show();
		}

		private async void GeneralEventHandler_Buttons_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			bool check;

			using (SqlCommand command = new SqlCommand("SELECT " + button.Tag.ToString() + " FROM Users WHERE Name = '" + username + "'", sqlConnection))
			{
				using (SqlDataReader reader = await command.ExecuteReaderAsync())
				{
					await reader.ReadAsync();
					check = (string)reader[0] == "Так" ? true : false;
				}
			}

			switch ((string)button.Tag)
			{
				case "Doctors":
					new Doctors() { sqlConnection = sqlConnection, check = check }.Show();
					break;

				case "Doctors_Schedules":
					new Doctors_Schedules() { sqlConnection = sqlConnection, check = check }.Show();
					break;

				case "Appointments":
					new Appointments() { sqlConnection = sqlConnection, check = check }.Show();
					break;

				case "Statuses":
					new Statuses() { sqlConnection = sqlConnection, check = check }.Show();
					break;

				case "Qualifications":
					new Qualifications() { sqlConnection = sqlConnection, check = check }.Show();
					break;

				case "Specializations":
					new Specializations() { sqlConnection = sqlConnection, check = check }.Show();
					break;

				case "Offices":
					new Offices() { sqlConnection = sqlConnection, check = check }.Show();
					break;

				case "Contingents":
					new Contingents() { sqlConnection = sqlConnection, check = check }.Show();
					break;

				case "Dispensary_Groups":
					new Dispensary_Groups() { sqlConnection = sqlConnection, check = check }.Show();
					break;

				case "Genders":
					new Genders() { sqlConnection = sqlConnection, check = check }.Show();
					break;

				case "Medical_Services":
					new Medical_Services() { sqlConnection = sqlConnection, check = check }.Show();
					break;

				case "Users":
					new Users() { sqlConnection = sqlConnection, check = check }.Show();
					break;

				case "Medical_Cards":
					new Medical_Cards() { sqlConnection = sqlConnection, check = check }.Show();
					break;

				case "Patients":
					new Patients() { sqlConnection = sqlConnection, check = check }.Show();
					break;
			}	
		}
	}
}
