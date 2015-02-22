using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Chapter20 {
    public class Exercise2 {
        public void Run() {
            var connection = ConfigurationManager.ConnectionStrings["SampleDatabaseConnectionString"].ConnectionString;
            var command = @"select ProductID,ProductName from Products p
                            where p.UnitsInStock < 10";
            var dataAdapter = new SqlDataAdapter(command, connection);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            var dataTable = dataSet.Tables[0];
            foreach (DataRow row in dataTable.Rows) {
                Console.WriteLine("ID: {0},Name: {1}", row["ProductID"], row["ProductName"]);
            }
        }
    }
}
