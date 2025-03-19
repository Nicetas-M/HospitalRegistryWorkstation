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
	public partial class Medical_Services : Form
	{
		public SqlConnection sqlConnection = null;  //приймає відкрите з'єднання з базою даних при відкритті форми

		string oldIDService;

		public bool check; //приймає значення, дивлячись на яке, користувачу дозволяється чи забороняється редагувати дані форми

		public Medical_Services()
		{
			InitializeComponent();
		}

		private void LoadTable()
		{
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Medical_Services", sqlConnection);
			DataSet dataSet = new DataSet();
			sqlDataAdapter.Fill(dataSet);
			dataGridView1.DataSource = dataSet.Tables[0];
		}

		private void ClearAllTextBoxes()
		{
			Doctor_ID_TextBox.Clear();
			Full_Name_TextBox.Clear();
			Phone_TextBox.Clear();
			Service_ID_TextBox.Clear();
			Service_TextBox.Clear();
		}

		private void Medical_Services_Load(object sender, EventArgs e)
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
				Service_ID_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["ID_Service"].Value);
				oldIDService = Service_ID_TextBox.Text;
				Service_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Name"].Value);
				Doctor_ID_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["ID_Doctor"].Value);
				using (SqlCommand comm = new SqlCommand("SELECT Name, Phone FROM Doctors WHERE ID_Doctor = '" + Doctor_ID_TextBox.Text + "'", sqlConnection))
				{
					using (SqlDataReader reader = await comm.ExecuteReaderAsync())
					{
						await reader.ReadAsync();
						Full_Name_TextBox.Text = (string)reader[0];
						Phone_TextBox.Text = (string)reader[1];
					}
				}
				Price_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Price"].Value);
				Info_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Additional_Information"].Value);
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
			SqlCommand command = new SqlCommand("Add_Medical_Service", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter idParam = new SqlParameter()
			{
				ParameterName = "@id_service",
				Value = Service_ID_TextBox.Text
			};
			command.Parameters.Add(idParam);

			SqlParameter nameParam = new SqlParameter()
			{
				ParameterName = "@name",
				Value = Service_TextBox.Text
			};
			command.Parameters.Add(nameParam);

			SqlParameter idDoctorParam = new SqlParameter()
			{
				ParameterName = "@id_doctor",
				Value = Doctor_ID_TextBox.Text
			};
			command.Parameters.Add(idDoctorParam);

			SqlParameter priceParam = new SqlParameter()
			{
				ParameterName = "@price",
				Value = Convert.ToDecimal(Price_TextBox.Text)
			};
			command.Parameters.Add(priceParam);

			SqlParameter infoParam = new SqlParameter()
			{
				ParameterName = "@additional_information",
				Value = Info_TextBox.Text
			};
			command.Parameters.Add(infoParam);

			await command.ExecuteScalarAsync();

			LoadTable();
		}

		private async void Update_Button_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("Update_Medical_Service", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter oldIDParam = new SqlParameter()
			{
				ParameterName = "@old_id_service",
				Value = oldIDService
			};
			command.Parameters.Add(oldIDParam);

			SqlParameter newIDParam = new SqlParameter()
			{
				ParameterName = "@new_id_service",
				Value = Service_ID_TextBox.Text
			};
			command.Parameters.Add(newIDParam);

			SqlParameter nameParam = new SqlParameter()
			{
				ParameterName = "@name",
				Value = Service_TextBox.Text
			};
			command.Parameters.Add(nameParam);

			SqlParameter idDoctorParam = new SqlParameter()
			{
				ParameterName = "@id_doctor",
				Value = Doctor_ID_TextBox.Text
			};
			command.Parameters.Add(idDoctorParam);

			SqlParameter priceParam = new SqlParameter()
			{
				ParameterName = "@price",
				Value = Convert.ToDecimal(Price_TextBox.Text)
			};
			command.Parameters.Add(priceParam);

			SqlParameter infoParam = new SqlParameter()
			{
				ParameterName = "@additional_information",
				Value = Info_TextBox.Text
			};
			command.Parameters.Add(infoParam);

			await command.ExecuteScalarAsync();

			LoadTable();
		}

		private async void Delete_Button_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("Delete_Medical_Service", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter idParam = new SqlParameter
			{
				ParameterName = "@id_service",
				Value = Service_ID_TextBox.Text
			};
			command.Parameters.Add(idParam);

			await command.ExecuteScalarAsync();

			ClearAllTextBoxes();
			LoadTable();
		}

		private void Report_Button_Click(object sender, EventArgs e)
		{
			new Medical_Services_Report() { sqlConnection = sqlConnection }.Show();
		}
	}
}
