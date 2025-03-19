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
	public partial class Appointments : Form
	{
		public SqlConnection sqlConnection = null;  //приймає відкрите з'єднання з базою даних при відкритті форми

		public bool check;	//приймає значення, дивлячись на яке, користувачу дозволяється чи забороняється редагувати дані форми

		public Appointments()
		{
			InitializeComponent();
		}

		private void LoadTable()
		{
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Appointments", sqlConnection);
			DataSet dataSet = new DataSet();
			sqlDataAdapter.Fill(dataSet);
			dataGridView1.DataSource = dataSet.Tables[0];
		}

		private void ClearAllTextBoxes()
		{
			Appointment_ID_TextBox.Clear();
			Time_TextBox.Clear();
			Patient_ID_TextBox.Clear();
			Patient_TextBox.Clear();
			Service_ID_TextBox.Clear();
			Service_TextBox.Clear();
		}

		private void Appointments_Load(object sender, EventArgs e)
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
				Appointment_ID_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["ID_Appointment"].Value);
				Time_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Appointment_Registration_Time"].Value);
				Patient_ID_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["ID_Patient"].Value);
				using (SqlCommand comm = new SqlCommand("SELECT Name FROM Patients WHERE ID_Patient = '" + Patient_ID_TextBox.Text + "'", sqlConnection))
				{
					using (SqlDataReader reader = await comm.ExecuteReaderAsync())
					{
						await reader.ReadAsync();
						Patient_TextBox.Text = (string)reader[0];
					}
				}
				Service_ID_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["ID_Service"].Value);
				using (SqlCommand comm = new SqlCommand("SELECT Name FROM Medical_Services WHERE ID_Service = '" + Service_ID_TextBox.Text + "'", sqlConnection))
				{
					using (SqlDataReader reader = await comm.ExecuteReaderAsync())
					{
						await reader.ReadAsync();
						Service_TextBox.Text = (string)reader[0];
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
			SqlCommand command = new SqlCommand("Add_Appointment", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter timeParam = new SqlParameter()
			{
				ParameterName = "@appointment_registration_time",
				Value = Time_TextBox.Text
			};
			command.Parameters.Add(timeParam);

			SqlParameter patientParam = new SqlParameter()
			{
				ParameterName = "@id_patient",
				Value = Patient_ID_TextBox.Text
			};
			command.Parameters.Add(patientParam);

			SqlParameter serviceParam = new SqlParameter()
			{
				ParameterName = "@id_service",
				Value = Service_ID_TextBox.Text
			};
			command.Parameters.Add(serviceParam);

			await command.ExecuteScalarAsync();

			LoadTable();
		}

		private async void Update_Button_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("Update_Appointment", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter idParam = new SqlParameter()
			{
				ParameterName = "@id_appointment",
				Value = Appointment_ID_TextBox.Text
			};
			command.Parameters.Add(idParam);

			SqlParameter timeParam = new SqlParameter()
			{
				ParameterName = "@appointment_registration_time",
				Value = Time_TextBox.Text
			};
			command.Parameters.Add(timeParam);

			SqlParameter patientParam = new SqlParameter()
			{
				ParameterName = "@id_patient",
				Value = Patient_ID_TextBox.Text
			};
			command.Parameters.Add(patientParam);

			SqlParameter serviceParam = new SqlParameter()
			{
				ParameterName = "@id_service",
				Value = Service_ID_TextBox.Text
			};
			command.Parameters.Add(serviceParam);

			await command.ExecuteScalarAsync();

			LoadTable();
		}

		private async void Delete_Button_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("Delete_Appointment", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter idParam = new SqlParameter()
			{
				ParameterName = "@id_appointment",
				Value = Appointment_ID_TextBox.Text
			};
			command.Parameters.Add(idParam);

			await command.ExecuteScalarAsync();

			ClearAllTextBoxes();
			LoadTable();
		}

		private void Report_Button_Click(object sender, EventArgs e)
		{
			new Appointments_Report() { sqlConnection = sqlConnection }.Show();
		}

		private void CurrentDate_Button_Click(object sender, EventArgs e)
		{
			Time_TextBox.Text = DateTime.Now.ToString();
		}
	}
}
