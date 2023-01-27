using AdaCredit.UI.Data;
using AdaCredit.UI.Domain;

namespace AdaCredit.UI.UseCases
{
    public static class ConsultClientData
    {
        public static bool Execute(int index, string info,out string[][] data,  string secondInfo = "")
        {
            var repository = new ClientRepository();
            var result = repository.GetInfos(index, info, out data,  secondInfo);

            return result;
        }
    }
}
