using AdaCredit.UI.Data;

namespace AdaCredit.UI.UseCases
{
    public class ConsultEmployeeData
    {
        public static bool Execute(int index, string info, out string[][] data)
        {
            var repository = new EmployeeRepository();
            var result = repository.GetInfos(index, info, out data);

            return result;
        }
    }
}
