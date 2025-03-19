﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace АРМ_реєстратури_лікарні
{
	public partial class Genders_Report : Form
	{
		public SqlConnection sqlConnection = null;  //приймає відкрите з'єднання з базою даних при відкритті форми

		public Genders_Report()
		{
			InitializeComponent();
		}

		private void Genders_Report_Load(object sender, EventArgs e)
		{
			SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Genders", sqlConnection);
			DataSet dataSet = new DataSet();
			adapter.Fill(dataSet);
			adapter.Dispose();
			gendersDataSetBindingSource.DataSource = dataSet.Tables[0];
			this.reportViewer1.RefreshReport();
        }
    }
}
