using Microsoft.EntityFrameworkCore;
using PracticaDobosh.DAL.Context;
using PracticaDobosh.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaDobosh.BLL
{
    internal class EmployeeService
    {
        private readonly EquipmentDbContext _db;

        public EmployeeService(EquipmentDbContext db)
        {
            _db = db;
        }

        public async Task<List<Employee>> GetAllAsync()
        {
            return await _db.Employees
                .Include(e => e.Department)
                .ToListAsync();
        }

        public async Task AddAsync(string fio, string position, int departmentId)
        {
            var emp = new Employee
            {
                FIO = fio,
                Position = position,
                DepartmentId = departmentId
            };
            _db.Employees.Add(emp);
            await _db.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, string fio, string position, int departmentId)
        {
            var emp = await _db.Employees.FindAsync(id);
            if (emp != null)
            {
                if (!string.IsNullOrWhiteSpace(fio)) emp.FIO = fio;
                if (!string.IsNullOrWhiteSpace(position)) emp.Position = position;
                emp.DepartmentId = departmentId;

                await _db.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            var emp = await _db.Employees.FindAsync(id);
            if (emp != null)
            {
                _db.Employees.Remove(emp);
                await _db.SaveChangesAsync();
            }
        }
    }
}
