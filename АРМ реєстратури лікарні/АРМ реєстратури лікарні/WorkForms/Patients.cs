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
	public partial class Patients : Form
	{
		public SqlConnection sqlConnection = null;  //приймає відкрите з'єднання з базою даних при відкритті форми

		public bool check; //приймає значення, дивлячись на яке, користувачу дозволяється чи забороняється редагувати дані форми

		public Patients()
		{
			InitializeComponent();
		}

		private void LoadTable()
		{
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Patients", sqlConnection);
			DataSet dataSet = new DataSet();
			sqlDataAdapter.Fill(dataSet);
			dataGridView1.DataSource = dataSet.Tables[0];
		}

		private void ClearAllTextBoxes()
		{
			Patient_ID_TextBox.Clear();
			Name_TextBox.Clear();
			Gender_ID_TextBox.Clear();
			Gender_TextBox.Clear();
			Birthday_TextBox.Clear();
			Phone_TextBox.Clear();
			Location_TextBox.Clear();
			Card_ID_TextBox.Clear();
		}

		private void Patients_Load(object sender, EventArgs e)
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
				Patient_ID_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["ID_Patient"].Value);
				Name_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Name"].Value);
				Gender_ID_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["ID_Gender"].Value);
				using (SqlCommand comm = new SqlCommand("SELECT Gender FROM Genders WHERE ID_Gender = '" + Gender_ID_TextBox.Text + "'", sqlConnection))
				{
					using (SqlDataReader reader = await comm.ExecuteReaderAsync())
					{
						await reader.ReadAsync();
						Gender_TextBox.Text = (string)reader[0];
					}
				}
				Birthday_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Date_of_Birth"].Value);
				Phone_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Phone"].Value);
				Location_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Location"].Value);
				Card_ID_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["ID_Card"].Value);
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
			SqlCommand command = new SqlCommand("Add_Patient", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter nameParam = new SqlParameter
			{
				ParameterName = "@name",
				Value = Name_TextBox.Text
			};
			command.Parameters.Add(nameParam);

			SqlParameter genderParam = new SqlParameter
			{
				ParameterName = "@id_gender",
				Value = Gender_ID_TextBox.Text
			};
			command.Parameters.Add(genderParam);

			SqlParameter birthParam = new SqlParameter
			{
				ParameterName = "@date_of_birth",
				Value = Birthday_TextBox.Text
			};
			command.Parameters.Add(birthParam);

			SqlParameter phoneParam = new SqlParameter
			{
				ParameterName = "@phone",
				Value = Phone_TextBox.Text
			};
			command.Parameters.Add(phoneParam);

			SqlParameter locationParam = new SqlParameter
			{
				ParameterName = "@location",
				Value = Location_TextBox.Text
			};
			command.Parameters.Add(locationParam);

			SqlParameter cardIDParam = new SqlParameter
			{
				ParameterName = "@id_card",
				Value = Convert.ToInt32(Card_ID_TextBox.Text)
			};
			command.Parameters.Add(cardIDParam);

			await command.ExecuteScalarAsync();

			LoadTable();
		}

		private async void Update_Button_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("Update_Patient", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter patientIDParam = new SqlParameter
			{
				ParameterName = "@id_patient",
				Value = Convert.ToInt32(Patient_ID_TextBox.Text)
			};
			command.Parameters.Add(patientIDParam);

			SqlParameter nameParam = new SqlParameter
			{
				ParameterName = "@name",
				Value = Name_TextBox.Text
			};
			command.Parameters.Add(nameParam);

			SqlParameter genderParam = new SqlParameter
			{
				ParameterName = "@id_gender",
				Value = Gender_ID_TextBox.Text
			};
			command.Parameters.Add(genderParam);

			SqlParameter birthParam = new SqlParameter
			{
				ParameterName = "@date_of_birth",
				Value = Birthday_TextBox.Text
			};
			command.Parameters.Add(birthParam);

			SqlParameter phoneParam = new SqlParameter
			{
				ParameterName = "@phone",
				Value = Phone_TextBox.Text
			};
			command.Parameters.Add(phoneParam);

			SqlParameter locationParam = new SqlParameter
			{
				ParameterName = "@location",
				Value = Location_TextBox.Text
			};
			command.Parameters.Add(locationParam);

			SqlParameter cardIDParam = new SqlParameter
			{
				ParameterName = "@id_card",
				Value = Convert.ToInt32(Card_ID_TextBox.Text)
			};
			command.Parameters.Add(cardIDParam);

			await command.ExecuteScalarAsync();

			LoadTable();
		}

		private async void Delete_Button_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("Delete_Patient", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter idParam = new SqlParameter
			{
				ParameterName = "@id_patient",
				Value = Convert.ToInt32(Patient_ID_TextBox.Text)
			};
			command.Parameters.Add(idParam);

			await command.ExecuteScalarAsync();

			ClearAllTextBoxes();
			LoadTable();
		}

		private void Report_Button_Click(object sender, EventArgs e)
		{
			new Patients_Report() { sqlConnection = sqlConnection }.Show();
		}

		private void Search_Button_Click(object sender, EventArgs e)
		{
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
				dataGridView1.Rows[row.Index].Selected = false;
				if (row.Cells[1].Value.ToString().Contains(Search_TextBox.Text))
				{
					dataGridView1.Rows[row.Index].Selected = true;
					break;
				}
            }
        }
	}
}
