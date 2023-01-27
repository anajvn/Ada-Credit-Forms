using AdaCredit.UI.Data;

namespace AdaCredit.UI.UseCases
{
    public class CheckActiveEmployees
    {
        public static string[][] Execute()
        {
            var repository = new EmployeeRepository();
            return repository.CheckEmployeesAndLogin();
        }
    }
}
