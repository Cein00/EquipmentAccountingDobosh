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
    public class EquipmentService
    {
        private readonly EquipmentDbContext _db;

        public EquipmentService()
        {
            _db = new EquipmentDbContext();
        }
        public async Task<List<Equipment>> GetAllEquipmentsAsync()
        {
            return await _db.Equipments
                .Include(e => e.EquipmentType)
                .Include(e => e.ResponsibleEmployee)
                .ToListAsync();
        }

        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return await _db.Employees
                .Include(e => e.Department)
                .ToListAsync();
        }
        public async Task MoveEquipmentAsync(string inventoryNumber, int newEmployeeId)
        {
            var equipment = await _db.Equipments.FindAsync(inventoryNumber);
            if (equipment != null)
            { 
                int? oldEmployeeId = equipment.EmployeeId;

                equipment.EmployeeId = newEmployeeId;

                var history = new MovementHistory
                {
                    MovementDate = System.DateTime.Now,
                    EquipmentInventoryNumber = inventoryNumber,
                    OldEmployeeId = oldEmployeeId,
                    NewEmployeeId = newEmployeeId
                };

                _db.MovementHistories.Add(history);
                await _db.SaveChangesAsync();
            }
        }
    }
}
