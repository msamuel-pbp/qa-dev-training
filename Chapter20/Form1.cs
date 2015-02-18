using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Chapter20 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e) {
            lblQuery.Text = null;

            var connectionString = ConfigurationManager.ConnectionStrings["SampleDatabaseConnectionString"].ConnectionString;
            var commandString = @"Select CompanyName,ContactName from Customers";
            var dataAdapter = new SqlDataAdapter(commandString, connectionString);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            var dataTable = dataSet.Tables[0];
            foreach (DataRow row in dataTable.Rows) {
               lblQuery.Text += String.Format("CompanyName:{0},Contact:{1}\n", row["CompanyName"], row["ContactName"]);
            }
        }
    }
}