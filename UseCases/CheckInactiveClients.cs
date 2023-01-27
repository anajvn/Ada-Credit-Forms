using AdaCredit.UI.Data;

namespace AdaCredit.UI.UseCases
{
    public class CheckInactiveClients
    {
        public static string[][] Execute()
        {
            var repository = new ClientRepository();
            return repository.CheckInactiveClients();
        }
    }
}
