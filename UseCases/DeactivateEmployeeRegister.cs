using AdaCredit.UI.Data;

namespace AdaCredit.UI.UseCases
{
    public class DeactivateEmployeeRegister
    {
        public static bool Execute(long document, out bool IsActive)
        {
            var repository = new EmployeeRepository();
            var result = repository.DeactivateEmployee(document, out IsActive);

            return result;
        }
    }
}
