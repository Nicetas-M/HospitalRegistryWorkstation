using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;

namespace АРМ_реєстратури_лікарні
{
	public partial class Doctors_Schedules : Form
	{
		public SqlConnection sqlConnection = null;  //приймає відкрите з'єднання з базою даних при відкритті форми

		string oldIdSchedule;

		public bool check; //приймає значення, дивлячись на яке, користувачу дозволяється чи забороняється редагувати дані форми

		public Doctors_Schedules()
		{
			InitializeComponent();
		}

		private void LoadTable()
		{
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Doctors_Schedules", sqlConnection);
			DataSet dataSet = new DataSet();
			sqlDataAdapter.Fill(dataSet);
			dataGridView1.DataSource = dataSet.Tables[0];
		}

		private void ClearAllTextBoxes()
		{
			Schedule_ID_TextBox.Clear();
			BeginWorkDay_TextBox.Clear();
			EndWorkDay_TextBox.Clear();
			BeginLunchBreak_TextBox.Clear();
			EndLunchBreak_TextBox.Clear();
		}

		private void Doctors_Schedules_Load(object sender, EventArgs e)
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
				Schedule_ID_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells[0].Value);
				BeginWorkDay_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells[1].Value);
				EndWorkDay_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells[4].Value);
				BeginLunchBreak_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells[2].Value);
				EndLunchBreak_TextBox.Text = Convert.ToString(dgv.SelectedRows[0].Cells[3].Value);
				oldIdSchedule = Schedule_ID_TextBox.Text;
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
			SqlCommand command = new SqlCommand("Add_Doctors_Schedule", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter idParam = new SqlParameter()
			{
				ParameterName = "@id_schedule",
				Value = Schedule_ID_TextBox.Text
			};
			command.Parameters.Add(idParam);

			SqlParameter beginWorkDayParam = new SqlParameter()
			{
				ParameterName = "@begin_of_the_work_day",
				Value = BeginWorkDay_TextBox.Text
			};
			command.Parameters.Add(beginWorkDayParam);

			SqlParameter endWorkDayParam = new SqlParameter()
			{
				ParameterName = "@end_of_the_work_day",
				Value = EndWorkDay_TextBox.Text

			};
			command.Parameters.Add(endWorkDayParam);

			SqlParameter beginLunchBreakParam = new SqlParameter()
			{
				ParameterName = "@begin_of_the_lunch_break",
				Value = BeginLunchBreak_TextBox.Text
			};
			command.Parameters.Add(beginLunchBreakParam);

			SqlParameter endLunchBreakParam = new SqlParameter()
			{
				ParameterName = "@end_of_the_lunch_break",
				Value = EndLunchBreak_TextBox.Text
			};
			command.Parameters.Add(endLunchBreakParam);

			await command.ExecuteScalarAsync();

			LoadTable();
		}

		private async void Update_Button_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("Update_Doctors_Schedule", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter oldIdParam = new SqlParameter()
			{
				ParameterName = "@old_id_schedule",
				Value = oldIdSchedule
			};
			command.Parameters.Add(oldIdParam);

			SqlParameter newIdParam = new SqlParameter()
			{
				ParameterName = "@new_id_schedule",
				Value = Schedule_ID_TextBox.Text
			};
			command.Parameters.Add(newIdParam);

			SqlParameter beginWorkDayParam = new SqlParameter()
			{
				ParameterName = "@begin_of_the_work_day",
				Value = BeginWorkDay_TextBox.Text
			};
			command.Parameters.Add(beginWorkDayParam);

			SqlParameter beginLunchBreakParam = new SqlParameter()
			{
				ParameterName = "@begin_of_the_lunch_break",
				Value = BeginLunchBreak_TextBox.Text
			};
			command.Parameters.Add(beginLunchBreakParam);

			SqlParameter endLunchBreakParam = new SqlParameter()
			{
				ParameterName = "@end_of_the_lunch_break",
				Value = EndLunchBreak_TextBox.Text
			};
			command.Parameters.Add(endLunchBreakParam);

			SqlParameter endWorkDayParam = new SqlParameter()
			{
				ParameterName = "@end_of_the_work_day",
				Value = EndWorkDay_TextBox.Text
			};
			command.Parameters.Add(endWorkDayParam);

			await command.ExecuteScalarAsync();

			LoadTable();
		}

		private async void Delete_Button_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("Delete_Doctors_Schedule", sqlConnection);
			command.CommandType = CommandType.StoredProcedure;

			SqlParameter idParam = new SqlParameter()
			{
				ParameterName = "@id_schedule",
				Value = Schedule_ID_TextBox.Text
			};
			command.Parameters.Add(idParam);

			await command.ExecuteScalarAsync();

			ClearAllTextBoxes();
			LoadTable();
		}

		private void Report_Button_Click(object sender, EventArgs e)
		{
			new Doctors_Schedules_Report() { sqlConnection = sqlConnection }.Show();
		}
	}
}
