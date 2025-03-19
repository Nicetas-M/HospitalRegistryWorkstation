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
using Microsoft.Reporting.WebForms;

namespace АРМ_реєстратури_лікарні
{
	public partial class Doctors : Form
	{
		public SqlConnection sqlConnection = null;  //приймає відкрите з'єднання з базою даних при відкритті форми

		public bool check; //приймає значення, дивлячись на яке, користувачу дозволяється чи забороняється редагувати дані форми

		public Doctors()
		{
			InitializeComponent();
		}

		private void LoadTable()
		{
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Doctors", sqlConnection);
			DataSet dataSet = new DataSet();
			sqlDataAdapter.Fill(dataSet);
			dataGridView1.DataSource = dataSet.Tables[0];
		}

		private void ClearAllTextBoxes()
		{
			Doctor_ID_TextBox.Clear();
			Full_Name_TextBox.Clear();
			Phone_TextBox.Clear();
			Specialization_ID_TextBox.Clear();
			Specialization_TextBox.Clear();
			Qualification_ID_TextBox.Clear();
			Qualification_TextBox.Clear();
			Status_ID_TextBox.Clear();
			Status_TextBox.Clear();
			Office_ID_TextBox.Clear();
			Office_TextBox.Clear();
			Schedule_ID_TextBox.Clear();
			BeginWorkDay_TextBox.Clear();
			EndWorkDay_TextBox.Clear();
			BeginLunchBreak_TextBox.Clear();
			EndLunchBreak_TextBox.Clear();
		}

		private void Doctors_Load(object sender, EventArgs e)
		{
			LoadTable();

			Add_Button.Enabled = check ? true : false;
			Update_Button.Enabled = check ? true : false;
			Delete_Button.Enabled = check ? true : false;
		}

		private async void dataGridView1_Click(object sender, EventArgs e)
		{
			DataGridView dgv = (DataGridView)sender;
			if (dgv.SelectedRows != null)
			{
				Doctor_ID_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["ID_Doctor"].Value);
				Full_Name_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Name"].Value);
				Phone_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Phone"].Value);
				Specialization_ID_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["ID_Specialization"].Value);
				using (SqlCommand comm = new SqlCommand("SELECT Specialization FROM Specializations WHERE ID_Specialization = '" + Specialization_ID_TextBox.Text + "'", sqlConnection))
				{
					using (SqlDataReader reader = await comm.ExecuteReaderAsync())
					{
						await reader.ReadAsync();
						Specialization_TextBox.Text = (string)reader[0];
					}
				}
				Qualification_ID_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["ID_Qualification"].Value);
				using (SqlCommand comm = new SqlCommand("SELECT Qualification FROM Qualifications WHERE ID_Qualification = '" + Qualification_ID_TextBox.Text + "'", sqlConnection))
				{
					using (SqlDataReader reader = await comm.ExecuteReaderAsync())
					{
						await reader.ReadAsync();
						Qualification_TextBox.Text = (string)reader[0];
					}
				}
				Status_ID_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["ID_Status"].Value);
				using (SqlCommand comm = new SqlCommand("SELECT Status FROM Statuses WHERE ID_Status = '" + Status_ID_TextBox.Text + "'", sqlConnection))
				{
					using (SqlDataReader reader = await comm.ExecuteReaderAsync())
					{
						await reader.ReadAsync();
						Status_TextBox.Text = (string)reader[0];
					}
				}
				Office_ID_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["ID_Office"].Value);
				using (SqlCommand comm = new SqlCommand("SELECT Office FROM Offices WHERE ID_Office = '" + Office_ID_TextBox.Text + "'", sqlConnection))
				{
					using (SqlDataReader reader = await comm.ExecuteReaderAsync())
					{
						await reader.ReadAsync();
						Office_TextBox.Text = (string)reader[0];
					}
				}
				Schedule_ID_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["ID_Schedule"].Value);
				using (SqlCommand comm = new SqlCommand("SELECT Begin_of_the_Work_Day, End_of_the_Work_Day, Begin_of_the_Lunch_Break, End_of_the_Lunch_Break FROM Doctors_Schedules WHERE ID_Schedule = '" + Schedule_ID_TextBox.Text + "'", sqlConnection))
				{
					using (SqlDataReader reader = await comm.ExecuteReaderAsync())
					{
						await reader.ReadAsync();
						BeginWorkDay_TextBox.Text = Convert.ToString(reader[0]).Remove(5, 3);
						EndWorkDay_TextBox.Text = Convert.ToString(reader[1]).Remove(5, 3);
						BeginLunchBreak_TextBox.Text = Convert.ToString(reader[2]).Remove(5, 3);
						EndLunchBreak_TextBox.Text = Convert.ToString(reader[3]).Remove(5, 3);
					}
				}
			}
		}

		private void Reload_Button_Click(object sender, EventArgs e)
		{
			LoadTable();
			ClearAllTextBoxes();
		}

		private void Clear_Button_Click(object sender, EventArgs e)
		{
			ClearAllTextBoxes();
		}

		private async void Add_Button_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("Add_Doctor", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter nameParam = new SqlParameter
			{
				ParameterName = "@name",
				Value = Full_Name_TextBox.Text
			};
			command.Parameters.Add(nameParam);

			SqlParameter phoneParam = new SqlParameter
			{
				ParameterName = "@phone",
				Value = Phone_TextBox.Text
			};
			command.Parameters.Add(phoneParam);

			SqlParameter specializationParam = new SqlParameter
			{
				ParameterName = "@id_specialization",
				Value = Specialization_ID_TextBox.Text
			};
			command.Parameters.Add(specializationParam);

			SqlParameter qualificationParam = new SqlParameter
			{
				ParameterName = "@id_qualification",
				Value = Qualification_ID_TextBox.Text
			};
			command.Parameters.Add(qualificationParam);

			SqlParameter statusParam = new SqlParameter
			{
				ParameterName = "@id_status",
				Value = Status_ID_TextBox.Text
			};
			command.Parameters.Add(statusParam);

			SqlParameter officeParam = new SqlParameter
			{
				ParameterName = "@id_office",
				Value = Office_ID_TextBox.Text
			};
			command.Parameters.Add(officeParam);

			SqlParameter scheduleParam = new SqlParameter
			{
				ParameterName = "@id_schedule",
				Value = Schedule_ID_TextBox.Text
			};
			command.Parameters.Add(scheduleParam);

			await command.ExecuteScalarAsync();

			LoadTable();
		}

		private async void Update_Button_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("Update_Doctor", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter idParam = new SqlParameter
			{
				ParameterName = "@id_doctor",
				Value = Convert.ToInt32(Doctor_ID_TextBox.Text)
			};
			command.Parameters.Add(idParam);

			SqlParameter nameParam = new SqlParameter
			{
				ParameterName = "@name",
				Value = Full_Name_TextBox.Text
			};
			command.Parameters.Add(nameParam);

			SqlParameter phoneParam = new SqlParameter
			{
				ParameterName = "@phone",
				Value = Phone_TextBox.Text
			};
			command.Parameters.Add(phoneParam);

			SqlParameter specializationParam = new SqlParameter
			{
				ParameterName = "@id_specialization",
				Value = Specialization_ID_TextBox.Text
			};
			command.Parameters.Add(specializationParam);

			SqlParameter qualificationParam = new SqlParameter
			{
				ParameterName = "@id_qualification",
				Value = Qualification_ID_TextBox.Text
			};
			command.Parameters.Add(qualificationParam);

			SqlParameter statusParam = new SqlParameter
			{
				ParameterName = "@id_status",
				Value = Status_ID_TextBox.Text
			};
			command.Parameters.Add(statusParam);

			SqlParameter officeParam = new SqlParameter
			{
				ParameterName = "@id_office",
				Value = Office_ID_TextBox.Text
			};
			command.Parameters.Add(officeParam);

			SqlParameter scheduleParam = new SqlParameter
			{
				ParameterName = "@id_schedule",
				Value = Schedule_ID_TextBox.Text
			};
			command.Parameters.Add(scheduleParam);

			await command.ExecuteScalarAsync();

			LoadTable();
		}

		private async void Delete_Button_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("Delete_Doctor", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter idParam = new SqlParameter
			{
				ParameterName = "@id_doctor",
				Value = Convert.ToInt32(Doctor_ID_TextBox.Text)
			};
			command.Parameters.Add(idParam);

			await command.ExecuteScalarAsync();

			ClearAllTextBoxes();
			LoadTable();
		}

		private void Report_Button_Click(object sender, EventArgs e)
		{
			new Doctors_Report() { sqlConnection = sqlConnection }.Show();
		}
	}
}
