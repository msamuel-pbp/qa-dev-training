using System;
using System.Linq;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Chapter20 {
    public class Sample2 {
        public static void Maint2(string[] args) {
            var db = new SampleDatabaseDataContext();

            var empQuery =
                from emp in db.Employees
                select emp;
            Console.WriteLine("Employee List");
            foreach (var e in empQuery) {
                Console.WriteLine("ID:{0},Name:{1} {2}",e.EmployeeID,e.FirstName,e.LastName);
            }

            var orderQuery =
                from order in db.Order_Details
                where order.OrderID >= 10250 && order.OrderID <= 10255
                select order;
            Console.WriteLine("Product orders between 10250 and 10255");
            foreach (var o in orderQuery) {
                Console.WriteLine("ID:{0}\tQty:{1}\tProduct:{2}", o.OrderID, o.Quantity, o.Product);
            }

            db.Dispose();
        }            
    }
}