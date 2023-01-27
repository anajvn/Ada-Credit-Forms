using AdaCredit.UI.Domain;
using CsvHelper.Configuration;
using CsvHelper;
using System.Globalization;

namespace AdaCredit.UI.Data
{
    public class EmployeeRepository
    {
        private static List<Employee> _employees = new List<Employee>();

        static EmployeeRepository()
        {
            try
            {
                string path = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Environment.CurrentDirectory)));
                string fileName = "Employees.txt";
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
                    _employees = csv.GetRecords<Employee>().ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool FirstAccess()
        {
            if (_employees.Any())
                return false;

            return true;
        }
        public void SaveAccess(string username)
        {
            var employee = _employees.FirstOrDefault(e => e.User.Username == username);

            employee.LastAccess = DateTime.Now;

            Save();
        }
        public bool AddEmployee(Employee employee, string username, string cleanPassword, out int reason)
        {
            if (_employees.Any(e => e.Document.Equals(employee.Document)))
            {
                reason = 1;
                return false;
            }
            if (UserRepository.IsUsernameUsed(_employees, username))
            {
                reason = 2;
                return false;
            }

            _employees.Add(new Employee(employee.Name, employee.Document, new User(username, 
                UserRepository.GenerateHash(cleanPassword, out var salt), salt)));

            Save();
            reason = 0;
            return true;
        }
        public void Save()
        {
            string path = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Environment.CurrentDirectory)));
            string fileName = "Employees.txt";

            string filePath = Path.Combine(path, fileName);

            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(_employees);
            }
        }
        public bool IsLoginValid(string user, string password)
        {
            var employee = _employees.FirstOrDefault(e => e.User.Username == user);

            if (employee == null)
                return false;

            var hashedPassword = UserRepository.Hash(password, employee.User.Salt);

            if (_employees.Any(e => e.User.Username == user && hashedPassword == e.User.HashedPassword))
                return true;

            return false;
        }
        public bool GetInfos(int index, string? info, out string[][] data)
        {
            IEnumerable<Employee> employees;

            switch (index)
            {
                case 1:
                    employees = from e in _employees
                        where e.Name.Contains(info) 
                        select e;
                    break;
                case 2:
                    long.TryParse(info, out var document);
                    employees = from e in _employees
                        where e.Document == document
                        select e;
                    break;
                default:
                    employees = from e in _employees
                        where e.User.Username == info
                        select e;
                    break;
            }

            data = new string[employees.Count()][];
            int count = 0;
            foreach (var e in employees)
            {
                var situation = "Inativa";
                if (e.IsActive)
                    situation = "Ativa";
                string[] list = new string[] {e.Name, e.Document.ToString(), e.User.Username, situation, e.LastAccess.ToString()};
                data[count] = list;
                count++;
            }

            if (!employees.Any())
                return false;

            return true;
        }
        public bool ChangeData(long document, int index, string newData)
        {
            var employee = _employees.FirstOrDefault(e => e.Document == document);

            if (employee == null)
                return false;
            
            bool isBeingUsed;

            switch (index)
            {
                case 1:
                    employee.Name = newData;
                    break;
                case 2:
                    isBeingUsed = _employees.Any(c => c.Document == long.Parse(newData));
                    if (isBeingUsed)
                        return false;
                    bool result = long.TryParse(newData, out var doc);
                    if(!result) 
                        return false;

                    employee.Document = doc;
                    break;
                case 3:
                    isBeingUsed = UserRepository.IsUsernameUsed(_employees, newData);
                    if(isBeingUsed)
                        return false;

                    employee.User.Username = newData;
                    break;
                case 4:
                    employee.User.HashedPassword = UserRepository.ChangePassword(newData, out var salt);
                    employee.User.Salt = salt;
                    break;
            }
            Save();
            return true;
        }
        public bool DeactivateEmployee(long document, out bool isActive)
        {
            var employee = _employees.FirstOrDefault(e => e.Document == document);

            isActive = false;

            if (employee == null)
                return false;

            isActive = employee.IsActive;

            if (isActive)
                employee.IsActive = false;
            else
                employee.IsActive = true;

            Save();
            return true;
        }

        public string[][] CheckEmployeesAndLogin()
        {
            var size = 0;
            foreach (var e in _employees)
            {
                if (e.IsActive)
                    size++;
            }

            string[][] employees = new string[size][];
            int index = 0;
            foreach (var e in _employees)
            {
                if (!e.IsActive)
                    continue;
                string[] employee = new string[]
                    { e.Name, e.Document.ToString(), e.User.Username, e.LastAccess.ToString() };
                employees[index] = employee;
                index++;
            }

            return employees;
        }

        public void AddEmployeesList(List<Employee> employees)
        {
            foreach (var employee in employees)
                _employees.Add(employee);

            Save();
        }
    }
}
