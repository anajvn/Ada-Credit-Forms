using AdaCredit.UI.Data;

namespace AdaCredit.UI.UseCases
{
    public static class ChangeClientData
    {
        public static bool Execute(int index, long document, string newData = "")
        {
            var repository = new ClientRepository();
            var result = repository.ChangeData(document, index, newData);

            return result;
        }
    }
}
