using Microsoft.EntityFrameworkCore;
using PracticaDobosh.DAL.Context;
using PracticaDobosh.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDobosh.BLL
{
    internal class DepartmentService
    {
        private readonly EquipmentDbContext _db;

        public DepartmentService(EquipmentDbContext db)
        {
            _db = db;
        }
        public async Task<List<Department>> GetAllAsync()
        {
            return await _db.Departments.ToListAsync();
        }

        public async Task UpdateAsync(int id, string newDepName, string newHeadName)
        {
            var dep = await _db.Departments.FindAsync(id);
            if (dep != null)
            {
                if (!string.IsNullOrWhiteSpace(newDepName)) dep.DepartmentName = newDepName;
                if (!string.IsNullOrWhiteSpace(newHeadName)) dep.HeadOfDepartment = newHeadName;

                await _db.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Отдел с таким ID не найден");
            }
        }
        public async Task AddAsync( string newDepName, string newHeadName)
        {
            if (!string.IsNullOrWhiteSpace(newDepName) || !string.IsNullOrWhiteSpace(newHeadName))
            {
                var dep = new Department { DepartmentName = newDepName, HeadOfDepartment = newHeadName };
                _db.Departments.Add(dep);
                await _db.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            var dept = await _db.Departments.FindAsync(id);
            if (dept != null)
            {
                _db.Departments.Remove(dept);
                await _db.SaveChangesAsync();
            }
        }  
    }
}
