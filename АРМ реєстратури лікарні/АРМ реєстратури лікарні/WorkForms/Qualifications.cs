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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace АРМ_реєстратури_лікарні
{
	public partial class Qualifications : Form
	{
		public SqlConnection sqlConnection = null;  //приймає відкрите з'єднання з базою даних при відкритті форми

		string oldIDQualification;

		public bool check; //приймає значення, дивлячись на яке, користувачу дозволяється чи забороняється редагувати дані форми

		public Qualifications()
		{
			InitializeComponent();
		}

		private void LoadTable()
		{
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Qualifications", sqlConnection);
			DataSet dataSet = new DataSet();
			sqlDataAdapter.Fill(dataSet);
			dataGridView1.DataSource = dataSet.Tables[0];
		}

		private void ClearAllTextBoxes()
		{
			Qualification_ID_TextBox.Clear();
			Qualification_TextBox.Clear();
		}

		private void Qualifications_Load(object sender, EventArgs e)
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
				Qualification_ID_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["ID_Qualification"].Value);
				Qualification_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Qualification"].Value);
				oldIDQualification = Qualification_ID_TextBox.Text;
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
			SqlCommand command = new SqlCommand("Add_Qualification", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter idParam = new SqlParameter()
			{
				ParameterName = "@id_qualification",
				Value = Qualification_ID_TextBox.Text
			};
			command.Parameters.Add(idParam);

			SqlParameter qualificationParam = new SqlParameter()
			{
				ParameterName = "@qualification",
				Value = Qualification_TextBox.Text
			};
			command.Parameters.Add(qualificationParam);

			await command.ExecuteScalarAsync();

			LoadTable();
		}

		private async void Update_Button_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("Update_Qualification", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter oldIDParam = new SqlParameter()
			{
				ParameterName = "@old_id_qualification",
				Value = oldIDQualification
			};
			command.Parameters.Add(oldIDParam);

			SqlParameter newIDParam = new SqlParameter()
			{
				ParameterName = "@new_id_qualification",
				Value = Qualification_ID_TextBox.Text
			};
			command.Parameters.Add(newIDParam);

			SqlParameter qualificationParam = new SqlParameter()
			{
				ParameterName = "@qualification",
				Value = Qualification_TextBox.Text
			};
			command.Parameters.Add(qualificationParam);

			await command.ExecuteScalarAsync();

			LoadTable();
		}

		private async void Delete_Button_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("Delete_Qualification", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter idParam = new SqlParameter()
			{
				ParameterName = "@id_qualification",
				Value = Qualification_ID_TextBox.Text
			};
			command.Parameters.Add(idParam);

			await command.ExecuteScalarAsync();

			ClearAllTextBoxes();
			LoadTable();
		}

		private void Report_Button_Click(object sender, EventArgs e)
		{
			new Qualifications_Report() { sqlConnection = sqlConnection }.Show();
		}
	}
}
