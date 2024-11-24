using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsWorkApp
{
    public interface IDatabase
    {
        IEnumerable<Employee> Employees();
        Employee GetEmployee(int id);
        void Create(Employee employee);
    }
}
