namespace MasteringLinq
{
    internal class Program
    {
        static void Main(string[] args)
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

            foreach ( var employee in EmployeeWithAddress )
            {
                Console.WriteLine( $"{employee.AddressLine} ,{employee.EmployeeName}");
            }
        }
    }
}
