using AdaCredit.UI.Data;

namespace AdaCredit.UI.UseCases
{
    public class ChangeEmployeeData
    {
        public static bool Execute(int index, long document, string newData)
        {
            var repository = new EmployeeRepository();
            var result = repository.ChangeData(document, index, newData);

            return result;
        }
    }
}
