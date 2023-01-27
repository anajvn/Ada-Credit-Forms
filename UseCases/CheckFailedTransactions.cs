using AdaCredit.UI.Data;

namespace AdaCredit.UI.UseCases
{
    public class CheckFailedTransactions
    {
        public static string[][] Execute()
        {
            return TransactionsRepository.FailedTransactions();
        }
    }
}
