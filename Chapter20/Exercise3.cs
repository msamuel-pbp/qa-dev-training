using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Chapter20 {
    public class Exercise3 {
        public void Run() {
            var connection = ConfigurationManager.ConnectionStrings["SampleDatabaseConnectionString"].ConnectionString;
            var command = @"select distinct e.LastName,e.FirstName 
                            from Employees e
                            left join EmployeeTerritories et on et.EmployeeID = e.EmployeeID
                            left join Territories t on t.TerritoryID = et.TerritoryID
                            where t.RegionID = 1";
            var dataAdapter = new SqlDataAdapter(command, connection);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            var dataTable = dataSet.Tables[0];
            foreach (DataRow row in dataTable.Rows) {
                Console.WriteLine("LastName: {0},FirstName: {1}", row["LastName"], row["FirstName"]);
            }
        }
    }
}
