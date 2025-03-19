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
	public partial class Offices : Form
	{
		public SqlConnection sqlConnection = null;  //приймає відкрите з'єднання з базою даних при відкритті форми

		string oldIDOffice;

		public bool check; //приймає значення, дивлячись на яке, користувачу дозволяється чи забороняється редагувати дані форми

		public Offices()
		{
			InitializeComponent();
		}

		private void LoadTable()
		{
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Offices", sqlConnection);
			DataSet dataSet = new DataSet();
			sqlDataAdapter.Fill(dataSet);
			dataGridView1.DataSource = dataSet.Tables[0];
		}

		private void ClearAllTextBoxes()
		{
			Office_ID_TextBox.Clear();
			Office_TextBox.Clear();
		}

		private void Offices_Load(object sender, EventArgs e)
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
				Office_ID_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["ID_Office"].Value);
				Office_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Office"].Value);
				oldIDOffice = Office_ID_TextBox.Text;
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
			SqlCommand command = new SqlCommand("Add_Office", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter idParam = new SqlParameter()
			{
				ParameterName = "@id_office",
				Value = Office_ID_TextBox.Text
			};
			command.Parameters.Add(idParam);

			SqlParameter officeParam = new SqlParameter()
			{
				ParameterName = "@office",
				Value = Office_TextBox.Text
			};
			command.Parameters.Add(officeParam);

			await command.ExecuteScalarAsync();

			LoadTable();
		}

		private async void Update_Button_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("Update_Office", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter oldIDParam = new SqlParameter()
			{
				ParameterName = "@old_id_office",
				Value = oldIDOffice
			};
			command.Parameters.Add(oldIDParam);

			SqlParameter newIDParam = new SqlParameter()
			{
				ParameterName = "@new_id_office",
				Value = Office_ID_TextBox.Text
			};
			command.Parameters.Add(newIDParam);

			SqlParameter officeParam = new SqlParameter()
			{
				ParameterName = "@office",
				Value = Office_TextBox.Text
			};
			command.Parameters.Add(officeParam);

			await command.ExecuteScalarAsync();

			LoadTable();
		}

		private async void Delete_Button_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("Delete_Office", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter idParam = new SqlParameter()
			{
				ParameterName = "@id_office",
				Value = Office_ID_TextBox.Text
			};
			command.Parameters.Add(idParam);

			await command.ExecuteScalarAsync();

			ClearAllTextBoxes();
			LoadTable();
		}

		private void Report_Button_Click(object sender, EventArgs e)
		{
			new Offices_Report() { sqlConnection = sqlConnection }.Show();
		}
	}
}
