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
	public partial class Genders : Form
	{
		public SqlConnection sqlConnection = null;  //приймає відкрите з'єднання з базою даних при відкритті форми

		string oldIDGender;

		public bool check; //приймає значення, дивлячись на яке, користувачу дозволяється чи забороняється редагувати дані форми

		public Genders()
		{
			InitializeComponent();
		}

		private void LoadTable()
		{
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Genders", sqlConnection);
			DataSet dataSet = new DataSet();
			sqlDataAdapter.Fill(dataSet);
			dataGridView1.DataSource = dataSet.Tables[0];
		}

		private void ClearAllTextBoxes()
		{
			Gender_ID_TextBox.Clear();
			Gender_TextBox.Clear();
		}

		private void Genders_Load(object sender, EventArgs e)
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
				Gender_ID_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["ID_Gender"].Value);
				Gender_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Gender"].Value);
				oldIDGender = Gender_ID_TextBox.Text;
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
			SqlCommand command = new SqlCommand("Add_Gender", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter idParam = new SqlParameter()
			{
				ParameterName = "@id_gender",
				Value = Gender_ID_TextBox.Text
			};
			command.Parameters.Add(idParam);

			SqlParameter genderParam = new SqlParameter()
			{
				ParameterName = "@gender",
				Value = Gender_TextBox.Text
			};
			command.Parameters.Add(genderParam);

			await command.ExecuteScalarAsync();

			LoadTable();
		}

		private async void Update_Button_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("Update_Gender", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter oldIDParam = new SqlParameter()
			{
				ParameterName = "@old_id_gender",
				Value = oldIDGender
			};
			command.Parameters.Add(oldIDParam);

			SqlParameter newIDParam = new SqlParameter()
			{
				ParameterName = "@new_id_gender",
				Value = Gender_ID_TextBox.Text
			};
			command.Parameters.Add(newIDParam);

			SqlParameter genderParam = new SqlParameter()
			{
				ParameterName = "@gender",
				Value = Gender_TextBox.Text
			};
			command.Parameters.Add(genderParam);

			await command.ExecuteScalarAsync();

			LoadTable();
		}

		private async void Delete_Button_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("Delete_Gender", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter idParam = new SqlParameter()
			{
				ParameterName = "@id_gender",
				Value = Gender_ID_TextBox.Text
			};
			command.Parameters.Add(idParam);

			await command.ExecuteScalarAsync();

			ClearAllTextBoxes();
			LoadTable();
		}

		private void Report_Button_Click(object sender, EventArgs e)
		{
			new Genders_Report() { sqlConnection = sqlConnection }.Show();
		}
	}
}
