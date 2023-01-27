using System.Globalization;
using AdaCredit.UI.Domain;
using CsvHelper;
using CsvHelper.Configuration;

namespace AdaCredit.UI.Data
{
    public class ClientRepository
    {
        private static List<Client> _clients = new List<Client>();

        static ClientRepository()
        {
            try
            {
                string path = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Environment.CurrentDirectory)));
                string fileName = "Clients.txt";
                string filePath = Path.Combine(path, fileName);

                if (!File.Exists(filePath))
                {
                    return;
                }

                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = false,
                };
                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, config))
                {
                    csv.Read();
                    _clients = csv.GetRecords<Client>().ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public List<Account> PassAccounts()
        {
            List<Account> accounts = _clients.Select(c => c.Account).ToList();
            return accounts;
        }

        public bool AddClient(Client client)
        {
            if (_clients.Any(c => c.Document.Equals(client.Document)))
                return false;

            var repository = new AccountRepository();
            _clients.Add(new Client(client.Name, client.Document, client.Phone, client.Address,
                repository.GetNewUnique()));

            Save();
            return true;
        }

        public void Save()
        {
            string path = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Environment.CurrentDirectory)));
            string fileName = "Clients.txt";

            string filePath = Path.Combine(path, fileName);

            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(_clients);
            }
        }

        public bool GetInfos(int index, string? info, out string[][] data, string? secondInfo = "")
        {
            IEnumerable<Client> clients;

            switch (index)
            {
                case 1:
                    clients = from c in _clients
                                  where c.Name.Contains(info)
                                  select c;
                    break;
                case 2:
                    long.TryParse(info, out var document);
                    clients = from c in _clients
                        where c.Document == document
                        select c;
                    break;
                default:
                    clients = from c in _clients
                        where c.Account.Number == info && c.Account.Branch == secondInfo
                        select c;
                    break;
            }

            data = new string[clients.Count()][];
            int count = 0;
            foreach(var client in clients)
            {
                var situation = "Inativa";
                if (client.Account.IsActive)
                    situation = "Ativa";
                string[] list = new string[]{client.Name, client.Document.ToString(), client.Phone, client.Address, client.Account.Number, client.Account.Branch, client.Account.Balance.ToString(), situation};
                data[count] = list;
                count++;
            }
            
            if (!clients.Any())
                return false;

            return true;
        }

        public bool ChangeData(long document, int index, string newData)
        {
            var client = _clients.FirstOrDefault(c => c.Document == document);

            if (client == null)
                return false;

            switch (index)
            {
                case 1:
                    client.Name = newData;
                    break;
                case 2:
                    bool isBeingUsed = _clients.Any(c => c.Document == long.Parse(newData));
                    if (isBeingUsed)
                        return false;
                    bool result = long.TryParse(newData, out var doc);
                    if(!result)
                        return false;
                    client.Document = doc;
                    break;
                case 3:
                    client.Phone = newData;
                    break;
                case 4:
                    client.Address = newData;
                    break;
                    //case 5:
                    //    var position = _clients.IndexOf(client);
                    //    _clients[position] = new Client(client.Name, document, AccountRepository.GetNewUnique(_clients));
                    //    Console.WriteLine($"A nova conta é {_clients[position].Account.Number}.");
            }

            Save();
            return true;
        }

        public bool DeactivateClient(long document, out bool isActive)
        {
            var client = _clients.FirstOrDefault(c => c.Document == document);

            isActive = false;

            if (client == null)
                return false;

            isActive = client.Account.IsActive;

            if (isActive)
                client.Account.IsActive = false;
            else
                client.Account.IsActive = true;

            Save();
            return true;
        }

        public void ChargeValues(string accountNumber, string branch, decimal value, int direction)
        {
            accountNumber = accountNumber.Insert(5, "-");

            var client = _clients.FirstOrDefault(c => c.Account.Number == accountNumber && c.Account.Branch == branch);

            if (direction == 0)
                client.Account.Balance -= value;
            if (direction == 1)
                client.Account.Balance += value;

            Save();
        }

        public string[][] CheckClientsAndBalances()
        {
            var size = 0;
            foreach (var c in _clients)
            {
                if (c.Account.IsActive)
                    size++;
            }
            string[][] clients = new string[size][];
            int index = 0;
            foreach (var c in _clients)
            {
                if (!c.Account.IsActive)
                    continue;
                string[] client = new string[] { c.Name, c.Document.ToString(), c.Account.Branch, c.Account.Number, c.Account.Balance.ToString()};
                clients[index] = client;
                index++;
            }
            return clients;
        }

        public string[][] CheckInactiveClients()
        {
            var size = 0;
            foreach (var c in _clients)
            {
                if (!c.Account.IsActive)
                    size++;
            }
            string[][] clients = new string[size][];
            int index = 0;
            foreach (var c in _clients)
            {
                if (c.Account.IsActive)
                    continue;
                string[] client = new string[] { c.Name, c.Document.ToString(), c.Account.Branch, c.Account.Number };
                clients[index] = client;
                index++;
            }
            return clients;
        }
        public bool IsAccountValid(string accountNumber, string branch)
        {
            accountNumber = accountNumber.Insert(5, "-");
            bool flag = _clients.Any(c => c.Account.Number == accountNumber && c.Account.Branch == branch);

            return flag;
        }
        public bool IsAccountActive(string accountNumber, string branch)
        {
            accountNumber = accountNumber.Insert(5, "-");
            var client = _clients.FirstOrDefault(c => c.Account.Number == accountNumber && c.Account.Branch == branch);

            return client.Account.IsActive;
        }
        public bool IsBalanceEnough(string accountNumber, string branch, decimal value)
        {
            accountNumber = accountNumber.Insert(5, "-");
            bool result = false;
            var client= _clients.FirstOrDefault(c => c.Account.Number == accountNumber && c.Account.Branch == branch);
            if (client.Account.Balance > value)
                result = true;

            return result;
        }
    }
}
