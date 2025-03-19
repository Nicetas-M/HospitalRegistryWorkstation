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
	public partial class Statuses : Form
	{
		public SqlConnection sqlConnection = null;  //приймає відкрите з'єднання з базою даних при відкритті форми

		string oldIDStatus;

		public bool check; //приймає значення, дивлячись на яке, користувачу дозволяється чи забороняється редагувати дані форми

		public Statuses()
		{
			InitializeComponent();
		}

		private void LoadTable()
		{
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Statuses", sqlConnection);
			DataSet dataSet = new DataSet();
			sqlDataAdapter.Fill(dataSet);
			dataGridView1.DataSource = dataSet.Tables[0];
		}

		private void ClearAllTextBoxes()
		{
			Status_ID_TextBox.Clear();
			Status_TextBox.Clear();
		}

		private void Statuses_Load(object sender, EventArgs e)
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
				Status_ID_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["ID_Status"].Value);
				Status_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Status"].Value);
				oldIDStatus = Status_ID_TextBox.Text;
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
			SqlCommand command = new SqlCommand("Add_Status", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter idParam = new SqlParameter()
			{
				ParameterName = "@id_status",
				Value = Status_ID_TextBox.Text
			};
			command.Parameters.Add(idParam);

			SqlParameter statusParam = new SqlParameter()
			{
				ParameterName = "@status",
				Value = Status_TextBox.Text
			};
			command.Parameters.Add(statusParam);

			await command.ExecuteScalarAsync();

			LoadTable();
		}

		private async void Update_Button_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("Update_Status", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter oldIDParam = new SqlParameter()
			{
				ParameterName = "@old_id_status",
				Value = oldIDStatus
			};
			command.Parameters.Add(oldIDParam);

			SqlParameter newIDParam = new SqlParameter()
			{
				ParameterName = "@new_id_status",
				Value = Status_ID_TextBox.Text
			};
			command.Parameters.Add(newIDParam);

			SqlParameter statusParam = new SqlParameter()
			{
				ParameterName = "@status",
				Value = Status_TextBox.Text
			};
			command.Parameters.Add(statusParam);

			await command.ExecuteScalarAsync();

			LoadTable();
		}

		private async void Delete_Button_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("Delete_Status", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter idParam = new SqlParameter()
			{
				ParameterName = "@id_status",
				Value = Status_ID_TextBox.Text
			};
			command.Parameters.Add(idParam);

			await command.ExecuteScalarAsync();

			ClearAllTextBoxes();
			LoadTable();
		}

		private void Report_Button_Click(object sender, EventArgs e)
		{
			new Statuses_Report() { sqlConnection = sqlConnection }.Show();
		}
	}
}
