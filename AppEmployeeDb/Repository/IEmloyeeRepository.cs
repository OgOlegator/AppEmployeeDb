using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppEmployeeDb.Models;

namespace AppEmployeeDb.Repository
{
    public interface IEmloyeeRepository
    {

        Task<IEnumerable<Employee>> GetEmployee();

        Task<Employee> GetEmployeeById(int id);

        Task<Employee> CreateUpdateEmployee(Employee employee);

        Task<bool> DeleteEmployee(int Id);

    }
}
