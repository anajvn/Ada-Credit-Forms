using AdaCredit.UI.Domain;
using Bogus;

namespace AdaCredit.UI.Data
{
    public class AccountRepository
    {
        private static List<Account> _accounts = new List<Account>();

        static AccountRepository()
        {
            var repository = new ClientRepository();
            _accounts = repository.PassAccounts();
        }
        public Account GetNewUnique()
        {
            var exists = false;
            var accountNumber = "";

            do
            {
                accountNumber = new Faker().Random.ReplaceNumbers("#####-#");
                exists = _accounts.Any(a => a.Number.Equals(accountNumber));

            } while (exists);

            return new Account(accountNumber);
        }

        public Account ReturnRandomAccount()
        {
            var index = new Random().Next(0, _accounts.Count);
            return _accounts[index];
        }
    }
}
