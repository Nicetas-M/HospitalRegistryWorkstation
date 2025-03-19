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

namespace АРМ_реєстратури_лікарні
{
	public partial class Medical_Cards_Report : Form
	{
		public SqlConnection sqlConnection = null;  //приймає відкрите з'єднання з базою даних при відкритті форми

		public Medical_Cards_Report()
		{
			InitializeComponent();
		}

		private void Medical_Cards_Report_Load(object sender, EventArgs e)
		{
			SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Medical_Cards", sqlConnection);
			DataSet dataSet = new DataSet();
			adapter.Fill(dataSet);
			adapter.Dispose();
			medicalCardsDataSetBindingSource.DataSource = dataSet.Tables[0];
			this.reportViewer1.RefreshReport();
        }
    }
}
