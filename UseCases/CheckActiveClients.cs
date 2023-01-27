using AdaCredit.UI.Data;

namespace AdaCredit.UI.UseCases
{
    public class CheckActiveClients
    {
        public static string[][] Execute()
        {
            var repository = new ClientRepository();
            
            return repository.CheckClientsAndBalances();
        }
    }
}
