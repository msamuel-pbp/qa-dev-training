using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Chapter20 {
    public class Exercise1 {
        public void Run() {
            var connection = ConfigurationManager.ConnectionStrings["SampleDatabaseConnectionString"].ConnectionString;
            var command = "select OrderDate,ShippedDate from orders";
            var dataAdapter = new SqlDataAdapter(command, connection);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            var dataTable = dataSet.Tables[0];
            foreach (DataRow row in dataTable.Rows) {
                Console.WriteLine("Order: {0} | Shipped: {1}",row["OrderDate"],row["ShippedDate"]);
            }
        }
    }
}