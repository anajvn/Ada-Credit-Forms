using AdaCredit.UI.Data;

namespace AdaCredit.UI.UseCases
{
    public static class DeactivateClientRegister
    {
        public static bool Execute(long document, out bool isActive)
        {
            var repository = new ClientRepository();
            var result = repository.DeactivateClient(document, out isActive);

            return result;
        }
    }
}
