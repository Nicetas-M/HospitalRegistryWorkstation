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
	public partial class Dispensary_Groups : Form
	{
		public SqlConnection sqlConnection = null;  //приймає відкрите з'єднання з базою даних при відкритті форми

		string oldIDDispensaryGroup;

		public bool check; //приймає значення, дивлячись на яке, користувачу дозволяється чи забороняється редагувати дані форми

		public Dispensary_Groups()
		{
			InitializeComponent();
		}

		private void LoadTable()
		{
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Dispensary_Groups", sqlConnection);
			DataSet dataSet = new DataSet();
			sqlDataAdapter.Fill(dataSet);
			dataGridView1.DataSource = dataSet.Tables[0];
		}

		private void ClearAllTextBoxes()
		{
			Dispensary_Group_ID_TextBox.Clear();
			Dispensary_Group_TextBox.Clear();
		}

		private void Dispensary_Groups_Load(object sender, EventArgs e)
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
				Dispensary_Group_ID_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["ID_Dispensary_Group"].Value);
				Dispensary_Group_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells["Dispensary_Group"].Value);
				oldIDDispensaryGroup = Dispensary_Group_ID_TextBox.Text;
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
			SqlCommand command = new SqlCommand("Add_Dispensary_Group", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter idParam = new SqlParameter()
			{
				ParameterName = "@id_dispensary_group",
				Value = Dispensary_Group_ID_TextBox.Text
			};
			command.Parameters.Add(idParam);

			SqlParameter dispensaryGroupParam = new SqlParameter()
			{
				ParameterName = "@dispensary_group",
				Value = Dispensary_Group_TextBox.Text
			};
			command.Parameters.Add(dispensaryGroupParam);

			await command.ExecuteScalarAsync();

			LoadTable();
		}

		private async void Update_Button_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("Update_Dispensary_Group", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter oldIDParam = new SqlParameter()
			{
				ParameterName = "@old_id_dispensary_group",
				Value = oldIDDispensaryGroup
			};
			command.Parameters.Add(oldIDParam);

			SqlParameter newIDParam = new SqlParameter()
			{
				ParameterName = "@new_id_dispensary_group",
				Value = Dispensary_Group_ID_TextBox.Text
			};
			command.Parameters.Add(newIDParam);

			SqlParameter dispensaryGroupParam = new SqlParameter()
			{
				ParameterName = "@dispensary_group",
				Value = Dispensary_Group_TextBox.Text
			};
			command.Parameters.Add(dispensaryGroupParam);

			await command.ExecuteScalarAsync();

			LoadTable();
		}

		private async void Delete_Button_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("Delete_Dispensary_Group", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter idParam = new SqlParameter()
			{
				ParameterName = "@id_dispensary_group",
				Value = Dispensary_Group_ID_TextBox.Text
			};
			command.Parameters.Add(idParam);

			await command.ExecuteScalarAsync();

			ClearAllTextBoxes();
			LoadTable();
		}

		private void Report_Button_Click(object sender, EventArgs e)
		{
			new Dispensary_Groups_Report() { sqlConnection = sqlConnection }.Show();
		}
	}
}
