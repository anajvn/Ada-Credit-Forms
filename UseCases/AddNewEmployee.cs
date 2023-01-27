using AdaCredit.UI.Data;
using AdaCredit.UI.Domain;


namespace AdaCredit.UI.UseCases
{
    public static class AddNewEmployee
    {
        public static bool Execute(string name, long document, string username, string cleanPassword, out int reason)
        {
            var employee = new Employee(name, document);
            
            var repository = new EmployeeRepository();
            var result = repository.AddEmployee(employee, username, cleanPassword, out reason);

            return result;
        }
    }
}
