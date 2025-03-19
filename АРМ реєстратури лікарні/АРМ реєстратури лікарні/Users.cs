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
	public partial class Users : Form
	{
		public SqlConnection sqlConnection = null;  //приймає відкрите з'єднання з базою даних при відкритті форми

		string oldName;

		public bool check;  //приймає значення, дивлячись на яке, користувачу дозволяється чи забороняється редагувати дані форми

		public Users()
		{
			InitializeComponent();
		}

		private void LoadTable()
		{
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Users", sqlConnection);
			DataSet dataSet = new DataSet();
			sqlDataAdapter.Fill(dataSet);
			dataGridView1.DataSource = dataSet.Tables[0];
		}

		private void ClearAllTextBoxes()
		{
			Name_TextBox.Clear();
			Password_TextBox.Clear();
			Offices_TextBox.Clear();
			Specializations_TextBox.Clear();
			Qualifications_TextBox.Clear();
			Statuses_TextBox.Clear();
			Medical_Services_TextBox.Clear();
			Doctors_TextBox.Clear();
			Doctors_Schedules_TextBox.Clear();
			Appointments_TextBox.Clear();
			Patients_TextBox.Clear();
			Genders_TextBox.Clear();
			Medical_Cards_TextBox.Clear();
			Dispensary_Groups_TextBox.Clear();
			Contingents_TextBox.Clear();
			Users_TextBox.Clear();
		}

		private void Users_Load(object sender, EventArgs e)
		{
			LoadTable();

			Add_Button.Enabled = check ? true : false;
			Update_Button.Enabled = check ? true : false;
			Delete_Button.Enabled = check ? true : false;
		}

		private void dataGridView1_Click(object sender, EventArgs e)
		{
			DataGridView dgv = (DataGridView)sender;
			if (dgv.SelectedRows != null)
			{
				Name_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Name"].Value);
				oldName = Name_TextBox.Text;
				Password_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Password"].Value);
				Offices_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Offices"].Value);
				Specializations_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Specializations"].Value);
				Qualifications_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Qualifications"].Value);
				Statuses_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Statuses"].Value);
				Medical_Services_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Medical_Services"].Value);
				Doctors_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Doctors"].Value);
				Doctors_Schedules_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Doctors_Schedules"].Value);
				Appointments_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Appointments"].Value);
				Patients_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Patients"].Value);
				Genders_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Genders"].Value);
				Medical_Cards_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Medical_Services"].Value);
				Dispensary_Groups_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Dispensary_Groups"].Value);
				Contingents_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Contingents"].Value);
				Users_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Users"].Value);
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
			SqlCommand command = new SqlCommand("Add_User", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter nameParam = new SqlParameter()
			{
				ParameterName = "@name",
				Value = Name_TextBox.Text
			};
			command.Parameters.Add(nameParam);

			SqlParameter passwordParam = new SqlParameter()
			{
				ParameterName = "@password",
				Value = Password_TextBox.Text
			};
			command.Parameters.Add(passwordParam);

			SqlParameter officesParam = new SqlParameter()
			{
				ParameterName = "@offices",
				Value = Offices_TextBox.Text
			};
			command.Parameters.Add(officesParam);

			SqlParameter specializationsParam = new SqlParameter()
			{
				ParameterName = "@specializations",
				Value = Specializations_TextBox.Text
			};
			command.Parameters.Add(specializationsParam);

			SqlParameter qualificationsParam = new SqlParameter()
			{
				ParameterName = "@qualifications",
				Value = Qualifications_TextBox.Text
			};
			command.Parameters.Add(qualificationsParam);

			SqlParameter statusesParam = new SqlParameter()
			{
				ParameterName = "@statuses",
				Value = Statuses_TextBox.Text
			};
			command.Parameters.Add(statusesParam);

			SqlParameter medicalServicesParam = new SqlParameter()
			{
				ParameterName = "@medical_services",
				Value = Medical_Services_TextBox.Text
			};
			command.Parameters.Add(medicalServicesParam);

			SqlParameter doctorsParam = new SqlParameter()
			{
				ParameterName = "@doctors",
				Value = Doctors_TextBox.Text
			};
			command.Parameters.Add(doctorsParam);

			SqlParameter doctorsSchedulesParam = new SqlParameter()
			{
				ParameterName = "@doctors_schedules",
				Value = Doctors_Schedules_TextBox.Text
			};
			command.Parameters.Add(doctorsSchedulesParam);

			SqlParameter appointmentsParam = new SqlParameter()
			{
				ParameterName = "@appointments",
				Value = Appointments_TextBox.Text
			};
			command.Parameters.Add(appointmentsParam);

			SqlParameter patientsParam = new SqlParameter()
			{
				ParameterName = "@patients",
				Value = Patients_TextBox.Text
			};
			command.Parameters.Add(patientsParam);

			SqlParameter gendersParam = new SqlParameter()
			{
				ParameterName = "@genders",
				Value = Genders_TextBox.Text
			};
			command.Parameters.Add(gendersParam);

			SqlParameter medicalCardsParam = new SqlParameter()
			{
				ParameterName = "@medical_cards",
				Value = Medical_Cards_TextBox.Text
			};
			command.Parameters.Add(medicalCardsParam);

			SqlParameter dispensaryGroupsParam = new SqlParameter()
			{
				ParameterName = "@dispensary_groups",
				Value = Dispensary_Groups_TextBox.Text
			};
			command.Parameters.Add(dispensaryGroupsParam);

			SqlParameter contingentsParam = new SqlParameter()
			{
				ParameterName = "@contingents",
				Value = Contingents_TextBox.Text
			};
			command.Parameters.Add(contingentsParam);

			SqlParameter usersParam = new SqlParameter()
			{
				ParameterName = "@users",
				Value = Users_TextBox.Text
			};
			command.Parameters.Add(usersParam);

			await command.ExecuteScalarAsync();

			LoadTable();
		}

		private async void Update_Button_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("Update_User", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter oldNameParam = new SqlParameter()
			{
				ParameterName = "@old_name",
				Value = oldName
			};
			command.Parameters.Add(oldNameParam);

			SqlParameter newNameParam = new SqlParameter()
			{
				ParameterName = "new_name",
				Value = Name_TextBox.Text
			};
			command.Parameters.Add(newNameParam);

			SqlParameter passwordParam = new SqlParameter()
			{
				ParameterName = "@password",
				Value = Password_TextBox.Text
			};
			command.Parameters.Add(passwordParam);

			SqlParameter officesParam = new SqlParameter()
			{
				ParameterName = "@offices",
				Value = Offices_TextBox.Text
			};
			command.Parameters.Add(officesParam);

			SqlParameter specializationsParam = new SqlParameter()
			{
				ParameterName = "@specializations",
				Value = Specializations_TextBox.Text
			};
			command.Parameters.Add(specializationsParam);

			SqlParameter qualificationsParam = new SqlParameter()
			{
				ParameterName = "@qualifications",
				Value = Qualifications_TextBox.Text
			};
			command.Parameters.Add(qualificationsParam);

			SqlParameter statusesParam = new SqlParameter()
			{
				ParameterName = "@statuses",
				Value = Statuses_TextBox.Text
			};
			command.Parameters.Add(statusesParam);

			SqlParameter medicalServicesParam = new SqlParameter()
			{
				ParameterName = "@medical_services",
				Value = Medical_Services_TextBox.Text
			};
			command.Parameters.Add(medicalServicesParam);

			SqlParameter doctorsParam = new SqlParameter()
			{
				ParameterName = "@doctors",
				Value = Doctors_TextBox.Text
			};
			command.Parameters.Add(doctorsParam);

			SqlParameter doctorsSchedulesParam = new SqlParameter()
			{
				ParameterName = "@doctors_schedules",
				Value = Doctors_Schedules_TextBox.Text
			};
			command.Parameters.Add(doctorsSchedulesParam);

			SqlParameter appointmentsParam = new SqlParameter()
			{
				ParameterName = "@appointments",
				Value = Appointments_TextBox.Text
			};
			command.Parameters.Add(appointmentsParam);

			SqlParameter patientsParam = new SqlParameter()
			{
				ParameterName = "@patients",
				Value = Patients_TextBox.Text
			};
			command.Parameters.Add(patientsParam);

			SqlParameter gendersParam = new SqlParameter()
			{
				ParameterName = "@genders",
				Value = Genders_TextBox.Text
			};
			command.Parameters.Add(gendersParam);

			SqlParameter medicalCardsParam = new SqlParameter()
			{
				ParameterName = "@medical_cards",
				Value = Medical_Cards_TextBox.Text
			};
			command.Parameters.Add(medicalCardsParam);

			SqlParameter dispensaryGroupsParam = new SqlParameter()
			{
				ParameterName = "@dispensary_groups",
				Value = Dispensary_Groups_TextBox.Text
			};
			command.Parameters.Add(dispensaryGroupsParam);

			SqlParameter contingentsParam = new SqlParameter()
			{
				ParameterName = "@contingents",
				Value = Contingents_TextBox.Text
			};
			command.Parameters.Add(contingentsParam);

			SqlParameter usersParam = new SqlParameter()
			{
				ParameterName = "@users",
				Value = Users_TextBox.Text
			};
			command.Parameters.Add(usersParam);

			await command.ExecuteScalarAsync();

			LoadTable();
		}

		private async void Delete_Button_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("Delete_User", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter nameParam = new SqlParameter()
			{
				ParameterName = "@name",
				Value = Name_TextBox.Text
			};
			command.Parameters.Add(nameParam);

			await command.ExecuteScalarAsync();

			ClearAllTextBoxes();
			LoadTable();
		}
	}
}
