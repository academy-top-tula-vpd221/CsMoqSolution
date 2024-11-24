using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsWorkApp
{
    public class EmployeeWork
    {
        IDatabase employeesDb;
        public EmployeeWork(IDatabase database)
        {
            employeesDb = database;
        }

        public IEnumerable<Employee> Show()
        {
            //string result = "";
            //foreach(var e in employeesDb.Employees())
            //    result += e.Name + "\n";
            //return result;
            return employeesDb.Employees();
        }
    }
}
