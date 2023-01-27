using AdaCredit.UI.Data;
using AdaCredit.UI.Domain;

namespace AdaCredit.UI.UseCases

{
    public static class AddNewClient
    {
        public static bool Execute(string name, long document, string phone, string address)
        {
            var client = new Client(name, document, phone, address);

            var repository = new ClientRepository();
            var result = repository.AddClient(client);

            if (result)
                return true;
            return false;
        }
    }
}
