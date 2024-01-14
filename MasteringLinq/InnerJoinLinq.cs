using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasteringLinq
{
    public class InnerJoinLinq
    {
        public void innerJoin()
        {
            var EmployeeWithAddress = Employee.GetAllEmployees().Join(
              Address.GetAllAddresses(),
              employee => employee.AddressId,
              address => address.ID,
              (employee, address) => new
              {
                  EmployeeName = employee.Name,
                  AddressLine = address.AddressLine,
              }
              ).ToList();

            foreach (var employee in EmployeeWithAddress)
            {
                Console.WriteLine($"{employee.AddressLine} ,{employee.EmployeeName}");
            }
        }
    }
}
