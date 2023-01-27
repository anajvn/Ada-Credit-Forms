using AdaCredit.UI.Data;
//using AdaCredit.UI.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaCredit.UI.UseCases
{
    public class IsFirstAccess
    {
        public static bool Execute()
        {
            var repository = new EmployeeRepository();
            var result = repository.FirstAccess();

            if (!result)
                return false;

            return true;
        }
    }
}
