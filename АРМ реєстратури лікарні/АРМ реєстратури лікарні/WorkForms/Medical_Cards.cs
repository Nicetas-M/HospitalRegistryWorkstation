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
using Microsoft.IdentityModel.Tokens;
using Microsoft.Reporting.WebForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace АРМ_реєстратури_лікарні
{
	public partial class Medical_Cards : Form
	{
		public SqlConnection sqlConnection = null;  //приймає відкрите з'єднання з базою даних при відкритті форми

		int oldIDCard;

		public bool check; //приймає значення, дивлячись на яке, користувачу дозволяється чи забороняється редагувати дані форми

		public Medical_Cards()
		{
			InitializeComponent();
		}

		private void LoadTable()
		{
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Medical_Cards", sqlConnection);
			DataSet dataSet = new DataSet();
			sqlDataAdapter.Fill(dataSet);
			dataGridView1.DataSource = dataSet.Tables[0];
		}

		private void ClearAllTextBoxes()
		{
			Card_ID_TextBox.Clear();
			EDRPOU_ID_TextBox.Clear();
			Dispensary_Group_ID_TextBox.Clear();
			Dispensary_Group_TextBox.Clear();
			Contingent_ID_TextBox.Clear();
			Contingent_TextBox.Clear();
			License_Number_TextBox.Clear();
			Date_TextBox.Clear();
		}

		private void Medical_Cards_Load(object sender, EventArgs e)
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
				Card_ID_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["ID_Card"].Value);
				oldIDCard = Convert.ToInt32(Card_ID_TextBox.Text);
				EDRPOU_ID_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["ID_EDRPOU"].Value);
				Dispensary_Group_ID_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["ID_Dispensary_Group"].Value);
				using (SqlCommand comm = new SqlCommand("SELECT Dispensary_Group FROM Dispensary_Groups WHERE ID_Dispensary_Group = '" + Dispensary_Group_ID_TextBox.Text + "'", sqlConnection))
				{
					using (SqlDataReader reader = await comm.ExecuteReaderAsync())
					{
						await reader.ReadAsync();
						Dispensary_Group_TextBox.Text = (string)reader[0];
					}
				}
				Contingent_ID_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["ID_Contingent"].Value);
				using (SqlCommand comm = new SqlCommand("SELECT Contingent FROM Contingents WHERE ID_Contingent = '" + Contingent_ID_TextBox.Text + "'", sqlConnection))
				{
					using (SqlDataReader reader = await comm.ExecuteReaderAsync())
					{
						await reader.ReadAsync();
						Contingent_TextBox.Text = (string)reader[0];
					}
				}
				License_Number_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Preferential_License_Number"].Value);
				Date_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Medical_Card_Registration_Date"].Value);
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
			SqlCommand command = new SqlCommand("Add_Medical_Card", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter idParam = new SqlParameter
			{
				ParameterName = "@id_card",
				Value = Convert.ToInt32(Card_ID_TextBox.Text)
			};
			command.Parameters.Add(idParam);

			SqlParameter edrpouParam = new SqlParameter
			{
				ParameterName = "@id_EDRPOU",
				Value = EDRPOU_ID_TextBox.Text
			};
			command.Parameters.Add(edrpouParam);

			SqlParameter dispensaryGroupParam = new SqlParameter
			{
				ParameterName = "@id_dispensary_group",
				Value = Dispensary_Group_ID_TextBox.Text
			};
			command.Parameters.Add(dispensaryGroupParam);

			SqlParameter contingentParam = new SqlParameter
			{
				ParameterName = "@id_contingent",
				Value = Contingent_ID_TextBox.Text
			};
			command.Parameters.Add(contingentParam);

			SqlParameter licenseNumberParam = new SqlParameter
			{
				ParameterName = "@preferential_license_number",
				Value = License_Number_TextBox.Text
			};
			command.Parameters.Add(licenseNumberParam);

			SqlParameter dateParam = new SqlParameter
			{
				ParameterName = "@medical_card_registration_date",
				Value = Date_TextBox.Text
			};
			command.Parameters.Add(dateParam);

			await command.ExecuteScalarAsync();

			LoadTable();
		}

		private async void Update_Button_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("Update_Medical_Card", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter oldIDParam = new SqlParameter
			{
				ParameterName = "@old_id_card",
				Value = oldIDCard
			};
			command.Parameters.Add(oldIDParam);

			SqlParameter newIDParam = new SqlParameter
			{
				ParameterName = "@new_id_card",
				Value = Convert.ToInt32(Card_ID_TextBox.Text)
			};
			command.Parameters.Add(newIDParam);

			SqlParameter edrpouParam = new SqlParameter
			{
				ParameterName = "@id_EDRPOU",
				Value = EDRPOU_ID_TextBox.Text
			};
			command.Parameters.Add(edrpouParam);

			SqlParameter dispensaryGroupParam = new SqlParameter
			{
				ParameterName = "@id_dispensary_group",
				Value = Dispensary_Group_ID_TextBox.Text
			};
			command.Parameters.Add(dispensaryGroupParam);

			SqlParameter contingentParam = new SqlParameter
			{
				ParameterName = "@id_contingent",
				Value = Contingent_ID_TextBox.Text
			};
			command.Parameters.Add(contingentParam);

			SqlParameter licenseNumberParam = new SqlParameter
			{
				ParameterName = "@preferential_license_number",
				Value = License_Number_TextBox.Text
			};
			command.Parameters.Add(licenseNumberParam);

			SqlParameter dateParam = new SqlParameter
			{
				ParameterName = "@medical_card_registration_date",
				Value = Date_TextBox.Text
			};
			command.Parameters.Add(dateParam);

			await command.ExecuteScalarAsync();

			LoadTable();
		}

		private async void Delete_Button_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("Delete_Medical_Card", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter idParam = new SqlParameter
			{
				ParameterName = "@id_card",
				Value = Convert.ToInt32(Card_ID_TextBox.Text)
			};
			command.Parameters.Add(idParam);

			await command.ExecuteScalarAsync();

			ClearAllTextBoxes();
			LoadTable();
		}

		private void Report_Button_Click(object sender, EventArgs e)
		{
			new Medical_Cards_Report() { sqlConnection = sqlConnection }.Show();
		}

		private void CurrentDate_Button_Click(object sender, EventArgs e)
		{
			Date_TextBox.Text = DateTime.Now.ToString();
		}
	}
}
