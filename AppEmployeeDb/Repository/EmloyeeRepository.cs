using AppEmployeeDb.DbContexts;
using AppEmployeeDb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEmployeeDb.Repository
{
    public class EmloyeeRepository : IEmloyeeRepository
    {
        private readonly ApplicationDbContext _db;

        public EmloyeeRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Employee> CreateUpdateEmployee(Employee employee)
        {
            if(employee.Id > 0)
            {
                _ = _db.Update(employee);
            }
            else
            {
                _db.Employees.Add(employee);
            }

            await _db.SaveChangesAsync();
            return employee;
        }

        public async Task<bool> DeleteEmployee(int id)
        {
            var employee = await _db.Employees.FirstOrDefaultAsync(employee => employee.Id == id);

            if (employee == null)
                return false;

            _db.Employees.Remove(employee);
            await _db.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<Employee>> GetEmployee()
        {
            var listEmployees = await _db.Employees.ToListAsync();
            return listEmployees;
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            var employee = await _db.Employees.FirstOrDefaultAsync(employee => employee.Id == id);
            return employee;
        }
    }
}
